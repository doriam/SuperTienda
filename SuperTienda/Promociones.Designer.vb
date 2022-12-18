<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromociones
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
        Dim Id_de_promociónLabel As System.Windows.Forms.Label
        Dim DeparmentoLabel As System.Windows.Forms.Label
        Dim PromociónLabel As System.Windows.Forms.Label
        Dim ProductoLabel As System.Windows.Forms.Label
        Dim Precio_unitarioLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim SubtotalLabel As System.Windows.Forms.Label
        Dim DescuentoLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPromociones))
        Me.PromocionesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.PromocionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.PromocionesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtpromo = New System.Windows.Forms.TextBox()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.txtpreciounitario = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.PromocionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblpromo = New System.Windows.Forms.Label()
        Me.PromocionesTableAdapter = New WindowsApplication1.SuperTiendaDataSetTableAdapters.PromocionesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.SuperTiendaDataSetTableAdapters.TableAdapterManager()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Id_de_promociónLabel = New System.Windows.Forms.Label()
        DeparmentoLabel = New System.Windows.Forms.Label()
        PromociónLabel = New System.Windows.Forms.Label()
        ProductoLabel = New System.Windows.Forms.Label()
        Precio_unitarioLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        SubtotalLabel = New System.Windows.Forms.Label()
        DescuentoLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.PromocionesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PromocionesBindingNavigator.SuspendLayout()
        CType(Me.PromocionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperTiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromocionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_de_promociónLabel
        '
        Id_de_promociónLabel.AutoSize = True
        Id_de_promociónLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Id_de_promociónLabel.Location = New System.Drawing.Point(20, 43)
        Id_de_promociónLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_de_promociónLabel.Name = "Id_de_promociónLabel"
        Id_de_promociónLabel.Size = New System.Drawing.Size(210, 38)
        Id_de_promociónLabel.TabIndex = 1
        Id_de_promociónLabel.Text = "Id de promoción:"
        '
        'DeparmentoLabel
        '
        DeparmentoLabel.AutoSize = True
        DeparmentoLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        DeparmentoLabel.Location = New System.Drawing.Point(20, 87)
        DeparmentoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DeparmentoLabel.Name = "DeparmentoLabel"
        DeparmentoLabel.Size = New System.Drawing.Size(186, 38)
        DeparmentoLabel.TabIndex = 3
        DeparmentoLabel.Text = "Departamento:"
        '
        'PromociónLabel
        '
        PromociónLabel.AutoSize = True
        PromociónLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        PromociónLabel.Location = New System.Drawing.Point(19, 133)
        PromociónLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PromociónLabel.Name = "PromociónLabel"
        PromociónLabel.Size = New System.Drawing.Size(146, 38)
        PromociónLabel.TabIndex = 5
        PromociónLabel.Text = "Promoción:"
        '
        'ProductoLabel
        '
        ProductoLabel.AutoSize = True
        ProductoLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        ProductoLabel.Location = New System.Drawing.Point(19, 176)
        ProductoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProductoLabel.Name = "ProductoLabel"
        ProductoLabel.Size = New System.Drawing.Size(127, 38)
        ProductoLabel.TabIndex = 7
        ProductoLabel.Text = "Producto:"
        '
        'Precio_unitarioLabel
        '
        Precio_unitarioLabel.AutoSize = True
        Precio_unitarioLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Precio_unitarioLabel.Location = New System.Drawing.Point(19, 218)
        Precio_unitarioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Precio_unitarioLabel.Name = "Precio_unitarioLabel"
        Precio_unitarioLabel.Size = New System.Drawing.Size(189, 38)
        Precio_unitarioLabel.TabIndex = 9
        Precio_unitarioLabel.Text = "Precio unitario:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        CantidadLabel.Location = New System.Drawing.Point(19, 262)
        CantidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(123, 38)
        CantidadLabel.TabIndex = 11
        CantidadLabel.Text = "Cantidad:"
        '
        'SubtotalLabel
        '
        SubtotalLabel.AutoSize = True
        SubtotalLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        SubtotalLabel.Location = New System.Drawing.Point(19, 304)
        SubtotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SubtotalLabel.Name = "SubtotalLabel"
        SubtotalLabel.Size = New System.Drawing.Size(114, 38)
        SubtotalLabel.TabIndex = 13
        SubtotalLabel.Text = "Subtotal:"
        '
        'DescuentoLabel
        '
        DescuentoLabel.AutoSize = True
        DescuentoLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        DescuentoLabel.Location = New System.Drawing.Point(19, 346)
        DescuentoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescuentoLabel.Name = "DescuentoLabel"
        DescuentoLabel.Size = New System.Drawing.Size(143, 38)
        DescuentoLabel.TabIndex = 15
        DescuentoLabel.Text = "Descuento:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        TotalLabel.Location = New System.Drawing.Point(19, 388)
        TotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(81, 38)
        TotalLabel.TabIndex = 17
        TotalLabel.Text = "Total:"
        '
        'PromocionesBindingNavigator
        '
        Me.PromocionesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PromocionesBindingNavigator.BindingSource = Me.PromocionesBindingSource
        Me.PromocionesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PromocionesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PromocionesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PromocionesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PromocionesBindingNavigatorSaveItem})
        Me.PromocionesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PromocionesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PromocionesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PromocionesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PromocionesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PromocionesBindingNavigator.Name = "PromocionesBindingNavigator"
        Me.PromocionesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PromocionesBindingNavigator.Size = New System.Drawing.Size(1125, 27)
        Me.PromocionesBindingNavigator.TabIndex = 0
        Me.PromocionesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'PromocionesBindingSource
        '
        Me.PromocionesBindingSource.DataMember = "Promociones"
        Me.PromocionesBindingSource.DataSource = Me.SuperTiendaDataSet
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
        'PromocionesBindingNavigatorSaveItem
        '
        Me.PromocionesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PromocionesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PromocionesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PromocionesBindingNavigatorSaveItem.Name = "PromocionesBindingNavigatorSaveItem"
        Me.PromocionesBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.PromocionesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'txtid
        '
        Me.txtid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PromocionesBindingSource, "Id de promoción", True))
        Me.txtid.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtid.Location = New System.Drawing.Point(241, 39)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(288, 38)
        Me.txtid.TabIndex = 2
        '
        'txtpromo
        '
        Me.txtpromo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PromocionesBindingSource, "Promoción", True))
        Me.txtpromo.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtpromo.Location = New System.Drawing.Point(240, 129)
        Me.txtpromo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpromo.Name = "txtpromo"
        Me.txtpromo.Size = New System.Drawing.Size(288, 38)
        Me.txtpromo.TabIndex = 6
        '
        'txtproducto
        '
        Me.txtproducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PromocionesBindingSource, "Producto", True))
        Me.txtproducto.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtproducto.Location = New System.Drawing.Point(240, 172)
        Me.txtproducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(288, 38)
        Me.txtproducto.TabIndex = 8
        '
        'txtpreciounitario
        '
        Me.txtpreciounitario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PromocionesBindingSource, "Precio unitario", True))
        Me.txtpreciounitario.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtpreciounitario.Location = New System.Drawing.Point(240, 214)
        Me.txtpreciounitario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpreciounitario.Name = "txtpreciounitario"
        Me.txtpreciounitario.Size = New System.Drawing.Size(288, 38)
        Me.txtpreciounitario.TabIndex = 10
        '
        'txtcantidad
        '
        Me.txtcantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PromocionesBindingSource, "Cantidad", True))
        Me.txtcantidad.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtcantidad.Location = New System.Drawing.Point(240, 258)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(288, 38)
        Me.txtcantidad.TabIndex = 12
        '
        'txtsubtotal
        '
        Me.txtsubtotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PromocionesBindingSource, "Subtotal", True))
        Me.txtsubtotal.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtsubtotal.Location = New System.Drawing.Point(240, 300)
        Me.txtsubtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(288, 38)
        Me.txtsubtotal.TabIndex = 14
        '
        'txtdescuento
        '
        Me.txtdescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PromocionesBindingSource, "Descuento", True))
        Me.txtdescuento.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtdescuento.Location = New System.Drawing.Point(240, 342)
        Me.txtdescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(288, 38)
        Me.txtdescuento.TabIndex = 16
        '
        'txttotal
        '
        Me.txttotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PromocionesBindingSource, "Total", True))
        Me.txttotal.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txttotal.Location = New System.Drawing.Point(240, 384)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(288, 38)
        Me.txttotal.TabIndex = 18
        '
        'PromocionesDataGridView
        '
        Me.PromocionesDataGridView.AutoGenerateColumns = False
        Me.PromocionesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.PromocionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PromocionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PromocionesDataGridView.DataSource = Me.PromocionesBindingSource
        Me.PromocionesDataGridView.Location = New System.Drawing.Point(42, 588)
        Me.PromocionesDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PromocionesDataGridView.Name = "PromocionesDataGridView"
        Me.PromocionesDataGridView.RowHeadersWidth = 51
        Me.PromocionesDataGridView.Size = New System.Drawing.Size(1036, 164)
        Me.PromocionesDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id de promoción"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id de promoción"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Deparmento"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Deparmento"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Promoción"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Promoción"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Producto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Precio unitario"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio unitario"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Subtotal"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Descuento"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Descuento"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSalir.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnSalir.Location = New System.Drawing.Point(721, 762)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(264, 66)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.Control
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnVolver.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnVolver.Location = New System.Drawing.Point(120, 760)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(264, 66)
        Me.btnVolver.TabIndex = 20
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(DeparmentoLabel)
        Me.GroupBox1.Controls.Add(Me.txttotal)
        Me.GroupBox1.Controls.Add(TotalLabel)
        Me.GroupBox1.Controls.Add(Me.txtdescuento)
        Me.GroupBox1.Controls.Add(Id_de_promociónLabel)
        Me.GroupBox1.Controls.Add(DescuentoLabel)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.txtsubtotal)
        Me.GroupBox1.Controls.Add(SubtotalLabel)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(PromociónLabel)
        Me.GroupBox1.Controls.Add(CantidadLabel)
        Me.GroupBox1.Controls.Add(Me.txtpromo)
        Me.GroupBox1.Controls.Add(Me.txtpreciounitario)
        Me.GroupBox1.Controls.Add(ProductoLabel)
        Me.GroupBox1.Controls.Add(Precio_unitarioLabel)
        Me.GroupBox1.Controls.Add(Me.txtproducto)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(42, 130)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(568, 436)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Promociones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-7, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 36)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Promociones"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBuscar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnBuscar.Location = New System.Drawing.Point(886, 461)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(192, 66)
        Me.btnBuscar.TabIndex = 46
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEliminar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnEliminar.Location = New System.Drawing.Point(631, 461)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(192, 66)
        Me.btnEliminar.TabIndex = 42
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGuardar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnGuardar.Location = New System.Drawing.Point(631, 169)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(447, 66)
        Me.btnGuardar.TabIndex = 41
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblpromo
        '
        Me.lblpromo.BackColor = System.Drawing.Color.Transparent
        Me.lblpromo.Font = New System.Drawing.Font("Gill Sans MT", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpromo.ForeColor = System.Drawing.Color.Black
        Me.lblpromo.Location = New System.Drawing.Point(301, 44)
        Me.lblpromo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpromo.Name = "lblpromo"
        Me.lblpromo.Size = New System.Drawing.Size(604, 61)
        Me.lblpromo.TabIndex = 48
        Me.lblpromo.Text = "Promociones"
        Me.lblpromo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PromocionesTableAdapter
        '
        Me.PromocionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepartamentosTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Nothing
        Me.TableAdapterManager.PromocionesTableAdapter = Me.PromocionesTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.SuperTiendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.Control
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnModificar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnModificar.Location = New System.Drawing.Point(886, 350)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(192, 66)
        Me.btnModificar.TabIndex = 51
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.SystemColors.Control
        Me.btnAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAlta.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnAlta.Location = New System.Drawing.Point(631, 356)
        Me.btnAlta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(192, 70)
        Me.btnAlta.TabIndex = 77
        Me.btnAlta.Text = "Alta de registros"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnCancelar.Location = New System.Drawing.Point(631, 263)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(447, 66)
        Me.btnCancelar.TabIndex = 78
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(239, 81)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(289, 43)
        Me.ComboBox1.TabIndex = 79
        '
        'frmPromociones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1125, 839)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblpromo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.PromocionesDataGridView)
        Me.Controls.Add(Me.PromocionesBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPromociones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promociones"
        CType(Me.PromocionesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PromocionesBindingNavigator.ResumeLayout(False)
        Me.PromocionesBindingNavigator.PerformLayout()
        CType(Me.PromocionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperTiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromocionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SuperTiendaDataSet As WindowsApplication1.SuperTiendaDataSet
    Friend WithEvents PromocionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PromocionesTableAdapter As WindowsApplication1.SuperTiendaDataSetTableAdapters.PromocionesTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.SuperTiendaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PromocionesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PromocionesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtpromo As System.Windows.Forms.TextBox
    Friend WithEvents txtproducto As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciounitario As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtsubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtdescuento As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents PromocionesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblpromo As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
