using System;
using System.Windows.Forms;

namespace SliceTester.Classes
{
    class Keyboard
    {
        // propriedades de premir tecla
        public Keys Key { get; set; }
        public bool IsDown { get; set; }
        public TimeSpan Timestamp { get; set; }
        // Construtor de parametros de teclado, pressionada, tempo pressionada;
        public Keyboard(Keys key, bool isDown, TimeSpan timestamp)
        {
            Key = key;
            IsDown = isDown;
            Timestamp = timestamp;
        }
    }
}
