using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class StreetLamp : StreetObject
    {

        public StreetLamp(int cx, int cy) : base(cx,cy)
        {

        }

        public override void Draw()
        {
            GraphicsWindow.DrawLine(x, y, x, y + 100);
            GraphicsWindow.DrawEllipse(x, y, 10, 10);
        }


    }
}
