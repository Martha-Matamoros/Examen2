using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;

namespace Examen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuarios usuario = new Usuarios();

            usuario = usuarioDA.Login(UsuarioTxt.Text, ContraseñaTxt.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuario y Contraseña incorrecta");
                return;
            }
            else if(!usuario.EstaActivo)
            {
                MessageBox.Show("Usuario Inactivo");
                return;
            }

            Menu menu = new Menu();
            menu.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
