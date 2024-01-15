namespace CapaPresentacion
{
    partial class frmMantenimientoCorrectivo
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
            txtRepuestosUtilizados = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 72);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Repuestos Utilizados:";
            // 
            // txtRepuestosUtilizados
            // 
            txtRepuestosUtilizados.Location = new Point(184, 69);
            txtRepuestosUtilizados.Name = "txtRepuestosUtilizados";
            txtRepuestosUtilizados.Size = new Size(226, 23);
            txtRepuestosUtilizados.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 101);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(335, 127);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(254, 127);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmMantenimientoCorrectivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 207);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtRepuestosUtilizados);
            Controls.Add(label1);
            Name = "frmMantenimientoCorrectivo";
            Text = "frmMantenimientoCorrectivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRepuestosUtilizados;
        private Label label2;
        private TextBox textBox1;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}