namespace CapaPresentacion
{
    partial class frmConsultarMecanico
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
            txtConsultarMecanico = new TextBox();
            dgvMecanico = new DataGridView();
            btnAceptar = new Button();
            btnRestaurar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMecanico).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Consultar por Cedula";
            // 
            // txtConsultarMecanico
            // 
            txtConsultarMecanico.Location = new Point(27, 58);
            txtConsultarMecanico.Name = "txtConsultarMecanico";
            txtConsultarMecanico.Size = new Size(198, 23);
            txtConsultarMecanico.TabIndex = 1;
            txtConsultarMecanico.KeyPress += txtConsultarMecanico_KeyPress;
            // 
            // dgvMecanico
            // 
            dgvMecanico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMecanico.Location = new Point(245, 22);
            dgvMecanico.Name = "dgvMecanico";
            dgvMecanico.RowTemplate.Height = 25;
            dgvMecanico.Size = new Size(519, 354);
            dgvMecanico.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(150, 87);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 26);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(69, 87);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(75, 26);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // frmConsultarMecanico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRestaurar);
            Controls.Add(btnAceptar);
            Controls.Add(dgvMecanico);
            Controls.Add(txtConsultarMecanico);
            Controls.Add(label1);
            Name = "frmConsultarMecanico";
            Text = "frmConsultarMecanico";
            ((System.ComponentModel.ISupportInitialize)dgvMecanico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtConsultarMecanico;
        private DataGridView dgvMecanico;
        private Button btnAceptar;
        private Button btnRestaurar;
    }
}