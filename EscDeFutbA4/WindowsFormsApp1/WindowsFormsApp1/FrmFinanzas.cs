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
    public partial class FrmFinanzas : Form
    {
        public FrmFinanzas()
        {
            InitializeComponent();
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbNroCI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button82_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbApellido_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroFutsalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroFutsal rf = new FrmRegistroFutsal();
            rf.ShowDialog();
        }

        private void registroFutbolCampoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroFutCampo rf = new FrmRegistroFutCampo();
            rf.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        FrmFinanzasHijoFutsal frm;
        private void button5_Click(object sender, EventArgs e)
        {
            frm = new FrmFinanzasHijoFutsal();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }
        FrmFinanzasFutbolCampo frm2;
        private void button4_Click(object sender, EventArgs e)
        {
            frm2 = new FrmFinanzasFutbolCampo();
            AddOwnedForm(frm2);
            frm2.ShowDialog();
        }
        public void GetAll(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "select * from finanzas " + condicion;

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
        //SIRVE PARA MOSTRAR EL MESSAGEBOX POR UN LAPSO DE TIEMPO
        private void showMessage(string msg, int duration)
        {
            using (Timer t = new Timer())
            {
                Timer time = new Timer();
                time.Interval = duration;
                time.Tick += timeTick;  /* Evento enlazado */

                time.Start();

                /* Muestras el texto en el MB */
                MessageBox.Show(msg);
            }
        }

        private void timeTick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();  /* Detiene el Timer */
            SendKeys.Send("{ESC}"); /* Hace la simulación de la tecla Escape, también puedes usar {ENTER} */
        }
        //**//
        public void RegistrarAlumnos()
        {
            string sql;
            //MySqlCommand comando;
            sql = "insert into finanzas (NroCi,Nombre,Apellido,Fecha,Observacion,Total,MontoAPagar,MontoDeuda) values (@NroCi,@Nombre,@Apellido,@Fecha,@Observacion,@Total,@MontoAPagar,@MontoDeuda)";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);

                comando.Parameters.AddWithValue("@NroCi", Convert.ToInt32(txtCi.Text));
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@Apellido", txtApelido.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@Fecha", dtpFechaPago.Value);
                comando.Parameters.AddWithValue("@Observacion", txtObservacion.Text);
                comando.Parameters.AddWithValue("@Total", Convert.ToInt32(txtTotal.Text));
                comando.Parameters.AddWithValue("@MontoAPagar", Convert.ToInt32(txtMontoaPagar.Text));
                comando.Parameters.AddWithValue("@MontoDeuda", Convert.ToInt32(txtMontoaPagar.Text));
                comando.ExecuteNonQuery();
                showMessage("Pago Efectuado", 1000);
                GetAll("");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmFinanzas_Load(object sender, EventArgs e)
        {
            GetAll("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double montoAPagar = 0.000;
            double montoDeDeuda = 0.000;
            double Total = 0.000;
            montoAPagar = Convert.ToDouble(txtMontoaPagar.Text);
            Total = Convert.ToDouble(txtTotal.Text);
            while (montoAPagar > Total)
            {
                MessageBox.Show("Su Monto a Pagar es Superior a tu Monto Total.");
                return;
            }
            montoDeDeuda = (Total - montoAPagar);
            txtMontoDeuda.Text = montoDeDeuda.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarAlumnos();
        }
    }
}
