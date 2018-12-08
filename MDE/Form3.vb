Public Class Form3
    Dim Pfad As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCSVErstellen.Click
        Dim Name As String
        Name = Me.CbWarenbereich.Text
        Name = Trim(Name)
        Try

            'Me.SaveFileDialog1.FileName = Name
           
            Me.SaveFileDialog1.ShowDialog()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub Warenbereichladen()
        Dim SQLString As String = "SELECT Erfassung.Warenbereich, Erfassung.WarenbereichID FROM Erfassung Group by WarenbereichID, Warenbereich"
        Me.OleDbDataAdapter1.SelectCommand.CommandText = SQLString
        Me.OleDbDataAdapter1.Fill(Me.CsvDataSet1, "Warenbereich")
    End Sub

    Private Sub Datenladen()
        Try
            '' Abfrage ob eine MDB datei ausgewählt wurde sonst gibts ne fehler meldung!!!

            If Pfad <> "" Then
                Me.CsvDataSet1.Tables("Erfassung").Clear()
                Me.OleDbDataAdapter1.SelectCommand.Parameters.Clear()
                Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Pfad
                Me.OleDbDataAdapter1.SelectCommand.CommandText = "SELECT Ean, Anzahl FROM Erfassung Where WarenbereichID = @BereichID"
                Me.OleDbDataAdapter1.SelectCommand.Parameters.AddWithValue("@BereichID", Me.CbWarenbereich.SelectedValue)
                Me.OleDbDataAdapter1.Fill(Me.CsvDataSet1, "Erfassung")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim DR As DataRow
        Dim DC As DataColumn
        Dim Stringtest As String
        Try
            Dim SW As New IO.StreamWriter(Me.SaveFileDialog1.FileName.ToString, False)
            For Each DR In Me.CsvDataSet1.Tables(0).Rows
                Stringtest = ""
                For Each DC In Me.CsvDataSet1.Tables(0).Columns
                    Stringtest += IIf(Stringtest <> "", ";", "").ToString
                    Stringtest += DR.Item(DC.ColumnName()).ToString

                Next
                SW.Write(Stringtest & Chr(10))
            Next

            SW.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ComboBox1_DropDownClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbWarenbereich.DropDownClosed
        Call Datenladen()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbMDEOeffnen.Click
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Pfad = Me.OpenFileDialog1.FileName
            Me.TbMDEPfad.Text = Pfad
            Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Pfad
            Try
                Me.OleDbConnection1.Open()
                Me.OleDbConnection1.Close()
                Call Warenbereichladen()
                Call Datenladen()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                Me.OleDbConnection1.Close()
            End Try

        End If
    End Sub

  
    Private Sub BindingSource1_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles BindingSource1.CurrentChanged
        Me.ToolStripStatusLabel2.Text = Me.BindingSource1.Count
    End Sub
End Class