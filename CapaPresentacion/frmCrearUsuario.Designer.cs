namespace CapaPresentacion
{
    partial class frmCrearUsuario
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
            txtNombre = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            btnAceptar = new Button();
            lblCreacionUsuario = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 57);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(121, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(121, 84);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 87);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Usuario:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(121, 113);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 116);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Password: ";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(121, 142);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 145);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Correo: ";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(146, 180);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblCreacionUsuario
            // 
            lblCreacionUsuario.AutoSize = true;
            lblCreacionUsuario.Location = new Point(25, 19);
            lblCreacionUsuario.Name = "lblCreacionUsuario";
            lblCreacionUsuario.Size = new Size(112, 15);
            lblCreacionUsuario.TabIndex = 9;
            lblCreacionUsuario.Text = "Creacion de usuario";
            // 
            // frmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 258);
            Controls.Add(lblCreacionUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "frmCrearUsuario";
            Text = "Creacion de usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtCorreo;
        private Label label4;
        private Button btnAceptar;
        private Label lblCreacionUsuario;
    }
}