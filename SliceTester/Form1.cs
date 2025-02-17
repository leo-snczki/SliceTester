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
        }

        public void KeyboardTester()
        {
            // Instancia um objeto da classe Keyboard.
            Keyboard keyboard = new Keyboard();
            // Pressionar a tecla 'A'.
            keyboard.PressKey(Keys.A);

            // Pressionar a combinação de teclas 'Ctrl + C'.
            keyboard.PressKeyCombo(new Keys[] { Keys.ControlKey, Keys.C });

            // Digita um texto com delay de 0.5s.
            keyboard.TypeText("Hello, World!", 500);

            // Pressiona a tecla 'A' com delay de 3s.
            keyboard.PressKey(Keys.A, 3000);

            // Pressiona a combinação de teclas 'Ctrl + V' com delay de 3s.
            keyboard.PressKeyCombo(new Keys[] { Keys.ControlKey, Keys.C }, 3000);

            // Digita um texto com delay padrão(100).
            keyboard.TypeText("Hello, World!");
        }

        private void MouseTester()
        {
            // Instancia um objeto da classe Mouse.
            Mouse mouse = new Mouse();

            // Mover o mouse para uma posição específica.
            mouse.Move(850, 813);

            // Realizar três clique esquerdo 3 vezes com 8s de delay.
            mouse.Click(3, 8000, leftClick: true);

            // Realizar um clique com o botão do meio com 2s de delay.
            mouse.Click(1, 2000, middleClick: true);

            // Scroll para baixo.
            mouse.ScrollVertical(-120);

            // Scroll para o lado.
            mouse.ScrollHorizontal(-150);
        }

        private void btnKeyboardTest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            KeyboardTester();
        }

        private void btnMouseTest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            MouseTester();
        }

    }
}
