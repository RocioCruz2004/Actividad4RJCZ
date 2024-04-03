namespace GestionPedidos.VISTA.ClienteVista
{
    partial class ClienteEditarVista
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
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            btnID = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(109, 347);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(100, 283);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(199, 23);
            textBox5.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(96, 223);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(199, 23);
            textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(165, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 23);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 286);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 15;
            label5.Text = "DIRECCIÓN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 226);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 14;
            label4.Text = "TELÉFONO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 170);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 13;
            label3.Text = "CORREO ELECTRÓNICO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 121);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 12;
            label2.Text = "APELLIDO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 63);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 11;
            label1.Text = "NOMBRE:";
            // 
            // button2
            // 
            button2.Location = new Point(109, 26);
            button2.Name = "button2";
            button2.Size = new Size(46, 23);
            button2.TabIndex = 22;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnID
            // 
            btnID.Location = new Point(50, 26);
            btnID.Name = "btnID";
            btnID.Size = new Size(44, 23);
            btnID.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 29);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 23;
            label6.Text = "ID:";
            // 
            // ClienteEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 388);
            Controls.Add(btnID);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClienteEditarVista";
            Text = "ClienteEditarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private TextBox btnID;
        private Label label6;
    }
}