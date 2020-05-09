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
    }
}
