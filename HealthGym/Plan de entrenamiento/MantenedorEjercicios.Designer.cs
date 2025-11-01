namespace HealthGym.Plan_de_entrenamiento
{
    partial class MantenedorEjercicios
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
            Dgv_Ejercicios = new DataGridView();
            Gbox_Ejercicio = new GroupBox();
            label5 = new Label();
            Cbox_Enfoque = new ComboBox();
            label4 = new Label();
            Tbox_Desc = new TextBox();
            label3 = new Label();
            Cbox_Dificultad = new ComboBox();
            label2 = new Label();
            Tbox_Nombre = new TextBox();
            label1 = new Label();
            Tbox_Id = new TextBox();
            Btn_Agregar = new Button();
            Btn_Editar = new Button();
            Btn_Cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)Dgv_Ejercicios).BeginInit();
            Gbox_Ejercicio.SuspendLayout();
            SuspendLayout();
            // 
            // Dgv_Ejercicios
            // 
            Dgv_Ejercicios.AllowUserToAddRows = false;
            Dgv_Ejercicios.AllowUserToDeleteRows = false;
            Dgv_Ejercicios.AllowUserToResizeColumns = false;
            Dgv_Ejercicios.AllowUserToResizeRows = false;
            Dgv_Ejercicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Ejercicios.Location = new Point(12, 12);
            Dgv_Ejercicios.Name = "Dgv_Ejercicios";
            Dgv_Ejercicios.ReadOnly = true;
            Dgv_Ejercicios.RowHeadersWidth = 51;
            Dgv_Ejercicios.Size = new Size(872, 282);
            Dgv_Ejercicios.TabIndex = 0;
            Dgv_Ejercicios.CellDoubleClick += Dgv_Ejercicios_CellDoubleClick;
            // 
            // Gbox_Ejercicio
            // 
            Gbox_Ejercicio.Controls.Add(label5);
            Gbox_Ejercicio.Controls.Add(Cbox_Enfoque);
            Gbox_Ejercicio.Controls.Add(label4);
            Gbox_Ejercicio.Controls.Add(Tbox_Desc);
            Gbox_Ejercicio.Controls.Add(label3);
            Gbox_Ejercicio.Controls.Add(Cbox_Dificultad);
            Gbox_Ejercicio.Controls.Add(label2);
            Gbox_Ejercicio.Controls.Add(Tbox_Nombre);
            Gbox_Ejercicio.Controls.Add(label1);
            Gbox_Ejercicio.Controls.Add(Tbox_Id);
            Gbox_Ejercicio.Location = new Point(12, 300);
            Gbox_Ejercicio.Name = "Gbox_Ejercicio";
            Gbox_Ejercicio.Size = new Size(649, 138);
            Gbox_Ejercicio.TabIndex = 1;
            Gbox_Ejercicio.TabStop = false;
            Gbox_Ejercicio.Text = "Datos Ejercicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(352, 19);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Enfoque";
            // 
            // Cbox_Enfoque
            // 
            Cbox_Enfoque.FormattingEnabled = true;
            Cbox_Enfoque.Items.AddRange(new object[] { "Tren inferior", "Tren superior" });
            Cbox_Enfoque.Location = new Point(352, 37);
            Cbox_Enfoque.Name = "Cbox_Enfoque";
            Cbox_Enfoque.Size = new Size(121, 23);
            Cbox_Enfoque.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 68);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 7;
            label4.Text = "Descripcion tecnica";
            // 
            // Tbox_Desc
            // 
            Tbox_Desc.Location = new Point(19, 86);
            Tbox_Desc.Name = "Tbox_Desc";
            Tbox_Desc.Size = new Size(611, 23);
            Tbox_Desc.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 19);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Dificultad";
            // 
            // Cbox_Dificultad
            // 
            Cbox_Dificultad.FormattingEnabled = true;
            Cbox_Dificultad.Items.AddRange(new object[] { "Facil", "Medio", "Dificil" });
            Cbox_Dificultad.Location = new Point(225, 37);
            Cbox_Dificultad.Name = "Cbox_Dificultad";
            Cbox_Dificultad.Size = new Size(121, 23);
            Cbox_Dificultad.TabIndex = 4;
            Cbox_Dificultad.SelectedIndexChanged += Cbox_Dificultad_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 19);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // Tbox_Nombre
            // 
            Tbox_Nombre.Location = new Point(86, 37);
            Tbox_Nombre.Name = "Tbox_Nombre";
            Tbox_Nombre.Size = new Size(133, 23);
            Tbox_Nombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // Tbox_Id
            // 
            Tbox_Id.Location = new Point(19, 37);
            Tbox_Id.Name = "Tbox_Id";
            Tbox_Id.Size = new Size(61, 23);
            Tbox_Id.TabIndex = 0;
            Tbox_Id.KeyDown += Tbox_Id_KeyDown;
            // 
            // Btn_Agregar
            // 
            Btn_Agregar.Location = new Point(730, 309);
            Btn_Agregar.Name = "Btn_Agregar";
            Btn_Agregar.Size = new Size(141, 23);
            Btn_Agregar.TabIndex = 2;
            Btn_Agregar.Text = "Agregar";
            Btn_Agregar.UseVisualStyleBackColor = true;
            Btn_Agregar.Click += Btn_Agregar_Click;
            // 
            // Btn_Editar
            // 
            Btn_Editar.Location = new Point(730, 338);
            Btn_Editar.Name = "Btn_Editar";
            Btn_Editar.Size = new Size(141, 23);
            Btn_Editar.TabIndex = 3;
            Btn_Editar.Text = "Editar";
            Btn_Editar.UseVisualStyleBackColor = true;
            Btn_Editar.Click += Btn_Editar_Click;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.Location = new Point(730, 368);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(141, 23);
            Btn_Cancelar.TabIndex = 5;
            Btn_Cancelar.Text = "Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = true;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // MantenedorEjercicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 466);
            Controls.Add(Btn_Cancelar);
            Controls.Add(Btn_Editar);
            Controls.Add(Btn_Agregar);
            Controls.Add(Gbox_Ejercicio);
            Controls.Add(Dgv_Ejercicios);
            Name = "MantenedorEjercicios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantenedorEjercicios";
            Load += MantenedorEjercicios_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv_Ejercicios).EndInit();
            Gbox_Ejercicio.ResumeLayout(false);
            Gbox_Ejercicio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Dgv_Ejercicios;
        private GroupBox Gbox_Ejercicio;
        private Button Btn_Agregar;
        private Button Btn_Editar;
        private TextBox Tbox_Id;
        private Label label1;
        private Label label2;
        private TextBox Tbox_Nombre;
        private ComboBox Cbox_Dificultad;
        private Label label4;
        private TextBox Tbox_Desc;
        private Label label3;
        private Label label5;
        private ComboBox Cbox_Enfoque;
        private Button Btn_Cancelar;
    }
}