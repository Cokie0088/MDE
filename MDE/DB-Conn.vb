Imports System.IO
Public Module DB_sub

    Dim Setting(6) As String
    Public Function DB_conn() As String
        Dim Einstellungen As New Settings.Einstellungen
        Dim Pfad As String = Path.GetDirectoryName(Application.ExecutablePath)
        Einstellungen.FileName() = Pfad & "\MDE.cfg"
        Einstellungen.LoadReader()
        Setting(1) = Einstellungen.Items("ServerName")
        Setting(2) = Einstellungen.Items("Datenbank")
        Setting(3) = Einstellungen.Items("DatenbankUser")
        Setting(4) = Einstellungen.Items("DatenbankPassword")
        Setting(5) = Einstellungen.Items("Accesspfad")
        Setting(6) = Einstellungen.Items("Sicher")


        If Setting(6) = 1 Then
            Return "Data Source=" & Setting(1) & ";Initial Catalog=" & Setting(2) & ";Persist Security Info=True;User ID=" & Setting(3) & ";Password=" & Setting(4)
        Else
            Return "Data Source=" & Setting(1) & ";Initial Catalog=" & Setting(2) & ";Integrated Security=True"
        End If


    End Function

    Public Function Access_conn() As String
        Call DB_conn()
        Return Setting(5)
    End Function

End Module
