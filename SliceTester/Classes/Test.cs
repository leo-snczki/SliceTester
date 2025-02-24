using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.Utils.DPI;

namespace SliceTester.Classes
{
    public class Test
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Delay { get; set; }
        public List<Step> Steps { get; set; }
        public Test(int id, string name)
        {
            Id = id;
            Name = name;
            Steps = new List<Step>();
        }
        public void AddStep(Step step)
        {
            Steps.Add(step);
        }
        public async Task PlayTest()
        {
            for (int i = 0; i < Steps.Count; i++)
            {
                if (i > 0)
                {
                    int delay = 2000;
                    await Task.Delay(delay); // Espera pelo tempo de atraso                    
                }

                await Steps[i].Execute();
                Console.WriteLine($"Etapa {i + 1} executada.");
            }
        }
        /*        public void PlayTest()
                {
                    for (int i = 0; i < Steps.Count; i++)
                    {
                        if (i > 0)
                        {
                            int delay = 2000;
                            Thread.Sleep(delay); // Espera pelo tempo de atraso                    
                        }

                        Steps[i].Execute();
                        Console.WriteLine($"Etapa {i + 1} executada.");
                    }
                }*/
    }
}
