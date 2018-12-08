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
            this.SuspendLayout();
            // 
            // AnzahltextBox
            // 
            this.AnzahltextBox.Location = new System.Drawing.Point(60, 12);
            this.AnzahltextBox.Name = "AnzahltextBox";
            this.AnzahltextBox.Size = new System.Drawing.Size(304, 20);
            this.AnzahltextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anzahl:";
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(208, 39);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(75, 23);
            this.Okbutton.TabIndex = 2;
            this.Okbutton.Text = "Ok";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // Abbrechenbutton
            // 
            this.Abbrechenbutton.Location = new System.Drawing.Point(289, 39);
            this.Abbrechenbutton.Name = "Abbrechenbutton";
            this.Abbrechenbutton.Size = new System.Drawing.Size(75, 23);
            this.Abbrechenbutton.TabIndex = 3;
            this.Abbrechenbutton.Text = "Abbrechen";
            this.Abbrechenbutton.UseVisualStyleBackColor = true;
            // 
            // Anzahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 74);
            this.Controls.Add(this.Abbrechenbutton);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnzahltextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Anzahl";
            this.Text = "Anzahl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnzahltextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.Button Abbrechenbutton;
    }
}