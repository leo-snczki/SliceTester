using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SliceTester.Classes
{
    public abstract class Step
    {
        public int Id { get; private set; }
        //StepType Type { get; set; }
        public Step(int id)
        {
            Id = id;
        }
        public abstract Task Execute();
    }

/*    public enum StepType
    {
        MoveAndClick = 1,
        PressKey,
        PasteText
    }*/
}
