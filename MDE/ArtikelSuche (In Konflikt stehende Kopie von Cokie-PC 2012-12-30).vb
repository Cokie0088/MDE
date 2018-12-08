Public Class ArtikelSuche
    Dim _DT As DataTable

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
End Class