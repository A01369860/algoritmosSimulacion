namespace algoritmosSimulacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1042, 108);
            button1.Name = "button1";
            button1.Size = new Size(186, 63);
            button1.TabIndex = 0;
            button1.Text = "Ejecutar\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 66);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 1;
            label1.Text = "Puntos Totales\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(355, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 39);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(355, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 39);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 173);
            label2.Name = "label2";
            label2.Size = new Size(100, 32);
            label2.TabIndex = 4;
            label2.Text = "Máximo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(125, 393);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(898, 438);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(1042, 224);
            button2.Name = "button2";
            button2.Size = new Size(186, 61);
            button2.TabIndex = 6;
            button2.Text = "Descarga";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(689, 294);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(355, 280);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 39);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 280);
            label4.Name = "label4";
            label4.Size = new Size(97, 32);
            label4.TabIndex = 9;
            label4.Text = "Mínimo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 875);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
    }
}
