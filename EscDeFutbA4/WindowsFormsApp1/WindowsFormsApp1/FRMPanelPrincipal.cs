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
    public partial class FRMPanelPrincipal : Form
    {
        public FRMPanelPrincipal()
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
        private void btnRegistrp_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmFutsal>();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmFutbolCampo>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmFinanzas>();
        }
    }
}
