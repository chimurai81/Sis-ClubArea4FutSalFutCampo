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
    public partial class FrmConsultaFutbolCampo : Form
    {
        public FrmConsultaFutbolCampo()
        {
            InitializeComponent();
        }

        private void btnAggFotoRegistro_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbriImagen = new OpenFileDialog();
            AbriImagen.InitialDirectory = @"C:\Users\Mauricio\Pictures";
            AbriImagen.Filter = "Archivos de Imagen(*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
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
        //        //**//
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
        public void GetAll(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "select * from alumnosfutbolcampo " + condicion;

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

        public void EditarAlumnos(string id)
        {
            string sql;
            //MySqlCommand comando;
            sql = "update alumnosfutbolcampo set CiNro=@CiNro,Nombre=@Nombre,Apellido=@Apellido,Telefono=@Telefono,FechaNac=@FechaNac,Edad=@Edad,Categoria=@Categoria,Direccion=@Direccion,Foto=@Foto where id=@id";
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
                comando.Parameters.AddWithValue("@Id", id);
                comando.ExecuteNonQuery();
                showMessage("Alumno Modificado", 1000);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void verImagen(PictureBox pbfoto, int Id)
        {
            int Recorrido = (Id - 1);
            try
            {
                MySqlConnection Conexion = new MySqlConnection("Server=localhost;" +
                                              "Database=EscFutA4;" +
                                              "Uid=root;" +
                                              "Pwd=;");
                MySqlDataAdapter da = new MySqlDataAdapter($"SELECT Foto FROM alumnosfutbolcampo", Conexion);
                DataRow dr;
                DataSet ds = new DataSet();
                da.Fill(ds, "Foto");
                byte[] datos = new byte[0];
                dr = ds.Tables["Foto"].Rows[Recorrido];
                datos = (byte[])dr["Foto"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pbfoto.Image = System.Drawing.Bitmap.FromStream(ms);


            }
            catch (Exception)
            {
                ptbFotoRegistros.Image = null;
            }
        }
        public void cargarRegistro(string id)
        {

            string sql;
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();

            try
            {
                modulo.AbrirConexion();
                sql = "select * from alumnosfutbolcampo where id= " + id;
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                consulta.Fill(resultado, "rsProveedor");
                int c, n;
                n = resultado.Tables["rsProveedor"].Rows.Count;
                c = 0;

                txtId.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["id"]);
                txtCi.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["CiNro"]);
                txtNombre.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Nombre"]);
                txtApelido.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Apellido"]);
                txtTelefono.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Telefono"]);
                dtpFechNac.Value = Convert.ToDateTime(resultado.Tables["rsProveedor"].Rows[0]["FechaNac"]);
                txtEdadActual.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Edad"]);
                txtCategoria.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Categoria"]);
                txtDireccion.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Direccion"]);

                modulo.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void FrmConsultaFutbolCampo_Load(object sender, EventArgs e)
        {
            GetAll("");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cargarRegistro(txtId.Text);
                string idstring = txtId.Text;
                int id = int.Parse(txtId.Text);
                verImagen(ptbFotoRegistros, id);
            }
        }

        private void btnCancelatFotoRegistro_Click(object sender, EventArgs e)
        {
            ptbFotoRegistros.Image = null;
        }

        private void txtEdadActual_Click(object sender, EventArgs e)
        {
            int dias = DateTime.Now.Date.Subtract(dtpFechNac.Value.Date).Days / 365;
            txtEdadActual.Text = $"Actualmente tiene: {dias.ToString()} años".ToString();
        }

        private void txtCategoria_Click(object sender, EventArgs e)
        {
            txtCategoria.Text = $"{dtpFechNac.Value.Year.ToString()} FutSal";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string condicion;
            condicion = "";

            if (rboNombre.Checked == true)
            {
                condicion = " where Nombre like '%" + TxtBuscar.Text.ToUpperInvariant() + "%'";
            }
            if (rboApellido.Checked == true)
            {
                condicion = " where Apellido like '%" + TxtBuscar.Text.ToUpperInvariant() + "%'";
            }
            if (rboCiNro.Checked == true)
            {
                condicion = " where CiNro like '%" + TxtBuscar.Text + "%'";
            }
            if (rboCategoria.Checked == true)
            {
                condicion = " where Categoria like '%" + TxtBuscar.Text.ToUpperInvariant() + "%'";
            }
            GetAll(condicion);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            EditarAlumnos(id);
            GetAll("");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnAggFotoRegistro_Click_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
