Imports System.Data.SqlClient
Public Class MySqlConnecting
    Dim cn As New SqlConnection With {.ConnectionString = "Data Source=DESKTOP-2MM79RF\SQL_EXPRESS2014;Initial Catalog=LearningVB;Integrated Security=True"}
    Dim da As SqlDataAdapter
    Dim cm As SqlCommand
    Dim dt As New DataTable
    Dim sqlStr As String
    Private Sub MySqlConnecting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cn.Open()
        sqlStr = "select * from Sales"
        da = New SqlDataAdapter(sqlStr, cn)
        da.Fill(dt)
        With cbopType
            .ValueMember = "PTID"
            .DisplayMember = "ProductType"
            .DataSource = dt
        End With
        cn.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        cn.Open()
        sqlStr = "insert into tbproduct values(@PID,@PTID,@PName,@Price,@QTY)"
        cm = New SqlCommand()
        With cm
            .Connection = cn
            .CommandText = sqlStr
            .Parameters.Add("@PID", SqlDbType.SmallInt).Value = tbpId
            .Parameters.Add("@PTID", SqlDbType.SmallInt).Value = cbopType
            .Parameters.Add("@PName", SqlDbType.NVarChar).Value = tbpName
            .Parameters.Add("@Price", SqlDbType.Int).Value = tbpPrice
            .Parameters.Add("@QTY", SqlDbType.SmallInt).Value = tbpQty
            .ExecuteNonQuery()
        End With
        cn.Close()
    End Sub
End Class