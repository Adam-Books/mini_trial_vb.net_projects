Public Class combo_items_list
    Private Sub combo_items_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Combo_ds.combo_items' table. You can move, or remove it, as needed.
        'Me.Combo_itemsTableAdapter.Fill(Me.Combo_ds.combo_items)
        Try
            Dim gi As Int32
            Int32.TryParse(Me.group_id_Label1.Text, gi)
            Me.Combo_itemsTableAdapter.FillBy_group_id(Me.Combo_ds.combo_items, gi)
        Catch ex As Exception
            MessageBox.Show("Error!" + ex.Message)
        End Try
    End Sub

    Private Sub exit_Button2_Click(sender As Object, e As EventArgs) Handles exit_Button2.Click
        Me.Close()
    End Sub

    Private Sub save_Button1_Click(sender As Object, e As EventArgs) Handles save_Button1.Click
        Try
            '-------------------------
            Dim rc As Integer
            rc = Me.Combo_ds.combo_items.Rows.Count
            '------------------------
            Dim gi As Integer
            Int32.TryParse(Me.group_id_Label1.Text, gi)
            '------------------------
            For index = 0 To rc - 1
                If Me.Combo_ds.combo_items.Rows.Item(index).RowState = DataRowState.Added Then
                    Me.Combo_ds.combo_items.Rows.Item(index).Item(2) = gi
                End If
            Next
            '-------------------------

            Me.ComboitemsBindingSource.EndEdit()
            Dim r As Integer
            r = Me.Combo_itemsTableAdapter.Update(Me.Combo_ds.combo_items)
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 2 Then
            Me.ComboitemsBindingSource.RemoveCurrent()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rc As Integer
        rc = Me.Combo_ds.combo_items.Rows.Count
        MessageBox.Show(rc.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cc As Integer
        cc = Me.Combo_ds.combo_items.Columns.Count
        MessageBox.Show(cc.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rs As String
        rs = Combo_ds.combo_items.Rows.Item(0).RowState.ToString()
        MessageBox.Show(rs, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.ListBox1.Items.Clear()
        Dim rc As Integer
        rc = Me.Combo_ds.combo_items.Rows.Count
        '------------------------
        For index = 0 To rc - 1
            Dim rs As String
            rs = Combo_ds.combo_items.Rows.Item(index).RowState.ToString()
            '--------------------
            Me.ListBox1.Items.Add(rs)
        Next
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Combo_ds.combo_items.Rows.Item(0).AcceptChanges()
        Me.Combo_ds.combo_items.AcceptChanges()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.ListBox1.Items.Clear()
        '------------------------
        Dim cv As New Object

        Dim rc As Integer
        rc = Me.Combo_ds.combo_items.Rows.Count
        '------------------------
        For index = 0 To rc - 1
            '--------------------
            cv = Combo_ds.combo_items.Rows.Item(index).Item(2)
            '------------------------
            If cv Is DBNull.Value Then
            Else
                Me.ListBox1.Items.Add(cv.ToString)
            End If
            '--------------------
        Next
    End Sub
End Class