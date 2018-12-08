<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FabrikatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtikelbezDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnzahlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WarenbereichDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Namen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessDataSet1 = New MDE.AccessDataSet()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankenZusammenlegenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSVErstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSVKomplettErstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OhneDatebankAbfrageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchliessenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Csv1 = New MDE.CSV()
        Me.RenditeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RenditeDataSet1 = New MDE.RenditeDataSet1()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Csv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RenditeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RenditeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(763, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Erfassung"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(129, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ACHTUNG OHNE DATENBANK ABFRAGE!!!"
        Me.ToolTip1.SetToolTip(Me.Label3, "Datenbankabfrage ist abgeschalten! Es wird nur die EAN, Anzahl und der Name erfas" & _
        "st!")
        Me.Label3.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(499, 44)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Auto Scroll"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Wenn Autoscroll aktiviert ist. Wird automatisch immer der erste eintrag angezeigt" & _
        " wenn etwas gescannt oder gesucht wird!")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(404, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name der Zähler:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(499, 18)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(223, 20)
        Me.TextBox2.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.TextBox2, "Die Namen des Zähler Teams was diese Liste zählt.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "EAN-Nummer/Fabrikat, Art.bez.:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(312, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Erfassen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(171, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 20)
        Me.TextBox1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Die Eannummer oder das Fabrikat mit der Artikelbezeichnung. Bitte durch Komma tre" & _
        "nnen!")
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FabrikatDataGridViewTextBoxColumn, Me.ArtikelbezDataGridViewTextBoxColumn, Me.EanDataGridViewTextBoxColumn, Me.AnzahlDataGridViewTextBoxColumn, Me.WarenbereichDataGridViewTextBoxColumn, Me.Namen})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 94)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(833, 215)
        Me.DataGridView1.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "Scannnummer"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FabrikatDataGridViewTextBoxColumn
        '
        Me.FabrikatDataGridViewTextBoxColumn.DataPropertyName = "Fabrikat"
        Me.FabrikatDataGridViewTextBoxColumn.HeaderText = "Fabrikat"
        Me.FabrikatDataGridViewTextBoxColumn.Name = "FabrikatDataGridViewTextBoxColumn"
        Me.FabrikatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArtikelbezDataGridViewTextBoxColumn
        '
        Me.ArtikelbezDataGridViewTextBoxColumn.DataPropertyName = "Artikelbez"
        Me.ArtikelbezDataGridViewTextBoxColumn.HeaderText = "Artikelbezeichnung"
        Me.ArtikelbezDataGridViewTextBoxColumn.Name = "ArtikelbezDataGridViewTextBoxColumn"
        Me.ArtikelbezDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EanDataGridViewTextBoxColumn
        '
        Me.EanDataGridViewTextBoxColumn.DataPropertyName = "Ean"
        Me.EanDataGridViewTextBoxColumn.HeaderText = "EAN"
        Me.EanDataGridViewTextBoxColumn.Name = "EanDataGridViewTextBoxColumn"
        Me.EanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnzahlDataGridViewTextBoxColumn
        '
        Me.AnzahlDataGridViewTextBoxColumn.DataPropertyName = "Anzahl"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnzahlDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.AnzahlDataGridViewTextBoxColumn.HeaderText = "Anzahl"
        Me.AnzahlDataGridViewTextBoxColumn.Name = "AnzahlDataGridViewTextBoxColumn"
        '
        'WarenbereichDataGridViewTextBoxColumn
        '
        Me.WarenbereichDataGridViewTextBoxColumn.DataPropertyName = "Warenbereich"
        Me.WarenbereichDataGridViewTextBoxColumn.HeaderText = "Warenbereich"
        Me.WarenbereichDataGridViewTextBoxColumn.Name = "WarenbereichDataGridViewTextBoxColumn"
        Me.WarenbereichDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Namen
        '
        Me.Namen.DataPropertyName = "Namen"
        Me.Namen.HeaderText = "Zähler Namen"
        Me.Namen.Name = "Namen"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Erfassung"
        Me.BindingSource1.DataSource = Me.AccessDataSet1
        Me.BindingSource1.Sort = "ID DESC"
        '
        'AccessDataSet1
        '
        Me.AccessDataSet1.DataSetName = "AccessDataSet"
        Me.AccessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EAN", System.Data.SqlDbType.[Char], 13, "ean")})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=192.168.5.100;Initial Catalog=rendite;Persist Security Info=True;User" & _
    " ID=sa;Password=masterkey"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ARTSTAMM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("EAN1", "EAN1"), New System.Data.Common.DataColumnMapping("EAN2", "EAN2"), New System.Data.Common.DataColumnMapping("EAN3", "EAN3"), New System.Data.Common.DataColumnMapping("ean", "ean"), New System.Data.Common.DataColumnMapping("artnr", "artnr"), New System.Data.Common.DataColumnMapping("ARTBEZ", "ARTBEZ"), New System.Data.Common.DataColumnMapping("GBEREICH", "GBEREICH"), New System.Data.Common.DataColumnMapping("BEZ", "BEZ")})})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        Erfassung.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Erfassung"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection2
        '
        'OleDbConnection2
        '
        Me.OleDbConnection2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""|DataDirectory|\MDE - Kopie.mdb"";Pe" & _
    "rsist Security Info=True"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `Erfassung` (`ID`, `Fabrikat`, `Artikelbez`, `Ean`, `Anzahl`, `Warenb" & _
    "ereich`, `WarenbereichID`, `Namen`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection2
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.[Integer], 0, "ID"), New System.Data.OleDb.OleDbParameter("Fabrikat", System.Data.OleDb.OleDbType.VarWChar, 0, "Fabrikat"), New System.Data.OleDb.OleDbParameter("Artikelbez", System.Data.OleDb.OleDbType.VarWChar, 0, "Artikelbez"), New System.Data.OleDb.OleDbParameter("Ean", System.Data.OleDb.OleDbType.VarWChar, 0, "Ean"), New System.Data.OleDb.OleDbParameter("Anzahl", System.Data.OleDb.OleDbType.VarWChar, 0, "Anzahl"), New System.Data.OleDb.OleDbParameter("Warenbereich", System.Data.OleDb.OleDbType.VarWChar, 0, "Warenbereich"), New System.Data.OleDb.OleDbParameter("WarenbereichID", System.Data.OleDb.OleDbType.[Integer], 0, "WarenbereichID"), New System.Data.OleDb.OleDbParameter("Namen", System.Data.OleDb.OleDbType.VarWChar, 0, "Namen")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection2
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.[Integer], 0, "ID"), New System.Data.OleDb.OleDbParameter("Fabrikat", System.Data.OleDb.OleDbType.VarWChar, 0, "Fabrikat"), New System.Data.OleDb.OleDbParameter("Artikelbez", System.Data.OleDb.OleDbType.VarWChar, 0, "Artikelbez"), New System.Data.OleDb.OleDbParameter("Ean", System.Data.OleDb.OleDbType.VarWChar, 0, "Ean"), New System.Data.OleDb.OleDbParameter("Anzahl", System.Data.OleDb.OleDbType.VarWChar, 0, "Anzahl"), New System.Data.OleDb.OleDbParameter("Warenbereich", System.Data.OleDb.OleDbType.VarWChar, 0, "Warenbereich"), New System.Data.OleDb.OleDbParameter("WarenbereichID", System.Data.OleDb.OleDbType.[Integer], 0, "WarenbereichID"), New System.Data.OleDb.OleDbParameter("Namen", System.Data.OleDb.OleDbType.VarWChar, 0, "Namen"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Fabrikat", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Fabrikat", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fabrikat", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fabrikat", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Artikelbez", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Artikelbez", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Artikelbez", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Artikelbez", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Ean", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Ean", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ean", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ean", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Anzahl", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Anzahl", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Anzahl", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anzahl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Warenbereich", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Warenbereich", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Warenbereich", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Warenbereich", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_WarenbereichID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WarenbereichID", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_WarenbereichID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WarenbereichID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Namen", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Namen", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Namen", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Namen", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection2
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Fabrikat", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Fabrikat", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fabrikat", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fabrikat", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Artikelbez", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Artikelbez", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Artikelbez", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Artikelbez", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Ean", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Ean", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ean", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ean", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Anzahl", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Anzahl", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Anzahl", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anzahl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Warenbereich", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Warenbereich", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Warenbereich", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Warenbereich", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_WarenbereichID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "WarenbereichID", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_WarenbereichID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "WarenbereichID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Namen", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Namen", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Namen", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Namen", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Erfassung", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Fabrikat", "Fabrikat"), New System.Data.Common.DataColumnMapping("Artikelbez", "Artikelbez"), New System.Data.Common.DataColumnMapping("Ean", "Ean"), New System.Data.Common.DataColumnMapping("Anzahl", "Anzahl"), New System.Data.Common.DataColumnMapping("Warenbereich", "Warenbereich"), New System.Data.Common.DataColumnMapping("WarenbereichID", "WarenbereichID"), New System.Data.Common.DataColumnMapping("Namen", "Namen")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.EinstellungenToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(857, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatenbankenZusammenlegenToolStripMenuItem, Me.CSVErstellenToolStripMenuItem, Me.CSVKomplettErstellenToolStripMenuItem, Me.OhneDatebankAbfrageToolStripMenuItem, Me.SchliessenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'DatenbankenZusammenlegenToolStripMenuItem
        '
        Me.DatenbankenZusammenlegenToolStripMenuItem.Name = "DatenbankenZusammenlegenToolStripMenuItem"
        Me.DatenbankenZusammenlegenToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.DatenbankenZusammenlegenToolStripMenuItem.Text = "Datenbanken zusammenlegen"
        '
        'CSVErstellenToolStripMenuItem
        '
        Me.CSVErstellenToolStripMenuItem.Name = "CSVErstellenToolStripMenuItem"
        Me.CSVErstellenToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.CSVErstellenToolStripMenuItem.Text = "CSV Erstellen"
        '
        'CSVKomplettErstellenToolStripMenuItem
        '
        Me.CSVKomplettErstellenToolStripMenuItem.Name = "CSVKomplettErstellenToolStripMenuItem"
        Me.CSVKomplettErstellenToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.CSVKomplettErstellenToolStripMenuItem.Text = "CSV-Komplett Erstellen"
        '
        'OhneDatebankAbfrageToolStripMenuItem
        '
        Me.OhneDatebankAbfrageToolStripMenuItem.CheckOnClick = True
        Me.OhneDatebankAbfrageToolStripMenuItem.Name = "OhneDatebankAbfrageToolStripMenuItem"
        Me.OhneDatebankAbfrageToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.OhneDatebankAbfrageToolStripMenuItem.Text = "Ohne Datebank Abfrage!"
        '
        'SchliessenToolStripMenuItem
        '
        Me.SchliessenToolStripMenuItem.Name = "SchliessenToolStripMenuItem"
        Me.SchliessenToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.SchliessenToolStripMenuItem.Text = "Schliessen"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = """Access-Datei|*.mdb"""
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipTitle = "Mobile Datenerfassung"
        '
        'Csv1
        '
        Me.Csv1.DataSetName = "CSV"
        Me.Csv1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RenditeBindingSource
        '
        Me.RenditeBindingSource.DataMember = "ARTSTAMM"
        Me.RenditeBindingSource.DataSource = Me.RenditeDataSet1
        '
        'RenditeDataSet1
        '
        Me.RenditeDataSet1.DataSetName = "RenditeDataSet1"
        Me.RenditeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 342)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(857, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(46, 17)
        Me.ToolStripStatusLabel1.Text = "Datum:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(61, 17)
        Me.ToolStripStatusLabel2.Text = "01.01.2014"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(92, 17)
        Me.ToolStripStatusLabel3.Text = "Gezählte Artikel:"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabel4.Text = "0"
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 364)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(675, 280)
        Me.Name = "Form1"
        Me.Text = "MDE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Csv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RenditeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RenditeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RenditeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SchliessenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CSVErstellenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Csv1 As MDE.CSV
    Friend WithEvents AccessDataSet1 As MDE.AccessDataSet
    Friend WithEvents RenditeDataSet1 As MDE.RenditeDataSet1
    Friend WithEvents DatenbankenZusammenlegenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CSVKomplettErstellenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents OhneDatebankAbfrageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FabrikatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtikelbezDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnzahlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WarenbereichDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Namen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel

End Class
