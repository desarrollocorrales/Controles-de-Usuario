using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlesPersonalizados.BasesDeDatos
{
    public partial class DBConfig : UserControl
    {
        public string Servidor;
        public string Usuario;
        public string Contraseña;
        public string BaseDeDatos;
        public int Puerto;
        
        public DBConfig()
        {
            InitializeComponent();
        }

        private void txbServidor_TextChanged(object sender, EventArgs e)
        {
            Servidor = txbServidor.Text.ToLower();
        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {
            Usuario = txbUsuario.Text.ToLower();
        }

        private void txbContraseña_TextChanged(object sender, EventArgs e)
        {
            Contraseña = txbContraseña.Text.ToLower();
        }

        private void txbPuerto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Puerto = Convert.ToInt32(txbPuerto.Text);
            }
            catch (Exception ex)
            {
                Puerto = 0;
                MessageBox.Show(ex.Message);
            }
        }

        private void txbBaseDeDatos_TextChanged(object sender, EventArgs e)
        {
            BaseDeDatos = txbBaseDeDatos.Text.ToLower();
        }
    }
}
