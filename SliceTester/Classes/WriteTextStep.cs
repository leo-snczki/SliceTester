using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SliceTester.Classes
{
    public class WriteTextStep : Step
    {
        private string Text { get; }
        private Keyboard Keyboard { get; }

        public WriteTextStep(int id, string text) : base(id)
        {
            Text = text;
            Keyboard = new Keyboard();
        }

        public override Task Execute()
        {
            Keyboard.TypeText(Text);
            return Task.CompletedTask;
        }
    }
}
