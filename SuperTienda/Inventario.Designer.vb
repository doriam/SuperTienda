<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventario
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
        Dim Id_DepartamentoLabel As System.Windows.Forms.Label
        Dim DepartamentoLabel As System.Windows.Forms.Label
        Dim Clave_del_productoLabel As System.Windows.Forms.Label
        Dim DescripciónLabel As System.Windows.Forms.Label
        Dim Precio_de_compraLabel As System.Windows.Forms.Label
        Dim Precio_de_ventaLabel As System.Windows.Forms.Label
        Dim ExistenciaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventario))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.InventarioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuperTiendaDataSet = New WindowsApplication1.SuperTiendaDataSet()
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
        Me.InventarioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtiddepa = New System.Windows.Forms.TextBox()
        Me.txtdepa = New System.Windows.Forms.TextBox()
        Me.txtclaveproducto = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtpreciocompra = New System.Windows.Forms.TextBox()
        Me.txtprecioventa = New System.Windows.Forms.TextBox()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.InventarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventarioTableAdapter = New WindowsApplication1.SuperTiendaDataSetTableAdapters.InventarioTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.SuperTiendaDataSetTableAdapters.TableAdapterManager()
        Me.lbldepa = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Id_DepartamentoLabel = New System.Windows.Forms.Label()
        DepartamentoLabel = New System.Windows.Forms.Label()
        Clave_del_productoLabel = New System.Windows.Forms.Label()
        DescripciónLabel = New System.Windows.Forms.Label()
        Precio_de_compraLabel = New System.Windows.Forms.Label()
        Precio_de_ventaLabel = New System.Windows.Forms.Label()
        ExistenciaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventarioBindingNavigator.SuspendLayout()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperTiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_DepartamentoLabel
        '
        Id_DepartamentoLabel.AutoSize = True
        Id_DepartamentoLabel.BackColor = System.Drawing.Color.Transparent
        Id_DepartamentoLabel.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_DepartamentoLabel.ForeColor = System.Drawing.Color.Black
        Id_DepartamentoLabel.Location = New System.Drawing.Point(12, 40)
        Id_DepartamentoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_DepartamentoLabel.Name = "Id_DepartamentoLabel"
        Id_DepartamentoLabel.Size = New System.Drawing.Size(189, 34)
        Id_DepartamentoLabel.TabIndex = 19
        Id_DepartamentoLabel.Text = "Id Departamento:"
        AddHandler Id_DepartamentoLabel.Click, AddressOf Me.Id_DepartamentoLabel_Click
        '
        'DepartamentoLabel
        '
        DepartamentoLabel.AutoSize = True
        DepartamentoLabel.BackColor = System.Drawing.Color.Transparent
        DepartamentoLabel.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartamentoLabel.ForeColor = System.Drawing.Color.Black
        DepartamentoLabel.Location = New System.Drawing.Point(12, 84)
        DepartamentoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DepartamentoLabel.Name = "DepartamentoLabel"
        DepartamentoLabel.Size = New System.Drawing.Size(164, 34)
        DepartamentoLabel.TabIndex = 21
        DepartamentoLabel.Text = "Departamento:"
        AddHandler DepartamentoLabel.Click, AddressOf Me.DepartamentoLabel_Click
        '
        'Clave_del_productoLabel
        '
        Clave_del_productoLabel.AutoSize = True
        Clave_del_productoLabel.BackColor = System.Drawing.Color.Transparent
        Clave_del_productoLabel.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Clave_del_productoLabel.ForeColor = System.Drawing.Color.Black
        Clave_del_productoLabel.Location = New System.Drawing.Point(12, 127)
        Clave_del_productoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Clave_del_productoLabel.Name = "Clave_del_productoLabel"
        Clave_del_productoLabel.Size = New System.Drawing.Size(209, 34)
        Clave_del_productoLabel.TabIndex = 23
        Clave_del_productoLabel.Text = "Clave del producto:"
        AddHandler Clave_del_productoLabel.Click, AddressOf Me.Clave_del_productoLabel_Click
        '
        'DescripciónLabel
        '
        DescripciónLabel.AutoSize = True
        DescripciónLabel.BackColor = System.Drawing.Color.Transparent
        DescripciónLabel.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripciónLabel.ForeColor = System.Drawing.Color.Black
        DescripciónLabel.Location = New System.Drawing.Point(12, 172)
        DescripciónLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescripciónLabel.Name = "DescripciónLabel"
        DescripciónLabel.Size = New System.Drawing.Size(138, 34)
        DescripciónLabel.TabIndex = 25
        DescripciónLabel.Text = "Descripción:"
        AddHandler DescripciónLabel.Click, AddressOf Me.DescripciónLabel_Click
        '
        'Precio_de_compraLabel
        '
        Precio_de_compraLabel.AutoSize = True
        Precio_de_compraLabel.BackColor = System.Drawing.Color.Transparent
        Precio_de_compraLabel.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Precio_de_compraLabel.ForeColor = System.Drawing.Color.Black
        Precio_de_compraLabel.Location = New System.Drawing.Point(12, 216)
        Precio_de_compraLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Precio_de_compraLabel.Name = "Precio_de_compraLabel"
        Precio_de_compraLabel.Size = New System.Drawing.Size(196, 34)
        Precio_de_compraLabel.TabIndex = 27
        Precio_de_compraLabel.Text = "Precio de compra:"
        AddHandler Precio_de_compraLabel.Click, AddressOf Me.Precio_de_compraLabel_Click
        '
        'Precio_de_ventaLabel
        '
        Precio_de_ventaLabel.AutoSize = True
        Precio_de_ventaLabel.BackColor = System.Drawing.Color.Transparent
        Precio_de_ventaLabel.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Precio_de_ventaLabel.ForeColor = System.Drawing.Color.Black
        Precio_de_ventaLabel.Location = New System.Drawing.Point(12, 260)
        Precio_de_ventaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Precio_de_ventaLabel.Name = "Precio_de_ventaLabel"
        Precio_de_ventaLabel.Size = New System.Drawing.Size(174, 34)
        Precio_de_ventaLabel.TabIndex = 29
        Precio_de_ventaLabel.Text = "Precio de venta:"
        AddHandler Precio_de_ventaLabel.Click, AddressOf Me.Precio_de_ventaLabel_Click
        '
        'ExistenciaLabel
        '
        ExistenciaLabel.AutoSize = True
        ExistenciaLabel.BackColor = System.Drawing.Color.Transparent
        ExistenciaLabel.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ExistenciaLabel.ForeColor = System.Drawing.Color.Black
        ExistenciaLabel.Location = New System.Drawing.Point(12, 309)
        ExistenciaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ExistenciaLabel.Name = "ExistenciaLabel"
        ExistenciaLabel.Size = New System.Drawing.Size(116, 34)
        ExistenciaLabel.TabIndex = 31
        ExistenciaLabel.Text = "Existencia:"
        AddHandler ExistenciaLabel.Click, AddressOf Me.ExistenciaLabel_Click
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.BackColor = System.Drawing.Color.Transparent
        FechaLabel.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.ForeColor = System.Drawing.Color.Black
        FechaLabel.Location = New System.Drawing.Point(14, 357)
        FechaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(76, 34)
        FechaLabel.TabIndex = 33
        FechaLabel.Text = "Fecha:"
        AddHandler FechaLabel.Click, AddressOf Me.FechaLabel_Click
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSalir.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnSalir.Location = New System.Drawing.Point(608, 798)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(264, 50)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.Control
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnVolver.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnVolver.Location = New System.Drawing.Point(263, 798)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(264, 50)
        Me.btnVolver.TabIndex = 17
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'InventarioBindingNavigator
        '
        Me.InventarioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InventarioBindingNavigator.BindingSource = Me.InventarioBindingSource
        Me.InventarioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InventarioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InventarioBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.InventarioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InventarioBindingNavigatorSaveItem})
        Me.InventarioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InventarioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InventarioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InventarioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InventarioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InventarioBindingNavigator.Name = "InventarioBindingNavigator"
        Me.InventarioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InventarioBindingNavigator.Size = New System.Drawing.Size(1163, 31)
        Me.InventarioBindingNavigator.TabIndex = 19
        Me.InventarioBindingNavigator.Text = "BindingNavigator1"
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
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataMember = "Inventario"
        Me.InventarioBindingSource.DataSource = Me.SuperTiendaDataSet
        '
        'SuperTiendaDataSet
        '
        Me.SuperTiendaDataSet.DataSetName = "SuperTiendaDataSet"
        Me.SuperTiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'InventarioBindingNavigatorSaveItem
        '
        Me.InventarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InventarioBindingNavigatorSaveItem.Image = CType(resources.GetObject("InventarioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InventarioBindingNavigatorSaveItem.Name = "InventarioBindingNavigatorSaveItem"
        Me.InventarioBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.InventarioBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'txtiddepa
        '
        Me.txtiddepa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Id Departamento", True))
        Me.txtiddepa.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiddepa.Location = New System.Drawing.Point(229, 40)
        Me.txtiddepa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtiddepa.Name = "txtiddepa"
        Me.txtiddepa.Size = New System.Drawing.Size(416, 35)
        Me.txtiddepa.TabIndex = 20
        '
        'txtdepa
        '
        Me.txtdepa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Departamento", True))
        Me.txtdepa.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepa.Location = New System.Drawing.Point(229, 84)
        Me.txtdepa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdepa.Name = "txtdepa"
        Me.txtdepa.Size = New System.Drawing.Size(416, 35)
        Me.txtdepa.TabIndex = 22
        '
        'txtclaveproducto
        '
        Me.txtclaveproducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Clave del producto", True))
        Me.txtclaveproducto.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclaveproducto.Location = New System.Drawing.Point(229, 127)
        Me.txtclaveproducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtclaveproducto.Name = "txtclaveproducto"
        Me.txtclaveproducto.Size = New System.Drawing.Size(416, 35)
        Me.txtclaveproducto.TabIndex = 24
        '
        'txtdescripcion
        '
        Me.txtdescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Descripción", True))
        Me.txtdescripcion.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(229, 172)
        Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(416, 35)
        Me.txtdescripcion.TabIndex = 26
        '
        'txtpreciocompra
        '
        Me.txtpreciocompra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Precio de compra", True))
        Me.txtpreciocompra.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpreciocompra.Location = New System.Drawing.Point(229, 216)
        Me.txtpreciocompra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpreciocompra.Name = "txtpreciocompra"
        Me.txtpreciocompra.Size = New System.Drawing.Size(416, 35)
        Me.txtpreciocompra.TabIndex = 28
        '
        'txtprecioventa
        '
        Me.txtprecioventa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Precio de venta", True))
        Me.txtprecioventa.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecioventa.Location = New System.Drawing.Point(229, 260)
        Me.txtprecioventa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprecioventa.Name = "txtprecioventa"
        Me.txtprecioventa.Size = New System.Drawing.Size(416, 35)
        Me.txtprecioventa.TabIndex = 30
        '
        'txtexistencia
        '
        Me.txtexistencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Existencia", True))
        Me.txtexistencia.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexistencia.Location = New System.Drawing.Point(229, 309)
        Me.txtexistencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(416, 35)
        Me.txtexistencia.TabIndex = 32
        '
        'txtfecha
        '
        Me.txtfecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InventarioBindingSource, "Fecha", True))
        Me.txtfecha.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha.Location = New System.Drawing.Point(229, 355)
        Me.txtfecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(416, 35)
        Me.txtfecha.TabIndex = 34
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGuardar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnGuardar.Location = New System.Drawing.Point(700, 191)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(411, 59)
        Me.btnGuardar.TabIndex = 35
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEliminar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnEliminar.Location = New System.Drawing.Point(700, 450)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(192, 60)
        Me.btnEliminar.TabIndex = 36
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBuscar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnBuscar.Location = New System.Drawing.Point(919, 450)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(192, 60)
        Me.btnBuscar.TabIndex = 40
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'InventarioDataGridView
        '
        Me.InventarioDataGridView.AutoGenerateColumns = False
        Me.InventarioDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.InventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.InventarioDataGridView.DataSource = Me.InventarioBindingSource
        Me.InventarioDataGridView.Location = New System.Drawing.Point(17, 624)
        Me.InventarioDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.InventarioDataGridView.Name = "InventarioDataGridView"
        Me.InventarioDataGridView.RowHeadersWidth = 51
        Me.InventarioDataGridView.Size = New System.Drawing.Size(1109, 143)
        Me.InventarioDataGridView.TabIndex = 40
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id Departamento"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Departamento"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Departamento"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Departamento"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Clave del producto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Clave del producto"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descripción"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Precio de compra"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio de compra"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Precio de venta"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Precio de venta"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Existencia"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Existencia"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'InventarioTableAdapter
        '
        Me.InventarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Me.InventarioTableAdapter
        Me.TableAdapterManager.PromocionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.SuperTiendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'lbldepa
        '
        Me.lbldepa.BackColor = System.Drawing.Color.Transparent
        Me.lbldepa.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldepa.ForeColor = System.Drawing.Color.Black
        Me.lbldepa.Location = New System.Drawing.Point(270, 42)
        Me.lbldepa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldepa.Name = "lbldepa"
        Me.lbldepa.Size = New System.Drawing.Size(700, 86)
        Me.lbldepa.TabIndex = 50
        Me.lbldepa.Text = "Inventario"
        Me.lbldepa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.Control
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnModificar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnModificar.Location = New System.Drawing.Point(919, 356)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(192, 60)
        Me.btnModificar.TabIndex = 52
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.SystemColors.Control
        Me.btnAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAlta.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnAlta.Location = New System.Drawing.Point(700, 356)
        Me.btnAlta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(192, 60)
        Me.btnAlta.TabIndex = 76
        Me.btnAlta.Text = "Alta de registros"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtiddepa)
        Me.GroupBox1.Controls.Add(Me.txtdepa)
        Me.GroupBox1.Controls.Add(DepartamentoLabel)
        Me.GroupBox1.Controls.Add(Id_DepartamentoLabel)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.txtprecioventa)
        Me.GroupBox1.Controls.Add(Precio_de_ventaLabel)
        Me.GroupBox1.Controls.Add(Me.txtpreciocompra)
        Me.GroupBox1.Controls.Add(Precio_de_compraLabel)
        Me.GroupBox1.Controls.Add(DescripciónLabel)
        Me.GroupBox1.Controls.Add(Me.txtclaveproducto)
        Me.GroupBox1.Controls.Add(ExistenciaLabel)
        Me.GroupBox1.Controls.Add(Clave_del_productoLabel)
        Me.GroupBox1.Controls.Add(Me.txtexistencia)
        Me.GroupBox1.Controls.Add(FechaLabel)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Font = New System.Drawing.Font("Gill Sans MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 407)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del producto"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnCancelar.Location = New System.Drawing.Point(700, 265)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(411, 59)
        Me.btnCancelar.TabIndex = 78
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1163, 869)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lbldepa)
        Me.Controls.Add(Me.InventarioDataGridView)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.InventarioBindingNavigator)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInventario"
        Me.Text = "Inventario"
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventarioBindingNavigator.ResumeLayout(False)
        Me.InventarioBindingNavigator.PerformLayout()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperTiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents SuperTiendaDataSet As WindowsApplication1.SuperTiendaDataSet
    Friend WithEvents InventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventarioTableAdapter As WindowsApplication1.SuperTiendaDataSetTableAdapters.InventarioTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.SuperTiendaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InventarioBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents InventarioBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtiddepa As System.Windows.Forms.TextBox
    Friend WithEvents txtdepa As System.Windows.Forms.TextBox
    Friend WithEvents txtclaveproducto As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciocompra As System.Windows.Forms.TextBox
    Friend WithEvents txtprecioventa As System.Windows.Forms.TextBox
    Friend WithEvents txtexistencia As System.Windows.Forms.TextBox
    Friend WithEvents txtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents InventarioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbldepa As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancelar As Button
End Class
