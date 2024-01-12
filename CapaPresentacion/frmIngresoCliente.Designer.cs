namespace CapaPresentacion
{
    partial class frmIngresoCliente
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
            txtApellidos = new TextBox();
            label2 = new Label();
            txtCedula = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 109);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 106);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(124, 135);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(100, 23);
            txtApellidos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 138);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellidos: ";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(124, 164);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(100, 23);
            txtCedula.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 167);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Cedula: ";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(124, 193);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 196);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefono: ";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(124, 222);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 225);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 8;
            label5.Text = "Direccion:";
            // 
            // button1
            // 
            button1.Location = new Point(149, 251);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmIngresoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtCedula);
            Controls.Add(label3);
            Controls.Add(txtApellidos);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "frmIngresoCliente";
            Text = "frmIngresoCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private Label label2;
        private TextBox txtCedula;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtDireccion;
        private Label label5;
        private Button button1;
    }
}