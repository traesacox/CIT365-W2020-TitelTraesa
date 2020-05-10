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
            label1.Text="You made it here with" + quote.CustName;
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
