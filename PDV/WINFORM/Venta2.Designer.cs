namespace WINFORM
{
    partial class Venta2
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
            dGventadetalle = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            MONTO = new DataGridViewTextBoxColumn();
            txtIdVenta = new TextBox();
            label1 = new Label();
            btnCargar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dGventadetalle).BeginInit();
            SuspendLayout();
            // 
            // dGventadetalle
            // 
            dGventadetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGventadetalle.Columns.AddRange(new DataGridViewColumn[] { Column1, ID, MONTO });
            dGventadetalle.Location = new Point(32, 129);
            dGventadetalle.Name = "dGventadetalle";
            dGventadetalle.RowTemplate.Height = 25;
            dGventadetalle.Size = new Size(344, 150);
            dGventadetalle.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID_VENTA";
            Column1.Name = "Column1";
            // 
            // ID
            // 
            ID.HeaderText = "PRODUCTO_ID";
            ID.Name = "ID";
            // 
            // MONTO
            // 
            MONTO.HeaderText = "MONTO";
            MONTO.Name = "MONTO";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(132, 76);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(100, 23);
            txtIdVenta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 79);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "ID_VENTA";
            // 
            // btnCargar
            // 
            btnCargar.BackgroundImage = Properties.Resources.qqqqq;
            btnCargar.FlatStyle = FlatStyle.Popup;
            btnCargar.Location = new Point(283, 79);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(84, 23);
            btnCargar.TabIndex = 3;
            btnCargar.Text = "CARGAR";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImage = Properties.Resources.qqqqq;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Location = new Point(301, 312);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 41);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(404, 385);
            Controls.Add(btnSalir);
            Controls.Add(btnCargar);
            Controls.Add(label1);
            Controls.Add(txtIdVenta);
            Controls.Add(dGventadetalle);
            Name = "Venta";
            Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)dGventadetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGventadetalle;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MONTO;
        private TextBox txtIdVenta;
        private Label label1;
        private Button btnCargar;
        private Button btnSalir;
    }
}