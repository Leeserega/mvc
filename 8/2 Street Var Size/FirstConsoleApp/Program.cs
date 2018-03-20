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

            s.AddHouse(new House(300, 300, 50));
            s.AddHouse(new House());
            s.Draw();
        }

    }

}
