using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;
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
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                case Keys.F1:
                    btnRecord_Click(sender, e);
                    break;
                case Keys.F2:
                    btnStop_Click(sender, e);                        
                    break;
                case Keys.F3:
                    btnPlay_Click(sender, e);
                    break;
                case Keys.F4:
                    btnClear_Click(sender, e);
                    break;
                case Keys.F5:
                    btnSaveJson_Click(sender, e);
                    break;
                case Keys.F6:
                    btnLoadJson_Click(sender, e);
                    break;
                }
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("A gravação vai começar depois do OK", "Iniciar Gravação", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                btnRecord.Enabled = false;
                _macroRecorder.StartRecording();
                btnStop.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            { 
                var recordedEvents = _macroRecorder.GetRecordedEvents();
                if (recordedEvents.Any())
                {
                    _macroRecorder.StopRecording();
                    btnStop.Enabled = false;
                    btnRecord.Enabled = true;
                    btnPlay.Enabled = true;
                    btnSaveJson.Enabled = true;
                    btnClear.Enabled = true;
                    btnEdit.Enabled = true;
                }
                else
                    throw new Exception("A lista de eventos gravados está vázia!");

            }
            catch(Exception ex)
            {
                _logger.Log($"[ERRO] Falha ao parar a gravação: {ex.Message}");
                MessageBox.Show($"Erro ao parar a gravação:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("A reprodução vai começar depois do OK", "Iniciar Reprodução", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                btnPlay.Enabled = false;
                _macroRecorder.Play();
                btnPlay.Enabled = true;
            }
            else
                _logger.Log("[INFO] Reprodução NÃO iniciada.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (_macroRecorder.GetRecordedEvents().Count > 0)
            {
                var result = MessageBox.Show("Tem certeza que deseja limpar a lista de eventos gravados?", "Limpar Eventos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    _macroRecorder.ClearEvents();
                    ViewMacroEventGrid();


                    btnClear.Enabled = false;
                    btnPlay.Enabled = false;
                    btnSaveJson.Enabled = false;
                    btnEdit.Enabled = false;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            macroRecorder.EditRecordedEvents();
        }

        private void BtnStartLoop_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Loop.num; i++)
            {
                btnPlay.Enabled = false;
                macroRecorder.Play();
                btnPlay.Enabled = true;
            }
        }

        private void btnCreateLoop_Click(object sender, EventArgs e)
        {
            Loop loop = new Loop();
            loop.Show();
            using (var form = new Loop())
            {
                int IntLoop = Loop.num;
            }
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivos JSON (*.json)|*.json|Todos os Arquivos (*.*)|*.*";
                saveFileDialog.Title = "Salvar Macro";
                saveFileDialog.FileName = "Nome.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _macroRecorder.SaveEvents(saveFileDialog.FileName);
                        MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        _logger.Log($"[ERRO] Falha ao salvar o arquivo: {ex.Message}");
                        MessageBox.Show($"Erro ao salvar o arquivo:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    _logger.Log("[INFO] o arquivo não foi salvo.");
                    MessageBox.Show("O arquivo não foi salvo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            _logger.Log("[INFO] Carregando arquivo JSON...");

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos JSON (*.json)|*.json|Todos os Arquivos (*.*)|*.*";
                openFileDialog.Title = "Carregar Macro";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Verifica se o arquivo está vazio.
                        FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                        if (fileInfo.Length == 0)
                            throw new InvalidOperationException("O arquivo selecionado está vazio.");

                        _macroRecorder.LoadEvents(openFileDialog.FileName);

                        ViewMacroEventGrid();

                        btnClear.Enabled = true;
                        btnPlay.Enabled = true;
                        btnSaveJson.Enabled = true;
                        btnEdit.Enabled = true;

                        _logger.Log("[INFO] Processo de carregamento de arquivo concluído.");
                        MessageBox.Show("Arquivo carregado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception ex)
                    {
                        _logger.Log($"[ERRO] Falha ao carregar o arquivo JSON: {ex.Message}");
                        MessageBox.Show($"Erro ao carregar o arquivo:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    _logger.Log("[INFO] Nenhum arquivo selecionado.");
                    MessageBox.Show("Nenhum arquivo selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the save form is opened to get the input string
                Save save = new Save();
                save.ShowDialog(); // Ensure this runs modally so inputString is set before continuing

                // Get the filename from the Save form
                string fileName = Save.inputString;
                if (string.IsNullOrWhiteSpace(fileName))
                {
                    MessageBox.Show("Nome do arquivo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure the filename has .json extension
                if (!fileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    fileName += ".json";
                }

                // Define the save path (relative to the bin folder)
                string binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\bin\JsonLogs");
                string fullFilePath = Path.Combine(binPath, fileName);

                // Ensure the directory exists
                if (!Directory.Exists(binPath))
                {
                    Directory.CreateDirectory(binPath);
                }

                // Save the macro
                macroRecorder.SaveEvents(fullFilePath);
                MessageBox.Show($"Arquivo salvo com sucesso em:\n{fullFilePath}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                logger.Log($"[ERRO] Falha ao salvar o arquivo: {ex.Message}");
                MessageBox.Show($"Erro ao salvar o arquivo:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedFilePath = listView1.SelectedItems[0].SubItems[1].Text;

                try
                {
                    FileInfo fileInfo = new FileInfo(selectedFilePath);
                    if (fileInfo.Length == 0)
                        throw new InvalidOperationException("O arquivo selecionado está vazio.");

                    macroRecorder.LoadEvents(selectedFilePath);

                    ViewMacroEventGrid();

                    btnClear.Enabled = true;
                    btnPlay.Enabled = true;
                    btnSaveJson.Enabled = true;
                    btnEdit.Enabled = true;

                    logger.Log("[INFO] Processo de carregamento de arquivo concluído.");
                    MessageBox.Show("Arquivo carregado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    logger.Log($"[ERRO] Falha ao carregar o arquivo JSON: {ex.Message}");
                    MessageBox.Show($"Erro ao carregar o arquivo:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadJsonFiles()
        {
            // Dynamically get the path for the JsonLogs folder
            string binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\bin\JsonLogs");

            // Get the absolute full path
            string directoryPath = Path.GetFullPath(binPath);

            // Clear the ListView before reloading files
            listView1.Items.Clear();

            // Check if the directory exists
            if (Directory.Exists(directoryPath))
            {
                try
                {
                    // Get all JSON files in the specified directory
                    string[] jsonFiles = Directory.GetFiles(directoryPath, "*.json");

                    // Loop through the files and add them to the ListView
                    foreach (string file in jsonFiles)
                    {
                        string fileName = Path.GetFileName(file);
                        string filePath = file;

                        // Add the file to the ListView with its full path
                        ListViewItem item = new ListViewItem(fileName)
                        {
                            SubItems = { filePath }
                        };
                        listView1.Items.Add(item);
                    }

                    // If no files found, inform the user
                    if (jsonFiles.Length == 0)
                    {
                        MessageBox.Show("No JSON files found in the specified directory.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The specified directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateAppFolder()
        {
            // Ensure the path is always pointing to the correct bin folder
            string binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\bin\JsonLogs");

            // Get the absolute full path
            string jsonLogsPath = Path.GetFullPath(binPath);

            // Create the folder if it does not exist
            if (!Directory.Exists(jsonLogsPath))
            {
                Directory.CreateDirectory(jsonLogsPath);
                MessageBox.Show("Folder created at: " + jsonLogsPath);
            }
        }


        private void loadDataGridConfig()
        {
            // Obter a GridView associada ao GridControl.
            var gridView = gridViewer.MainView as GridView;

            if (gridView != null)
            {
                // Nome das colunas.
                string[] columns = { "EventType", "Key", "MouseButton", "Timestamp" };

                foreach (var columnName in columns)
                {
                    var eventTypeColumn = gridView.Columns[columnName];

                    // Desabilitar o sort para essa coluna.
                    if (eventTypeColumn != null)
                        eventTypeColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                }
            }
        }

        private void ViewMacroEventGrid()
        {
            loadDataGridConfig();
            gridViewer.DataSource = macroRecorder.GetRecordedEvents();
            gridViewer.RefreshDataSource(); // Garante que os dados sejam recarregados corretamente.
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadJsonFiles();
            _macroRecorder.EditRecordedEvents();
        }

        private void GlobalHotkeys() // Regista os atalhos globais.
        {
            _hook = Hook.GlobalEvents(); // Captura teclas globalmente.
            _hook.KeyDown += GlobalKeyDown;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_hook != null)         
                _hook.Dispose(); // Libera o hook se estiver inicializado.           
        }
    }
}