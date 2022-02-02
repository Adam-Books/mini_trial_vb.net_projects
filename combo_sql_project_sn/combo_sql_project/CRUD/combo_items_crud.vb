Public Class combo_items_crud
    Private Sub combo_items_crud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_loader()
        '-------------
        Me.ComboitemsBindingSource.Sort = "id ASC"
    End Sub
    Sub data_loader()
        Try
            Me.Combo_itemsTableAdapter.Fill(Me.Combo_ds.combo_items)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As Integer
        '--------------------
        Dim gi As Int32
        Int32.TryParse(Me.Group_idLabel1.Text, gi)
        r = Me.Combo_itemsTableAdapter.my_InsertQuery(item_title_TextBox1.Text, gi)
        '--------------------
        If r > 0 Then 'inserted
            MessageBox.Show("Done! Count: " + r.ToString)
            data_loader()
            Me.ComboitemsBindingSource.MoveLast()
        Else
            MessageBox.Show("Failed!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'My.Forms.combo_items_crud.Close()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim r As Integer
        Dim id As Long
        Int64.TryParse(Me.IdLabel1.Text, id)
        Dim dr As DialogResult

        dr = MessageBox.Show("Do you want to delete this record?", "Alert!", MessageBoxButtons.OKCancel)
        If dr = DialogResult.OK Then
            'r = Me.Combo_itemsTableAdapter.Delete(id)
            r = Me.Combo_itemsTableAdapter.my_DeleteQuery(id)
            If r > 0 Then 'deleted
                MessageBox.Show("Done! Count: " + r.ToString)
                data_loader()
            Else
                MessageBox.Show("Failed!")
            End If
        Else
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim new_item As String
        new_item = InputBox("Please enter a new value:", "Edit your record", Me.IdLabel1.Text)
        Dim r, gi As Integer
        Dim id As Long
        Int64.TryParse(Me.IdLabel1.Text, id)
        Int32.TryParse(Me.Group_idLabel1.Text, gi)
        Dim dr As DialogResult

        dr = MessageBox.Show("Do you want to update this record?", "Alert!", MessageBoxButtons.OKCancel)

        If dr = DialogResult.OK Then
            'r = Me.Combo_itemsTableAdapter.Delete(id)

            '----------------
            Dim mgi As Int32
            Int32.TryParse(Me.Group_idLabel1.Text, mgi)
            r = Me.Combo_itemsTableAdapter.my_UpdateQuery(new_item, mgi, id)
            '----------------

            If r > 0 Then 'Updated
                MessageBox.Show("Done! Count: " + r.ToString)
                data_loader()
            Else
                MessageBox.Show("Failed!")
            End If
        Else
        End If
    End Sub

End Class