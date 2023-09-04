namespace ExportacionExceldeDBC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBusca = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new ExportacionExceldeDBC.NorthwindDataSet();
            this.btnExporta = new System.Windows.Forms.PictureBox();
            this.ventascat = new ExportacionExceldeDBC.NorthwindDataSetTableAdapters.Ventascat();
            this.tableAdapterManager = new ExportacionExceldeDBC.NorthwindDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.btnBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExporta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(364, 12);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(53, 50);
            this.btnBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBusca.TabIndex = 9;
            this.btnBusca.TabStop = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(346, 19);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Busca y Exporta las ventas por categoria y producto";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(199, 24);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Ventas por Categoria";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoGenerateColumns = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoriaDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.ventaDataGridViewTextBoxColumn});
            this.DGV.DataSource = this.ventasBindingSource;
            this.DGV.Location = new System.Drawing.Point(12, 68);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(464, 370);
            this.DGV.TabIndex = 6;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriaDataGridViewTextBoxColumn.Width = 77;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoDataGridViewTextBoxColumn.Width = 75;
            // 
            // ventaDataGridViewTextBoxColumn
            // 
            this.ventaDataGridViewTextBoxColumn.DataPropertyName = "Venta";
            this.ventaDataGridViewTextBoxColumn.HeaderText = "Venta";
            this.ventaDataGridViewTextBoxColumn.Name = "ventaDataGridViewTextBoxColumn";
            this.ventaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExporta
            // 
            this.btnExporta.Enabled = false;
            this.btnExporta.Location = new System.Drawing.Point(423, 12);
            this.btnExporta.Name = "btnExporta";
            this.btnExporta.Size = new System.Drawing.Size(53, 50);
            this.btnExporta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExporta.TabIndex = 5;
            this.btnExporta.TabStop = false;
            this.btnExporta.Click += new System.EventHandler(this.btnExporta_Click);
            // 
            // ventascat
            // 
            this.ventascat.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ExportacionExceldeDBC.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btnExporta);
            this.Name = "Form1";
            this.Text = "Exportacion C a Excel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExporta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox btnBusca;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView DGV;
        internal System.Windows.Forms.PictureBox btnExporta;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private NorthwindDataSetTableAdapters.Ventascat ventascat;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaDataGridViewTextBoxColumn;
    }
}

