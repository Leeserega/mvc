using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Street
    {

        public House[] houses;
        public int count = 0;
        public int max;

        public Street(int n)
        {
            max = n;
            houses = new House[n];
        }

        public Street() : this(10) { }

        public void AddHouse(House h)
        {
            if (count<max) houses[count++] = h;
        }

        public void Draw()
        {
            for (int i=0;i<count;i++)
            {
                houses[i].Draw();
            }
        }

    }
}
