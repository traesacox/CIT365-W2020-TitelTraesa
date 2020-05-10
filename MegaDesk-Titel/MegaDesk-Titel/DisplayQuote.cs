using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Titel
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(Desk desk, DeskQuote quote)
        {
            InitializeComponent();
            name.Text=quote.CustName;
            width.Text = desk.Width.ToString() + " inches";
            depth.Text = desk.Depth.ToString() + " inches";
            drawerCount.Text = desk.DrawerCount.ToString();
            surfaceMaterial.Text = desk.SurfaceMaterial.ToString();
            deliveryTime.Text = quote.DeliveryTime.ToString() + " Days";
            CostBreakDown costDetail = quote.CalcCost(desk, quote);
            int aCost = costDetail.areaCost;
            int mCost = costDetail.materialCost;
            int rCost = costDetail.rushCost;
            int dCost = costDetail.drawerCost;
            areaCost.Text = "$" + aCost.ToString();
            materialCost.Text = "$" + mCost.ToString();
            rushCost.Text = "$" + rCost.ToString();
            drawerCost.Text = "$" + dCost.ToString();
            totalCost.Text = "$" + quote.Cost.ToString();
            quoteDate.Text = quote.OrderDate.ToString();

        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCloseQuote_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }
    }
}
