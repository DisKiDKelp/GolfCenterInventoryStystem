<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExistingCustomerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.creationDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.activeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lnTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fnTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.storeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.customerIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lastUpdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(225, 294)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(99, 294)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 30
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Creation Date:"
        '
        'creationDateTimePicker
        '
        Me.creationDateTimePicker.Location = New System.Drawing.Point(132, 211)
        Me.creationDateTimePicker.Name = "creationDateTimePicker"
        Me.creationDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.creationDateTimePicker.TabIndex = 28
        '
        'activeCheckBox
        '
        Me.activeCheckBox.AutoSize = True
        Me.activeCheckBox.Location = New System.Drawing.Point(132, 191)
        Me.activeCheckBox.Name = "activeCheckBox"
        Me.activeCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.activeCheckBox.TabIndex = 27
        Me.activeCheckBox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Active:"
        '
        'addressTextBox
        '
        Me.addressTextBox.Enabled = False
        Me.addressTextBox.Location = New System.Drawing.Point(132, 163)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.addressTextBox.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Address ID:"
        '
        'emailTextBox
        '
        Me.emailTextBox.Enabled = False
        Me.emailTextBox.Location = New System.Drawing.Point(132, 137)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(212, 20)
        Me.emailTextBox.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Email:"
        '
        'lnTextBox
        '
        Me.lnTextBox.Enabled = False
        Me.lnTextBox.Location = New System.Drawing.Point(132, 111)
        Me.lnTextBox.Name = "lnTextBox"
        Me.lnTextBox.Size = New System.Drawing.Size(200, 20)
        Me.lnTextBox.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Last Name:"
        '
        'fnTextBox
        '
        Me.fnTextBox.Enabled = False
        Me.fnTextBox.Location = New System.Drawing.Point(132, 85)
        Me.fnTextBox.Name = "fnTextBox"
        Me.fnTextBox.Size = New System.Drawing.Size(200, 20)
        Me.fnTextBox.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "First Name:"
        '
        'storeTextBox
        '
        Me.storeTextBox.Enabled = False
        Me.storeTextBox.Location = New System.Drawing.Point(132, 59)
        Me.storeTextBox.MaxLength = 3
        Me.storeTextBox.Name = "storeTextBox"
        Me.storeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.storeTextBox.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Store ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Customer ID:"
        '
        'customerIDTextBox
        '
        Me.customerIDTextBox.Enabled = False
        Me.customerIDTextBox.Location = New System.Drawing.Point(132, 29)
        Me.customerIDTextBox.MaxLength = 3
        Me.customerIDTextBox.Name = "customerIDTextBox"
        Me.customerIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.customerIDTextBox.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(58, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Last Update:"
        '
        'lastUpdateDateTimePicker
        '
        Me.lastUpdateDateTimePicker.Location = New System.Drawing.Point(132, 237)
        Me.lastUpdateDateTimePicker.Name = "lastUpdateDateTimePicker"
        Me.lastUpdateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.lastUpdateDateTimePicker.TabIndex = 34
        '
        'ExistingCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 356)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lastUpdateDateTimePicker)
        Me.Controls.Add(Me.customerIDTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.creationDateTimePicker)
        Me.Controls.Add(Me.activeCheckBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lnTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fnTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.storeTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ExistingCustomerForm"
        Me.Text = "UpdateCustomer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents creationDateTimePicker As DateTimePicker
    Friend WithEvents activeCheckBox As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lnTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents fnTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents storeTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents customerIDTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lastUpdateDateTimePicker As DateTimePicker
End Class
