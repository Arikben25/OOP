using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer("hammer", 5);
            Wrench wrench = new Wrench("wrench", 1);
            Drill drill = new Drill("drill", 2);
            Saw saw = new Saw("saw", 3);
            Screwdriver screwdriver = new Screwdriver("scr", 4);
            PipeCutter pipe = new PipeCutter("pipe", 8);
            List <Tool> my_tools = new List<Tool> { hammer, wrench, drill, saw, screwdriver, pipe };

            
   

        }
    }
}
