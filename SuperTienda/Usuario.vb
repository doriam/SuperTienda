Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmUsuario
    Dim Conexion As OleDb.OleDbConnection

    'A actualizar
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Conexion = New OleDb.OleDbConnection
        Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SuperTienda.accdb"
        Conexion.Open()
        Dim da As New OleDb.OleDbDataAdapter("select * from Usuarios WHERE Usuario='" & cboUsuario.Text & "' AND Contraseña='" & txtcontraseña.Text & "'", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            MessageBox.Show("Bienvenido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Visible = False
            My.Forms.frmPrincipal.Visible = True
        Else
            MessageBox.Show("Usuario o contraseña incorrecta, intente de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboUsuario.Text = ""
            txtcontraseña.Text = ""
        End If
    End Sub
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SuperTiendaDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.SuperTiendaDataSet.Usuarios)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
