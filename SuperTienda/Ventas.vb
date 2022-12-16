Imports System.Data
Imports System.Data.OleDb
Imports System.IO.Path
Imports System.IO

Public Class frmVentas
    Dim ruta = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Venta.txt"
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Visible = False
        My.Forms.frmPrincipal.Visible = True
    End Sub

    Private Sub txtseleccion_TextChanged(sender As Object, e As EventArgs) Handles txtseleccion.TextChanged
        If Trim(txtseleccion.Text) = "" Then
            Me.InventarioBindingSource.RemoveFilter()
            Me.gridInventario.Visible = False
        Else
            Me.InventarioBindingSource.Filter = "Descripción LIKE '*" &
                Trim(txtseleccion.Text) & "%'"
            Me.gridInventario.Visible = True
        End If

    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SuperTiendaDataSet.Inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.SuperTiendaDataSet.Inventario)
      
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        With gridInventario
            If gridInventario.Rows.Count = 0 Then Exit Sub
            lbldescrip.Tag = .CurrentRow.Cells(1).Value
            lbldescrip.Text = .CurrentRow.Cells(3).Value
            lblprecio.Text = Format(.CurrentRow.Cells(5).Value)
        End With
        txtseleccion.Text = ""
        txtcantidad.Focus()

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim DbConexion As New OleDbConnection
        Dim Insertar As String = "INSERT INTO ventas (lbldescrip.Text, txtcantidad.Text, lblprecio.Text, lblsubtotal.Text)"
        Dim Valores As String = "Values ( " & CStr(lblnumero.Text) & ", " & lbldescrip.Text & ", " & txtcantidad.Text & ", " & lblprecio.Text & ", " & lblsubtotal.Text & ")"
        Dim Cmd As New OleDbCommand(Insertar + Valores, DbConexion)
        If txtcantidad.Text < 0 Then
            listcuenta.Items.Add(lbldescrip.Text & "                " & lblprecio.Text & "                  " & txtcantidad.Text & "                " & lblsubtotal.Text & vbCrLf)
            lbltotal.Text = txtcantidad.Text * lblprecio.Text
        Else
            listcuenta.Items.Add(lbldescrip.Text & "                " & lblprecio.Text & "                  " & txtcantidad.Text & "                " & lblsubtotal.Text & vbCrLf)
            lbltotal.Text = lbltotal.Text + (txtcantidad.Text * lblprecio.Text)
        End If
        Cmd = Nothing
        DbConexion.Close()
        lbldescrip.Text = "Artículo"
        lblprecio.Text = "Precio"
        txtcantidad.Text = ""
        lblsubtotal.Text = "Subtotal"
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
        If txtcantidad.Text = "" Then
            btnguardar.Enabled = False
        Else
            btnguardar.Enabled = True
        End If

        If txtcantidad.Text = "" Then
            btnagregar.Enabled = False
        Else
            btnagregar.Enabled = True
        End If
        If Trim(txtcantidad.Text) = "" Then lblsubtotal.Text = 0 : Exit Sub
        If IsNumeric(Trim(txtcantidad.Text)) Then
            lblsubtotal.Text = Format(txtcantidad.Text) * (lblprecio.Text)
        End If

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        Try
            Dim rutaFichero As String
            Dim i As Integer

            rutaFichero = Path.Combine(Application.StartupPath, "ventas.txt")
            Dim fichero As New IO.StreamWriter(rutaFichero)
            For i = 0 To listcuenta.Items.Count - 1
                fichero.WriteLine(listcuenta.Items(i))
            Next
            fichero.Close()
            lbldescrip.Text = "Artículo"
            lblprecio.Text = "Precio"
            txtcantidad.Text = ""
            lblsubtotal.Text = "Subtotal"
            listcuenta.Items.Clear()
            lbltotal.Text = ""
            MsgBox("Se ha guardado la venta con éxito", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox("Se ha producido un error al guardar la venta, intente de nuevo")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        MsgBox("¿Está seguro de cancelar la venta?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If vbYes Then
            lbldescrip.Text = "Artículo"
            lblprecio.Text = "Precio"
            txtcantidad.Text = ""
            lblsubtotal.Text = "Subtotal"
            listcuenta.Items.Clear()
            lbltotal.Text = ""
        End If
    End Sub

    Private Sub btnNueva_Click(sender As Object, e As EventArgs) Handles btnNueva.Click

        MsgBox("¿Está seguro de iniciar una nueva venta? Esto borrará el contenido de la venta actual y no se guardará la información", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
        If vbYes Then
            lbldescrip.Text = "Artículo"
            lblprecio.Text = "Precio"
            txtcantidad.Text = ""
            lblsubtotal.Text = "Subtotal"
            listcuenta.Items.Clear()
        ElseIf vbNo Then
            btnNueva.Focus()
        End If
            Select Case vbYes
                Case vbYes
                    lblnumero.Text = 1
                If vbYes Then
                    lblnumero.Text = 2
                End If
        End Select

    End Sub

    Private Sub listcuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listcuenta.SelectedIndexChanged

    End Sub
End Class