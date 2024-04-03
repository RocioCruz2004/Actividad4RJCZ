namespace GestionPedidos.VISTA.PedidosVista
{
    partial class PedidosEliminarVista
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
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(179, 12);
            button2.Name = "button2";
            button2.Size = new Size(42, 23);
            button2.TabIndex = 23;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(222, 88);
            button1.Name = "button1";
            button1.Size = new Size(50, 145);
            button1.TabIndex = 22;
            button1.Text = "E\r\nL\r\nI\r\nM\r\nI\r\nN\r\nA\r\nR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pendiente", "En Proceso", "Completado", "Cancelado" });
            comboBox1.Location = new Point(86, 236);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 178);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(88, 23);
            textBox3.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 235);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 19;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 178);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 18;
            label4.Text = "Total:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(85, 115);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(115, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 121);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 16;
            label3.Text = "Fecha:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 66);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(88, 23);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 69);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 14;
            label2.Text = "ID Cliente:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(88, 23);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 12;
            label1.Text = "ID Pedido:";
            // 
            // PedidosEliminarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 284);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "PedidosEliminarVista";
            Text = "PedidosEliminarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}