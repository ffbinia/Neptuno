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


    public partial class frmConsultaTablas : Form
    {
        public frmConsultaTablas()
        {
            InitializeComponent();
        }


        //DECLARACION DE VARIABLES Y OBJETOS
        //CREAR OBJETOS PARA LA CONEXION A LA BD
        OleDbConnection objConexion;
        OleDbCommand objComando;
        OleDbDataAdapter objAdaptador;
        string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";

        private void frmConsultaTablas_Load(object sender, EventArgs e)
        {
            objAdaptador = new OleDbDataAdapter();
            objComando = new OleDbCommand();

            try
            {
                using (objConexion = new OleDbConnection(connectionString));
                {
                    objConexion.ConnectionString = connectionString;
                    objConexion.Open();              

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
            cboTablas.Items.Add("Categorías");
            cboTablas.Items.Add("Clientes");
            cboTablas.Items.Add("Detalles de pedidos");
            cboTablas.Items.Add("Empleados");
            cboTablas.Items.Add("Pedidos");
            cboTablas.Items.Add("Productos");
            cboTablas.Items.Add("Proveedores");
        }

        private void btnConsultarTablas_Click(object sender, EventArgs e)
        {

            if (cboTablas.Text == "")
            {
                MessageBox.Show("Seleccione la tabla que desea consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTablas.Focus();
            }
            else

            {

                objComando.Connection = objConexion;
                objComando.CommandType = CommandType.TableDirect;
                objComando.CommandText = cboTablas.Text;

                objAdaptador = new OleDbDataAdapter(objComando);
                DataTable dt = new DataTable();

                objAdaptador.Fill(dt);
                dgvTablas.DataSource = dt;

            }
   
        }
            
        

            private void btnVolver_Click(object sender, EventArgs e)
            {   
                this.Hide();
            }
        }
    } 
