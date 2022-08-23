
namespace pryBDNeptuno_BINIA
{
    partial class frmTabladePedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTablaPedidos = new System.Windows.Forms.DataGridView();
            this.btnFechas = new System.Windows.Forms.Button();
            this.btnCargo = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.gpbConsXNombre = new System.Windows.Forms.GroupBox();
            this.txtNombrePedido = new System.Windows.Forms.TextBox();
            this.gpbCargo = new System.Windows.Forms.GroupBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.gpbRangoFechas = new System.Windows.Forms.GroupBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.gpbUbicacion = new System.Windows.Forms.GroupBox();
            this.cboCP = new System.Windows.Forms.ComboBox();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPedidos)).BeginInit();
            this.gpbConsXNombre.SuspendLayout();
            this.gpbCargo.SuspendLayout();
            this.gpbRangoFechas.SuspendLayout();
            this.gpbUbicacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTablaPedidos
            // 
            this.dgvTablaPedidos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvTablaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaPedidos.Location = new System.Drawing.Point(9, 155);
            this.dgvTablaPedidos.Name = "dgvTablaPedidos";
            this.dgvTablaPedidos.Size = new System.Drawing.Size(869, 323);
            this.dgvTablaPedidos.TabIndex = 0;
            // 
            // btnFechas
            // 
            this.btnFechas.BackColor = System.Drawing.Color.White;
            this.btnFechas.Location = new System.Drawing.Point(202, 101);
            this.btnFechas.Name = "btnFechas";
            this.btnFechas.Size = new System.Drawing.Size(75, 23);
            this.btnFechas.TabIndex = 1;
            this.btnFechas.Text = "Consultar";
            this.btnFechas.UseVisualStyleBackColor = false;
            this.btnFechas.Click += new System.EventHandler(this.btnFechas_Click);
            // 
            // btnCargo
            // 
            this.btnCargo.BackColor = System.Drawing.Color.White;
            this.btnCargo.Location = new System.Drawing.Point(161, 30);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(75, 23);
            this.btnCargo.TabIndex = 2;
            this.btnCargo.Text = "Consultar";
            this.btnCargo.UseVisualStyleBackColor = false;
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarForeColor = System.Drawing.Color.Silver;
            this.dtpDesde.Location = new System.Drawing.Point(77, 24);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 21);
            this.dtpDesde.TabIndex = 4;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarForeColor = System.Drawing.Color.Silver;
            this.dtpHasta.Location = new System.Drawing.Point(77, 70);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 21);
            this.dtpHasta.TabIndex = 5;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // gpbConsXNombre
            // 
            this.gpbConsXNombre.Controls.Add(this.txtNombrePedido);
            this.gpbConsXNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConsXNombre.Location = new System.Drawing.Point(9, 8);
            this.gpbConsXNombre.Name = "gpbConsXNombre";
            this.gpbConsXNombre.Size = new System.Drawing.Size(245, 53);
            this.gpbConsXNombre.TabIndex = 6;
            this.gpbConsXNombre.TabStop = false;
            this.gpbConsXNombre.Text = "Por nombre de Cliente";
            this.gpbConsXNombre.Enter += new System.EventHandler(this.gpbConsXNombre_Enter);
            // 
            // txtNombrePedido
            // 
            this.txtNombrePedido.BackColor = System.Drawing.Color.Silver;
            this.txtNombrePedido.Location = new System.Drawing.Point(6, 24);
            this.txtNombrePedido.Name = "txtNombrePedido";
            this.txtNombrePedido.Size = new System.Drawing.Size(215, 21);
            this.txtNombrePedido.TabIndex = 4;
            this.txtNombrePedido.TextChanged += new System.EventHandler(this.txtNombrePedido_TextChanged);
            this.txtNombrePedido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombrePedido_KeyUp);
            // 
            // gpbCargo
            // 
            this.gpbCargo.Controls.Add(this.lblMax);
            this.gpbCargo.Controls.Add(this.lblMin);
            this.gpbCargo.Controls.Add(this.txtMin);
            this.gpbCargo.Controls.Add(this.txtMax);
            this.gpbCargo.Controls.Add(this.btnCargo);
            this.gpbCargo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCargo.Location = new System.Drawing.Point(12, 67);
            this.gpbCargo.Name = "gpbCargo";
            this.gpbCargo.Size = new System.Drawing.Size(242, 82);
            this.gpbCargo.TabIndex = 7;
            this.gpbCargo.TabStop = false;
            this.gpbCargo.Text = "Consulta por cargo mínimo y máximo $$";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(6, 48);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(34, 13);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "Max: ";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(6, 24);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(30, 13);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "Min: ";
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.Silver;
            this.txtMin.Location = new System.Drawing.Point(50, 19);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(105, 21);
            this.txtMin.TabIndex = 4;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.Silver;
            this.txtMax.Location = new System.Drawing.Point(50, 45);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(105, 21);
            this.txtMax.TabIndex = 3;
            // 
            // gpbRangoFechas
            // 
            this.gpbRangoFechas.Controls.Add(this.lblHasta);
            this.gpbRangoFechas.Controls.Add(this.lblDesde);
            this.gpbRangoFechas.Controls.Add(this.dtpHasta);
            this.gpbRangoFechas.Controls.Add(this.dtpDesde);
            this.gpbRangoFechas.Controls.Add(this.btnFechas);
            this.gpbRangoFechas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRangoFechas.Location = new System.Drawing.Point(273, 8);
            this.gpbRangoFechas.Name = "gpbRangoFechas";
            this.gpbRangoFechas.Size = new System.Drawing.Size(299, 141);
            this.gpbRangoFechas.TabIndex = 8;
            this.gpbRangoFechas.TabStop = false;
            this.gpbRangoFechas.Text = "Consulta por rango de fechas";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(30, 73);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(42, 13);
            this.lblHasta.TabIndex = 7;
            this.lblHasta.Text = "Hasta: ";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(30, 28);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(44, 13);
            this.lblDesde.TabIndex = 6;
            this.lblDesde.Text = "Desde: ";
            // 
            // gpbUbicacion
            // 
            this.gpbUbicacion.Controls.Add(this.lblCP);
            this.gpbUbicacion.Controls.Add(this.lblRegion);
            this.gpbUbicacion.Controls.Add(this.lblCiudad);
            this.gpbUbicacion.Controls.Add(this.lblPais);
            this.gpbUbicacion.Controls.Add(this.cboCP);
            this.gpbUbicacion.Controls.Add(this.cboRegion);
            this.gpbUbicacion.Controls.Add(this.cboCiudad);
            this.gpbUbicacion.Controls.Add(this.cboPais);
            this.gpbUbicacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbUbicacion.Location = new System.Drawing.Point(588, 8);
            this.gpbUbicacion.Name = "gpbUbicacion";
            this.gpbUbicacion.Size = new System.Drawing.Size(293, 141);
            this.gpbUbicacion.TabIndex = 9;
            this.gpbUbicacion.TabStop = false;
            this.gpbUbicacion.Text = "Consulta por ubicación";
            // 
            // cboCP
            // 
            this.cboCP.BackColor = System.Drawing.Color.Silver;
            this.cboCP.FormattingEnabled = true;
            this.cboCP.Location = new System.Drawing.Point(133, 103);
            this.cboCP.Name = "cboCP";
            this.cboCP.Size = new System.Drawing.Size(121, 21);
            this.cboCP.TabIndex = 11;
            this.cboCP.SelectedIndexChanged += new System.EventHandler(this.cboCP_SelectedIndexChanged);
            // 
            // cboRegion
            // 
            this.cboRegion.BackColor = System.Drawing.Color.Silver;
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(6, 103);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(121, 21);
            this.cboRegion.TabIndex = 10;
            this.cboRegion.SelectedIndexChanged += new System.EventHandler(this.cboRegion_SelectedIndexChanged);
            // 
            // cboCiudad
            // 
            this.cboCiudad.BackColor = System.Drawing.Color.Silver;
            this.cboCiudad.DisplayMember = "CiudadDestinatario";
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(132, 42);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(121, 21);
            this.cboCiudad.TabIndex = 4;
            this.cboCiudad.ValueMember = "CiudadDestinatario";
            this.cboCiudad.SelectedIndexChanged += new System.EventHandler(this.cboCiudad_SelectedIndexChanged);
            // 
            // cboPais
            // 
            this.cboPais.BackColor = System.Drawing.Color.Silver;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(6, 42);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(120, 21);
            this.cboPais.TabIndex = 2;
            this.cboPais.SelectedIndexChanged += new System.EventHandler(this.cboUbicacion_SelectedIndexChanged);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(6, 16);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 12;
            this.lblPais.Text = "País:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(130, 16);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(44, 13);
            this.lblCiudad.TabIndex = 13;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(6, 78);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 14;
            this.lblRegion.Text = "Región:";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(130, 78);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(76, 13);
            this.lblCP.TabIndex = 15;
            this.lblCP.Text = "Código postal:";
            this.lblCP.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmTabladePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(893, 490);
            this.Controls.Add(this.gpbUbicacion);
            this.Controls.Add(this.gpbRangoFechas);
            this.Controls.Add(this.gpbCargo);
            this.Controls.Add(this.gpbConsXNombre);
            this.Controls.Add(this.dgvTablaPedidos);
            this.Name = "frmTabladePedidos";
            this.Text = "Consulta - Tabla de pedidos";
            this.Load += new System.EventHandler(this.frmTabladePedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPedidos)).EndInit();
            this.gpbConsXNombre.ResumeLayout(false);
            this.gpbConsXNombre.PerformLayout();
            this.gpbCargo.ResumeLayout(false);
            this.gpbCargo.PerformLayout();
            this.gpbRangoFechas.ResumeLayout(false);
            this.gpbRangoFechas.PerformLayout();
            this.gpbUbicacion.ResumeLayout(false);
            this.gpbUbicacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaPedidos;
        private System.Windows.Forms.Button btnFechas;
        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.GroupBox gpbConsXNombre;
        private System.Windows.Forms.TextBox txtNombrePedido;
        private System.Windows.Forms.GroupBox gpbCargo;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.GroupBox gpbRangoFechas;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.GroupBox gpbUbicacion;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.ComboBox cboCP;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblPais;
    }
}