using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SADDEX
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //USUARIOS nombreusuario = new USUARIOS();
     

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del sistema", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nombreusuario.NOMBRE_USUARIO = txtNombreUsuario.Text;
            //nombreusuario.CONTRASEÑA = txtContraseña.Text;
           
        }
    }
}
