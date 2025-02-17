using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliceTester.Classes
{
    public class Keyboard
    {
        // CAMPOS

        // Campos privados mas CONSTANTES não levam underline.
        private const int KEYEVENTF_KEYDOWN = 0x0000; // Simula pressionar a tecla.
        private const int KEYEVENTF_KEYUP = 0x0002;   // Simula soltar a tecla.

        // MÉTODOS

        // P/Invoke para user32.dll para simular o teclado.
        // Static e extern indicado porque o método existe em outro lugar, neste caso, uma DLL.
        // Para chamar tal método, é usado o nome exato, nesse caso, em SnakeCase e PascalCase.
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, IntPtr dwExtraInfo);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern short VkKeyScan(char ch); // Mapeia caractere para código de tecla virtual.

        public void PressKey(Keys key, int delay = 100)
        {
            // Simula pressionar e soltar uma tecla.
            keybd_event((byte)key, 0, KEYEVENTF_KEYDOWN, IntPtr.Zero);
            Task.Delay(delay);
            keybd_event((byte)key, 0, KEYEVENTF_KEYUP, IntPtr.Zero);
            Console.WriteLine($"Tecla '{key}' pressionada.");
        }

        public void PressKeyCombo(Keys[] keys, int delay = 100)
        {
            // Simula pressionar uma combinação de teclas.
            if (keys.Length < 2)
            {
                MessageBox.Show("Por favor, especifique pelo menos duas teclas para a combinação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pressiona todas as teclas.
            foreach (var key in keys)
                keybd_event((byte)key, 0, KEYEVENTF_KEYDOWN, IntPtr.Zero);

            Task.Delay(delay);

            // Solta todas as teclas na ordem inversa.
            for (int i = keys.Length - 1; i >= 0; i--)
                keybd_event((byte)keys[i], 0, KEYEVENTF_KEYUP, IntPtr.Zero);

            Console.WriteLine($"Combinação de teclas '{string.Join(" + ", keys)}' pressionada.");
        }

        public void TypeText(string text, int delay = 100)
        {
            // Simula a digitação de um texto.
            foreach (char c in text)
            {
                short keyCode = VkKeyScan(c);
                if (keyCode == -1)
                {
                    MessageBox.Show($"Caractere '{c}' não pode ser simulado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                bool shift = (keyCode & 0x0100) != 0;
                Keys key = (Keys)(keyCode & 0xFF);

                if (shift)
                    PressKeyCombo(new[] { Keys.ShiftKey, key }, delay);
                else
                    PressKey(key, delay);
            }

            Console.WriteLine($"Texto '{text}' digitado.");
        }
    }
}
