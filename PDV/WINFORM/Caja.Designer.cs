namespace WINFORM
{
    partial class Caja
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
            txtProductID = new TextBox();
            txtName = new TextBox();
            txtsubtotal = new TextBox();
            txtiva = new TextBox();
            txttotal = new TextBox();
            txtPrice = new TextBox();
            txtAmount = new TextBox();
            btnAgregar = new Button();
            btnVender = new Button();
            btnSalir = new Button();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            PRODUCTOID = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            PRICE = new DataGridViewTextBoxColumn();
            AMOUNT = new DataGridViewTextBoxColumn();
            SUBTOTAL = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(81, 104);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(100, 23);
            txtProductID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(214, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtsubtotal
            // 
            txtsubtotal.Location = new Point(688, 46);
            txtsubtotal.Name = "txtsubtotal";
            txtsubtotal.Size = new Size(100, 23);
            txtsubtotal.TabIndex = 2;
            // 
            // txtiva
            // 
            txtiva.Location = new Point(688, 75);
            txtiva.Name = "txtiva";
            txtiva.Size = new Size(100, 23);
            txtiva.TabIndex = 3;
            // 
            // txttotal
            // 
            txttotal.Location = new Point(688, 104);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(100, 23);
            txttotal.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(350, 104);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(486, 104);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 6;
            txtAmount.TextChanged += txtCantidad_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(502, 341);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(84, 34);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "ADD";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(592, 341);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(89, 34);
            btnVender.TabIndex = 8;
            btnVender.Text = "BUY";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(711, 395);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(77, 43);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "EXIT";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(90, 141);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "SEARCH";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PRODUCTOID, NAME, PRICE, AMOUNT, SUBTOTAL });
            dataGridView1.Location = new Point(144, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(538, 150);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PRODUCTOID
            // 
            PRODUCTOID.HeaderText = "PRODUCTOID";
            PRODUCTOID.Name = "PRODUCTOID";
            // 
            // NAME
            // 
            NAME.HeaderText = "NAME";
            NAME.Name = "NAME";
            // 
            // PRICE
            // 
            PRICE.HeaderText = "PRICE";
            PRICE.Name = "PRICE";
            // 
            // AMOUNT
            // 
            AMOUNT.HeaderText = "AMOUNT";
            AMOUNT.Name = "AMOUNT";
            // 
            // SUBTOTAL
            // 
            SUBTOTAL.HeaderText = "SUBTOTAL";
            SUBTOTAL.Name = "SUBTOTAL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 75);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 12;
            label1.Text = "PRODUCTOID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 75);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 13;
            label2.Text = "NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 75);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 14;
            label3.Text = "PRICE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(514, 75);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 15;
            label4.Text = "AMOUNT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(623, 54);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 16;
            label5.Text = "SUBTOTAL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(657, 83);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 17;
            label6.Text = "IVA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(642, 112);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 18;
            label7.Text = "TOTAL";
            // 
            // Caja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(btnSalir);
            Controls.Add(btnVender);
            Controls.Add(btnAgregar);
            Controls.Add(txtAmount);
            Controls.Add(txtPrice);
            Controls.Add(txttotal);
            Controls.Add(txtiva);
            Controls.Add(txtsubtotal);
            Controls.Add(txtName);
            Controls.Add(txtProductID);
            Name = "Caja";
            Text = "Caja";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductID;
        private TextBox txtName;
        private TextBox txtsubtotal;
        private TextBox txtiva;
        private TextBox txttotal;
        private TextBox txtPrice;
        private TextBox txtAmount;
        private Button btnAgregar;
        private Button btnVender;
        private Button btnSalir;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn PRODUCTOID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn PRICE;
        private DataGridViewTextBoxColumn AMOUNT;
        private DataGridViewTextBoxColumn SUBTOTAL;
    }
}