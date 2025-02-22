﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JorgeM.SistemaVentas.CapaEntidad;
using JorgeM.SistemaVentas.CapaNegocio;
namespace JorgeM.SistemaVentas.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario? usuario =  new CN_Usuario().Listar().FirstOrDefault(u => u.Documento == txtDocumento.Text && u.Clave == txtClave.Text);

            if(usuario != null)
            {
                Inicio form = new Inicio(usuario);
                form.Show();
                this.Hide();
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontró al usuario","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }           

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            txtDocumento.Text = string.Empty;
            txtClave.Text = string.Empty;           

        }
    }
}
