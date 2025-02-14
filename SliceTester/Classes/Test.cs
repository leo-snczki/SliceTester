using System.Collections.Generic;

namespace SliceTester.Classes
{
    public class Test
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Step> Steps { get; set; }
        public Test()
        {
            Steps = new List<Step>();
        }
    }
}
