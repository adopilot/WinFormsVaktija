namespace Vaktija
{
    partial class ApiDownload
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
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            godinaNumeric = new System.Windows.Forms.NumericUpDown();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)godinaNumeric).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(205, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(271, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(87, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Odaberite lokaciju";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(90, 91);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Odaberite godinu";
            // 
            // godinaNumeric
            // 
            godinaNumeric.Location = new System.Drawing.Point(205, 89);
            godinaNumeric.Name = "godinaNumeric";
            godinaNumeric.Size = new System.Drawing.Size(120, 23);
            godinaNumeric.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(205, 138);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(107, 23);
            button1.TabIndex = 4;
            button1.Text = "Učitaj i spasi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ApiDownload
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button1);
            Controls.Add(godinaNumeric);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "ApiDownload";
            Text = "ApiDownload";
            Load += ApiDownload_Load;
            ((System.ComponentModel.ISupportInitialize)godinaNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown godinaNumeric;
        private System.Windows.Forms.Button button1;
    }
}