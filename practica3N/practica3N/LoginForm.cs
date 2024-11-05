using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practica3N.models;

namespace practica3N
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void mbtnIniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbUser.Text) || string.IsNullOrWhiteSpace(mtbPsw.Text))
            {
                MetroMessageBox.Show(this, "No se han completado todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mtbUser.Text == "admin" && mtbPsw.Text == "1234")
            {
                MetroMessageBox.Show(this, "Bienvenido", "Inicio de sesion exitoso", MessageBoxButtons.OK);
            }
        }
    }
}
