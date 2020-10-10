using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            //AddQuote.ActiveForm.Show();
            AddQuote a = new AddQuote();
            a.ShowDialog();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes v = new ViewAllQuotes();
            v.ShowDialog();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes s = new SearchQuotes();
            s.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK) 
            {
                Environment.Exit(1);
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
