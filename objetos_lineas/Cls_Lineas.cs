using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace objetos_lineas
{
    internal class Cls_Lineas
    {

        public static int totalLineas = 0;
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public Cls_Lineas(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }


        public void DibujarLinea(Graphics g)
        {
            Pen lapiz = new Pen(Color.Red, 3);
            g.DrawLine(lapiz, X1, Y1, X2, Y2);
            totalLineas++;
        }
    }
}
