Public Class adv_combo_frm
    Private Sub adv_combo_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Combo_ds.combo_items' table. You can move, or remove it, as needed.
        'Me.Combo_itemsTableAdapter.Fill(Me.Combo_ds.combo_items)

        Me.Combo_itemsTableAdapter.FillBy_sender_gender_priority(Me.Combo_ds.combo_items)

        Me.Sender_BindingSource.Filter = "group_id = 1"
        Me.Sender_BindingSource.Sort = "item_title ASC"

        Me.Priority_BindingSource1.Filter = "group_id = 20"
        Me.Priority_BindingSource1.Sort = ""

        Me.Gender_BindingSource1.Filter = "group_id = 100"
        Me.Gender_BindingSource1.Sort = ""

        'TODO: This line of code loads data into the 'Combo_ds.customers_info' table. You can move, or remove it, as needed.
        Me.Customers_infoTableAdapter.Fill(Me.Combo_ds.customers_info)

    End Sub

    Private Sub add_Button1_Click(sender As Object, e As EventArgs) Handles sender_add_Button1.Click
        Dim frm As New combo_items_list
        frm.group_id_Label1.Text = "1"
        frm.ShowDialog()
        '----------------------
        If frm.DialogResult = DialogResult.OK Then
            adv_combo_frm_Load(sender, e)
        End If
        frm.Dispose()
    End Sub

    Private Sub priority_add_Button1_Click(sender As Object, e As EventArgs) Handles priority_add_Button1.Click
        Dim frm As New combo_items_list
        frm.group_id_Label1.Text = "20"
        frm.ShowDialog()
        '----------------------
        If frm.DialogResult = DialogResult.OK Then
            adv_combo_frm_Load(sender, e)
        End If
        frm.Dispose()
    End Sub

    Private Sub gender_Button2_Click(sender As Object, e As EventArgs) Handles gender_Button2.Click
        Dim frm As New combo_items_list
        frm.group_id_Label1.Text = "100"
        frm.ShowDialog()
        '----------------------
        If frm.DialogResult = DialogResult.OK Then
            adv_combo_frm_Load(sender, e)
        End If
        frm.Dispose()
    End Sub

    Private Sub save_Button1_Click(sender As Object, e As EventArgs) Handles save_Button1.Click
        Try
            Me.Customers_infoBindingSource.EndEdit()
            Dim r As Integer
            r = Me.Customers_infoTableAdapter.Update(Me.Combo_ds.customers_info)
            '-------------------------
            If r > 0 Then
                MessageBox.Show("Saved!")
                Me.DialogResult = DialogResult.OK
            Else
                MessageBox.Show("Not Saved! Try again!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error! " + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New combo_items_crud
        frm.parent_group_id.Text = "1"
        frm.ShowDialog()
        '----------------------
        If frm.DialogResult = DialogResult.OK Then
            adv_combo_frm_Load(sender, e)
        End If
        frm.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New combo_items_crud
        frm.parent_group_id.Text = "20"
        frm.ShowDialog()
        '----------------------
        If frm.DialogResult = DialogResult.OK Then
            adv_combo_frm_Load(sender, e)
        End If
        frm.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New combo_items_crud
        frm.parent_group_id.Text = "100"
        frm.ShowDialog()
        '----------------------
        If frm.DialogResult = DialogResult.OK Then
            adv_combo_frm_Load(sender, e)
        End If
        frm.Dispose()
    End Sub
End Class