<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCustomerForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.storeTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fnTextBox = New System.Windows.Forms.TextBox()
        Me.lnTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.activeCheckBox = New System.Windows.Forms.CheckBox()
        Me.creationDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Store ID:"
        '
        'storeTextBox
        '
        Me.storeTextBox.Location = New System.Drawing.Point(93, 28)
        Me.storeTextBox.MaxLength = 3
        Me.storeTextBox.Name = "storeTextBox"
        Me.storeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.storeTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name:"
        '
        'fnTextBox
        '
        Me.fnTextBox.Location = New System.Drawing.Point(93, 54)
        Me.fnTextBox.Name = "fnTextBox"
        Me.fnTextBox.Size = New System.Drawing.Size(200, 20)
        Me.fnTextBox.TabIndex = 3
        '
        'lnTextBox
        '
        Me.lnTextBox.Location = New System.Drawing.Point(93, 80)
        Me.lnTextBox.Name = "lnTextBox"
        Me.lnTextBox.Size = New System.Drawing.Size(200, 20)
        Me.lnTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name:"
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(93, 106)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(212, 20)
        Me.emailTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Email:"
        '
        'addressTextBox
        '
        Me.addressTextBox.Location = New System.Drawing.Point(93, 132)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.addressTextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Address ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Active:"
        '
        'activeCheckBox
        '
        Me.activeCheckBox.AutoSize = True
        Me.activeCheckBox.Location = New System.Drawing.Point(93, 160)
        Me.activeCheckBox.Name = "activeCheckBox"
        Me.activeCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.activeCheckBox.TabIndex = 11
        Me.activeCheckBox.UseVisualStyleBackColor = True
        '
        'creationDateTimePicker
        '
        Me.creationDateTimePicker.Location = New System.Drawing.Point(93, 180)
        Me.creationDateTimePicker.Name = "creationDateTimePicker"
        Me.creationDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.creationDateTimePicker.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Creation Date:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(66, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(192, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NewCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 316)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewCustomerForm"
        Me.Text = "NewCustomerForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents storeTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fnTextBox As TextBox
    Friend WithEvents lnTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents activeCheckBox As CheckBox
    Friend WithEvents creationDateTimePicker As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
