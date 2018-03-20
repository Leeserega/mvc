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
        public int x, y, size;

        public static int count = 0;

        private string color;

        public string Color
        {
            get { return color; }
            set 
            {
                color = value;
                GraphicsWindow.PenColor = color;
                Draw();
            }
        }
        
        public House(int cx, int cy, int size)
        {
            x = cx;
            y = cy;
            this.size = size;
            count++;
            Console.WriteLine("Домик {0} создан", count);
        }

        public House () : this(100,100,100)
        {
        }

        public void Draw()
        {
            GraphicsWindow.DrawRectangle(x, y, size, size);
            GraphicsWindow.DrawTriangle(x, y, x + size / 2, y - size / 2, x + size, y);
            GraphicsWindow.DrawRectangle(x + size / 4, y + size / 4, size / 2, size / 2);
        }

    }
}
