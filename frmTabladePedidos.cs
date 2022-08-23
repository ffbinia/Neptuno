using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryBDNeptuno_BINIA
{
    public partial class frmTabladePedidos : Form
    {

        OleDbDataAdapter adapter;
        OleDbCommand Comando;
        OleDbDataReader dr;

        public frmTabladePedidos()
        {
            InitializeComponent();
        }
        string ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";

        OleDbConnection objconector = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb");
        private void cboUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection objconector = new OleDbConnection(ruta);
            objconector.Open();

            OleDbCommand Comando = new OleDbCommand("SELECT * FROM Pedidos where PaísDestinatario like '" + cboPais.Text + "'", objconector);

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(Comando);

            da.Fill(dt);

            dgvTablaPedidos.DataSource = dt;

            objconector.Close();

        }

        public void frmTabladePedidos_Load(object sender, EventArgs e)
        {
            Comando = new OleDbCommand();

            try
            {
                using (objconector = new OleDbConnection(ruta))
                {
                    objconector.ConnectionString = ruta;
                    objconector.Open();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            objconector.ConnectionString = ruta;
            Comando.Connection = objconector;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "SELECT * FROM Pedidos";
                        
            objconector.Open();
            
            dr = Comando.ExecuteReader();

            while (dr.Read())
            {
                if (!cboCiudad.Items.Contains(dr["CiudadDestinatario"].ToString())) { cboCiudad.Items.Add(dr["CiudadDestinatario"].ToString()); }
                if (!cboRegion.Items.Contains(dr["RegiónDestinatario"].ToString()) & dr["RegiónDestinatario"].ToString() != "") { cboRegion.Items.Add(dr["RegiónDestinatario"].ToString()); }
                if (!cboCP.Items.Contains(dr["CódPostalDestinatario"].ToString()) & dr["CódPostalDestinatario"].ToString() != "") { cboCP.Items.Add(dr["CódPostalDestinatario"].ToString()); }
                if (!cboPais.Items.Contains(dr["PaísDestinatario"].ToString())) { cboPais.Items.Add(dr["PaísDestinatario"].ToString()); }

            }
            dr.Close();
            
            adapter = new OleDbDataAdapter(Comando);
            DataTable dt = new DataTable();

            adapter.SelectCommand = Comando;
            adapter.Fill(dt);
            dgvTablaPedidos.DataSource = dt;
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            if (objconector.State != ConnectionState.Open)
            {
                objconector.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                objconector.Open();
            }

            //if (txtMin.Text = "" | txtMax.Text = "")
                string min = txtMin.Text;
                string max = txtMax.Text;

                OleDbCommand cmd = objconector.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Pedidos where Cargo> " + min + " and " + "Cargo < " + max;

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);

                dgvTablaPedidos.DataSource = dt;

                objconector.Close();
            
            //else
            //{
            //    MessageBox.Show("Debe ingresar un cargo mínimo y máximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
        }

        private void txtNombrePedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombrePedido_KeyUp(object sender, KeyEventArgs e)
        {

            if (objconector.State == ConnectionState.Closed)
            {
                objconector.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                objconector.Open();
            }
            OleDbCommand cmd = objconector.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Pedidos where IdCliente like ('" + txtNombrePedido.Text + "%')";

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            da.Fill(dt);

            dgvTablaPedidos.DataSource = dt;

            objconector.Close();
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            if (objconector.State != ConnectionState.Open)
            {
                objconector.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                objconector.Open();
            }
            OleDbCommand cmd = objconector.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM Pedidos where FechaPedido  between #" + dtpDesde.Value.Date + "# and #" + dtpHasta.Value.Date + "#";

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            da.Fill(dt);

            dgvTablaPedidos.DataSource = dt;

            objconector.Close();
        }

        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection objconector = new OleDbConnection(ruta);
            objconector.Open();

            OleDbCommand Comando = new OleDbCommand("SELECT * FROM Pedidos where RegiónDestinatario like '" + cboRegion.Text + "'", objconector);

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(Comando);

            da.Fill(dt);

            dgvTablaPedidos.DataSource = dt;

            objconector.Close();

        }

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

            OleDbConnection objconector = new OleDbConnection(ruta);
            objconector.Open();

            OleDbCommand Comando = new OleDbCommand("SELECT * FROM Pedidos where CiudadDestinatario like '" + cboCiudad.Text + "'", objconector);

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(Comando);

            da.Fill(dt);

            dgvTablaPedidos.DataSource = dt;

            objconector.Close();

        }

        private void cboCP_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection objconector = new OleDbConnection(ruta);
            objconector.Open();

            OleDbCommand Comando = new OleDbCommand("SELECT * FROM Pedidos where CódPostalDestinatario like '" + cboCP.Text + "'", objconector);

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(Comando);

            da.Fill(dt);

            dgvTablaPedidos.DataSource = dt;

            objconector.Close();

        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value > DateTime.Today)
            {
                MessageBox.Show("No puede ingresar fechas futuras", "Fecha no válda", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dtpDesde.Value = DateTime.Today;
            }
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHasta.Value > DateTime.Today)
            {
                MessageBox.Show("No puede ingresar fechas futuras", "Fecha no válda", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dtpHasta.Value = DateTime.Today;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gpbConsXNombre_Enter(object sender, EventArgs e)
        {

        }
    } }
