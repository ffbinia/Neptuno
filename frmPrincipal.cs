using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace pryBDNeptuno_BINIA
{
    public partial class frmPrincipal : Form
    {
        private Button click;
        private Form formActivo;

        OleDbCommand comando;
        OleDbConnection conex;
        OleDbDataAdapter adaptador;
        string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tablaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaTablas frmConsulta = new frmConsultaTablas();
            
            frmConsulta.ShowDialog();

        }

        private void registroDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarEmpleado Empleado = new frmRegistrarEmpleado();
            Empleado.ShowDialog();

        }

        private void tablaDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTabladePedidos frm = new frmTabladePedidos();
            frm.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = DateTime.Now.ToString("F");

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            adaptador = new OleDbDataAdapter();
            comando = new OleDbCommand();

            try
            {
                using (conex = new OleDbConnection(connectionString)) ;
                {
                    conex.ConnectionString = connectionString;
                    conex.Open();

                    MessageBox.Show("Bienvenido a NeptunoDB", "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);              
            }
        }

        private void BotonActivo(object btnSender)
        {
            if (btnSender != null)
            {
                if (click != (Button)btnSender)
                {
                    Antesbtn();
                    click = (Button)btnSender;
                    click.BackColor = Color.Gray;
                    click.Font = new Font("Malgun Gothic", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void Antesbtn()
        {
            foreach (Control btnAntes in panelMenu.Controls)
            {
                if (btnAntes.GetType() == typeof(Button))
                {
                    btnAntes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                    btnAntes.Font = new Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenForm(Form form, object btnSender)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            BotonActivo(btnSender);
            formActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panelForms.Controls.Add(form);
            this.panelForms.Tag = form;
            form.BringToFront();
            form.Show();
            lblTitulo.Text = form.Text;
        }

        private void btnRegEmpleado_Click(object sender, EventArgs e)
        {
            OpenForm(new frmRegistrarEmpleado(), sender);
        }

        private void btnVerTablas_Click(object sender, EventArgs e)
        {
            OpenForm(new frmConsultaTablas(), sender);

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            OpenForm(new frmTabladePedidos(), sender);

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            BotonActivo(sender);

        }
    }
}
