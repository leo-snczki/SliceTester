using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliceTester.Classes
{
    public class PressKeyStep : Step
    {
        private Keys Key { get; }
        private Keyboard Keyboard { get; }

        public PressKeyStep(int id, Keys key) : base(id)
        {
            Key = key;
            Keyboard = new Keyboard();
        }

        public override Task Execute()
        {
            Keyboard.PressKey(Key);
            return Task.CompletedTask;
        }
    }
}
