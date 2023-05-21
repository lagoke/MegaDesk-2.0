using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Amiola
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote objAddQuote = new AddQuote();
            objAddQuote.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllQuotes objView = new ViewAllQuotes();
            objView.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchQuotes objSearch = new SearchQuotes();
            objSearch.Show();
        }
    }
}
