Imports System.Diagnostics.Eventing.Reader

Public Class frmDepartamentos
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DepartamentosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DepartamentosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DepartamentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SuperTiendaDataSet)

    End Sub

    Private Sub frmDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SuperTiendaDataSet.Inventario' Puede moverla o quitarla según sea necesario.
        'Me.InventarioTableAdapter.Fill(Me.SuperTiendaDataSet.Inventario)'
        'TODO: esta línea de código carga datos en la tabla 'SuperTiendaDataSet.Departamentos' Puede moverla o quitarla según sea necesario.
        Me.DepartamentosTableAdapter.Fill(Me.SuperTiendaDataSet.Departamentos)
        btnGuardar.Enabled = False
    End Sub

    Private Sub DepartamentosBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles DepartamentosBindingNavigator.RefreshItems

    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If buscar = 2 Then
            Me.DepartamentosTableAdapter.BUSCAR(Me.SuperTiendaDataSet.Departamentos, txtdepartamento.Text)
            buscar = 1
        Else
            MessageBox.Show("Favor de escribir en el campo Departamento el Departamento a buscar y después hacer click en Buscar de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            buscar = 2
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If eliminar = 2 Then
            respuesta = MsgBox("¿Está seguro de borrar este dato?", vbQuestion + vbYesNo + vbDefaultButton2, "Eliminar departamento")
            If respuesta = vbYes Then
                Me.DepartamentosTableAdapter.DELETE1(txtiddep.Text)
                Me.DepartamentosTableAdapter.Fill(Me.SuperTiendaDataSet.Departamentos)
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
                Me.DepartamentosTableAdapter.INSERTAR(txtdepartamento.Text)
                Me.DepartamentosTableAdapter.Fill(Me.SuperTiendaDataSet.Departamentos)
                MessageBox.Show("Información guardada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Información no actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            Try
                Me.DepartamentosTableAdapter.MODIFICAR(txtdepartamento.Text, txtiddep.Text)
                Me.DepartamentosTableAdapter.Fill(Me.SuperTiendaDataSet.Departamentos)
                MessageBox.Show("Información actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtiddep.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Información no actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        txtiddep.Enabled = False
        btnGuardar.Enabled = False
        btnEliminar.Enabled = True
        btnBuscar.Enabled = True
        btnModificar.Enabled = True
        btnAlta.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtdepartamento.Enabled = True
        txtiddep.Enabled = False
        btnGuardar.Enabled = True
        btnAlta.Enabled = False
        btnEliminar.Enabled = False
        btnBuscar.Enabled = False
        up = True
        MessageBox.Show("Favor de elegir el valor a modificar dentro de la Tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        txtdepartamento.Text = ""
        txtiddep.Enabled = False
        txtiddep.Text = ""
        btnGuardar.Enabled = True
        btnEliminar.Enabled = False
        btnBuscar.Enabled = False
        btnModificar.Enabled = False
        up = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        buscar = 1
        eliminar = 1
        txtiddep.Enabled = True
        btnEliminar.Enabled = True
        btnBuscar.Enabled = True
        btnModificar.Enabled = True
        btnAlta.Enabled = True
        Me.DepartamentosTableAdapter.Fill(Me.SuperTiendaDataSet.Departamentos)
    End Sub
End Class