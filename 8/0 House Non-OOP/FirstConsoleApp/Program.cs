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
        static void Draw(int x, int y, int size)
        {
            GraphicsWindow.DrawRectangle(x, y, size, size);
            GraphicsWindow.DrawTriangle(x, y, x + size / 2, y - size / 2, x + size, y);
            GraphicsWindow.DrawRectangle(x + size / 4, y + size / 4, size / 2, size / 2);
        }

        
        static void Main(string[] args)
        {
            GraphicsWindow.Show();
            int x1 = 100, y1 = 100, size1 = 50;
            Draw(x1, y1, size1);

            int x2 = 300, y2 = 300, size2 = 100;
            Draw(x2, y2, size2);

        }

    }
}
