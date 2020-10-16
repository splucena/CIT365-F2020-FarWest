using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        public ViewAllQuotes()
        {
            InitializeComponent();
            // Create an instance of a ListView column sorter and assign it
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            //this.lvQuotes.ListViewItemSorter = lvwColumnSorter;
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            
            // Read data from json file.
            string jsonPath = @"quotes.json";

            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                // Read data from json.
                var jsonData = File.ReadAllText(jsonPath);
                // Deserialize json and then save it to a list
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData, new JsonSerializerSettings
                {
                    DateFormatString = "MM/dd/YYYY HH:mm:ss"
                });

                // Populate datagrid
                foreach(DeskQuote dq in deskQuotes)
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
                    } else
                    {
                        shippingMethod = $"Normal - {shippingDays} days.";
                    }

                    string[] row = { customerName, dateCreated, shippingMethod, totalSize, sizeCost, 
                                     drawerCost, material, materialCost, shippingCost, totalCost };
                    dgvQuotes.Rows.Add(row);
                }
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvQuotes_SelectionChanged(object sender, EventArgs e)
        {
            
                foreach (DataGridViewRow row in dgvQuotes.SelectedRows)
                {
                try
                {
                    lblCustomerName.Text = row.Cells[0].Value == null ? "" : row.Cells[0].Value.ToString();
                    // Date

                    // Desk details
                    if (row.Cells[0].Value != null)
                    {
                        lblBasePrice.Text = "200.00";
                        lblBaseSizeIncluded.Text = "1000.00";
                        lblCostPerIn.Text = "1.00";
                        lblPricePerDrawer.Text = "50.00";
                    } else
                    {
                        lblBasePrice.Text = "";
                        lblBaseSizeIncluded.Text = "";
                        lblCostPerIn.Text = "";
                        lblPricePerDrawer.Text = "";
                    }

                    // Surface area
                    lblTotalSizeIn.Text = row.Cells[3].Value == null ? "" : row.Cells[3].Value.ToString();
                    lblSizeCost.Text = row.Cells[4].Value == null ? "" : row.Cells[4].Value.ToString();

                    // Drawer
                    lblDrawerCost.Text = row.Cells[5].Value == null ? "" : row.Cells[5].Value.ToString();

                    // Material
                    lblMaterial.Text = row.Cells[6].Value == null ? "" : row.Cells[6].Value.ToString();
                    lblMaterialCost.Text = row.Cells[7].Value == null ? "" : row.Cells[7].Value.ToString();

                    // Shipping
                    lblShippingMethod.Text = row.Cells[2].Value == null ? "" : row.Cells[2].Value.ToString();
                    lblShippingCost.Text = row.Cells[8].Value == null ? "" : row.Cells[8].Value.ToString();

                    // Total cost
                    lblTotalCost.Text = row.Cells[9].Value == null ? "" : row.Cells[9].Value.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }            
        }
    }
}
