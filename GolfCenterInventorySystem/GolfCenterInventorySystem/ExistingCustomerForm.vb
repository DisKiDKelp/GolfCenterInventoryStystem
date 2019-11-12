Imports System.Text.RegularExpressions
Public Class ExistingCustomerForm
    Private DB As New DBAccess
    Private Sub ExistingCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(CustomerForm.custIDTextBox.Text) Then
            MessageBox.Show("No customer selected")
            Me.Close()
        Else
            DB.AddParam("@custID", CustomerForm.custIDTextBox.Text)
            DB.ExecuteQuery("Select * FROM customer WHERE customer_id = ?;")

            If DB.DBException <> String.Empty Then
                MessageBox.Show(DB.DBException)
                Exit Sub
            End If

            lock_edit_form()

            customerIDTextBox.Text = DB.DBDataTable(0)!customer_id
            storeTextBox.Text = DB.DBDataTable(0)!store_id
            fnTextBox.Text = DB.DBDataTable(0)!first_name
            lnTextBox.Text = DB.DBDataTable(0)!last_name
            emailTextBox.Text = DB.DBDataTable(0)!email
            addressTextBox.Text = DB.DBDataTable(0)!address_id
            activeCheckBox.Checked = DB.DBDataTable(0)!active
            creationDateTimePicker.Value = DB.DBDataTable(0)!create_date
            lastUpdateDateTimePicker.Value = DB.DBDataTable(0)!last_update
        End If
    End Sub

    Private Sub EnableFieldsForEdit(ToEdit As Boolean)
        storeTextBox.Enabled = Not ToEdit
        fnTextBox.Enabled = Not ToEdit
        lnTextBox.Enabled = Not ToEdit
        addressTextBox.Enabled = Not ToEdit
        emailTextBox.Enabled = Not ToEdit
        activeCheckBox.Enabled = Not ToEdit

        If ToEdit = False Then
            EditButton.Text = "&Save"
        Else
            EditButton.Text = "&Edit"
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If EditButton.Text = "&Edit" Then
            EnableFieldsForEdit(False)
        Else
            UpdateCustomer()
            EnableFieldsForEdit(True)
        End If
    End Sub

    Private Sub UpdateCustomer()
        If ValidCustomerData() = False Then
            Exit Sub
        End If


        DB.AddParam("@storeID", storeTextBox.Text)
        DB.AddParam("@first_name", fnTextBox.Text)
        DB.AddParam("@last_name", lnTextBox.Text)
        DB.AddParam("@email", emailTextBox.Text)
        DB.AddParam("@address_ID", addressTextBox.Text)
        DB.AddParam("@active", activeCheckBox.Checked)
        DB.AddParam("@id", customerIDTextBox.Text)

        DB.ExecuteQuery("Update customer SET store_id = ?, first_name = ?, last_name = ?, email = ?, address_id = ?, active = ? WHERE customer_id = ?;")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If


        MessageBox.Show("The customer #" & customerIDTextBox.Text & " record had been updated successfully.")
    End Sub

    Private Function ValidCustomerData() As Boolean
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

        Return True
    End Function

    Private Function lock_edit_form()
        EditButton.Text = "&Edit"
        storeTextBox.Enabled = False
        fnTextBox.Enabled = False
        lnTextBox.Enabled = False
        addressTextBox.Enabled = False
        emailTextBox.Enabled = False
        activeCheckBox.Enabled = False
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lock_edit_form()
        Me.Close()
    End Sub
End Class