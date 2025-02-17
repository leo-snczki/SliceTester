using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraTab;

namespace SliceTester.Classes
{
    public class Mouse
    {
        // CAMPOS

        // Botão esquerdo.
        private const int _MOUSEEVENTF_LEFTDOWN = 0x0002; // simula pressionar BotãoEsquerdo.
        private const int _MOUSEEVENTF_LEFTUP = 0x0004; // simula pressionar BotãoDireito.
        // Botão do meio.
        private const int _MOUSEEVENTF_MIDDLEDOWN = 0x0020; // simula pressionar BotãoMeio.
        private const int _MOUSEEVENTF_MIDDLEUP = 0x0040; // simula soltar BotãoMeio.
        // Rodela do meio.
        private const int _MOUSEEVENTF_WHEELV = 0x0800; // simula rolar a roda do mouse verticalmente.
        private const int _MOUSEEVENTF_WHEELH = 0x01000; // simula rolar a roda do mouse horizontalmente.
        // Botão direito.
        private const int _MOUSEEVENTF_RIGHTDOWN = 0x0008; // simula pressionar BotãoDireito.
        private const int _MOUSEEVENTF_RIGHTUP = 0x0010; // simula soltar BotãoDireito.

        // MÉTODOS.

        // P/Invoke para user32.dll serve para simular o mouse.
        // Static e extern indicado porque o método existe em outro lugar, neste caso, uma DLL.
        // Para chamar tal método, é usado o nome exato, nesse caso, em SnakeCase e PascalCase.
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo); // Simula um evento do mouse.

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y); // Move o cursor do mouse para as coordenadas especificadas.
        public void Move(int x, int y)
        {
            // move o mouse para as coordenadas especificadas.
            if (SetCursorPos(x, y))
                Console.WriteLine($"Mouse movido para ({x}, {y}).");
            else
            {
                MessageBox.Show("O mouse não foi movimentado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        public void Click(int numClicks, int delay = 200, bool rightClick = false, bool leftClick = false, bool middleClick = false)
        {
            if (numClicks < 1)
            {
                MessageBox.Show("Por favor, especifique algum número de clique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // simula a quantidade de cliques inserida.
            for (int i = 0; i < numClicks; i++)
            {
                if (leftClick && rightClick || leftClick && middleClick || rightClick && middleClick)
                {
                    MessageBox.Show("Por favor, escolha apenas um botão para clicar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (leftClick)
                {
                    // Botão esquerdo.
                    mouse_event(_MOUSEEVENTF_LEFTDOWN, 0, 0, 0, IntPtr.Zero);
                    mouse_event(_MOUSEEVENTF_LEFTUP, 0, 0, 0, IntPtr.Zero);
                }
                else if (rightClick)
                {
                    // Botão direito.
                    mouse_event(_MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, IntPtr.Zero);
                    mouse_event(_MOUSEEVENTF_RIGHTUP, 0, 0, 0, IntPtr.Zero);
                }
                else if (middleClick) // Aqui poderia estar sem o if, mas para fins de clareza, foi mantido assim.
                {
                    // Botão do meio.
                    mouse_event(_MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, IntPtr.Zero);
                    mouse_event(_MOUSEEVENTF_MIDDLEUP, 0, 0, 0, IntPtr.Zero);
                }

                // Atraso entre os cliques para aguardar o sistema.
                if (numClicks > 1)
                    Thread.Sleep(delay); // 200 por padrão mas pode ser mudado.

                // Para fazer log no console sobre os cliques.
                Console.WriteLine($"Clique {i + 1} de {numClicks}: {(rightClick ? "direito" : leftClick ? "esquerdo" : "meio")}");
            }
        }
        public void ScrollVertical(int delta)
        {
            // Simula a rotação da roda do mouse.
            // Um valor positivo de delta vai para cima, e um valor negativo para baixo.
            if (delta != 0)
            {
                mouse_event(_MOUSEEVENTF_WHEELV, 0, 0, delta, IntPtr.Zero);
                Console.WriteLine($"Roda do mouse girada com valor {delta}.");
            }
            else
            {
                MessageBox.Show("Por favor, especifique algum valor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        public void ScrollHorizontal(int delta)
        {
            // Simula a rotação da roda do mouse.
            // Um valor positivo de delta vai para cima, e um valor negativo para baixo.
            if (delta != 0)
            {
                mouse_event(_MOUSEEVENTF_WHEELH, 0, 0, delta, IntPtr.Zero);
                Console.WriteLine($"Roda do mouse girada com valor {delta}.");
            }
            else
            {
                MessageBox.Show("Por favor, especifique algum valor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}


