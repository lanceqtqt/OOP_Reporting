Imports MySql.Data.MySqlClient

Public Class Form1
    Private conn As New MySqlConnection("Server=localhost;Database=query_db;User ID=root;Password=;")
    Dim dr As MySqlDataReader
    Dim i As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Public Sub LoadData()
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM payroll", conn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                DataGridView1.Rows.Add(dr("employee_id"), dr("lastname"), dr("firstname"), dr("hoursWorked"), dr("hourlyRate"))
            End While

            If DataGridView1.Rows.Count = 0 Then
                MessageBox.Show("No records found.")
            End If

            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Save()
    End Sub

    Public Sub Save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO payroll (employee_id, lastname, firstname, hoursWorked, hourlyRate) VALUES (@EmployeeId, @LastName, @FirstName, @HoursWorked, @HourlyRate)", conn)
            cmd.Parameters.AddWithValue("@EmployeeId", txt_employee_id.Text)
            cmd.Parameters.AddWithValue("@LastName", txt_lastname.Text)
            cmd.Parameters.AddWithValue("@FirstName", txt_firstname.Text)
            cmd.Parameters.AddWithValue("@HoursWorked", Convert.ToDecimal(txt_hoursworked.Text))
            cmd.Parameters.AddWithValue("@HourlyRate", Convert.ToDecimal(txt_hourlyrate.Text))

            i = cmd.ExecuteNonQuery()
            MessageBox.Show(If(i > 0, "Record Save Success!", "Record Save Failed!"))

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        Clear()
        LoadData()
    End Sub

    Public Sub Edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE payroll SET employee_id=@EmployeeId, lastname=@LastName, firstname=@FirstName, hoursWorked=@HoursWorked, hourlyRate=@HourlyRate WHERE employee_id = @EmployeeId", conn)

            cmd.Parameters.AddWithValue("@EmployeeId", txt_employee_id.Text)
            cmd.Parameters.AddWithValue("@LastName", txt_lastname.Text)
            cmd.Parameters.AddWithValue("@FirstName", txt_firstname.Text)
            cmd.Parameters.AddWithValue("@HoursWorked", Convert.ToDecimal(txt_hoursworked.Text))
            cmd.Parameters.AddWithValue("@HourlyRate", Convert.ToDecimal(txt_hourlyrate.Text))

            i = cmd.ExecuteNonQuery()
            MessageBox.Show(If(i > 0, "Record Update Success!", "Record Update Failed!"))

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        Clear()
        LoadData()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Delete()
    End Sub

    Public Sub Delete()
        If MsgBox("Are you sure to delete this record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM payroll WHERE employee_id = @EmployeeId", conn)
                cmd.Parameters.AddWithValue("@EmployeeId", txt_employee_id.Text)

                i = cmd.ExecuteNonQuery()
                MessageBox.Show(If(i > 0, "Record Delete Success!", "Record Delete Failed!"))

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try

            Clear()
            LoadData()
        End If
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        Clear()
    End Sub

    Sub Clear()
        txt_employee_id.Clear()
        txt_lastname.Clear()
        txt_firstname.Clear()
        txt_hoursworked.Clear()
        txt_hourlyrate.Clear()

        save_btn.Enabled = True
        txt_employee_id.ReadOnly = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txt_employee_id.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_lastname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_firstname.Text = DataGridView1.CurrentRow.Cells(2).Value
        txt_hoursworked.Text = DataGridView1.CurrentRow.Cells(3).Value
        txt_hourlyrate.Text = DataGridView1.CurrentRow.Cells(4).Value

        txt_employee_id.ReadOnly = True
        save_btn.Enabled = False
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Edit()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM payroll WHERE employee_id like '%" & txt_search.Text & "%' OR lastname like '%" & txt_search.Text & "%' OR firstname like '%" & txt_search.Text & "%' or hoursWorked like '%" & txt_search.Text & "%' or hourlyRate like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                DataGridView1.Rows.Add(dr("employee_id"), dr("lastname"), dr("firstname"), dr("hoursWorked"), dr("hourlyRate"))
            End While

            If DataGridView1.Rows.Count = 0 Then
                MessageBox.Show("No records found.")
            End If

            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
