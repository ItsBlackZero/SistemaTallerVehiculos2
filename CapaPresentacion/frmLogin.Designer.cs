namespace CapaPresentacion
{
    partial class frmLogin
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
            txtUser = new TextBox();
            label3 = new Label();
            txtPass = new TextBox();
            lblOlvideContrasena = new Label();
            lblCrearUsuario = new Label();
            btnIngreso = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 45);
            label1.Name = "label1";
            label1.Size = new Size(215, 46);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 150);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario: ";
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.Window;
            txtUser.ForeColor = SystemColors.InfoText;
            txtUser.Location = new Point(106, 147);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(181, 23);
            txtUser.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 198);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.Window;
            txtPass.ForeColor = SystemColors.InfoText;
            txtPass.Location = new Point(106, 190);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(181, 23);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            txtPass.Enter += txtPass_Enter;
            // 
            // lblOlvideContrasena
            // 
            lblOlvideContrasena.AutoSize = true;
            lblOlvideContrasena.ForeColor = SystemColors.ActiveCaption;
            lblOlvideContrasena.Location = new Point(30, 226);
            lblOlvideContrasena.Name = "lblOlvideContrasena";
            lblOlvideContrasena.Size = new Size(117, 15);
            lblOlvideContrasena.TabIndex = 6;
            lblOlvideContrasena.Text = "olvide mi contraseña";
            lblOlvideContrasena.Click += lblOlvideContrasena_Click;
            // 
            // lblCrearUsuario
            // 
            lblCrearUsuario.AutoSize = true;
            lblCrearUsuario.ForeColor = SystemColors.ActiveCaption;
            lblCrearUsuario.Location = new Point(209, 226);
            lblCrearUsuario.Name = "lblCrearUsuario";
            lblCrearUsuario.Size = new Size(78, 15);
            lblCrearUsuario.TabIndex = 7;
            lblCrearUsuario.Text = "Crear Usuario";
            lblCrearUsuario.Click += lblCrearUsuario_Click;
            // 
            // btnIngreso
            // 
            btnIngreso.Location = new Point(115, 265);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(75, 23);
            btnIngreso.TabIndex = 8;
            btnIngreso.Text = "Ingresar";
            btnIngreso.UseVisualStyleBackColor = true;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 318);
            Controls.Add(btnIngreso);
            Controls.Add(lblCrearUsuario);
            Controls.Add(lblOlvideContrasena);
            Controls.Add(txtPass);
            Controls.Add(label3);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private Label label3;
        private TextBox txtPass;
        private Label lblOlvideContrasena;
        private Label lblCrearUsuario;
        private Button btnIngreso;
    }
}