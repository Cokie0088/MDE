<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CSVErstellen
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
        Me.MDBOeffnen = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Dateinamen = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'MDBOeffnen
        '
        Me.MDBOeffnen.Location = New System.Drawing.Point(387, 11)
        Me.MDBOeffnen.Name = "MDBOeffnen"
        Me.MDBOeffnen.Size = New System.Drawing.Size(135, 23)
        Me.MDBOeffnen.TabIndex = 0
        Me.MDBOeffnen.Text = "MDB Dateien Öffnen"
        Me.MDBOeffnen.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'Dateinamen
        '
        Me.Dateinamen.Location = New System.Drawing.Point(65, 14)
        Me.Dateinamen.Name = "Dateinamen"
        Me.Dateinamen.Size = New System.Drawing.Size(316, 20)
        Me.Dateinamen.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dateien:"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'SaveFileDialog1
        '
        '
        'CSVErstellen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 49)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dateinamen)
        Me.Controls.Add(Me.MDBOeffnen)
        Me.MaximumSize = New System.Drawing.Size(550, 87)
        Me.MinimumSize = New System.Drawing.Size(550, 87)
        Me.Name = "CSVErstellen"
        Me.Text = "CSVErstellen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MDBOeffnen As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Dateinamen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
