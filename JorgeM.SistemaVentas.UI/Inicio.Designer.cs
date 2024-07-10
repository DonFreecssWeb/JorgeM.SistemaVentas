namespace JorgeM.SistemaVentas.UI
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblUsuario = new Label();
            label2 = new Label();
            label1 = new Label();
            menu = new MenuStrip();
            menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            submenuCategoria = new ToolStripMenuItem();
            submenuProducto = new ToolStripMenuItem();
            menuventas = new FontAwesome.Sharp.IconMenuItem();
            submenuRegistrarVenta = new ToolStripMenuItem();
            submenuVerDetalleVenta = new ToolStripMenuItem();
            menucompras = new FontAwesome.Sharp.IconMenuItem();
            submenuRegistrarCompra = new ToolStripMenuItem();
            submenuVerDetalleCompra = new ToolStripMenuItem();
            menuclientes = new FontAwesome.Sharp.IconMenuItem();
            menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            menureportes = new FontAwesome.Sharp.IconMenuItem();
            menuacercade = new FontAwesome.Sharp.IconMenuItem();
            contenedor = new Panel();
            panel1.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(877, 91);
            panel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(614, 43);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(76, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "lblUsuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(544, 43);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(244, 46);
            label1.TabIndex = 0;
            label1.Text = "Sistema Ventas";
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menuusuarios, menumantenedor, menuventas, menucompras, menuclientes, menuproveedores, menureportes, menuacercade });
            menu.Location = new Point(0, 91);
            menu.Name = "menu";
            menu.Size = new Size(877, 73);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // menuusuarios
            // 
            menuusuarios.AutoSize = false;
            menuusuarios.BackColor = Color.WhiteSmoke;
            menuusuarios.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            menuusuarios.IconColor = Color.Black;
            menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuusuarios.IconSize = 50;
            menuusuarios.ImageScaling = ToolStripItemImageScaling.None;
            menuusuarios.Name = "menuusuarios";
            menuusuarios.Size = new Size(90, 69);
            menuusuarios.Text = "Usuarios";
            menuusuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            menuusuarios.Click += menuusuarios_Click;
            // 
            // menumantenedor
            // 
            menumantenedor.AutoSize = false;
            menumantenedor.DropDownItems.AddRange(new ToolStripItem[] { submenuCategoria, submenuProducto });
            menumantenedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            menumantenedor.IconColor = Color.Black;
            menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menumantenedor.IconSize = 50;
            menumantenedor.ImageScaling = ToolStripItemImageScaling.None;
            menumantenedor.Name = "menumantenedor";
            menumantenedor.Size = new Size(90, 69);
            menumantenedor.Text = "Mantenedor";
            menumantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuCategoria
            // 
            submenuCategoria.Name = "submenuCategoria";
            submenuCategoria.Size = new Size(224, 26);
            submenuCategoria.Text = "Categoria";
            submenuCategoria.Click += submenuCategoria_Click;
            // 
            // submenuProducto
            // 
            submenuProducto.Name = "submenuProducto";
            submenuProducto.Size = new Size(224, 26);
            submenuProducto.Text = "Producto";
            submenuProducto.Click += submenuProducto_Click;
            // 
            // menuventas
            // 
            menuventas.AutoSize = false;
            menuventas.DropDownItems.AddRange(new ToolStripItem[] { submenuRegistrarVenta, submenuVerDetalleVenta });
            menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuventas.IconColor = Color.Black;
            menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuventas.IconSize = 50;
            menuventas.ImageScaling = ToolStripItemImageScaling.None;
            menuventas.Name = "menuventas";
            menuventas.Size = new Size(90, 69);
            menuventas.Text = "Ventas";
            menuventas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuRegistrarVenta
            // 
            submenuRegistrarVenta.Name = "submenuRegistrarVenta";
            submenuRegistrarVenta.Size = new Size(165, 26);
            submenuRegistrarVenta.Text = "Registrar";
            submenuRegistrarVenta.Click += submenuRegistrarVenta_Click;
            // 
            // submenuVerDetalleVenta
            // 
            submenuVerDetalleVenta.Name = "submenuVerDetalleVenta";
            submenuVerDetalleVenta.Size = new Size(165, 26);
            submenuVerDetalleVenta.Text = "Ver Detalle";
            submenuVerDetalleVenta.Click += submenuVerDetalleVenta_Click;
            // 
            // menucompras
            // 
            menucompras.AutoSize = false;
            menucompras.DropDownItems.AddRange(new ToolStripItem[] { submenuRegistrarCompra, submenuVerDetalleCompra });
            menucompras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            menucompras.IconColor = Color.Black;
            menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menucompras.IconSize = 50;
            menucompras.ImageScaling = ToolStripItemImageScaling.None;
            menucompras.Name = "menucompras";
            menucompras.Size = new Size(90, 69);
            menucompras.Text = "Compras";
            menucompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuRegistrarCompra
            // 
            submenuRegistrarCompra.Name = "submenuRegistrarCompra";
            submenuRegistrarCompra.Size = new Size(165, 26);
            submenuRegistrarCompra.Text = "Registrar";
            submenuRegistrarCompra.Click += submenuRegistrarCompra_Click;
            // 
            // submenuVerDetalleCompra
            // 
            submenuVerDetalleCompra.Name = "submenuVerDetalleCompra";
            submenuVerDetalleCompra.Size = new Size(165, 26);
            submenuVerDetalleCompra.Text = "Ver Detalle";
            submenuVerDetalleCompra.Click += submenuVerDetalleCompra_Click;
            // 
            // menuclientes
            // 
            menuclientes.AutoSize = false;
            menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            menuclientes.IconColor = Color.Black;
            menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuclientes.IconSize = 50;
            menuclientes.ImageScaling = ToolStripItemImageScaling.None;
            menuclientes.Name = "menuclientes";
            menuclientes.Size = new Size(90, 69);
            menuclientes.Text = "Clientes";
            menuclientes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuclientes.Click += menuclientes_Click;
            // 
            // menuproveedores
            // 
            menuproveedores.AutoSize = false;
            menuproveedores.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            menuproveedores.IconColor = Color.Black;
            menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuproveedores.IconSize = 50;
            menuproveedores.ImageScaling = ToolStripItemImageScaling.None;
            menuproveedores.Name = "menuproveedores";
            menuproveedores.Size = new Size(90, 69);
            menuproveedores.Text = "Proveedores";
            menuproveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            menuproveedores.Click += menuproveedores_Click;
            // 
            // menureportes
            // 
            menureportes.AutoSize = false;
            menureportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menureportes.IconColor = Color.Black;
            menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menureportes.IconSize = 50;
            menureportes.ImageScaling = ToolStripItemImageScaling.None;
            menureportes.Name = "menureportes";
            menureportes.Size = new Size(90, 69);
            menureportes.Text = "Reportes";
            menureportes.TextImageRelation = TextImageRelation.ImageAboveText;
            menureportes.Click += menureportes_Click;
            // 
            // menuacercade
            // 
            menuacercade.AutoSize = false;
            menuacercade.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            menuacercade.IconColor = Color.Black;
            menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuacercade.IconSize = 50;
            menuacercade.ImageScaling = ToolStripItemImageScaling.None;
            menuacercade.Name = "menuacercade";
            menuacercade.Size = new Size(90, 69);
            menuacercade.Text = "Acerca de";
            menuacercade.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // contenedor
            // 
            contenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contenedor.Location = new Point(0, 167);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(880, 376);
            contenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(877, 542);
            Controls.Add(menu);
            Controls.Add(panel1);
            Controls.Add(contenedor);
            MainMenuStrip = menu;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Inicio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private Panel contenedor;
        private Panel panel1;
        private Label lblUsuario;
        private Label label2;
        private Label label1;
        private ToolStripMenuItem submenuCategoria;
        private ToolStripMenuItem submenuProducto;
        private ToolStripMenuItem submenuRegistrarVenta;
        private ToolStripMenuItem submenuVerDetalleVenta;
        private ToolStripMenuItem submenuRegistrarCompra;
        private ToolStripMenuItem submenuVerDetalleCompra;
    }
}
