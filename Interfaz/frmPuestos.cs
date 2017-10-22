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
    public partial class frmPuestos : Form
    {

        //incializar las variables a utilizar
        PuestoLN puestos_L = new PuestoLN();
        PUESTOS puesto = new PUESTOS();
        int id_Puesto = 0;

        public frmPuestos()
        {
            InitializeComponent();
        }      

        //metodo para cargar los datos de la tabla en el grid
        public void cargarGridPuestos()
        {
            List<object> listaPuestos = puestos_L.devolverLISTA_L().ToList();
            dgvPuesto.DataSource = listaPuestos;
            if (listaPuestos.Count != 0)
            {
                dgvPuesto.Columns[0].Visible = false;
                dgvPuesto.Columns[1].Visible = false;
                dgvPuesto.Columns[2].HeaderText = "Nombre del puesto";
                dgvPuesto.Columns[3].HeaderText = "Detalle del puesto";
            }
        }

        public void coloresGrid(DataGridView dgv)
        {
            dgvPuesto.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvPuesto.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        public void limpiarCampos()
        {
            txtNombrePuesto.Clear();
            txtDetallePuesto.Clear();
        }

        private void frmPuestos_Load(object sender, EventArgs e)
        {

            cargarGridPuestos();
            coloresGrid(dgvPuesto);
        }

        //metodos para ingresar, modificar y eliminar
        private void btnAgregarPuesto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombrePuesto.Text != "" && txtDetallePuesto.Text != "")
                {
                    puesto.NOMBRE_PUESTO = txtNombrePuesto.Text;
                    puesto.DETALLE_PUESTO = txtDetallePuesto.Text;

                    puestos_L.Agregar_L(puesto);
                    MessageBox.Show("Los datos fueron agregados correctamente", "Agregar Puestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGridPuestos();
                    limpiarCampos();                    
                }
                else
                {
                    MessageBox.Show("No puede dejar campos sin rellenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarPuesto_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_Puesto != 0)
                {
                    puesto.ID_PUESTO = id_Puesto;
                    puesto.NOMBRE_PUESTO = txtNombrePuesto.Text;
                    puesto.DETALLE_PUESTO = txtDetallePuesto.Text;

                    puestos_L.Modificar_L(puesto);
                    MessageBox.Show("Los datos fueron modificados correctamente", "Modificar Puestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGridPuestos();
                    limpiarCampos();               
                }
                else
                {
                    MessageBox.Show("Dede selecionar un registro de la tabla con doble click", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar los datos\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarPuesto_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_Puesto != 0)
                {
                    puesto.ID_PUESTO = id_Puesto;

                    puestos_L.Eliminar_L(puesto);
                    MessageBox.Show("Los datos fueron eliminados correctamente", "Eliminar Puestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGridPuestos();
                    limpiarCampos();                  
                }
                else
                {
                    MessageBox.Show("Dede selecionar un registro de la tabla con doble click", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los datos\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //metodo para seleccionar un registro en el grid con doble click
        private void dgvPuesto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id_Puesto = int.Parse(dgvPuesto.Rows[dgvPuesto.CurrentRow.Index].Cells[1].Value.ToString());
                txtNombrePuesto.Text = dgvPuesto.Rows[dgvPuesto.CurrentRow.Index].Cells[2].Value.ToString();
                txtDetallePuesto.Text = dgvPuesto.Rows[dgvPuesto.CurrentRow.Index].Cells[3].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
