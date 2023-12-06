namespace WINFORM
{
    partial class Usuario2
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
            dgvUsuarios = new DataGridView();
            CUSTOMERID = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            EMAIL = new DataGridViewTextBoxColumn();
            PHONE = new DataGridViewTextBoxColumn();
            ADDRESS = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            textBox1 = new TextBox();
            btnSalir = new Button();
            txtCustomerID = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "CUSTOMERID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 134);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "PHONE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 60);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 97);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "EMAIL";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { CUSTOMERID, NAME, EMAIL, PHONE, ADDRESS });
            dgvUsuarios.Location = new Point(113, 216);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(549, 150);
            dgvUsuarios.TabIndex = 4;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // CUSTOMERID
            // 
            CUSTOMERID.HeaderText = "CUSTOMERID";
            CUSTOMERID.Name = "CUSTOMERID";
            // 
            // NAME
            // 
            NAME.HeaderText = "NAME";
            NAME.Name = "NAME";
            // 
            // EMAIL
            // 
            EMAIL.HeaderText = "EMAIL";
            EMAIL.Name = "EMAIL";
            // 
            // PHONE
            // 
            PHONE.HeaderText = "PHONE";
            PHONE.Name = "PHONE";
            // 
            // ADDRESS
            // 
            ADDRESS.HeaderText = "ADDRESS";
            ADDRESS.Name = "ADDRESS";
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.qqqqq;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Location = new Point(281, 152);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 44);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "DELETE";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackgroundImage = Properties.Resources.qqqqq;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Location = new Point(281, 57);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(88, 40);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "MODIFY";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackgroundImage = Properties.Resources.qqqqq;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Location = new Point(281, 103);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 43);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "CLEAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImage = Properties.Resources.qqqqq;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Location = new Point(281, 9);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(88, 42);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "ADD";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.qqqqq;
            pictureBox1.Location = new Point(528, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 147);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(467, 181);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "SEARCH";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(549, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImage = Properties.Resources.qqqqq;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Location = new Point(616, 378);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(73, 40);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Enabled = false;
            txtCustomerID.Location = new Point(113, 19);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(40, 23);
            txtCustomerID.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(115, 23);
            txtName.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(113, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(115, 23);
            txtEmail.TabIndex = 15;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(113, 126);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(115, 23);
            txtPhone.TabIndex = 16;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(113, 164);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(115, 23);
            txtAddress.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 172);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 17;
            label6.Text = "ADDRESS";
            // 
            // Usuario2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(708, 430);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtCustomerID);
            Controls.Add(btnSalir);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(btnAgregar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvUsuarios);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Usuario2";
            Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvUsuarios;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnAgregar;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox textBox1;
        private Button btnSalir;
        private TextBox txtCustomerID;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Label label6;
        private DataGridViewTextBoxColumn CUSTOMERID;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn PHONE;
        private DataGridViewTextBoxColumn ADDRESS;
    }
}