namespace GestionPedidos.VISTA.PedidosVista
{
    partial class PedidosListarVista
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
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(522, 225);
            dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(651, 41);
            button3.Name = "button3";
            button3.Size = new Size(100, 48);
            button3.TabIndex = 7;
            button3.Text = "INSERTAR\r\nPEDIDO";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(651, 119);
            button4.Name = "button4";
            button4.Size = new Size(100, 48);
            button4.TabIndex = 8;
            button4.Text = "EDITAR\r\nPEDIDO";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(651, 191);
            button5.Name = "button5";
            button5.Size = new Size(100, 48);
            button5.TabIndex = 9;
            button5.Text = "ELIMINAR\r\nPEDIDO";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(633, 264);
            button6.Name = "button6";
            button6.Size = new Size(137, 48);
            button6.TabIndex = 10;
            button6.Text = "FILTRAR PEDIDO\r\nPOR CLIENTE";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(641, 345);
            button7.Name = "button7";
            button7.Size = new Size(127, 48);
            button7.TabIndex = 11;
            button7.Text = "CALCULAR PEDIDOS\r\nPOR CLIENTE";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // PedidosListarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Name = "PedidosListarVista";
            Text = "PedidosListarVista";
            Load += PedidosListarVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}