﻿namespace MDE_Version_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DatumtoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.AnzahltoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDatabaseSQLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Erfassungbutton = new System.Windows.Forms.Button();
            this.ErfasserTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.abfragestringTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Artikel_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabrikat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtikelbezCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnzahlCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarenbereichCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenerfassungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datenerfassungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.DatumtoolStripStatusLabel,
            this.toolStripStatusLabel2,
            this.AnzahltoolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 386);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1054, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel1.Text = "Datum:";
            // 
            // DatumtoolStripStatusLabel
            // 
            this.DatumtoolStripStatusLabel.Name = "DatumtoolStripStatusLabel";
            this.DatumtoolStripStatusLabel.Size = new System.Drawing.Size(61, 17);
            this.DatumtoolStripStatusLabel.Text = "01.01.2016";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel2.Text = "Gezählte Artikel:";
            // 
            // AnzahltoolStripStatusLabel
            // 
            this.AnzahltoolStripStatusLabel.Name = "AnzahltoolStripStatusLabel";
            this.AnzahltoolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.AnzahltoolStripStatusLabel.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.EinstellungenToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDatabaseSQLiteToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // createDatabaseSQLiteToolStripMenuItem
            // 
            this.createDatabaseSQLiteToolStripMenuItem.Name = "createDatabaseSQLiteToolStripMenuItem";
            this.createDatabaseSQLiteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.createDatabaseSQLiteToolStripMenuItem.Text = "Create Database SQLite";
            this.createDatabaseSQLiteToolStripMenuItem.Click += new System.EventHandler(this.createDatabaseSQLiteToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Erfassungbutton);
            this.groupBox1.Controls.Add(this.ErfasserTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.abfragestringTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Erfassung";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(451, 22);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(89, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Name der Zähler:";
            // 
            // Erfassungbutton
            // 
            this.Erfassungbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Erfassungbutton.Location = new System.Drawing.Point(347, 16);
            this.Erfassungbutton.Name = "Erfassungbutton";
            this.Erfassungbutton.Size = new System.Drawing.Size(99, 23);
            this.Erfassungbutton.TabIndex = 2;
            this.Erfassungbutton.Text = "Erfassen";
            this.Erfassungbutton.UseVisualStyleBackColor = true;
            this.Erfassungbutton.Click += new System.EventHandler(this.Erfassungbutton_Click);
            // 
            // ErfasserTextBox
            // 
            this.ErfasserTextBox.Location = new System.Drawing.Point(546, 19);
            this.ErfasserTextBox.Name = "ErfasserTextBox";
            this.ErfasserTextBox.Size = new System.Drawing.Size(223, 20);
            this.ErfasserTextBox.TabIndex = 6;
            this.ErfasserTextBox.TextChanged += new System.EventHandler(this.ErfasserTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EAN-Nummer/Fabrikat, Art.bez.:";
            // 
            // abfragestringTextBox
            // 
            this.abfragestringTextBox.Location = new System.Drawing.Point(171, 19);
            this.abfragestringTextBox.Name = "abfragestringTextBox";
            this.abfragestringTextBox.Size = new System.Drawing.Size(170, 20);
            this.abfragestringTextBox.TabIndex = 0;
            this.abfragestringTextBox.TextChanged += new System.EventHandler(this.abfragestringTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artikel_ID,
            this.Fabrikat,
            this.ArtikelbezCell,
            this.AnzahlCell,
            this.WarenbereichCell,
            this.NameCell});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 293);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // Artikel_ID
            // 
            this.Artikel_ID.DataPropertyName = "Artikel_ID";
            this.Artikel_ID.HeaderText = "Artikel ID";
            this.Artikel_ID.Name = "Artikel_ID";
            this.Artikel_ID.ReadOnly = true;
            // 
            // Fabrikat
            // 
            this.Fabrikat.DataPropertyName = "Fabrikat";
            this.Fabrikat.HeaderText = "Farbrikat";
            this.Fabrikat.Name = "Fabrikat";
            this.Fabrikat.ReadOnly = true;
            // 
            // ArtikelbezCell
            // 
            this.ArtikelbezCell.DataPropertyName = "Artikelbezeichnung";
            this.ArtikelbezCell.HeaderText = "Artikelbezeichnung";
            this.ArtikelbezCell.Name = "ArtikelbezCell";
            this.ArtikelbezCell.ReadOnly = true;
            // 
            // AnzahlCell
            // 
            this.AnzahlCell.DataPropertyName = "Anzahl";
            this.AnzahlCell.HeaderText = "Anzahl";
            this.AnzahlCell.Name = "AnzahlCell";
            // 
            // WarenbereichCell
            // 
            this.WarenbereichCell.DataPropertyName = "Warenbereich";
            this.WarenbereichCell.HeaderText = "Warenbereich";
            this.WarenbereichCell.Name = "WarenbereichCell";
            this.WarenbereichCell.ReadOnly = true;
            // 
            // NameCell
            // 
            this.NameCell.DataPropertyName = "Name";
            this.NameCell.HeaderText = "Name";
            this.NameCell.Name = "NameCell";
            this.NameCell.ReadOnly = true;
            // 
            // datenerfassungBindingSource
            // 
            this.datenerfassungBindingSource.DataSource = typeof(MDE_Version_2._0.Datenerfassung);
            // 
            // Form1
            // 
            this.AcceptButton = this.Erfassungbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 408);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1070, 446);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datenerfassungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox abfragestringTextBox;
        private System.Windows.Forms.Button Erfassungbutton;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox ErfasserTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel DatumtoolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel AnzahltoolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDatabaseSQLiteToolStripMenuItem;
        private System.Windows.Forms.BindingSource datenerfassungBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikel_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabrikat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtikelbezCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnzahlCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarenbereichCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCell;
    }
}

