using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Titel
{
    public class Desk
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
        private int w;
        private int d;
        private int drawer;
        private int surface;

        public Desk(int w, int d, int drawers, string surface)
        {
            this.Width = w;
            this.Depth = d;
            this.DrawerCount = drawers;
           // Material convertSurface = Enum.Parse(Material, surface); 
            this.SurfaceMaterial =(Material) Enum.Parse(typeof(Material), surface);
        }

     
    }
    public enum Material
    { Laminate, Oak, Rosewood, Veneer, Pine};
}
