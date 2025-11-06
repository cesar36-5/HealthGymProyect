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
            gbPlanNutri.Location = new Point(18, 11);
            gbPlanNutri.Margin = new Padding(4, 5, 4, 5);
            gbPlanNutri.Name = "gbPlanNutri";
            gbPlanNutri.Padding = new Padding(4, 5, 4, 5);
            gbPlanNutri.Size = new Size(439, 719);
            gbPlanNutri.TabIndex = 0;
            gbPlanNutri.TabStop = false;
            gbPlanNutri.Text = "Plan Nutricional";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 299);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 15;
            label5.Text = "Evaluacion N°";
            // 
            // txtEvaluacionNutricional
            // 
            txtEvaluacionNutricional.Location = new Point(160, 294);
            txtEvaluacionNutricional.Margin = new Padding(4, 5, 4, 5);
            txtEvaluacionNutricional.Name = "txtEvaluacionNutricional";
            txtEvaluacionNutricional.Size = new Size(263, 31);
            txtEvaluacionNutricional.TabIndex = 14;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(230, 670);
            btnModificar.Margin = new Padding(4, 5, 4, 5);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(194, 39);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(14, 670);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(208, 39);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 591);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 11;
            label4.Text = "Valor Nutricional:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 519);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(188, 25);
            label3.TabIndex = 10;
            label3.Text = "Nombre del Alimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 445);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(204, 25);
            label2.TabIndex = 9;
            label2.Text = "Tipo de Plan Nutricional:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 399);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 8;
            label1.Text = "Comida del día:";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(14, 350);
            lblDia.Margin = new Padding(4, 0, 4, 0);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(149, 25);
            lblDia.TabIndex = 7;
            lblDia.Text = "Día de la Semana";
            // 
            // txtValorNutricional
            // 
            txtValorNutricional.Location = new Point(12, 621);
            txtValorNutricional.Margin = new Padding(4, 5, 4, 5);
            txtValorNutricional.Name = "txtValorNutricional";
            txtValorNutricional.Size = new Size(410, 31);
            txtValorNutricional.TabIndex = 6;
            // 
            // txtAlimento
            // 
            txtAlimento.Location = new Point(12, 549);
            txtAlimento.Margin = new Padding(4, 5, 4, 5);
            txtAlimento.Name = "txtAlimento";
            txtAlimento.Size = new Size(410, 31);
            txtAlimento.TabIndex = 5;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(12, 475);
            txtTipo.Margin = new Padding(4, 5, 4, 5);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(410, 31);
            txtTipo.TabIndex = 4;
            // 
            // cboComida
            // 
            cboComida.FormattingEnabled = true;
            cboComida.Items.AddRange(new object[] { "Desayuno", "Almuerzo", "Cena" });
            cboComida.Location = new Point(160, 390);
            cboComida.Margin = new Padding(4, 5, 4, 5);
            cboComida.Name = "cboComida";
            cboComida.Size = new Size(263, 33);
            cboComida.TabIndex = 3;
            // 
            // cboDia
            // 
            cboDia.FormattingEnabled = true;
            cboDia.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" });
            cboDia.Location = new Point(160, 341);
            cboDia.Margin = new Padding(4, 5, 4, 5);
            cboDia.Name = "cboDia";
            cboDia.Size = new Size(263, 33);
            cboDia.TabIndex = 2;
            // 
            // rtbDatosEva
            // 
            rtbDatosEva.Location = new Point(12, 86);
            rtbDatosEva.Margin = new Padding(4, 5, 4, 5);
            rtbDatosEva.Name = "rtbDatosEva";
            rtbDatosEva.ReadOnly = true;
            rtbDatosEva.Size = new Size(410, 190);
            rtbDatosEva.TabIndex = 1;
            rtbDatosEva.Text = "";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(139, 36);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // dgvPlanNutri
            // 
            dgvPlanNutri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanNutri.Location = new Point(464, 25);
            dgvPlanNutri.Margin = new Padding(4, 5, 4, 5);
            dgvPlanNutri.Name = "dgvPlanNutri";
            dgvPlanNutri.RowHeadersWidth = 51;
            dgvPlanNutri.Size = new Size(908, 656);
            dgvPlanNutri.TabIndex = 1;
            dgvPlanNutri.CellDoubleClick += dgvPlanNutri_CellDoubleClick;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(574, 691);
            btnNuevo.Margin = new Padding(4, 5, 4, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(200, 39);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(802, 691);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(200, 39);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeshabilitarAlim
            // 
            btnDeshabilitarAlim.Location = new Point(1040, 691);
            btnDeshabilitarAlim.Margin = new Padding(4, 5, 4, 5);
            btnDeshabilitarAlim.Name = "btnDeshabilitarAlim";
            btnDeshabilitarAlim.Size = new Size(242, 39);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 778);
            Controls.Add(btnDeshabilitarAlim);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvPlanNutri);
            Controls.Add(gbPlanNutri);
            Margin = new Padding(4, 5, 4, 5);
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