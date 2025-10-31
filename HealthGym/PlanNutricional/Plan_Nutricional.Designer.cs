namespace HealthGym.PlanNutricional
{
    partial class Plan_Nutricional
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
            gbPlanNutri = new GroupBox();
            label5 = new Label();
            txtEvaluacionNutricional = new TextBox();
            btnModificar = new Button();
            btnAgregar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblDia = new Label();
            txtValorNutricional = new TextBox();
            txtAlimento = new TextBox();
            txtTipo = new TextBox();
            cboComida = new ComboBox();
            cboDia = new ComboBox();
            rtbDatosEva = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            dgvPlanNutri = new DataGridView();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnDeshabilitarAlim = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            gbPlanNutri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlanNutri).BeginInit();
            SuspendLayout();
            // 
            // gbPlanNutri
            // 
            gbPlanNutri.Controls.Add(label5);
            gbPlanNutri.Controls.Add(txtEvaluacionNutricional);
            gbPlanNutri.Controls.Add(btnModificar);
            gbPlanNutri.Controls.Add(btnAgregar);
            gbPlanNutri.Controls.Add(label4);
            gbPlanNutri.Controls.Add(label3);
            gbPlanNutri.Controls.Add(label2);
            gbPlanNutri.Controls.Add(label1);
            gbPlanNutri.Controls.Add(lblDia);
            gbPlanNutri.Controls.Add(txtValorNutricional);
            gbPlanNutri.Controls.Add(txtAlimento);
            gbPlanNutri.Controls.Add(txtTipo);
            gbPlanNutri.Controls.Add(cboComida);
            gbPlanNutri.Controls.Add(cboDia);
            gbPlanNutri.Controls.Add(rtbDatosEva);
            gbPlanNutri.Controls.Add(dateTimePicker1);
            gbPlanNutri.Location = new Point(14, 9);
            gbPlanNutri.Margin = new Padding(3, 4, 3, 4);
            gbPlanNutri.Name = "gbPlanNutri";
            gbPlanNutri.Padding = new Padding(3, 4, 3, 4);
            gbPlanNutri.Size = new Size(351, 575);
            gbPlanNutri.TabIndex = 0;
            gbPlanNutri.TabStop = false;
            gbPlanNutri.Text = "Plan Nutricional";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 239);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 15;
            label5.Text = "Evaluacion N°";
            // 
            // txtEvaluacionNutricional
            // 
            txtEvaluacionNutricional.Location = new Point(128, 235);
            txtEvaluacionNutricional.Margin = new Padding(3, 4, 3, 4);
            txtEvaluacionNutricional.Name = "txtEvaluacionNutricional";
            txtEvaluacionNutricional.Size = new Size(211, 27);
            txtEvaluacionNutricional.TabIndex = 14;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(184, 536);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(155, 31);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(11, 536);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(166, 31);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 473);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 11;
            label4.Text = "Valor Nutricional:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 415);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 10;
            label3.Text = "Nombre del Alimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 356);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 9;
            label2.Text = "Tipo de Plan Nutricional:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 319);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 8;
            label1.Text = "Comida del día:";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(11, 280);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(126, 20);
            lblDia.TabIndex = 7;
            lblDia.Text = "Día de la Semana";
            // 
            // txtValorNutricional
            // 
            txtValorNutricional.Location = new Point(10, 497);
            txtValorNutricional.Margin = new Padding(3, 4, 3, 4);
            txtValorNutricional.Name = "txtValorNutricional";
            txtValorNutricional.Size = new Size(329, 27);
            txtValorNutricional.TabIndex = 6;
            // 
            // txtAlimento
            // 
            txtAlimento.Location = new Point(10, 439);
            txtAlimento.Margin = new Padding(3, 4, 3, 4);
            txtAlimento.Name = "txtAlimento";
            txtAlimento.Size = new Size(329, 27);
            txtAlimento.TabIndex = 5;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(10, 380);
            txtTipo.Margin = new Padding(3, 4, 3, 4);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(329, 27);
            txtTipo.TabIndex = 4;
            // 
            // cboComida
            // 
            cboComida.FormattingEnabled = true;
            cboComida.Items.AddRange(new object[] { "Desayuno", "Almuerzo", "Cena" });
            cboComida.Location = new Point(128, 312);
            cboComida.Margin = new Padding(3, 4, 3, 4);
            cboComida.Name = "cboComida";
            cboComida.Size = new Size(211, 28);
            cboComida.TabIndex = 3;
            // 
            // cboDia
            // 
            cboDia.FormattingEnabled = true;
            cboDia.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" });
            cboDia.Location = new Point(128, 273);
            cboDia.Margin = new Padding(3, 4, 3, 4);
            cboDia.Name = "cboDia";
            cboDia.Size = new Size(211, 28);
            cboDia.TabIndex = 2;
            // 
            // rtbDatosEva
            // 
            rtbDatosEva.Location = new Point(10, 69);
            rtbDatosEva.Margin = new Padding(3, 4, 3, 4);
            rtbDatosEva.Name = "rtbDatosEva";
            rtbDatosEva.ReadOnly = true;
            rtbDatosEva.Size = new Size(329, 153);
            rtbDatosEva.TabIndex = 1;
            rtbDatosEva.Text = "";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(111, 29);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // dgvPlanNutri
            // 
            dgvPlanNutri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanNutri.Location = new Point(371, 20);
            dgvPlanNutri.Margin = new Padding(3, 4, 3, 4);
            dgvPlanNutri.Name = "dgvPlanNutri";
            dgvPlanNutri.RowHeadersWidth = 51;
            dgvPlanNutri.Size = new Size(726, 525);
            dgvPlanNutri.TabIndex = 1;
            dgvPlanNutri.CellDoubleClick += dgvPlanNutri_CellDoubleClick;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(459, 553);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(160, 31);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(642, 553);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(160, 31);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeshabilitarAlim
            // 
            btnDeshabilitarAlim.Location = new Point(832, 553);
            btnDeshabilitarAlim.Margin = new Padding(3, 4, 3, 4);
            btnDeshabilitarAlim.Name = "btnDeshabilitarAlim";
            btnDeshabilitarAlim.Size = new Size(194, 31);
            btnDeshabilitarAlim.TabIndex = 4;
            btnDeshabilitarAlim.Text = "Deshabilitar Alimentos";
            btnDeshabilitarAlim.UseVisualStyleBackColor = true;
            btnDeshabilitarAlim.Click += btnDeshabilitarAlim_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Plan_Nutricional
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 622);
            Controls.Add(btnDeshabilitarAlim);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvPlanNutri);
            Controls.Add(gbPlanNutri);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Plan_Nutricional";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlanNutricional";
            gbPlanNutri.ResumeLayout(false);
            gbPlanNutri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlanNutri).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbPlanNutri;
        private DataGridView dgvPlanNutri;
        private DateTimePicker dateTimePicker1;
        private RichTextBox rtbDatosEva;
        private TextBox txtAlimento;
        private TextBox txtTipo;
        private ComboBox cboComida;
        private ComboBox cboDia;
        private TextBox txtValorNutricional;
        private Label lblDia;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnDeshabilitarAlim;
        private Label label5;
        private TextBox txtEvaluacionNutricional;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}