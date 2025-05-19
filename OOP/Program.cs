using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

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
            Hammer new_hammer = new Hammer("new hammer",4);
            Drill new_drill = new Drill("new_drill", 44);
            my_tools.Add(new_drill);
            my_tools.Add(new_hammer);
            NailGun nailgun = new NailGun("nail ", 20);
            my_tools.Add(nailgun);
            foreach (Tool objects in my_tools)
            {
                objects.describe();
                objects.use();
            }

            
   

        }
    }
}
