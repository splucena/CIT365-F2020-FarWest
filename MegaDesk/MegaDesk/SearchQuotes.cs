using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk

    
{
    public partial class SearchQuotes : Form
    {
        public enum SurfaceMaterial
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine,
        };
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            cbSurfaceMaterial.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
            cbSurfaceMaterial.SelectedItem = SurfaceMaterial.Laminate;

            lvQuotes.View = View.Details;

            // Read content of file storage
            string[] lines = File.ReadAllLines(@"qoutes.txt");
            foreach (string line in lines)
            {
                //string[] quote = line.Split(new string[] { "," }, StringSplitOptions.None);
                string[] quote = line.Split(',');
                lvQuotes.Items.Add(new ListViewItem(quote));
            }
        }

        private void cbSurfaceMaterial_SelectedValueChanged(object sender, EventArgs e)
        {
            lvQuotes.Items.Clear();
            lvQuotes.View = View.Details;

            string surfaceMaterial = cbSurfaceMaterial.Text;

            Console.WriteLine("1");
            Console.WriteLine(surfaceMaterial);
            // Read content of file storage
            string[] lines = File.ReadAllLines(@"qoutes.txt");
            foreach (string line in lines)
            {
                //string[] quote = line.Split(new string[] { "," }, StringSplitOptions.None);
                string[] quote = line.Split(',');

                Console.WriteLine("2");
                Console.WriteLine(quote[5]);
                Console.WriteLine(surfaceMaterial.Trim(' ').Equals(quote[5].Trim(' ')));

                if (surfaceMaterial.Trim(' ').Equals(quote[5].Trim(' ')))
                {
                    Console.WriteLine("3");
                    lvQuotes.Items.Add(new ListViewItem(quote));
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
