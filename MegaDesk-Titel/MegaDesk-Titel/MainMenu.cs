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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the Main Menu Form
            Close();
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            //Create AddQuote object called viewAddQuote
            AddQuote viewAddQuote = new AddQuote();
            
            //Tag MainMenu and show AddQuote view passing in MainMenu
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            
            //Hide Main Menu
            this.Hide();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            //Create ViewAllQuotes object called viewAllQuotesForm
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();

            //Tag MainMenu and show ViewAllQuotes view passing in MainMenu
            viewAllQuotesForm.Tag = this;
            viewAllQuotesForm.Show(this);

            //Hide Main Menu
            this.Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {

            //Create SearchQuotes object called viewSearchQuotes
            SearchQuotes viewSearchQuotes = new SearchQuotes();

            //Tag MainMenu and show SearchQuotes view passing in MainMenu
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);

            //Hide Main Menu
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
