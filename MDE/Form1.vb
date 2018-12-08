Imports System.IO
Public Class Form1
    Dim Pfad As String
    WithEvents Artikelsuche As ArtikelSuche
    WithEvents Einstellungen As Form2


    Private Sub Artikelsuche_event(ByVal EAN As String) Handles Artikelsuche.Artikel

        Me.RenditeDataSet1.Tables(0).Clear()
        Me.SqlConnection1.ConnectionString = DB_sub.DB_conn
        Me.SqlDataAdapter1.SelectCommand.Parameters.Clear()
        Me.SqlDataAdapter1.SelectCommand.CommandText = My.Resources.ArtikelsucheEAN
        Me.SqlDataAdapter1.SelectCommand.Parameters.AddWithValue("@EAN", EAN)
        Me.SqlDataAdapter1.Fill(Me.RenditeDataSet1, "Artstamm")
        Call Anzahl()
    End Sub

    Public Sub Access_load()

        Try
            Me.OleDbConnection2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Access_conn()
            Me.AccessDataSet1.Clear()
            Me.OleDbDataAdapter1.Fill(Me.AccessDataSet1, "Erfassung")
        Catch ex As OleDb.OleDbException
            MessageBox.Show("Die Access Datenbank konnte nicht gefunden werden. Bitte in denn Einstellungen eine gültige Access Datenbank einstellen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolStripStatusLabel2.Text = Date.Now
        Datenbankoeffnen()

    End Sub

    Public Sub Datenbankoeffnen() Handles Einstellungen.DatenbankLaden
        Try
            Pfad = Path.GetDirectoryName(Application.ExecutablePath)
            Dim settings As New Settings.Einstellungen
            settings.FileName = Pfad & "\MDE.cfg"
            settings.LoadReader()
            Me.TextBox2.Text = settings.Items("Namen")
            Call Access_load()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.TextBox2.Text = "" Then
            MsgBox("Bitte Zähler Namen eingeben!", MsgBoxStyle.Exclamation)

        Else

            If Not TextBox1.Text = "" Then
                If IsNumeric(TextBox1.Text) Then
                    If OhneDatebankAbfrageToolStripMenuItem.Checked Then
                        Dim DR As DataRow
                        RenditeDataSet1.Clear()
                        DR = Me.RenditeDataSet1.Tables("Artstamm").NewRow

                        DR.Item("EAN") = TextBox1.Text
                        DR.Item("Artbez") = " "
                        DR.Item("FABRIKAT") = " "
                        DR.Item("Bez") = " "
                        DR.Item("GBEREICH") = 0
                        DR.Item("artnr") = 0
                        Me.RenditeDataSet1.Tables("Artstamm").Rows.Add(DR)
                        Anzahl()
                    Else
                        Call RenditeSucheEAN()
                    End If


                Else
                    Call RenditeSucheNormal()

                End If
            End If



            '''''Autoscrolling im Datagridview ;)

            If DataGridView1.RowCount > 2 And CheckBox1.Checked Then

                DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(1)
            End If




        End If

    End Sub
    ''' <summary>
    ''' Die "normale" Rendite Suche mit Komma
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RenditeSucheNormal()
        Me.RenditeDataSet1.Clear()
        Dim Artbez As String = ""
        Dim Fabrikat As String = ""
        Dim Text() As String
        Try
            '' Erstmal denn Text auf Komma untersuchen und dann die teile dann in ein Array schieben
            Text = TextBox1.Text.Split(",")
            '' Das erste sollte immer das Fabrikat sein!
            Fabrikat = Text(0)

            '' Wenn das Array größer als 1 ist wird angenommen das der 2 Punkt im Array die Artikelbezeichnung ist.
            If Text.Length > 1 Then
                Artbez = Text(1)
                Artbez = StringX(Artbez, "%")
            End If

            Me.SqlConnection1.ConnectionString = DB_sub.DB_conn
            Me.SqlDataAdapter1.SelectCommand.Parameters.Clear()
            Me.SqlDataAdapter1.SelectCommand.CommandText = My.Resources.ArtikelsucheNormal



            ''Füllt das Dataset mit denn Daten!!!
            Me.SqlDataAdapter1.SelectCommand.Parameters.AddWithValue("@Artbez", "%" & Artbez & "%")
            Me.SqlDataAdapter1.SelectCommand.Parameters.AddWithValue("@Fabrikat", "%" & Fabrikat & "%")
            Me.SqlDataAdapter1.Fill(Me.RenditeDataSet1, "Artstamm")

            ''Prüft ob die Bindungsource Über 1 einstrag verfügt Verfügt wenn ja wir gleich zu Anzahl weitergesprungen!
            ''Ansonsten wird die Artikelauswahl aufgemacht!
            If Me.RenditeBindingSource.Count = 1 Then
                Anzahl()

            ElseIf Me.RenditeBindingSource.Count > 1 Then
                Artikelsuche = New ArtikelSuche()
                Artikelsuche.Datatable = Me.RenditeDataSet1.Tables(0)

                Artikelsuche.Show()
            Else
                MsgBox("Nichts zu finden mit: " & TextBox1.Text, MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


    End Sub




    Public Function StringX(ByVal TheString As String, _
       ByVal TheChar As Char) As String

        If String.IsNullOrEmpty(TheString) Then Return String.Empty

        Dim stb As New System.Text.StringBuilder
        For i As Integer = 0 To TheString.Length - 1
            stb.Append(TheString(i))
            If Not TheString(i) = " "c Then stb.Append(TheChar)
        Next i
        Return stb.ToString
    End Function
    Private Sub RenditeSucheEAN()


        Me.RenditeDataSet1.Clear()
        Try
            Me.SqlConnection1.ConnectionString = DB_sub.DB_conn
            Me.SqlDataAdapter1.SelectCommand.Parameters.Clear()
            Me.SqlDataAdapter1.SelectCommand.CommandText = My.Resources.ArtikelsucheEAN
            ''Füllt das Dataset mit denn Daten!!!
            Me.SqlDataAdapter1.SelectCommand.Parameters.AddWithValue("@EAN", Me.TextBox1.Text)
            Me.SqlDataAdapter1.Fill(Me.RenditeDataSet1, "Artstamm")

            ''Prüft ob die Bindungsource Über einträge Verfügt wenn ja wir gleich zu Anzahl weitergesprungen!
            If Me.RenditeBindingSource.Count > 0 Then
                Anzahl()

            Else
                ''Sollten keine Einträge in der Bindingsource sein. Wir ein 0 An die EAN Gehängt und nochmal gesucht.
                ''Sollte da auch nichts gefunden werden wird eine Meldung ausgegeben!
                Me.SqlDataAdapter1.SelectCommand.Parameters.Clear()
                Dim EAN As String
                EAN = "0" + Me.TextBox1.Text
                Me.TextBox1.Text = EAN
                Me.SqlDataAdapter1.SelectCommand.Parameters.AddWithValue("@EAN", EAN)
                Me.SqlDataAdapter1.Fill(Me.RenditeDataSet1, "Artstamm")
                If RenditeBindingSource.Count > 0 Then
                    Anzahl()
                Else
                    MsgBox("Kenn ich nicht!", MsgBoxStyle.Critical)
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Anzahl()
        Dim iAnzahl As String
        iAnzahl = InputBox("Anzahl", "Anzahl", "1")
        If iAnzahl <> "" Then
            If CType(iAnzahl, Double) > 500 Then
                If MessageBox.Show("Die Anzahl ist größer als 500 ist das Richtig?", "Anzahl", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If CType(iAnzahl, Double) > 100000 Then
                        MessageBox.Show("Die Zahl ist Größer als 10000, das Stimmt nicht!!!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Call AccessDatasetfuellen(iAnzahl)
                End If

            Else
                Call AccessDatasetfuellen(iAnzahl)
            End If

        End If
    End Sub

    Private Sub AccessDatasetfuellen(ByVal Anzahl As Integer)
        Dim Dr As DataRow
        Dr = Me.AccessDataSet1.Tables(0).NewRow()
        Dr.Item("Artikelbez") = Me.RenditeDataSet1.Tables(0).Rows(0).Item("Artbez")
        Dr.Item("Fabrikat") = Me.RenditeDataSet1.Tables(0).Rows(0).Item("FABRIKAT")
        Dr.Item("Ean") = Me.RenditeDataSet1.Tables(0).Rows(0).Item("ean")
        Dr.Item("Anzahl") = Anzahl 'Me.NumericUpDown1.Value
        Dr.Item("Warenbereich") = Me.RenditeDataSet1.Tables(0).Rows(0).Item("Bez")
        Dr.Item("WarenbereichID") = Me.RenditeDataSet1.Tables(0).Rows(0).Item("GBEREICH")
        Dr.Item("Namen") = Me.TextBox2.Text
        Me.AccessDataSet1.Tables(0).Rows.Add(Dr)
        Call Accessschreiben()
        Me.TextBox1.Text = ""
    End Sub
    Public Sub Accessschreiben()
        Try
            Me.BindingSource1.EndEdit()
            Me.OleDbDataAdapter1.Update(Me.AccessDataSet1, "erfassung")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub DataGridView1_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        Call Accessschreiben()
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinstellungenToolStripMenuItem.Click
        Einstellungen = New Form2
        Einstellungen.Show(Owner)

    End Sub

    Private Sub CSVErstellenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSVErstellenToolStripMenuItem.Click
        Dim CSV As New Form3
        CSV.Show(Owner)

    End Sub

    Private Sub DataGridView1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.Enter
        Me.AcceptButton.NotifyDefault(False)

    End Sub

    Private Sub DataGridView1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.Leave
        Me.AcceptButton.NotifyDefault(True)
    End Sub

    Private Sub DataGridView1_UserAddedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        Call RenditeSucheEAN()
    End Sub

    Private Sub DataGridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
    
        Call Accessschreiben()
    End Sub

    Private Sub DatenbankenZusammenlegenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatenbankenZusammenlegenToolStripMenuItem.Click
        Dim Form4 As New Form4
        Form4.Show()
    End Sub

    Private Sub TextBox2_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Validated

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim settings As New Settings.Einstellungen
        settings.FileName = Pfad & "\MDE.cfg"
        settings.Items("Namen") = Me.TextBox2.Text
        settings.SaveWriter()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub CSVKomplettErstellenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSVKomplettErstellenToolStripMenuItem.Click
        Dim CSVErstellen As New CSVErstellen
        CSVErstellen.Show()
    End Sub

    Private Sub OhneDatebankAbfrageToolStripMenuItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OhneDatebankAbfrageToolStripMenuItem.CheckedChanged
        If OhneDatebankAbfrageToolStripMenuItem.Checked Then
            Me.BackColor = Color.Red
            GroupBox1.BackColor = Color.Red
            Label3.Visible = True
        Else
            Me.BackColor = Color.Empty
            GroupBox1.BackColor = Color.Empty
            Label3.Visible = False
        End If
    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles BindingSource1.CurrentChanged
        Me.ToolStripStatusLabel4.Text = Me.BindingSource1.Count
    End Sub
End Class
