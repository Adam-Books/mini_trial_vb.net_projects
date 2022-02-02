Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Barcode_ds.Product_List' table. You can move, or remove it, as needed.
        'Me.Product_ListTableAdapter.Fill(Me.Barcode_ds.Product_List)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles search_TextBox1.TextChanged

    End Sub

    Private Sub Product_ListBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Product_ListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Product_ListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Barcode_ds)

    End Sub

    Private Sub Product_ListBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles Product_ListBindingSource.CurrentChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Product_ListTableAdapter.Fill(Me.Barcode_ds.Product_List)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Product_ListTableAdapter.FillBy_barcode_data(Me.Barcode_ds.Product_List)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Product_ListTableAdapter.FillBy_barcode_search(Me.Barcode_ds.Product_List, Me.search_TextBox1.Text)
    End Sub

    Private Sub search_TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles search_TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3_Click(sender, e)
            search_TextBox1.Text = ""

        End If
    End Sub
End Class
