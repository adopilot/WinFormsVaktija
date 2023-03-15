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
            components = new System.ComponentModel.Container();
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
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // textBoxExcelFajla
            // 
            resources.ApplyResources(textBoxExcelFajla, "textBoxExcelFajla");
            textBoxExcelFajla.Name = "textBoxExcelFajla";
            textBoxExcelFajla.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialogExcel
            // 
            this.openFileDialogExcel.FileName = "openFileDialog1";
            // 
            // monthCalendar1
            // 
            resources.ApplyResources(monthCalendar1, "monthCalendar1");
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // textBoxZora
            // 
            resources.ApplyResources(textBoxZora, "textBoxZora");
            textBoxZora.Name = "textBoxZora";
            textBoxZora.ReadOnly = true;
            // 
            // textBoxIzlazak
            // 
            resources.ApplyResources(textBoxIzlazak, "textBoxIzlazak");
            textBoxIzlazak.Name = "textBoxIzlazak";
            textBoxIzlazak.ReadOnly = true;
            // 
            // textBoxPodne
            // 
            resources.ApplyResources(textBoxPodne, "textBoxPodne");
            textBoxPodne.Name = "textBoxPodne";
            textBoxPodne.ReadOnly = true;
            // 
            // textBoxIkindija
            // 
            resources.ApplyResources(textBoxIkindija, "textBoxIkindija");
            textBoxIkindija.Name = "textBoxIkindija";
            textBoxIkindija.ReadOnly = true;
            // 
            // textBoxAksam
            // 
            resources.ApplyResources(textBoxAksam, "textBoxAksam");
            textBoxAksam.Name = "textBoxAksam";
            textBoxAksam.ReadOnly = true;
            // 
            // textBoxJacija
            // 
            resources.ApplyResources(textBoxJacija, "textBoxJacija");
            textBoxJacija.Name = "textBoxJacija";
            textBoxJacija.ReadOnly = true;
            // 
            // ezaniZora
            // 
            resources.ApplyResources(ezaniZora, "ezaniZora");
            ezaniZora.Name = "ezaniZora";
            ezaniZora.UseVisualStyleBackColor = true;
            ezaniZora.CheckedChanged += ezaniZora_CheckedChanged;
            // 
            // ezaniIzlazak
            // 
            resources.ApplyResources(ezaniIzlazak, "ezaniIzlazak");
            ezaniIzlazak.Name = "ezaniIzlazak";
            ezaniIzlazak.UseVisualStyleBackColor = true;
            ezaniIzlazak.CheckedChanged += ezaniZora_CheckedChanged;
            // 
            // ezaniPodne
            // 
            resources.ApplyResources(ezaniPodne, "ezaniPodne");
            ezaniPodne.Name = "ezaniPodne";
            ezaniPodne.UseVisualStyleBackColor = true;
            ezaniPodne.CheckedChanged += ezaniZora_CheckedChanged;
            // 
            // ezaniIkindija
            // 
            resources.ApplyResources(ezaniIkindija, "ezaniIkindija");
            ezaniIkindija.Name = "ezaniIkindija";
            ezaniIkindija.UseVisualStyleBackColor = true;
            ezaniIkindija.CheckedChanged += ezaniZora_CheckedChanged;
            // 
            // ezaniAksam
            // 
            resources.ApplyResources(ezaniAksam, "ezaniAksam");
            ezaniAksam.Name = "ezaniAksam";
            ezaniAksam.UseVisualStyleBackColor = true;
            ezaniAksam.CheckedChanged += ezaniZora_CheckedChanged;
            // 
            // ezaniJacija
            // 
            resources.ApplyResources(ezaniJacija, "ezaniJacija");
            ezaniJacija.Name = "ezaniJacija";
            ezaniJacija.UseVisualStyleBackColor = true;
            ezaniJacija.CheckedChanged += ezaniZora_CheckedChanged;
            // 
            // numericZora
            // 
            resources.ApplyResources(numericZora, "numericZora");
            numericZora.Maximum = new decimal(new int[] { 80000, 0, 0, 0 });
            numericZora.Name = "numericZora";
            numericZora.ValueChanged += numericZora_ValueChanged;
            // 
            // numericIzlazak
            // 
            resources.ApplyResources(numericIzlazak, "numericIzlazak");
            numericIzlazak.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            numericIzlazak.Name = "numericIzlazak";
            numericIzlazak.ValueChanged += numericIzlazak_ValueChanged;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // ezanZora
            // 
            resources.ApplyResources(ezanZora, "ezanZora");
            ezanZora.Name = "ezanZora";
            ezanZora.UseVisualStyleBackColor = true;
            ezanZora.Click += buttonEzanZora_Click;
            // 
            // ezanIzlazak
            // 
            resources.ApplyResources(ezanIzlazak, "ezanIzlazak");
            ezanIzlazak.Name = "ezanIzlazak";
            ezanIzlazak.UseVisualStyleBackColor = true;
            ezanIzlazak.Click += buttonEzanZora_Click;
            // 
            // ezanPodne
            // 
            resources.ApplyResources(ezanPodne, "ezanPodne");
            ezanPodne.Name = "ezanPodne";
            ezanPodne.UseVisualStyleBackColor = true;
            ezanPodne.Click += buttonEzanZora_Click;
            // 
            // ezanIkindija
            // 
            resources.ApplyResources(ezanIkindija, "ezanIkindija");
            ezanIkindija.Name = "ezanIkindija";
            ezanIkindija.UseVisualStyleBackColor = true;
            ezanIkindija.Click += buttonEzanZora_Click;
            // 
            // ezanAksam
            // 
            resources.ApplyResources(ezanAksam, "ezanAksam");
            ezanAksam.Name = "ezanAksam";
            ezanAksam.UseVisualStyleBackColor = true;
            ezanAksam.Click += buttonEzanZora_Click;
            // 
            // ezanJacija
            // 
            resources.ApplyResources(ezanJacija, "ezanJacija");
            ezanJacija.Name = "ezanJacija";
            ezanJacija.UseVisualStyleBackColor = true;
            ezanJacija.Click += buttonEzanZora_Click;
            // 
            // openFileDialogMp3
            // 
            this.openFileDialogMp3.FileName = "openFileDialogMp3";
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TesterPojacivac
            // 
            resources.ApplyResources(TesterPojacivac, "TesterPojacivac");
            TesterPojacivac.Name = "TesterPojacivac";
            TesterPojacivac.VolumeChanged += TesterPojacivac_VolumeChanged;
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
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            resources.ApplyResources(labelLastEvent, "labelLastEvent");
            labelLastEvent.Name = "labelLastEvent";
            // 
            // checkBoxMujezin
            // 
            resources.ApplyResources(checkBoxMujezin, "checkBoxMujezin");
            checkBoxMujezin.Checked = true;
            checkBoxMujezin.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxMujezin.Name = "checkBoxMujezin";
            checkBoxMujezin.UseVisualStyleBackColor = true;
            checkBoxMujezin.CheckedChanged += checkBoxMujezin_CheckedChanged;
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            // 
            // textBoxDoNamaza
            // 
            resources.ApplyResources(textBoxDoNamaza, "textBoxDoNamaza");
            textBoxDoNamaza.Name = "textBoxDoNamaza";
            textBoxDoNamaza.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // textBoxSlijedeciNamaz
            // 
            resources.ApplyResources(textBoxSlijedeciNamaz, "textBoxSlijedeciNamaz");
            textBoxSlijedeciNamaz.Name = "textBoxSlijedeciNamaz";
            textBoxSlijedeciNamaz.ReadOnly = true;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // textBoxSlijedeciNamazLbl
            // 
            resources.ApplyResources(textBoxSlijedeciNamazLbl, "textBoxSlijedeciNamazLbl");
            textBoxSlijedeciNamazLbl.Name = "textBoxSlijedeciNamazLbl";
            textBoxSlijedeciNamazLbl.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // textBoxSada
            // 
            resources.ApplyResources(textBoxSada, "textBoxSada");
            textBoxSada.Name = "textBoxSada";
            textBoxSada.ReadOnly = true;
            // 
            // timerSada
            // 
            timerSada.Interval = 5000;
            timerSada.Tick += timerSada_Tick;
            // 
            // volumeSliderZora
            // 
            resources.ApplyResources(volumeSliderZora, "volumeSliderZora");
            volumeSliderZora.Name = "volumeSliderZora";
            volumeSliderZora.VolumeChanged += volumeSliderZora_VolumeChanged;
            // 
            // volumeSliderIzlazak
            // 
            resources.ApplyResources(volumeSliderIzlazak, "volumeSliderIzlazak");
            volumeSliderIzlazak.Name = "volumeSliderIzlazak";
            volumeSliderIzlazak.VolumeChanged += volumeSliderZora_VolumeChanged;
            // 
            // volumeSliderPodne
            // 
            resources.ApplyResources(volumeSliderPodne, "volumeSliderPodne");
            volumeSliderPodne.Name = "volumeSliderPodne";
            volumeSliderPodne.VolumeChanged += volumeSliderZora_VolumeChanged;
            // 
            // volumeSliderIkindija
            // 
            resources.ApplyResources(volumeSliderIkindija, "volumeSliderIkindija");
            volumeSliderIkindija.Name = "volumeSliderIkindija";
            volumeSliderIkindija.VolumeChanged += volumeSliderZora_VolumeChanged;
            // 
            // volumeSliderAksam
            // 
            resources.ApplyResources(volumeSliderAksam, "volumeSliderAksam");
            volumeSliderAksam.Name = "volumeSliderAksam";
            volumeSliderAksam.VolumeChanged += volumeSliderZora_VolumeChanged;
            // 
            // volumeSliderJacija
            // 
            resources.ApplyResources(volumeSliderJacija, "volumeSliderJacija");
            volumeSliderJacija.Name = "volumeSliderJacija";
            volumeSliderJacija.VolumeChanged += volumeSliderZora_VolumeChanged;
            // 
            // checkBoxPodne
            // 
            resources.ApplyResources(checkBoxPodne, "checkBoxPodne");
            checkBoxPodne.Name = "checkBoxPodne";
            checkBoxPodne.UseVisualStyleBackColor = true;
            checkBoxPodne.CheckedChanged += checkBoxPodne_CheckedChanged;
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
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

