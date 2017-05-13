Public Class Form1

    Public Nombre As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        txtNombre.Text = tbxNombre.Text()
        Nombre = tbxNombre.Text()





    End Sub

    Private Sub btnAgregarLista_Click(sender As Object, e As EventArgs) Handles btnAgregarLista.Click
        lstAgregar.Items.Add(tbxNombre.Text())
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        lstAgregar.Items.Remove(lstAgregar.SelectedItem)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lstAgregar.Items.Clear()

    End Sub


    Private Sub btnVerch_Click(sender As Object, e As EventArgs) Handles btnVerch.Click
        

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnAgregarcbx_Click(sender As Object, e As EventArgs) Handles btnAgregarcbx.Click
        cbxFrutas.Items.Insert(0, tbxAgregarcbx.Text())
    End Sub

    Private Sub btnLimpiarcbx_Click(sender As Object, e As EventArgs) Handles btnLimpiarcbx.Click
        cbxFrutas.Items.Clear()
    End Sub

    Private Sub btnEliminarSel_Click(sender As Object, e As EventArgs) Handles btnEliminarSel.Click
        cbxFrutas.Items.Remove(cbxFrutas.SelectedItem)


    End Sub

    Private Sub btnIr_Click(sender As Object, e As EventArgs) Handles btnIr.Click
        Me.Hide()

        formOperaciones.Show()



    End Sub
End Class
