using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;



namespace pryBDNeptuno_BINIA
{
    public partial class frmRegistrarEmpleado : Form
    {
        OleDbConnection conex;
        OleDbCommand comando;
        OleDbDataAdapter adapter;
        string ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";

        public frmRegistrarEmpleado()
        {
            InitializeComponent();

            conex = new OleDbConnection();
            comando = new OleDbCommand();
            adapter = new OleDbDataAdapter();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrarEmpleado_Load(object sender, EventArgs e)
        {

            txtNombre.Focus();
            if (conex.State != ConnectionState.Open)
            {
                try
                {
                    comando.Connection = conex;
                    conex.ConnectionString = ruta;
                    conex.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
                comando = new OleDbCommand("SELECT DISTINCT Jefe FROM Empleados", conex);
                adapter = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adapter.SelectCommand = comando;
                adapter.Fill(ds, "Empleados");

                cboJefe.DataSource = ds.Tables["Empleados"];
                cboJefe.DisplayMember = "Jefe";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            DialogResult d = MessageBox.Show("¿Desea volver al menú principal?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (d == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            int dias = DateTime.Now.Date.Subtract(dtpFechaNac.Value.Date).Days;
            int años = dias / 365;
            if (txtNombre.Text == "" | txtApellido.Text == "" | txtCargo.Text == "" | txtTratamiento.Text == "" | txtDirecc.Text == "" | txtCiudad.Text == "" | txtRegion.Text == "" | txtCP.Text == "" | txtPais.Text == "" | txtTel.Text == "" | txtExtension.Text == "" | txtNotas.Text == "" | cboJefe.Text == "---Seleccione un item---" | cboJefe.Text == "" | cboJefe.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (dtpFechaNac.MinDate >= DateTime.Today | dtpFechaCont.MinDate >= DateTime.Today)
            {
                MessageBox.Show("Ingrese fechas válidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (ptbFotoEmpleado.Image == null)
            {
                MessageBox.Show("No se olvide la imagen del empleado", "Espere", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (años < 18)
                {
                {
                    MessageBox.Show("El empleado no puede ser menor de 18 años", "Edad", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                try
                {
    
                    string registro = "INSERT INTO Empleados (Apellidos, Nombre, Cargo, Tratamiento, FechaNacimiento," +
                        " FechaContratación, Dirección, Ciudad, Región, CódPostal, País, TelDomicilio, Extensión, Foto, Notas, Jefe) VALUES" +
                        " ('" + txtApellido.Text + "','" + txtNombre.Text + "','"
                        + txtCargo.Text + "','" + txtTratamiento.Text + "','" + dtpFechaNac.Value + "','"
                        + dtpFechaCont.Value + "','" + txtDirecc.Text + "','" + txtCiudad.Text
                        + "','" + txtRegion.Text + "','" + txtCP.Text + "','"
                        + txtPais.Text + "','" + txtTel.Text + "','"
                        + txtExtension.Text + "','"
                        + ptbFotoEmpleado.Image + "','" + txtNotas.Text + "','" + cboJefe.Text
                        + "')";

                    comando = new OleDbCommand(registro, conex);

                    comando.ExecuteNonQuery();
                    
                    MessageBox.Show("¡Datos cargados!", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtApellido.Text = "";
                    txtNombre.Text = "";
                    txtExtension.Text = "";
                    txtCargo.Text = "";
                    txtCiudad.Text = "";
                    txtCP.Text = "";
                    txtDirecc.Text = "";
                    txtTel.Text = "";
                    txtTratamiento.Text = "";
                    txtRegion.Text = "";
                    txtPais.Text = "";
                    cboJefe.Text = "";
                    dtpFechaCont.Value = DateTime.Today;
                        dtpFechaNac.Value = DateTime.Today;
                    ptbFotoEmpleado.Image = null;
                    txtNotas.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void ptbFotoEmpleado_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                ptbFotoEmpleado.ImageLocation = BuscarImagen.FileName;
            }
        }

        private void txtNotas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerTabla_Click(object sender, EventArgs e)
        {
            this.Height = 700;
            if (conex.State != ConnectionState.Open)
            {
                conex.ConnectionString = ruta;
                conex.Open();
            }
            comando.Connection = conex;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Empleados";
            adapter = new OleDbDataAdapter(comando);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            
            dgvEmpleado.DataSource = dt;

            
            conex.Close();
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaNac.Value > DateTime.Now)
            {
                MessageBox.Show("No puede ingresar una fecha futura", "Espere", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dtpFechaNac.Value = DateTime.Today;
            }
        }

        private void dtpFechaCont_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaCont.Value > DateTime.Today)

            {
                MessageBox.Show("Ingrese una fecha válida");
                dtpFechaCont.Value = DateTime.Today;
            }
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            txtTel.MaxLength = 13;
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) | char.IsSeparator(e.KeyChar) | char.IsSymbol(e.KeyChar) | char.IsPunctuation(e.KeyChar) | char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dígitos permitidos únicamente");

            }
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtExtension.Text = "";
            txtCargo.Text = "";
            txtCiudad.Text = "";
            txtCP.Text = "";
            txtDirecc.Text = "";
            txtTel.Text = "";
            txtTratamiento.Text = "";
            txtRegion.Text = "";
            txtPais.Text = "";
            cboJefe.Text = "";
            dtpFechaCont.Value = DateTime.Today;
            dtpFechaNac.Value = DateTime.Today;
            ptbFotoEmpleado.Image = null;
            txtNotas.Text = "";
        }

        private void txtExtension_TextChanged(object sender, EventArgs e)
        {
            txtExtension.MaxLength = 4;
        }

        private void txtCP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTratamiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExtension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) | char.IsSeparator(e.KeyChar) | char.IsSymbol(e.KeyChar) | char.IsPunctuation(e.KeyChar) | char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dígitos permitidos únicamente");
            }
        }
    }
}
