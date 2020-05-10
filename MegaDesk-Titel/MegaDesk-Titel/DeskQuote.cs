using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Titel
{
    public class DeskQuote
    {
        //Auto -Implement Data Members
        public string CustName { get; set; }
        public Desk desk { get; set; }
        public double Cost { get; set; }
        public int DeliveryTime { get; set; }
        public DateTime OrderDate { get; set; }
        //public DeskState OrderState { get; set; }

        //Constructor - Create object of Desk Quote
        public DeskQuote (string name, Desk desk, int deliveryTime)
        {
            this.CustName = name;
            this.desk = desk;
            this.Cost = 0;
            this.DeliveryTime = deliveryTime;
            this.OrderDate = DateTime.Now;
           // this.OrderState = Quoted;

        }
        public void CalcCost (Desk desk, DeskQuote quote)
        {
            const int baseCost = 200;
            int areaCost = 0;
            int drawerCost = desk.DrawerCount *50;
            int surfaceCost = 0;
            int deliveryCost = 0;
            double totalCost = 0;

            int area = desk.Width * desk.Depth;

            if (area > 1000)
            {
                areaCost = (area - 1000);
            }

            switch (desk.SurfaceMaterial)
            {
                case Material.Laminate:
                    surfaceCost = 100;
                    break;
                case Material.Oak:
                    surfaceCost = 200;
                    break;
                case Material.Pine:
                    surfaceCost = 50;
                    break;
                case Material.Rosewood:
                    surfaceCost = 300;
                    break;
                case Material.Veneer:
                    surfaceCost = 125;
                    break;
            }
            //Calc delivery Cost
            if (quote.DeliveryTime == 3)
            {
                if (area < 1000)
                {
                    deliveryCost = 60;
                }
                else if (area > 2000)
                {
                    deliveryCost = 80;
                }
                else
                {
                    deliveryCost = 70;
                }     
                
            }

            if (quote.DeliveryTime == 5)
            {
                if (area < 1000)
                {
                    deliveryCost = 40;
                }
                else if (area > 2000)
                {
                    deliveryCost = 60;
                }
                else
                {
                    deliveryCost = 50;
                }
                if (quote.DeliveryTime == 7)
                {
                    if (area < 1000)
                    {
                        deliveryCost = 30;
                    }
                    else if (area > 2000)
                    {
                        deliveryCost = 40;
                    }
                    else
                    {
                        deliveryCost = 35;
                    }

                }

            }

            totalCost = baseCost + areaCost + drawerCost + surfaceCost + deliveryCost;
            this.Cost = totalCost;
        }

        
    }
   // enum DeskState
   // { Quoted, Ordered, Manufactured, Delivered };

}
