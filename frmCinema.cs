using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace FormProgramacion
{

    public partial class frmCinema : Form
    {
        //Variables
        private IconButton botonGeneral;
        private Panel bordeIzquieroBtn;
        private Form currentChildForm;

        //Constructor
        public frmCinema()
        {
            InitializeComponent();
            bordeIzquieroBtn = new Panel();
            bordeIzquieroBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(bordeIzquieroBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(94, 221, 100);
            public static Color color8 = Color.FromArgb(255, 255, 128);

        }

        //Métodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                botonDeshabilitado();
                //Button
                botonGeneral = (IconButton)senderBtn;
                botonGeneral.BackColor = Color.FromArgb(37, 36, 81);
                botonGeneral.ForeColor = color;
                botonGeneral.TextAlign = ContentAlignment.MiddleCenter;
                botonGeneral.IconColor = color;
                botonGeneral.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonGeneral.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                bordeIzquieroBtn.BackColor = color;
                bordeIzquieroBtn.Location = new Point(0, botonGeneral.Location.Y);
                bordeIzquieroBtn.Visible = true;
                bordeIzquieroBtn.BringToFront();
                //Current Child Form Icon
                iconoFormularioHijo.IconChar = botonGeneral.IconChar;
                iconoFormularioHijo.IconColor = color;
            }
        }

        private void botonDeshabilitado()
        {
            if (botonGeneral != null)
            {
                botonGeneral.BackColor = Color.FromArgb(31, 30, 68);
                botonGeneral.ForeColor = Color.Gainsboro;
                botonGeneral.TextAlign = ContentAlignment.MiddleLeft;
                botonGeneral.IconColor = Color.Gainsboro;
                botonGeneral.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonGeneral.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void AbrirFormularioHijo(Form formularioHijo)
        {
            //Abre solo el form si
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = formularioHijo;
            //End
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formularioHijo);
            panelEscritorio.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
            lblFormularioHijo.Text = formularioHijo.Text;
        }

        private void Reset()
        {
            botonDeshabilitado();
            bordeIzquieroBtn.Visible = false;
            iconoFormularioHijo.IconChar = IconChar.Home;
            iconoFormularioHijo.IconColor = Color.MediumPurple;
            lblFormularioHijo.Text = "Home";
        }

        


        //Menu Button_Clicks

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            AbrirFormularioHijo(new Clientes());
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            AbrirFormularioHijo(new Peliculas());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            AbrirFormularioHijo(new frmReporteClientes());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            AbrirFormularioHijo(new Pagos());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            AbrirFormularioHijo(new Periodos());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            

        }
        private void btnGenero_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            
        }





        //Botón para resetear y volver al menú principal
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }







        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }


    }
}