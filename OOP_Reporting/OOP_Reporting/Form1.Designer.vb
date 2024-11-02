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
        add_btn = New Button()
        DataGridView1 = New DataGridView()
        edit_btn = New Button()
        delete_btn = New Button()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' add_btn
        ' 
        add_btn.Location = New Point(47, 35)
        add_btn.Name = "add_btn"
        add_btn.Size = New Size(93, 30)
        add_btn.TabIndex = 0
        add_btn.Text = "Add Row"
        add_btn.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(188, 23)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(343, 245)
        DataGridView1.TabIndex = 1
        ' 
        ' edit_btn
        ' 
        edit_btn.Location = New Point(47, 93)
        edit_btn.Name = "edit_btn"
        edit_btn.Size = New Size(93, 30)
        edit_btn.TabIndex = 2
        edit_btn.Text = "Edit Row"
        edit_btn.UseVisualStyleBackColor = True
        ' 
        ' delete_btn
        ' 
        delete_btn.Location = New Point(47, 150)
        delete_btn.Name = "delete_btn"
        delete_btn.Size = New Size(93, 30)
        delete_btn.TabIndex = 3
        delete_btn.Text = "Delete Row"
        delete_btn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(47, 207)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 30)
        Button1.TabIndex = 4
        Button1.Text = "Cancel Delete"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(588, 333)
        Controls.Add(Button1)
        Controls.Add(delete_btn)
        Controls.Add(edit_btn)
        Controls.Add(DataGridView1)
        Controls.Add(add_btn)
        MinimumSize = New Size(604, 372)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents add_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents edit_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents Button1 As Button

End Class
