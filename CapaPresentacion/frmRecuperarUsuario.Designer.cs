namespace CapaPresentacion
{
    partial class frmRecuperarUsuario
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
            txtCorreo = new TextBox();
            btnAceptar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 41);
            label1.Name = "label1";
            label1.Size = new Size(213, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresa tu usuario o correo electronico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(56, 78);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(320, 23);
            txtCorreo.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(301, 125);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(56, 162);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(65, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado: ";
            // 
            // frmRecuperarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 254);
            Controls.Add(lblResultado);
            Controls.Add(btnAceptar);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Name = "frmRecuperarUsuario";
            Text = "frmRecuperarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCorreo;
        private Button btnAceptar;
        private Label lblResultado;
    }
}