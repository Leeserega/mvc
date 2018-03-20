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
            var h = new House();
            var h2 = new House(200, 200, 50);
            h.Draw();
            h2.Draw();
            h2.Color = "Red";

            var s = new Street();
            s.AddHouse(new House(100, 200, 30));
            s.AddHouse(new House(200, 100, 30));
            s.Draw();
        }

    }
}
