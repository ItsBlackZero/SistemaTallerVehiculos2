namespace CapaPresentacion
{
    partial class frmConsultarCliente
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
            txtConsultaCedula = new TextBox();
            dgvCliente = new DataGridView();
            btnAceptar = new Button();
            btnRestaurar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Consultar por cedula";
            // 
            // txtConsultaCedula
            // 
            txtConsultaCedula.Location = new Point(30, 69);
            txtConsultaCedula.Name = "txtConsultaCedula";
            txtConsultaCedula.Size = new Size(207, 23);
            txtConsultaCedula.TabIndex = 1;
            txtConsultaCedula.KeyPress += txtConsultaCedula_KeyPress;
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(243, 35);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.Size = new Size(528, 397);
            dgvCliente.TabIndex = 2;
            dgvCliente.CellContentClick += dgvCliente_CellContentClick;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(162, 98);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(81, 98);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(75, 23);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // frmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRestaurar);
            Controls.Add(btnAceptar);
            Controls.Add(dgvCliente);
            Controls.Add(txtConsultaCedula);
            Controls.Add(label1);
            Name = "frmConsultarCliente";
            Text = "frmConsultarCliente";
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtConsultaCedula;
        private DataGridView dgvCliente;
        private Button btnAceptar;
        private Button btnRestaurar;
    }
}