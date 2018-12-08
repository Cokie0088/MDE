Public Class Wait
    Dim _Labeltext As String = ""

    Public Property Labeltext() As String
        Get
            Return _Labeltext
        End Get
        Set(ByVal value As String)
            _Labeltext = value
            Me.Ladetext.Text = _Labeltext
        End Set
    End Property

    Public Property Progressbar() As ProgressBar
        Get
            Return ProgressBar1
        End Get
        Set(ByVal value As ProgressBar)
            ProgressBar1 = value
        End Set
    End Property

    Private Sub Wait_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class