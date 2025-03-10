using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SliceTester.Classes;

namespace SliceTester
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private LogManager logger;
        private MacroRecorder macroRecorder;
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
            btnRecord.Enabled = true;
            btnStop.Enabled = false;
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
        }
    }
}
