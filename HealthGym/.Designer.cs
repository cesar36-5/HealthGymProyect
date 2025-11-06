namespace HealthGym
{
    partial class MantenedorTrabajador
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
            dgvTrabajador = new DataGridView();
            grpDatosTrabajador = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Nombres = new Label();
            txtSalario = new TextBox();
            txtEspecialidad = new TextBox();
            txtCorreo = new TextBox();
            txtCargo = new TextBox();
            txtTelefono = new TextBox();
            txtSexo = new TextBox();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            btnCancelar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            btnBuscar = new Button();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            txtDNI = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTrabajador).BeginInit();
            grpDatosTrabajador.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTrabajador
            // 
            dgvTrabajador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrabajador.Location = new Point(12, 12);
            dgvTrabajador.Name = "dgvTrabajador";
            dgvTrabajador.RowHeadersWidth = 51;
            dgvTrabajador.Size = new Size(876, 231);
            dgvTrabajador.TabIndex = 0;
            dgvTrabajador.CellContentClick += dgvTrabajador_CellContentClick;
            // 
            // grpDatosTrabajador
            // 
            grpDatosTrabajador.Controls.Add(label8);
            grpDatosTrabajador.Controls.Add(label7);
            grpDatosTrabajador.Controls.Add(label6);
            grpDatosTrabajador.Controls.Add(label5);
            grpDatosTrabajador.Controls.Add(label4);
            grpDatosTrabajador.Controls.Add(label3);
            grpDatosTrabajador.Controls.Add(label2);
            grpDatosTrabajador.Controls.Add(Nombres);
            grpDatosTrabajador.Controls.Add(txtSalario);
            grpDatosTrabajador.Controls.Add(txtEspecialidad);
            grpDatosTrabajador.Controls.Add(txtCorreo);
            grpDatosTrabajador.Controls.Add(txtCargo);
            grpDatosTrabajador.Controls.Add(txtTelefono);
            grpDatosTrabajador.Controls.Add(txtSexo);
            grpDatosTrabajador.Controls.Add(txtApellidos);
            grpDatosTrabajador.Controls.Add(txtNombres);
            grpDatosTrabajador.Controls.Add(btnCancelar);
            grpDatosTrabajador.Controls.Add(btnModificar);
            grpDatosTrabajador.Controls.Add(btnGuardar);
            grpDatosTrabajador.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            grpDatosTrabajador.Location = new Point(12, 309);
            grpDatosTrabajador.Name = "grpDatosTrabajador";
            grpDatosTrabajador.Size = new Size(893, 290);
            grpDatosTrabajador.TabIndex = 1;
            grpDatosTrabajador.TabStop = false;
            grpDatosTrabajador.Text = "Datos del Trabajador";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Constantia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(375, 237);
            label8.Name = "label8";
            label8.Size = new Size(73, 24);
            label8.TabIndex = 17;
            label8.Text = "Salario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(372, 167);
            label7.Name = "label7";
            label7.Size = new Size(117, 24);
            label7.TabIndex = 16;
            label7.Text = "Especialidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(376, 100);
            label6.Name = "label6";
            label6.Size = new Size(73, 24);
            label6.TabIndex = 15;
            label6.Text = "Correo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(376, 44);
            label5.Name = "label5";
            label5.Size = new Size(66, 24);
            label5.TabIndex = 14;
            label5.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 242);
            label4.Name = "label4";
            label4.Size = new Size(85, 24);
            label4.TabIndex = 13;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 172);
            label3.Name = "label3";
            label3.Size = new Size(54, 24);
            label3.TabIndex = 12;
            label3.Text = "Sexo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 105);
            label2.Name = "label2";
            label2.Size = new Size(90, 24);
            label2.TabIndex = 11;
            label2.Text = "Apellidos:";
            // 
            // Nombres
            // 
            Nombres.AutoSize = true;
            Nombres.Font = new Font("Constantia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Nombres.Location = new Point(28, 40);
            Nombres.Name = "Nombres";
            Nombres.Size = new Size(92, 24);
            Nombres.TabIndex = 10;
            Nombres.Text = "Nombres:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(495, 236);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(125, 31);
            txtSalario.TabIndex = 10;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(495, 166);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(125, 31);
            txtEspecialidad.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(495, 99);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 31);
            txtCorreo.TabIndex = 8;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(495, 39);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(125, 31);
            txtCargo.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(144, 242);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 31);
            txtTelefono.TabIndex = 6;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(144, 172);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(125, 31);
            txtSexo.TabIndex = 5;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(144, 99);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(125, 31);
            txtApellidos.TabIndex = 4;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(144, 39);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(125, 31);
            txtNombres.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Georgia", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(782, 99);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Georgia", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(782, 160);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Georgia", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(782, 39);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(930, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(930, 68);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(930, 125);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(930, 180);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(930, 237);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(930, 298);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 265);
            label1.Name = "label1";
            label1.Size = new Size(48, 22);
            label1.TabIndex = 8;
            label1.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(131, 263);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(160, 27);
            txtDNI.TabIndex = 9;
            // 
            // MantenedorTrabajador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 622);
            Controls.Add(txtDNI);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(grpDatosTrabajador);
            Controls.Add(dgvTrabajador);
            Name = "MantenedorTrabajador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantenedorTrabajador";
            ((System.ComponentModel.ISupportInitialize)dgvTrabajador).EndInit();
            grpDatosTrabajador.ResumeLayout(false);
            grpDatosTrabajador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTrabajador;
        private GroupBox grpDatosTrabajador;
        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnSalir;
        private Button btnCancelar;
        private Button btnModificar;
        private Button btnGuardar;
        private TextBox txtSalario;
        private TextBox txtEspecialidad;
        private TextBox txtCorreo;
        private TextBox txtCargo;
        private TextBox txtTelefono;
        private TextBox txtSexo;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private Label label1;
        private TextBox txtDNI;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Nombres;
    }
}