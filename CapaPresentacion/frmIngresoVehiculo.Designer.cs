namespace CapaPresentacion
{
    partial class frmIngresoVehiculo
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
            txtPlaca = new TextBox();
            txtModelo = new TextBox();
            label2 = new Label();
            txtAnio = new TextBox();
            label3 = new Label();
            txtKilometraje = new TextBox();
            label4 = new Label();
            btnAceptar = new Button();
            dgvIngreoVehiculo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvIngreoVehiculo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 49);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Placa:";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(112, 46);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(152, 23);
            txtPlaca.TabIndex = 1;
            txtPlaca.TextChanged += txtPlaca_TextChanged;
            txtPlaca.KeyDown += txtPlaca_KeyDown;
            txtPlaca.KeyPress += txtPlaca_KeyPress;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(112, 75);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(152, 23);
            txtModelo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 78);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Modelo:";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(112, 104);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(152, 23);
            txtAnio.TabIndex = 5;
            txtAnio.KeyDown += txtAnio_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 107);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 4;
            label3.Text = "Anio:";
            // 
            // txtKilometraje
            // 
            txtKilometraje.Location = new Point(112, 133);
            txtKilometraje.Name = "txtKilometraje";
            txtKilometraje.Size = new Size(152, 23);
            txtKilometraje.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 136);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 6;
            label4.Text = "Kilometraje: ";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(189, 162);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dgvIngreoVehiculo
            // 
            dgvIngreoVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngreoVehiculo.Location = new Point(291, 49);
            dgvIngreoVehiculo.Name = "dgvIngreoVehiculo";
            dgvIngreoVehiculo.RowTemplate.Height = 25;
            dgvIngreoVehiculo.Size = new Size(476, 352);
            dgvIngreoVehiculo.TabIndex = 9;
            // 
            // frmIngresoVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvIngreoVehiculo);
            Controls.Add(btnAceptar);
            Controls.Add(txtKilometraje);
            Controls.Add(label4);
            Controls.Add(txtAnio);
            Controls.Add(label3);
            Controls.Add(txtModelo);
            Controls.Add(label2);
            Controls.Add(txtPlaca);
            Controls.Add(label1);
            Name = "frmIngresoVehiculo";
            Text = "frmIngresoVehiculo";
            ((System.ComponentModel.ISupportInitialize)dgvIngreoVehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPlaca;
        private TextBox txtModelo;
        private Label label2;
        private TextBox txtAnio;
        private Label label3;
        private TextBox txtKilometraje;
        private Label label4;
        private Button btnAceptar;
        private DataGridView dgvIngreoVehiculo;
    }
}