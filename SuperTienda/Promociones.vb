Public Class frmPromociones
    Public conex As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SuperTienda.accdb")
    Public coman As New OleDb.OleDbCommand
    Dim cargar As String

    Dim up As Boolean

    Dim buscar As Integer = 1
    Dim eliminar As Integer = 1
    Dim respuesta As Integer
    Dim Conexion As OleDb.OleDbConnection

    Private Sub PromocionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PromocionesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PromocionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SuperTiendaDataSet)

    End Sub

    Private Sub frmPromociones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SuperTiendaDataSet.Promociones' Puede moverla o quitarla según sea necesario.
        Me.PromocionesTableAdapter.Fill(Me.SuperTiendaDataSet.Promociones)
        btnGuardar.Enabled = False
        LlenarCombo()
        txtsubtotal.Enabled = False
        txttotal.Enabled = False
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
                Dim subtotal As String = 0
                subtotal = txtpreciounitario.Text * txtcantidad.Text
                Dim total As String = 0
                Dim descuento As Decimal
                txtsubtotal.Text = subtotal
                Decimal.TryParse(txtdescuento.Text, descuento)
                txtdescuento.Text = descuento
                total = subtotal * descuento
                txttotal.Text = total

                Me.PromocionesTableAdapter.INSERTAR(cboDepto.Text, txtpromo.Text, txtproducto.Text, txtpreciounitario.Text, txtcantidad.Text, txtdescuento.Text)
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
                Me.PromocionesTableAdapter.ACTUALIZAR(cboDepto.Text, txtpromo.Text, txtproducto.Text, txtpreciounitario.Text, txtcantidad.Text, txtdescuento.Text, txtid.Text)
                Me.PromocionesTableAdapter.Fill(Me.SuperTiendaDataSet.Promociones)
                MessageBox.Show("Información actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtid.Enabled = True
            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0}", ex.Message))
                'MessageBox.Show("Información no actuaizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)'
            End Try
        End If
        txtid.Enabled = False
        txtdepto.Visible = True
        cboDepto.Visible = False
        btnGuardar.Enabled = False
        btnEliminar.Enabled = True
        btnBuscar.Enabled = True
        btnModificar.Enabled = True
        btnAlta.Enabled = True

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
        cboDepto.Visible = False
        txtdescuento.Enabled = True
        txtpreciounitario.Enabled = True
        txtproducto.Enabled = True
        txtpromo.Enabled = True

        btnGuardar.Enabled = True
        btnAlta.Enabled = False
        btnEliminar.Enabled = False
        btnBuscar.Enabled = False
        up = True
        MessageBox.Show("Favor de elegir el valor a modificar dentro de la Tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        txtid.Enabled = True
        txtid.Text = ""
        txtcantidad.Text = ""
        txtdepto.Visible = False
        cboDepto.Visible = True
        cboDepto.SelectedValue = -1
        txtdescuento.Text = ""
        txtpreciounitario.Text = ""
        txtproducto.Text = ""
        txtpromo.Text = ""
        txtsubtotal.Text = ""
        txttotal.Text = ""
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
        txtdepto.Visible = True
        cboDepto.Visible = False
        btnEliminar.Enabled = True
        btnBuscar.Enabled = True
        btnModificar.Enabled = True
        btnAlta.Enabled = True
        Me.PromocionesTableAdapter.Fill(Me.SuperTiendaDataSet.Promociones)
    End Sub
    Private Sub LlenarCombo()
        Conexion = New OleDb.OleDbConnection
        Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SuperTienda.accdb"
        Conexion.Open()
        Dim da As New OleDb.OleDbDataAdapter("select * from Departamentos", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            cboDepto.DataSource = ds.Tables(0)
            cboDepto.DisplayMember = "Departamento"
            cboDepto.ValueMember = "Id Departamento"
            cboDepto.SelectedIndex = -1
        End If
    End Sub
End Class