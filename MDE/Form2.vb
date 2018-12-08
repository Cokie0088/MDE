Imports Settings
Imports System.IO
Public Class Form2
    Dim Einstellungen As New Einstellungen
    Dim Setting(6) As String
    Dim Pfad As String
    Public Event DatenbankLaden(ByVal sender As Object, ByVal e As EventArgs)

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Pfad = Path.GetDirectoryName(Application.ExecutablePath)
            Einstellungen.FileName() = Pfad & "\MDE.cfg"
            Einstellungen.LoadReader()
            Setting(1) = Einstellungen.Items("ServerName")
            Setting(2) = Einstellungen.Items("Datenbank")
            Setting(3) = Einstellungen.Items("DatenbankUser")
            Setting(4) = Einstellungen.Items("DatenbankPassword")
            Setting(5) = Einstellungen.Items("Accesspfad")
            Setting(6) = Einstellungen.Items("Sicher")


            Me.TbSQLServer.Text = Setting(1)
            Me.TbRenditeDatenbank.Text = Setting(2)
            Me.TbDatenbankBenutzer.Text = Setting(3)
            Me.TbDatenbankPasswort.Text = Setting(4)
            Me.TbAccessDatenbank.Text = Setting(5)
            Me.CbDBSave.Checked = Setting(6)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtSettingsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSettingsSave.Click
        Einstellungen.FileName = Pfad & "\MDE.cfg"
        Setting(1) = Me.TbSQLServer.Text
        Setting(2) = Me.TbRenditeDatenbank.Text
        Setting(3) = Me.TbDatenbankBenutzer.Text
        Setting(4) = Me.TbDatenbankPasswort.Text
        Setting(5) = Me.OpenFileDialog1.FileName
        Setting(6) = Me.CbDBSave.CheckState
        Einstellungen.Items("ServerName") = Setting(1)
        Einstellungen.Items("Datenbank") = Setting(2)
        Einstellungen.Items("DatenbankUser") = Setting(3)
        Einstellungen.Items("DatenbankPassword") = Setting(4)
        Einstellungen.Items("Accesspfad") = Setting(5)
        Einstellungen.Items("Sicher") = Setting(6)
        Einstellungen.SaveWriter()
        RaiseEvent DatenbankLaden(Me, EventArgs.Empty)
        Me.Close()
        Me.Dispose(True)
    End Sub

    Private Sub BtAbort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAbort.Click
        Me.Close()
        Me.Dispose(True)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAcessOeffnen.Click
        Me.OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Setting(5) = Me.OpenFileDialog1.FileName
        Me.TbAccessDatenbank.Text = Me.OpenFileDialog1.FileName
    End Sub
End Class