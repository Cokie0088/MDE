<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CbDBSave = New System.Windows.Forms.CheckBox()
        Me.TbDatenbankBenutzer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbDatenbankPasswort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbRenditeDatenbank = New System.Windows.Forms.TextBox()
        Me.TbSQLServer = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtAcessOeffnen = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbAccessDatenbank = New System.Windows.Forms.TextBox()
        Me.BtSettingsSave = New System.Windows.Forms.Button()
        Me.BtAbort = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TbRenditeDatenbank)
        Me.GroupBox1.Controls.Add(Me.TbSQLServer)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 179)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rendite SQL-Server"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CbDBSave)
        Me.GroupBox3.Controls.Add(Me.TbDatenbankBenutzer)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TbDatenbankPasswort)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 100)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Schutz"
        '
        'CbDBSave
        '
        Me.CbDBSave.AutoSize = True
        Me.CbDBSave.Location = New System.Drawing.Point(3, 19)
        Me.CbDBSave.Name = "CbDBSave"
        Me.CbDBSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CbDBSave.Size = New System.Drawing.Size(139, 17)
        Me.CbDBSave.TabIndex = 3
        Me.CbDBSave.Text = ":Geschützte Datenbank"
        Me.CbDBSave.UseVisualStyleBackColor = True
        '
        'TbDatenbankBenutzer
        '
        Me.TbDatenbankBenutzer.Location = New System.Drawing.Point(162, 45)
        Me.TbDatenbankBenutzer.Name = "TbDatenbankBenutzer"
        Me.TbDatenbankBenutzer.Size = New System.Drawing.Size(100, 20)
        Me.TbDatenbankBenutzer.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Datenbank Passwort:"
        '
        'TbDatenbankPasswort
        '
        Me.TbDatenbankPasswort.Location = New System.Drawing.Point(162, 71)
        Me.TbDatenbankPasswort.Name = "TbDatenbankPasswort"
        Me.TbDatenbankPasswort.Size = New System.Drawing.Size(100, 20)
        Me.TbDatenbankPasswort.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Datenbank Benutzer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Rendite Datenbank:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SQL-Server:"
        '
        'TbRenditeDatenbank
        '
        Me.TbRenditeDatenbank.Location = New System.Drawing.Point(171, 45)
        Me.TbRenditeDatenbank.Name = "TbRenditeDatenbank"
        Me.TbRenditeDatenbank.Size = New System.Drawing.Size(100, 20)
        Me.TbRenditeDatenbank.TabIndex = 1
        '
        'TbSQLServer
        '
        Me.TbSQLServer.Location = New System.Drawing.Point(171, 19)
        Me.TbSQLServer.Name = "TbSQLServer"
        Me.TbSQLServer.Size = New System.Drawing.Size(100, 20)
        Me.TbSQLServer.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(297, 217)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(289, 191)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rendite Datenbank"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(289, 191)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Access Datenbank"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtAcessOeffnen)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TbAccessDatenbank)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 92)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Access Datenbank"
        '
        'BtAcessOeffnen
        '
        Me.BtAcessOeffnen.Location = New System.Drawing.Point(134, 49)
        Me.BtAcessOeffnen.Name = "BtAcessOeffnen"
        Me.BtAcessOeffnen.Size = New System.Drawing.Size(137, 23)
        Me.BtAcessOeffnen.TabIndex = 2
        Me.BtAcessOeffnen.Text = "Access Datei Öffnen"
        Me.BtAcessOeffnen.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Access Datenbankpfad:"
        '
        'TbAccessDatenbank
        '
        Me.TbAccessDatenbank.Location = New System.Drawing.Point(134, 23)
        Me.TbAccessDatenbank.Name = "TbAccessDatenbank"
        Me.TbAccessDatenbank.Size = New System.Drawing.Size(137, 20)
        Me.TbAccessDatenbank.TabIndex = 0
        '
        'BtSettingsSave
        '
        Me.BtSettingsSave.Location = New System.Drawing.Point(12, 236)
        Me.BtSettingsSave.Name = "BtSettingsSave"
        Me.BtSettingsSave.Size = New System.Drawing.Size(75, 23)
        Me.BtSettingsSave.TabIndex = 2
        Me.BtSettingsSave.Text = "Speichern"
        Me.BtSettingsSave.UseVisualStyleBackColor = True
        '
        'BtAbort
        '
        Me.BtAbort.Location = New System.Drawing.Point(234, 236)
        Me.BtAbort.Name = "BtAbort"
        Me.BtAbort.Size = New System.Drawing.Size(75, 23)
        Me.BtAbort.TabIndex = 3
        Me.BtAbort.Text = "Abbrechen"
        Me.BtAbort.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Access-Datei|*.mdb"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 264)
        Me.Controls.Add(Me.BtAbort)
        Me.Controls.Add(Me.BtSettingsSave)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "MDE-Einstellungen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbDatenbankBenutzer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbRenditeDatenbank As System.Windows.Forms.TextBox
    Friend WithEvents TbSQLServer As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CbDBSave As System.Windows.Forms.CheckBox
    Friend WithEvents TbDatenbankPasswort As System.Windows.Forms.TextBox
    Friend WithEvents BtSettingsSave As System.Windows.Forms.Button
    Friend WithEvents BtAbort As System.Windows.Forms.Button
    Friend WithEvents BtAcessOeffnen As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TbAccessDatenbank As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
