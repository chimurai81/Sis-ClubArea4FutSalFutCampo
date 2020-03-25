using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmFinanzasHijoFutsal : Form
    {
        public FrmFinanzasHijoFutsal()
        {
            InitializeComponent();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFinanzas frm = (FrmFinanzas)Owner;
            frm.txtCi.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtApelido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }
        public void GetAll(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "select CiNro, Nombre, Apellido from alumnosfutsal " + condicion;

            try
            {
                modulo.AbrirConexion();
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                resultado = new DataSet();
                consulta.Fill(resultado, "rsresultado");
                dataGridView1.DataSource = resultado.Tables["rsresultado"];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FrmFinanzasHijoFutsal_Load(object sender, EventArgs e)
        {
            GetAll("");

        }

        private void button82_Click(object sender, EventArgs e)
        {
            string condicion;
            condicion = "";

            if (rbNombre.Checked == true)
            {
                condicion = " where Nombre like '%" + txtbusqueda.Text.ToUpperInvariant() + "%'";
            }
            if (rbApellido.Checked == true)
            {
                condicion = " where Apellido like '%" + txtbusqueda.Text.ToUpperInvariant() + "%'";
            }
            if (rbNroCI.Checked == true)
            {
                condicion = " where CiNro like '%" + txtbusqueda.Text + "%'";
            }
            GetAll(condicion);
        }
    }
}
