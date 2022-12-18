Imports System.Data.SqlClient
Imports WindowsApplication1.SuperTiendaDataSetTableAdapters

Public Class frmEmpleados
    Dim up As Boolean
    Dim buscar As Integer = 1
    Dim eliminar As Integer = 1
    Dim respuesta As Integer
    Dim Conexion As OleDb.OleDbConnection

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SuperTiendaDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SuperTiendaDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.SuperTiendaDataSet.Empleados)
        btnGuardar.Enabled = False
        LlenarCombo()

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Visible = False
        My.Forms.frmPrincipal.Visible = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If eliminar = 2 Then
            respuesta = MsgBox("¿Está seguro de borrar este dato?", vbQuestion + vbYesNo + vbDefaultButton2, "Eliminar empleado")
            If respuesta = vbYes Then
                Me.EmpleadosTableAdapter.Delete(txtclaveempleado.Text, txtsexo.Text, txtnombre.Text, txtedad.Text, txtestado.Text, txtdireccion.Text, txtciudad.Text, txttelefono.Text, cboDepto.Text, txtdate.Text)
                Me.EmpleadosTableAdapter.Fill(Me.SuperTiendaDataSet.Empleados)
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If up = False Then
            Try
                Me.EmpleadosTableAdapter.Insert(txtclaveempleado.Text, txtsexo.Text, txtnombre.Text, txtedad.Text, txtestado.Text, txtdireccion.Text, txtciudad.Text, txttelefono.Text, cboDepto.Text, txtdate.Text)
                Me.EmpleadosTableAdapter.Fill(Me.SuperTiendaDataSet.Empleados)
                MessageBox.Show("Información guardada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Información no actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            Try
                Me.EmpleadosTableAdapter.MODIFICAR(txtsexo.Text, txtnombre.Text, txtedad.Text, txtestado.Text, txtdireccion.Text, txtciudad.Text, txttelefono.Text, cboDepto.Text, txtdate.Text, txtclaveempleado.Text)
                Me.EmpleadosTableAdapter.Fill(Me.SuperTiendaDataSet.Empleados)
                MessageBox.Show("Información actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtclaveempleado.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Información no actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        txtclaveempleado.Enabled = False
        btnGuardar.Enabled = False
        btnEliminar.Enabled = True
        btnBuscar.Enabled = True
        btnmodificar.Enabled = True
        btnAlta.Enabled = True

    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If buscar = 2 Then
            Me.EmpleadosTableAdapter.FillBy(Me.SuperTiendaDataSet.Empleados, txtnombre.Text)
            buscar = 1
        Else
            MessageBox.Show("Favor de escribir en el campo Departamento el Departamento a buscar y después hacer click en Buscar de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            buscar = 2
        End If

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        txtclaveempleado.Enabled = False
        btnGuardar.Enabled = True
        btnAlta.Enabled = False
        btnEliminar.Enabled = False
        btnBuscar.Enabled = False
        up = True
        MessageBox.Show("Favor de elegir el valor a modificar dentro de la Tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        txtclaveempleado.Enabled = False
        txtclaveempleado.Text = ""
        txtsexo.Text = ""
        txtnombre.Text = ""
        txtedad.Text = ""
        txtestado.Text = ""
        txtdireccion.Text = ""
        txtciudad.Text = ""
        txttelefono.Text = ""
        'txtdepartamento.Text = ""
        cboDepto.SelectedValue = -1
        txtdate.Text = ""
        btnGuardar.Enabled = True
        btnEliminar.Enabled = False
        btnBuscar.Enabled = False
        btnmodificar.Enabled = False
        up = False
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        buscar = 1
        eliminar = 1
        txtclaveempleado.Enabled = True
        btnEliminar.Enabled = True
        btnBuscar.Enabled = True
        btnmodificar.Enabled = True
        btnAlta.Enabled = True
        Me.EmpleadosTableAdapter.Fill(Me.SuperTiendaDataSet.Empleados)
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