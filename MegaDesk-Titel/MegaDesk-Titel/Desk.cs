using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Titel
{
    class Desk
    {
        //Auto -Implement Data Members
        public int Width { get; set; }
        public int Depth { get; set; }
        public int DrawerCount { get; set; }
        public Material SurfaceMaterial { get; set; }

        const int MAX_WIDTH = 96;
        const int MIN_WIDTH = 24;
        const int MAX_DEPTH = 48;
        const int MIN_DEPTH = 12;

        Desk(int w, int d, int drawers, Material surface)
        {
            this.Width = w;
            this.Depth = d;
            this.DrawerCount = drawers;
            this.SurfaceMaterial = surface;
        }

    }
    enum Material
    { Laminate, Oak, Rosewood, Veneer, Pine};
}
