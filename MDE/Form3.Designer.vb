<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnzahlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CsvDataSet1 = New MDE.CSVDataSet()
        Me.BtCSVErstellen = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbWarenbereich = New System.Windows.Forms.ComboBox()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbMDEPfad = New System.Windows.Forms.TextBox()
        Me.TbMDEOeffnen = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CsvDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        Ean, Anzahl" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Erfassung"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\MDE\MDE.mdb"";Persist Security In" & _
    "fo=True"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `Erfassung` (`Ean`, `Anzahl`) VALUES (?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Ean", System.Data.OleDb.OleDbType.VarWChar, 0, "Ean"), New System.Data.OleDb.OleDbParameter("Anzahl", System.Data.OleDb.OleDbType.VarWChar, 0, "Anzahl")})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Erfassung", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Ean", "Ean"), New System.Data.Common.DataColumnMapping("Anzahl", "Anzahl")})})
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EanDataGridViewTextBoxColumn, Me.AnzahlDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(614, 211)
        Me.DataGridView1.TabIndex = 0
        '
        'EanDataGridViewTextBoxColumn
        '
        Me.EanDataGridViewTextBoxColumn.DataPropertyName = "Ean"
        Me.EanDataGridViewTextBoxColumn.HeaderText = "Ean"
        Me.EanDataGridViewTextBoxColumn.Name = "EanDataGridViewTextBoxColumn"
        '
        'AnzahlDataGridViewTextBoxColumn
        '
        Me.AnzahlDataGridViewTextBoxColumn.DataPropertyName = "Anzahl"
        Me.AnzahlDataGridViewTextBoxColumn.HeaderText = "Anzahl"
        Me.AnzahlDataGridViewTextBoxColumn.Name = "AnzahlDataGridViewTextBoxColumn"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Erfassung"
        Me.BindingSource1.DataSource = Me.CsvDataSet1
        '
        'CsvDataSet1
        '
        Me.CsvDataSet1.DataSetName = "CSVDataSet"
        Me.CsvDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtCSVErstellen
        '
        Me.BtCSVErstellen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtCSVErstellen.Location = New System.Drawing.Point(12, 282)
        Me.BtCSVErstellen.Name = "BtCSVErstellen"
        Me.BtCSVErstellen.Size = New System.Drawing.Size(97, 23)
        Me.BtCSVErstellen.TabIndex = 1
        Me.BtCSVErstellen.Text = "CSV Erstellen"
        Me.BtCSVErstellen.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "(*.csv)|*.csv"
        Me.SaveFileDialog1.Filter = "(*.csv)|*.csv"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Warenbereich:"
        '
        'CbWarenbereich
        '
        Me.CbWarenbereich.DataSource = Me.BindingSource2
        Me.CbWarenbereich.DisplayMember = "Warenbereich"
        Me.CbWarenbereich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbWarenbereich.FormattingEnabled = True
        Me.CbWarenbereich.Location = New System.Drawing.Point(95, 38)
        Me.CbWarenbereich.Name = "CbWarenbereich"
        Me.CbWarenbereich.Size = New System.Drawing.Size(197, 21)
        Me.CbWarenbereich.TabIndex = 3
        Me.CbWarenbereich.ValueMember = "WarenbereichID"
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "Warenbereich"
        Me.BindingSource2.DataSource = Me.CsvDataSet1
        '
        'TbMDEPfad
        '
        Me.TbMDEPfad.Location = New System.Drawing.Point(15, 12)
        Me.TbMDEPfad.Name = "TbMDEPfad"
        Me.TbMDEPfad.ReadOnly = True
        Me.TbMDEPfad.Size = New System.Drawing.Size(277, 20)
        Me.TbMDEPfad.TabIndex = 4
        '
        'TbMDEOeffnen
        '
        Me.TbMDEOeffnen.Location = New System.Drawing.Point(298, 12)
        Me.TbMDEOeffnen.Name = "TbMDEOeffnen"
        Me.TbMDEOeffnen.Size = New System.Drawing.Size(75, 23)
        Me.TbMDEOeffnen.TabIndex = 5
        Me.TbMDEOeffnen.Text = "Öffnen"
        Me.TbMDEOeffnen.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "*.mdb|*.mdb"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 317)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(638, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(129, 17)
        Me.ToolStripStatusLabel1.Text = "Angezeigte Datensätze:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabel2.Text = "0"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 339)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TbMDEOeffnen)
        Me.Controls.Add(Me.TbMDEPfad)
        Me.Controls.Add(Me.CbWarenbereich)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtCSVErstellen)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.Text = "MDE-CSV Erstellen"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CsvDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents CsvDataSet1 As MDE.CSVDataSet
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnzahlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtCSVErstellen As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CbWarenbereich As System.Windows.Forms.ComboBox
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TbMDEPfad As System.Windows.Forms.TextBox
    Friend WithEvents TbMDEOeffnen As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
End Class
