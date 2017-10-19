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
using Logica.Implementaciones;


namespace SADDEX
{
    public partial class frmFuncionarios : Form
    {

        //se inicializan las variables que se van a necesitar
        FuncionarioLN funcionario_L = new FuncionarioLN();



        public frmFuncionarios()
        {
            InitializeComponent();
        }


       
    }
}
