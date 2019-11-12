Imports System.Text.RegularExpressions
Public Class NewCustomerForm
    Private DB As New DBAccess
    Private Sub NewCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clear_input()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddCustomer()

    End Sub
    Private Function ValidNewCustomerData() As Boolean
        ' Validate StoreID input
        If String.IsNullOrWhiteSpace(storeTextBox.Text) Then
            MessageBox.Show("Store ID can not be empty")
            storeTextBox.SelectAll()
            storeTextBox.Focus()
            Return False
        End If

        ' Validate 
        Dim StoreIDInteger As Integer
        If Integer.TryParse(storeTextBox.Text, StoreIDInteger) = False Then
            MessageBox.Show("Store ID must be Integer")
            storeTextBox.SelectAll()
            storeTextBox.Focus()
            Return False
        End If

        If (StoreIDInteger >= 1 Or StoreIDInteger <= 2) = False Then
            MessageBox.Show("Store ID must be")
            storeTextBox.SelectAll()
            storeTextBox.Focus()
            Return False
        End If

        Dim rxfirstname As New Regex("[a-zA-Z]+")
        If Not rxfirstname.IsMatch(fnTextBox.Text) Then
            MessageBox.Show("First Name must be an alphbetic number")
            fnTextBox.SelectAll()
            fnTextBox.Focus()
            Return False
        End If

        Dim rxemail As New Regex("[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]")
        If emailTextBox.Text <> String.Empty Then
            If Not rxemail.IsMatch(emailTextBox.Text) Then
                MessageBox.Show("Email must follow the right format, such as abc@xyz.net")
                emailTextBox.SelectAll()
                emailTextBox.Focus()
                Return False
            End If
        End If
    End Function
    Private Sub AddCustomer()
        If ValidNewCustomerData() = False Then
            Exit Sub
        End If
        DB.AddParam("@storeID", storeTextBox.Text)
        DB.AddParam("@first_name", fnTextBox.Text)
        DB.AddParam("@last_name", lnTextBox.Text)
        DB.AddParam("@email", emailTextBox.Text)
        DB.AddParam("@address_ID", addressTextBox.Text)
        DB.AddParam("@active", activeCheckBox.Checked)
        DB.AddParam("@creation_date", creationDateTimePicker.Value)

        DB.ExecuteQuery("Insert INTO Customer(store_id, first_name, last_name, email, address_id, active, create_date) Values (?, ?, ?, ?, ?, ?, ?);")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        MessageBox.Show("New Customer Successfully added")
        Clear_input()

    End Sub

    Private Sub Clear_input()
        storeTextBox.Clear()
        fnTextBox.Clear()
        lnTextBox.Clear()
        emailTextBox.Clear()
        addressTextBox.Clear()
        storeTextBox.Clear()
    End Sub
End Class