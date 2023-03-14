using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaktija.Models;

namespace Vaktija
{
    public partial class ApiDownload : Form
    {
        public string Path { get; set; }
        private string[] lokacije;
        private int lokacija = -1;

        public ApiDownload()
        {
            InitializeComponent();
            this.godinaNumeric.Minimum = 2023;
            this.godinaNumeric.Maximum = 2100;

            this.godinaNumeric.Value = DateTime.Today.Year;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var ado = await SpasiDatoteku();
            if (ado)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private async void ApiDownload_Load(object sender, EventArgs e)
        {
            await UcitajLokacije();
        }
        private async Task UcitajLokacije()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
                client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");


                var json = await client.GetStringAsync("https://api.vaktija.ba/vaktija/v1/lokacije");


                lokacije = JsonConvert.DeserializeObject<string[]>(json);

                this.comboBox1.Items.AddRange(lokacije);
            }


        }
        private async Task<bool> SpasiDatoteku()
        {
            var lokacija = this.comboBox1.SelectedItem as string;
            if (string.IsNullOrEmpty(lokacija))
            {
                MessageBox.Show("Odaberite lokaciju");
                return false;
            }

            int ix = Array.IndexOf(lokacije, lokacija);
            if (ix < 0)
            {
                MessageBox.Show("Netšo nije uredu ix lokacije ti ne valja");
                return false;
            }


            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
                client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");


                var json = await client.GetStringAsync($"https://api.vaktija.ba/vaktija/v1/{ix}/{this.godinaNumeric.Value}");

                VaktijaModel model = JsonConvert.DeserializeObject<VaktijaModel>(json);

                if (model == null)
                {
                    MessageBox.Show("Nešto nije urdu sa podatcimsa va vaktija api-a");
                    return false;
                }

                this.Path = System.IO.Path.Combine(Environment.CurrentDirectory, $"vakts_{ix}_{this.godinaNumeric.Value}.txt");

                if (File.Exists(this.Path))
                {
                    try
                    {
                        File.Delete(Path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Nisam uspijeo pregaziti datotkeu");
                        return false;
                    }
                }
                File.WriteAllText(this.Path, json);

                return true;
            }
        }
    }
}
