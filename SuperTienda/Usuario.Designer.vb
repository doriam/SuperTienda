<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.lblcontraseña = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuperTiendaDataSet = New WindowsApplication1.SuperTiendaDataSet()
        Me.UsuariosTableAdapter = New WindowsApplication1.SuperTiendaDataSetTableAdapters.UsuariosTableAdapter()
        Me.cboUsuario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperTiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSalir.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnSalir.Location = New System.Drawing.Point(99, 375)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(264, 66)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAcceder
        '
        Me.btnAcceder.BackColor = System.Drawing.SystemColors.Control
        Me.btnAcceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAcceder.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnAcceder.Location = New System.Drawing.Point(99, 287)
        Me.btnAcceder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(264, 66)
        Me.btnAcceder.TabIndex = 10
        Me.btnAcceder.Text = "ACCEDER"
        Me.btnAcceder.UseVisualStyleBackColor = False
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtcontraseña.ForeColor = System.Drawing.Color.Black
        Me.txtcontraseña.Location = New System.Drawing.Point(99, 230)
        Me.txtcontraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Size = New System.Drawing.Size(265, 38)
        Me.txtcontraseña.TabIndex = 9
        Me.txtcontraseña.UseSystemPasswordChar = True
        '
        'lblcontraseña
        '
        Me.lblcontraseña.AutoSize = True
        Me.lblcontraseña.BackColor = System.Drawing.Color.Transparent
        Me.lblcontraseña.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.lblcontraseña.ForeColor = System.Drawing.Color.Black
        Me.lblcontraseña.Location = New System.Drawing.Point(97, 188)
        Me.lblcontraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcontraseña.Name = "lblcontraseña"
        Me.lblcontraseña.Size = New System.Drawing.Size(152, 38)
        Me.lblcontraseña.TabIndex = 8
        Me.lblcontraseña.Text = "Contraseña:"
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.BackColor = System.Drawing.Color.Transparent
        Me.lblusuario.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.ForeColor = System.Drawing.Color.Black
        Me.lblusuario.Location = New System.Drawing.Point(97, 93)
        Me.lblusuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(110, 38)
        Me.lblusuario.TabIndex = 6
        Me.lblusuario.Text = "Usuario:"
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.SuperTiendaDataSet
        '
        'SuperTiendaDataSet
        '
        Me.SuperTiendaDataSet.DataSetName = "SuperTiendaDataSet"
        Me.SuperTiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'cboUsuario
        '
        Me.cboUsuario.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.cboUsuario.ForeColor = System.Drawing.Color.Black
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.Items.AddRange(New Object() {"Brandon Ruiz", "Bryan Martínez", "Emilio Doria", "Genaro Siller", "Jaresy García", "Jose Martínez", "Karina Ruiz", "Kenia Álvarez", "Luis Cortez", "Martin Moreno", "Nancy Arriaga", "Raúl Ruiz", "Rocío Galvan", "Rodrigo Martínez", "Teresa Doria"})
        Me.cboUsuario.Location = New System.Drawing.Point(101, 135)
        Me.cboUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(263, 43)
        Me.cboUsuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(104, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 60)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "BIENVENIDO"
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(484, 473)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboUsuario)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.lblcontraseña)
        Me.Controls.Add(Me.lblusuario)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido"
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperTiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAcceder As System.Windows.Forms.Button
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblcontraseña As System.Windows.Forms.Label
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents SuperTiendaDataSet As WindowsApplication1.SuperTiendaDataSet
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As WindowsApplication1.SuperTiendaDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
