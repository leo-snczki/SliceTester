using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SliceTester.Classes
{
    public class MoveAndClickStep : Step
    {
        private int X { get; }
        private int Y { get; }
        private Mouse Mouse { get; }

        public MoveAndClickStep(int id, int x, int y) : base(id)
        {
            X = x;
            Y = y;
            Mouse = new Mouse();
        }

        public override async Task Execute()
        {
            Mouse.Move(X, Y);
            await Task.Delay(500);
            Mouse.Click(1, leftClick: true);
        }
/*        public override Task Execute()
        {
            Mouse.Move(X, Y);
            Thread.Sleep(500);
            Mouse.Click(1, leftClick: true);
        }*/
    }
}
