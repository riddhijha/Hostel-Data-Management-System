Imports System.Data
Imports System.Data.SqlClient

Public Class Delete
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim student As Object
    Dim employee As Object
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = "0" Then
            Try
                con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;
                        AttachDbFilename=C:\Users\R N JHA\Desktop\HostelManagementSystem\HostelManagementSystem\HostelManagementSystem\hostel.mdf;Integrated Security=True")
                con.Open()
                str = "DELETE FROM student WHERE id = '" & TextBox7.Text & "'"

                com = New SqlCommand(str, con)
                com.ExecuteNonQuery()
                con.Close()
                MsgBox(" Student Record Delete Successfully")
                Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\HostelManagementSystem\HostelManagementSystem\hostel.mdf;Integrated Security=True")
                    str = "SELECT * FROM student"
                    com = New SqlCommand(str, con)
                    da = New SqlDataAdapter(com)
                    dt = New DataTable()
                    dv = New DataView()
                    da.Fill(dt)

                    DataGridView1.DataSource = New BindingSource(dt, student)
                    Hide()
                    TextBox7.Text = ""
                    ComboBox1.Text = "--Select--"
                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        ElseIf ComboBox1.SelectedIndex = "1" Then
            Try
                con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\HostelManagementSystem\HostelManagementSystem\hostel.mdf;Integrated Security=True")
                con.Open()
                str = "DELETE FROM emp WHERE id = '" & TextBox7.Text & "'"

                com = New SqlCommand(str, con)
                com.ExecuteNonQuery()
                con.Close()
                MsgBox(" Employee Record Delete Successfully")
                Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\HostelManagementSystem\HostelManagementSystem\hostel.mdf;Integrated Security=True")
                    str = "SELECT * FROM emp"
                    com = New SqlCommand(str, con)
                    da = New SqlDataAdapter(com)
                    dt = New DataTable()
                    dv = New DataView()
                    da.Fill(dt)

                    DataGridView1.DataSource = New BindingSource(dt, employee)
                    Hide()
                    TextBox7.Text = ""
                    ComboBox1.Text = "--Select--"
                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = "0" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\R N JHA\Desktop\HostelManagementSystem\HostelManagementSystem\HostelManagementSystem\hostel.mdf;Integrated Security=True")

                str = "SELECT * FROM student "
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, student)
            End Using
        ElseIf ComboBox1.SelectedIndex = "1" Then
            Using con = New SqlConnection("Data Source=C:\Users\R N JHA\Desktop\HostelManagementSystem\HostelManagementSystem\HostelManagementSystem\hostel.mdf;Integrated Security=True")


                str = "SELECT * FROM emp"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, employee)
            End Using
        End If
    End Sub


End Class