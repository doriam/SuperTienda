<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.lblprecio = New System.Windows.Forms.Label()
        Me.lbldescrip = New System.Windows.Forms.Label()
        Me.txtseleccion = New System.Windows.Forms.TextBox()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.gridInventario = New System.Windows.Forms.DataGridView()
        Me.IdDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveDelProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDeCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDeVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuperTiendaDataSet = New WindowsApplication1.SuperTiendaDataSet()
        Me.InventarioTableAdapter = New WindowsApplication1.SuperTiendaDataSetTableAdapters.InventarioTableAdapter()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.listcuenta = New System.Windows.Forms.ListBox()
        Me.lbltootal = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblnumero = New System.Windows.Forms.Label()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnNueva = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.gridInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperTiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSalir.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnSalir.Location = New System.Drawing.Point(524, 687)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(264, 66)
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
        Me.btnVolver.Location = New System.Drawing.Point(178, 687)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(264, 66)
        Me.btnVolver.TabIndex = 17
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtcantidad.Location = New System.Drawing.Point(910, 315)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(137, 38)
        Me.txtcantidad.TabIndex = 22
        '
        'lblprecio
        '
        Me.lblprecio.AutoSize = True
        Me.lblprecio.BackColor = System.Drawing.Color.Transparent
        Me.lblprecio.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.lblprecio.ForeColor = System.Drawing.Color.Black
        Me.lblprecio.Location = New System.Drawing.Point(644, 315)
        Me.lblprecio.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblprecio.Name = "lblprecio"
        Me.lblprecio.Size = New System.Drawing.Size(0, 38)
        Me.lblprecio.TabIndex = 21
        '
        'lbldescrip
        '
        Me.lbldescrip.AutoSize = True
        Me.lbldescrip.BackColor = System.Drawing.Color.Transparent
        Me.lbldescrip.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.lbldescrip.ForeColor = System.Drawing.Color.Black
        Me.lbldescrip.Location = New System.Drawing.Point(139, 315)
        Me.lbldescrip.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbldescrip.Name = "lbldescrip"
        Me.lbldescrip.Size = New System.Drawing.Size(0, 38)
        Me.lbldescrip.TabIndex = 20
        '
        'txtseleccion
        '
        Me.txtseleccion.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtseleccion.Location = New System.Drawing.Point(10, 234)
        Me.txtseleccion.Margin = New System.Windows.Forms.Padding(5)
        Me.txtseleccion.Name = "txtseleccion"
        Me.txtseleccion.Size = New System.Drawing.Size(1039, 38)
        Me.txtseleccion.TabIndex = 19
        '
        'lblsubtotal
        '
        Me.lblsubtotal.AutoSize = True
        Me.lblsubtotal.BackColor = System.Drawing.Color.Transparent
        Me.lblsubtotal.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.lblsubtotal.ForeColor = System.Drawing.Color.Black
        Me.lblsubtotal.Location = New System.Drawing.Point(1252, 315)
        Me.lblsubtotal.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(0, 38)
        Me.lblsubtotal.TabIndex = 23
        '
        'gridInventario
        '
        Me.gridInventario.AutoGenerateColumns = False
        Me.gridInventario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.gridInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDepartamentoDataGridViewTextBoxColumn, Me.DepartamentoDataGridViewTextBoxColumn, Me.ClaveDelProductoDataGridViewTextBoxColumn, Me.DescripciónDataGridViewTextBoxColumn, Me.PrecioDeCompraDataGridViewTextBoxColumn, Me.PrecioDeVentaDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.gridInventario.DataSource = Me.InventarioBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridInventario.DefaultCellStyle = DataGridViewCellStyle6
        Me.gridInventario.Location = New System.Drawing.Point(10, 429)
        Me.gridInventario.Margin = New System.Windows.Forms.Padding(4)
        Me.gridInventario.Name = "gridInventario"
        Me.gridInventario.RowHeadersWidth = 51
        Me.gridInventario.Size = New System.Drawing.Size(876, 185)
        Me.gridInventario.TabIndex = 24
        '
        'IdDepartamentoDataGridViewTextBoxColumn
        '
        Me.IdDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "Id Departamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.HeaderText = "Id Departamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDepartamentoDataGridViewTextBoxColumn.Name = "IdDepartamentoDataGridViewTextBoxColumn"
        Me.IdDepartamentoDataGridViewTextBoxColumn.Width = 125
        '
        'DepartamentoDataGridViewTextBoxColumn
        '
        Me.DepartamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento"
        Me.DepartamentoDataGridViewTextBoxColumn.HeaderText = "Departamento"
        Me.DepartamentoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DepartamentoDataGridViewTextBoxColumn.Name = "DepartamentoDataGridViewTextBoxColumn"
        Me.DepartamentoDataGridViewTextBoxColumn.Width = 125
        '
        'ClaveDelProductoDataGridViewTextBoxColumn
        '
        Me.ClaveDelProductoDataGridViewTextBoxColumn.DataPropertyName = "Clave del producto"
        Me.ClaveDelProductoDataGridViewTextBoxColumn.HeaderText = "Clave del producto"
        Me.ClaveDelProductoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClaveDelProductoDataGridViewTextBoxColumn.Name = "ClaveDelProductoDataGridViewTextBoxColumn"
        Me.ClaveDelProductoDataGridViewTextBoxColumn.Width = 125
        '
        'DescripciónDataGridViewTextBoxColumn
        '
        Me.DescripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripciónDataGridViewTextBoxColumn.Name = "DescripciónDataGridViewTextBoxColumn"
        Me.DescripciónDataGridViewTextBoxColumn.Width = 125
        '
        'PrecioDeCompraDataGridViewTextBoxColumn
        '
        Me.PrecioDeCompraDataGridViewTextBoxColumn.DataPropertyName = "Precio de compra"
        Me.PrecioDeCompraDataGridViewTextBoxColumn.HeaderText = "Precio de compra"
        Me.PrecioDeCompraDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioDeCompraDataGridViewTextBoxColumn.Name = "PrecioDeCompraDataGridViewTextBoxColumn"
        Me.PrecioDeCompraDataGridViewTextBoxColumn.Width = 125
        '
        'PrecioDeVentaDataGridViewTextBoxColumn
        '
        Me.PrecioDeVentaDataGridViewTextBoxColumn.DataPropertyName = "Precio de venta"
        Me.PrecioDeVentaDataGridViewTextBoxColumn.HeaderText = "Precio de venta"
        Me.PrecioDeVentaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrecioDeVentaDataGridViewTextBoxColumn.Name = "PrecioDeVentaDataGridViewTextBoxColumn"
        Me.PrecioDeVentaDataGridViewTextBoxColumn.Width = 125
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        Me.ExistenciaDataGridViewTextBoxColumn.Width = 125
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 125
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
        'InventarioTableAdapter
        '
        Me.InventarioTableAdapter.ClearBeforeFill = True
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.SystemColors.Control
        Me.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSeleccionar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnSeleccionar.Location = New System.Drawing.Point(1080, 229)
        Me.btnSeleccionar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(264, 66)
        Me.btnSeleccionar.TabIndex = 25
        Me.btnSeleccionar.Text = "SELECCIONAR"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'listcuenta
        '
        Me.listcuenta.FormattingEnabled = True
        Me.listcuenta.ItemHeight = 16
        Me.listcuenta.Items.AddRange(New Object() {"Producto" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Precio" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "    Cantidad" & Global.Microsoft.VisualBasic.ChrW(9) & "    Subtotal"})
        Me.listcuenta.Location = New System.Drawing.Point(912, 486)
        Me.listcuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.listcuenta.MultiColumn = True
        Me.listcuenta.Name = "listcuenta"
        Me.listcuenta.Size = New System.Drawing.Size(601, 196)
        Me.listcuenta.TabIndex = 27
        '
        'lbltootal
        '
        Me.lbltootal.AutoSize = True
        Me.lbltootal.BackColor = System.Drawing.Color.Transparent
        Me.lbltootal.Font = New System.Drawing.Font("Gill Sans MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltootal.ForeColor = System.Drawing.Color.Black
        Me.lbltootal.Location = New System.Drawing.Point(1193, 706)
        Me.lbltootal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltootal.Name = "lbltootal"
        Me.lbltootal.Size = New System.Drawing.Size(120, 47)
        Me.lbltootal.TabIndex = 29
        Me.lbltootal.Text = "Total $"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BackColor = System.Drawing.Color.Transparent
        Me.lbltotal.Font = New System.Drawing.Font("Gill Sans MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.White
        Me.lbltotal.Location = New System.Drawing.Point(1388, 706)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(78, 47)
        Me.lbltotal.TabIndex = 28
        Me.lbltotal.Text = "0.00"
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.BackColor = System.Drawing.Color.Transparent
        Me.lblnumero.Font = New System.Drawing.Font("Gill Sans MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumero.ForeColor = System.Drawing.Color.Black
        Me.lblnumero.Location = New System.Drawing.Point(1022, 125)
        Me.lblnumero.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(37, 47)
        Me.lblnumero.TabIndex = 30
        Me.lblnumero.Text = "1"
        Me.lblnumero.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.SystemColors.Control
        Me.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnagregar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnagregar.Location = New System.Drawing.Point(1032, 412)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(359, 66)
        Me.btnagregar.TabIndex = 31
        Me.btnagregar.Text = "AGREGAR A LA CUENTA"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'btnNueva
        '
        Me.btnNueva.BackColor = System.Drawing.SystemColors.Control
        Me.btnNueva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNueva.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnNueva.Location = New System.Drawing.Point(10, 118)
        Me.btnNueva.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(264, 66)
        Me.btnNueva.TabIndex = 32
        Me.btnNueva.Text = "NUEVA VENTA"
        Me.btnNueva.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnCancelar.Location = New System.Drawing.Point(318, 118)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(305, 66)
        Me.btnCancelar.TabIndex = 33
        Me.btnCancelar.Text = "CANCELAR VENTA"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnguardar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnguardar.Location = New System.Drawing.Point(670, 118)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(264, 66)
        Me.btnguardar.TabIndex = 34
        Me.btnguardar.Text = "GUARDAR VENTA"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.ventas_icono
        Me.PictureBox2.Location = New System.Drawing.Point(1409, 92)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 114)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.icons_club
        Me.PictureBox1.Location = New System.Drawing.Point(1096, 92)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(659, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 60)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "VENTAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(517, 315)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 38)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Precio: $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(777, 315)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 38)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Cantidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 315)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 38)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Producto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1105, 315)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 38)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Subtotal: $"
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1533, 817)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.lblnumero)
        Me.Controls.Add(Me.lbltootal)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.listcuenta)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.gridInventario)
        Me.Controls.Add(Me.lblsubtotal)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.lblprecio)
        Me.Controls.Add(Me.lbldescrip)
        Me.Controls.Add(Me.txtseleccion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.gridInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperTiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblprecio As System.Windows.Forms.Label
    Friend WithEvents lbldescrip As System.Windows.Forms.Label
    Friend WithEvents txtseleccion As System.Windows.Forms.TextBox
    Friend WithEvents lblsubtotal As System.Windows.Forms.Label
    Friend WithEvents gridInventario As System.Windows.Forms.DataGridView
    Friend WithEvents SuperTiendaDataSet As WindowsApplication1.SuperTiendaDataSet
    Friend WithEvents InventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventarioTableAdapter As WindowsApplication1.SuperTiendaDataSetTableAdapters.InventarioTableAdapter
    Friend WithEvents IdDepartamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClaveDelProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDeCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDeVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents listcuenta As System.Windows.Forms.ListBox
    Friend WithEvents lbltootal As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lblnumero As System.Windows.Forms.Label
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
