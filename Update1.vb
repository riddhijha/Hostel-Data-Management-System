Imports System.Data
Imports System.Data.SqlClient

Public Class Update1
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim getst As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\R N JHA\Desktop\HostelManagementSystem\HostelManagementSystem\HostelManagementSystem\hostel.mdf;Integrated Security=True")
        com = New SqlCommand(" update student set name='" + TextBox1.Text + "',mobile='" + TextBox2.Text + "',f_mobile='" + TextBox3.Text + "',dob='" + TextBox4.Text + "',addr='" + TextBox5.Text + "',edu='" + TextBox6.Text + "',state='" + ComboBox1.Text + "',r_no='" + TextBox7.Text + "',fees='" + TextBox8.Text + "',m_fees='" + TextBox9.Text + "',r_fees='" + TextBox10.Text + "',date='" + TextBox11.Text + "'", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("Student Record updated Successfully..")
        Hide()
        con.Close()
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;

AttachDbFilename=C:\Users\R N JHA\Desktop\HostelManagementSystem\HostelManagementSystem\HostelManagementSystem\hostel.mdf;Integrated Security=True")
        con.Open()

        Try
            getst = "select name,mobile,f_mobile,dob,addr,edu,state,r_no,fees,m_fees,r_fees,date from student where id='" & TextBox12.Text & "'"
            com = New SqlCommand(getst, con)
            dr = com.ExecuteReader()
            If dr.Read() Then


                TextBox1.Text = dr.GetValue(0).ToString()
                TextBox2.Text = dr.GetValue(1).ToString()
                TextBox3.Text = dr.GetValue(2).ToString()
                TextBox4.Text = dr.GetValue(3).ToString()
                TextBox5.Text = dr.GetValue(4).ToString()
                TextBox6.Text = dr.GetValue(5).ToString()
                ComboBox1.Text = dr.GetValue(6).ToString()
                TextBox7.Text = dr.GetValue(7).ToString()
                TextBox8.Text = dr.GetValue(8).ToString()
                TextBox9.Text = dr.GetValue(9).ToString()
                TextBox10.Text = dr.GetValue(10).ToString()
                TextBox11.Text = dr.GetValue(11).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Update1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class