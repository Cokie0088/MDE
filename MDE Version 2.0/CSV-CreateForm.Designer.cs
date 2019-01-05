namespace MDE_Version_2._0
{
    partial class CSV_CreateForm
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
            this.SelectFilesbutton = new System.Windows.Forms.Button();
            this.SelectedFileslistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SelectFilesbutton
            // 
            this.SelectFilesbutton.Location = new System.Drawing.Point(129, 12);
            this.SelectFilesbutton.Name = "SelectFilesbutton";
            this.SelectFilesbutton.Size = new System.Drawing.Size(115, 23);
            this.SelectFilesbutton.TabIndex = 0;
            this.SelectFilesbutton.Text = "Dateien auswählen";
            this.SelectFilesbutton.UseVisualStyleBackColor = true;
            this.SelectFilesbutton.Click += new System.EventHandler(this.SelectFilesbutton_Click);
            // 
            // SelectedFileslistBox
            // 
            this.SelectedFileslistBox.FormattingEnabled = true;
            this.SelectedFileslistBox.Location = new System.Drawing.Point(12, 12);
            this.SelectedFileslistBox.Name = "SelectedFileslistBox";
            this.SelectedFileslistBox.Size = new System.Drawing.Size(111, 147);
            this.SelectedFileslistBox.TabIndex = 1;
            // 
            // CSV_Erstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 173);
            this.Controls.Add(this.SelectedFileslistBox);
            this.Controls.Add(this.SelectFilesbutton);
            this.Name = "CSV_Erstellen";
            this.Text = "CSV Erstellen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectFilesbutton;
        private System.Windows.Forms.ListBox SelectedFileslistBox;
    }
}