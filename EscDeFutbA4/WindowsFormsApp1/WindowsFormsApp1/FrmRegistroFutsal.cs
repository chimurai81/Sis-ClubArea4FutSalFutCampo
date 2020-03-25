using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class FrmRegistroFutsal : Form
    {
        public FrmRegistroFutsal()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            txtCi.Text = "C.I.N°";
            txtNombre.Text = "Nombre";
            txtApelido.Text = "Apellido";
            txtDireccion.Text = "Direccion";
            dtpFechNac.Text = "";
            txtTelefono.Text = "Telefono";
            ptbFotoRegistros.Image = null;
            txtCi.Focus();
        }
        private void FrmRegistroFutsal_Load(object sender, EventArgs e)
        {

        }


        private void txtCi_Click(object sender, EventArgs e)
        {
            txtCi.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
        }

        private void txtApelido_Click(object sender, EventArgs e)
        {
            txtApelido.Text = "";
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            txtTelefono.Text = "";
        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {
            txtDireccion.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdadActual_Click(object sender, EventArgs e)
        {
            int dias = DateTime.Now.Date.Subtract(dtpFechNac.Value.Date).Days/365;
            txtEdadActual.Text = $"Actualmente tiene: {dias.ToString()} años".ToString();
        }

        private void btnAggFotoRegistro_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbriImagen = new OpenFileDialog();
            AbriImagen.InitialDirectory = @"C:\Users\Mauricio\Pictures";
            AbriImagen.Filter = "Archivos de Imagen(*.jpg, *.jpeg, *.jpe, *.png, *.jfif) | *.jpg; *.jpeg; *.jpe; *.png; *.jfif";
            AbriImagen.ShowDialog();

            if (AbriImagen.FileName != "")
            {
                ptbFotoRegistros.Image = Image.FromFile(AbriImagen.FileName);
            }
            else
            {
                ptbFotoRegistros.Image = null;
            }
        }

        private void btnCancelatFotoRegistro_Click(object sender, EventArgs e)
        {
            ptbFotoRegistros.Image = null;
        }

        private void txtCategoria_Click(object sender, EventArgs e)
        {
            txtCategoria.Text = $"{dtpFechNac.Value.Year.ToString()} FutSal";

        }

        private void txtCi_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptbFotoRegistros_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
        public static byte[] Image2Bytes(Image Img)
        {
            if (Img == null)
            {
                return null;
            }
            else
            {
                ImageConverter converter = new ImageConverter();
                return (byte[])converter.ConvertTo(Img, typeof(byte[]));
            }
        }
        //**//
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
            sql = "insert into alumnosfutsal (CiNro,Nombre,Apellido,Telefono,FechaNac,Edad,Categoria,Direccion,Foto) values (@CiNro,@Nombre,@Apellido,@Telefono,@FechaNac,@Edad,@Categoria,@Direccion,@Foto)";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);

                comando.Parameters.AddWithValue("@CiNro", Convert.ToInt32(txtCi.Text));
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@Apellido", txtApelido.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text).ToString();
                comando.Parameters.AddWithValue("@FechaNac", dtpFechNac.Value);
                comando.Parameters.AddWithValue("@Edad", txtEdadActual.Text.ToString());
                comando.Parameters.AddWithValue("@Categoria", txtCategoria.Text);
                comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@Foto", Image2Bytes(ptbFotoRegistros.Image));
                comando.ExecuteNonQuery();
                showMessage("Alumno Registrado", 2000);
                Limpiar();
                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(txtCi.Text == "C.I.N°" || txtCi.Text == "")
            {
                showMessage("Introduce Numero de Cedula", 1500);
                return;
            }

            RegistrarAlumnos();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApelido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
