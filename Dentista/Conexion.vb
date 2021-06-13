Imports System.Data.OleDb.OleDbConnection
Module Conexion
    Public cnx As OleDb.OleDbConnection
    Public mysqlstring As String
    Public Cmd As OleDb.OleDbCommand
    Dim ruta As String

    Public Sub ABREBD()
        cnx = New OleDb.OleDbConnection
        ruta = Application.StartupPath
        cnx.ConnectionString = ("provider = Microsoft.ACE.OLEDB.12.0; Data Source = " & ruta & "\Dentista.accdb")
        cnx.Open()

    End Sub

    Public Sub CIERRABD()
        cnx.Close()


    End Sub
End Module
