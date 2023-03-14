namespace Vaktija
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExcelFajla = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxZora = new System.Windows.Forms.TextBox();
            this.textBoxIzlazak = new System.Windows.Forms.TextBox();
            this.textBoxPodne = new System.Windows.Forms.TextBox();
            this.textBoxIkindija = new System.Windows.Forms.TextBox();
            this.textBoxAksam = new System.Windows.Forms.TextBox();
            this.textBoxJacija = new System.Windows.Forms.TextBox();
            this.ezaniZora = new System.Windows.Forms.CheckBox();
            this.ezaniIzlazak = new System.Windows.Forms.CheckBox();
            this.ezaniPodne = new System.Windows.Forms.CheckBox();
            this.ezaniIkindija = new System.Windows.Forms.CheckBox();
            this.ezaniAksam = new System.Windows.Forms.CheckBox();
            this.ezaniJacija = new System.Windows.Forms.CheckBox();
            this.numericZora = new System.Windows.Forms.NumericUpDown();
            this.numericIzlazak = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ezanZora = new System.Windows.Forms.Button();
            this.ezanIzlazak = new System.Windows.Forms.Button();
            this.ezanPodne = new System.Windows.Forms.Button();
            this.ezanIkindija = new System.Windows.Forms.Button();
            this.ezanAksam = new System.Windows.Forms.Button();
            this.ezanJacija = new System.Windows.Forms.Button();
            this.openFileDialogMp3 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.TesterPojacivac = new NAudio.Gui.VolumeSlider();
            this.groupBoxTester = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxTest = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLastEvent = new System.Windows.Forms.Label();
            this.checkBoxMujezin = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxDoNamaza = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSlijedeciNamaz = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxSlijedeciNamazLbl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSada = new System.Windows.Forms.TextBox();
            this.timerSada = new System.Windows.Forms.Timer(this.components);
            this.volumeSliderZora = new NAudio.Gui.VolumeSlider();
            this.volumeSliderIzlazak = new NAudio.Gui.VolumeSlider();
            this.volumeSliderPodne = new NAudio.Gui.VolumeSlider();
            this.volumeSliderIkindija = new NAudio.Gui.VolumeSlider();
            this.volumeSliderAksam = new NAudio.Gui.VolumeSlider();
            this.volumeSliderJacija = new NAudio.Gui.VolumeSlider();
            this.checkBoxPodne = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericZora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIzlazak)).BeginInit();
            this.groupBoxTester.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBoxExcelFajla
            // 
            resources.ApplyResources(this.textBoxExcelFajla, "textBoxExcelFajla");
            this.textBoxExcelFajla.Name = "textBoxExcelFajla";
            this.textBoxExcelFajla.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialogExcel
            // 
            this.openFileDialogExcel.FileName = "openFileDialog1";
            // 
            // monthCalendar1
            // 
            resources.ApplyResources(this.monthCalendar1, "monthCalendar1");
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // textBoxZora
            // 
            resources.ApplyResources(this.textBoxZora, "textBoxZora");
            this.textBoxZora.Name = "textBoxZora";
            this.textBoxZora.ReadOnly = true;
            // 
            // textBoxIzlazak
            // 
            resources.ApplyResources(this.textBoxIzlazak, "textBoxIzlazak");
            this.textBoxIzlazak.Name = "textBoxIzlazak";
            this.textBoxIzlazak.ReadOnly = true;
            // 
            // textBoxPodne
            // 
            resources.ApplyResources(this.textBoxPodne, "textBoxPodne");
            this.textBoxPodne.Name = "textBoxPodne";
            this.textBoxPodne.ReadOnly = true;
            // 
            // textBoxIkindija
            // 
            resources.ApplyResources(this.textBoxIkindija, "textBoxIkindija");
            this.textBoxIkindija.Name = "textBoxIkindija";
            this.textBoxIkindija.ReadOnly = true;
            // 
            // textBoxAksam
            // 
            resources.ApplyResources(this.textBoxAksam, "textBoxAksam");
            this.textBoxAksam.Name = "textBoxAksam";
            this.textBoxAksam.ReadOnly = true;
            // 
            // textBoxJacija
            // 
            resources.ApplyResources(this.textBoxJacija, "textBoxJacija");
            this.textBoxJacija.Name = "textBoxJacija";
            this.textBoxJacija.ReadOnly = true;
            // 
            // ezaniZora
            // 
            resources.ApplyResources(this.ezaniZora, "ezaniZora");
            this.ezaniZora.Name = "ezaniZora";
            this.ezaniZora.UseVisualStyleBackColor = true;
            this.ezaniZora.CheckedChanged += new System.EventHandler(this.ezaniZora_CheckedChanged);
            // 
            // ezaniIzlazak
            // 
            resources.ApplyResources(this.ezaniIzlazak, "ezaniIzlazak");
            this.ezaniIzlazak.Name = "ezaniIzlazak";
            this.ezaniIzlazak.UseVisualStyleBackColor = true;
            this.ezaniIzlazak.CheckedChanged += new System.EventHandler(this.ezaniZora_CheckedChanged);
            // 
            // ezaniPodne
            // 
            resources.ApplyResources(this.ezaniPodne, "ezaniPodne");
            this.ezaniPodne.Name = "ezaniPodne";
            this.ezaniPodne.UseVisualStyleBackColor = true;
            this.ezaniPodne.CheckedChanged += new System.EventHandler(this.ezaniZora_CheckedChanged);
            // 
            // ezaniIkindija
            // 
            resources.ApplyResources(this.ezaniIkindija, "ezaniIkindija");
            this.ezaniIkindija.Name = "ezaniIkindija";
            this.ezaniIkindija.UseVisualStyleBackColor = true;
            this.ezaniIkindija.CheckedChanged += new System.EventHandler(this.ezaniZora_CheckedChanged);
            // 
            // ezaniAksam
            // 
            resources.ApplyResources(this.ezaniAksam, "ezaniAksam");
            this.ezaniAksam.Name = "ezaniAksam";
            this.ezaniAksam.UseVisualStyleBackColor = true;
            this.ezaniAksam.CheckedChanged += new System.EventHandler(this.ezaniZora_CheckedChanged);
            // 
            // ezaniJacija
            // 
            resources.ApplyResources(this.ezaniJacija, "ezaniJacija");
            this.ezaniJacija.Name = "ezaniJacija";
            this.ezaniJacija.UseVisualStyleBackColor = true;
            this.ezaniJacija.CheckedChanged += new System.EventHandler(this.ezaniZora_CheckedChanged);
            // 
            // numericZora
            // 
            resources.ApplyResources(this.numericZora, "numericZora");
            this.numericZora.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            this.numericZora.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            -2147483648});
            this.numericZora.Name = "numericZora";
            this.numericZora.ValueChanged += new System.EventHandler(this.numericZora_ValueChanged);
            // 
            // numericIzlazak
            // 
            resources.ApplyResources(this.numericIzlazak, "numericIzlazak");
            this.numericIzlazak.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericIzlazak.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.numericIzlazak.Name = "numericIzlazak";
            this.numericIzlazak.ValueChanged += new System.EventHandler(this.numericIzlazak_ValueChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // ezanZora
            // 
            resources.ApplyResources(this.ezanZora, "ezanZora");
            this.ezanZora.Name = "ezanZora";
            this.ezanZora.UseVisualStyleBackColor = true;
            this.ezanZora.Click += new System.EventHandler(this.buttonEzanZora_Click);
            // 
            // ezanIzlazak
            // 
            resources.ApplyResources(this.ezanIzlazak, "ezanIzlazak");
            this.ezanIzlazak.Name = "ezanIzlazak";
            this.ezanIzlazak.UseVisualStyleBackColor = true;
            this.ezanIzlazak.Click += new System.EventHandler(this.buttonEzanZora_Click);
            // 
            // ezanPodne
            // 
            resources.ApplyResources(this.ezanPodne, "ezanPodne");
            this.ezanPodne.Name = "ezanPodne";
            this.ezanPodne.UseVisualStyleBackColor = true;
            this.ezanPodne.Click += new System.EventHandler(this.buttonEzanZora_Click);
            // 
            // ezanIkindija
            // 
            resources.ApplyResources(this.ezanIkindija, "ezanIkindija");
            this.ezanIkindija.Name = "ezanIkindija";
            this.ezanIkindija.UseVisualStyleBackColor = true;
            this.ezanIkindija.Click += new System.EventHandler(this.buttonEzanZora_Click);
            // 
            // ezanAksam
            // 
            resources.ApplyResources(this.ezanAksam, "ezanAksam");
            this.ezanAksam.Name = "ezanAksam";
            this.ezanAksam.UseVisualStyleBackColor = true;
            this.ezanAksam.Click += new System.EventHandler(this.buttonEzanZora_Click);
            // 
            // ezanJacija
            // 
            resources.ApplyResources(this.ezanJacija, "ezanJacija");
            this.ezanJacija.Name = "ezanJacija";
            this.ezanJacija.UseVisualStyleBackColor = true;
            this.ezanJacija.Click += new System.EventHandler(this.buttonEzanZora_Click);
            // 
            // openFileDialogMp3
            // 
            this.openFileDialogMp3.FileName = "openFileDialogMp3";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TesterPojacivac
            // 
            resources.ApplyResources(this.TesterPojacivac, "TesterPojacivac");
            this.TesterPojacivac.Name = "TesterPojacivac";
            this.TesterPojacivac.VolumeChanged += new System.EventHandler(this.TesterPojacivac_VolumeChanged);
            // 
            // groupBoxTester
            // 
            this.groupBoxTester.Controls.Add(this.label15);
            this.groupBoxTester.Controls.Add(this.label14);
            this.groupBoxTester.Controls.Add(this.button3);
            this.groupBoxTester.Controls.Add(this.comboBoxTest);
            this.groupBoxTester.Controls.Add(this.button2);
            this.groupBoxTester.Controls.Add(this.TesterPojacivac);
            resources.ApplyResources(this.groupBoxTester, "groupBoxTester");
            this.groupBoxTester.Name = "groupBoxTester";
            this.groupBoxTester.TabStop = false;
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxTest
            // 
            this.comboBoxTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTest.FormattingEnabled = true;
            this.comboBoxTest.Items.AddRange(new object[] {
            resources.GetString("comboBoxTest.Items"),
            resources.GetString("comboBoxTest.Items1"),
            resources.GetString("comboBoxTest.Items2"),
            resources.GetString("comboBoxTest.Items3"),
            resources.GetString("comboBoxTest.Items4"),
            resources.GetString("comboBoxTest.Items5")});
            resources.ApplyResources(this.comboBoxTest, "comboBoxTest");
            this.comboBoxTest.Name = "comboBoxTest";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLastEvent);
            this.groupBox1.Controls.Add(this.checkBoxMujezin);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBoxDoNamaza);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxSlijedeciNamaz);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxSlijedeciNamazLbl);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxSada);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // labelLastEvent
            // 
            resources.ApplyResources(this.labelLastEvent, "labelLastEvent");
            this.labelLastEvent.Name = "labelLastEvent";
            // 
            // checkBoxMujezin
            // 
            resources.ApplyResources(this.checkBoxMujezin, "checkBoxMujezin");
            this.checkBoxMujezin.Checked = true;
            this.checkBoxMujezin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMujezin.Name = "checkBoxMujezin";
            this.checkBoxMujezin.UseVisualStyleBackColor = true;
            this.checkBoxMujezin.CheckedChanged += new System.EventHandler(this.checkBoxMujezin_CheckedChanged);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // textBoxDoNamaza
            // 
            resources.ApplyResources(this.textBoxDoNamaza, "textBoxDoNamaza");
            this.textBoxDoNamaza.Name = "textBoxDoNamaza";
            this.textBoxDoNamaza.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // textBoxSlijedeciNamaz
            // 
            resources.ApplyResources(this.textBoxSlijedeciNamaz, "textBoxSlijedeciNamaz");
            this.textBoxSlijedeciNamaz.Name = "textBoxSlijedeciNamaz";
            this.textBoxSlijedeciNamaz.ReadOnly = true;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // textBoxSlijedeciNamazLbl
            // 
            resources.ApplyResources(this.textBoxSlijedeciNamazLbl, "textBoxSlijedeciNamazLbl");
            this.textBoxSlijedeciNamazLbl.Name = "textBoxSlijedeciNamazLbl";
            this.textBoxSlijedeciNamazLbl.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // textBoxSada
            // 
            resources.ApplyResources(this.textBoxSada, "textBoxSada");
            this.textBoxSada.Name = "textBoxSada";
            this.textBoxSada.ReadOnly = true;
            // 
            // timerSada
            // 
            this.timerSada.Interval = 5000;
            this.timerSada.Tick += new System.EventHandler(this.timerSada_Tick);
            // 
            // volumeSliderZora
            // 
            resources.ApplyResources(this.volumeSliderZora, "volumeSliderZora");
            this.volumeSliderZora.Name = "volumeSliderZora";
            this.volumeSliderZora.VolumeChanged += new System.EventHandler(this.volumeSliderZora_VolumeChanged);
            // 
            // volumeSliderIzlazak
            // 
            resources.ApplyResources(this.volumeSliderIzlazak, "volumeSliderIzlazak");
            this.volumeSliderIzlazak.Name = "volumeSliderIzlazak";
            this.volumeSliderIzlazak.VolumeChanged += new System.EventHandler(this.volumeSliderZora_VolumeChanged);
            // 
            // volumeSliderPodne
            // 
            resources.ApplyResources(this.volumeSliderPodne, "volumeSliderPodne");
            this.volumeSliderPodne.Name = "volumeSliderPodne";
            this.volumeSliderPodne.VolumeChanged += new System.EventHandler(this.volumeSliderZora_VolumeChanged);
            // 
            // volumeSliderIkindija
            // 
            resources.ApplyResources(this.volumeSliderIkindija, "volumeSliderIkindija");
            this.volumeSliderIkindija.Name = "volumeSliderIkindija";
            this.volumeSliderIkindija.VolumeChanged += new System.EventHandler(this.volumeSliderZora_VolumeChanged);
            // 
            // volumeSliderAksam
            // 
            resources.ApplyResources(this.volumeSliderAksam, "volumeSliderAksam");
            this.volumeSliderAksam.Name = "volumeSliderAksam";
            this.volumeSliderAksam.VolumeChanged += new System.EventHandler(this.volumeSliderZora_VolumeChanged);
            // 
            // volumeSliderJacija
            // 
            resources.ApplyResources(this.volumeSliderJacija, "volumeSliderJacija");
            this.volumeSliderJacija.Name = "volumeSliderJacija";
            this.volumeSliderJacija.VolumeChanged += new System.EventHandler(this.volumeSliderZora_VolumeChanged);
            // 
            // checkBoxPodne
            // 
            resources.ApplyResources(this.checkBoxPodne, "checkBoxPodne");
            this.checkBoxPodne.Name = "checkBoxPodne";
            this.checkBoxPodne.UseVisualStyleBackColor = true;
            this.checkBoxPodne.CheckedChanged += new System.EventHandler(this.checkBoxPodne_CheckedChanged);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBoxPodne);
            this.Controls.Add(this.volumeSliderJacija);
            this.Controls.Add(this.volumeSliderAksam);
            this.Controls.Add(this.volumeSliderIkindija);
            this.Controls.Add(this.volumeSliderPodne);
            this.Controls.Add(this.volumeSliderIzlazak);
            this.Controls.Add(this.volumeSliderZora);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTester);
            this.Controls.Add(this.ezanJacija);
            this.Controls.Add(this.ezanAksam);
            this.Controls.Add(this.ezanIkindija);
            this.Controls.Add(this.ezanPodne);
            this.Controls.Add(this.ezanIzlazak);
            this.Controls.Add(this.ezanZora);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericIzlazak);
            this.Controls.Add(this.numericZora);
            this.Controls.Add(this.ezaniJacija);
            this.Controls.Add(this.ezaniAksam);
            this.Controls.Add(this.ezaniIkindija);
            this.Controls.Add(this.ezaniPodne);
            this.Controls.Add(this.ezaniIzlazak);
            this.Controls.Add(this.ezaniZora);
            this.Controls.Add(this.textBoxJacija);
            this.Controls.Add(this.textBoxAksam);
            this.Controls.Add(this.textBoxIkindija);
            this.Controls.Add(this.textBoxPodne);
            this.Controls.Add(this.textBoxIzlazak);
            this.Controls.Add(this.textBoxZora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxExcelFajla);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericZora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIzlazak)).EndInit();
            this.groupBoxTester.ResumeLayout(false);
            this.groupBoxTester.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxExcelFajla;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private System.Windows.Forms.TextBox textBoxJacija;
        private System.Windows.Forms.TextBox textBoxAksam;
        private System.Windows.Forms.TextBox textBoxIkindija;
        private System.Windows.Forms.TextBox textBoxPodne;
        private System.Windows.Forms.TextBox textBoxIzlazak;
        private System.Windows.Forms.TextBox textBoxZora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NumericUpDown numericIzlazak;
        private System.Windows.Forms.NumericUpDown numericZora;
        private System.Windows.Forms.CheckBox ezaniJacija;
        private System.Windows.Forms.CheckBox ezaniAksam;
        private System.Windows.Forms.CheckBox ezaniIkindija;
        private System.Windows.Forms.CheckBox ezaniPodne;
        private System.Windows.Forms.CheckBox ezaniIzlazak;
        private System.Windows.Forms.CheckBox ezaniZora;
        private System.Windows.Forms.Button ezanJacija;
        private System.Windows.Forms.Button ezanAksam;
        private System.Windows.Forms.Button ezanPodne;
        private System.Windows.Forms.Button ezanIzlazak;
        private System.Windows.Forms.Button ezanZora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialogMp3;
        private System.Windows.Forms.Button ezanIkindija;
        private System.Windows.Forms.Button button2;
        private NAudio.Gui.VolumeSlider TesterPojacivac;
        private System.Windows.Forms.GroupBox groupBoxTester;
        private System.Windows.Forms.ComboBox comboBoxTest;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSada;
        private System.Windows.Forms.Timer timerSada;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxDoNamaza;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSlijedeciNamaz;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxSlijedeciNamazLbl;
        private System.Windows.Forms.CheckBox checkBoxMujezin;
        private NAudio.Gui.VolumeSlider volumeSliderZora;
        private NAudio.Gui.VolumeSlider volumeSliderIzlazak;
        private NAudio.Gui.VolumeSlider volumeSliderPodne;
        private NAudio.Gui.VolumeSlider volumeSliderIkindija;
        private NAudio.Gui.VolumeSlider volumeSliderAksam;
        private NAudio.Gui.VolumeSlider volumeSliderJacija;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBoxPodne;
        public System.Windows.Forms.Label labelLastEvent;
        private System.Windows.Forms.Button button4;
    }
}

