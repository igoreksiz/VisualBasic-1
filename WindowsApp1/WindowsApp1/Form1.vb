<<<<<<< HEAD
﻿Public Class RobotTrades
    Private Sub MejnüToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MejnüToolStripMenuItem.Click

    End Sub

    Private Sub DollárToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DollárToolStripMenuItem.Click

=======
﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
<<<<<<< HEAD
<<<<<<< HEAD

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim path As String = "D:\\8I\\Code\\VisualBasic\\ExactSpreadsFull.xlsx"

            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [ExactSpreadsFull$]", MyConnection)

            dataSet = New System.Data.DataSet
            MyCommand.Fill(dataSet)
            DataGridView1.DataSource = dataSet.Tables(0)

            MyConnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
>>>>>>> dba7ad4fdcad5a6b7d68f96fa07cb714e10fe820
=======

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim path As String = "D:\\8I\\Code\\VisualBasic\\ExactSpreadsFull.xlsx"

            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [ExactSpreadsFull$]", MyConnection)

            dataSet = New System.Data.DataSet
            MyCommand.Fill(dataSet)
            DataGridView1.DataSource = dataSet.Tables(0)

            MyConnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
>>>>>>> dba7ad4fdcad5a6b7d68f96fa07cb714e10fe820
=======

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim path As String = "D:\\8I\\Code\\VisualBasic\\ExactSpreadsFull.xlsx"

            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [ExactSpreadsFull$]", MyConnection)

            dataSet = New System.Data.DataSet
            MyCommand.Fill(dataSet)
            DataGridView1.DataSource = dataSet.Tables(0)

            MyConnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
>>>>>>> dba7ad4fdcad5a6b7d68f96fa07cb714e10fe820
    End Sub
End Class
