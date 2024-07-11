namespace JorgeM.SistemaVentas.UI
{
    partial class frmUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtId = new TextBox();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            comboEstado = new ComboBox();
            comboRol = new ComboBox();
            txtConfirmarClave = new TextBox();
            txtClave = new TextBox();
            txtCorreo = new TextBox();
            txtNombreCompleto = new TextBox();
            txtDocumento = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            label1 = new Label();
            dgvData = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            idusuario = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            label9 = new Label();
            label10 = new Label();
            comboBusqueda = new ComboBox();
            txtBusqueda = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(comboEstado);
            panel1.Controls.Add(comboRol);
            panel1.Controls.Add(txtConfirmarClave);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtNombreCompleto);
            panel1.Controls.Add(txtDocumento);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 642);
            panel1.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(205, 65);
            txtId.Name = "txtId";
            txtId.Size = new Size(68, 27);
            txtId.TabIndex = 4;
            txtId.Text = "0";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 16;
            btnEliminar.ImageAlign = ContentAlignment.MiddleRight;
            btnEliminar.Location = new Point(28, 589);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(245, 27);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.RoyalBlue;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.Black;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnEditar.IconColor = Color.White;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 16;
            btnEditar.ImageAlign = ContentAlignment.MiddleRight;
            btnEditar.Location = new Point(28, 555);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(245, 27);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 16;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(28, 521);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(245, 27);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // comboEstado
            // 
            comboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEstado.FormattingEnabled = true;
            comboEstado.Location = new Point(28, 466);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(245, 28);
            comboEstado.TabIndex = 2;
            // 
            // comboRol
            // 
            comboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRol.FormattingEnabled = true;
            comboRol.Location = new Point(28, 404);
            comboRol.Name = "comboRol";
            comboRol.Size = new Size(245, 28);
            comboRol.TabIndex = 2;
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(28, 343);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.PasswordChar = '*';
            txtConfirmarClave.Size = new Size(245, 27);
            txtConfirmarClave.TabIndex = 1;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(28, 282);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(245, 27);
            txtClave.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(28, 221);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(245, 27);
            txtCorreo.TabIndex = 1;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(28, 160);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(245, 27);
            txtNombreCompleto.TabIndex = 1;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(28, 99);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(245, 27);
            txtDocumento.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 439);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 0;
            label7.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 377);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 0;
            label6.Text = "Rol";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 316);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 0;
            label5.Text = "Confirmar Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 255);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 0;
            label4.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 194);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 0;
            label3.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 133);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre Completo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 24);
            label8.Name = "label8";
            label8.Size = new Size(170, 31);
            label8.TabIndex = 0;
            label8.Text = "Detalle Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 72);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Nro Documento";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, idusuario, Documento, NombreCompleto, Correo, IdRol, rol, EstadoValor, estado });
            dgvData.Location = new Point(340, 87);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(974, 517);
            dgvData.TabIndex = 1;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.MinimumWidth = 6;
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 30;
            // 
            // idusuario
            // 
            idusuario.HeaderText = "Idusuario";
            idusuario.MinimumWidth = 6;
            idusuario.Name = "idusuario";
            idusuario.ReadOnly = true;
            idusuario.Visible = false;
            idusuario.Width = 125;
            // 
            // Documento
            // 
            Documento.HeaderText = "Nro Documento";
            Documento.MinimumWidth = 6;
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 180;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 150;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "idrol";
            IdRol.MinimumWidth = 6;
            IdRol.Name = "IdRol";
            IdRol.ReadOnly = true;
            IdRol.Visible = false;
            IdRol.Width = 125;
            // 
            // rol
            // 
            rol.HeaderText = "Rol";
            rol.MinimumWidth = 6;
            rol.Name = "rol";
            rol.ReadOnly = true;
            rol.Width = 125;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.MinimumWidth = 6;
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            EstadoValor.Width = 125;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Width = 125;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(340, 19);
            label9.Name = "label9";
            label9.Size = new Size(200, 35);
            label9.TabIndex = 2;
            label9.Text = "Lista de usuarios";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(603, 30);
            label10.Name = "label10";
            label10.Size = new Size(79, 20);
            label10.TabIndex = 3;
            label10.Text = "Buscar por";
            // 
            // comboBusqueda
            // 
            comboBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBusqueda.FormattingEnabled = true;
            comboBusqueda.Location = new Point(707, 24);
            comboBusqueda.Name = "comboBusqueda";
            comboBusqueda.Size = new Size(156, 28);
            comboBusqueda.TabIndex = 2;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(889, 30);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(191, 27);
            txtBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.ForestGreen;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.Black;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 16;
            btnBuscar.Location = new Point(1111, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(63, 27);
            btnBuscar.TabIndex = 3;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.RoyalBlue;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.Black;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = Color.White;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 16;
            btnLimpiar.Location = new Point(1198, 30);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(63, 27);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 642);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvData);
            Controls.Add(btnBuscar);
            Controls.Add(panel1);
            Controls.Add(comboBusqueda);
            Controls.Add(txtBusqueda);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox comboRol;
        private TextBox txtConfirmarClave;
        private TextBox txtClave;
        private TextBox txtCorreo;
        private TextBox txtNombreCompleto;
        private TextBox txtDocumento;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboEstado;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label label8;
        private DataGridView dgvData;
        private Label label9;
        private TextBox txtId;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn idusuario;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn estado;
        private Label label10;
        private ComboBox comboBusqueda;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
    }
}