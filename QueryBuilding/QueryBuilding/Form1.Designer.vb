<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        save_btn = New Button()
        update_btn = New Button()
        delete_btn = New Button()
        clear_btn = New Button()
        txt_employee_id = New TextBox()
        txt_lastname = New TextBox()
        txt_firstname = New TextBox()
        txt_hourlyrate = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txt_hoursworked = New TextBox()
        txt_search = New TextBox()
        Label6 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(205, 106)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(647, 250)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Employee Id"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Lastname"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Firstname"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "HoursWorked"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column5.HeaderText = "HourlyRate"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' save_btn
        ' 
        save_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        save_btn.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        save_btn.Cursor = Cursors.Hand
        save_btn.Location = New Point(13, 276)
        save_btn.Margin = New Padding(4, 3, 4, 3)
        save_btn.Name = "save_btn"
        save_btn.Size = New Size(81, 38)
        save_btn.TabIndex = 1
        save_btn.Text = "Save"
        save_btn.UseVisualStyleBackColor = False
        ' 
        ' update_btn
        ' 
        update_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        update_btn.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        update_btn.Cursor = Cursors.Hand
        update_btn.Location = New Point(116, 276)
        update_btn.Margin = New Padding(4, 3, 4, 3)
        update_btn.Name = "update_btn"
        update_btn.Size = New Size(81, 38)
        update_btn.TabIndex = 2
        update_btn.Text = "Update"
        update_btn.UseVisualStyleBackColor = False
        ' 
        ' delete_btn
        ' 
        delete_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        delete_btn.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        delete_btn.Cursor = Cursors.Hand
        delete_btn.Location = New Point(13, 320)
        delete_btn.Margin = New Padding(4, 3, 4, 3)
        delete_btn.Name = "delete_btn"
        delete_btn.Size = New Size(81, 38)
        delete_btn.TabIndex = 5
        delete_btn.Text = "Delete"
        delete_btn.UseVisualStyleBackColor = False
        ' 
        ' clear_btn
        ' 
        clear_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        clear_btn.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        clear_btn.Cursor = Cursors.Hand
        clear_btn.Location = New Point(116, 320)
        clear_btn.Margin = New Padding(4, 3, 4, 3)
        clear_btn.Name = "clear_btn"
        clear_btn.Size = New Size(81, 38)
        clear_btn.TabIndex = 6
        clear_btn.Text = "Clear"
        clear_btn.UseVisualStyleBackColor = False
        ' 
        ' txt_employee_id
        ' 
        txt_employee_id.Location = New Point(13, 52)
        txt_employee_id.Name = "txt_employee_id"
        txt_employee_id.PlaceholderText = "Enter ID"
        txt_employee_id.Size = New Size(184, 22)
        txt_employee_id.TabIndex = 7
        ' 
        ' txt_lastname
        ' 
        txt_lastname.Location = New Point(14, 106)
        txt_lastname.Name = "txt_lastname"
        txt_lastname.PlaceholderText = "Enter Lastname"
        txt_lastname.Size = New Size(184, 22)
        txt_lastname.TabIndex = 8
        ' 
        ' txt_firstname
        ' 
        txt_firstname.Location = New Point(12, 159)
        txt_firstname.Name = "txt_firstname"
        txt_firstname.PlaceholderText = "Enter Firstname"
        txt_firstname.Size = New Size(184, 22)
        txt_firstname.TabIndex = 9
        ' 
        ' txt_hourlyrate
        ' 
        txt_hourlyrate.Location = New Point(12, 248)
        txt_hourlyrate.Name = "txt_hourlyrate"
        txt_hourlyrate.PlaceholderText = "Enter Hourly Rate"
        txt_hourlyrate.Size = New Size(184, 22)
        txt_hourlyrate.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 14)
        Label1.TabIndex = 11
        Label1.Text = "Lastname"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(14, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 14)
        Label2.TabIndex = 12
        Label2.Text = "Firstname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(14, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 14)
        Label3.TabIndex = 13
        Label3.Text = "HoursWorked"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(13, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 14)
        Label4.TabIndex = 14
        Label4.Text = "HourlyRate"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(13, 35)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 14)
        Label5.TabIndex = 15
        Label5.Text = "Employee Id"
        ' 
        ' txt_hoursworked
        ' 
        txt_hoursworked.Location = New Point(12, 206)
        txt_hoursworked.Name = "txt_hoursworked"
        txt_hoursworked.PlaceholderText = "Enter Hours Worked"
        txt_hoursworked.Size = New Size(184, 22)
        txt_hoursworked.TabIndex = 16
        ' 
        ' txt_search
        ' 
        txt_search.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txt_search.Location = New Point(205, 52)
        txt_search.Name = "txt_search"
        txt_search.PlaceholderText = "Search Here...."
        txt_search.Size = New Size(284, 22)
        txt_search.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(205, 35)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 14)
        Label6.TabIndex = 18
        Label6.Text = "Search"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(879, 394)
        Controls.Add(Label6)
        Controls.Add(txt_search)
        Controls.Add(txt_hoursworked)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_hourlyrate)
        Controls.Add(txt_firstname)
        Controls.Add(txt_lastname)
        Controls.Add(txt_employee_id)
        Controls.Add(clear_btn)
        Controls.Add(delete_btn)
        Controls.Add(update_btn)
        Controls.Add(save_btn)
        Controls.Add(DataGridView1)
        Font = New Font("Broadway", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        MinimumSize = New Size(812, 433)
        Name = "Form1"
        Text = "Simple System"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents save_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents clear_btn As Button
    Friend WithEvents txt_employee_id As TextBox
    Friend WithEvents txt_lastname As TextBox
    Friend WithEvents txt_firstname As TextBox
    Friend WithEvents txt_hourlyrate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_hoursworked As TextBox
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn

End Class
