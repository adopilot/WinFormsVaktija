using NAudio.Wave;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaktija
{
    public partial class Form1 : Form
    {
        List<Satnica> vakti = new List<Satnica>();
        private IWavePlayer wavePlayer;
        private AudioFileReader audioFileReader;
        private DateTime danas;
        private DateTime sutra;
        private Satnica zaDanas;
        private Satnica zaSutra;
        private bool ukujisem = false;
        private TimeZoneInfo tzi = TimeZoneInfo.Local;

        public Form1()
        {
            InitializeComponent();

            openFileDialogMp3.Multiselect = false;
            openFileDialogMp3.Filter = "MP3 files (*.mp3)|*.mp3";
            refresh();
            timerSada.Enabled = true;
        }

        

        private List<Satnica> ucitajTxtDatoteku(string adreseFajle)
        {
            var satnice = new List<Satnica>();
            try
            {
                
                using (StreamReader sr = new StreamReader(path: adreseFajle))
                {

                    int i = 0;
                    string currentLine;
                    while ((currentLine = sr.ReadLine()) != null)
                    {
                        i++;
                        try
                        {
                            Satnica satnica = new Satnica();

                            /*varijanta sa babovima
                            string sep = "\t";
                            var red = currentLine.Split(sep.ToCharArray());
                            */
                            
                            var red = currentLine.Split(' ');

                            satnica.datum = DateTime.ParseExact(red[0], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                            satnica.zora = DateTime.ParseExact(red[0] + " " + red[2] + ":00", "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture);
                            satnica.izlazak = DateTime.ParseExact(red[0] + " " + red[3] + ":00", "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture);
                            satnica.podne = DateTime.ParseExact(red[0] + " " + red[4] + ":00", "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                            satnica.ikindija = DateTime.ParseExact(red[0] + " " + red[5] + ":00", "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                            satnica.aksam = DateTime.ParseExact(red[0] + " " + red[6] + ":00", "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                            satnica.jacija = DateTime.ParseExact(red[0] + " " + red[7] + ":00", "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                            satnice.Add(satnica);
                        }
                        catch (Exception exS)
                        {
                            Console.WriteLine("Nisam učitao red {0} sa excetipnom {1} \n {2} \n", i, exS.Message, currentLine);
                        }
                    }
                }
                this.labelLastEvent.Text = "Učitali smo VAKTIJU sa " + satnice.Count + (satnice.Count > 0 ? " datuma do datuma:" + satnice.Max(x => x.datum).ToString("dd.MM.yyyy") : " ");
            }
            catch (Exception ex)
            {
                this.labelLastEvent.Text = "Greška kod učitavanja vaktije iz TXT-a :" + ex.Message;
                MessageBox.Show("Nisam učitao datoeku " + ex.Message);
            }
            return satnice;
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogExcel.Multiselect = false;
            openFileDialogExcel.Title = "Odaberite TXT datotku sa Namaskim vremenima ";
            openFileDialogExcel.Filter = "TXT files (*.txt)|*.txt";

            var rezultati = openFileDialogExcel.ShowDialog();

            if (rezultati == DialogResult.OK)
            {
                Properties.Settings.Default.txtFajla = openFileDialogExcel.FileName;
                this.textBoxExcelFajla.Text = openFileDialogExcel.FileName;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
                refresh();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            this.comboBoxTest.DataSource = Enum.GetValues(typeof(Ezani));
            this.textBoxExcelFajla.Text = Properties.Settings.Default.txtFajla;

            vakti = ucitajTxtDatoteku(Properties.Settings.Default.txtFajla);

            ezanZora.Text = Path.GetFileName(Properties.Settings.Default.ezanZora);
            ezanIzlazak.Text = Path.GetFileName(Properties.Settings.Default.ezanIzlazak);
            ezanPodne.Text = Path.GetFileName(Properties.Settings.Default.ezanPodne);
            ezanIkindija.Text = Path.GetFileName(Properties.Settings.Default.ezanIkindija);
            ezanAksam.Text = Path.GetFileName(Properties.Settings.Default.ezanAksam);
            ezanJacija.Text = Path.GetFileName(Properties.Settings.Default.ezanJacija);

            this.numericIzlazak.Value = Properties.Settings.Default.korekcijaIzlazak;
            this.numericZora.Value = Properties.Settings.Default.korekcijaZora;

            this.ezaniZora.Checked = Properties.Settings.Default.ezaniZora;
            this.ezaniIzlazak.Checked = Properties.Settings.Default.ezaniIzlazak;
            this.ezaniPodne.Checked = Properties.Settings.Default.ezaniPodne;
            this.ezaniIkindija.Checked = Properties.Settings.Default.ezaniIkindija;
            this.ezaniAksam.Checked = Properties.Settings.Default.ezaniAksam;
            this.ezaniJacija.Checked = Properties.Settings.Default.ezaniJacija;

            foreach (SettingsProperty sp in Properties.Settings.Default.Properties)
            {
                if (sp.Name.Contains("volumeSlider"))
                {
                    var slider = (NAudio.Gui.VolumeSlider)this.Controls.Find(sp.Name,false).FirstOrDefault();

                    slider.Volume = (float)Properties.Settings.Default[sp.Name];

                }
            }

            checkBoxPodne.Checked = Properties.Settings.Default.checkBoxPodne;

            setVaktoviOnFormi(DateTime.Today);

            setujZaDanasIsutraVakte();
            timerSada_Tick(timerSada, new EventArgs());
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            setVaktoviOnFormi(e.Start);
        }
        private void setVaktoviOnFormi(DateTime date)
        {
            ResetujFormuVremena();
            if (vakti == null || vakti.Count == 0)
            {
                MessageBox.Show("Nemam učitane vakte i nemgu uštiamti namaska vremna");
                return;
            }
            var dan = vakti.Where(x => x.datum == date).FirstOrDefault(); 

            if (dan != null)
            {
                this.textBoxZora.Text = dan.zora.ToString("HH:mm");
                this.textBoxIzlazak.Text = dan.izlazak.ToString("HH:mm");
                this.textBoxPodne.Text = dan.podne.ToString("HH:mm");
                this.textBoxIkindija.Text = dan.ikindija.ToString("HH:mm");
                this.textBoxAksam.Text = dan.aksam.ToString("HH:mm");
                this.textBoxJacija.Text = dan.jacija.ToString("HH:mm");
            }


        }
        private void ResetujFormuVremena()
        {
            this.textBoxZora.Text = string.Empty;
            this.textBoxIzlazak.Text = string.Empty;
            this.textBoxPodne.Text = string.Empty;
            this.textBoxIkindija.Text = string.Empty;
            this.textBoxAksam.Text = string.Empty;
            this.textBoxJacija.Text = string.Empty;
        }

        private void buttonEzanZora_Click(object sender, EventArgs e)
        {
            var dugme = (Button)sender;
            openFileDialogMp3.FileName = string.Empty;
            openFileDialogMp3.Title = "Odaberite MP3 datoteku za ezan za " + dugme.Name.Replace("ezan","");

            var result = openFileDialogMp3.ShowDialog();

            if (result == DialogResult.OK)
            {
                Properties.Settings.Default[dugme.Name] = openFileDialogMp3.FileName;
                dugme.Text = Path.GetFileNameWithoutExtension(openFileDialogMp3.FileName);
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
        }

        private void numericZora_ValueChanged(object sender, EventArgs e)
        {
            int i = 0;

            var a = (NumericUpDown)sender;

            Properties.Settings.Default.korekcijaZora = int.Parse(a.Value.ToString());

            setujZaDanasIsutraVakte();

            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void numericIzlazak_ValueChanged(object sender, EventArgs e)
        {
            int i = 0;

            var a = (NumericUpDown)sender;

            Properties.Settings.Default.korekcijaIzlazak = int.Parse(a.Value.ToString());
            setujZaDanasIsutraVakte();
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void ezaniZora_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            Properties.Settings.Default[cb.Name] = cb.Checked;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();

        }

        private void button2_Click(object sender, EventArgs e)
        { 

            if (wavePlayer != null && wavePlayer.PlaybackState == PlaybackState.Playing)
            {
                return;
            }

            Ezani ezani = Ezani.Podne;

            Enum.TryParse<Ezani>(comboBoxTest.SelectedValue.ToString(), out ezani);


            string ezanProperti = "ezan" + ezani.ToString();
            string ezanFajla = Properties.Settings.Default[ezanProperti].ToString();



            try
            {
                Debug.Assert(wavePlayer == null);
                wavePlayer = CreateWavePlayer();
                audioFileReader = new AudioFileReader(ezanFajla);
                audioFileReader.Volume = TesterPojacivac.Volume;
                wavePlayer.PlaybackStopped += WavePlayer_PlaybackStopped;
                wavePlayer.Init(audioFileReader);
                wavePlayer.Play();
            }
            catch (Exception ex)
            {
                stopPlayer();
                this.labelLastEvent.Text = "Greška kod testiranja ezana:" + ex.Message;
                MessageBox.Show("Nisam uspijeo testirati sa greškom \n" + ex.Message);

            }
            
        }

        private void WavePlayer_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            ukujisem = false;
            Debug.Assert(!InvokeRequired, "PlaybackStopped on wrong thread");

            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
            if (wavePlayer != null)
            {
                wavePlayer.Dispose();
                wavePlayer = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stopPlayer();
        }

        private void stopPlayer()
        {
            ukujisem = false;
            if (wavePlayer != null)
            {
                wavePlayer.Stop();
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
            if (wavePlayer != null)
            {
                wavePlayer.Dispose();
                wavePlayer = null;
            }
        }

        private IWavePlayer CreateWavePlayer()
        {
                    return new WaveOut();
        }

        private void setujZaDanasIsutraVakte()
        {
            danas = DateTime.Today;
            sutra = DateTime.Today.AddDays(1);


            if (vakti != null && vakti.Count > 0)
            {
                zaDanas = vakti.Where(x => x.datum == danas).FirstOrDefault();
                zaSutra = vakti.Where(x => x.datum == sutra).FirstOrDefault();

                if (zaSutra == null || zaDanas == null)
                {
                    MessageBox.Show("Nisam našao satnicu za danas ili sutra, molimo Vas provjeirte txt datoku i uključite mujesina ponovo");
                }

                if (zaSutra != null )
                {
                    zaDanas.zora = zaDanas.zora.AddMinutes(int.Parse(numericZora.Value.ToString()));
                    zaDanas.izlazak = zaDanas.izlazak.AddMinutes(int.Parse(numericIzlazak.Value.ToString()));
                }
                if (zaSutra != null)
                {
                    zaSutra.zora = zaSutra.zora.AddMinutes(int.Parse(numericZora.Value.ToString()));
                    zaSutra.izlazak = zaSutra.izlazak.AddMinutes(int.Parse(numericIzlazak.Value.ToString()));
                }
            }
            else
            {
                checkBoxMujezin.Checked = false;

                MessageBox.Show("Nisam učitao vaktiju iz TXT-a molim vas provjerite postavke \n Molimo vas provjerite postavke i uključte mujezina ponvo","Nemam podataka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerSada_Tick(object sender, EventArgs e)
        {
           
            textBoxSada.Text = DateTime.Now.ToString("HH:mm:ss");

            if (zaDanas == null || zaSutra == null)
            {

                goto kraj;
            }
            if (DateTime.Today != danas)
            {
                labelLastEvent.Text = "Novi dan nova nafaka"+DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                setujZaDanasIsutraVakte();
                if (zaDanas == null || zaSutra == null)
                {
                    goto kraj;
                }

            }
            var sada = RoundUp();
            if (!ukujisem)
            {
                if (zaDanas.zora == sada)
                {
                    Ukuisi(Ezani.Zora);
                }
                else if (zaDanas.izlazak == sada)
                {
                    Ukuisi(Ezani.Izlazak);
                }
                else if (zaDanas.podne == sada && !checkBoxPodne.Checked)
                {
                    Ukuisi(Ezani.Podne);
                }
                else if (checkBoxPodne.Checked && sada.Hour == 12 && sada.Minute ==0 && !tzi.IsDaylightSavingTime(sada)  )
                {
                    Ukuisi(Ezani.Podne);
                }
                else if (checkBoxPodne.Checked && sada.Hour == 13 && sada.Minute == 0 && tzi.IsDaylightSavingTime(sada))
                {
                    Ukuisi(Ezani.Podne);
                }
                else if (zaDanas.ikindija == sada)
                {
                    Ukuisi(Ezani.Ikindija);
                }
                else if (zaDanas.aksam == sada)
                {
                    Ukuisi(Ezani.Aksam);
                }
                else if (zaDanas.jacija == sada)
                {
                    Ukuisi(Ezani.Jacija);
                }
            }

            if (sada < zaDanas.zora)
            {
                SetMujezinTimers(Ezani.Zora, zaDanas.zora);
            }
            else if (sada < zaDanas.izlazak)
            {
                SetMujezinTimers(Ezani.Izlazak, zaDanas.izlazak);
            }
            else if (sada < zaDanas.podne   && !checkBoxPodne.Checked)
            {
                SetMujezinTimers(Ezani.Podne, zaDanas.podne);
            }
            else if (checkBoxPodne.Checked && sada.Hour < 12  && !tzi.IsDaylightSavingTime(sada))
            {
                DateTime dateTimePodne = new DateTime();
                dateTimePodne = DateTime.Today.AddHours(12);
                SetMujezinTimers(Ezani.Podne, dateTimePodne);
            }
            else if (checkBoxPodne.Checked && sada.Hour < 13 && tzi.IsDaylightSavingTime(sada))
            {
                DateTime dateTimePodne = new DateTime();
                dateTimePodne = DateTime.Today.AddHours(13);
                SetMujezinTimers(Ezani.Podne, dateTimePodne);
            }
            else if (sada < zaDanas.ikindija)
            {
                SetMujezinTimers(Ezani.Ikindija, zaDanas.ikindija);
            }
            else if (sada < zaDanas.aksam)
            {
                SetMujezinTimers(Ezani.Aksam, zaDanas.aksam);
            }
            else if (sada < zaDanas.jacija)
            {
                SetMujezinTimers(Ezani.Jacija, zaDanas.jacija);
            }
            else if (sada > zaDanas.jacija && sada < zaSutra.izlazak)
            {
                SetMujezinTimers(Ezani.Izlazak, zaSutra.izlazak);
            }
            kraj:
            Console.WriteLine("kraj");
        }

        private void SetMujezinTimers(Ezani ezan, DateTime vakat)
        {
            textBoxSlijedeciNamaz.Text = vakat.ToString("HH:mm");

            var minuta = vakat -DateTime.Now  ;

            textBoxDoNamaza.Text = minuta.Hours.ToString() + ":" + minuta.Minutes.ToString() + ":" + minuta.Seconds.ToString();

            switch (ezan)
            {
                case Ezani.Zora:
                    textBoxSlijedeciNamazLbl.Text = "Zora";
                    break;
                case Ezani.Izlazak:
                    textBoxSlijedeciNamazLbl.Text = "Izlazak sunca";
                    break;
                case Ezani.Podne:
                    textBoxSlijedeciNamazLbl.Text = "Podne";
                    break;
                case Ezani.Ikindija:
                    textBoxSlijedeciNamazLbl.Text = "Ikindija";
                    break;
                case Ezani.Aksam:
                    textBoxSlijedeciNamazLbl.Text = "Akšam";
                    break;
                case Ezani.Jacija:
                        textBoxSlijedeciNamazLbl.Text = "Jacija";
                    break;
            }
        }

        private void Ukuisi(Ezani ezan)
        {
            if (ukujisem)
            {
                return;
            }
            if (wavePlayer != null && wavePlayer.PlaybackState == PlaybackState.Playing)
            {
                return;
            }
            var cehcBox = (CheckBox)this.Controls.Find("ezani" + ezan.ToString(),true).FirstOrDefault();
            if (!cehcBox.Checked)
            {
                return;
            }

            string ezanProperti = "ezan" + ezan.ToString();
            string ezanFajla = Properties.Settings.Default[ezanProperti].ToString();

            string sslider = "volumeSlider" + ezan.ToString();

            var slider = (NAudio.Gui.VolumeSlider)this.Controls.Find(sslider, false).FirstOrDefault();

            
            try
            {
                Debug.Assert(wavePlayer == null);
                wavePlayer = CreateWavePlayer();
                audioFileReader = new AudioFileReader(ezanFajla);
                audioFileReader.Volume = slider.Volume;
                wavePlayer.PlaybackStopped += WavePlayer_PlaybackStopped;
                wavePlayer.Init(audioFileReader);
                wavePlayer.Play();
                ukujisem = true;
                this.labelLastEvent.Text = "Ukujišem ezan za  namaz: " + ezan.ToString();
            }
            catch (Exception ex)
            {
                stopPlayer();
                this.labelLastEvent.Text = "Nisam upiejo ezaniti " + ezan.ToString() + " sa ex" + ex.Message;
            }


            

            


        }

        private DateTime RoundUp()
        {
            DateTime dt = DateTime.Now;
            var d = TimeSpan.FromMinutes(1);
            return new DateTime(((dt.Ticks + d.Ticks - 1) / d.Ticks) * d.Ticks);
        }

        private void checkBoxMujezin_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            timerSada.Enabled = cb.Checked;
            
            if (!cb.Checked)
            {
                textBoxSada.Text = "Mujezin je";
                textBoxSlijedeciNamazLbl.Text = "gašen, upalite";
                textBoxSlijedeciNamaz.Text = "isti za";
                textBoxDoNamaza.Text = "vremena";
                ukujisem = false;
                stopPlayer();
                cb.Text = "Isključen";

            }
            else
            {
                this.labelLastEvent.Text = "Mujezin upaljen" + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                timerSada_Tick(timerSada, new EventArgs());
                cb.Text = "Uključen";
            }

        }

        public enum Ezani { Zora,Izlazak,Podne,Ikindija,Aksam,Jacija }

        private void buttonStopEzan_Click(object sender, EventArgs e)
        {
            stopPlayer();
        }

        private void volumeSliderZora_VolumeChanged(object sender, EventArgs e)
        {
            var slider = (NAudio.Gui.VolumeSlider)sender;
            Properties.Settings.Default[slider.Name] = slider.Volume;
            Properties.Settings.Default.Save();

        }

        private void TesterPojacivac_VolumeChanged(object sender, EventArgs e)
        {
            if (wavePlayer != null && wavePlayer.PlaybackState == PlaybackState.Playing && audioFileReader != null )
            {
                var volume = (NAudio.Gui.VolumeSlider)sender;
                audioFileReader.Volume = volume.Volume;
            }
        }

        private void checkBoxPodne_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.checkBoxPodne = checkBoxPodne.Checked;
            Properties.Settings.Default.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var json = File.ReadAllText(System.IO.Path.Combine(Environment.CurrentDirectory, "VaktijaJson.txt"));
            var data = JsonConvert.DeserializeObject<Models.Root>(json);

            

        }
    }
}
