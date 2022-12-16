Public Class frmPromociones
    Public conex As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SuperTienda.accdb")
    Public coman As New OleDb.OleDbCommand
    Dim cargar As String



    Dim up As Boolean

    Dim buscar As Integer = 1
    Dim eliminar As Integer = 1
    Dim respuesta As Integer

    Private Sub PromocionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PromocionesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PromocionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SuperTiendaDataSet)

    End Sub

    Private Sub frmPromociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SuperTiendaDataSet.Promociones' Puede moverla o quitarla según sea necesario.
        Me.PromocionesTableAdapter.Fill(Me.SuperTiendaDataSet.Promociones)
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Visible = False
        My.Forms.frmPrincipal.Visible = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If up = False Then
            Try
                txtsubtotal.Enabled = True
                txttotal.Enabled = True
                Dim subtotal As String = 0
                Dim precio, cantidad As String
                precio = txtpreciounitario.Text
                cantidad = txtcantidad.Text
                subtotal = precio * cantidad
                txtsubtotal.Text = subtotal
                Dim total As String = 0
                Dim descuento As String

                subtotal = txtsubtotal.Text
                descuento = txtdescuento.Text
                total = subtotal * descuento
                txttotal.Text = total

                Decimal.TryParse(txtsubtotal.Text, subtotal)
                Me.PromocionesTableAdapter.INSERTAR(txtid.Text, txtpromo.Text, txtproducto.Text, txtpreciounitario.Text, txtcantidad.Text, txtsubtotal.Text, txtdescuento.Text, txttotal.Text)
                Me.PromocionesTableAdapter.Fill(Me.SuperTiendaDataSet.Promociones)
                MessageBox.Show("Información guardada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0}", ex.Message))

                MessageBox.Show("Información no actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            Try

                Dim subtotal As String = 0
                Dim precio, cantidad As String
                If Not String.IsNullOrEmpty(txtsubtotal.Text) Then

                    subtotal = CDbl(txtsubtotal.Text)
                End If
                precio = txtpreciounitario.Text
                cantidad = txtcantidad.Text
                subtotal = precio * cantidad
                txtsubtotal.Text = subtotal
                Dim total As String = 0
                Dim descuento As String
                If Not String.IsNullOrEmpty(txttotal.Text) Then

                    total = CDbl(txttotal.Text)
                End If
                subtotal = txtsubtotal.Text
                descuento = txtdescuento.Text
                total = subtotal * descuento
                txttotal.Text = total
                Me.PromocionesTableAdapter.ACTUALIZAR(txtdepa.Text, txtpromo.Text, txtproducto.Text, txtpreciounitario.Text, txtcantidad.Text, txtdescuento.Text, txtid.Text)
                Me.PromocionesTableAdapter.Fill(Me.SuperTiendaDataSet.Promociones)
                MessageBox.Show("Información actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtid.Enabled = True
                txtsubtotal.Enabled = True
                txttotal.Enabled = True
            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0}", ex.Message))
                'MessageBox.Show("Información no actuaizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)'
            End Try
        End If
        txtid.Enabled = False
        btnGuardar.Enabled = False
        btnEliminar.Enabled = True
        btnBuscar.Enabled = True
        btnModificar.Enabled = True
        btnAlta.Enabled = True

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If buscar = 2 Then
            Me.PromocionesTableAdapter.BUSCAR(Me.SuperTiendaDataSet.Promociones, txtpromo.Text)
            buscar = 1
        Else
            MessageBox.Show("Favor de escribir en el campo promoción la Promoción a buscar y después hacer click en Buscar de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            buscar = 2
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If eliminar = 2 Then
            respuesta = MsgBox("¿Está seguro de borrar este dato?", vbQuestion + vbYesNo + vbDefaultButton2, "Eliminar promoción")
            If respuesta = vbYes Then
                Me.PromocionesTableAdapter.DELETE1(txtproducto.Text)
                Me.PromocionesTableAdapter.Fill(Me.SuperTiendaDataSet.Promociones)
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
        txtid.Enabled = False
        txtcantidad.Enabled = True
        txtdepa.Enabled = True
        txtdescuento.Enabled = True
        txtpreciounitario.Enabled = True
        txtproducto.Enabled = True
        txtpromo.Enabled = True
        txtsubtotal.Enabled = False
        txttotal.Enabled = False

        btnGuardar.Enabled = True
        btnAlta.Enabled = False
        btnEliminar.Enabled = False
        btnBuscar.Enabled = False
        up = True
        MessageBox.Show("Favor de elegir el valor a modificar dentro de la Tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        txtid.Enabled = True
        txtcantidad.Text = ""
        txtdepa.Text = ""
        txtdescuento.Text = ""
        txtpreciounitario.Text = ""
        txtproducto.Text = ""
        txtpromo.Text = ""
        txtsubtotal.Text = ""
        txttotal.Text = ""
        txtsubtotal.Enabled = False
        txttotal.Enabled = False
        btnGuardar.Enabled = True
        btnEliminar.Enabled = False
        btnBuscar.Enabled = False
        btnModificar.Enabled = False
        up = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        buscar = 1
        eliminar = 1
        txtid.Enabled = True
        btnEliminar.Enabled = True
        btnBuscar.Enabled = True
        btnModificar.Enabled = True
        btnAlta.Enabled = True
        Me.PromocionesTableAdapter.Fill(Me.SuperTiendaDataSet.Promociones)
    End Sub

    Private Sub txtpromo_TextChanged(sender As Object, e As EventArgs) Handles txtpromo.TextChanged

    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub
End Class