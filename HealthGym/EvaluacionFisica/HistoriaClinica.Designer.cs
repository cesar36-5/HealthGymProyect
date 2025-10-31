namespace HealthGym.EvaluacionFisica
{
    partial class HistoriaClinica
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
            gbxBuscar = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtIndicaciones = new TextBox();
            label7 = new Label();
            txtDiagnostico = new TextBox();
            label6 = new Label();
            txtAntecedentes = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtObservaciones = new TextBox();
            cbxResponsable = new ComboBox();
            dtpFecha = new DateTimePicker();
            btnBuscarM = new Button();
            txtDni = new TextBox();
            label2 = new Label();
            txtIdHistoria = new TextBox();
            gbxBuscar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F);
            label1.Location = new Point(6, 164);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Historia Clínica";
            // 
            // gbxBuscar
            // 
            gbxBuscar.Controls.Add(button5);
            gbxBuscar.Controls.Add(button4);
            gbxBuscar.Controls.Add(button3);
            gbxBuscar.Controls.Add(button2);
            gbxBuscar.Controls.Add(button1);
            gbxBuscar.Controls.Add(txtIndicaciones);
            gbxBuscar.Controls.Add(label7);
            gbxBuscar.Controls.Add(txtDiagnostico);
            gbxBuscar.Controls.Add(label6);
            gbxBuscar.Controls.Add(txtAntecedentes);
            gbxBuscar.Controls.Add(label5);
            gbxBuscar.Controls.Add(label4);
            gbxBuscar.Controls.Add(label3);
            gbxBuscar.Controls.Add(txtObservaciones);
            gbxBuscar.Controls.Add(cbxResponsable);
            gbxBuscar.Controls.Add(dtpFecha);
            gbxBuscar.Controls.Add(btnBuscarM);
            gbxBuscar.Controls.Add(txtDni);
            gbxBuscar.Controls.Add(label2);
            gbxBuscar.Controls.Add(txtIdHistoria);
            gbxBuscar.Controls.Add(label1);
            gbxBuscar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxBuscar.Location = new Point(24, 16);
            gbxBuscar.Name = "gbxBuscar";
            gbxBuscar.Size = new Size(1094, 607);
            gbxBuscar.TabIndex = 1;
            gbxBuscar.TabStop = false;
            gbxBuscar.Text = "Buscar Mienbro";
            // 
            // button5
            // 
            button5.Location = new Point(701, 45);
            button5.Name = "button5";
            button5.Size = new Size(132, 42);
            button5.TabIndex = 20;
            button5.Text = "Limpiar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(543, 103);
            button4.Name = "button4";
            button4.Size = new Size(132, 42);
            button4.TabIndex = 19;
            button4.Text = "Consultar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(387, 103);
            button3.Name = "button3";
            button3.Size = new Size(132, 42);
            button3.TabIndex = 18;
            button3.Text = "Anular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(542, 45);
            button2.Name = "button2";
            button2.Size = new Size(132, 42);
            button2.TabIndex = 17;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(387, 45);
            button1.Name = "button1";
            button1.Size = new Size(132, 42);
            button1.TabIndex = 16;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.Location = new Point(543, 471);
            txtIndicaciones.Multiline = true;
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.Size = new Size(272, 91);
            txtIndicaciones.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(542, 434);
            label7.Name = "label7";
            label7.Size = new Size(273, 23);
            label7.TabIndex = 14;
            label7.Text = "Indicaciones / recomendaciones";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(675, 310);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(272, 91);
            txtDiagnostico.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(543, 332);
            label6.Name = "label6";
            label6.Size = new Size(108, 23);
            label6.TabIndex = 12;
            label6.Text = "Diagnóstico";
            // 
            // txtAntecedentes
            // 
            txtAntecedentes.Location = new Point(217, 421);
            txtAntecedentes.Multiline = true;
            txtAntecedentes.Name = "txtAntecedentes";
            txtAntecedentes.Size = new Size(272, 94);
            txtAntecedentes.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 454);
            label5.Name = "label5";
            label5.Size = new Size(196, 23);
            label5.TabIndex = 10;
            label5.Text = "Antecedentes médicos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 332);
            label4.Name = "label4";
            label4.Size = new Size(205, 23);
            label4.TabIndex = 9;
            label4.Text = "Observaciones médicas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 270);
            label3.Name = "label3";
            label3.Size = new Size(182, 23);
            label3.TabIndex = 8;
            label3.Text = "Medico Responsable";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(217, 310);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(272, 91);
            txtObservaciones.TabIndex = 7;
            // 
            // cbxResponsable
            // 
            cbxResponsable.FormattingEnabled = true;
            cbxResponsable.Location = new Point(217, 262);
            cbxResponsable.Name = "cbxResponsable";
            cbxResponsable.Size = new Size(235, 31);
            cbxResponsable.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(6, 216);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(372, 30);
            dtpFecha.TabIndex = 5;
            // 
            // btnBuscarM
            // 
            btnBuscarM.Location = new Point(6, 103);
            btnBuscarM.Name = "btnBuscarM";
            btnBuscarM.Size = new Size(113, 29);
            btnBuscarM.TabIndex = 4;
            btnBuscarM.Text = "BUSCAR";
            btnBuscarM.UseVisualStyleBackColor = true;
            btnBuscarM.Click += btnBuscarM_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(169, 57);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(147, 30);
            txtDni.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F);
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 2;
            label2.Text = "DNI del miembro";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtIdHistoria
            // 
            txtIdHistoria.Location = new Point(169, 164);
            txtIdHistoria.Name = "txtIdHistoria";
            txtIdHistoria.Size = new Size(180, 30);
            txtIdHistoria.TabIndex = 1;
            // 
            // HistoriaClinica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 635);
            Controls.Add(gbxBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HistoriaClinica";
            gbxBuscar.ResumeLayout(false);
            gbxBuscar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox gbxBuscar;
        private Button btnBuscarM;
        private TextBox txtDni;
        private Label label2;
        private TextBox txtIdHistoria;
        private TextBox txtAntecedentes;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtObservaciones;
        private ComboBox cbxResponsable;
        private DateTimePicker dtpFecha;
        private Label label7;
        private TextBox txtDiagnostico;
        private Label label6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtIndicaciones;
    }
}