Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Combo_itemsTableAdapter.Fill(Me.Combo_ds.combo_items)
        load_lbl_data()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Combo_itemsTableAdapter.FillBy_desc(Me.Combo_ds.combo_items)
        load_lbl_data()
    End Sub

    Private Sub Sender_ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Sender_ComboBox1.SelectedIndexChanged
        load_lbl_data()
    End Sub

    Sub load_lbl_data()
        Me.sel_Item_IndexLabel5.Text = Me.Sender_ComboBox1.SelectedIndex.ToString
        Me.sel_Item_Text_Label6.Text = Me.Sender_ComboBox1.Text
        Me.sel_Item_value__Label6.Text = Me.Sender_ComboBox1.SelectedValue.ToString

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New adv_combo_frm
        f.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Dim crud_frm As New combo_items_crud
        'crud_frm.Show()
        '-------------------------
        My.Forms.combo_items_crud.Show()
    End Sub
End Class
