using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using Gma.System.MouseKeyHook;
using SliceTester.Classes;
using System.Drawing;

namespace SliceTester
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private LogManager _logger;
        private MacroRecorder _macroRecorder;
        private IKeyboardMouseEvents _hook;

        public MainForm()
        {
            CreateAppFolder();
            InitializeComponent();
            _logger = new LogManager(txtLog);
            _macroRecorder = new MacroRecorder(_logger);
            GlobalHotkeys();
            LoadJsonFiles();

        }

        // Mouse drag logic
        private bool isDragging = false;
        private Point lastLocation;

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void TitleBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void TitleBarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }


        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GlobalKeyDown(object sender, KeyEventArgs e)
        {
            ref readonly bool recording = ref _macroRecorder.IsRecording();

            if (e.Control && e.KeyCode == Keys.F2)
                StopTest();

            if (recording)
                return;


            if (e.Control) // Restante das teclas que só podem ser utilizadas se não estiver gravando.
            {
                switch (e.KeyCode)
                {
                    case Keys.F1:
                        RecordTest();
                        break;
                    case Keys.F3:
                        PlayTest();
                        break;
                    case Keys.F4:
                        ClearTest();
                        break;
                    case Keys.F5:
                        ExportJson();
                        break;
                    case Keys.F6:
                        ImportJson();
                        break;
                    case Keys.F7:
                        SaveTestInDirectory();
                        break;
                    case Keys.F8:
                        ModifyTest();
                        break;
                }
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            RecordTest();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopTest();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayTest();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTest();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyTest();
        }


        private void btnExportJson_Click(object sender, EventArgs e)
        {
            ExportJson();
        }

        private void btnImportJson_Click(object sender, EventArgs e)
        {
            ImportJson();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveTestInDirectory();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadJsonFiles();
        }

        private void btnExportLog_Click(object sender, EventArgs e)
        {
            if(txtLog.Lines.Length > 0)
            _logger.ExportLogToFile();
        }

        private void btnDeleteTest_Click(object sender, EventArgs e)
        {
            DeleteTest();
        }

        private void btnRenameTest_Click(object sender, EventArgs e)
        {
            RenameTest();
        }

        private void ListFiles_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                string selectedFilePath;

                // Obtém o caminho completo do ficheiro selecionado.
                selectedFilePath = listFiles.SelectedItems[0].SubItems[1].Text;

                // Cria um objeto FileInfo para verificar o tamanho do ficheiro selecionado.
                FileInfo fileInfo = new FileInfo(selectedFilePath);

                // Se o ficheiro estiver vazio, lança uma exceção.
                if (fileInfo.Length == 0)
                    throw new InvalidOperationException("O ficheiro selecionado está vazio.");

                // Chama o método LoadEvents da classe _macroRecorder para carregar os eventos do ficheiro.
                _macroRecorder.LoadEvents(selectedFilePath);

                // Atualiza a visualização dos eventos na interface.
                ViewMacroEventGrid();

                EnableButtons();

                // Regista no log que o processo de carregamento foi concluído.
                _logger.Log("[INFO] Processo de carregamento de ficheiro concluído.");
            }
            catch (Exception ex)
            {
                // Se ocorrer um erro ao carregar o ficheiro, regista o erro no log e exibe uma mensagem de erro.
                _logger.Log($"[ERROR] Falha ao carregar o ficheiro JSON: {ex.Message}");
                MessageBox.Show($"Erro ao carregar o ficheiro:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _hook.Dispose();
        }

        private void LoadJsonFiles()
        {
            try
            {
                // Obtém o caminho relativo para a pasta "MacroFiles" dentro da pasta bin.
                string binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\bin\MacroFiles");

                // Obtém o caminho completo da pasta
                string directoryPath = Path.GetFullPath(binPath);

                // Limpa o ListView antes de recarregar os ficheiros.
                listFiles.Items.Clear();

                // Obtém todos os ficheiros JSON na pasta especificada.
                string[] jsonFiles = Directory.GetFiles(directoryPath, "*.json");

                // Itera através dos ficheiros e os adiciona ao ListView.
                foreach (string file in jsonFiles)
                {
                    // Obtém o nome do ficheiro.
                    string fileName = Path.GetFileName(file);
                    string filePath = file;

                    // Adiciona o ficheiro ao ListView incluindo o caminho completo.
                    ListViewItem item = new ListViewItem(fileName)
                    {
                        SubItems = { filePath } // Adiciona o caminho completo do ficheiro.
                    };
                    listFiles.Items.Add(item); // Adiciona o item à ListView.
                }

                // Se não houver ficheiros encontrados informa o utilizador.
                if (jsonFiles.Length == 0)
                    MessageBox.Show("Nenhum ficheiro JSON encontrado na pasta especificada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                _logger.Log($"[ERROR] (LOAD): {ex.Message}");
                MessageBox.Show($"Erro ao carregar os ficheiros: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateAppFolder()
        {
            try
            {
                // Garante que o caminho está sempre a apontar para a pasta bin correta.
                string binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\bin\MacroFiles"); ;

                // Obtém o caminho absoluto da pasta.
                string macroFilesPath = Path.GetFullPath(binPath);


                // Cria a pasta se não existir.
                if (!Directory.Exists(macroFilesPath))
                {
                    Directory.CreateDirectory(macroFilesPath);
                    // Exibe uma mensagem indicando que a pasta foi criada.
                    MessageBox.Show("Pasta criada em: " + macroFilesPath);
                }
            }
            catch (Exception ex)
            {
                _logger.Log($"[ERROR] Falha ao criar pasta: {ex.Message}");
                MessageBox.Show($"Falha ao criar pasta:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loadDataGridConfig()
        {
            // Obter a GridView associada ao GridControl.
            var gridView = gridControl.MainView as GridView;

            // Verifica se a GridView foi obtida corretamente.
            if (gridView != null)
            {
                // Definir os nomes das colunas a serem configuradas.
                string[] columns = { "EventType", "Key", "MouseButton", "Timestamp" };

                // Iterar pelas colunas e desabilitar a ordenação.
                foreach (var columnName in columns)
                {
                    // Obter a coluna correspondente
                    var eventTypeColumn = gridView.Columns[columnName];

                    // Se a coluna existir, desabilitar a ordenação.
                    if (eventTypeColumn != null)
                        eventTypeColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                }
            }
        }

        private void ViewMacroEventGrid()
        {
            // Configura as colunas e propriedades da GridView.
            loadDataGridConfig();

            // Atribui a lista de eventos gravados como fonte de dados para a grid
            gridControl.DataSource = _macroRecorder.GetRecordedEvents();

            // Recarrega os dados na grid para refletir as alterações.
            gridControl.RefreshDataSource(); // Garante que os dados sejam recarregados corretamente.
        }

        private void RecordTest()
        {
            try
            {
                // Exibe uma mensagem ao utilizador informando que a gravação começará após a confirmação.
                var result = MessageBox.Show("A gravação vai começar depois do OK", "Iniciar Gravação", MessageBoxButtons.OKCancel);

                if (result != DialogResult.OK) // Se o utilizador confirmar a ação.
                {
                    _logger.Log("[INFO] Gravação cancelada.");
                    return;
                }

                WindowState = FormWindowState.Minimized;
                // Desativa o botão "Record" para evitar cliques repetidos.
                btnRecord.Enabled = false;
                // Inicia o processo de gravação da função.
                _macroRecorder.StartRecording();
                // Ativa o botão Stop.
                btnStop.Enabled = true;
            }
            catch (Exception ex)
            {
                _logger.Log($"[ERROR] (RECORD): {ex.Message}");
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void StopTest()
        {
            try
            {
                ref readonly bool recording = ref _macroRecorder.IsRecording();

                // Obtém a lista de eventos gravados.
                var recordedEvents = _macroRecorder.GetRecordedEvents();

                if (recording == false)
                    throw new InvalidOperationException("Não há gravação em curso.");


                // Pára a gravação dos eventos que estão em curso.
                _macroRecorder.StopRecording();

                WindowState = FormWindowState.Normal;

                // Desativa o botão "Stop" pois a gravação foi concluída.
                btnStop.Enabled = false;

                // Reativa os outros botões para permitir ações adicionais.
                btnRecord.Enabled = true;
                EnableButtons();

                // Atualiza a visualização dos eventos na interface.
                ViewMacroEventGrid();
            }
            catch (Exception ex)
            {
                // Caso ocorra algum erro, registra o erro e exibe uma mensagem.
                _logger.Log($"[ERROR] (STOP): {ex.Message}");
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlayTest()
        {
            try
            {
                var events = _macroRecorder.GetRecordedEvents();

                if (events.Count == 0)
                    throw new Exception("Não há eventos gravados para reproduzir.");

                // Exibe uma caixa de mensagem informando ao utilizador que o reply vai começar após o clique em OK.
                var result = MessageBox.Show("A reprodução vai começar depois do OK", "Iniciar Reprodução", MessageBoxButtons.OKCancel);

                // Verifica se o utilizador clicou em OK.
                if (result != DialogResult.OK)
                {
                    // Caso o utilizador cancele a reprodução, registra no log que a reprodução não foi iniciada.
                    _logger.Log("[CANCEL] Reprodução cancelada.");

                    return;
                }

                WindowState = FormWindowState.Minimized;

                for (int i = 0; i < NumLoopBox.Value; i++)
                {
                    btnPlay.Enabled = false;
                    _macroRecorder.Play();
                    btnPlay.Enabled = true;
                }

                WindowState = FormWindowState.Normal;
            }
            catch (Exception ex)
            {
                _logger.Log($"[ERROR] (PLAY): {ex.Message}");
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTest()
        {
            try
            {
                if (_macroRecorder.GetRecordedEvents().Count == 0)
                    throw new InvalidOperationException("Não há eventos gravados para limpar.");

                // Exibe uma caixa de mensagem perguntando se o utilizador tem certeza de que deseja limpar a lista.
                var result = MessageBox.Show("Tem certeza que deseja limpar a lista de eventos gravados?", "Limpar Eventos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Se o utilizador clicar em "Sim", a lista de eventos será limpa.
                if (result == DialogResult.Yes)
                {
                    // Chama o método ClearEvents para apagar os eventos gravados.
                    _macroRecorder.ClearEvents();

                    // Atualiza a visualização dos eventos na grelha.
                    ViewMacroEventGrid();

                    DisableButtons();
                }
            }
            catch (Exception ex)
            {
                _logger.Log($"[ERROR] (CLEAR): {ex.Message}");
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModifyTest()
        {
            try
            {
                var events = _macroRecorder.GetRecordedEvents();
                if (events.Count == 0)
                    throw new InvalidOperationException("Não há eventos gravados para modificar.");

                _logger.Log("[INFO] Janela de edição aberta.");
                // Chama o método EditRecordedEvents da classe _macroRecorder para permitir a edição dos eventos gravados.
                _macroRecorder.EditRecordedEvents();
                loadDataGridConfig();
            }
            catch (Exception ex)
            {
                _logger.Log($"[ERROR] (MODIFY): {ex.Message}");
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTest()
        {
            try
            {
                string selectedFilePath;

                if (listFiles.Items.Count == 0)
                    throw new InvalidOperationException("Nenhum ficheiro na lista.");

                // Verifica se há um ficheiro selecionado na lista.
                if (listFiles.SelectedItems.Count == 0)
                    throw new InvalidOperationException("Nenhum ficheiro selecionado.");

                selectedFilePath = listFiles.SelectedItems[0].SubItems[1].Text; ;

                // Solicita confirmação do utilizador antes de excluir o ficheiro.
                DialogResult result = MessageBox.Show("Tem certeza de que deseja apagar este ficheiro?", "Confirmar Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                {
                    _logger.Log("[CANCEL] Operação de deletar cancelada.");
                    return;
                }


                // Exclui o ficheiro.
                File.Delete(selectedFilePath);
                _logger.Log($"[INFO] Arquivo apagado: {selectedFilePath}");
                MessageBox.Show("Arquivo apagado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Remove o item da ListView.
                listFiles.Items.Remove(listFiles.SelectedItems[0]);
            }
            catch (Exception ex)
            {
                // Registra erro no log e exibe uma mensagem de erro ao usuário.
                _logger.Log($"[ERROR] (DELFILE): {ex.Message}");
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenameTest()
        {
            try
            {
                // Verifica se há um ficheiro selecionado na lista
                string selectedFilePath;
                string directory;
                string currentFileName;
                string newFileName;
                string newFilePath;

                if (listFiles.Items.Count == 0)
                    throw new InvalidOperationException("Nenhum ficheiro na lista.");

                if (listFiles.SelectedItems.Count == 0)
                    throw new InvalidOperationException("Nenhum ficheiro selecionado.");

                selectedFilePath = listFiles.SelectedItems[0].SubItems[1].Text;
                directory = Path.GetDirectoryName(selectedFilePath);
                currentFileName = Path.GetFileName(selectedFilePath);

                // Cria uma instância do formulário de renomeação que é o mesmo que salva.
                SaveForm renameForm = new SaveForm();

                if (renameForm.ShowDialog() != DialogResult.OK)
                {
                    _logger.Log("Operação de renomear cancelada.");
                    return;
                }

                newFileName = renameForm.fileName;

                // Define o nome do ficheiro atual no campo de texto (txtSaveFile) do SaveForm.
                renameForm.fileName = currentFileName;

                if (string.IsNullOrWhiteSpace(newFileName))
                    throw new InvalidOperationException("Nome do ficheiro inválido.");


                newFilePath = Path.Combine(directory, newFileName);

                // Renomeia o ficheiro
                File.Move(selectedFilePath, newFilePath);
                _logger.Log($"[INFO] Arquivo renomeado de {selectedFilePath} para {newFilePath}");
                MessageBox.Show("Arquivo renomeado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza o item na ListView
                listFiles.SelectedItems[0].SubItems[1].Text = newFilePath;
                listFiles.SelectedItems[0].Text = newFileName; // Assume que a primeira coluna contém o nome do ficheiro.

            }
            catch (Exception ex)
            {
                // AVISO.

                _logger.Log($"[ERROR] (RENAME): {ex.Message}");
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveTestInDirectory()
        {
            try
            {
                SaveForm save = new SaveForm();

                string fileName;
                string binPath;
                string fullFilePath;

                var events = _macroRecorder.GetRecordedEvents();

                if (events.Count == 0)
                    throw new InvalidOperationException("Não há eventos gravados para salvar.");

                _logger.Log("[INFO] Salvando arquivo JSON...");

                if (save.ShowDialog() != DialogResult.OK)
                {
                    // AVISO.

                    _logger.Log("[CANCEL] Operação de Salvar cancelada.");
                    return;
                }

                fileName = save.fileName;

                // Garante que o nome do arquivo tenha a extensão json.
                if (!fileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                    fileName += ".json";

                // Define o caminho da pasta onde o arquivo será salvo.
                binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\bin\MacroFiles");
                fullFilePath = Path.Combine(binPath, fileName);  // Caminho completo do arquivo.

                // Verifica se a pasta existe se não cria.
                if (!Directory.Exists(binPath))
                    Directory.CreateDirectory(binPath);


                // Chama o método SaveEvents da classe _macroRecorder para salvar os eventos no arquivo.
                _macroRecorder.SaveEvents(fullFilePath);

                LoadJsonFiles();

                // CONFIRMAÇÃO.

                _logger.Log($"[INFO] Arquivo salvo em: {fullFilePath}");
                MessageBox.Show($"Arquivo salvo com sucesso em:\n{fullFilePath}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _logger.Log($"[ERROR] (SAVE): {ex.Message}");
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImportJson()
        {
            try
            {
                _logger.Log("[INFO] Carregando ficheiros JSON...");

                // Cria uma instância de OpenFileDialog para permitir ao utilizador selecionar o ficheiro JSON a carregar.
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    // Define o filtro para mostrar apenas ficheiros JSON ou todos os ficheiros
                    openFileDialog.Filter = "ficheiros JSON (*.json)|*.json|Todos os ficheiros (*.*)|*.*";
                    openFileDialog.Title = "Carregar Macro";  // Define o título da janela de abrir ficheiro.


                    if (openFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        // Se o utilizador não selecionar nenhum ficheiro (clicou em "Cancelar"), regista no log e exibe uma mensagem de aviso.
                        _logger.Log("[INFO] Nenhum ficheiro selecionado.");
                        MessageBox.Show("Nenhum ficheiro selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Cria um objeto FileInfo para verificar o tamanho do ficheiro selecionado.
                    FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                    // Se o ficheiro estiver vazio lança uma exceção.
                    if (fileInfo.Length == 0)
                        throw new InvalidOperationException("O ficheiro selecionado está vazio.");

                    // Chama o método LoadEvents da classe _macroRecorder para carregar os eventos gravados do ficheiro selecionado.
                    _macroRecorder.LoadEvents(openFileDialog.FileName);

                    // Atualiza a visualização dos eventos na interface.
                    ViewMacroEventGrid();

                    EnableButtons();

                    // CONFIRMAÇÃO.

                    _logger.Log($"[INFO] Processo de carregamento do ficheiro concluído: {openFileDialog.FileName}");
                    MessageBox.Show("Ficheiro carregado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                _logger.Log($"[ERROR] (IMPORT): {ex.Message}");
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportJson()
        {
            try
            {
                var events = _macroRecorder.GetRecordedEvents();
                if (events.Count == 0)
                    throw new InvalidOperationException("Não há eventos gravados para exportar.");

                _logger.Log("[INFO] Exportando ficheiro JSON...");

                // Cria uma instância de SaveFileDialog para permitir ao utilizador escolher o local e nome do ficheiro para salvar.
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    // Define o filtro para mostrar apenas ficheiros JSON ou todos os ficheiros
                    saveFileDialog.Filter = "ficheiros JSON (*.json)|*.json|Todos os ficheiros (*.*)|*.*";
                    saveFileDialog.Title = "Salvar Macro";  // Define o título da janela de salvar.
                    saveFileDialog.FileName = "Nome.json";  // Define o nome padrão para o ficheiro como "Nome.json".


                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        _logger.Log("[CANCEL] Operação de exportar cancelada.");
                        return;
                    }



                    // Chama o método SaveEvents da classe _macroRecorder para salvar os eventos gravados no ficheiro selecionado.
                    _macroRecorder.SaveEvents(saveFileDialog.FileName);

                    // CONFIRMAÇÃO.
                    _logger.Log($"[INFO] Eventos gravados salvos em {saveFileDialog.FileName}");
                    MessageBox.Show($"Ficheiro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Caso ocorra um erro ao salvar o ficheiro, loga a falha e exibe uma mensagem de erro.
                _logger.Log($"[ERROR] (EXPORT): {ex.Message}");
                MessageBox.Show($"{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GlobalHotkeys()
        {
            // Regista o hook global para captura de eventos de teclas.
            _hook = Hook.GlobalEvents(); // Captura teclas globalmente.

            // Associa o evento de tecla pressionada ao método GlobalKeyDown.
            _hook.KeyDown += GlobalKeyDown;
        }

        private void DisableButtons()
        {
            btnClear.Enabled = false;
            btnPlay.Enabled = false;
            btnExportJson.Enabled = false;
            btnModify.Enabled = false;
            btnSave.Enabled = false;
            NumLoopBox.Enabled = false;
        }

        private void EnableButtons()
        {
            btnClear.Enabled = true;
            btnPlay.Enabled = true;
            btnExportJson.Enabled = true;
            btnModify.Enabled = true;
            btnSave.Enabled = true;
            NumLoopBox.Enabled = true;
        }
    }
}