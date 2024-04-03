namespace GestionPedidos.VISTA.ClienteVista
{
    partial class ClienteEliminarVista
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
            btnID = new TextBox();
            label6 = new Label();
            button2 = new Button();
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
            SuspendLayout();
            // 
            // btnID
            // 
            btnID.Location = new Point(42, 20);
            btnID.Name = "btnID";
            btnID.Size = new Size(44, 23);
            btnID.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 23);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 37;
            label6.Text = "ID:";
            // 
            // button2
            // 
            button2.Location = new Point(101, 20);
            button2.Name = "button2";
            button2.Size = new Size(46, 23);
            button2.TabIndex = 36;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(101, 341);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 35;
            button1.Text = "ELIMINAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(92, 277);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(199, 23);
            textBox5.TabIndex = 34;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(88, 217);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(199, 23);
            textBox4.TabIndex = 33;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 161);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 23);
            textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 23);
            textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 280);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 29;
            label5.Text = "DIRECCIÓN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 220);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 28;
            label4.Text = "TELÉFONO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 164);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 27;
            label3.Text = "CORREO ELECTRÓNICO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 115);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 26;
            label2.Text = "APELLIDO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 57);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 25;
            label1.Text = "NOMBRE:";
            // 
            // ClienteEliminarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 380);
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
            Name = "ClienteEliminarVista";
            Text = "ClienteEliminarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox btnID;
        private Label label6;
        private Button button2;
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
    }
}