<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnExporta = New System.Windows.Forms.PictureBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasPorcatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NorthwindDataSet = New ExportacionExceldeDBVB.NorthwindDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBusca = New System.Windows.Forms.PictureBox()
        Me.VentasporVentascat = New ExportacionExceldeDBVB.NorthwindDataSetTableAdapters.ventasporVentascat()
        Me.TableAdapterManager = New ExportacionExceldeDBVB.NorthwindDataSetTableAdapters.TableAdapterManager()
        CType(Me.btnExporta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasPorcatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExporta
        '
        Me.btnExporta.Enabled = False
        Me.btnExporta.Location = New System.Drawing.Point(423, 12)
        Me.btnExporta.Name = "btnExporta"
        Me.btnExporta.Size = New System.Drawing.Size(53, 50)
        Me.btnExporta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnExporta.TabIndex = 0
        Me.btnExporta.TabStop = False
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AutoGenerateColumns = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategoriaDataGridViewTextBoxColumn, Me.ProductoDataGridViewTextBoxColumn, Me.VentaDataGridViewTextBoxColumn})
        Me.DGV.DataSource = Me.VentasPorcatBindingSource
        Me.DGV.Location = New System.Drawing.Point(12, 68)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(464, 370)
        Me.DGV.TabIndex = 1
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoriaDataGridViewTextBoxColumn.Width = 77
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductoDataGridViewTextBoxColumn.Width = 75
        '
        'VentaDataGridViewTextBoxColumn
        '
        Me.VentaDataGridViewTextBoxColumn.DataPropertyName = "Venta"
        Me.VentaDataGridViewTextBoxColumn.HeaderText = "Venta"
        Me.VentaDataGridViewTextBoxColumn.Name = "VentaDataGridViewTextBoxColumn"
        Me.VentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VentasPorcatBindingSource
        '
        Me.VentasPorcatBindingSource.DataMember = "VentasPorcat"
        Me.VentasPorcatBindingSource.DataSource = Me.NorthwindDataSet
        '
        'NorthwindDataSet
        '
        Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ventas por Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(346, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Busca y Exporta las ventas por categoria y producto"
        '
        'btnBusca
        '
        Me.btnBusca.Location = New System.Drawing.Point(364, 12)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(53, 50)
        Me.btnBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBusca.TabIndex = 4
        Me.btnBusca.TabStop = False
        '
        'VentasporVentascat
        '
        Me.VentasporVentascat.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CustomerCustomerDemoTableAdapter = Nothing
        Me.TableAdapterManager.CustomerDemographicsTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTerritoriesTableAdapter = Nothing
        Me.TableAdapterManager.Order_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.RegionTableAdapter = Nothing
        Me.TableAdapterManager.ShippersTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TerritoriesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ExportacionExceldeDBVB.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 450)
        Me.Controls.Add(Me.btnBusca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.btnExporta)
        Me.Name = "Form1"
        Me.Text = "Exportacion a Excel"
        CType(Me.btnExporta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasPorcatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBusca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExporta As PictureBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBusca As PictureBox
    Friend WithEvents NorthwindDataSet As NorthwindDataSet
    Friend WithEvents VentasPorcatBindingSource As BindingSource
    Friend WithEvents VentasporVentascat As NorthwindDataSetTableAdapters.ventasporVentascat
    Friend WithEvents TableAdapterManager As NorthwindDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
