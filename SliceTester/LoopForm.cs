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
    public partial class LoopForm : DevExpress.XtraEditors.XtraForm
    {

        public static int num;

        public LoopForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(textBox1.Text, out num))
                {
                    MessageBox.Show("Numero de Loops:" + num);
                }
                else
                {
                    MessageBox.Show("Por favor insira um numero válido.");
                }
            }
            this.Close();
        }
    }
}