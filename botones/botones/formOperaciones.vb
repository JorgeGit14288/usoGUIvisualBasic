Public Class formOperaciones

    Public Nombre As String = Form1.Nombre

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click


    End Sub

    Private Sub formOperaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombre.Text = Nombre
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        dgvPersona.Rows.Add(tbxNombres.Text, tbxApellidos.Text)

    End Sub

    
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.dgvPersona .Rows .Remove (Me.dgvPersona .CurrentRow)

    End Sub

    Private Sub btnLImpiar_Click(sender As Object, e As EventArgs) Handles btnLImpiar.Click
        Me.dgvPersona.Rows.Clear()

    End Sub
End Class