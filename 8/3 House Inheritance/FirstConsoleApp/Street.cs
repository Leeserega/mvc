using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Street
    {

        public StreetObject[] Objects = new StreetObject[10];

        public int count = 0;

        public void AddObject(StreetObject o)
        {
            if (count < 10) Objects[count++] = o;
        }

        public void Draw()
        {
            for (int i=0;i<count;i++)
            {
                Objects[i].Draw();
            }
        }

    }
}
