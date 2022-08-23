
namespace pryBDNeptuno_BINIA
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cmsPrincipal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnVerTablas = new System.Windows.Forms.Button();
            this.btnRegEmpleado = new System.Windows.Forms.Button();
            this.panelNeptuno = new System.Windows.Forms.Panel();
            this.lblNeptuno = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelForms = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelNeptuno.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsPrincipal
            // 
            this.cmsPrincipal.Name = "contextMenuStrip1";
            this.cmsPrincipal.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btnAyuda);
            this.panelMenu.Controls.Add(this.btnPedidos);
            this.panelMenu.Controls.Add(this.btnVerTablas);
            this.panelMenu.Controls.Add(this.btnRegEmpleado);
            this.panelMenu.Controls.Add(this.panelNeptuno);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 460);
            this.panelMenu.TabIndex = 1;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.Black;
            this.btnAyuda.Image = global::pryBDNeptuno_BINIA.Properties.Resources.Help_icon_icons_com_55891;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 225);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(200, 50);
            this.btnAyuda.TabIndex = 4;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.Black;
            this.btnPedidos.Image = global::pryBDNeptuno_BINIA.Properties.Resources.filter_filters_funnel_list_sort_sorting_tool_icon_123213;
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Location = new System.Drawing.Point(0, 175);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(200, 50);
            this.btnPedidos.TabIndex = 3;
            this.btnPedidos.Text = "Tabla de pedidos";
            this.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnVerTablas
            // 
            this.btnVerTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerTablas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerTablas.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnVerTablas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnVerTablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTablas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTablas.ForeColor = System.Drawing.Color.Black;
            this.btnVerTablas.Image = global::pryBDNeptuno_BINIA.Properties.Resources.database_5664;
            this.btnVerTablas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerTablas.Location = new System.Drawing.Point(0, 125);
            this.btnVerTablas.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnVerTablas.Name = "btnVerTablas";
            this.btnVerTablas.Size = new System.Drawing.Size(200, 50);
            this.btnVerTablas.TabIndex = 2;
            this.btnVerTablas.Text = "Ver Tablas";
            this.btnVerTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerTablas.UseVisualStyleBackColor = false;
            this.btnVerTablas.Click += new System.EventHandler(this.btnVerTablas_Click);
            // 
            // btnRegEmpleado
            // 
            this.btnRegEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRegEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRegEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnRegEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnRegEmpleado.Image")));
            this.btnRegEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegEmpleado.Location = new System.Drawing.Point(0, 75);
            this.btnRegEmpleado.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnRegEmpleado.Name = "btnRegEmpleado";
            this.btnRegEmpleado.Size = new System.Drawing.Size(200, 50);
            this.btnRegEmpleado.TabIndex = 1;
            this.btnRegEmpleado.Text = "Registrar empleado";
            this.btnRegEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegEmpleado.UseVisualStyleBackColor = false;
            this.btnRegEmpleado.Click += new System.EventHandler(this.btnRegEmpleado_Click);
            // 
            // panelNeptuno
            // 
            this.panelNeptuno.BackColor = System.Drawing.Color.Maroon;
            this.panelNeptuno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNeptuno.Controls.Add(this.lblNeptuno);
            this.panelNeptuno.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNeptuno.Location = new System.Drawing.Point(0, 0);
            this.panelNeptuno.Name = "panelNeptuno";
            this.panelNeptuno.Size = new System.Drawing.Size(200, 75);
            this.panelNeptuno.TabIndex = 0;
            // 
            // lblNeptuno
            // 
            this.lblNeptuno.AutoSize = true;
            this.lblNeptuno.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeptuno.ForeColor = System.Drawing.Color.White;
            this.lblNeptuno.Location = new System.Drawing.Point(53, 23);
            this.lblNeptuno.Name = "lblNeptuno";
            this.lblNeptuno.Size = new System.Drawing.Size(92, 25);
            this.lblNeptuno.TabIndex = 0;
            this.lblNeptuno.Text = "Neptuno";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(200, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(694, 75);
            this.panelTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(324, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(76, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "HOME";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelForms
            // 
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(200, 75);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(694, 385);
            this.panelForms.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 460);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEPTUNO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelNeptuno.ResumeLayout(false);
            this.panelNeptuno.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsPrincipal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnRegEmpleado;
        private System.Windows.Forms.Panel panelNeptuno;
        private System.Windows.Forms.Label lblNeptuno;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnVerTablas;
        public System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelForms;
    }
}