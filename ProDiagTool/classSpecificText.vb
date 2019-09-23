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

    Public Function Create() As Integer
        'Der Specific Text hat folgendes Format (XML)
        '<SpecificField>
        '<Entry Language="de-DE">Text ABC</Entry>
        '</SpecificField>
        Const Prefix As String = "<SpecificField>" & vbCrLf & "<Entry Language=" & """de-DE""" & ">"
        Const Suffix As String = "</Entry>" & vbCrLf & "</SpecificField>"

        Dim rowProDiag As DataRow
        Dim Operant As String
        Dim Adresse As String
        Dim Comment As String
        Dim rowReplacement As DataRow
        Dim Replace As Boolean
        Dim SpecificText As String
        Dim Anzahl As Integer

        Try
            For Each rowProDiag In GlobalVar.dsProDiag.Tables("[ProDiag Supervisions$]").Rows

                'Operant / Symbol
                Operant = "| Var: " & rowProDiag.Item("Supervised tag").ToString.Replace(Chr(34), "")

                'Adresse
                If rowProDiag.Item("Adresse").ToString <> "" Then
                    Adresse = "| Adr: " & rowProDiag.Item("Adresse")
                Else
                    Adresse = "| Adr: ???"
                End If

                'Kommentar
                Comment = rowProDiag.Item("Comment").ToString
                For Each rowReplacement In GlobalVar.dsReplacements.Tables("[Ersetzungen$]").Rows
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
                SpecificText = Prefix & Comment & " " & Operant & " " & Adresse & Suffix

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
        Create = Anzahl
    End Function
End Class
