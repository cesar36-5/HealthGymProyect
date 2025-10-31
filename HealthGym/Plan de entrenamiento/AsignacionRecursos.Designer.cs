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
            dateTimePicker1.Location = new Point(14, 55);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(257, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(14, 93);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(257, 27);
            dateTimePicker2.TabIndex = 1;
            dateTimePicker2.Value = new DateTime(2025, 10, 28, 18, 0, 0, 0);
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 16);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(14, 196);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(255, 31);
            button1.TabIndex = 6;
            button1.Text = "Separar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(14, 235);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(255, 31);
            button2.TabIndex = 7;
            button2.Text = "Borrar separacion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Tbox_plan
            // 
            Tbox_plan.Location = new Point(16, 157);
            Tbox_plan.Margin = new Padding(3, 4, 3, 4);
            Tbox_plan.Name = "Tbox_plan";
            Tbox_plan.Size = new Size(254, 27);
            Tbox_plan.TabIndex = 8;
            Tbox_plan.Text = "1111111";
            // 
            // Dgv_Disponibilidad
            // 
            Dgv_Disponibilidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Disponibilidad.Location = new Point(278, 16);
            Dgv_Disponibilidad.Margin = new Padding(3, 4, 3, 4);
            Dgv_Disponibilidad.Name = "Dgv_Disponibilidad";
            Dgv_Disponibilidad.RowHeadersWidth = 51;
            Dgv_Disponibilidad.Size = new Size(802, 486);
            Dgv_Disponibilidad.TabIndex = 9;
            Dgv_Disponibilidad.CellDoubleClick += Dgv_Disponibilidad_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 132);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
            label1.TabIndex = 10;
            label1.Text = "Id del Plan de Entrenamiento";
            // 
            // AsignacionRecursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 622);
            Controls.Add(label1);
            Controls.Add(Dgv_Disponibilidad);
            Controls.Add(Tbox_plan);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AsignacionRecursos";
            StartPosition = FormStartPosition.CenterScreen;
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