Public Class Form4

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


    
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Pfad() As String

            'Dim Pfade As String
            If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                Pfad = Me.OpenFileDialog1.FileNames
                Me.ZusammenDataSet1.Tables("Erfassung").Clear()
                For Each Pfade As String In Pfad
                    Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Pfade
                    Me.OleDbDataAdapter1.SelectCommand.CommandText = "Select Fabrikat, Artikelbez, EAN, Anzahl, WarenbereichID, Warenbereich, Namen From Erfassung"
                    Me.OleDbDataAdapter1.Fill(Me.ZusammenDataSet1, "Erfassung")
                Next
                Me.LlDatensätzteEinzelne.Text = Me.ZusammenDataSet1.Tables("Erfassung").Rows.Count
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Me.Cursor = Cursors.Default
        End Try
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
End Class