namespace WINFORM
{
    partial class Menu
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
            btnCajasM = new Button();
            btnSalirM = new Button();
            btnVentasM = new Button();
            btnMotosM = new Button();
            btnUsuarioM = new Button();
            SuspendLayout();
            // 
            // btnCajasM
            // 
            btnCajasM.BackgroundImage = Properties.Resources.qqqqq;
            btnCajasM.FlatStyle = FlatStyle.Popup;
            btnCajasM.Location = new Point(3, 156);
            btnCajasM.Name = "btnCajasM";
            btnCajasM.Size = new Size(177, 57);
            btnCajasM.TabIndex = 0;
            btnCajasM.Text = "CAJAS";
            btnCajasM.UseVisualStyleBackColor = true;
            btnCajasM.Click += btnCajasM_Click;
            // 
            // btnSalirM
            // 
            btnSalirM.BackgroundImage = Properties.Resources.qqqqq;
            btnSalirM.FlatStyle = FlatStyle.Popup;
            btnSalirM.Location = new Point(48, 320);
            btnSalirM.Name = "btnSalirM";
            btnSalirM.Size = new Size(75, 47);
            btnSalirM.TabIndex = 1;
            btnSalirM.Text = "EXIT";
            btnSalirM.UseVisualStyleBackColor = true;
            btnSalirM.Click += btnSalirM_Click;
            // 
            // btnVentasM
            // 
            btnVentasM.BackgroundImage = Properties.Resources.qqqqq;
            btnVentasM.FlatStyle = FlatStyle.Popup;
            btnVentasM.Location = new Point(3, 219);
            btnVentasM.Name = "btnVentasM";
            btnVentasM.Size = new Size(177, 57);
            btnVentasM.TabIndex = 2;
            btnVentasM.Text = "VENTAS";
            btnVentasM.UseVisualStyleBackColor = true;
            btnVentasM.Click += btnVentasM_Click;
            // 
            // btnMotosM
            // 
            btnMotosM.BackgroundImage = Properties.Resources.qqqqq;
            btnMotosM.FlatStyle = FlatStyle.Popup;
            btnMotosM.Location = new Point(3, 91);
            btnMotosM.Name = "btnMotosM";
            btnMotosM.Size = new Size(177, 59);
            btnMotosM.TabIndex = 3;
            btnMotosM.Text = "PRODUCTS";
            btnMotosM.UseVisualStyleBackColor = true;
            btnMotosM.Click += btnMotosM_Click;
            // 
            // btnUsuarioM
            // 
            btnUsuarioM.BackgroundImage = Properties.Resources.qqqqq;
            btnUsuarioM.FlatStyle = FlatStyle.Popup;
            btnUsuarioM.Location = new Point(3, 34);
            btnUsuarioM.Name = "btnUsuarioM";
            btnUsuarioM.Size = new Size(177, 51);
            btnUsuarioM.TabIndex = 4;
            btnUsuarioM.Text = "CUSTOMERS";
            btnUsuarioM.UseVisualStyleBackColor = true;
            btnUsuarioM.Click += btnUsuarioM_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(183, 400);
            Controls.Add(btnUsuarioM);
            Controls.Add(btnMotosM);
            Controls.Add(btnVentasM);
            Controls.Add(btnSalirM);
            Controls.Add(btnCajasM);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCajasM;
        private Button btnSalirM;
        private Button btnVentasM;
        private Button btnMotosM;
        private Button btnUsuarioM;
    }
}