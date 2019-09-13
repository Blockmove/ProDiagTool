Imports System.Data.OleDb
Imports System.IO
Public Class FormMain

    Dim dsSymbol As New DataSet

    Dim dsProDiag As New DataSet

    Dim dsReplacements As New DataSet
    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BtnSymboleLoad_Click(sender As Object, e As EventArgs) Handles btnSymbolLoad.Click
        SymbolLoad()
    End Sub

    Private Sub BtnProDiagLoad_Click(sender As Object, e As EventArgs) Handles btnProDiagLoad.Click
        ProDiagLoad()
    End Sub

    Private Sub BtnReplacementsLoad_Click(sender As Object, e As EventArgs) Handles btnReplacementsLoad.Click
        ReplacementsLoad()
    End Sub

    Private Sub SymbolLoad()
        Dim FileInfoSourceFile As FileInfo
        Dim Connectionstring As String
        Dim Connection As OleDbConnection
        Dim Adapter As OleDbDataAdapter

        Try
            OpenFileDialog1.Title = "Symboltabelle laden"
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx"
            OpenFileDialog1.FileName = "PLCTags.xlsx"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                FileInfoSourceFile = New FileInfo(OpenFileDialog1.FileName)
                Connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileInfoSourceFile.FullName & ";Extended Properties = ""Excel 12.0 Xml;HDR=YES"""
                Connection = New OleDbConnection(Connectionstring)
                Adapter = New OleDbDataAdapter("SELECT * FROM [PLC Tags$]", Connection)
                Adapter.Fill(dsSymbol, "[PLC Tags$]")
                dgvSymbol.DataSource = dsSymbol
                dgvSymbol.DataMember = "[PLC Tags$]"
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
        Dim Adapter As OleDbDataAdapter

        Try
            OpenFileDialog1.Title = "ProDiag-Datei laden"
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx"
            OpenFileDialog1.FileName = "ProDiag.xlsx"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                FileInfoSourceFile = New FileInfo(OpenFileDialog1.FileName)
                Connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileInfoSourceFile.FullName & ";Extended Properties = ""Excel 12.0 Xml;HDR=YES"""
                Connection = New OleDbConnection(Connectionstring)
                Adapter = New OleDbDataAdapter("SELECT * FROM [ProDiag Supervisions$]", Connection)
                Adapter.Fill(dsProDiag, "[ProDiag Supervisions$]")
                dgvProDiag.DataSource = dsProDiag
                dgvProDiag.DataMember = "[ProDiag Supervisions$]"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Connection.Close()
        Connection.Dispose()
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

End Class
