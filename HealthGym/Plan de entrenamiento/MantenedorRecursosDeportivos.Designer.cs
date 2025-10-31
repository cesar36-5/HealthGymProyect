namespace HealthGym.Plan_de_entrenamiento
{
    partial class MantenedorRecursosDeportivos
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
            Dgv_Recursos = new DataGridView();
            label1 = new Label();
            Tbox_Nombre = new TextBox();
            Btn_Agregar = new Button();
            Btn_Editar = new Button();
            Btn_Cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)Dgv_Recursos).BeginInit();
            SuspendLayout();
            // 
            // Dgv_Recursos
            // 
            Dgv_Recursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Recursos.Location = new Point(14, 16);
            Dgv_Recursos.Margin = new Padding(3, 4, 3, 4);
            Dgv_Recursos.Name = "Dgv_Recursos";
            Dgv_Recursos.RowHeadersWidth = 51;
            Dgv_Recursos.Size = new Size(488, 395);
            Dgv_Recursos.TabIndex = 0;
            Dgv_Recursos.CellDoubleClick += Dgv_Recursos_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(639, 43);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // Tbox_Nombre
            // 
            Tbox_Nombre.Location = new Point(594, 76);
            Tbox_Nombre.Margin = new Padding(3, 4, 3, 4);
            Tbox_Nombre.Name = "Tbox_Nombre";
            Tbox_Nombre.Size = new Size(158, 27);
            Tbox_Nombre.TabIndex = 2;
            // 
            // Btn_Agregar
            // 
            Btn_Agregar.Location = new Point(528, 132);
            Btn_Agregar.Margin = new Padding(3, 4, 3, 4);
            Btn_Agregar.Name = "Btn_Agregar";
            Btn_Agregar.Size = new Size(159, 31);
            Btn_Agregar.TabIndex = 3;
            Btn_Agregar.Text = "Agregar";
            Btn_Agregar.UseVisualStyleBackColor = true;
            Btn_Agregar.Click += Btn_Agregar_Click;
            // 
            // Btn_Editar
            // 
            Btn_Editar.Location = new Point(528, 186);
            Btn_Editar.Margin = new Padding(3, 4, 3, 4);
            Btn_Editar.Name = "Btn_Editar";
            Btn_Editar.Size = new Size(159, 31);
            Btn_Editar.TabIndex = 4;
            Btn_Editar.Text = "Editar";
            Btn_Editar.UseVisualStyleBackColor = true;
            Btn_Editar.Click += Btn_Editar_Click;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.Location = new Point(528, 244);
            Btn_Cancelar.Margin = new Padding(3, 4, 3, 4);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(159, 31);
            Btn_Cancelar.TabIndex = 5;
            Btn_Cancelar.Text = "Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = true;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // MantenedorRecursosDeportivos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 424);
            Controls.Add(Btn_Cancelar);
            Controls.Add(Btn_Editar);
            Controls.Add(Btn_Agregar);
            Controls.Add(Tbox_Nombre);
            Controls.Add(label1);
            Controls.Add(Dgv_Recursos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MantenedorRecursosDeportivos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MantenedorRecursosDeportivos";
            ((System.ComponentModel.ISupportInitialize)Dgv_Recursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Dgv_Recursos;
        private Label label1;
        private TextBox Tbox_Nombre;
        private Button Btn_Agregar;
        private Button Btn_Editar;
        private Button Btn_Cancelar;
    }
}