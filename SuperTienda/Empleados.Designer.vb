<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Dim Clave_de_empleadoLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim EdadLabel As System.Windows.Forms.Label
        Dim Estado_civilLabel As System.Windows.Forms.Label
        Dim DirecciónLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim TeléfonoLabel As System.Windows.Forms.Label
        Dim DepartamentoLabel As System.Windows.Forms.Label
        Dim Fecha_de_contrataciónLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleados))
        Me.SuperTiendaDataSet = New WindowsApplication1.SuperTiendaDataSet()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New WindowsApplication1.SuperTiendaDataSetTableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.SuperTiendaDataSetTableAdapters.TableAdapterManager()
        Me.EmpleadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmpleadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtclaveempleado = New System.Windows.Forms.TextBox()
        Me.txtsexo = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtciudad = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboDepto = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblempleado = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Clave_de_empleadoLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        EdadLabel = New System.Windows.Forms.Label()
        Estado_civilLabel = New System.Windows.Forms.Label()
        DirecciónLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        TeléfonoLabel = New System.Windows.Forms.Label()
        DepartamentoLabel = New System.Windows.Forms.Label()
        Fecha_de_contrataciónLabel = New System.Windows.Forms.Label()
        CType(Me.SuperTiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadosBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Clave_de_empleadoLabel
        '
        Clave_de_empleadoLabel.AutoSize = True
        Clave_de_empleadoLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Clave_de_empleadoLabel.Location = New System.Drawing.Point(24, 56)
        Clave_de_empleadoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Clave_de_empleadoLabel.Name = "Clave_de_empleadoLabel"
        Clave_de_empleadoLabel.Size = New System.Drawing.Size(236, 38)
        Clave_de_empleadoLabel.TabIndex = 44
        Clave_de_empleadoLabel.Text = "Clave de empleado:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        SexoLabel.Location = New System.Drawing.Point(24, 101)
        SexoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(77, 38)
        SexoLabel.TabIndex = 46
        SexoLabel.Text = "Sexo:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        NombreLabel.Location = New System.Drawing.Point(24, 146)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(118, 38)
        NombreLabel.TabIndex = 48
        NombreLabel.Text = "Nombre:"
        '
        'EdadLabel
        '
        EdadLabel.AutoSize = True
        EdadLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        EdadLabel.Location = New System.Drawing.Point(24, 190)
        EdadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EdadLabel.Name = "EdadLabel"
        EdadLabel.Size = New System.Drawing.Size(77, 38)
        EdadLabel.TabIndex = 50
        EdadLabel.Text = "Edad:"
        '
        'Estado_civilLabel
        '
        Estado_civilLabel.AutoSize = True
        Estado_civilLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Estado_civilLabel.Location = New System.Drawing.Point(24, 233)
        Estado_civilLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Estado_civilLabel.Name = "Estado_civilLabel"
        Estado_civilLabel.Size = New System.Drawing.Size(147, 38)
        Estado_civilLabel.TabIndex = 52
        Estado_civilLabel.Text = "Estado civil:"
        '
        'DirecciónLabel
        '
        DirecciónLabel.AutoSize = True
        DirecciónLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        DirecciónLabel.Location = New System.Drawing.Point(24, 277)
        DirecciónLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DirecciónLabel.Name = "DirecciónLabel"
        DirecciónLabel.Size = New System.Drawing.Size(132, 38)
        DirecciónLabel.TabIndex = 54
        DirecciónLabel.Text = "Dirección:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        CiudadLabel.Location = New System.Drawing.Point(24, 322)
        CiudadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(102, 38)
        CiudadLabel.TabIndex = 56
        CiudadLabel.Text = "Ciudad:"
        '
        'TeléfonoLabel
        '
        TeléfonoLabel.AutoSize = True
        TeléfonoLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        TeléfonoLabel.Location = New System.Drawing.Point(24, 367)
        TeléfonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TeléfonoLabel.Name = "TeléfonoLabel"
        TeléfonoLabel.Size = New System.Drawing.Size(122, 38)
        TeléfonoLabel.TabIndex = 58
        TeléfonoLabel.Text = "Teléfono:"
        '
        'DepartamentoLabel
        '
        DepartamentoLabel.AutoSize = True
        DepartamentoLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        DepartamentoLabel.Location = New System.Drawing.Point(24, 412)
        DepartamentoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DepartamentoLabel.Name = "DepartamentoLabel"
        DepartamentoLabel.Size = New System.Drawing.Size(186, 38)
        DepartamentoLabel.TabIndex = 60
        DepartamentoLabel.Text = "Departamento:"
        '
        'Fecha_de_contrataciónLabel
        '
        Fecha_de_contrataciónLabel.AutoSize = True
        Fecha_de_contrataciónLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Fecha_de_contrataciónLabel.Location = New System.Drawing.Point(24, 458)
        Fecha_de_contrataciónLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Fecha_de_contrataciónLabel.Name = "Fecha_de_contrataciónLabel"
        Fecha_de_contrataciónLabel.Size = New System.Drawing.Size(271, 38)
        Fecha_de_contrataciónLabel.TabIndex = 62
        Fecha_de_contrataciónLabel.Text = "Fecha de contratación:"
        '
        'SuperTiendaDataSet
        '
        Me.SuperTiendaDataSet.DataSetName = "SuperTiendaDataSet"
        Me.SuperTiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.SuperTiendaDataSet
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.PromocionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.SuperTiendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'EmpleadosBindingNavigator
        '
        Me.EmpleadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpleadosBindingNavigator.BindingSource = Me.EmpleadosBindingSource
        Me.EmpleadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpleadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpleadosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EmpleadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpleadosBindingNavigatorSaveItem})
        Me.EmpleadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpleadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadosBindingNavigator.Name = "EmpleadosBindingNavigator"
        Me.EmpleadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpleadosBindingNavigator.Size = New System.Drawing.Size(1369, 31)
        Me.EmpleadosBindingNavigator.TabIndex = 0
        Me.EmpleadosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'EmpleadosBindingNavigatorSaveItem
        '
        Me.EmpleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpleadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpleadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpleadosBindingNavigatorSaveItem.Name = "EmpleadosBindingNavigatorSaveItem"
        Me.EmpleadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.EmpleadosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSalir.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnSalir.Location = New System.Drawing.Point(943, 826)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(221, 66)
        Me.btnSalir.TabIndex = 44
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.Control
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnVolver.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnVolver.Location = New System.Drawing.Point(173, 826)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(221, 66)
        Me.btnVolver.TabIndex = 43
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'txtclaveempleado
        '
        Me.txtclaveempleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Clave de empleado", True))
        Me.txtclaveempleado.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtclaveempleado.Location = New System.Drawing.Point(312, 56)
        Me.txtclaveempleado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtclaveempleado.Name = "txtclaveempleado"
        Me.txtclaveempleado.Size = New System.Drawing.Size(473, 38)
        Me.txtclaveempleado.TabIndex = 45
        '
        'txtsexo
        '
        Me.txtsexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Sexo", True))
        Me.txtsexo.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtsexo.Location = New System.Drawing.Point(312, 101)
        Me.txtsexo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsexo.Name = "txtsexo"
        Me.txtsexo.Size = New System.Drawing.Size(473, 38)
        Me.txtsexo.TabIndex = 47
        '
        'txtnombre
        '
        Me.txtnombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Nombre", True))
        Me.txtnombre.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtnombre.Location = New System.Drawing.Point(312, 146)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(473, 38)
        Me.txtnombre.TabIndex = 49
        '
        'txtedad
        '
        Me.txtedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Edad", True))
        Me.txtedad.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtedad.Location = New System.Drawing.Point(312, 190)
        Me.txtedad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(473, 38)
        Me.txtedad.TabIndex = 51
        '
        'txtestado
        '
        Me.txtestado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Estado civil", True))
        Me.txtestado.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtestado.Location = New System.Drawing.Point(312, 233)
        Me.txtestado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(473, 38)
        Me.txtestado.TabIndex = 53
        '
        'txtdireccion
        '
        Me.txtdireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Dirección", True))
        Me.txtdireccion.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtdireccion.Location = New System.Drawing.Point(312, 277)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(473, 38)
        Me.txtdireccion.TabIndex = 55
        '
        'txtciudad
        '
        Me.txtciudad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Ciudad", True))
        Me.txtciudad.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtciudad.Location = New System.Drawing.Point(312, 322)
        Me.txtciudad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtciudad.Name = "txtciudad"
        Me.txtciudad.Size = New System.Drawing.Size(473, 38)
        Me.txtciudad.TabIndex = 57
        '
        'txttelefono
        '
        Me.txttelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Teléfono", True))
        Me.txttelefono.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txttelefono.Location = New System.Drawing.Point(312, 367)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(473, 38)
        Me.txttelefono.TabIndex = 59
        '
        'txtdate
        '
        Me.txtdate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "Fecha de contratación", True))
        Me.txtdate.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtdate.Location = New System.Drawing.Point(312, 457)
        Me.txtdate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(473, 38)
        Me.txtdate.TabIndex = 63
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.cboDepto)
        Me.GroupBox1.Controls.Add(Fecha_de_contrataciónLabel)
        Me.GroupBox1.Controls.Add(Clave_de_empleadoLabel)
        Me.GroupBox1.Controls.Add(Me.txtdate)
        Me.GroupBox1.Controls.Add(Me.txtclaveempleado)
        Me.GroupBox1.Controls.Add(SexoLabel)
        Me.GroupBox1.Controls.Add(DepartamentoLabel)
        Me.GroupBox1.Controls.Add(Me.txtsexo)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(TeléfonoLabel)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtciudad)
        Me.GroupBox1.Controls.Add(EdadLabel)
        Me.GroupBox1.Controls.Add(CiudadLabel)
        Me.GroupBox1.Controls.Add(Me.txtedad)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Estado_civilLabel)
        Me.GroupBox1.Controls.Add(DirecciónLabel)
        Me.GroupBox1.Controls.Add(Me.txtestado)
        Me.GroupBox1.Font = New System.Drawing.Font("Gill Sans MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(30, 117)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(813, 512)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de empleados"
        '
        'cboDepto
        '
        Me.cboDepto.Font = New System.Drawing.Font("Gill Sans MT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepto.FormattingEnabled = True
        Me.cboDepto.Location = New System.Drawing.Point(312, 410)
        Me.cboDepto.Name = "cboDepto"
        Me.cboDepto.Size = New System.Drawing.Size(473, 42)
        Me.cboDepto.TabIndex = 77
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBuscar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnBuscar.Location = New System.Drawing.Point(1115, 474)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(212, 64)
        Me.btnBuscar.TabIndex = 70
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEliminar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnEliminar.Location = New System.Drawing.Point(881, 474)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(212, 64)
        Me.btnEliminar.TabIndex = 66
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGuardar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnGuardar.Location = New System.Drawing.Point(881, 161)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(446, 64)
        Me.btnGuardar.TabIndex = 65
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(30, 650)
        Me.EmpleadosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.RowHeadersWidth = 51
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(1320, 155)
        Me.EmpleadosDataGridView.TabIndex = 70
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Clave de empleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Clave de empleado"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Sexo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sexo"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Edad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Edad"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Estado civil"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estado civil"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Dirección"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Ciudad"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Ciudad"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Teléfono"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Departamento"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Departamento"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Fecha de contratación"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fecha de contratación"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'lblempleado
        '
        Me.lblempleado.BackColor = System.Drawing.Color.Transparent
        Me.lblempleado.Font = New System.Drawing.Font("Gill Sans MT", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempleado.ForeColor = System.Drawing.Color.Black
        Me.lblempleado.Location = New System.Drawing.Point(489, 46)
        Me.lblempleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblempleado.Name = "lblempleado"
        Me.lblempleado.Size = New System.Drawing.Size(513, 54)
        Me.lblempleado.TabIndex = 72
        Me.lblempleado.Text = "Empleados"
        Me.lblempleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.SystemColors.Control
        Me.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnmodificar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnmodificar.Location = New System.Drawing.Point(1115, 368)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(212, 64)
        Me.btnmodificar.TabIndex = 74
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.SystemColors.Control
        Me.btnAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAlta.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnAlta.Location = New System.Drawing.Point(881, 368)
        Me.btnAlta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(212, 64)
        Me.btnAlta.TabIndex = 75
        Me.btnAlta.Text = "Alta de registros"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnCancelar.Location = New System.Drawing.Point(881, 263)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(446, 64)
        Me.btnCancelar.TabIndex = 76
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1369, 1055)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.lblempleado)
        Me.Controls.Add(Me.EmpleadosDataGridView)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.EmpleadosBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos empleados"
        CType(Me.SuperTiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadosBindingNavigator.ResumeLayout(False)
        Me.EmpleadosBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SuperTiendaDataSet As WindowsApplication1.SuperTiendaDataSet
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As WindowsApplication1.SuperTiendaDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.SuperTiendaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EmpleadosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents txtclaveempleado As System.Windows.Forms.TextBox
    Friend WithEvents txtsexo As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtedad As System.Windows.Forms.TextBox
    Friend WithEvents txtestado As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtciudad As System.Windows.Forms.TextBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents EmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblempleado As System.Windows.Forms.Label
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents cboDepto As ComboBox
End Class
