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
        //List<Test> tests = new List<Test>();

        public MainForm()
        {
            InitializeComponent();
            logger = new LogManager(txtLog);
            macroRecorder = new MacroRecorder(logger);
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
                logger.Log("Reprodução não iniciada.");
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

    }
}
