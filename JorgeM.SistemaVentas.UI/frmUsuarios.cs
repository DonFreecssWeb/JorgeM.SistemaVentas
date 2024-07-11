using JorgeM.SistemaVentas.CapaEntidad;
using JorgeM.SistemaVentas.CapaNegocio;
using JorgeM.SistemaVentas.UI.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JorgeM.SistemaVentas.UI
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            comboEstado.Items.Add(new OpcionCombo { Value = 1, Text = "Activo" });
            comboEstado.Items.Add(new OpcionCombo { Value = 0, Text = "Inactivo" });


            comboEstado.DisplayMember = "Text";
            comboEstado.ValueMember = "Value";
            comboEstado.SelectedIndex = 0;

            foreach(DataGridViewColumn column in dgvData.Columns)
            {
                //solo columnas visibles, sin ids y sin la primera columna que es el botón
                if (column.Visible && column.Name != "btnSeleccionar")
                {
                    comboBusqueda.Items.Add(new OpcionCombo { Value = column.Name, Text = column.HeaderText });
                };
            }

            comboBusqueda.DisplayMember = "Text";
            comboBusqueda.ValueMember = "Value";
            comboBusqueda.SelectedIndex = 0;

            var roles = new CN_Rol().Listar();

            foreach (Rol role in roles)
            {
                comboRol.Items.Add(new OpcionCombo { Value = role.IdRol, Text = role.Descripcion });
            }

            comboRol.DisplayMember = "Text";
            comboRol.ValueMember = "Value";
            comboRol.SelectedIndex = 0;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Add(new object[] { "", txtId.Text, txtDocumento.Text, txtNombreCompleto.Text, txtCorreo.Text });

            Limpiar();
        }

        private void Limpiar()
        {     
            foreach( var item in panel1.Controls)
            {
                if(item is TextBox t)
                {
                    t.Clear();
                    comboRol.SelectedIndex = 0;
                    comboEstado.SelectedIndex=0;
                }
            }                       
        }
    }
}
