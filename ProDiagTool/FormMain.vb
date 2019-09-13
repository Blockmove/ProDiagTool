Imports System.Data.OleDb
Imports System.IO
Public Class FormMain

    Dim dsSymbol As New DataSet
    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BtnSymboleLoad_Click(sender As Object, e As EventArgs) Handles btnSymbolLoad.Click
        SymbolLoad()
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
            OpenFileDialog1.FileName = "PLCTags.xlxs"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
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
End Class
