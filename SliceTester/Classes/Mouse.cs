using System;
using System.Runtime.InteropServices;


namespace SliceTester.Classes
{
    public class Mouse
    {
        // constantes do rato
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002; // simula pressionar BotãoEsquerdo
        const uint MOUSEEVENTF_LEFTUP = 0x0004;   // simula pressionar BotãoDireito

        // P/Invoke para user32.dll serve para simular o mouse
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, IntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y); // move o cursor para as coordenadas 

        // metodo para mover o mouse e clickar
        static public void MoveAndClick(int x, int y, int numClicks)
        {

            if (numClicks < 1)
            {
                Console.WriteLine("Por favor, especifique um número positivo de cliques.");
                return;
            }

            // move o rato para as coordenadas especificadas
            if (SetCursorPos(x, y))
            {
                Console.WriteLine($"Mouse movido para ({x}, {y}).");

                // simula a quantidade de cliques inserida
                for (int i = 0; i < numClicks; i++)
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, IntPtr.Zero); // pressiona o botao esquerdo do mouse
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, IntPtr.Zero);   // solta o botao esquerdo do mouse
                }

                Console.WriteLine($"{numClicks} clique(s) simulado(s) em ({x}, {y}).");
            }
            else
                Console.WriteLine("Falha ao mover o mouse.");
            
        }
    }
}
