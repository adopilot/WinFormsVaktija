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
            label1 = new System.Windows.Forms.Label();
            textBoxExcelFajla = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            textBoxZora = new System.Windows.Forms.TextBox();
            textBoxIzlazak = new System.Windows.Forms.TextBox();
            textBoxPodne = new System.Windows.Forms.TextBox();
            textBoxIkindija = new System.Windows.Forms.TextBox();
            textBoxAksam = new System.Windows.Forms.TextBox();
            textBoxJacija = new System.Windows.Forms.TextBox();
            ezaniZora = new System.Windows.Forms.CheckBox();
            ezaniIzlazak = new System.Windows.Forms.CheckBox();
            ezaniPodne = new System.Windows.Forms.CheckBox();
            ezaniIkindija = new System.Windows.Forms.CheckBox();
            ezaniAksam = new System.Windows.Forms.CheckBox();
            ezaniJacija = new System.Windows.Forms.CheckBox();
            numericZora = new System.Windows.Forms.NumericUpDown();
            numericIzlazak = new System.Windows.Forms.NumericUpDown();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ezanZora = new System.Windows.Forms.Button();
            ezanIzlazak = new System.Windows.Forms.Button();
            ezanPodne = new System.Windows.Forms.Button();
            ezanIkindija = new System.Windows.Forms.Button();
            ezanAksam = new System.Windows.Forms.Button();
            ezanJacija = new System.Windows.Forms.Button();
            openFileDialogMp3 = new System.Windows.Forms.OpenFileDialog();
            button2 = new System.Windows.Forms.Button();
            TesterPojacivac = new NAudio.Gui.VolumeSlider();
            groupBoxTester = new System.Windows.Forms.GroupBox();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            comboBoxTest = new System.Windows.Forms.ComboBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            labelLastEvent = new System.Windows.Forms.Label();
            checkBoxMujezin = new System.Windows.Forms.CheckBox();
            label13 = new System.Windows.Forms.Label();
            textBoxDoNamaza = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            textBoxSlijedeciNamaz = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            textBoxSlijedeciNamazLbl = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            textBoxSada = new System.Windows.Forms.TextBox();
            timerSada = new System.Windows.Forms.Timer(components);
            volumeSliderZora = new NAudio.Gui.VolumeSlider();
            volumeSliderIzlazak = new NAudio.Gui.VolumeSlider();
            volumeSliderPodne = new NAudio.Gui.VolumeSlider();
            volumeSliderIkindija = new NAudio.Gui.VolumeSlider();
            volumeSliderAksam = new NAudio.Gui.VolumeSlider();
            volumeSliderJacija = new NAudio.Gui.VolumeSlider();
            checkBoxPodne = new System.Windows.Forms.CheckBox();
            button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericZora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericIzlazak).BeginInit();
            groupBoxTester.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            openFileDialogExcel.FileName = "openFileDialog1";
            resources.ApplyResources(openFileDialogExcel, "openFileDialogExcel");
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
            openFileDialogMp3.FileName = "openFileDialogMp3";
            resources.ApplyResources(openFileDialogMp3, "openFileDialogMp3");
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
            resources.ApplyResources(groupBoxTester, "groupBoxTester");
            groupBoxTester.Controls.Add(label15);
            groupBoxTester.Controls.Add(label14);
            groupBoxTester.Controls.Add(button3);
            groupBoxTester.Controls.Add(comboBoxTest);
            groupBoxTester.Controls.Add(button2);
            groupBoxTester.Controls.Add(TesterPojacivac);
            groupBoxTester.Name = "groupBoxTester";
            groupBoxTester.TabStop = false;
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
            resources.ApplyResources(comboBoxTest, "comboBoxTest");
            comboBoxTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxTest.FormattingEnabled = true;
            comboBoxTest.Items.AddRange(new object[] { resources.GetString("comboBoxTest.Items"), resources.GetString("comboBoxTest.Items1"), resources.GetString("comboBoxTest.Items2"), resources.GetString("comboBoxTest.Items3"), resources.GetString("comboBoxTest.Items4"), resources.GetString("comboBoxTest.Items5") });
            comboBoxTest.Name = "comboBoxTest";
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(labelLastEvent);
            groupBox1.Controls.Add(checkBoxMujezin);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(textBoxDoNamaza);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBoxSlijedeciNamaz);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBoxSlijedeciNamazLbl);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBoxSada);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
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
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(checkBoxPodne);
            Controls.Add(volumeSliderJacija);
            Controls.Add(volumeSliderAksam);
            Controls.Add(volumeSliderIkindija);
            Controls.Add(volumeSliderPodne);
            Controls.Add(volumeSliderIzlazak);
            Controls.Add(volumeSliderZora);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxTester);
            Controls.Add(ezanJacija);
            Controls.Add(ezanAksam);
            Controls.Add(ezanIkindija);
            Controls.Add(ezanPodne);
            Controls.Add(ezanIzlazak);
            Controls.Add(ezanZora);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(numericIzlazak);
            Controls.Add(numericZora);
            Controls.Add(ezaniJacija);
            Controls.Add(ezaniAksam);
            Controls.Add(ezaniIkindija);
            Controls.Add(ezaniPodne);
            Controls.Add(ezaniIzlazak);
            Controls.Add(ezaniZora);
            Controls.Add(textBoxJacija);
            Controls.Add(textBoxAksam);
            Controls.Add(textBoxIkindija);
            Controls.Add(textBoxPodne);
            Controls.Add(textBoxIzlazak);
            Controls.Add(textBoxZora);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(monthCalendar1);
            Controls.Add(button1);
            Controls.Add(textBoxExcelFajla);
            Controls.Add(label1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericZora).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericIzlazak).EndInit();
            groupBoxTester.ResumeLayout(false);
            groupBoxTester.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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

