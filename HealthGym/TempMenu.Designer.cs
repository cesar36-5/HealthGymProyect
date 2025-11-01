namespace HealthGym
{
    partial class TempMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempMenu));
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button6 = new Button();
            button3 = new Button();
            button5 = new Button();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(488, 248);
            button1.Name = "button1";
            button1.Size = new Size(114, 45);
            button1.TabIndex = 0;
            button1.Text = "Mantenedor Miembro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(631, 143);
            button2.Name = "button2";
            button2.Size = new Size(106, 46);
            button2.TabIndex = 1;
            button2.Text = "Mantenedor Trabajadores";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(631, 293);
            button4.Name = "button4";
            button4.Size = new Size(106, 54);
            button4.TabIndex = 2;
            button4.Text = "Asignacion Recursos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(631, 224);
            button6.Name = "button6";
            button6.Size = new Size(106, 50);
            button6.TabIndex = 4;
            button6.Text = "Mantenedor Ejercicios";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(631, 355);
            button3.Name = "button3";
            button3.Size = new Size(106, 50);
            button3.TabIndex = 7;
            button3.Text = "Evalución Nutricional";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(488, 313);
            button5.Name = "button5";
            button5.Size = new Size(115, 34);
            button5.TabIndex = 8;
            button5.Text = "Plan Nutricional ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button8
            // 
            button8.Location = new Point(488, 162);
            button8.Name = "button8";
            button8.Size = new Size(115, 61);
            button8.TabIndex = 9;
            button8.Text = "Mantenedor Recurso \r\nDeportivo\r\n";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-67, -1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(932, 532);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // TempMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 524);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Name = "TempMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TempMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Button button6;
        private Button button3;
        private Button button5;
        private Button button8;
        private PictureBox pictureBox1;
    }
}