using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using SliceTester.Classes;

namespace SliceTester
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        List<Test> tests = new List<Test>();  // Lista para armazenar todos os testes.

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

        private void CountSteps()
        {
            if (tests.Any())
            {
                Test currentTest = tests.Last(); // escolhe o ultimo teste criado.
                currentTest.Steps.Count(); // Conta o número de etapas no teste.
                Console.WriteLine($"O teste '{currentTest.Name}' tem {currentTest.Steps.Count()} etapas."); // Log no output.
            }
            else
                MessageBox.Show("Por favor, crie um teste antes de contar etapas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            //string txtTestName.Text = txttxtTestName.Text.Text;

            if (string.IsNullOrEmpty(txtTestName.Text))
                MessageBox.Show("Por favor, insira um nome para o teste.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (tests.Any(t => t.Name == txtTestName.Text))
            {
                MessageBox.Show("Um teste com esse nome já existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {   
                Test newTest = new Test(tests.Count() + 1, txtTestName.Text);
                tests.Add(newTest);  // Adiciona o teste à lista.
                Console.WriteLine($"Teste '{txtTestName.Text}' criado com ID: {newTest.Id}"); // cw para log no output.

                // Adição de uma nova aba ao XtraTabControl.

                XtraTabPage newTab = new XtraTabPage
                {
                    Text = txtTestName.Text // Nome da aba
                };

                LabelControl label = new LabelControl
                {
                    Text = $"Id: {newTest.Id}",
                    Dock = DockStyle.Fill
                };
                newTab.Controls.Add(label);

                // Adicionar a aba ao XtraTabControl
                xtraTabControl1.TabPages.Add(newTab);
            }
        }

        /*        private void btnAddStep_Click(object sender, EventArgs e)
                {
                    if (tests.Count > 0)
                    {
                        Test currentTest = tests.Last(); // escolhe o ultimo teste criado..
                        //currentTest.AddStep(new WriteTextStep(currentTest.Steps.Count + 1, "teste"));
                        //currentTest.AddStep(new MoveAndClickStep(currentTest.Steps.Count + 1, 500, 400));
                        //currentTest.AddStep(new PressKeyStep(currentTest.Steps.Count + 1, Keys.A));
                    }
                    else
                        MessageBox.Show("Por favor, crie um teste antes de adicionar uma etapa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);            
                }*/
        private void btnAddStep_Click(object sender, EventArgs e)
        {
            if (tests.Count > 0)
            {
                Test currentTest = tests.Last(); // Get the last test created.

                // Open the StepChooser form to allow the user to create a step.
                StepChooser stepChooserForm = new StepChooser(currentTest);

                // Show the StepChooser form as a dialog.
                DialogResult result = stepChooserForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, crie um teste antes de adicionar uma etapa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStepCount_Click(object sender, EventArgs e)
        {
            CountSteps();
        }

        private async void btnPlayTest_Click(object sender, EventArgs e)
        {
            if (tests.Any())
            {
                Test currentTest = tests.Last();
                this.WindowState = FormWindowState.Minimized;
                await currentTest.PlayTest();
            }
            else
                MessageBox.Show("Por favor, crie um teste antes de executá-lo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
/*        private void btnPlayTest_Click(object sender, EventArgs e)
        {
            if (tests.Any())
            {
                Test currentTest = tests.Last();
                this.WindowState = FormWindowState.Minimized;
                currentTest.PlayTest();
            }
            else
                MessageBox.Show("Por favor, crie um teste antes de executá-lo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }*/
    }
}
