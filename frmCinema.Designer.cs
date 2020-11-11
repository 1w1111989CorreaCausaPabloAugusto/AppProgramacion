namespace FormProgramacion
{
    partial class frmCinema
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCinema));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnComprobantes = new FontAwesome.Sharp.IconButton();
            this.btnActores = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnExpandir = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.lblFormularioHijo = new System.Windows.Forms.Label();
            this.iconoFormularioHijo = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoFormularioHijo)).BeginInit();
            this.panelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnComprobantes);
            this.panelMenu.Controls.Add(this.btnActores);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(210, 656);
            this.panelMenu.TabIndex = 0;
            // 
            // btnComprobantes
            // 
            this.btnComprobantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComprobantes.FlatAppearance.BorderSize = 0;
            this.btnComprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobantes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnComprobantes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnComprobantes.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnComprobantes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnComprobantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComprobantes.IconSize = 30;
            this.btnComprobantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprobantes.Location = new System.Drawing.Point(0, 237);
            this.btnComprobantes.Name = "btnComprobantes";
            this.btnComprobantes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnComprobantes.Rotation = 0D;
            this.btnComprobantes.Size = new System.Drawing.Size(210, 80);
            this.btnComprobantes.TabIndex = 3;
            this.btnComprobantes.Text = "Reporte de Clientes";
            this.btnComprobantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprobantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprobantes.UseVisualStyleBackColor = true;
            this.btnComprobantes.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnActores
            // 
            this.btnActores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActores.FlatAppearance.BorderSize = 0;
            this.btnActores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActores.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnActores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnActores.IconChar = FontAwesome.Sharp.IconChar.TheaterMasks;
            this.btnActores.IconColor = System.Drawing.Color.Gainsboro;
            this.btnActores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActores.IconSize = 30;
            this.btnActores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActores.Location = new System.Drawing.Point(0, 153);
            this.btnActores.Name = "btnActores";
            this.btnActores.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnActores.Rotation = 0D;
            this.btnActores.Size = new System.Drawing.Size(210, 84);
            this.btnActores.TabIndex = 2;
            this.btnActores.Text = "Peliculas";
            this.btnActores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActores.UseVisualStyleBackColor = true;
            this.btnActores.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UmbrellaBeach;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 70);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(210, 83);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Clientes";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 70);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(74, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "CINEMA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnExpandir);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.lblFormularioHijo);
            this.panel1.Controls.Add(this.iconoFormularioHijo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(210, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 61);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 15;
            this.btnExit.Location = new System.Drawing.Point(872, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(28, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.iconButton4_Click_1);
            // 
            // btnExpandir
            // 
            this.btnExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandir.FlatAppearance.BorderSize = 0;
            this.btnExpandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExpandir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExpandir.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnExpandir.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExpandir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpandir.IconSize = 15;
            this.btnExpandir.Location = new System.Drawing.Point(844, 3);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Rotation = 0D;
            this.btnExpandir.Size = new System.Drawing.Size(28, 23);
            this.btnExpandir.TabIndex = 2;
            this.btnExpandir.UseVisualStyleBackColor = true;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 15;
            this.btnMinimizar.Location = new System.Drawing.Point(816, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Rotation = 0D;
            this.btnMinimizar.Size = new System.Drawing.Size(28, 23);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblFormularioHijo
            // 
            this.lblFormularioHijo.AutoSize = true;
            this.lblFormularioHijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormularioHijo.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblFormularioHijo.Location = new System.Drawing.Point(57, 22);
            this.lblFormularioHijo.Name = "lblFormularioHijo";
            this.lblFormularioHijo.Size = new System.Drawing.Size(45, 16);
            this.lblFormularioHijo.TabIndex = 1;
            this.lblFormularioHijo.Text = "Home";
            // 
            // iconoFormularioHijo
            // 
            this.iconoFormularioHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconoFormularioHijo.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconoFormularioHijo.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconoFormularioHijo.IconColor = System.Drawing.Color.MediumPurple;
            this.iconoFormularioHijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoFormularioHijo.Location = new System.Drawing.Point(19, 12);
            this.iconoFormularioHijo.Name = "iconoFormularioHijo";
            this.iconoFormularioHijo.Size = new System.Drawing.Size(32, 32);
            this.iconoFormularioHijo.TabIndex = 0;
            this.iconoFormularioHijo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(210, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 9);
            this.panel3.TabIndex = 2;
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelEscritorio.Controls.Add(this.pictureBox2);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(210, 70);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(909, 586);
            this.panelEscritorio.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-44, -102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1024, 768);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frmCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 656);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmCinema";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoFormularioHijo)).EndInit();
            this.panelEscritorio.ResumeLayout(false);
            this.panelEscritorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnComprobantes;
        private FontAwesome.Sharp.IconButton btnActores;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFormularioHijo;
        private FontAwesome.Sharp.IconPictureBox iconoFormularioHijo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelEscritorio;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnExpandir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

