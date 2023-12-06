namespace WINFORM
{
    partial class Moto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvProductos = new DataGridView();
            txtDescription = new TextBox();
            txtQuantityInStock = new TextBox();
            txtPrice = new TextBox();
            txtProductID = new TextBox();
            txtName = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            label9 = new Label();
            txtBusqueda = new TextBox();
            pictureBox1 = new PictureBox();
            PRODUCTID = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            DESCRIPTION = new DataGridViewTextBoxColumn();
            PRICE = new DataGridViewTextBoxColumn();
            STOCK = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 83);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "DESCRIPTION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 152);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "PRICE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 184);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "STOCK";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { PRODUCTID, NAME, DESCRIPTION, PRICE, STOCK });
            dgvProductos.Location = new Point(184, 248);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(543, 150);
            dgvProductos.TabIndex = 8;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(105, 113);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 9;
            // 
            // txtQuantityInStock
            // 
            txtQuantityInStock.Location = new Point(105, 176);
            txtQuantityInStock.Name = "txtQuantityInStock";
            txtQuantityInStock.Size = new Size(100, 23);
            txtQuantityInStock.TabIndex = 13;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(105, 144);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 14;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(105, 57);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(49, 23);
            txtProductID.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(105, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 16;
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImage = Properties.Resources.qqqqq;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.ForeColor = SystemColors.ControlText;
            btnAgregar.Location = new Point(301, 20);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(84, 41);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "ADD";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackgroundImage = Properties.Resources.qqqqq;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Location = new Point(301, 70);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(84, 46);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "MODIFY";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackgroundImage = Properties.Resources.qqqqq;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Location = new Point(301, 128);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(84, 42);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "CLEAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.qqqqq;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Location = new Point(301, 177);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(84, 40);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "DELETE";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImage = Properties.Resources.qqqqq;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Location = new Point(761, 414);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(78, 30);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "EXIT";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(568, 206);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 22;
            label9.Text = "SEARCH";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(627, 203);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(100, 23);
            txtBusqueda.TabIndex = 23;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.qqqqq;
            pictureBox1.Location = new Point(598, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 138);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // PRODUCTID
            // 
            PRODUCTID.HeaderText = "PRODUCTID";
            PRODUCTID.Name = "PRODUCTID";
            // 
            // NAME
            // 
            NAME.HeaderText = "NAME";
            NAME.Name = "NAME";
            // 
            // DESCRIPTION
            // 
            DESCRIPTION.HeaderText = "DESCRIPTION";
            DESCRIPTION.Name = "DESCRIPTION";
            // 
            // PRICE
            // 
            PRICE.HeaderText = "PRICE";
            PRICE.Name = "PRICE";
            // 
            // STOCK
            // 
            STOCK.HeaderText = "STOCK";
            STOCK.Name = "STOCK";
            // 
            // Moto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(851, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtBusqueda);
            Controls.Add(label9);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtName);
            Controls.Add(txtProductID);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantityInStock);
            Controls.Add(txtDescription);
            Controls.Add(dgvProductos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Moto";
            Text = "Moto";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvProductos;
        private TextBox txtDescription;
        private TextBox txtQuantityInStock;
        private TextBox txtPrice;
        private TextBox txtProductID;
        private TextBox txtName;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnSalir;
        private Label label9;
        private TextBox txtBusqueda;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn PRODUCTID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn DESCRIPTION;
        private DataGridViewTextBoxColumn PRICE;
        private DataGridViewTextBoxColumn STOCK;
    }
}