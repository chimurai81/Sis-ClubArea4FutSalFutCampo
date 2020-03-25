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
    public partial class FrmFutbolCampo : Form
    {
        public FrmFutbolCampo()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelContenedor.Controls.Add(formulario);
                PanelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

           
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistroFutCampo>();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmConsultaFutbolCampo>();
        }
    }
}
