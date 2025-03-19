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
    public partial class Save : DevExpress.XtraEditors.XtraForm
    {
        public Save()
        {
            InitializeComponent();
        }

        public static string inputString;

        private void btnOK_Click(object sender, EventArgs e)
        {
            inputString = textBox1.Text;

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}