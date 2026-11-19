namespace Reto
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            dgvContactos = new DataGridView();
            lblTotal = new Label();
            lblRegistro = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            btnAgregar = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnEliminar = new Button();
            btnGuardarCambios = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(25, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(181, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agenda de contactos";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(118, 49);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(150, 31);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.FromArgb(255, 192, 128);
            lblBuscar.Location = new Point(35, 49);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(63, 25);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Buscar";
            // 
            // dgvContactos
            // 
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.Location = new Point(25, 98);
            dgvContactos.Name = "dgvContactos";
            dgvContactos.RowHeadersWidth = 62;
            dgvContactos.Size = new Size(437, 225);
            dgvContactos.TabIndex = 3;
            dgvContactos.CellDoubleClick += dgvContactos_CellDoubleClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(25, 356);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 26);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: ";
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(539, 24);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(158, 25);
            lblRegistro.TabIndex = 5;
            lblRegistro.Text = "Registrar Contacto";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(469, 55);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 25);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(468, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(201, 31);
            txtNombre.TabIndex = 7;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(468, 147);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(88, 25);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Telefono: ";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(468, 187);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(201, 31);
            txtTelefono.TabIndex = 9;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(468, 247);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(75, 25);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo: ";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(468, 292);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(201, 31);
            txtCorreo.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregar.Location = new Point(468, 347);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.Location = new Point(469, 404);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.FromArgb(255, 255, 192);
            btnGuardarCambios.Location = new Point(586, 347);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(162, 34);
            btnGuardarCambios.TabIndex = 14;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblRegistro);
            Controls.Add(lblTotal);
            Controls.Add(dgvContactos);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private DataGridView dgvContactos;
        private Label lblTotal;
        private Label lblRegistro;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Button btnAgregar;
        private ErrorProvider errorProvider1;
        private Button btnEliminar;
        private Button btnGuardarCambios;
    }
}
