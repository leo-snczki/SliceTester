using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliceTester
{
    public partial class SaveForm : DevExpress.XtraEditors.XtraForm
    {
        public string fileName;
        public SaveForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fileName = txtSaveFile.Text;

            // Verifica se o nome do arquivo é inválido branco ou nulo.
            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Nome do arquivo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}