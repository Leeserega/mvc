using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    abstract class StreetObject
    {
        public int x, y;
        public static int count = 0;

        public StreetObject(int cx, int cy)
        {
            x = cx; y = cy;
            count++;
        }

        public abstract void Draw();

    }
}
