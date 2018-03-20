using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Street
    {

        public House[] Houses = new House[10];

        public int count = 0;

        public void AddHouse(House h)
        {
            if (count < 10) Houses[count++] = h;
        }

        public void Draw()
        {
            for (int i=0;i<count;i++)
            {
                Houses[i].Draw();
            }
        }

    }
}
