Imports System.Data
Imports System.Data.OleDb
Public Class frmUsuario

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Dim usuario, contraseña As String
        Dim consulta As String
        consulta = "SELECT*FROM Usuarios WHERE Usuario='" & cboUsuario.Text & "' Contraseña='" & txtcontraseña.Text
        usuario = cboUsuario.Text
        contraseña = txtcontraseña.Text
        If txtcontraseña.Text = "" Then
            MessageBox.Show("Usuario o contraseña incorrecta, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboUsuario.Text = ""
            txtcontraseña.Text = ""
            Me.Visible = True
        End If
        If usuario = (cboUsuario.Text) And contraseña = txtcontraseña.Text Then
            MessageBox.Show("Bienvenido a la Base de datos de el negocio: Super Tienda." & " " & usuario, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Visible = False
            My.Forms.frmPrincipal.Visible = True
        
        End If
    End Sub
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SuperTiendaDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.SuperTiendaDataSet.Usuarios)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 
        MsgBox("Bienvenido a la Base de datos de el negocio: Super Tienda", MsgBoxStyle.Information, "Bienvenido Usuario")
    End Sub
End Class
