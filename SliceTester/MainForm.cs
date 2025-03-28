﻿using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using Gma.System.MouseKeyHook;
using SliceTester.Classes;

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

        private void GlobalKeyDown(object sender, KeyEventArgs e)
        {
            ref readonly bool recording = ref _macroRecorder.IsRecording();

            if (e.Control && e.KeyCode == Keys.F2)
                btnStop_Click(sender, e);


            if (recording)           
                return;
            

            if (e.Control) // Restante das teclas que só podem ser utilizadas se não estiver gravando.
            {
                switch (e.KeyCode)
                {
                    case Keys.F1:
                        btnRecord_Click(sender, e);
                        break;
                    case Keys.F3:
                        _macroRecorder.Play();
                        break;
                    case Keys.F4:
                        btnClear_Click(sender, e);
                        break;
                    case Keys.F5:
                        btnExportJson_Click(sender, e);
                        break;
                    case Keys.F6:
                        btnImportJson_Click(sender, e);
                        break;
                    case Keys.F7:
                        BtnStartLoop_Click(sender, e);
                        break;
                    case Keys.F8:
                        btnSave_Click(sender, e);
                        break;
                    case Keys.F9:
                        btnEdit_Click(sender, e);
                        break;
                }
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem ao utilizador informando que a gravação começará após a confirmação.
            var result = MessageBox.Show("A gravação vai começar depois do OK", "Iniciar Gravação", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) // Se o utilizador confirmar a ação.
            {
                // Desativa o botão "Record" para evitar cliques repetidos.
                btnRecord.Enabled = false;
                // Inicia o processo de gravação da função.
                _macroRecorder.StartRecording();
                // Ativa o botão Stop.
                btnStop.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém a lista de eventos gravados.
                var recordedEvents = _macroRecorder.GetRecordedEvents();

                // Verifica se há eventos gravados.
                if (recordedEvents.Any())
                {
                    // Pára a gravação dos eventos que estão em curso.
                    _macroRecorder.StopRecording();

                    // Desativa o botão "Stop" pois a gravação foi concluída.
                    btnStop.Enabled = false;

                    // Reativa os outros botões para permitir ações adicionais.
                    btnRecord.Enabled = true;
                    btnPlay.Enabled = true;
                    btnExportJson.Enabled = true;
                    btnClear.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = true;
                    btnStartLoop.Enabled = true;
                    txtLoopBox.Enabled = true;

                    // Atualiza a visualização dos eventos na interface.
                    ViewMacroEventGrid();

                }
                else
                    // Se não houver eventos gravados, lança uma exceção.
                    throw new Exception("A lista de eventos gravados está vazia!");
            }
            catch (Exception ex)
            {
                // Caso ocorra algum erro, registra o erro e exibe uma mensagem.
                _logger.Log($"[ERRO] Falha ao parar a gravação: {ex.Message}");
                MessageBox.Show($"Erro ao parar a gravação:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Exibe uma caixa de mensagem informando ao utilizador que o reply vai começar após o clique em OK.
            var result = MessageBox.Show("A reprodução vai começar depois do OK", "Iniciar Reprodução", MessageBoxButtons.OKCancel);

            // Verifica se o utilizador clicou em OK.
            if (result == DialogResult.OK)
            {
                // Desativa o botão Play.
                btnPlay.Enabled = false;

                // Inicia o replay dos eventos gravados chamando o método Play do objeto macroRecorder.
                _macroRecorder.Play();

                //reativa o botão Play.
                btnPlay.Enabled = true;
            }
            else
            {
                // Caso o usuário cancele a reprodução, registra no log que a reprodução não foi iniciada.
                _logger.Log("[INFO] Reprodução NÃO iniciada.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Verifica se há eventos gravados na lista.
            if (_macroRecorder.GetRecordedEvents().Count > 0)
            {
                // Exibe uma caixa de mensagem perguntando se o utilizador tem certeza de que deseja limpar a lista.
                var result = MessageBox.Show("Tem certeza que deseja limpar a lista de eventos gravados?", "Limpar Eventos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Se o utilizador clicar em "Sim", a lista de eventos será limpa.
                if (result == DialogResult.Yes)
                {
                    // Chama o método ClearEvents para apagar os eventos gravados.
                    _macroRecorder.ClearEvents();

                    // Atualiza a visualização dos eventos na grelha.
                    ViewMacroEventGrid();

                    // Desativa os botões 
                    btnClear.Enabled = false;
                    btnPlay.Enabled = false;
                    btnExportJson.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = false;
                    btnStartLoop.Enabled = false;
                    txtLoopBox.Enabled = false;
                }
            }
            else
            {
                _logger.Log("[INFO] Não tem nada para limpar.");
                MessageBox.Show("Não tem nada para limpar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var events = _macroRecorder.GetRecordedEvents();
            if (events.Count == 0)
            {
                _logger.Log("[INFO] Não há eventos gravados para salvar...");
                MessageBox.Show($"Não há eventos gravados para salvar...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // Chama o método EditRecordedEvents da classe _macroRecorder para permitir a edição dos eventos gravados.
            _macroRecorder.EditRecordedEvents();
        }

        private void BtnStartLoop_Click(object sender, EventArgs e)
        {
            var events = _macroRecorder.GetRecordedEvents();
            if (events.Count == 0)
            {
                _logger.Log("[INFO] Não há eventos gravados para fazer loop...");
                MessageBox.Show($"Não há eventos gravados para fazer loop...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //Um loop que vai repetir as vezes que o utilizador inserio na Variavel.
                for (int i = 0; i < Convert.ToInt32(txtLoopBox.Text); i++)
                {
                    // Desativa o botão replay.
                    btnPlay.Enabled = false;

                    // Chama o método Play da classe _macroRecorder para reproduzir os eventos gravados.
                    _macroRecorder.Play();

                    // Reativa o botão.
                    btnPlay.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                // Caso ocorra um erro ao salvar o arquivo, loga a falha e exibe uma mensagem de erro.
                _logger.Log($"[ERRO] Falha no Loop: {ex.Message}");
                MessageBox.Show($"Erro ao iniciar loop: \n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExportJson_Click(object sender, EventArgs e)
        {

            var events = _macroRecorder.GetRecordedEvents();
            if (events.Count == 0)
            {
                _logger.Log("[INFO] Não há eventos gravados para exportar...");
                MessageBox.Show($"Não há eventos gravados para exportar...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _logger.Log("[INFO] Exportando arquivo JSON...");

            ExportJson();
        }

        private void btnImportJson_Click(object sender, EventArgs e)
        {
            // Regista no log a informação de que o carregamento do arquivo JSON foi iniciado.
            _logger.Log("[INFO] Carregando arquivo JSON...");

            ImportJson();
        }

        // Método chamado quando o utilizador clica no botão "Salvar" para guardar o arquivo.
        private void btnSave_Click(object sender, EventArgs e)
        {
            var events = _macroRecorder.GetRecordedEvents();
            if (events.Count == 0)
            {
                _logger.Log("[INFO] Não há eventos gravados para salvar...");
                MessageBox.Show($"Não há eventos gravados para salvar...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            try
            {
                SaveForm save = new SaveForm();
                save.ShowDialog();  // Exibe a janela de diálogo para o utilizador escolher o nome do arquivo.

                // Obtém o nome do arquivo inserido pelo utilizador.
                string fileName = SaveForm.inputString;

                // Verifica se o nome do arquivo é inválido branco ou nulo.
                if (string.IsNullOrWhiteSpace(fileName))
                {
                    MessageBox.Show("Nome do arquivo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Interrompe a execução se o nome do arquivo for inválido.
                }

                // Garante que o nome do arquivo tenha a extensão json.
                if (!fileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    fileName += ".json";
                }

                // Define o caminho da pasta onde o arquivo será salvo.
                string binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\bin\JsonLogs");
                string fullFilePath = Path.Combine(binPath, fileName);  // Caminho completo do arquivo.

                // Verifica se a pasta existe se não cria.
                if (!Directory.Exists(binPath))
                {
                    Directory.CreateDirectory(binPath);
                }

                // Chama o método SaveEvents da classe _macroRecorder para salvar os eventos no arquivo.
                _macroRecorder.SaveEvents(fullFilePath);
                LoadJsonFiles();
                // Exibe uma mensagem informando o utilizador que o arquivo foi salvo com sucesso.
                MessageBox.Show($"Arquivo salvo com sucesso em:\n{fullFilePath}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Se ocorrer um erro regista o erro no log e exibe uma mensagem ao utilizador.
                _logger.Log($"[ERRO] Falha ao salvar o arquivo: {ex.Message}");
                MessageBox.Show($"Erro ao salvar o arquivo:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListFiles_ItemActivate(object sender, EventArgs e)
        {
            // Verifica se há itens selecionados na listView1.
            if (listFiles.SelectedItems.Count > 0)
            {
                // Obtém o caminho completo do arquivo selecionado.
                string selectedFilePath = listFiles.SelectedItems[0].SubItems[1].Text;

                try
                {
                    // Cria um objeto FileInfo para verificar o tamanho do arquivo selecionado.
                    FileInfo fileInfo = new FileInfo(selectedFilePath);

                    // Se o arquivo estiver vazio, lança uma exceção.
                    if (fileInfo.Length == 0)
                        throw new InvalidOperationException("O arquivo selecionado está vazio.");

                    // Chama o método LoadEvents da classe _macroRecorder para carregar os eventos do arquivo.
                    _macroRecorder.LoadEvents(selectedFilePath);

                    // Atualiza a visualização dos eventos na interface.
                    ViewMacroEventGrid();

                    // Ativa os botões.
                    btnClear.Enabled = true;
                    btnPlay.Enabled = true;
                    btnExportJson.Enabled = true;
                    btnEdit.Enabled = true;
                    btnStartLoop.Enabled = true;
                    btnSave.Enabled = true;
                    txtLoopBox.Enabled = true;


                    // Regista no log que o processo de carregamento foi concluído.
                    _logger.Log("[INFO] Processo de carregamento de arquivo concluído.");

                    // Exibe uma mensagem de sucesso informando o utilizador que o arquivo foi carregado.
                    MessageBox.Show("Arquivo carregado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Se ocorrer um erro ao carregar o arquivo, regista o erro no log e exibe uma mensagem de erro.
                    _logger.Log($"[ERRO] Falha ao carregar o arquivo JSON: {ex.Message}");
                    MessageBox.Show($"Erro ao carregar o arquivo:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadJsonFiles()
        {
            // Obtém o caminho relativo para a pasta "JsonLogs" dentro da pasta bin.
            string binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\bin\JsonLogs");

            // Obtém o caminho completo da pasta
            string directoryPath = Path.GetFullPath(binPath);

            // Limpa o ListView antes de recarregar os arquivos.
            listFiles.Items.Clear();

            // Verifica se a pasta existe.
            if (Directory.Exists(directoryPath))
            {
                try
                {
                    // Obtém todos os arquivos JSON na pasta especificada.
                    string[] jsonFiles = Directory.GetFiles(directoryPath, "*.json");

                    // Itera através dos arquivos e os adiciona ao ListView.
                    foreach (string file in jsonFiles)
                    {
                        // Obtém o nome do arquivo.
                        string fileName = Path.GetFileName(file);
                        string filePath = file;

                        // Adiciona o arquivo ao ListView incluindo o caminho completo.
                        ListViewItem item = new ListViewItem(fileName)
                        {
                            SubItems = { filePath } // Adiciona o caminho completo do arquivo.
                        };
                        listFiles.Items.Add(item); // Adiciona o item à ListView.
                    }

                    // Se não houver arquivos encontrados informa o utilizador.
                    if (jsonFiles.Length == 0)
                    {
                        MessageBox.Show("Nenhum arquivo JSON encontrado na pasta especificada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // Se ocorrer um erro ao tentar carregar os arquivos, exibe uma mensagem de erro.
                    MessageBox.Show($"Erro ao carregar os arquivos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Caso a pasta não exista, exibe uma mensagem de erro.
                MessageBox.Show("A pasta especificada não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateAppFolder()
        {
            // Garante que o caminho está sempre a apontar para a pasta bin correta.
            string binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\bin\JsonLogs");

            // Obtém o caminho absoluto da pasta.
            string jsonLogsPath = Path.GetFullPath(binPath);


            // Cria a pasta se não existir.
            if (!Directory.Exists(jsonLogsPath))
            {
                Directory.CreateDirectory(jsonLogsPath);
                // Exibe uma mensagem indicando que a pasta foi criada.
                MessageBox.Show("Pasta criada em: " + jsonLogsPath);
            }
        }

        private void loadDataGridConfig()
        {
            // Obter a GridView associada ao GridControl.
            var gridView = gridViewer.MainView as GridView;

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
            gridViewer.DataSource = _macroRecorder.GetRecordedEvents();

            // Recarrega os dados na grid para refletir as alterações.
            gridViewer.RefreshDataSource(); // Garante que os dados sejam recarregados corretamente.
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Chama o método que carrega os arquivos JSON na interface.
            LoadJsonFiles();
        }

        private void ImportJson()
        {
            // Cria uma instância de OpenFileDialog para permitir ao utilizador selecionar o arquivo JSON a carregar.
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Define o filtro para mostrar apenas arquivos JSON ou todos os arquivos
                openFileDialog.Filter = "Arquivos JSON (*.json)|*.json|Todos os Arquivos (*.*)|*.*";
                openFileDialog.Title = "Carregar Macro";  // Define o título da janela de abrir arquivo.

                // Exibe a caixa de diálogo de abrir arquivo e verifica se o utilizador escolheu um arquivo (clicou em "OK").
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Cria um objeto FileInfo para verificar o tamanho do arquivo selecionado.
                        FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                        // Se o arquivo estiver vazio lança uma exceção.
                        if (fileInfo.Length == 0)
                            throw new InvalidOperationException("O arquivo selecionado está vazio.");

                        // Chama o método LoadEvents da classe _macroRecorder para carregar os eventos gravados do arquivo selecionado.
                        _macroRecorder.LoadEvents(openFileDialog.FileName);

                        // Atualiza a visualização dos eventos na interface.
                        ViewMacroEventGrid();

                        // Ativa os botões .
                        btnClear.Enabled = true;
                        btnPlay.Enabled = true;
                        btnExportJson.Enabled = true;
                        btnEdit.Enabled = true;
                        btnSave.Enabled = true;
                        btnStartLoop.Enabled = true;
                        txtLoopBox.Enabled = true;


                        // Regista no log que o processo de carregamento foi concluído com sucesso.
                        _logger.Log("[INFO] Processo de carregamento de arquivo concluído.");

                        // Exibe uma mensagem de sucesso informando o utilizador de que o arquivo foi carregado com sucesso.
                        MessageBox.Show("Arquivo carregado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Se ocorrer um erro ao carregar o arquivo, regista a falha no log e exibe uma mensagem de erro.
                        _logger.Log($"[ERRO] Falha ao carregar o arquivo JSON: {ex.Message}");
                        MessageBox.Show($"Erro ao carregar o arquivo:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Se o utilizador não selecionar nenhum arquivo (clicou em "Cancelar"), regista no log e exibe uma mensagem de aviso.
                    _logger.Log("[INFO] Nenhum arquivo selecionado.");
                    MessageBox.Show("Nenhum arquivo selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ExportJson()
        {
            // Cria uma instância de SaveFileDialog para permitir ao utilizador escolher o local e nome do arquivo para salvar.
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Define o filtro para mostrar apenas arquivos JSON ou todos os arquivos
                saveFileDialog.Filter = "Arquivos JSON (*.json)|*.json|Todos os Arquivos (*.*)|*.*";
                saveFileDialog.Title = "Salvar Macro";  // Define o título da janela de salvar.
                saveFileDialog.FileName = "Nome.json";  // Define o nome padrão para o arquivo como "Nome.json".

                // Exibe a caixa de diálogo de salvar e verifica se o utilizador clicou em "OK".
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Chama o método SaveEvents da classe _macroRecorder para salvar os eventos gravados no arquivo selecionado.
                        _macroRecorder.SaveEvents(saveFileDialog.FileName);

                        // Exibe uma mensagem de sucesso informando o utilizador de que o arquivo foi salvo com sucesso.
                        MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Caso ocorra um erro ao salvar o arquivo, loga a falha e exibe uma mensagem de erro.
                        _logger.Log($"[ERRO] Falha ao salvar o arquivo: {ex.Message}");
                        MessageBox.Show($"Erro ao salvar o arquivo:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Caso o utilizador não escolha um local para salvar, loga a informação e exibe uma mensagem de aviso.
                    _logger.Log("[INFO] o arquivo não foi salvo.");
                    MessageBox.Show("O arquivo não foi salvo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void GlobalHotkeys()
        {
            // Regista o hook global para captura de eventos de teclas.
            _hook = Hook.GlobalEvents(); // Captura teclas globalmente.

            // Associa o evento de tecla pressionada ao método GlobalKeyDown.
            _hook.KeyDown += GlobalKeyDown;
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
                _hook.Dispose(); // Libera o hook.
        }
    }
}