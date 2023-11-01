namespace PruebaConexionDB
{
    partial class menuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblMensajeAdmin = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Panel();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnRecetas = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBarraControl = new System.Windows.Forms.Panel();
            this.btnExpandirMenu = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBarraControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpandirMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(352, 72);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(111, 13);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "BIENVENIDO ADMIN";
            // 
            // lblMensajeAdmin
            // 
            this.lblMensajeAdmin.AutoSize = true;
            this.lblMensajeAdmin.Location = new System.Drawing.Point(384, 72);
            this.lblMensajeAdmin.Name = "lblMensajeAdmin";
            this.lblMensajeAdmin.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeAdmin.TabIndex = 1;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(376, 144);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Menu.Controls.Add(this.btnFacturas);
            this.Menu.Controls.Add(this.btnRecetas);
            this.Menu.Controls.Add(this.btnMedicos);
            this.Menu.Controls.Add(this.btnCitas);
            this.Menu.Controls.Add(this.btnPacientes);
            this.Menu.Controls.Add(this.pictureBox1);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(224, 450);
            this.Menu.TabIndex = 3;
            this.Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(139)))), ((int)(((byte)(181)))));
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.ForeColor = System.Drawing.Color.White;
            this.btnFacturas.Image = global::PruebaConexionDB.Properties.Resources.factura1;
            this.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Location = new System.Drawing.Point(0, 224);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(224, 48);
            this.btnFacturas.TabIndex = 9;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = false;
            // 
            // btnRecetas
            // 
            this.btnRecetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(139)))), ((int)(((byte)(181)))));
            this.btnRecetas.FlatAppearance.BorderSize = 0;
            this.btnRecetas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecetas.ForeColor = System.Drawing.Color.White;
            this.btnRecetas.Image = global::PruebaConexionDB.Properties.Resources.receta;
            this.btnRecetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecetas.Location = new System.Drawing.Point(0, 184);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(224, 48);
            this.btnRecetas.TabIndex = 8;
            this.btnRecetas.Text = "Recetas";
            this.btnRecetas.UseVisualStyleBackColor = false;
            // 
            // btnMedicos
            // 
            this.btnMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(139)))), ((int)(((byte)(181)))));
            this.btnMedicos.FlatAppearance.BorderSize = 0;
            this.btnMedicos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicos.ForeColor = System.Drawing.Color.White;
            this.btnMedicos.Image = global::PruebaConexionDB.Properties.Resources.estetoscopio;
            this.btnMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicos.Location = new System.Drawing.Point(0, 144);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(224, 48);
            this.btnMedicos.TabIndex = 7;
            this.btnMedicos.Text = "Médicos";
            this.btnMedicos.UseVisualStyleBackColor = false;
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(139)))), ((int)(((byte)(181)))));
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.White;
            this.btnCitas.Image = global::PruebaConexionDB.Properties.Resources.calendario;
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Location = new System.Drawing.Point(0, 104);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(224, 48);
            this.btnCitas.TabIndex = 6;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(139)))), ((int)(((byte)(181)))));
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.Image = global::PruebaConexionDB.Properties.Resources.silueta_de_multiples_usuarios1;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 64);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(224, 48);
            this.btnPacientes.TabIndex = 5;
            this.btnPacientes.Text = " ";
            this.btnPacientes.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PruebaConexionDB.Properties.Resources.logoMenu;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlBarraControl
            // 
            this.pnlBarraControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(139)))), ((int)(((byte)(181)))));
            this.pnlBarraControl.Controls.Add(this.btnExpandirMenu);
            this.pnlBarraControl.Controls.Add(this.btnMaximizar);
            this.pnlBarraControl.Controls.Add(this.btnCerrar);
            this.pnlBarraControl.Controls.Add(this.btnMinimizar);
            this.pnlBarraControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraControl.Location = new System.Drawing.Point(224, 0);
            this.pnlBarraControl.Name = "pnlBarraControl";
            this.pnlBarraControl.Size = new System.Drawing.Size(556, 32);
            this.pnlBarraControl.TabIndex = 4;
            this.pnlBarraControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraControl_MouseDown);
            // 
            // btnExpandirMenu
            // 
            this.btnExpandirMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpandirMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExpandirMenu.Image = global::PruebaConexionDB.Properties.Resources.menu;
            this.btnExpandirMenu.Location = new System.Drawing.Point(0, 0);
            this.btnExpandirMenu.Name = "btnExpandirMenu";
            this.btnExpandirMenu.Size = new System.Drawing.Size(44, 32);
            this.btnExpandirMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExpandirMenu.TabIndex = 16;
            this.btnExpandirMenu.TabStop = false;
            this.btnExpandirMenu.Click += new System.EventHandler(this.btnExpandirMenu_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::PruebaConexionDB.Properties.Resources.cuadrado;
            this.btnMaximizar.Location = new System.Drawing.Point(468, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(44, 32);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 15;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::PruebaConexionDB.Properties.Resources.cerrarIcon;
            this.btnCerrar.Location = new System.Drawing.Point(512, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::PruebaConexionDB.Properties.Resources.menos;
            this.btnMinimizar.Location = new System.Drawing.Point(424, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(44, 32);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 14;
            this.btnMinimizar.TabStop = false;
            // 
            // menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PruebaConexionDB.Properties.Resources.fondoClinica;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.pnlBarraControl);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.lblMensajeAdmin);
            this.Controls.Add(this.lblAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menuAdmin_Load);
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBarraControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExpandirMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblMensajeAdmin;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel pnlBarraControl;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnExpandirMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnCitas;
    }
}