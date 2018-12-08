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

            For Each Pfade As String In Pfad
                OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Pfade
                OleSelectCommand.CommandText = "Select Fabrikat, Artikelbez, EAN, Anzahl, WarenbereichID, Warenbereich, Namen From Erfassung"
                OleSelectCommand.Connection = OleDbConnection1
                OleDbDataAdapter1.SelectCommand = OleSelectCommand
                OleDbDataAdapter1.Fill(ZusammenDataset1, "zusammen")
                Prozent = 100 / Anzahl
                Prozent = Prozent * Durchgang
                Labeltext_Waitbox = Pfade
                BackgroundWorker1.ReportProgress(Prozent)
                Durchgang += 1

            Next

            Dim Test As String
            Dim Test2(10) As String
            Dim ArrayList As New ArrayList
            Dim Inte As Integer = 1
            For Each DataRow As DataRow In ZusammenDataset1.zusammen.Rows()
                Inte += 1
                Test = DataRow.Item("Warenbereich").ToString
                If Array.Find(Test2, CType(Test, String)) = True Then

                    Test2(Inte) = (Test)

                End If


                'Test(Inte) = DataRow.Item("Warenbereich").ToString



            Next

            For Each Test3 As String In Test2
                Debug.WriteLine("Hallo: " & Test3)
            Next

            e.Result = ZusammenDataset1


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'Me.ZusammenDataset1 = e.Result
        'Dim Cat As New ADOX.Catalog
        'Dim Ole As New OleDb.OleDbCommand
        'Dim Con As New OleDb.OleDbConnection
        'Dim Str As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Zusamm.mdb; Jet OLEDB:Engine Type=5;"
        'Dim Tabelleerstellen As String = "CREATE TABLE Zusammen ([ID] Counter, [EAN] Long, [Anzahl] Long, [Warenbereich] Text, [WarenbereichID] Integer) "
        'Dim Insert As String = "Insert Into Zusammen (ID, EAN, Anzahl, Warenbereich, WarenbereichID) Value ('', @EAN, @Anzahl, @Warenbereich, @WarenbereichID)"


        'Try
        '    Cat.Create(Str)
        'Catch ex As Exception

        'End Try

        'Try
        '    Con.ConnectionString = Str
        '    Ole.CommandText() = Tabelleerstellen
        '    Ole.Connection = Con
        '    Con.Open()

        '    Ole.ExecuteNonQuery()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical)
        'End Try

        'Debug.WriteLine(ZusammenDataset1.zusammen.Rows(1).RowState)




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

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
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
End Class