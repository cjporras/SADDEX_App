using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;
using Logica.Implementaciones;

namespace SADDEX
{
    public partial class frmUsuarios : Form
    {

        USUARIOS usuarios = new USUARIOS();
        UsuarioLN usuarios_L = new UsuarioLN();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }

        private void btnModificarUbicacion_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarUbicacion_Click(object sender, EventArgs e)
        {

        }
    }
}
