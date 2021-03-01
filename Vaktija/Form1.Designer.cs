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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vremena ezana se nalaze u TXT datoteci";
            // 
            // textBoxExcelFajla
            // 
            this.textBoxExcelFajla.Location = new System.Drawing.Point(221, 17);
            this.textBoxExcelFajla.Name = "textBoxExcelFajla";
            this.textBoxExcelFajla.ReadOnly = true;
            this.textBoxExcelFajla.Size = new System.Drawing.Size(284, 20);
            this.textBoxExcelFajla.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nađi datoteku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialogExcel
            // 
            this.openFileDialogExcel.FileName = "openFileDialog1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 57);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Izazak sunca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Podne:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ikindija:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Akšam:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Jacija:";
            // 
            // textBoxZora
            // 
            this.textBoxZora.Location = new System.Drawing.Point(319, 62);
            this.textBoxZora.Name = "textBoxZora";
            this.textBoxZora.ReadOnly = true;
            this.textBoxZora.Size = new System.Drawing.Size(100, 20);
            this.textBoxZora.TabIndex = 11;
            // 
            // textBoxIzlazak
            // 
            this.textBoxIzlazak.Location = new System.Drawing.Point(319, 88);
            this.textBoxIzlazak.Name = "textBoxIzlazak";
            this.textBoxIzlazak.ReadOnly = true;
            this.textBoxIzlazak.Size = new System.Drawing.Size(100, 20);
            this.textBoxIzlazak.TabIndex = 12;
            // 
            // textBoxPodne
            // 
            this.textBoxPodne.Location = new System.Drawing.Point(319, 114);
            this.textBoxPodne.Name = "textBoxPodne";
            this.textBoxPodne.ReadOnly = true;
            this.textBoxPodne.Size = new System.Drawing.Size(100, 20);
            this.textBoxPodne.TabIndex = 13;
            // 
            // textBoxIkindija
            // 
            this.textBoxIkindija.Location = new System.Drawing.Point(319, 140);
            this.textBoxIkindija.Name = "textBoxIkindija";
            this.textBoxIkindija.ReadOnly = true;
            this.textBoxIkindija.Size = new System.Drawing.Size(100, 20);
            this.textBoxIkindija.TabIndex = 14;
            // 
            // textBoxAksam
            // 
            this.textBoxAksam.Location = new System.Drawing.Point(319, 166);
            this.textBoxAksam.Name = "textBoxAksam";
            this.textBoxAksam.ReadOnly = true;
            this.textBoxAksam.Size = new System.Drawing.Size(100, 20);
            this.textBoxAksam.TabIndex = 15;
            // 
            // textBoxJacija
            // 
            this.textBoxJacija.Location = new System.Drawing.Point(319, 192);
            this.textBoxJacija.Name = "textBoxJacija";
            this.textBoxJacija.ReadOnly = true;
            this.textBoxJacija.Size = new System.Drawing.Size(100, 20);
            this.textBoxJacija.TabIndex = 16;
            // 
            // ezaniZora
            // 
            this.ezaniZora.AutoSize = true;
            this.ezaniZora.Location = new System.Drawing.Point(434, 65);
            this.ezaniZora.Name = "ezaniZora";
            this.ezaniZora.Size = new System.Drawing.Size(52, 17);
            this.ezaniZora.TabIndex = 17;
            this.ezaniZora.Text = "Ezani";
            this.ezaniZora.UseVisualStyleBackColor = true;
            this.ezaniZora.CheckedChanged += new System.EventHandler(this.ezaniZora_CheckedChanged);
            // 
            // ezaniIzlazak
            // 
            this.ezaniIzlazak.AutoSize = true;
            this.ezaniIzlazak.Location = new System.Drawing.Point(434, 91);
            this.ezaniIzlazak.Name = "ezaniIzlazak";
            this.ezaniIzlazak.Size = new System.Drawing.Size(52, 17);
            this.ezaniIzlazak.TabIndex = 18;
            this.ezaniIzlazak.Text = "Ezani";
            this.ezaniIzlazak.UseVisualStyleBackColor = true;
            this.ezaniIzlazak.CheckedChanged += new System.EventHandler(this.ezaniZora_CheckedChanged);
            // 
            // ezaniPodne
            // 
            this.ezaniPodne.AutoSize = true;
            this.ezaniPodne.Location = new System.Drawing.Point(434, 114);
            this.ezaniPodne.Name = "ezaniPodne";
            this.ezaniPodne.Size = new System.Drawing.Size(52, 17);
            this.ezaniPodne.TabIndex = 19;
            this.ezaniPodne.Text = "Ezani";
            this.ezaniPodne.UseVisualStyleBackColor = true;
            this.ezaniPodne.CheckedChanged += new System.EventHandler(this.ezaniZora_CheckedChanged);
            // 
            // ezaniIkindija
            // 
            this.ezaniIkindija.AutoSize = true;
            this.ezaniIkindija.Location = new System.Drawing.Point(434, 142);
            this.ezaniIkindija.Name = "ezaniIkindija";
            this.ezaniIkindija.Size = new System.Drawing.Size(52, 17);
            this.ezaniIkindija.TabIndex = 20;
            this.ezaniIkindija.Text = "Ezani";
            this.ezaniIkindija.UseVisualStyleBackColor = true;
            this.ezaniIkindija.CheckedChanged += new System.EventHandler(this.ezaniZora_CheckedChanged);
            // 
            // ezaniAksam
            // 
            this.ezaniAksam.AutoSize = true;
            this.ezaniAksam.Location = new System.Drawing.Point(434, 168);
            this.ezaniAksam.Name = "ezaniAksam";
            this.ezaniAksam.Size = new System.Drawing.Size(52, 17);
            this.ezaniAksam.TabIndex = 21;
            this.ezaniAksam.Text = "Ezani";
            this.ezaniAksam.UseVisualStyleBackColor = true;
            this.ezaniAksam.CheckedChanged += new System.EventHandler(this.ezaniZora_CheckedChanged);
            // 
            // ezaniJacija
            // 
            this.ezaniJacija.AutoSize = true;
            this.ezaniJacija.Location = new System.Drawing.Point(434, 194);
            this.ezaniJacija.Name = "ezaniJacija";
            this.ezaniJacija.Size = new System.Drawing.Size(52, 17);
            this.ezaniJacija.TabIndex = 22;
            this.ezaniJacija.Text = "Ezani";
            this.ezaniJacija.UseVisualStyleBackColor = true;
            this.ezaniJacija.CheckedChanged += new System.EventHandler(this.ezaniZora_CheckedChanged);
            // 
            // numericZora
            // 
            this.numericZora.Location = new System.Drawing.Point(583, 64);
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
            this.numericZora.Size = new System.Drawing.Size(47, 20);
            this.numericZora.TabIndex = 23;
            this.numericZora.ValueChanged += new System.EventHandler(this.numericZora_ValueChanged);
            // 
            // numericIzlazak
            // 
            this.numericIzlazak.Location = new System.Drawing.Point(583, 91);
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
            this.numericIzlazak.Size = new System.Drawing.Size(47, 20);
            this.numericIzlazak.TabIndex = 24;
            this.numericIzlazak.ValueChanged += new System.EventHandler(this.numericIzlazak_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Korekcija minuta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Korekcija minuta";
            // 
            // ezanZora
            // 
            this.ezanZora.Location = new System.Drawing.Point(636, 60);
            this.ezanZora.Name = "ezanZora";
            this.ezanZora.Size = new System.Drawing.Size(136, 23);
            this.ezanZora.TabIndex = 27;
            this.ezanZora.Text = "ezanZora";
            this.ezanZora.UseVisualStyleBackColor = true;
            this.ezanZora.Click += new System.EventHandler(this.buttonEzanZora_Click);
            // 
            // ezanIzlazak
            // 
            this.ezanIzlazak.Location = new System.Drawing.Point(636, 87);
            this.ezanIzlazak.Name = "ezanIzlazak";
            this.ezanIzlazak.Size = new System.Drawing.Size(136, 23);
            this.ezanIzlazak.TabIndex = 28;
            this.ezanIzlazak.Text = "button3";
            this.ezanIzlazak.UseVisualStyleBackColor = true;
            this.ezanIzlazak.Click += new System.EventHandler(this.buttonEzanZora_Click);
            // 
            // ezanPodne
            // 
            this.ezanPodne.Location = new System.Drawing.Point(636, 112);
            this.ezanPodne.Name = "ezanPodne";
            this.ezanPodne.Size = new System.Drawing.Size(136, 23);
            this.ezanPodne.TabIndex = 29;
            this.ezanPodne.Text = "ezanPodne";
            this.ezanPodne.UseVisualStyleBackColor = true;
            this.ezanPodne.Click += new System.EventHandler(this.buttonEzanZora_Click);
            // 
            // ezanIkindija
            // 
            this.ezanIkindija.Location = new System.Drawing.Point(636, 138);
            this.ezanIkindija.Name = "ezanIkindija";
            this.ezanIkindija.Size = new System.Drawing.Size(136, 23);
            this.ezanIkindija.TabIndex = 30;
            this.ezanIkindija.Text = "ezanIkindija";
            this.ezanIkindija.UseVisualStyleBackColor = true;
            this.ezanIkindija.Click += new System.EventHandler(this.buttonEzanZora_Click);
            // 
            // ezanAksam
            // 
            this.ezanAksam.Location = new System.Drawing.Point(636, 164);
            this.ezanAksam.Name = "ezanAksam";
            this.ezanAksam.Size = new System.Drawing.Size(136, 23);
            this.ezanAksam.TabIndex = 31;
            this.ezanAksam.Text = "ezanAksam";
            this.ezanAksam.UseVisualStyleBackColor = true;
            this.ezanAksam.Click += new System.EventHandler(this.buttonEzanZora_Click);
            // 
            // ezanJacija
            // 
            this.ezanJacija.Location = new System.Drawing.Point(636, 190);
            this.ezanJacija.Name = "ezanJacija";
            this.ezanJacija.Size = new System.Drawing.Size(136, 23);
            this.ezanJacija.TabIndex = 32;
            this.ezanJacija.Text = "ezanAksam";
            this.ezanJacija.UseVisualStyleBackColor = true;
            this.ezanJacija.Click += new System.EventHandler(this.buttonEzanZora_Click);
            // 
            // openFileDialogMp3
            // 
            this.openFileDialogMp3.FileName = "openFileDialogMp3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TesterPojacivac
            // 
            this.TesterPojacivac.Location = new System.Drawing.Point(362, 38);
            this.TesterPojacivac.Name = "TesterPojacivac";
            this.TesterPojacivac.Size = new System.Drawing.Size(96, 16);
            this.TesterPojacivac.TabIndex = 34;
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
            this.groupBoxTester.Location = new System.Drawing.Point(15, 231);
            this.groupBoxTester.Name = "groupBoxTester";
            this.groupBoxTester.Size = new System.Drawing.Size(859, 65);
            this.groupBoxTester.TabIndex = 35;
            this.groupBoxTester.TabStop = false;
            this.groupBoxTester.Text = "Testni mujezin";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(301, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Glasnoća:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Ezan za namaz:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(609, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxTest
            // 
            this.comboBoxTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTest.FormattingEnabled = true;
            this.comboBoxTest.Items.AddRange(new object[] {
            "Zora",
            "Izlazak",
            "Podne",
            "Ikindija",
            "Aksam",
            "Jacija"});
            this.comboBoxTest.Location = new System.Drawing.Point(93, 35);
            this.comboBoxTest.Name = "comboBoxTest";
            this.comboBoxTest.Size = new System.Drawing.Size(194, 21);
            this.comboBoxTest.TabIndex = 35;
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
            this.groupBox1.Location = new System.Drawing.Point(15, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 139);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mujezin";
            // 
            // labelLastEvent
            // 
            this.labelLastEvent.AutoSize = true;
            this.labelLastEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastEvent.Location = new System.Drawing.Point(9, 96);
            this.labelLastEvent.Name = "labelLastEvent";
            this.labelLastEvent.Size = new System.Drawing.Size(357, 31);
            this.labelLastEvent.TabIndex = 9;
            this.labelLastEvent.Text = "Zadnji event ov je neki event";
            // 
            // checkBoxMujezin
            // 
            this.checkBoxMujezin.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxMujezin.AutoSize = true;
            this.checkBoxMujezin.Checked = true;
            this.checkBoxMujezin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMujezin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxMujezin.Location = new System.Drawing.Point(15, 41);
            this.checkBoxMujezin.Name = "checkBoxMujezin";
            this.checkBoxMujezin.Size = new System.Drawing.Size(72, 27);
            this.checkBoxMujezin.TabIndex = 8;
            this.checkBoxMujezin.Text = "Uključen";
            this.checkBoxMujezin.UseVisualStyleBackColor = true;
            this.checkBoxMujezin.CheckedChanged += new System.EventHandler(this.checkBoxMujezin_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(656, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Vrijeme do namaza";
            // 
            // textBoxDoNamaza
            // 
            this.textBoxDoNamaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDoNamaza.Location = new System.Drawing.Point(650, 28);
            this.textBoxDoNamaza.Name = "textBoxDoNamaza";
            this.textBoxDoNamaza.ReadOnly = true;
            this.textBoxDoNamaza.Size = new System.Drawing.Size(169, 53);
            this.textBoxDoNamaza.TabIndex = 6;
            this.textBoxDoNamaza.Text = "00:00:00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(522, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Vrijeme namaza";
            // 
            // textBoxSlijedeciNamaz
            // 
            this.textBoxSlijedeciNamaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSlijedeciNamaz.Location = new System.Drawing.Point(525, 28);
            this.textBoxSlijedeciNamaz.Name = "textBoxSlijedeciNamaz";
            this.textBoxSlijedeciNamaz.ReadOnly = true;
            this.textBoxSlijedeciNamaz.Size = new System.Drawing.Size(119, 53);
            this.textBoxSlijedeciNamaz.TabIndex = 4;
            this.textBoxSlijedeciNamaz.Text = "00:00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Slijedeći namaz";
            // 
            // textBoxSlijedeciNamazLbl
            // 
            this.textBoxSlijedeciNamazLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSlijedeciNamazLbl.Location = new System.Drawing.Point(268, 28);
            this.textBoxSlijedeciNamazLbl.Name = "textBoxSlijedeciNamazLbl";
            this.textBoxSlijedeciNamazLbl.ReadOnly = true;
            this.textBoxSlijedeciNamazLbl.Size = new System.Drawing.Size(251, 53);
            this.textBoxSlijedeciNamazLbl.TabIndex = 2;
            this.textBoxSlijedeciNamazLbl.Text = "Izlazak sunca";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Trenutno vrijeme";
            // 
            // textBoxSada
            // 
            this.textBoxSada.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSada.Location = new System.Drawing.Point(93, 28);
            this.textBoxSada.Name = "textBoxSada";
            this.textBoxSada.ReadOnly = true;
            this.textBoxSada.Size = new System.Drawing.Size(169, 53);
            this.textBoxSada.TabIndex = 0;
            this.textBoxSada.Text = "00:00:00";
            // 
            // timerSada
            // 
            this.timerSada.Interval = 5000;
            this.timerSada.Tick += new System.EventHandler(this.timerSada_Tick);
            // 
            // volumeSliderZora
            // 
            this.volumeSliderZora.Location = new System.Drawing.Point(778, 65);
            this.volumeSliderZora.Name = "volumeSliderZora";
            this.volumeSliderZora.Size = new System.Drawing.Size(96, 16);
            this.volumeSliderZora.TabIndex = 37;
            this.volumeSliderZora.VolumeChanged += new System.EventHandler(this.volumeSliderZora_VolumeChanged);
            // 
            // volumeSliderIzlazak
            // 
            this.volumeSliderIzlazak.Location = new System.Drawing.Point(778, 89);
            this.volumeSliderIzlazak.Name = "volumeSliderIzlazak";
            this.volumeSliderIzlazak.Size = new System.Drawing.Size(96, 16);
            this.volumeSliderIzlazak.TabIndex = 38;
            this.volumeSliderIzlazak.VolumeChanged += new System.EventHandler(this.volumeSliderZora_VolumeChanged);
            // 
            // volumeSliderPodne
            // 
            this.volumeSliderPodne.Location = new System.Drawing.Point(778, 112);
            this.volumeSliderPodne.Name = "volumeSliderPodne";
            this.volumeSliderPodne.Size = new System.Drawing.Size(96, 16);
            this.volumeSliderPodne.TabIndex = 39;
            this.volumeSliderPodne.VolumeChanged += new System.EventHandler(this.volumeSliderZora_VolumeChanged);
            // 
            // volumeSliderIkindija
            // 
            this.volumeSliderIkindija.Location = new System.Drawing.Point(778, 140);
            this.volumeSliderIkindija.Name = "volumeSliderIkindija";
            this.volumeSliderIkindija.Size = new System.Drawing.Size(96, 16);
            this.volumeSliderIkindija.TabIndex = 40;
            this.volumeSliderIkindija.VolumeChanged += new System.EventHandler(this.volumeSliderZora_VolumeChanged);
            // 
            // volumeSliderAksam
            // 
            this.volumeSliderAksam.Location = new System.Drawing.Point(778, 166);
            this.volumeSliderAksam.Name = "volumeSliderAksam";
            this.volumeSliderAksam.Size = new System.Drawing.Size(96, 16);
            this.volumeSliderAksam.TabIndex = 41;
            this.volumeSliderAksam.VolumeChanged += new System.EventHandler(this.volumeSliderZora_VolumeChanged);
            // 
            // volumeSliderJacija
            // 
            this.volumeSliderJacija.Location = new System.Drawing.Point(778, 192);
            this.volumeSliderJacija.Name = "volumeSliderJacija";
            this.volumeSliderJacija.Size = new System.Drawing.Size(96, 16);
            this.volumeSliderJacija.TabIndex = 42;
            this.volumeSliderJacija.VolumeChanged += new System.EventHandler(this.volumeSliderZora_VolumeChanged);
            // 
            // checkBoxPodne
            // 
            this.checkBoxPodne.AutoSize = true;
            this.checkBoxPodne.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxPodne.Location = new System.Drawing.Point(495, 114);
            this.checkBoxPodne.Name = "checkBoxPodne";
            this.checkBoxPodne.Size = new System.Drawing.Size(128, 17);
            this.checkBoxPodne.TabIndex = 43;
            this.checkBoxPodne.Text = "Ezani uvijek u 12 (13)";
            this.checkBoxPodne.UseVisualStyleBackColor = true;
            this.checkBoxPodne.CheckedChanged += new System.EventHandler(this.checkBoxPodne_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(636, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "UcitajJson";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 465);
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
            this.Text = "Form1";
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

