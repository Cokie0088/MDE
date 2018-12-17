<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArtikelSuche
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RenditeDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fabrikat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Artikelbezeichung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Warenbereich = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.RenditeDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(12, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Übernehmen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(658, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(186, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Abbrechen"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EAN, Me.Fabrikat, Me.Artikelbezeichung, Me.Warenbereich})
        Me.DataGridView1.DataSource = Me.RenditeDataSet1BindingSource
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(832, 197)
        Me.DataGridView1.TabIndex = 3
        '
        'EAN
        '
        Me.EAN.DataPropertyName = "ean"
        Me.EAN.HeaderText = "Ean"
        Me.EAN.Name = "EAN"
        Me.EAN.ReadOnly = True
        Me.EAN.Width = 150
        '
        'Fabrikat
        '
        Me.Fabrikat.DataPropertyName = "Fabrikat"
        Me.Fabrikat.HeaderText = "Fabrikat"
        Me.Fabrikat.Name = "Fabrikat"
        Me.Fabrikat.ReadOnly = True
        Me.Fabrikat.Width = 150
        '
        'Artikelbezeichung
        '
        Me.Artikelbezeichung.DataPropertyName = "artbez"
        Me.Artikelbezeichung.HeaderText = "Artieklbezeichnung"
        Me.Artikelbezeichung.Name = "Artikelbezeichung"
        Me.Artikelbezeichung.ReadOnly = True
        Me.Artikelbezeichung.Width = 150
        '
        'Warenbereich
        '
        Me.Warenbereich.DataPropertyName = "Bez"
        Me.Warenbereich.HeaderText = "Warenbereich"
        Me.Warenbereich.Name = "Warenbereich"
        Me.Warenbereich.ReadOnly = True
        Me.Warenbereich.Width = 200
        '
        'ArtikelSuche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 266)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ArtikelSuche"
        Me.Text = "ArtikelSuche"
        CType(Me.RenditeDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RenditeDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fabrikat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Artikelbezeichung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Warenbereich As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
