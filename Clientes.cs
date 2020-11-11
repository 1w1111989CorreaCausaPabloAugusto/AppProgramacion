using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//111995 - Romero Luna Carmela.
//111942 - Ismael Zamuz. 
//111947 - Sebastian Leyria.
//111989 - Correa Causa Pablo.
namespace FormProgramacion
{
    public partial class Clientes : Form
    {
        CNN cnn = new CNN();
        List<Cliente> lP = new List<Cliente>();
        enum accion
        {
            nuevo,
            editado
        }
        accion miAccion;

        public Clientes()
        {
            InitializeComponent();

        }


        public void habilitarCampos(bool x)
        {
            txtNombreCliente.Enabled = x;
            txtApellidoCliente.Enabled = x;
            dtpFechaNacCliente.Enabled = x;
            cboTipoDocCliente.Enabled = x;
            txtDNICliente.Enabled = x;
            rbtFemCliente.Enabled = x;
            rbtMasculinoCliente.Enabled = x;

            txtCalleCliente.Enabled = x;
            txtAlturaCliente.Enabled = x;
            cboBarrioCliente.Enabled = x;

            btnCancelar.Enabled = x;
            btnGrabar.Enabled = x;

            btnNuevoCliente.Enabled = !x;
            btnEditarCliente.Enabled = !x;
            btnBorrarCliente.Enabled = !x;
            lstClientes.Enabled = !x;


        }
        public void limpiar()
        {
            txtNombreCliente.Text = string.Empty;
            txtApellidoCliente.Text = string.Empty;
            txtDNICliente.Text = string.Empty;
            txtCalleCliente.Text = string.Empty;
            txtAlturaCliente.Text = string.Empty;

            cboTipoDocCliente.SelectedIndex = -1;
            cboBarrioCliente.SelectedIndex = -1;
        }

        public void cargarCombos(ComboBox combo, string nombreTabla)
        {
            DataTable dt = new DataTable();
            dt = cnn.extraerTabla(nombreTabla);

            combo.DataSource = dt;

            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public void cargarLista(ListBox lst, string nombreTabla)
        {

            cnn.leerTabla(nombreTabla);
            while (cnn.pDr.Read())
            {
                Cliente cli = new Cliente();
                if (!cnn.pDr.IsDBNull(0))
                    cli.pId_cliente = cnn.pDr.GetInt32(0);
                if (!cnn.pDr.IsDBNull(1))
                    cli.pNombre = cnn.pDr.GetString(1);
                if (!cnn.pDr.IsDBNull(2))
                    cli.pApellido = cnn.pDr.GetString(2);
                if (!cnn.pDr.IsDBNull(3))
                    cli.pFecha_nac = cnn.pDr.GetDateTime(3);
                if (!cnn.pDr.IsDBNull(4))
                    cli.pCalle = cnn.pDr.GetString(4);
                if (!cnn.pDr.IsDBNull(5))
                    cli.pAltura = cnn.pDr.GetInt32(5);
                if (!cnn.pDr.IsDBNull(6))
                    cli.pNro_documento = cnn.pDr.GetInt32(6);
                if (!cnn.pDr.IsDBNull(7))
                    cli.pId_tipo_doc = cnn.pDr.GetInt32(7);
                if (!cnn.pDr.IsDBNull(8))
                    cli.pId_sexo = cnn.pDr.GetInt32(8);
                if (!cnn.pDr.IsDBNull(9))
                    cli.pD_barrio = cnn.pDr.GetInt32(9);
                if (cnn.pDr.GetInt32(10) == 0)
                    lP.Add(cli);



            }

            cnn.pDr.Close();
            cnn.desconectar();

            lstClientes.Items.Clear();
            for (int i = 0; i < lP.Count; i++)
            {
                lstClientes.Items.Add(lP[i].ToString());
            }


        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            habilitarCampos(false);
            cargarCombos(cboBarrioCliente, "BARRIOS");
            cargarCombos(cboTipoDocCliente, "TIPOS_DOCUMENTO");
            cargarLista(lstClientes, "CLIENTES");
            limpiar();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            txtMenu.Text = "Nuevo Cliente";
            miAccion = accion.nuevo;
            habilitarCampos(true);
            limpiar();
            txtNombreCliente.Focus();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

            if (lstClientes.SelectedIndex >= 0)
            {
                txtMenu.Text = "Modo edición";
                miAccion = accion.editado;
                habilitarCampos(true);
                txtNombreCliente.Focus();
            }
            else
                MessageBox.Show("Debe seleccionar un cliente de la lista", "Seleccionar");
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            int k = lstClientes.SelectedIndex;
            if (lstClientes.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Esta seguro que desea eliminar este cliente?", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    lP[k].borrar(lP[k]);
                    limpiar();
                    lP.Clear();
                    cargarLista(lstClientes, "CLIENTES");
                }


            }
            else
                MessageBox.Show("Debe seleccionar una persona a eliminar", "Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtMenu.Text = "";
            habilitarCampos(false);
            limpiar();
            txtNombreCliente.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Cliente cli = new Cliente();
                cli.pNombre = txtNombreCliente.Text;
                cli.pApellido = txtApellidoCliente.Text;
                cli.pFecha_nac = dtpFechaNacCliente.Value;

                cli.pId_tipo_doc = (int)cboTipoDocCliente.SelectedValue;
                cli.pNro_documento = Convert.ToInt32(txtDNICliente.Text);
                if (rbtFemCliente.Checked)
                    cli.pId_sexo = 1;
                if (rbtMasculinoCliente.Checked)
                    cli.pId_sexo = 2;
                if (rbtSinEspecificar.Checked)
                    cli.pId_sexo = 3;

                cli.pCalle = txtCalleCliente.Text;
                cli.pAltura = Convert.ToInt32(txtAlturaCliente.Text);
                cli.pD_barrio = (int)cboBarrioCliente.SelectedValue;


                if (miAccion == accion.nuevo)
                {
                    cli.nuevo(cli);
                    habilitarCampos(false);
                    txtMenu.Text = "";
                }
                else
                {
                    if (lstClientes.SelectedIndex >= 0)
                    {


                        int k = lstClientes.SelectedIndex;

                        lP[k].pNombre = txtNombreCliente.Text;
                        lP[k].pApellido = txtApellidoCliente.Text;
                        lP[k].pFecha_nac = dtpFechaNacCliente.Value;

                        lP[k].pId_tipo_doc = (int)cboTipoDocCliente.SelectedValue;
                        lP[k].pNro_documento = Convert.ToInt32(txtDNICliente.Text);
                        if (rbtFemCliente.Checked)
                            lP[k].pId_sexo = 1;
                        if (rbtMasculinoCliente.Checked)
                            lP[k].pId_sexo = 2;
                        if (rbtSinEspecificar.Checked)
                            lP[k].pId_sexo = 3;

                        lP[k].pCalle = txtCalleCliente.Text;
                        lP[k].pAltura = Convert.ToInt32(txtAlturaCliente.Text);
                        lP[k].pD_barrio = (int)cboBarrioCliente.SelectedValue;




                        lP[k].editar(lP[k]);
                        habilitarCampos(false);
                        txtMenu.Text = "";

                    }
                    else
                        MessageBox.Show("Seleccione un item a editar", "Item");
                }
                lP.Clear();
                cargarLista(lstClientes, "CLIENTES");
            }

        





        }

        private bool validarCampos()
        {
            if (string.IsNullOrEmpty(txtNombreCliente.Text))
            {
                MessageBox.Show("Debe ingresar un nombre", "Completar");
                txtNombreCliente.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtApellidoCliente.Text))
            {
                MessageBox.Show("Debe ingresar un apellido", "Completar");
                txtApellidoCliente.Focus();
                return false;
            }

            if (cboTipoDocCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de documento", "Completar");
                cboTipoDocCliente.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDNICliente.Text))
            {
                MessageBox.Show("Debe ingresar un número de documento", "Completar");
                txtDNICliente.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCalleCliente.Text))
            {
                MessageBox.Show("Debe ingresar una calle", "Completar");
                txtCalleCliente.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAlturaCliente.Text))
            {
                MessageBox.Show("Debe ingresar una altura para su dirección", "Completar");
                txtAlturaCliente.Focus();
                return false;
            }
            if (cboBarrioCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un barrio", "Completar");
                cboBarrioCliente.Focus();
                return false;
            }



            return true;

        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lstClientes.SelectedIndex);
        }

        private void cargarCampos(int selectedIndex)
        {
            int k = lstClientes.SelectedIndex;
            txtNombreCliente.Text = lP[k].pNombre;
            txtApellidoCliente.Text = lP[k].pApellido;
            dtpFechaNacCliente.Value = lP[k].pFecha_nac;
            cboTipoDocCliente.SelectedValue = lP[k].pId_tipo_doc;
            txtDNICliente.Text = lP[k].pNro_documento.ToString();
            if (lP[k].pId_sexo == 1)
                rbtFemCliente.Checked = true;
            if (lP[k].pId_sexo == 2)
                rbtMasculinoCliente.Checked = true;
            if (lP[k].pId_sexo == 3)
                rbtSinEspecificar.Checked = true;

            txtCalleCliente.Text = lP[k].pCalle;
            txtAlturaCliente.Text = lP[k].pAltura.ToString() ;
            cboBarrioCliente.SelectedValue = lP[k].pD_barrio;

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtAlturaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if(!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Ingrese una altura valida","Altura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDNICliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Ingrese un documento valido", "Altura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
