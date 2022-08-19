Imports System.Data.OleDb
Public Class frmgem
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader


    Private Sub frmgem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pConnectDB()
    End Sub

    Private Sub frmgem_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call pDisconnectDB()
    End Sub

    Private Sub pLoadcboLoc()
        cmd = New OleDbCommand("select usrRecLoc from tbusrRec", dbCon)
        dr = cmd.ExecuteReader()
        dr.Read()
        MessageBox.Show(dr.Item("usrRecLoc"))
    End Sub

End Class