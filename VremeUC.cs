using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Web;


namespace asistent_virtual
{
    public partial class VremeUC : UserControl
    {
        public VremeUC()
        {
            InitializeComponent();

        }

        static readonly HttpClient client = new HttpClient();
        static async Task<(float, float)> Locatie()
        {
            float latd, longi;
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://ipinfo.io/json");
                response.EnsureSuccessStatusCode();
                dynamic responseBody = await response.Content.ReadAsStringAsync();
                dynamic json = JsonConvert.DeserializeObject(responseBody);
                string oras = json.GetValue("city");
                string loc = json.GetValue("loc");
                string lat = String.Empty, lon = String.Empty;
                int i = 0;
                bool gasit = false;

                while ((i < loc.Length) && (!loc[i].Equals("\"")))
                {

                    if (loc[i].Equals(','))
                    {
                        gasit = true;
                        i++;
                        continue;
                    }
                    if (gasit == false)
                    {
                        lat += loc[i];
                    }
                    else
                    {
                        lon += loc[i];
                    }

                    i++;
                }

                latd = Convert.ToSingle(lat);
                longi = Convert.ToSingle(lon);

                return (latd, longi);
            }

            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return (-1, -1);
            }
        }

        public dynamic alegere { get; set; }
        public dynamic alegere2 { get; set; }

        static async Task<dynamic> Vreme(float lat, float lon)
        {
            try
            {

                string url = "https://api.openweathermap.org/data/2.5/onecall?lat=" + lat.ToString() + "&lon=" + lon.ToString() + "&units=metric&lang=ro&appid=";// pune API ul tau
                HttpResponseMessage rasp = await client.GetAsync(url);
                rasp.EnsureSuccessStatusCode();
                dynamic rf = await rasp.Content.ReadAsStringAsync();
                dynamic RVreme = JsonConvert.DeserializeObject(rf);
                return RVreme;
            }


            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return 0;
            }
        }

            private async Task Vre()
            {
                float latitudine = 0f, longitudine = 0f;
                var zona = await Locatie();
                if (zona == (-1, -1))
                {
                    MessageBox.Show("Ceva nu a mers bine! Verifica daca ai o conexiune la internet!");
                    return;
                }
                (latitudine, longitudine) = zona;
                var rezultat = await Vreme(latitudine, longitudine);
                if (rezultat != null)
                {

                    double aux = rezultat.GetValue("current").GetValue("dt"); // ora in secunde
                    double aux_2 = rezultat.GetValue("timezone_offset"); //fusul orar
                    string ora = Form1.Conversie_ora(aux, aux_2, 1); //stocata ora finala

                    float temp = rezultat.GetValue("current").GetValue("temp");
                    label2.Text = "Now " + ora;
                    label3.Text = "Temperatura " + (((int)temp).ToString());
                    dynamic descriere = rezultat.GetValue("current").GetValue("weather");
                    label4.Text = descriere[0].GetValue("description");

                    var labels = new List<Label> { label5, label8, label11, label14 };
                    int i = 1;
                    foreach (var label in labels)    //temperatura
                    {
                        label.Text = "Temperatura " + ((int)((rezultat.GetValue("daily"))[i].GetValue("temp")).GetValue("day")).ToString();
                        i++;
                    }

                    labels = new List<Label> { label6, label9, label12, label15 };
                    i = 1;
                    foreach (var label in labels)               //ziua
                    {

                        aux = rezultat.GetValue("daily")[i].GetValue("dt");
                        label.Text = Form1.Conversie_ora(aux, 0, 0);
                        i++;
                    }

                    labels = new List<Label> { label7, label10, label13, label16 };
                    i = 1;
                    foreach (var label in labels)            //starea vremii
                    {

                        descriere = (rezultat.GetValue("daily")[i].GetValue("weather")[0]).GetValue("description");
                        label.Text = descriere;
                        i++;

                    }
                    labels = new List<Label> { label17, label20, label23, label26 };
                    i = 1;
                    foreach (var label in labels)            //pe ore 
                    {
                        aux = (rezultat.GetValue("hourly")[i]).GetValue("dt"); // ora in secunde
                        aux_2 = rezultat.GetValue("timezone_offset"); //fusul orar
                        ora = Form1.Conversie_ora(aux, aux_2, 1); //stocata ora finala
                        label.Text = ora;
                        i += 2;
                    }

                    labels = new List<Label> { label19, label22, label25, label28 };
                    i = 1;
                    foreach (var label in labels)            //pe ore temperatura
                    {
                        label.Text = "Temperatura " + ((int)((rezultat.GetValue("hourly"))[i].GetValue("temp"))).ToString();
                        i += 2;
                    }
                    labels = new List<Label> { label18, label21, label24, label27 };
                    i = 1;
                    foreach (var label in labels)            //pe ore starea vremii
                    {
                        descriere = (rezultat.GetValue("hourly")[i].GetValue("weather")[0]).GetValue("description");
                        label.Text = descriere;
                        i += 2;
                    }
                }
            }  
         

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
            alegere.Visible = true;
        }

        private void VremeUC_Load(object sender, EventArgs e)
        {
            Vre();
            label1.Text = alegere.label1.Text;

        }

        private void muzicabtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            alegere2.Visible = true;
            
            
        }

    }   
}

