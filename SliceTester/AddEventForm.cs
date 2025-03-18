using System;
using System.Windows.Forms;


namespace SliceTester
{
    public partial class AddEventForm : DevExpress.XtraEditors.XtraForm
    {
        public MacroRecorder.MacroEvent NewEvent { get; private set; }
        public AddEventForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AddEvent();
        }


        private void AddEvent()
        {
                this.DialogResult = DialogResult.OK;
                this.Close();
        }
    }
}