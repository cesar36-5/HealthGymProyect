namespace HealthGym.PlanNutricional
{
    partial class FormGestionRecetas
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
            numRecetaID = new NumericUpDown();
            btnBuscarReceta = new Button();
            groupBox1 = new GroupBox();
            btnBajar = new Button();
            btnSubir = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnAgregar = new Button();
            txtInstruccion = new TextBox();
            label2 = new Label();
            lstPasos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numRecetaID).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 37);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "ID Receta (Prueba):";
            // 
            // numRecetaID
            // 
            numRecetaID.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numRecetaID.Location = new Point(240, 33);
            numRecetaID.Margin = new Padding(5, 6, 5, 6);
            numRecetaID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numRecetaID.Name = "numRecetaID";
            numRecetaID.Size = new Size(200, 30);
            numRecetaID.TabIndex = 1;
            // 
            // btnBuscarReceta
            // 
            btnBuscarReceta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarReceta.Location = new Point(465, 29);
            btnBuscarReceta.Margin = new Padding(5, 6, 5, 6);
            btnBuscarReceta.Name = "btnBuscarReceta";
            btnBuscarReceta.Size = new Size(157, 52);
            btnBuscarReceta.TabIndex = 2;
            btnBuscarReceta.Text = "Buscar";
            btnBuscarReceta.UseVisualStyleBackColor = true;
            btnBuscarReceta.Click += btnBuscarReceta_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnBajar);
            groupBox1.Controls.Add(btnSubir);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtInstruccion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lstPasos);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(25, 119);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(1095, 616);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pasos de la Receta";
            // 
            // btnBajar
            // 
            btnBajar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBajar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBajar.Location = new Point(1010, 169);
            btnBajar.Margin = new Padding(5, 6, 5, 6);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(58, 67);
            btnBajar.TabIndex = 7;
            btnBajar.Text = "↓";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // btnSubir
            // 
            btnSubir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSubir.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubir.Location = new Point(1010, 73);
            btnSubir.Margin = new Padding(5, 6, 5, 6);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(58, 67);
            btnSubir.TabIndex = 6;
            btnSubir.Text = "↑";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.FromArgb(255, 224, 224);
            btnEliminar.Location = new Point(35, 537);
            btnEliminar.Margin = new Padding(5, 6, 5, 6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(133, 56);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(224, 255, 224);
            btnGuardar.Location = new Point(753, 537);
            btnGuardar.Margin = new Padding(5, 6, 5, 6);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(213, 56);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(224, 224, 255);
            btnAgregar.Location = new Point(560, 537);
            btnAgregar.Margin = new Padding(5, 6, 5, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(183, 56);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar Nuevo";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtInstruccion
            // 
            txtInstruccion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtInstruccion.Location = new Point(35, 405);
            txtInstruccion.Margin = new Padding(5, 6, 5, 6);
            txtInstruccion.Multiline = true;
            txtInstruccion.Name = "txtInstruccion";
            txtInstruccion.Size = new Size(929, 106);
            txtInstruccion.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(30, 368);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 1;
            label2.Text = "Instrucción del Paso";
            // 
            // lstPasos
            // 
            lstPasos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstPasos.FormattingEnabled = true;
            lstPasos.ItemHeight = 25;
            lstPasos.Location = new Point(35, 73);
            lstPasos.Margin = new Padding(5, 6, 5, 6);
            lstPasos.Name = "lstPasos";
            lstPasos.Size = new Size(929, 229);
            lstPasos.TabIndex = 0;
            lstPasos.SelectedIndexChanged += lstPasos_SelectedIndexChanged;
            // 
            // FormGestionRecetas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 758);
            Controls.Add(groupBox1);
            Controls.Add(btnBuscarReceta);
            Controls.Add(numRecetaID);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(819, 814);
            Name = "FormGestionRecetas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Pasos de Receta";
            ((System.ComponentModel.ISupportInitialize)numRecetaID).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRecetaID;
        private System.Windows.Forms.Button btnBuscarReceta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtInstruccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPasos;
    }
}