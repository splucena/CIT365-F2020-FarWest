using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

        private void populateDataGridView(bool isFilter, string surfaceMaterial)
        {
            // Read data from json file.
            string jsonPath = @"quotes.json";

            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Read data from json.
                var jsonData = File.ReadAllText(jsonPath);
                // Deserialize json and then save it to a list
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData, new JsonSerializerSettings
                {
                    DateFormatString = "MM/dd/YYYY HH:mm:ss"
                });

                // Populate datagrid
                dgvQuotes.Rows.Clear();
                dgvQuotes.Refresh();
                foreach (DeskQuote dq in deskQuotes)
                {
                    string dateCreated = dq.ShippingDate.ToString();
                    string customerName = dq.CustomerName;

                    string totalSize = $"{Math.Round(dq.computeSurfaceArea(dq.Desk.Width, dq.Desk.Depth), 2)}";
                    string sizeCost = Math.Round(dq.computeDeskSizeCost(), 2).ToString("F");
                    string drawerCost = Math.Round(dq.computeDrawerCost(), 2).ToString("F");
                    string material = dq.Desk.SurfaceMaterial;
                    string materialCost = Math.Round(dq.computeSurfaceMaterialCost(), 2).ToString("F");
                    int shippingDays = dq.Desk.RushOrderDay;
                    string shippingMethod = "";
                    string shippingCost = Math.Round(dq.computeShippingCost(), 2).ToString("F");
                    string totalCost = Math.Round(dq.computeDeskPrice(), 2).ToString("F");

                    if (shippingDays != 14)
                    {
                        shippingMethod = $"Rush - {shippingDays} days.";
                    }
                    else
                    {
                        shippingMethod = $"Normal - {shippingDays} days.";
                    }

                    string[] row = { customerName, dateCreated, shippingMethod, totalSize, sizeCost,
                                     drawerCost, material, materialCost, shippingCost, totalCost };

                    if (material == surfaceMaterial && isFilter)
                    {
                        dgvQuotes.Rows.Add(row);
                    } 

                    if (!isFilter)
                    {
                        dgvQuotes.Rows.Add(row);
                    }
                }
            }
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            cbSurfaceMaterial.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
            cbSurfaceMaterial.SelectedItem = SurfaceMaterial.Laminate;

            // Populate datagrid with values from JSON
            populateDataGridView(false, "");
        }

        private void cbSurfaceMaterial_SelectedValueChanged(object sender, EventArgs e)
        {
            string surfaceMaterial = cbSurfaceMaterial.Text;
            // Populate datagrid with values from JSON based on the value selected from the dropdown.
            populateDataGridView(true, surfaceMaterial);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
