Imports System.Data.OleDb
Module ModGem
    Public dbCon As New OleDbConnection

    Public Sub pConnectDB()
        dbCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dbGem.accdb"
        dbCon.Open()
        If dbCon.State = ConnectionState.Open Then
            'MsgBox("Open")'
        End If
    End Sub

    Public Sub pDisconnectDB()
        If dbCon.State = ConnectionState.Open Then
            dbCon.Close()
            'MsgBox("Closed")'
        End If
    End Sub
End Module
