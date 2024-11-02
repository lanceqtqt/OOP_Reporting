Imports System.Data

Public Class Form1
    ' Define a DataSet to hold your tables
    Dim dataBooks As New DataSet()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a New DataTable called "Titles"
        Dim titlesTable As New DataTable("Titles")

        ' Add columns to the "Titles" DataTable
        titlesTable.Columns.Add("id", GetType(Integer))
        titlesTable.Columns.Add("title", GetType(String))
        titlesTable.Columns.Add("type", GetType(String))

        ' Add the "Titles" table to the DataSet
        dataBooks.Tables.Add(titlesTable)

        ' Bind the DataGridView to the Titles table
        DataGridView1.DataSource = dataBooks.Tables("Titles")
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        ' Create a new DataRow for the "Titles" table
        Dim newDataRow = dataBooks.Tables("Titles").NewRow()

        ' Set column values
        newDataRow("id") = dataBooks.Tables("Titles").Rows.Count + 1 ' Automatically increment ID
        newDataRow("title") = "New York"
        newDataRow("type") = "business"

        ' Add the new row to the "Titles" table
        dataBooks.Tables("Titles").Rows.Add(newDataRow)

        ' Optional: Refresh the DataGridView to display the new data immediately
        DataGridView1.Refresh()
    End Sub

    Private Sub edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        ' Check if there are rows to edit
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the index of the selected row
            Dim selectedIndex As Integer = DataGridView1.SelectedRows(0).Index

            ' Check if the selected index is within the bounds of the DataTable
            If selectedIndex >= 0 AndAlso selectedIndex < dataBooks.Tables("Titles").Rows.Count Then
                ' Get the selected row of the "Titles" table
                Dim editDataRow As DataRow = dataBooks.Tables("Titles").Rows(selectedIndex)

                ' Begin editing the row
                editDataRow.BeginEdit()

                ' Update the "Title" column with the new value
                editDataRow("type") = 23

                ' End the edit
                editDataRow.EndEdit()

                ' Refresh the DataGridView to reflect the changes
                DataGridView1.Refresh()
            Else
                MessageBox.Show("No rows available to edit.")
            End If
        Else
            MessageBox.Show("Please select a row to edit.")
        End If
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedIndex = DataGridView1.SelectedRows(0).Index
            If selectedIndex >= 0 AndAlso selectedIndex < dataBooks.Tables("Titles").Rows.Count Then
                Dim delRow = dataBooks.Tables("Titles").Rows(selectedIndex)

                ' Mark the row for deletion
                delRow.Delete()

                ' Refresh the DataGridView to reflect the deletion
                DataGridView1.Refresh()
            Else
                MessageBox.Show("No rows available to delete.")
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Discard changes made to the DataTable
        If dataBooks.Tables("Titles").GetChanges() IsNot Nothing Then
            MessageBox.Show("Changes have been canceled.")

            dataBooks.Tables("Titles").RejectChanges() ' Revert all changes made
            DataGridView1.Refresh() ' Refresh the DataGridView to show the original data
        Else
            MessageBox.Show("There are no changes to cancel.")
        End If
    End Sub
End Class
