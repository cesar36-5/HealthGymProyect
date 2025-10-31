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
            label1.Location = new Point(15, 18);
            label1.Name = "label1";
            label1.Size = new Size(227, 32);
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
            grpDatMiembro.Location = new Point(18, 72);
            grpDatMiembro.Name = "grpDatMiembro";
            grpDatMiembro.Size = new Size(332, 212);
            grpDatMiembro.TabIndex = 1;
            grpDatMiembro.TabStop = false;
            grpDatMiembro.Text = "Datos del Miembro";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 165);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 27);
            txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(8, 165);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblEstadoCita
            // 
            lblEstadoCita.AutoSize = true;
            lblEstadoCita.Location = new Point(160, 101);
            lblEstadoCita.Name = "lblEstadoCita";
            lblEstadoCita.Size = new Size(54, 20);
            lblEstadoCita.TabIndex = 3;
            lblEstadoCita.Text = "Estado";
            // 
            // btnBuscarCita
            // 
            btnBuscarCita.Location = new Point(8, 90);
            btnBuscarCita.Name = "btnBuscarCita";
            btnBuscarCita.Size = new Size(117, 43);
            btnBuscarCita.TabIndex = 2;
            btnBuscarCita.Text = "Verificar Cita";
            btnBuscarCita.UseVisualStyleBackColor = true;
            btnBuscarCita.Click += btnBuscarCita_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(148, 42);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(169, 27);
            txtDNI.TabIndex = 1;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(6, 42);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(125, 20);
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
            grpEvaluacionFisica.Location = new Point(356, 72);
            grpEvaluacionFisica.Name = "grpEvaluacionFisica";
            grpEvaluacionFisica.Size = new Size(529, 212);
            grpEvaluacionFisica.TabIndex = 2;
            grpEvaluacionFisica.TabStop = false;
            grpEvaluacionFisica.Text = "Datos de Evaluación Física";
            // 
            // txtValoracion
            // 
            txtValoracion.Location = new Point(164, 179);
            txtValoracion.Multiline = true;
            txtValoracion.Name = "txtValoracion";
            txtValoracion.Size = new Size(247, 27);
            txtValoracion.TabIndex = 15;
            // 
            // lblValoracion
            // 
            lblValoracion.AutoSize = true;
            lblValoracion.Location = new Point(15, 186);
            lblValoracion.Name = "lblValoracion";
            lblValoracion.Size = new Size(79, 20);
            lblValoracion.TabIndex = 14;
            lblValoracion.Text = "Valoracion";
            // 
            // txtPostura
            // 
            txtPostura.Location = new Point(164, 140);
            txtPostura.Multiline = true;
            txtPostura.Name = "txtPostura";
            txtPostura.Size = new Size(247, 27);
            txtPostura.TabIndex = 13;
            // 
            // lblPostura
            // 
            lblPostura.AutoSize = true;
            lblPostura.Location = new Point(15, 147);
            lblPostura.Name = "lblPostura";
            lblPostura.Size = new Size(57, 20);
            lblPostura.TabIndex = 12;
            lblPostura.Text = "Postura";
            // 
            // txtAntropometria
            // 
            txtAntropometria.Location = new Point(164, 98);
            txtAntropometria.Multiline = true;
            txtAntropometria.Name = "txtAntropometria";
            txtAntropometria.Size = new Size(247, 27);
            txtAntropometria.TabIndex = 11;
            // 
            // lblAntropometria
            // 
            lblAntropometria.AutoSize = true;
            lblAntropometria.Location = new Point(15, 101);
            lblAntropometria.Name = "lblAntropometria";
            lblAntropometria.Size = new Size(107, 20);
            lblAntropometria.TabIndex = 10;
            lblAntropometria.Text = "Antropometría";
            // 
            // txtSignosVitales
            // 
            txtSignosVitales.Location = new Point(164, 56);
            txtSignosVitales.Multiline = true;
            txtSignosVitales.Name = "txtSignosVitales";
            txtSignosVitales.Size = new Size(247, 27);
            txtSignosVitales.TabIndex = 9;
            // 
            // lblSignosVitales
            // 
            lblSignosVitales.AutoSize = true;
            lblSignosVitales.Location = new Point(15, 63);
            lblSignosVitales.Name = "lblSignosVitales";
            lblSignosVitales.Size = new Size(97, 20);
            lblSignosVitales.TabIndex = 8;
            lblSignosVitales.Text = "SignosVitales";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(164, 22);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(271, 27);
            dtpFecha.TabIndex = 7;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(15, 29);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(143, 20);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha de evaluación";
            // 
            // grpAcciones
            // 
            grpAcciones.Controls.Add(Cancelar);
            grpAcciones.Controls.Add(btnGuardar);
            grpAcciones.Location = new Point(902, 72);
            grpAcciones.Name = "grpAcciones";
            grpAcciones.Size = new Size(257, 212);
            grpAcciones.TabIndex = 3;
            grpAcciones.TabStop = false;
            grpAcciones.Text = "Acciones";
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(59, 124);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(117, 43);
            Cancelar.TabIndex = 7;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(59, 40);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 43);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvEvaluaciones
            // 
            dgvEvaluaciones.AccessibleName = "";
            dgvEvaluaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvaluaciones.Location = new Point(32, 315);
            dgvEvaluaciones.Name = "dgvEvaluaciones";
            dgvEvaluaciones.RowHeadersWidth = 51;
            dgvEvaluaciones.Size = new Size(1046, 252);
            dgvEvaluaciones.TabIndex = 4;
            // 
            // EvaluacionFisica_2
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 649);
            Controls.Add(dgvEvaluaciones);
            Controls.Add(grpAcciones);
            Controls.Add(grpEvaluacionFisica);
            Controls.Add(grpDatMiembro);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EvaluacionFisica_2";
            Text = "EvaluacionFisica";
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