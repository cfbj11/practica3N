﻿using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3N
{
    public partial class RegistrationForm : MetroFramework.Forms.MetroForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void mbtnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbName.Text) ||
                string.IsNullOrWhiteSpace(mtbLastName.Text) ||
                string.IsNullOrWhiteSpace(mtbEmail.Text) ||
                string.IsNullOrWhiteSpace(mtbContraseña.Text) ||
                string.IsNullOrWhiteSpace(mtbConfirm.Text))
            {
                MetroMessageBox.Show(this, "No estan completos todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else if (!mtbEmail.Text.Contains("@"))
            {
                MetroMessageBox.Show(this, "El campo correo debe contener un arroba", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else if (mtbContraseña.Text != mtbConfirm.Text)
            {
                MetroMessageBox.Show(this, "Las contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MetroMessageBox.Show(this, "Usuario registrado exitosamente", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
 