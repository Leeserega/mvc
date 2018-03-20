using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class House
    {
        public static int count = 0;
        public int x, y, size;
        public House(int cx, int cy, int csz)
        {
            x = cx; y = cy; size = csz;
            count++;
            Console.WriteLine("House #{0} created", count);
        }
        public House () : this(300,300,100)
        { }

        private string color;

        public string Color
        {
            set {
                color = value;
                Draw(); 
            }
            get { return color; }
        }

        public void Draw()
        {
            GraphicsWindow.PenColor = color;
            GraphicsWindow.DrawRectangle(x, y, size, size);
            GraphicsWindow.DrawTriangle(x, y, x+size/2, y-size/2, x+size, y);
            GraphicsWindow.DrawRectangle(x+size/4, y+size/4, size/2, size/2);
        }

    }

}
