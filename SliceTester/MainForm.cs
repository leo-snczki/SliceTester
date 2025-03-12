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
                btnStop.Enabled = true;
                macroRecorder.StartRecording();
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
            if (macroRecorder.GetRecordedEvents().Count == 0)
            {
                MessageBox.Show("Nenhum evento gravado para reproduzir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("A reprodução vai começar depois do OK", "Iniciar Reprodução", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                btnPlay.Enabled = false;
                macroRecorder.Play();
                btnPlay.Enabled = true;
            }
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
                    macroRecorder.SaveEvents(saveFileDialog.FileName);
                    MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    macroRecorder.LoadEvents(openFileDialog.FileName);
                    btnPlay.Enabled = true;
                    MessageBox.Show("Arquivo carregado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    logger.Log("[INFO] Nenhum arquivo selecionado.");
                    MessageBox.Show("Nenhum arquivo selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
