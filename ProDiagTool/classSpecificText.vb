Public Class classSpecificText
    Public Function SymbolsMap() As Integer
        'Public Function SymbolsMap(ByVal dsSymbol As DataSet, ByRef dsProDiag As DataSet) As Integer
        Dim rowProDiag As DataRow
        Dim rowSymbol As DataRow
        Dim Anzahl As Integer
        Try
            For Each rowProDiag In GlobalVar.dsProDiag.Tables("[ProDiag Supervisions$]").Rows
                For Each rowSymbol In GlobalVar.dsSymbol.Tables("[PLC Tags$]").Rows
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
End Class
