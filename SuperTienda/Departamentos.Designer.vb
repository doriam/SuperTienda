<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartamentos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.DepartamentosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.DepartamentosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtiddep = New System.Windows.Forms.TextBox()
        Me.txtdepartamento = New System.Windows.Forms.TextBox()
        Me.gridDepartamentos = New System.Windows.Forms.DataGridView()
        Me.IdDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.DepartamentosInventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbldepa = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.DepartamentosTableAdapter = New WindowsApplication1.SuperTiendaDataSetTableAdapters.DepartamentosTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.SuperTiendaDataSetTableAdapters.TableAdapterManager()
        Me.InventarioTableAdapter = New WindowsApplication1.SuperTiendaDataSetTableAdapters.InventarioTableAdapter()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Id_DepartamentoLabel = New System.Windows.Forms.Label()
        DepartamentoLabel = New System.Windows.Forms.Label()
        CType(Me.DepartamentosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DepartamentosBindingNavigator.SuspendLayout()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperTiendaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosInventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_DepartamentoLabel
        '
        Id_DepartamentoLabel.AutoSize = True
        Id_DepartamentoLabel.BackColor = System.Drawing.Color.Transparent
        Id_DepartamentoLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Id_DepartamentoLabel.ForeColor = System.Drawing.Color.Black
        Id_DepartamentoLabel.Location = New System.Drawing.Point(16, 254)
        Id_DepartamentoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_DepartamentoLabel.Name = "Id_DepartamentoLabel"
        Id_DepartamentoLabel.Size = New System.Drawing.Size(215, 38)
        Id_DepartamentoLabel.TabIndex = 19
        Id_DepartamentoLabel.Text = "Id Departamento:"
        '
        'DepartamentoLabel
        '
        DepartamentoLabel.AutoSize = True
        DepartamentoLabel.BackColor = System.Drawing.Color.Transparent
        DepartamentoLabel.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        DepartamentoLabel.ForeColor = System.Drawing.Color.Black
        DepartamentoLabel.Location = New System.Drawing.Point(16, 330)
        DepartamentoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DepartamentoLabel.Name = "DepartamentoLabel"
        DepartamentoLabel.Size = New System.Drawing.Size(186, 38)
        DepartamentoLabel.TabIndex = 21
        DepartamentoLabel.Text = "Departamento:"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSalir.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnSalir.Location = New System.Drawing.Point(760, 589)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(192, 66)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.Control
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnVolver.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnVolver.Location = New System.Drawing.Point(216, 589)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(192, 66)
        Me.btnVolver.TabIndex = 17
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'DepartamentosBindingNavigator
        '
        Me.DepartamentosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DepartamentosBindingNavigator.BindingSource = Me.DepartamentosBindingSource
        Me.DepartamentosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DepartamentosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DepartamentosBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DepartamentosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DepartamentosBindingNavigatorSaveItem})
        Me.DepartamentosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DepartamentosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DepartamentosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DepartamentosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DepartamentosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DepartamentosBindingNavigator.Name = "DepartamentosBindingNavigator"
        Me.DepartamentosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DepartamentosBindingNavigator.Size = New System.Drawing.Size(1069, 27)
        Me.DepartamentosBindingNavigator.TabIndex = 19
        Me.DepartamentosBindingNavigator.Text = "BindingNavigator1"
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
        'DepartamentosBindingSource
        '
        Me.DepartamentosBindingSource.DataMember = "Departamentos"
        Me.DepartamentosBindingSource.DataSource = Me.SuperTiendaDataSet
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
        'DepartamentosBindingNavigatorSaveItem
        '
        Me.DepartamentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DepartamentosBindingNavigatorSaveItem.Image = CType(resources.GetObject("DepartamentosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DepartamentosBindingNavigatorSaveItem.Name = "DepartamentosBindingNavigatorSaveItem"
        Me.DepartamentosBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.DepartamentosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'txtiddep
        '
        Me.txtiddep.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentosBindingSource, "Id Departamento", True))
        Me.txtiddep.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtiddep.Location = New System.Drawing.Point(241, 251)
        Me.txtiddep.Margin = New System.Windows.Forms.Padding(4)
        Me.txtiddep.Name = "txtiddep"
        Me.txtiddep.Size = New System.Drawing.Size(251, 38)
        Me.txtiddep.TabIndex = 20
        '
        'txtdepartamento
        '
        Me.txtdepartamento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DepartamentosBindingSource, "Departamento", True))
        Me.txtdepartamento.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.txtdepartamento.Location = New System.Drawing.Point(241, 330)
        Me.txtdepartamento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdepartamento.Name = "txtdepartamento"
        Me.txtdepartamento.Size = New System.Drawing.Size(251, 38)
        Me.txtdepartamento.TabIndex = 22
        '
        'gridDepartamentos
        '
        Me.gridDepartamentos.AutoGenerateColumns = False
        Me.gridDepartamentos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.gridDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDepartamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDepartamentoDataGridViewTextBoxColumn, Me.DepartamentoDataGridViewTextBoxColumn})
        Me.gridDepartamentos.DataSource = Me.DepartamentosBindingSource
        Me.gridDepartamentos.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gridDepartamentos.Location = New System.Drawing.Point(107, 387)
        Me.gridDepartamentos.Margin = New System.Windows.Forms.Padding(4)
        Me.gridDepartamentos.Name = "gridDepartamentos"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridDepartamentos.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridDepartamentos.RowHeadersWidth = 51
        Me.gridDepartamentos.Size = New System.Drawing.Size(385, 156)
        Me.gridDepartamentos.TabIndex = 23
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
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBuscar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnBuscar.Location = New System.Drawing.Point(794, 481)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(192, 60)
        Me.btnBuscar.TabIndex = 45
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEliminar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnEliminar.Location = New System.Drawing.Point(594, 481)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(192, 62)
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
        Me.btnGuardar.Location = New System.Drawing.Point(594, 254)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(392, 60)
        Me.btnGuardar.TabIndex = 41
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'DepartamentosInventarioBindingSource
        '
        Me.DepartamentosInventarioBindingSource.DataMember = "DepartamentosInventario"
        Me.DepartamentosInventarioBindingSource.DataSource = Me.DepartamentosBindingSource
        '
        'lbldepa
        '
        Me.lbldepa.BackColor = System.Drawing.Color.Transparent
        Me.lbldepa.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldepa.ForeColor = System.Drawing.Color.Black
        Me.lbldepa.Location = New System.Drawing.Point(181, 65)
        Me.lbldepa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldepa.Name = "lbldepa"
        Me.lbldepa.Size = New System.Drawing.Size(727, 121)
        Me.lbldepa.TabIndex = 49
        Me.lbldepa.Text = "Departamentos"
        Me.lbldepa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.Control
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnModificar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnModificar.Location = New System.Drawing.Point(794, 401)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(192, 60)
        Me.btnModificar.TabIndex = 50
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAlta
        '
        Me.btnAlta.BackColor = System.Drawing.SystemColors.Control
        Me.btnAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAlta.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnAlta.Location = New System.Drawing.Point(594, 401)
        Me.btnAlta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(192, 60)
        Me.btnAlta.TabIndex = 51
        Me.btnAlta.Text = "Alta de registros"
        Me.btnAlta.UseVisualStyleBackColor = False
        '
        'DepartamentosTableAdapter
        '
        Me.DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepartamentosTableAdapter = Me.DepartamentosTableAdapter
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Me.InventarioTableAdapter
        Me.TableAdapterManager.PromocionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.SuperTiendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'InventarioTableAdapter
        '
        Me.InventarioTableAdapter.ClearBeforeFill = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelar.Font = New System.Drawing.Font("Gill Sans MT", 15.75!)
        Me.btnCancelar.Location = New System.Drawing.Point(594, 330)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(392, 60)
        Me.btnCancelar.TabIndex = 52
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmDepartamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1069, 667)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lbldepa)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gridDepartamentos)
        Me.Controls.Add(Id_DepartamentoLabel)
        Me.Controls.Add(Me.txtiddep)
        Me.Controls.Add(DepartamentoLabel)
        Me.Controls.Add(Me.txtdepartamento)
        Me.Controls.Add(Me.DepartamentosBindingNavigator)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDepartamentos"
        Me.Text = "Departamentos"
        CType(Me.DepartamentosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DepartamentosBindingNavigator.ResumeLayout(False)
        Me.DepartamentosBindingNavigator.PerformLayout()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperTiendaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosInventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents SuperTiendaDataSet As WindowsApplication1.SuperTiendaDataSet
    Friend WithEvents DepartamentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartamentosTableAdapter As WindowsApplication1.SuperTiendaDataSetTableAdapters.DepartamentosTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.SuperTiendaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepartamentosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DepartamentosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents InventarioTableAdapter As WindowsApplication1.SuperTiendaDataSetTableAdapters.InventarioTableAdapter
    Friend WithEvents txtiddep As System.Windows.Forms.TextBox
    Friend WithEvents txtdepartamento As System.Windows.Forms.TextBox
    Friend WithEvents gridDepartamentos As System.Windows.Forms.DataGridView
    Friend WithEvents DepartamentosInventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdDepartamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lbldepa As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As Button
End Class
