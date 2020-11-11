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
    public partial class Peliculas : Form
    {
        CNN cnn = new CNN();
        List<Pelicula> lP = new List<Pelicula>();
        frmMessageBox FMB = new frmMessageBox();
        enum accion
        {
            nuevo,
            editado
        }
        accion miAccion;
       
        public Peliculas()
        {
            InitializeComponent();
            autoCompleteText("NACIONALIDADES", txtNacionalidad);
            autoCompleteText("peliculas", txtTitulo);
            miAccion = accion.editado;

        }
        public void habilitarCampos(bool x)
        {
            txtTitulo.Enabled = x;
            txtNacionalidad.Enabled = x;
            btnCancelar.Enabled = x;
            btnGrabar.Enabled = x;
            cboClasificacion.Enabled = x;
            cboGenero.Enabled = x;
            cboIdiomas.Enabled = x;


            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            lstPeliculas.Enabled =! x;
        }
        public void limpiar()
        {
            txtTitulo.Text = string.Empty;
            txtNacionalidad.Text = string.Empty;
            cboClasificacion.SelectedIndex = -1;
            cboGenero.SelectedIndex = -1;
            cboIdiomas.SelectedIndex = -1;
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
                Pelicula p = new Pelicula();
                if (!cnn.pDr.IsDBNull(0))
                    p.pId_pelicula = cnn.pDr.GetInt32(0);
                if (!cnn.pDr.IsDBNull(1))
                    p.pTitulo = cnn.pDr.GetString(1);
                if (!cnn.pDr.IsDBNull(2))
                    p.pId_genero = cnn.pDr.GetInt32(2);
                if (!cnn.pDr.IsDBNull(3))
                    p.pId_nacionalidad = cnn.pDr.GetInt32(3);
                if (!cnn.pDr.IsDBNull(4))
                    p.pId_idioma = cnn.pDr.GetInt32(4);
                if (!cnn.pDr.IsDBNull(5))
                    p.pId_clasificacion = cnn.pDr.GetInt32(5);
                if(cnn.pDr.GetInt32(6)==0)
                    lP.Add(p);

            }
            cnn.pDr.Close();
            cnn.desconectar();
            cnn.leerTabla("NACIONALIDADES");
            
            while (cnn.pDr.Read())
            {
                for (int j = 0; j < lP.Count; j++)
                {
                    if (lP[j].pId_nacionalidad == cnn.pDr.GetInt32(0))
                        lP[j].pNacionalidad = cnn.pDr.GetString(1);
                }
            }
            cnn.pDr.Close();
            cnn.desconectar();
            
            lstPeliculas.Items.Clear();
            for (int i = 0; i < lP.Count; i++)
            {
                lstPeliculas.Items.Add(lP[i].ToString());
            }
        }
       
        private void Peliculas_Load(object sender, EventArgs e)
        {
            
            habilitarCampos(false);
            cargarCombos(cboClasificacion, "CLASIFICACIONES");
            cargarCombos(cboGenero, "GENEROS");
            cargarCombos(cboIdiomas, "IDIOMAS");
            cargarLista(lstPeliculas, "peliculas");
            
  

        }
        void autoCompleteText(string nombreTabla, TextBox txtbx)
        {
            txtbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            cnn.leerTabla(nombreTabla);
            while (cnn.pDr.Read())
            {
                string descripcion = cnn.pDr.GetString(1);
                coll.Add(descripcion);
            }
            cnn.pDr.Close();
            cnn.desconectar();
            txtbx.AutoCompleteCustomSource = coll;
        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            txtMenu.Text = "Nueva Pelicula";
            
            habilitarCampos(true);
            limpiar();
            txtTitulo.Focus();
            miAccion = accion.nuevo;

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (lstPeliculas.SelectedIndex >= 0)
            {
                txtMenu.Text = "Modo Edición";
                miAccion = accion.editado;
                habilitarCampos(true);
                txtTitulo.Focus();
            }
            else
            {
                FMB.pLabel = "Debe seleccionar una pelicula";
                FMB.ShowDialog();
            }
                
            
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            habilitarCampos(false);
            
            txtTitulo.Focus();
            txtMenu.Text = "";
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Pelicula p = new Pelicula();
                p.pTitulo = txtTitulo.Text;
                p.pId_genero = (int)cboGenero.SelectedValue;
                p.pNacionalidad = txtNacionalidad.Text;
                cnn.leerTabla("NACIONALIDADES");

                while (cnn.pDr.Read())
                {
                    if (p.pNacionalidad == cnn.pDr.GetString(1))
                        p.pId_nacionalidad = cnn.pDr.GetInt32(0);
                }
                cnn.pDr.Close();
                cnn.desconectar();
                p.pId_idioma = (int)cboIdiomas.SelectedValue;
                p.pId_clasificacion = (int)cboClasificacion.SelectedValue;
                if (miAccion == accion.nuevo)
                {
                    p.nuevo(p);
                    habilitarCampos(false);
                }
                else
                {
                    if (lstPeliculas.SelectedIndex >= 0)
                    {
                        int k = lstPeliculas.SelectedIndex;
                        lP[k].pTitulo = txtTitulo.Text;
                        lP[k].pId_genero = (int)cboGenero.SelectedValue;
                        lP[k].pNacionalidad = txtNacionalidad.Text;
                        cnn.leerTabla("NACIONALIDADES");

                        while (cnn.pDr.Read())
                        {
                            if (lP[k].pNacionalidad == cnn.pDr.GetString(1))
                                lP[k].pId_nacionalidad = cnn.pDr.GetInt32(0);
                        }
                        cnn.pDr.Close();
                        cnn.desconectar();
                        lP[k].pId_idioma = (int)cboClasificacion.SelectedValue;
                        lP[k].pId_clasificacion = (int)cboClasificacion.SelectedValue;
                        lP[k].editar(lP[k]);
                        habilitarCampos(false);
                    }
                   

                }
                lP.Clear();
                cargarLista(lstPeliculas, "PELICULAS");
                txtMenu.Text = "";
                miAccion = accion.editado;
            }
            
            
        }

        private bool validarCampos()
        {
            if (miAccion == accion.nuevo)
            {
                if (string.IsNullOrEmpty(txtTitulo.Text))
                {
                    FMB.pLabel = "Debe ingresar un titulo";
                    FMB.ShowDialog();
                    txtTitulo.Focus();
                    return false;
                }
                if (cboGenero.SelectedIndex == -1)
                {
                    FMB.pLabel = "Debe seleccionar un genero";
                    FMB.ShowDialog();
                    cboGenero.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtNacionalidad.Text))
                {
                    FMB.pLabel = "Debe ingresar una nacionalidad";
                    FMB.ShowDialog();
                    txtNacionalidad.Focus();
                    return false;
                }
                if (cboIdiomas.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe ingresar un idioma", "Completar");
                    cboIdiomas.Focus();
                    return false;
                }
                if (cboClasificacion.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe ingresar una clasificacion", "Completar");
                    cboClasificacion.Focus();
                    return false;
                }
               
            }
            return true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lstPeliculas.SelectedIndex);
        }

        private void cargarCampos(int selectedIndex)
        {
            int k = lstPeliculas.SelectedIndex;
            txtTitulo.Text = lP[k].pTitulo;
            cboGenero.SelectedValue = lP[k].pId_genero;
            txtNacionalidad.Text = lP[k].pNacionalidad;
            cboIdiomas.SelectedValue = lP[k].pId_idioma;
            cboClasificacion.SelectedValue = lP[k].pId_clasificacion;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int k = lstPeliculas.SelectedIndex;
            if (lstPeliculas.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Esta seguro que desea eliminar esta pelicula?", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    lP[k].borrar(lP[k]);
                    limpiar();
                    lP.Clear();
                    cargarLista(lstPeliculas, "PELICULAS");
                }
                    
                
            }
            else
                MessageBox.Show("Debe seleccionar una pelicula a eliminar", "Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }
    }
}
