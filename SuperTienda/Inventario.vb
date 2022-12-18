Public Class frmInventario
    Dim up As Boolean
    Dim buscar As Integer = 1
    Dim eliminar As Integer = 1
    Dim respuesta As Integer
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Visible = False
        My.Forms.frmPrincipal.Visible = True

    End Sub

    Private Sub InventarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InventarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InventarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SuperTiendaDataSet)

    End Sub

    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SuperTiendaDataSet.Inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.SuperTiendaDataSet.Inventario)
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If up = False Then
            Try
                Me.InventarioTableAdapter.Insert(txtiddepa.Text, txtdepa.Text, txtclaveproducto.Text, txtdescripcion.Text, txtpreciocompra.Text, txtprecioventa.Text, txtexistencia.Text, txtfecha.Text)
                Me.InventarioTableAdapter.Fill(Me.SuperTiendaDataSet.Inventario)
                MessageBox.Show("Información guardada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Información no actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            Try
                Me.InventarioTableAdapter.ACTUALIZAR(txtiddepa.Text, txtdepa.Text, txtdescripcion.Text, txtpreciocompra.Text, txtprecioventa.Text, txtexistencia.Text, txtfecha.Text, txtclaveproducto.Text)
                Me.InventarioTableAdapter.Fill(Me.SuperTiendaDataSet.Inventario)
                MessageBox.Show("Información actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Información no actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        txtiddepa.Enabled = True
        txtclaveproducto.Enabled = True
        btnGuardar.Enabled = False
        btnEliminar.Enabled = True
        btnBuscar.Enabled = True
        btnModificar.Enabled = True
        btnAlta.Enabled = True
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If buscar = 2 Then
            Me.InventarioTableAdapter.BUSCAR(Me.SuperTiendaDataSet.Inventario, txtdescripcion.Text)
            buscar = 1
        Else
            MessageBox.Show("Favor de escribir en el campo Descripción el Producto a buscar y después hacer click en Buscar de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            buscar = 2
        End If


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If eliminar = 2 Then
            respuesta = MsgBox("¿Está seguro de borrar este dato?", vbQuestion + vbYesNo + vbDefaultButton2, "Eliminar departamento")
            If respuesta = vbYes Then
                Me.InventarioTableAdapter.Delete(txtiddepa.Text, txtdepa.Text, txtclaveproducto.Text, txtdescripcion.Text, txtpreciocompra.Text, txtprecioventa.Text, txtexistencia.Text, txtfecha.Text)
                Me.InventarioTableAdapter.Fill(Me.SuperTiendaDataSet.Inventario)
                MessageBox.Show("Se ha eliminado con éxito el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                eliminar = 1
            Else
                eliminar = 2
            End If

        Else
            MessageBox.Show("Favor de elegir el valor a eliminar dentro de la Tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            eliminar = 2
        End If
    End Sub


    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtiddepa.Enabled = True
        txtdepa.Enabled = True
        txtclaveproducto.Enabled = False
        txtdescripcion.Enabled = True
        txtpreciocompra.Enabled = True
        txtprecioventa.Enabled = True
        txtexistencia.Enabled = True
        txtfecha.Enabled = True
        btnGuardar.Enabled = True
        btnAlta.Enabled = False
        btnEliminar.Enabled = False
        btnBuscar.Enabled = False
        up = True
        MessageBox.Show("Favor de elegir el valor a modificar dentro de la Tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        txtiddepa.Text = ""
        txtdepa.Text = ""
        txtclaveproducto.Text = ""
        txtdescripcion.Text = ""
        txtpreciocompra.Text = ""
        txtprecioventa.Text = ""
        txtexistencia.Text = ""
        txtfecha.Text = ""
        btnGuardar.Enabled = True
        btnEliminar.Enabled = False
        btnBuscar.Enabled = False
        btnModificar.Enabled = False
        up = False
    End Sub

    Private Sub lbldepa_Click(sender As Object, e As EventArgs) Handles lbldepa.Click

    End Sub

    Private Sub Id_DepartamentoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DepartamentoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Clave_del_productoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DescripciónLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Precio_de_compraLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Precio_de_ventaLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExistenciaLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FechaLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        buscar = 1
        eliminar = 1
        txtclaveproducto.Enabled = True
        txtdepa.Enabled = True
        btnEliminar.Enabled = True
        btnBuscar.Enabled = True
        btnModificar.Enabled = True
        btnAlta.Enabled = True
        Me.InventarioTableAdapter.Fill(Me.SuperTiendaDataSet.Inventario)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class