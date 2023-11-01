using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PruebaConexionDB
{
    public partial class menuAdmin : Form
    {
        public menuAdmin(string nombre)
        {
            InitializeComponent();
            lblMensajeAdmin.Text = nombre;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            principalUsuario principalUsuario = new principalUsuario();

            this.Hide();

            principalUsuario.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void menuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBarraControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExpandirMenu_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 224)
            {
                Menu.Width = 64;
            }
            else
                Menu.Width = 224;
        }
    }
}
