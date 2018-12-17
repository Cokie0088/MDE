Public Class ArtikelSuche
    Dim _DT As DataTable

   
    Public Event Artikel(ByVal Ean As String)




    Public Property Datatable() As DataTable
        Get
            Return _DT
        End Get
        Set(ByVal value As DataTable)
            _DT = value
        End Set
    End Property

    Private Sub ArtikelSuche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RenditeDataSet1BindingSource.DataSource = _DT
        Me.DataGridView1.DataSource = Me.RenditeDataSet1BindingSource

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim EAN As String
        EAN = DataGridView1.CurrentRow.Cells("EAN").Value.ToString
        Me.Close()
        RaiseEvent Artikel(EAN)
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        AcceptButton = Button1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim EAN As String
        EAN = DataGridView1.CurrentRow.Cells("EAN").Value.ToString
        Me.Close()
        RaiseEvent Artikel(EAN)
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

    End Sub
End Class