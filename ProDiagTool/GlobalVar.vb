Imports System.IO

'Globale Variablen definieren
'Definition als Public Shared.
'Dadurch ist keine Instanz notwendig (Variable ist Mitglied der Class und nicht nur der Instanz)
Public Class GlobalVar

    Public Shared dsSymbol As DataSet
    Public Shared SymbolLoaded As Boolean

    Public Shared SourceFilenameProDiag As String
    Public Shared fiProDiagSourceFile As FileInfo
    Public Shared dsProDiag As DataSet
    Public Shared ProDiagLoaded As Boolean

    Public Shared dsReplacements As DataSet
    Public Shared ReplacementsLoaded As Boolean

End Class
