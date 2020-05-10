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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();

        }

        private void width_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg="";
            int testWidth = 0;
            Boolean goodValue = false;
            if(int.TryParse(width.Text, out testWidth))
            {
                if(testWidth<24 || testWidth >96)
                { errorMsg = "You must enter a width between 24 and 96 inches. Please correct the measurement.";
                }else
                {
                    goodValue = true;
                }
            }
            else
            {
                errorMsg = "You must enter a numberic value between 24 and 96 inches.  Please correct the measurement.";
            }

            if (goodValue==false)
            {
                //Cancel the event and select the text to be crrected by the user
                e.Cancel = true;
                width.Select(0, width.Text.Length);
                //Display Message Box error with the text to display
                MessageBox.Show(errorMsg, "Error in Input Values");
                
            }
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            //Create Desk ojbect
            int w = int.Parse(width.Text);
            int d = int.Parse(depth.Text);
            int drawer = int.Parse(drawerCount.Text);
            string surface = SurfaceMaterial.Text;

            Desk desk = new Desk (w, d, drawer, surface);

            //Create DeskQuote Object
            string name = custName.Text;
            int Time = int.Parse(DeliveryDays.Text);

            DeskQuote quote = new DeskQuote(name, desk, Time);

            DisplayQuote viewQuote = new DisplayQuote(desk, quote);
            this.Hide();
            viewQuote.Show();


        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void deliveryTime_ValueMemberChanged(object sender, EventArgs e)
        {
            Console.WriteLine("You are here");
            switch (deliveryTime.Text)
            {
                case "Rush Order -3 Days(extra charge)":
                    DeliveryDays.Text = "3";
                    Console.WriteLine("3 Days");
                    break;
                case "Rush Order -5 Days(extra charge)":
                    DeliveryDays.Text = "5";
                    break;
                case "Rush Order -7 Days(extra charge)":
                    DeliveryDays.Text = "7";
                    break;
                case "Normal Order -14 Days(No extra Charge)":
                    DeliveryDays.Text = "14";
                    break;
            }

        }

        private void deliveryTime_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("You are here");
            switch (deliveryTime.Text)
            {
                case "Rush Order -3 Days(extra charge)":
                    DeliveryDays.Text = "3";
                    Console.WriteLine("3 Days");
                    break;
                case "Rush Order -5 Days(extra charge)":
                    DeliveryDays.Text = "5";
                    break;
                case "Rush Order -7 Days(extra charge)":
                    DeliveryDays.Text = "7";
                    break;
                case "Normal Order -14 Days(No extra Charge)":
                    DeliveryDays.Text = "14";
                    break;
            }

        }

        private void deliveryTime_Leave(object sender, EventArgs e)
        {
            string delString = deliveryTime.Text;

            if (delString.Contains("3 Days"))
            {
                DeliveryDays.Text = "3";
            }
            if (delString.Contains("5 Days"))
            {
                DeliveryDays.Text = "5";
            }
            if (delString.Contains("7 Days"))
            {
                DeliveryDays.Text = "7";
            }
            if (delString.Contains("14 Days"))
            {
                DeliveryDays.Text = "14";
            }
            
        }
    }
}
