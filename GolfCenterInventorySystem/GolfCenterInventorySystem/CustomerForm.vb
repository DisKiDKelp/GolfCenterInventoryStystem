Public Class CustomerForm
    Private DB As New DBAccess

    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBDataGridView.ReadOnly = True

        DB.ExecuteQuery("Select customer_id, first_name, last_name, email, active, create_date, address, district, postal_code, phone FROM customer c JOIN address a on a.address_id = c.address_id;")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
        End If

        DBDataGridView.DataSource = DB.DBDataTable

    End Sub
    Private Sub DBDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridView.CellClick

        If e.ColumnIndex > 0 And e.RowIndex > 0 Then
            custIDTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(0).Value
            custNameTextBox.Text = (DBDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString + " " + DBDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString)
            DeleteCustomerToolStripMenuItem.Enabled = True
            UpdateCustomerToolStripMenuItem.Enabled = True
        End If

    End Sub
    Private Sub lnTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles lnTextBox.KeyUp
        SearchCustomer(lnTextBox.Text, postalTextBox.Text)

    End Sub

    Private Sub postalTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles postalTextBox.KeyUp
        SearchCustomer(lnTextBox.Text, postalTextBox.Text)

    End Sub

    Private Sub SearchCustomer(last_name As String, postal_code As String)
        DB.AddParam("@last_name", last_name & "%")
        DB.AddParam("@postal_code", postal_code & "%")

        DB.ExecuteQuery("Select customer_id, first_name, last_name, email, active, create_date, address, district, postal_code, phone FROM customer c JOIN address a on a.address_id = c.address_id WHERE last_name LIKE ? and postal_code LIKE ?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        DBDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
        NewCustomerForm.ShowDialog()
    End Sub

    Private Sub DeleteCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCustomerToolStripMenuItem.Click
        Dim answer = MsgBox("Are you sure you want to delete this customer?", vbYesNo)
        If custIDTextBox.Text <> String.Empty Then
            If answer = vbYes Then
                DB.AddParam("@custID", custIDTextBox.Text)
                DB.ExecuteQuery("DELETE from customer WHERE customer_id = ?;")

                If DB.DBException <> String.Empty Then
                    MessageBox.Show(DB.DBException)
                    Exit Sub
                End If

                MessageBox.Show("Customer successfully deleted")
                custIDTextBox.Text = String.Empty
                custNameTextBox.Text = String.Empty
            End If
            DeleteCustomerToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub UpdateCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCustomerToolStripMenuItem.Click
        ExistingCustomerForm.ShowDialog()

    End Sub


End Class