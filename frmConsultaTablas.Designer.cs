
namespace pryBDNeptuno_BINIA
{
    partial class frmConsultaTablas
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
            this.btnConsultarTablas = new System.Windows.Forms.Button();
            this.cboTablas = new System.Windows.Forms.ComboBox();
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.nEPTUNODataSet = new pryBDNeptuno_BINIA.NEPTUNODataSet();
            this.categoríasTableAdapter = new pryBDNeptuno_BINIA.NEPTUNODataSet1TableAdapters.CategoríasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEPTUNODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarTablas
            // 
            this.btnConsultarTablas.BackColor = System.Drawing.Color.Silver;
            this.btnConsultarTablas.Location = new System.Drawing.Point(206, 19);
            this.btnConsultarTablas.Name = "btnConsultarTablas";
            this.btnConsultarTablas.Size = new System.Drawing.Size(229, 39);
            this.btnConsultarTablas.TabIndex = 0;
            this.btnConsultarTablas.Text = "Consultar Tabla";
            this.btnConsultarTablas.UseVisualStyleBackColor = false;
            this.btnConsultarTablas.Click += new System.EventHandler(this.btnConsultarTablas_Click);
            // 
            // cboTablas
            // 
            this.cboTablas.BackColor = System.Drawing.Color.Silver;
            this.cboTablas.FormattingEnabled = true;
            this.cboTablas.Location = new System.Drawing.Point(12, 29);
            this.cboTablas.Name = "cboTablas";
            this.cboTablas.Size = new System.Drawing.Size(173, 21);
            this.cboTablas.TabIndex = 1;
            // 
            // dgvTablas
            // 
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.Location = new System.Drawing.Point(14, 74);
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.Size = new System.Drawing.Size(793, 379);
            this.dgvTablas.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 459);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(115, 29);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // nEPTUNODataSet
            // 
            this.nEPTUNODataSet.DataSetName = "NEPTUNODataSet";
            this.nEPTUNODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoríasTableAdapter
            // 
            this.categoríasTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultaTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(819, 500);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvTablas);
            this.Controls.Add(this.cboTablas);
            this.Controls.Add(this.btnConsultarTablas);
            this.Name = "frmConsultaTablas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de BD";
            this.Load += new System.EventHandler(this.frmConsultaTablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEPTUNODataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarTablas;
        private System.Windows.Forms.ComboBox cboTablas;
        private System.Windows.Forms.DataGridView dgvTablas;
        private System.Windows.Forms.Button btnVolver;
        private NEPTUNODataSet nEPTUNODataSet;
        private NEPTUNODataSet1TableAdapters.CategoríasTableAdapter categoríasTableAdapter;
    }
}

