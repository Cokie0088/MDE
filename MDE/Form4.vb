Public Class Form4
    Dim Pfad() As String
    Dim Wait As Wait
    Dim LabelText_Waitbox As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim NewRow As DataRow
            Me.Cursor = Cursors.WaitCursor
            For Each row As DataGridViewRow In Me.DataGridView1.SelectedRows
                NewRow = Me.ZusammenDataSet1.Tables("Zusammen").NewRow
                NewRow.Item("Fabrikat") = Me.DataGridView1.Item(0, row.Index).Value
                NewRow.Item("Artikelbez") = Me.DataGridView1.Item(1, row.Index).Value
                NewRow.Item("EAN") = Me.DataGridView1.Item(2, row.Index).Value
                NewRow.Item("Anzahl") = Me.DataGridView1.Item(3, row.Index).Value
                NewRow.Item("WarenbereichID") = Me.DataGridView1.Item(4, row.Index).Value
                NewRow.Item("Warenbereich") = Me.DataGridView1.Item(5, row.Index).Value
                NewRow.Item("Namen") = Me.DataGridView1.Item(6, row.Index).Value

                Me.ZusammenDataSet1.Tables("zusammen").Rows.Add(NewRow)
                Me.LlDatenseatzteZusammen.Text = Me.ZusammenDataSet1.Tables("zusammen").Rows.Count

            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        
        Me.Cursor = Cursors.Default
    End Sub


    
    Private Sub Bt_Einzelnoeffnen_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Einzelnoeffnen.Click

        Me.Cursor = Cursors.WaitCursor
        Wait = New Wait
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Pfad = OpenFileDialog1.FileNames
            Me.Bt_Einzelnoeffnen.Enabled = False
            Wait.Show()

            BackgroundWorker1.RunWorkerAsync()


        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Me.Cursor = Cursors.Default
            Dim cat As New ADOX.Catalog
            Dim Pfad As String
            Dim CMD As New OleDb.OleDbCommand
            If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Pfad = Me.SaveFileDialog1.FileName
                Me.TextBox1.Text = Pfad
                cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Pfad)

                Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Pfad
                CMD.Connection = Me.OleDbConnection1
                CMD.CommandText = "CREATE TABLE Erfassung(ID Counter, Fabrikat char(50), Artikelbez char(50), EAN char(50), Anzahl char(50), Warenbereich char(255), WarenbereichID int, Namen char(50))"
                CMD.Connection.Open()
                CMD.ExecuteNonQuery()
                CMD.Connection.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Me.TextBox1.Text
            Me.OleDbDataAdapter1.Update(Me.ZusammenDataSet1, "Zusammen")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

   
    Private Sub BtZusammenOeffnen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtZusammenOeffnen.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Pfad() As String

            'Dim Pfade As String
            If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                Pfad = Me.OpenFileDialog1.FileNames
                Me.ZusammenDataSet1.Tables("zusammen").Clear()
                For Each Pfade As String In Pfad
                    Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Pfade
                    Me.OleDbDataAdapter1.SelectCommand.CommandText = "Select Fabrikat, Artikelbez, EAN, Anzahl, WarenbereichID, Warenbereich, Namen From Erfassung"
                    Me.OleDbDataAdapter1.Fill(Me.ZusammenDataSet1, "zusammen")
                Next
                Me.LlDatenseatzteZusammen.Text = Me.ZusammenDataSet1.Tables("zusammen").Rows.Count
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim Anzahl As Integer
            Dim Prozent As Integer
            Dim Durchgang As Integer = 1
            Me.ZusammenDataSet1.Tables("Erfassung").Clear()
            Anzahl = Pfad.Length
            Dim DT As DataTable
            DT = New DataTable
            For Each Pfade As String In Pfad
                OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Pfade
                OleDbDataAdapter1.SelectCommand.CommandText = "Select Fabrikat, Artikelbez, EAN, Anzahl, WarenbereichID, Warenbereich, Namen From Erfassung"

                'OleDbDataAdapter1.Fill(ZusammenDataSet1, "Erfassung")
                OleDbDataAdapter1.Fill(DT)

                'ZusammenDataSet1.Tables("Erfassung").Merge(DT)


                Prozent = 100 / Anzahl
                Prozent = Prozent * Durchgang
                LabelText_Waitbox = Pfade
                BackgroundWorker1.ReportProgress(Prozent)
                Durchgang += 1

            Next

            e.Result = DT

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Me.ZusammenDataSet1.Tables("Erfassung").Merge(e.Result)

        Me.BindingSource1.CurrencyManager.Refresh()

        Me.Bt_Einzelnoeffnen.Enabled = True
        Me.LlDatensätzteEinzelne.Text = Me.ZusammenDataSet1.Tables("Erfassung").Rows.Count
        Wait.Close()
        Wait.Dispose()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Wait.ProgressBar1.Maximum = 100
        Wait.ProgressBar1.Value = e.ProgressPercentage
        Wait.Labeltext = LabelText_Waitbox
    End Sub

    
End Class