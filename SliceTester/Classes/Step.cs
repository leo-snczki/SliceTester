using System;

namespace SliceTester.Classes
{
    public class Step
    {
        public int Id { get; private set; }
        public int NumStep { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Delay { get; set; }
        //public DateTime TotalTime { get; set; } (para se quiser mostra o tempo que todos os passos demoraram em total)
        public InstructionType TypeStep { get; set; }
        public enum InstructionType
        {
            Click,
            KeyPress,
            PasteText
        }
    }
}
