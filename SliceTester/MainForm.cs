using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
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
            InitializeComponent();
            _logger = new LogManager(txtLog);
            _macroRecorder = new MacroRecorder(_logger);
            GlobalHotkeys(); 
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
                    btnClear.Enabled = false;
                    btnPlay.Enabled = false;
                    btnSaveJson.Enabled = false;
                    btnEdit.Enabled = false;
                }
            }
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivos JSON (*.json)|*.json|Todos os Arquivos (*.*)|*.*";
                saveFileDialog.Title = "Salvar Macro";
                saveFileDialog.FileName = "macro.json";

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
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