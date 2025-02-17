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
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            // Instancia um objeto da classe Mouse.
            Mouse mouse = new Mouse();

            // Mover o mouse para uma posição específica.
            mouse.Move(850, 813);

            // Realizar um clique esquerdo 3 vezes com 8s de delay.
            mouse.Click(3, 8000, leftClick: true);
            // Realizar um clique com o botão do meio.
            mouse.Click(1, 2000, middleClick: true);

            // Scroll para baixo.
            mouse.ScrollVertical(-120);

            // Scroll para o lado.
            mouse.ScrollHorizontal(-150);
        }
    }
}
