

Public Class Form2

    Public Sub limpiar()

        nombres.Text = " "
        apepat.Text = " "
        apemat.Text = " "
        domi.Text = " "
        celular.Text = " "
        email.Text = " "

    End Sub




    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Boton_mostrar_Click(sender As Object, e As EventArgs) Handles Boton_mostrar.Click

        Dim tbl As Integer

        DataGridView1.Rows.Add()
        tbl = DataGridView1.Rows.Count - 1

        DataGridView1(0, tbl).Value = nombres.Text
        DataGridView1(1, tbl).Value = apepat.Text
        DataGridView1(2, tbl).Value = apemat.Text
        DataGridView1(3, tbl).Value = celular.Text
        DataGridView1(4, tbl).Value = email.Text

        limpiar()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(file.FileName)
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiar()

    End Sub
End Class