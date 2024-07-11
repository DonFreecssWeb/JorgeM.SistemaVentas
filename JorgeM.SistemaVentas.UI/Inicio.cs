using FontAwesome.Sharp;
using JorgeM.SistemaVentas.CapaEntidad;
using JorgeM.SistemaVentas.CapaNegocio;

namespace JorgeM.SistemaVentas.UI
{
    public partial class Inicio : Form
    {
        private static Usuario _usuarioActual;
        private static Form _formularioActivo = null;
        private static IconMenuItem _menuActivo;
        public Inicio(Usuario usuario = null)
        {
            if (usuario == null)
                _usuarioActual = new Usuario { NombreCompleto = "ADMIN PREDEF", IdUsuario = 1 };
            else
                _usuarioActual = usuario;
            InitializeComponent();

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //ver permisos del usuario logueado
            List<Permiso> listaPermisos = new CN_Permiso().Listar(_usuarioActual.IdUsuario);

            foreach(IconMenuItem iconmenu in menu.Items)
            {
                //si el usuario no tiene el permiso no mostrar el menu
               if(!listaPermisos.Any(m => m.NombreMenu == iconmenu.Name))
                {
                    iconmenu.Visible = false;
                }
            }
            lblUsuario.Text = _usuarioActual?.NombreCompleto;
        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }
        public void AbrirFormulario(IconMenuItem menuClick, Form form)
        {

            if (_menuActivo != null)
            {
                //menu anterior
                _menuActivo.BackColor = Color.WhiteSmoke;
            }
            menuClick.BackColor = Color.SkyBlue;
            _menuActivo = menuClick;

            //si ya hay formulario anterior, cerrarlo
            if (_formularioActivo != null)
            {
                _formularioActivo.Close();
            }

            _formularioActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(form);
            form.Show();

        }

        private void submenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmCategoria());
        }
        //no puedo enviarle un sender porque es un submenu y requiero un menu
        private void submenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmCategoria());
        }
        private void submenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentas());
        }
        private void submenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmDetalleVenta());
        }

        private void submenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCompras());
        }

        private void submenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmDetalleCompra());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }
    }
}
