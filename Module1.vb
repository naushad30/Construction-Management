
Imports System.Data.OleDb
Module Module1
    Public cn As New OleDbConnection
    Public cm As New OleDbCommand
    Public dr As OleDbDataReader
    Sub connection()
        With cn
            .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ssdatabase\SSConstruction.accdb"
            .Open()

        End With
    End Sub
End Module
