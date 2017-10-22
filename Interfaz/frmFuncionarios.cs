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
        FuncionarioLN funcionarios_L = new FuncionarioLN();
        PuestoLN puestos_L = new PuestoLN();
        FUNCIONARIOS funcionarios = new FUNCIONARIOS();
        int id_Funcinarios = 0;



        public frmFuncionarios()
        {
            InitializeComponent();
        }

        public void cargarComboPuestos()
        {
            cmbPuestos.DataSource = puestos_L.devolverLISTA_L().ToList();
            cmbPuestos.DisplayMember = "NOMBRE_PUESTO";
            cmbPuestos.ValueMember = "ID_PUESTO";
        }

        public void cargarGridFuncionarios()
        {
            List<object> listaFuncionarios = funcionarios_L.devolverLISTA_L().ToList();
            dgvFuncionario.DataSource = listaFuncionarios;
            if (listaFuncionarios.Count != 0)
            {
                dgvFuncionario.Columns[0].Visible = false;
                dgvFuncionario.Columns[1].Visible = false;
                dgvFuncionario.Columns[2].Visible = false;
                dgvFuncionario.Columns[3].HeaderText = "Cédula";
                dgvFuncionario.Columns[4].HeaderText = "Nombre completo";
                dgvFuncionario.Columns[5].HeaderText = "Primer Apellido";
                dgvFuncionario.Columns[6].HeaderText = "Segundo Apellido";
                dgvFuncionario.Columns[7].HeaderText = "Puesto";
                dgvFuncionario.Columns[8].HeaderText = "Provincia";
                dgvFuncionario.Columns[9].HeaderText = "Cantón";
                dgvFuncionario.Columns[10].HeaderText = "Distrito";
                dgvFuncionario.Columns[11].HeaderText = "Otras señas";
                dgvFuncionario.Columns[12].HeaderText = "Correo electrónico";
                dgvFuncionario.Columns[13].HeaderText = "Nacionalidad";
                dgvFuncionario.Columns[14].HeaderText = "Fecha de nacimiento";
                dgvFuncionario.Columns[15].HeaderText = "Fecha de ingreso";
                dgvFuncionario.Columns[16].HeaderText = "Télefono";
                dgvFuncionario.Columns[17].HeaderText = "Télefono opcional";
                dgvFuncionario.Columns[18].HeaderText = "Fecha de cesantía";
                dgvFuncionario.Columns[19].HeaderText = "Sexo";
            }
        }

        public void coloresGrid(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }


        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            cargarComboPuestos();
            cargarGridFuncionarios();
            coloresGrid(dgvFuncionario);
            //cmbSexo.SelectedIndex = 0;
            //cmbProvincia.SelectedIndex = 0;
            cmbCanton.Enabled = false;
            cmbDistrito.Enabled = false;       
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvincia.Text == "San José")
            {
                cmbCanton.Items.Clear();
                cmbCanton.Enabled = true;
                cmbCanton.Items.Add("San José");
                cmbCanton.Items.Add("Escazú");
                cmbCanton.Items.Add("Desamparados");
                cmbCanton.Items.Add("Puriscal");
                cmbCanton.Items.Add("Tarrazú");
                cmbCanton.Items.Add("Aserrí");
                cmbCanton.Items.Add("Mora");
                cmbCanton.Items.Add("Goicoechea");
                cmbCanton.Items.Add("Santa Ana");
                cmbCanton.Items.Add("Alajuelita");
                cmbCanton.Items.Add("Vázquez de Coronado");
                cmbCanton.Items.Add("Acosta");
                cmbCanton.Items.Add("Tibás");
                cmbCanton.Items.Add("Moravia");
                cmbCanton.Items.Add("Montes de Oca");
                cmbCanton.Items.Add("Turrubares");
                cmbCanton.Items.Add("Dota");
                cmbCanton.Items.Add("Curridabat");
                cmbCanton.Items.Add("Peréz Zeledón");
                cmbCanton.Items.Add("León Cortés");
            }
            else if (cmbProvincia.Text == "Alajuela")
            {
                cmbCanton.Enabled = true;
                cmbCanton.Items.Clear();
                cmbCanton.Items.Add("Alajuela");
                cmbCanton.Items.Add("San Ramón");
                cmbCanton.Items.Add("Grecia");
                cmbCanton.Items.Add("San Mateo");
                cmbCanton.Items.Add("Atenas");
                cmbCanton.Items.Add("Naranjo");
                cmbCanton.Items.Add("Palmares");
                cmbCanton.Items.Add("Poás");
                cmbCanton.Items.Add("Orotina");
                cmbCanton.Items.Add("San Carlos");
                cmbCanton.Items.Add("Zarcero");
                cmbCanton.Items.Add("Valverde Vega");
                cmbCanton.Items.Add("Upala");
                cmbCanton.Items.Add("Los Chiles");
                cmbCanton.Items.Add("Guatuso");
            }
            else if (cmbProvincia.Text == "Cartago")
            {
                cmbCanton.Enabled = true;
                cmbCanton.Items.Clear();
                cmbCanton.Items.Add("Cartago");
                cmbCanton.Items.Add("Paraíso");
                cmbCanton.Items.Add("La Unión");
                cmbCanton.Items.Add("Jiménez");
                cmbCanton.Items.Add("Turrialba");
                cmbCanton.Items.Add("Alvarado");
                cmbCanton.Items.Add("Oreamuno");
                cmbCanton.Items.Add("El Guarco");
            }
            else if (cmbProvincia.Text == "Heredia")
            {
                cmbCanton.Enabled = true;
                cmbCanton.Items.Clear();
                cmbCanton.Items.Add("Heredia");
                cmbCanton.Items.Add("Barva");
                cmbCanton.Items.Add("Santo Domingo");
                cmbCanton.Items.Add("Santa Bárbara");
                cmbCanton.Items.Add("San Rafael");
                cmbCanton.Items.Add("San Isidro");
                cmbCanton.Items.Add("Belén");
                cmbCanton.Items.Add("Flores");
                cmbCanton.Items.Add("San Pablo");
                cmbCanton.Items.Add("Sarapiquí");
            }
            else if (cmbProvincia.Text == "Guanacaste")
            {
                cmbCanton.Enabled = true;
                cmbCanton.Items.Clear();
                cmbCanton.Items.Add("Liberia");
                cmbCanton.Items.Add("Nicoya");
                cmbCanton.Items.Add(" Santa Cruz");
                cmbCanton.Items.Add("Bagaces");
                cmbCanton.Items.Add("Carrillo");
                cmbCanton.Items.Add("Cañas");
                cmbCanton.Items.Add("Abangares");
                cmbCanton.Items.Add("Tilarán");
                cmbCanton.Items.Add("Nandayure");
                cmbCanton.Items.Add("La Cruz");
                cmbCanton.Items.Add("Hojancha");
            }
            else if (cmbProvincia.Text == "Puntarenas")
            {
                cmbCanton.Enabled = true;
                cmbCanton.Items.Clear();
                cmbCanton.Items.Add("Puntarenas");
                cmbCanton.Items.Add("Esparza");
                cmbCanton.Items.Add("Buenos Aires");
                cmbCanton.Items.Add("Montes de Oro");
                cmbCanton.Items.Add("Osa");
                cmbCanton.Items.Add("Quepos");
                cmbCanton.Items.Add("Golfito");
                cmbCanton.Items.Add("Coto Brus");
                cmbCanton.Items.Add("Parrita");
                cmbCanton.Items.Add("Corredores");
                cmbCanton.Items.Add("Garabito");               
            }
            else if (cmbProvincia.Text == "Limón")
            {
                cmbCanton.Enabled = true;
                cmbCanton.Items.Clear();
                cmbCanton.Items.Add("Limón");
                cmbCanton.Items.Add("Pococí");
                cmbCanton.Items.Add("Siquirres");
                cmbCanton.Items.Add("Talamanca");
                cmbCanton.Items.Add("Matina");
                cmbCanton.Items.Add("Guácimo");               
            }
        }
    }
}
