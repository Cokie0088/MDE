namespace MDE_Version_2._0
{
    partial class frmEinstellungen
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.DBSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.DatenbankBenutzerTextBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.DatenbankPasswortTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.RenditeDatenbankTextBox = new System.Windows.Forms.TextBox();
            this.SQLServerTextBox = new System.Windows.Forms.TextBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.ErstellenButton = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.AccessOeffnenButton = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.AccessDatenbankTextBox = new System.Windows.Forms.TextBox();
            this.BtAbort = new System.Windows.Forms.Button();
            this.BtSettingsSave = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(297, 217);
            this.TabControl1.TabIndex = 2;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(289, 191);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Rendite Datenbank";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.GroupBox3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.RenditeDatenbankTextBox);
            this.GroupBox1.Controls.Add(this.SQLServerTextBox);
            this.GroupBox1.Location = new System.Drawing.Point(6, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(277, 179);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Rendite SQL-Server";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.DBSaveCheckBox);
            this.GroupBox3.Controls.Add(this.DatenbankBenutzerTextBox);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Controls.Add(this.DatenbankPasswortTextBox);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Location = new System.Drawing.Point(3, 71);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(268, 100);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Schutz";
            // 
            // DBSaveCheckBox
            // 
            this.DBSaveCheckBox.AutoSize = true;
            this.DBSaveCheckBox.Location = new System.Drawing.Point(3, 19);
            this.DBSaveCheckBox.Name = "DBSaveCheckBox";
            this.DBSaveCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DBSaveCheckBox.Size = new System.Drawing.Size(139, 17);
            this.DBSaveCheckBox.TabIndex = 0;
            this.DBSaveCheckBox.Text = ":Geschützte Datenbank";
            this.DBSaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // DatenbankBenutzerTextBox
            // 
            this.DatenbankBenutzerTextBox.Location = new System.Drawing.Point(162, 45);
            this.DatenbankBenutzerTextBox.Name = "DatenbankBenutzerTextBox";
            this.DatenbankBenutzerTextBox.Size = new System.Drawing.Size(100, 20);
            this.DatenbankBenutzerTextBox.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(3, 74);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(109, 13);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Datenbank Passwort:";
            // 
            // DatenbankPasswortTextBox
            // 
            this.DatenbankPasswortTextBox.Location = new System.Drawing.Point(162, 71);
            this.DatenbankPasswortTextBox.Name = "DatenbankPasswortTextBox";
            this.DatenbankPasswortTextBox.Size = new System.Drawing.Size(100, 20);
            this.DatenbankPasswortTextBox.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(3, 48);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(108, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Datenbank Benutzer:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(103, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Rendite Datenbank:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "SQL-Server:";
            // 
            // RenditeDatenbankTextBox
            // 
            this.RenditeDatenbankTextBox.Location = new System.Drawing.Point(171, 45);
            this.RenditeDatenbankTextBox.Name = "RenditeDatenbankTextBox";
            this.RenditeDatenbankTextBox.Size = new System.Drawing.Size(100, 20);
            this.RenditeDatenbankTextBox.TabIndex = 1;
            // 
            // SQLServerTextBox
            // 
            this.SQLServerTextBox.Location = new System.Drawing.Point(171, 19);
            this.SQLServerTextBox.Name = "SQLServerTextBox";
            this.SQLServerTextBox.Size = new System.Drawing.Size(100, 20);
            this.SQLServerTextBox.TabIndex = 0;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.ErstellenButton);
            this.TabPage2.Controls.Add(this.GroupBox2);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(289, 191);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "SQL-Lite Datenbank";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // ErstellenButton
            // 
            this.ErstellenButton.Location = new System.Drawing.Point(124, 117);
            this.ErstellenButton.Name = "ErstellenButton";
            this.ErstellenButton.Size = new System.Drawing.Size(153, 23);
            this.ErstellenButton.TabIndex = 3;
            this.ErstellenButton.Text = "Datenbank Datei erstellen";
            this.ErstellenButton.UseVisualStyleBackColor = true;
            this.ErstellenButton.Click += new System.EventHandler(this.ErstellenButton_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.AccessOeffnenButton);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.AccessDatenbankTextBox);
            this.GroupBox2.Location = new System.Drawing.Point(6, 6);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(277, 105);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "SQL-Lite Datenbank";
            // 
            // AccessOeffnenButton
            // 
            this.AccessOeffnenButton.Location = new System.Drawing.Point(118, 76);
            this.AccessOeffnenButton.Name = "AccessOeffnenButton";
            this.AccessOeffnenButton.Size = new System.Drawing.Size(153, 23);
            this.AccessOeffnenButton.TabIndex = 2;
            this.AccessOeffnenButton.Text = "Datenbank Datei öffnen";
            this.AccessOeffnenButton.UseVisualStyleBackColor = true;
            this.AccessOeffnenButton.Click += new System.EventHandler(this.AccessOeffnenButton_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 26);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(128, 13);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "SQL-Lite Datenbankpfad:";
            // 
            // AccessDatenbankTextBox
            // 
            this.AccessDatenbankTextBox.Enabled = false;
            this.AccessDatenbankTextBox.Location = new System.Drawing.Point(9, 50);
            this.AccessDatenbankTextBox.Name = "AccessDatenbankTextBox";
            this.AccessDatenbankTextBox.Size = new System.Drawing.Size(262, 20);
            this.AccessDatenbankTextBox.TabIndex = 0;
            // 
            // BtAbort
            // 
            this.BtAbort.Location = new System.Drawing.Point(234, 231);
            this.BtAbort.Name = "BtAbort";
            this.BtAbort.Size = new System.Drawing.Size(75, 23);
            this.BtAbort.TabIndex = 1;
            this.BtAbort.Text = "Abbrechen";
            this.BtAbort.UseVisualStyleBackColor = true;
            this.BtAbort.Click += new System.EventHandler(this.BtAbort_Click);
            // 
            // BtSettingsSave
            // 
            this.BtSettingsSave.Location = new System.Drawing.Point(12, 231);
            this.BtSettingsSave.Name = "BtSettingsSave";
            this.BtSettingsSave.Size = new System.Drawing.Size(75, 23);
            this.BtSettingsSave.TabIndex = 0;
            this.BtSettingsSave.Text = "Speichern";
            this.BtSettingsSave.UseVisualStyleBackColor = true;
            this.BtSettingsSave.Click += new System.EventHandler(this.BtSettingsSave_Click);
            // 
            // frmEinstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 266);
            this.Controls.Add(this.BtAbort);
            this.Controls.Add(this.BtSettingsSave);
            this.Controls.Add(this.TabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(337, 305);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(337, 305);
            this.Name = "frmEinstellungen";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.frmEinstellungen_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.CheckBox DBSaveCheckBox;
        internal System.Windows.Forms.TextBox DatenbankBenutzerTextBox;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox DatenbankPasswortTextBox;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox RenditeDatenbankTextBox;
        internal System.Windows.Forms.TextBox SQLServerTextBox;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button AccessOeffnenButton;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox AccessDatenbankTextBox;
        internal System.Windows.Forms.Button BtAbort;
        internal System.Windows.Forms.Button BtSettingsSave;
        private System.Windows.Forms.Button ErstellenButton;
    }
}