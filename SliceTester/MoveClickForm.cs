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
    public partial class MoveClickForm : DevExpress.XtraEditors.XtraForm
    {
        private Test _currentTest;
        private Timer _timer;


        public MoveClickForm(Test currentTest)
        {
            InitializeComponent();
            _currentTest = currentTest;

            _timer = new Timer
            {
                Interval = 50  // Intervalo de 50 ms
            };
            _timer.Tick += (s, e) =>
            {
                // Atualiza as coordenadas X e Y nas TextEdits
                txtX.Text = $"X: {Cursor.Position.X}";
                txtY.Text = $"Y: {Cursor.Position.Y}";
            };
            _timer.Start();
        }
    }
}