using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SliceTester.Classes;

namespace SliceTester
{
    public partial class StepChooser : DevExpress.XtraEditors.XtraForm
    {
        private Test _currentTest;
        public Step CreatedStep { get; private set; }

        public StepChooser(Test currentTest)
        {
            InitializeComponent();
            _currentTest = currentTest;
        }

        private void btnSaveStep_Click(object sender, EventArgs e)
        {
            // Close the form and indicate success.
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelStep_Click(object sender, EventArgs e)
        {
            // Close the form without creating a step.
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnMoveClick_Click(object sender, EventArgs e)
        {
            MoveClickForm MoveClickForm = new MoveClickForm(_currentTest);
            DialogResult result = MoveClickForm.ShowDialog();

        }
    }
}