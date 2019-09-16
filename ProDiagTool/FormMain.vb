Imports System.Data.OleDb
Imports System.IO
Public Class FormMain

    Dim dsSymbol As DataSet
    Dim SymbolLoaded As Boolean

    Dim SourceFilenameProDiag As String
    Dim fiProDiagSourceFile As FileInfo
    Dim dsProDiag As DataSet
    Dim ProDiagLoaded As Boolean

    Dim dsReplacements As DataSet
    Dim ReplacementsLoaded As Boolean

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BtnSymboleLoad_Click(sender As Object, e As EventArgs) Handles btnSymbolLoad.Click
        SymbolLoad()
    End Sub

    Private Sub BtnProDiagLoad_Click(sender As Object, e As EventArgs) Handles btnProDiagLoad.Click
        ProDiagLoad()
        If ProDiagLoaded Then
            dsProDiag.Tables(0).Columns.Add("Adresse")
            dsProDiag.Tables(0).Columns.Add("Comment")
            dgvProDiag.DataSource = dsProDiag
            dgvProDiag.DataMember = "[ProDiag Supervisions$]"
        End If
    End Sub

    Private Sub BtnProDiagSave_Click(sender As Object, e As EventArgs) Handles btnProDiagSave.Click
        ProDiagSave()
    End Sub

    Private Sub BtnReplacementsLoad_Click(sender As Object, e As EventArgs) Handles btnReplacementsLoad.Click
        ReplacementsLoad()
    End Sub

    Private Sub BtnSymbolsMap_Click(sender As Object, e As EventArgs) Handles btnSymbolsMap.Click
        Dim Anzahl As Integer
        Anzahl = SymbolsMap()
        MsgBox("Symbole gefunden: " & Anzahl)
    End Sub

    Private Sub BtnSpecificTextCreate_Click(sender As Object, e As EventArgs) Handles btnSpecificTextCreate.Click
        Dim Anzahl As Integer
        Anzahl = SpecificTextCreate()
        MsgBox("Texte bearbeitet: " & Anzahl)
    End Sub

    Private Sub SymbolLoad()
        Dim FileInfoSourceFile As FileInfo
        Dim Connectionstring As String
        Dim Connection As OleDbConnection
        Dim SqlStatement As String
        Dim Adapter As OleDbDataAdapter

        SymbolLoaded = False
        Try
            OpenFileDialog1.Title = "Symboltabelle laden"
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx"
            OpenFileDialog1.FileName = "PLCTags.xlsx"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                FileInfoSourceFile = New FileInfo(OpenFileDialog1.FileName)
                Connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileInfoSourceFile.FullName & ";Extended Properties = ""Excel 12.0 Xml;HDR=YES"""
                Connection = New OleDbConnection(Connectionstring)
                SqlStatement = "SELECT Name, [Logical Address], Comment, [Data Type] FROM [PLC Tags$]"
                Adapter = New OleDbDataAdapter(SqlStatement, Connection)
                dsSymbol = New DataSet
                Adapter.Fill(dsSymbol, "[PLC Tags$]")
                dgvSymbol.DataSource = dsSymbol
                dgvSymbol.DataMember = "[PLC Tags$]"
                SymbolLoaded = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Connection.Close()
        Connection.Dispose()
    End Sub

    Private Sub ProDiagLoad()
        Dim FileInfoSourceFile As FileInfo
        Dim Connectionstring As String
        Dim Connection As OleDbConnection
        Dim SqlStatement As String
        Dim Adapter As OleDbDataAdapter

        ProDiagLoaded = False
        SourceFilenameProDiag = Nothing
        Try
            OpenFileDialog1.Title = "ProDiag-Datei laden"
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx"
            OpenFileDialog1.FileName = "ProDiag.xlsx"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                FileInfoSourceFile = New FileInfo(OpenFileDialog1.FileName)
                Connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileInfoSourceFile.FullName & ";Extended Properties = ""Excel 12.0 Xml;HDR=YES"""
                Connection = New OleDbConnection(Connectionstring)
                SqlStatement = "SELECT ID, [Supervised tag], Trigger, [Specific text field] FROM [ProDiag Supervisions$]"
                Adapter = New OleDbDataAdapter(SqlStatement, Connection)
                dsProDiag = New DataSet
                Adapter.Fill(dsProDiag, "[ProDiag Supervisions$]")
                SourceFilenameProDiag = FileInfoSourceFile.FullName
                ProDiagLoaded = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Connection.Close()
        Connection.Dispose()
    End Sub

    Private Sub ProDiagSave()
        Dim FileInfoSourceFile As FileInfo
        Dim BackupFilename As String
        Dim FileInfoDestFile As FileInfo
        Dim DestFilename As String
        Dim Connectionstring As String
        Dim Connection As OleDbConnection
        Dim SqlStatement As String
        Dim Command As OleDbCommand
        Dim rowProDiag As DataRow
        Dim Anzahl As Integer

        'Datei-Operationen
        Try
            'Orginalfile sichern - Endung .bak
            FileInfoSourceFile = New FileInfo(SourceFilenameProDiag)
            BackupFilename = SourceFilenameProDiag.Replace(".xlsx", ".bak")
            If File.Exists(BackupFilename) Then
                File.Delete(BackupFilename)
            End If
            File.Copy(SourceFilenameProDiag, BackupFilename)

            'SavFileDialog init
            SaveFileDialog1.Title = "ProDiag-Datei speichern"
            SaveFileDialog1.InitialDirectory = FileInfoSourceFile.DirectoryName
            SaveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx"
            SaveFileDialog1.FileName = FileInfoSourceFile.Name.Replace(".xlsx", "New.xlsx")
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                DestFilename = SaveFileDialog1.FileName
                'Neuer Filename -> Orignalfile kopieren
                If DestFilename.ToLower <> SourceFilenameProDiag.ToLower Then
                    If File.Exists(DestFilename) Then
                        File.Delete(DestFilename)
                    End If
                    File.Copy(SourceFilenameProDiag, DestFilename)
                End If
                FileInfoDestFile = New FileInfo(DestFilename)
                DestFilename = FileInfoDestFile.FullName
            Else
                DestFilename = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Datenbank / Excel Operationen
        Try
            If DestFilename IsNot Nothing Then
                Connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & DestFilename & ";Extended Properties = ""Excel 12.0 Xml;HDR=YES"""
                Connection = New OleDbConnection(Connectionstring)
                SqlStatement = "UPDATE [ProDiag Supervisions$] SET [Specific text field] = @SpecificTextField WHERE ID = @ID"
                Command = New OleDbCommand(SqlStatement, Connection)
                'Parameter erzeugen
                Command.Parameters.AddWithValue("@SpecificTextField", "Init")
                Command.Parameters.AddWithValue("@ID", "0")
                Connection.Open()
                Anzahl = Command.ExecuteNonQuery()
                For Each rowProDiag In dsProDiag.Tables(0).Rows
                    Command.Parameters("@SpecificTextField").Value = rowProDiag.Item("Specific text field")
                    Command.Parameters("@ID").Value = rowProDiag.Item("ID")
                    Anzahl = Command.ExecuteNonQuery()
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Connection.Close()
        Connection.Dispose()
        Command.Dispose()

    End Sub

    Private Sub ReplacementsLoad()
        Dim FileInfoSourceFile As FileInfo
        Dim Connectionstring As String
        Dim Connection As OleDbConnection
        Dim Adapter As OleDbDataAdapter

        Try
            OpenFileDialog1.Title = "Textersetzungen laden"
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx"
            OpenFileDialog1.FileName = "TextErsetzungen.xlsx"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                FileInfoSourceFile = New FileInfo(OpenFileDialog1.FileName)
                Connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileInfoSourceFile.FullName & ";Extended Properties = ""Excel 12.0 Xml;HDR=YES"""
                Connection = New OleDbConnection(Connectionstring)
                Adapter = New OleDbDataAdapter("SELECT * FROM [Ersetzungen$]", Connection)
                dsReplacements = New DataSet
                Adapter.Fill(dsReplacements, "[Ersetzungen$]")
                dgvReplacements.DataSource = dsReplacements
                dgvReplacements.DataMember = "[Ersetzungen$]"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Connection.Close()
        Connection.Dispose()
    End Sub

    Private Function SymbolsMap() As Integer
        Dim rowProDiag As DataRow
        Dim rowSymbol As DataRow
        Dim Anzahl As Integer
        Try
            For Each rowProDiag In dsProDiag.Tables("[ProDiag Supervisions$]").Rows
                For Each rowSymbol In dsSymbol.Tables("[PLC Tags$]").Rows
                    'Bei Supervised tag müssen die Anführungszeichen Chr(34) entfernt werden  
                    If rowProDiag.Item("Supervised tag").ToString.Replace(Chr(34), "") = rowSymbol.Item("Name").ToString Then
                        'Bei Logical Adress wird das % entfernt
                        rowProDiag.Item("Adresse") = rowSymbol.Item("Logical Address").ToString.Replace("%", "")
                        rowProDiag.Item("Comment") = rowSymbol.Item("Comment")
                        Anzahl += 1
                    End If
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SymbolsMap = Anzahl
    End Function

    Private Function SpecificTextCreate() As Integer
        Dim rowProDiag As DataRow
        Dim Operant As String
        Dim Adresse As String
        Dim Comment As String
        Dim rowReplacement As DataRow
        Dim Replace As Boolean
        Dim SpecificText As String
        Dim Anzahl As Integer
        Try
            For Each rowProDiag In dsProDiag.Tables("[ProDiag Supervisions$]").Rows

                'Operant / Symbol
                Operant = "|Var: " & rowProDiag.Item("Supervised tag").ToString.Replace(Chr(34), "")

                'Adresse
                If rowProDiag.Item("Adresse").ToString <> "" Then
                    Adresse = "|Adr: " & rowProDiag.Item("Adresse")
                Else
                    Adresse = "|Adr: ???"
                End If

                'Kommentar
                Comment = "Text: " & rowProDiag.Item("Comment").ToString
                For Each rowReplacement In dsReplacements.Tables("[Ersetzungen$]").Rows
                    Replace = False
                    'Trigger prüfen
                    If rowReplacement.Item("Trigger") = "True" And rowProDiag.Item("Trigger") = "True" Then
                        Replace = True
                    ElseIf rowReplacement.Item("Trigger") = "False" And rowProDiag.Item("Trigger") = "False" Then
                        Replace = True
                    ElseIf rowReplacement.Item("Trigger") = "" Then
                        Replace = True
                    End If

                    'Ersetzung
                    If Replace And Comment.Contains(rowReplacement.Item("Text")) Then
                        Comment = Comment.Replace(rowReplacement.Item("Text"), rowReplacement.Item("Replace"))
                    End If
                Next
                If Comment = "" Then
                    Comment = "Text fehlt"
                End If

                'Spezifischen Text zusammenbauen
                SpecificText = Comment & " " & Operant & " " & Adresse

                If rowProDiag.Item("Specific text field").ToString <> "" _
                    And Not rowProDiag.Item("Specific text field").ToString.Contains("Text fehlt") _
                    And Not rowProDiag.Item("Specific text field").ToString = SpecificText _
                Then
                    If MessageBox.Show(rowProDiag.Item("Specific text field").ToString & vbCrLf & "Neuer Text: " & vbCrLf & SpecificText _
                                                , "Spezifischen Text überschreiben", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                        rowProDiag.Item("Specific text field") = SpecificText
                    End If
                Else
                        rowProDiag.Item("Specific text field") = SpecificText
                End If
                Anzahl += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SpecificTextCreate = Anzahl
    End Function
End Class
