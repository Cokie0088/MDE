namespace MDE_Version_2._0
{
    partial class Anzahl
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
            this.AnzahltextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Okbutton = new System.Windows.Forms.Button();
            this.Abbrechenbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Herstellerlabel = new System.Windows.Forms.Label();
            this.Artikelbezeichunglabel = new System.Windows.Forms.Label();
            this.eanlabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnzahltextBox
            // 
            this.AnzahltextBox.Location = new System.Drawing.Point(58, 81);
            this.AnzahltextBox.Name = "AnzahltextBox";
            this.AnzahltextBox.Size = new System.Drawing.Size(304, 20);
            this.AnzahltextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anzahl:";
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(206, 107);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(75, 23);
            this.Okbutton.TabIndex = 2;
            this.Okbutton.Text = "Ok";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // Abbrechenbutton
            // 
            this.Abbrechenbutton.Location = new System.Drawing.Point(287, 107);
            this.Abbrechenbutton.Name = "Abbrechenbutton";
            this.Abbrechenbutton.Size = new System.Drawing.Size(75, 23);
            this.Abbrechenbutton.TabIndex = 3;
            this.Abbrechenbutton.Text = "Abbrechen";
            this.Abbrechenbutton.UseVisualStyleBackColor = true;
            this.Abbrechenbutton.Click += new System.EventHandler(this.Abbrechenbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eanlabel);
            this.groupBox1.Controls.Add(this.Artikelbezeichunglabel);
            this.groupBox1.Controls.Add(this.Herstellerlabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gefundener Artikel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hersteller:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Artikelbezeichnung:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "EAN:";
            // 
            // Herstellerlabel
            // 
            this.Herstellerlabel.AutoSize = true;
            this.Herstellerlabel.Location = new System.Drawing.Point(114, 16);
            this.Herstellerlabel.Name = "Herstellerlabel";
            this.Herstellerlabel.Size = new System.Drawing.Size(51, 13);
            this.Herstellerlabel.TabIndex = 3;
            this.Herstellerlabel.Text = "Hersteller";
            // 
            // Artikelbezeichunglabel
            // 
            this.Artikelbezeichunglabel.AutoSize = true;
            this.Artikelbezeichunglabel.Location = new System.Drawing.Point(114, 29);
            this.Artikelbezeichunglabel.Name = "Artikelbezeichunglabel";
            this.Artikelbezeichunglabel.Size = new System.Drawing.Size(36, 13);
            this.Artikelbezeichunglabel.TabIndex = 4;
            this.Artikelbezeichunglabel.Text = "Artikel";
            // 
            // eanlabel
            // 
            this.eanlabel.AutoSize = true;
            this.eanlabel.Location = new System.Drawing.Point(114, 42);
            this.eanlabel.Name = "eanlabel";
            this.eanlabel.Size = new System.Drawing.Size(25, 13);
            this.eanlabel.TabIndex = 5;
            this.eanlabel.Text = "ean";
            // 
            // Anzahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 147);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Abbrechenbutton);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnzahltextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Anzahl";
            this.Text = "Anzahl";
            this.Load += new System.EventHandler(this.Anzahl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnzahltextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.Button Abbrechenbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label eanlabel;
        private System.Windows.Forms.Label Artikelbezeichunglabel;
        private System.Windows.Forms.Label Herstellerlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}