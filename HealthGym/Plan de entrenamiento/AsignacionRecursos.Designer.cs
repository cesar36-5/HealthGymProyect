namespace HealthGym.Plan_de_entrenamiento
{
    partial class AsignacionRecursos
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            Tbox_plan = new TextBox();
            Dgv_Disponibilidad = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Dgv_Disponibilidad).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 41);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(225, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(12, 70);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(225, 23);
            dateTimePicker2.TabIndex = 1;
            dateTimePicker2.Value = new DateTime(2025, 10, 28, 18, 0, 0, 0);
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 147);
            button1.Name = "button1";
            button1.Size = new Size(223, 23);
            button1.TabIndex = 6;
            button1.Text = "Separar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 176);
            button2.Name = "button2";
            button2.Size = new Size(223, 23);
            button2.TabIndex = 7;
            button2.Text = "Borrar separacion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Tbox_plan
            // 
            Tbox_plan.Location = new Point(14, 118);
            Tbox_plan.Name = "Tbox_plan";
            Tbox_plan.Size = new Size(223, 23);
            Tbox_plan.TabIndex = 8;
            Tbox_plan.Text = "1111111";
            // 
            // Dgv_Disponibilidad
            // 
            Dgv_Disponibilidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Disponibilidad.Location = new Point(243, 12);
            Dgv_Disponibilidad.Name = "Dgv_Disponibilidad";
            Dgv_Disponibilidad.Size = new Size(595, 268);
            Dgv_Disponibilidad.TabIndex = 9;
            Dgv_Disponibilidad.CellDoubleClick += Dgv_Disponibilidad_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 99);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 10;
            label1.Text = "Id del Plan de Entrenamiento";
            // 
            // AsignacionRecursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 403);
            Controls.Add(label1);
            Controls.Add(Dgv_Disponibilidad);
            Controls.Add(Tbox_plan);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "AsignacionRecursos";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv_Disponibilidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private TextBox Tbox_plan;
        private DataGridView Dgv_Disponibilidad;
        private Label label1;
    }
}