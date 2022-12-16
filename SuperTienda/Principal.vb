Public Class frmPrincipal

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Visible = False
        My.Forms.frmUsuario.Visible = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnDepartamentos_Click(sender As Object, e As EventArgs) Handles btnDepartamentos.Click
        Me.Visible = False
        My.Forms.frmDepartamentos.Visible = True

    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Me.Visible = False
        My.Forms.frmInventario.Visible = True
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Me.Visible = False
        My.Forms.frmEmpleados.Visible = True
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Me.Visible = False
        My.Forms.frmVentas.Visible = True
    End Sub

    Private Sub btnpromociones_Click(sender As Object, e As EventArgs) Handles btnpromociones.Click
        Me.Visible = False
        My.Forms.frmPromociones.Visible = True
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        Me.Visible = False
        My.Forms.frmDepartamentos.Visible = True
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Me.Visible = False
        My.Forms.frmInventario.Visible = True
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Me.Visible = False
        My.Forms.frmEmpleados.Visible = True
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Me.Visible = False
        My.Forms.frmVentas.Visible = True
    End Sub

    Private Sub PromocionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromocionesToolStripMenuItem.Click
        Me.Visible = False
        My.Forms.frmPromociones.Visible = True
    End Sub
End Class