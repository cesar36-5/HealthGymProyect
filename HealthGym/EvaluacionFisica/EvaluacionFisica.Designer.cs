namespace HealthGym.EvaluacionFisica
{
    partial class EvaluacionFisica_2
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
            label1 = new Label();
            grpDatMiembro = new GroupBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblEstadoCita = new Label();
            btnBuscarCita = new Button();
            txtDNI = new TextBox();
            lblDNI = new Label();
            grpEvaluacionFisica = new GroupBox();
            txtValoracion = new TextBox();
            lblValoracion = new Label();
            txtPostura = new TextBox();
            lblPostura = new Label();
            txtAntropometria = new TextBox();
            lblAntropometria = new Label();
            txtSignosVitales = new TextBox();
            lblSignosVitales = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            grpAcciones = new GroupBox();
            Cancelar = new Button();
            btnGuardar = new Button();
            dgvEvaluaciones = new DataGridView();
            grpDatMiembro.SuspendLayout();
            grpEvaluacionFisica.SuspendLayout();
            grpAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 0;
            label1.Text = "Evaluación Física";
            // 
            // grpDatMiembro
            // 
            grpDatMiembro.Controls.Add(txtNombre);
            grpDatMiembro.Controls.Add(lblNombre);
            grpDatMiembro.Controls.Add(lblEstadoCita);
            grpDatMiembro.Controls.Add(btnBuscarCita);
            grpDatMiembro.Controls.Add(txtDNI);
            grpDatMiembro.Controls.Add(lblDNI);
            grpDatMiembro.Location = new Point(16, 54);
            grpDatMiembro.Margin = new Padding(3, 2, 3, 2);
            grpDatMiembro.Name = "grpDatMiembro";
            grpDatMiembro.Padding = new Padding(3, 2, 3, 2);
            grpDatMiembro.Size = new Size(290, 159);
            grpDatMiembro.TabIndex = 1;
            grpDatMiembro.TabStop = false;
            grpDatMiembro.Text = "Datos del Miembro";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 124);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 23);
            txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(7, 124);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblEstadoCita
            // 
            lblEstadoCita.AutoSize = true;
            lblEstadoCita.Location = new Point(140, 76);
            lblEstadoCita.Name = "lblEstadoCita";
            lblEstadoCita.Size = new Size(42, 15);
            lblEstadoCita.TabIndex = 3;
            lblEstadoCita.Text = "Estado";
            // 
            // btnBuscarCita
            // 
            btnBuscarCita.Location = new Point(7, 68);
            btnBuscarCita.Margin = new Padding(3, 2, 3, 2);
            btnBuscarCita.Name = "btnBuscarCita";
            btnBuscarCita.Size = new Size(102, 32);
            btnBuscarCita.TabIndex = 2;
            btnBuscarCita.Text = "Verificar Cita";
            btnBuscarCita.UseVisualStyleBackColor = true;
            btnBuscarCita.Click += btnBuscarCita_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(130, 32);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(148, 23);
            txtDNI.TabIndex = 1;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(5, 32);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(98, 15);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI del miembro";
            // 
            // grpEvaluacionFisica
            // 
            grpEvaluacionFisica.Controls.Add(txtValoracion);
            grpEvaluacionFisica.Controls.Add(lblValoracion);
            grpEvaluacionFisica.Controls.Add(txtPostura);
            grpEvaluacionFisica.Controls.Add(lblPostura);
            grpEvaluacionFisica.Controls.Add(txtAntropometria);
            grpEvaluacionFisica.Controls.Add(lblAntropometria);
            grpEvaluacionFisica.Controls.Add(txtSignosVitales);
            grpEvaluacionFisica.Controls.Add(lblSignosVitales);
            grpEvaluacionFisica.Controls.Add(dtpFecha);
            grpEvaluacionFisica.Controls.Add(lblFecha);
            grpEvaluacionFisica.Location = new Point(312, 54);
            grpEvaluacionFisica.Margin = new Padding(3, 2, 3, 2);
            grpEvaluacionFisica.Name = "grpEvaluacionFisica";
            grpEvaluacionFisica.Padding = new Padding(3, 2, 3, 2);
            grpEvaluacionFisica.Size = new Size(463, 159);
            grpEvaluacionFisica.TabIndex = 2;
            grpEvaluacionFisica.TabStop = false;
            grpEvaluacionFisica.Text = "Datos de Evaluación Física";
            // 
            // txtValoracion
            // 
            txtValoracion.Location = new Point(144, 134);
            txtValoracion.Margin = new Padding(3, 2, 3, 2);
            txtValoracion.Multiline = true;
            txtValoracion.Name = "txtValoracion";
            txtValoracion.Size = new Size(217, 21);
            txtValoracion.TabIndex = 15;
            // 
            // lblValoracion
            // 
            lblValoracion.AutoSize = true;
            lblValoracion.Location = new Point(13, 140);
            lblValoracion.Name = "lblValoracion";
            lblValoracion.Size = new Size(62, 15);
            lblValoracion.TabIndex = 14;
            lblValoracion.Text = "Valoracion";
            // 
            // txtPostura
            // 
            txtPostura.Location = new Point(144, 105);
            txtPostura.Margin = new Padding(3, 2, 3, 2);
            txtPostura.Multiline = true;
            txtPostura.Name = "txtPostura";
            txtPostura.Size = new Size(217, 21);
            txtPostura.TabIndex = 13;
            // 
            // lblPostura
            // 
            lblPostura.AutoSize = true;
            lblPostura.Location = new Point(13, 110);
            lblPostura.Name = "lblPostura";
            lblPostura.Size = new Size(47, 15);
            lblPostura.TabIndex = 12;
            lblPostura.Text = "Postura";
            // 
            // txtAntropometria
            // 
            txtAntropometria.Location = new Point(144, 74);
            txtAntropometria.Margin = new Padding(3, 2, 3, 2);
            txtAntropometria.Multiline = true;
            txtAntropometria.Name = "txtAntropometria";
            txtAntropometria.Size = new Size(217, 21);
            txtAntropometria.TabIndex = 11;
            // 
            // lblAntropometria
            // 
            lblAntropometria.AutoSize = true;
            lblAntropometria.Location = new Point(13, 76);
            lblAntropometria.Name = "lblAntropometria";
            lblAntropometria.Size = new Size(85, 15);
            lblAntropometria.TabIndex = 10;
            lblAntropometria.Text = "Antropometría";
            // 
            // txtSignosVitales
            // 
            txtSignosVitales.Location = new Point(144, 42);
            txtSignosVitales.Margin = new Padding(3, 2, 3, 2);
            txtSignosVitales.Multiline = true;
            txtSignosVitales.Name = "txtSignosVitales";
            txtSignosVitales.Size = new Size(217, 21);
            txtSignosVitales.TabIndex = 9;
            // 
            // lblSignosVitales
            // 
            lblSignosVitales.AutoSize = true;
            lblSignosVitales.Location = new Point(13, 47);
            lblSignosVitales.Name = "lblSignosVitales";
            lblSignosVitales.Size = new Size(76, 15);
            lblSignosVitales.TabIndex = 8;
            lblSignosVitales.Text = "SignosVitales";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(144, 16);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(238, 23);
            dtpFecha.TabIndex = 7;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(13, 22);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(114, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha de evaluación";
            // 
            // grpAcciones
            // 
            grpAcciones.Controls.Add(Cancelar);
            grpAcciones.Controls.Add(btnGuardar);
            grpAcciones.Location = new Point(789, 54);
            grpAcciones.Margin = new Padding(3, 2, 3, 2);
            grpAcciones.Name = "grpAcciones";
            grpAcciones.Padding = new Padding(3, 2, 3, 2);
            grpAcciones.Size = new Size(225, 159);
            grpAcciones.TabIndex = 3;
            grpAcciones.TabStop = false;
            grpAcciones.Text = "Acciones";
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(52, 93);
            Cancelar.Margin = new Padding(3, 2, 3, 2);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(102, 32);
            Cancelar.TabIndex = 7;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(52, 30);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 32);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvEvaluaciones
            // 
            dgvEvaluaciones.AccessibleName = "";
            dgvEvaluaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvaluaciones.Location = new Point(28, 236);
            dgvEvaluaciones.Margin = new Padding(3, 2, 3, 2);
            dgvEvaluaciones.Name = "dgvEvaluaciones";
            dgvEvaluaciones.RowHeadersWidth = 51;
            dgvEvaluaciones.Size = new Size(915, 189);
            dgvEvaluaciones.TabIndex = 4;
            // 
            // EvaluacionFisica_2
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 487);
            Controls.Add(dgvEvaluaciones);
            Controls.Add(grpAcciones);
            Controls.Add(grpEvaluacionFisica);
            Controls.Add(grpDatMiembro);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EvaluacionFisica_2";
            Text = "EvaluacionFisica";
            Load += EvaluacionFisica_2_Load;
            grpDatMiembro.ResumeLayout(false);
            grpDatMiembro.PerformLayout();
            grpEvaluacionFisica.ResumeLayout(false);
            grpEvaluacionFisica.PerformLayout();
            grpAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpDatMiembro;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblEstadoCita;
        private Button btnBuscarCita;
        private TextBox txtDNI;
        private Label lblDNI;
        private GroupBox grpEvaluacionFisica;
        private TextBox txtAntropometria;
        private Label lblAntropometria;
        private TextBox txtSignosVitales;
        private Label lblSignosVitales;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private TextBox txtValoracion;
        private Label lblValoracion;
        private TextBox txtPostura;
        private Label lblPostura;
        private GroupBox grpAcciones;
        private Button Cancelar;
        private Button btnGuardar;
        private DataGridView dgvEvaluaciones;
    }
}