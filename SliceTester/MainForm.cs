using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using SliceTester.Classes;

namespace SliceTester
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private LogManager logger;
        private MacroRecorder macroRecorder;

        private bool isF1Pressed = false;
        private bool isF2Pressed = false;
        private bool isF3Pressed = false;
        private bool isF4Pressed = false;
        private bool isF5Pressed = false;
        private bool isF6Pressed = false;

        public MainForm()
        {
            InitializeComponent();
            logger = new LogManager(txtLog);
            macroRecorder = new MacroRecorder(logger);
            this.KeyPreview = true; 
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    isF1Pressed = true;
                    btnRecord_Click(sender, e);
                    break;
                case Keys.F2:
                    isF2Pressed = true;
                    btnStop_Click(sender, e);
                    break;
                case Keys.F3:
                    isF3Pressed = true;
                    btnPlay_Click(sender, e);
                    break;
                case Keys.F4:
                    isF4Pressed = true;
                    btnClear_Click(sender, e);
                    break;
                case Keys.F5:
                    isF5Pressed = true;
                    btnSaveJson_Click(sender, e);
                    break;
                case Keys.F6:
                    isF6Pressed = true;
                    btnLoadJson_Click(sender, e);
                    break;
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("A gravação vai começar depois do OK", "Iniciar Gravação", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                btnRecord.Enabled = false;
                macroRecorder.StartRecording();
                btnStop.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            macroRecorder.StopRecording();
            btnStop.Enabled = false;
            btnRecord.Enabled = true;
            btnPlay.Enabled = true;
            btnSaveJson.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("A reprodução vai começar depois do OK", "Iniciar Reprodução", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                btnPlay.Enabled = false;
                macroRecorder.Play();
                btnPlay.Enabled = true;
            }
            else
                logger.Log("[INFO] Reprodução NÃO iniciada.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (macroRecorder.GetRecordedEvents().Count > 0)
            {
                var result = MessageBox.Show("Tem certeza que deseja limpar a lista de eventos gravados?", "Limpar Eventos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    macroRecorder.ClearEvents();
                    btnClear.Enabled = false;
                    btnPlay.Enabled = false;
                    btnSaveJson.Enabled = false;
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
                        macroRecorder.SaveEvents(saveFileDialog.FileName);
                        MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        logger.Log($"[ERRO] Falha ao salvar o arquivo: {ex.Message}");
                        MessageBox.Show($"Erro ao salvar o arquivo:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    logger.Log("[INFO] o arquivo não foi salvo.");
                    MessageBox.Show("O arquivo não foi salvo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            logger.Log("[INFO] Carregando arquivo JSON...");

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos JSON (*.json)|*.json|Todos os Arquivos (*.*)|*.*";
                openFileDialog.Title = "Carregar Macro";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        macroRecorder.LoadEvents(openFileDialog.FileName);
                        btnPlay.Enabled = true;
                        logger.Log("[INFO] Processo de carregamento de arquivo concluído.");
                        MessageBox.Show("Arquivo carregado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        logger.Log($"[ERRO] Falha ao carregar o arquivo: {ex.Message}");
                        MessageBox.Show($"Erro ao carregar o arquivo:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    logger.Log("[INFO] Nenhum arquivo selecionado.");
                    MessageBox.Show("Nenhum arquivo selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            macroRecorder.EditRecordedEvents();
        }
    }
}