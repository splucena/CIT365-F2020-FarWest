using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MegaDesk.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MegaDesk
{
    class DeskQuote
    {
        // Make this member variable accessible during JSON de/serialization
        [JsonProperty]
        private Desk _desk;
        [JsonProperty]
        private DateTime _shippingDate;
        [JsonProperty]
        private String _customerName;

        private List<DeskQuote> _dq;

        public string CustomerName { get => _customerName; set => _customerName = value; }
        public DateTime ShippingDate { get => _shippingDate; set => _shippingDate = value; }
        internal Desk Desk { get => _desk; set => _desk = value; }

        public DeskQuote(Desk desk, DateTime shippingDate, String customerName)
        {
            _desk = desk;
            _shippingDate = shippingDate;
            _customerName = customerName;
        }

        public decimal computeSurfaceArea(decimal width, decimal height)
        {
            return width * height;
        }

        public int[,] getRushOrderPrices()
        {
            int[,] rushOrderPrices = new int[8, 3];
            string[] stringSeparators = new string[] { "\r\n" };
            string[] lines = Resources.rushOrderPrices.Split(stringSeparators, StringSplitOptions.None);
            int k = 0;
            try
            {
                foreach (string line in lines)
                {
                    for (int i = 3; i <= 7; i += 2)
                    {
                        for (int j = 0; j < 3; j++, k++)
                        {
                            rushOrderPrices[i, j] = Int32.Parse(lines[k]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong getting the rush order prices. Try again later.");
                Console.WriteLine(e.Message);
            }
            return rushOrderPrices;
        }

        public decimal computeShippingCost()
        {
            
            decimal totalSurfaceArea = computeSurfaceArea(_desk.Width, _desk.Depth);
            int rushOrderCost;
            int[,] rushOrderPrices = getRushOrderPrices();
            int costFactor;
            if (_desk.RushOrderDay == 3 || _desk.RushOrderDay == 5 || _desk.RushOrderDay == 7)
            {
                if (totalSurfaceArea < 1000)
                {
                    costFactor = 0;
                }
                else if (totalSurfaceArea >= 100 && totalSurfaceArea <= 2000)
                {
                    costFactor = 1;
                }
                else
                {
                    costFactor = 2;
                }
                rushOrderCost = rushOrderPrices[_desk.RushOrderDay, costFactor];
            }
            else
            {
                rushOrderCost = 0;
            }
            return rushOrderCost;
        }

        public decimal computeDeskSizeCost()
        {
            decimal totalSurfaceArea = computeSurfaceArea(_desk.Width, _desk.Depth);
            decimal totalDeskSizeCost;
            const decimal BASE_DESK_PRICE = 200;

            if (totalSurfaceArea > 1000)
            {
                totalDeskSizeCost = BASE_DESK_PRICE + (totalSurfaceArea - 1000);
            }
            else
            {
                totalDeskSizeCost = BASE_DESK_PRICE;
            }

            return totalDeskSizeCost;
        }

        public decimal computeDrawerCost()
        {
            return _desk.NumberOfDrawer * 50;
        }

        public decimal computeSurfaceMaterialCost()
        {
            decimal surfaceMaterialCost;
            switch (_desk.SurfaceMaterial)
            {
                case "Oak":
                    surfaceMaterialCost = 200;
                    break;
                case "Laminate":
                    surfaceMaterialCost = 100;
                    break;
                case "Pine":
                    surfaceMaterialCost = 50;
                    break;
                case "Rosewood":
                    surfaceMaterialCost = 300;
                    break;
                case "Veneer":
                    surfaceMaterialCost = 125;
                    break;
                default:
                    surfaceMaterialCost = 0;
                    break;
            }

            return surfaceMaterialCost;
        }

        public decimal computeDeskPrice()
        {
            decimal totalDeskSizeCost = computeDeskSizeCost();
            decimal totalDrawerAmount = computeDrawerCost();
            decimal surfaceMaterialCost = computeSurfaceMaterialCost();
            decimal shippingCost = computeShippingCost();

            return totalDeskSizeCost + totalDrawerAmount + surfaceMaterialCost + shippingCost;

        }
        //The following function creates the .json file in the /bin folder
        public void saveDeskQuoteJS (DeskQuote dq)
        {

            //Create the new object that uses public variables in order to access information to create the json file.
            PublicDesk deskJs = new PublicDesk();

            //populating all the public class variables
            deskJs._pCustomerName = dq._customerName;
            deskJs._pDateCreated = dq._shippingDate;
            deskJs._pWidth = dq._desk.Width;
            deskJs._pDepth = dq._desk.Depth;
            deskJs._pTotalSurfaceArea = $"{Math.Round(computeSurfaceArea(deskJs._pWidth, deskJs._pDepth), 2)}";
            deskJs._pSizeCost = Math.Round(computeDeskSizeCost(), 2).ToString("F");
            deskJs._pDrawerCost = Math.Round(computeDrawerCost(), 2).ToString("F");
            deskJs._pMaterial = dq._desk.SurfaceMaterial; ;
            deskJs._pMaterialCost = Math.Round(computeSurfaceMaterialCost(), 2).ToString("F");
            string shippingMethod = null;
            deskJs._pRushOptionDays = dq._desk.RushOrderDay;
            if (deskJs._pRushOptionDays != 14)
            {
                shippingMethod = $"Rush - {deskJs._pRushOptionDays} Days";
            }
            else
            {
                shippingMethod = $"Normal - {deskJs._pRushOptionDays} Days";
            }
            deskJs._pShippingCost = Math.Round(computeShippingCost(), 2).ToString("F");
            deskJs._pTotalCost = Math.Round(computeDeskPrice(), 2).ToString("F");

            //This variable is actually the string written in a json format
            string json = JsonConvert.SerializeObject(deskJs);

            //the following creates the json file. 
            string path = @"qoutesJs.json";
            // This text is added only once to the file
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {

                    sw.WriteLine(json);
                }
            }
            else 
            // This text is always added, making file longer over time
            // if not deleted
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(json);
            }

        }

        public void saveDeskQuote(DeskQuote dq)
        {
            _dq = new List<DeskQuote>();
            _dq.Add(dq);

            // DeskQoute
            string customerName = dq._customerName;
            DateTime dateCreated = dq._shippingDate;

            decimal width = dq._desk.Width;
            decimal depth = dq._desk.Depth;
            //string totalSurfaceArea = $"{Math.Round(dq._desk.computeSurfaceArea(width, depth), 2)}";
            string totalSurfaceArea = $"{Math.Round(computeSurfaceArea(width, depth), 2)}";

            //string sizeCost = Math.Round(dq._desk.computeDeskSizeCost(), 2).ToString("F");
            string sizeCost = Math.Round(computeDeskSizeCost(), 2).ToString("F");

            // Drawer
            //string drawerCost = Math.Round(dq._desk.computeDrawerCost(), 2).ToString("F");
            string drawerCost = Math.Round(computeDrawerCost(), 2).ToString("F");

            // Surface material
            string material = dq._desk.SurfaceMaterial;
            //string materialCost = Math.Round(dq._desk.computeSurfaceMaterialCost(), 2).ToString("F");
            string materialCost = Math.Round(computeSurfaceMaterialCost(), 2).ToString("F");

            // Shipping details
            string shippingMethod = null;
            int rushOptionDays = dq._desk.RushOrderDay;
            if (rushOptionDays != 14)
            {
                shippingMethod = $"Rush - {rushOptionDays} Days";
            }
            else
            {
                shippingMethod = $"Normal - {rushOptionDays} Days";
            }

            //string shippingCost = Math.Round(dq._desk.computeShippingCost(), 2).ToString("F");
            string shippingCost = Math.Round(computeShippingCost(), 2).ToString("F");

            // Total cost
            //string totalCost = Math.Round(dq._desk.computeDeskPrice(), 2).ToString("F");
            string totalCost = Math.Round(computeDeskPrice(), 2).ToString("F");

            string deskQuote = $"{customerName}, {dateCreated}, {totalSurfaceArea}, " +
                        $"{sizeCost}, {drawerCost}, {material}, {materialCost}, {shippingMethod}, " +
                        $"{shippingCost}, {totalCost}";

            string path = @"qoutes.txt";
            // This text is added only once to the file
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    
                    sw.WriteLine(deskQuote);
                }
            }

            // This text is always added, making file longer over time
            // if not deleted
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(deskQuote);
            }

            // Declare path that will store the json data.
            string jsonPath = @"quotes.json";

            if (!File.Exists(jsonPath))
            {
                // Initialize a list that will hold the desk quotations.
                List<DeskQuote> serializedDeskQuote = new List<DeskQuote>();
                serializedDeskQuote.Add(dq);

                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(jsonPath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    // Serialize then write list to file.
                    serializer.Serialize(writer, serializedDeskQuote);
                }

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
                // Append new desk quotation to list.
                deskQuotes.Add(dq);

                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(jsonPath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    // Serialize then write list to file.
                    serializer.Serialize(writer, deskQuotes);
                }
            }
        } 

        public void displayDeskQuotes()
        {
            foreach(var dq in _dq)
            {
                Console.WriteLine($"Customer Name: {dq._customerName}, Shipping Date: {dq._shippingDate}, Total Desk Price: {computeDeskPrice()}");
            }
        }

        public override string ToString()
        {
            string deskQuote = null;
            deskQuote += $"Name: {_customerName} Width: {_desk.Width}";
            return deskQuote;
            //return base.ToString();
        }
    }
}
