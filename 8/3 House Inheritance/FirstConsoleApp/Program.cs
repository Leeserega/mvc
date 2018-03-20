using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.SmallBasic.Library;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.Show();

            var s = new Street();
            s.AddObject(new House());
            s.AddObject(new House(100, 300, 50));
            s.AddObject(new StreetLamp(150, 150));
            s.AddObject(new StreetLamp(240, 300));
            s.Draw();
        }

    }
}
