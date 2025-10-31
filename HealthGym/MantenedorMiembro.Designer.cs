namespace HealthGym
{
    partial class MantenedorMiembro
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
            dgvMiembros = new DataGridView();
            groupMiembro = new GroupBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            dtpFin = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            dtpFecha = new DateTimePicker();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSanguineo = new TextBox();
            txtNombres = new TextBox();
            txtSexo = new TextBox();
            txtTelefono = new TextBox();
            txtApellidos = new TextBox();
            txtSeguro = new TextBox();
            txtCorreo = new TextBox();
            txtId = new TextBox();
            btnAgregar = new Button();
            btnSalir = new Button();
            btnBuscar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            label1 = new Label();
            txtDNI = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMiembros).BeginInit();
            groupMiembro.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMiembros
            // 
            dgvMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMiembros.Location = new Point(12, 12);
            dgvMiembros.Name = "dgvMiembros";
            dgvMiembros.RowHeadersWidth = 51;
            dgvMiembros.Size = new Size(935, 225);
            dgvMiembros.TabIndex = 0;
            dgvMiembros.CellContentClick += dgvMiembros_CellContentClick;
            // 
            // groupMiembro
            // 
            groupMiembro.Controls.Add(btnCancelar);
            groupMiembro.Controls.Add(btnGuardar);
            groupMiembro.Controls.Add(btnModificar);
            groupMiembro.Controls.Add(dtpFin);
            groupMiembro.Controls.Add(dtpInicio);
            groupMiembro.Controls.Add(dtpFecha);
            groupMiembro.Controls.Add(label12);
            groupMiembro.Controls.Add(label11);
            groupMiembro.Controls.Add(label10);
            groupMiembro.Controls.Add(label9);
            groupMiembro.Controls.Add(label8);
            groupMiembro.Controls.Add(label7);
            groupMiembro.Controls.Add(label6);
            groupMiembro.Controls.Add(label5);
            groupMiembro.Controls.Add(label4);
            groupMiembro.Controls.Add(label3);
            groupMiembro.Controls.Add(label2);
            groupMiembro.Controls.Add(txtSanguineo);
            groupMiembro.Controls.Add(txtNombres);
            groupMiembro.Controls.Add(txtSexo);
            groupMiembro.Controls.Add(txtTelefono);
            groupMiembro.Controls.Add(txtApellidos);
            groupMiembro.Controls.Add(txtSeguro);
            groupMiembro.Controls.Add(txtCorreo);
            groupMiembro.Controls.Add(txtId);
            groupMiembro.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupMiembro.Location = new Point(12, 282);
            groupMiembro.Name = "groupMiembro";
            groupMiembro.Size = new Size(935, 328);
            groupMiembro.TabIndex = 1;
            groupMiembro.TabStop = false;
            groupMiembro.Text = "Datos del Miembro";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(815, 175);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(815, 118);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(815, 58);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(102, 29);
            btnModificar.TabIndex = 22;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dtpFin
            // 
            dtpFin.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dtpFin.Location = new Point(512, 291);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(250, 27);
            dtpFin.TabIndex = 21;
            // 
            // dtpInicio
            // 
            dtpInicio.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dtpInicio.Location = new Point(512, 241);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(250, 27);
            dtpInicio.TabIndex = 20;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dtpFecha.Location = new Point(512, 38);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(245, 27);
            dtpFecha.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(318, 295);
            label12.Name = "label12";
            label12.Size = new Size(161, 23);
            label12.TabIndex = 18;
            label12.Text = "Fin de Membresia:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(318, 245);
            label11.Name = "label11";
            label11.Size = new Size(180, 23);
            label11.TabIndex = 17;
            label11.Text = "Inicio de Membresia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(318, 190);
            label10.Name = "label10";
            label10.Size = new Size(73, 23);
            label10.TabIndex = 16;
            label10.Text = "Seguro:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(318, 140);
            label9.Name = "label9";
            label9.Size = new Size(159, 23);
            label9.TabIndex = 15;
            label9.Text = "Grupo Sanguineo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 99);
            label8.Name = "label8";
            label8.Size = new Size(89, 23);
            label8.TabIndex = 14;
            label8.Text = "Nombres:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 153);
            label7.Name = "label7";
            label7.Size = new Size(90, 23);
            label7.TabIndex = 13;
            label7.Text = "Apellidos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 211);
            label6.Name = "label6";
            label6.Size = new Size(53, 23);
            label6.TabIndex = 12;
            label6.Text = "Sexo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 267);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 11;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 41);
            label4.Name = "label4";
            label4.Size = new Size(188, 23);
            label4.TabIndex = 10;
            label4.Text = "Fecha de Nacimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 88);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 9;
            label3.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 47);
            label2.Name = "label2";
            label2.Size = new Size(34, 23);
            label2.TabIndex = 8;
            label2.Text = "ID:";
            // 
            // txtSanguineo
            // 
            txtSanguineo.Location = new Point(483, 137);
            txtSanguineo.Name = "txtSanguineo";
            txtSanguineo.Size = new Size(125, 31);
            txtSanguineo.TabIndex = 7;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(122, 96);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(125, 31);
            txtNombres.TabIndex = 6;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(122, 208);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(125, 31);
            txtSexo.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(122, 264);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 31);
            txtTelefono.TabIndex = 4;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(122, 150);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(125, 31);
            txtApellidos.TabIndex = 3;
            // 
            // txtSeguro
            // 
            txtSeguro.Location = new Point(424, 188);
            txtSeguro.Name = "txtSeguro";
            txtSeguro.Size = new Size(125, 31);
            txtSeguro.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(424, 85);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 31);
            txtCorreo.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(122, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 31);
            txtId.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(969, 22);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(969, 309);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(969, 256);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(969, 199);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(969, 137);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(969, 78);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 256);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 8;
            label1.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(219, 249);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(125, 27);
            txtDNI.TabIndex = 9;
            // 
            // MantenedorMiembro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 622);
            Controls.Add(txtDNI);
            Controls.Add(label1);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnBuscar);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(groupMiembro);
            Controls.Add(dgvMiembros);
            Name = "MantenedorMiembro";
            Text = "MantenedorMiembro";
            ((System.ComponentModel.ISupportInitialize)dgvMiembros).EndInit();
            groupMiembro.ResumeLayout(false);
            groupMiembro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMiembros;
        private GroupBox groupMiembro;
        private Button btnAgregar;
        private Button btnSalir;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnEditar;
        private Label label1;
        private TextBox txtDNI;
        private TextBox txtNombres;
        private TextBox txtSexo;
        private TextBox txtTelefono;
        private TextBox txtApellidos;
        private TextBox txtSeguro;
        private TextBox txtCorreo;
        private TextBox txtId;
        private TextBox txtSanguineo;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFecha;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnModificar;
    }
}