Imports System.Linq
Public Class CSVErstellen
    Dim Pfad() As String
    Dim Labeltext_Waitbox As String

    Dim ZusammenDataset1 As ZusammenDataSet
    Dim Wait As Wait

    Private Sub MDBOeffnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MDBOeffnen.Click
        Me.Cursor = Cursors.WaitCursor
        Wait = New Wait
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Pfad = OpenFileDialog1.FileNames
            MDBOeffnen.Enabled = False
            Wait.Show()

            BackgroundWorker1.RunWorkerAsync()


        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim OleDbConnection1 As New OleDb.OleDbConnection
            Dim OleSelectCommand As New OleDb.OleDbCommand
            Dim OleDbDataAdapter1 As New OleDb.OleDbDataAdapter
            ZusammenDataset1 = New ZusammenDataSet


            Dim Anzahl As Integer
            Dim Prozent As Integer
            Dim Durchgang As Integer = 1
            Me.ZusammenDataset1.Tables("Erfassung").Clear()
            Anzahl = Pfad.Length
            Dim DT As DataTable
            DT = New DataTable


            For Each Pfade As String In Pfad
                OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Pfade
                OleSelectCommand.CommandText = "Select Fabrikat, Artikelbez, EAN, Anzahl, WarenbereichID, Warenbereich, Namen From Erfassung"
                OleSelectCommand.Connection = OleDbConnection1
                OleDbDataAdapter1.SelectCommand = OleSelectCommand
                OleDbDataAdapter1.Fill(DT)
                Prozent = 100 / Anzahl
                Prozent = Prozent * Durchgang
                Labeltext_Waitbox = Pfade
                BackgroundWorker1.ReportProgress(Prozent)
                Durchgang += 1

            Next
            e.Result = DT


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
       
        ZusammenDataset1.Tables("zusammen").Merge(e.Result)

        Dim OleDbConnection1 As New OleDb.OleDbConnection
        Dim OleSelectCommand As New OleDb.OleDbCommand
        Dim OleDbDataAdapter1 As New OleDb.OleDbDataAdapter

        OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Access_conn()





        Me.MDBOeffnen.Enabled = True
        Wait.Close()
        Wait.Dispose()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Wait.ProgressBar1.Maximum = 100
        Wait.ProgressBar1.Value = e.ProgressPercentage
        Wait.Labeltext = Labeltext_Waitbox
    End Sub

    Private Sub CSVErstellen()
        Try
            Me.SaveFileDialog1.FileName = Name
            Me.SaveFileDialog1.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CSVSpeichern()
        Dim DR As DataRow
        Dim Stringtest As String
        Try
            Dim SW As New IO.StreamWriter(Me.SaveFileDialog1.FileName.ToString, False)
            For Each DR In ZusammenDataset1.Tables(0).Rows
                Stringtest = ""
                Stringtest += DR.Item("EAN")
                Stringtest += ";"
                Stringtest += DR.Item("Anzahl")
                SW.Write(Stringtest & Chr(10))
            Next

            SW.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub


    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
       
    End Sub
End Class