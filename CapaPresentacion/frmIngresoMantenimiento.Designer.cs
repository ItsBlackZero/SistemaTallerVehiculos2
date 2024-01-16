namespace CapaPresentacion
{
    partial class frmIngresoMantenimiento
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
            txtCodigo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            cmbCliente = new ComboBox();
            cmbMecanico = new ComboBox();
            cmbVehiculo = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtDiagnostico = new TextBox();
            label7 = new Label();
            rtbTrabajosRealizados = new RichTextBox();
            label8 = new Label();
            cmbServicio = new ComboBox();
            label9 = new Label();
            btnAceptar = new Button();
            label10 = new Label();
            txtRepuestosUtilizados = new TextBox();
            txtValorRepuestos = new TextBox();
            label11 = new Label();
            rbCorrectivo = new RadioButton();
            rbPreventivo = new RadioButton();
            rbServicioNo = new RadioButton();
            rbServicioSI = new RadioButton();
            grbMantenimiento = new GroupBox();
            txtValorReparacion = new TextBox();
            label12 = new Label();
            grbMantenimiento.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(150, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(62, 23);
            txtCodigo.TabIndex = 1;
            txtCodigo.Text = "MNT000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 52);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Mecanico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 80);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 110);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha Mantenimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(150, 107);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(150, 77);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(200, 23);
            cmbCliente.TabIndex = 12;
            // 
            // cmbMecanico
            // 
            cmbMecanico.FormattingEnabled = true;
            cmbMecanico.Location = new Point(150, 49);
            cmbMecanico.Name = "cmbMecanico";
            cmbMecanico.Size = new Size(200, 23);
            cmbMecanico.TabIndex = 13;
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Location = new Point(150, 136);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(200, 23);
            cmbVehiculo.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 139);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 14;
            label5.Text = "Vehiculo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 168);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 16;
            label6.Text = "Diagnostico:";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(150, 165);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(200, 23);
            txtDiagnostico.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 200);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 18;
            label7.Text = "Trabajos Realizados:";
            // 
            // rtbTrabajosRealizados
            // 
            rtbTrabajosRealizados.Location = new Point(150, 200);
            rtbTrabajosRealizados.Name = "rtbTrabajosRealizados";
            rtbTrabajosRealizados.Size = new Size(200, 96);
            rtbTrabajosRealizados.TabIndex = 19;
            rtbTrabajosRealizados.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 309);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 22;
            label8.Text = "Servicios Adicionales:";
            // 
            // cmbServicio
            // 
            cmbServicio.Enabled = false;
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Items.AddRange(new object[] { "Sin Servicios Adicionales" });
            cmbServicio.Location = new Point(150, 337);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(200, 23);
            cmbServicio.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 33);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 24;
            label9.Text = "Mantenimiento:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(257, 119);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 25;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 64);
            label10.Name = "label10";
            label10.Size = new Size(118, 15);
            label10.TabIndex = 26;
            label10.Text = "Repuestos Utilizados:";
            // 
            // txtRepuestosUtilizados
            // 
            txtRepuestosUtilizados.Location = new Point(139, 61);
            txtRepuestosUtilizados.Name = "txtRepuestosUtilizados";
            txtRepuestosUtilizados.ReadOnly = true;
            txtRepuestosUtilizados.Size = new Size(193, 23);
            txtRepuestosUtilizados.TabIndex = 27;
            txtRepuestosUtilizados.Text = "N/A";
            // 
            // txtValorRepuestos
            // 
            txtValorRepuestos.Location = new Point(139, 90);
            txtValorRepuestos.Name = "txtValorRepuestos";
            txtValorRepuestos.ReadOnly = true;
            txtValorRepuestos.Size = new Size(193, 23);
            txtValorRepuestos.TabIndex = 29;
            txtValorRepuestos.Text = "0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 93);
            label11.Name = "label11";
            label11.Size = new Size(124, 15);
            label11.TabIndex = 28;
            label11.Text = "Valor de los repuestos:";
            // 
            // rbCorrectivo
            // 
            rbCorrectivo.AutoSize = true;
            rbCorrectivo.Location = new Point(139, 31);
            rbCorrectivo.Name = "rbCorrectivo";
            rbCorrectivo.Size = new Size(80, 19);
            rbCorrectivo.TabIndex = 30;
            rbCorrectivo.Text = "Correctivo";
            rbCorrectivo.UseVisualStyleBackColor = true;
            rbCorrectivo.CheckedChanged += rbCorrectivo_CheckedChanged;
            // 
            // rbPreventivo
            // 
            rbPreventivo.AutoSize = true;
            rbPreventivo.Checked = true;
            rbPreventivo.Location = new Point(252, 31);
            rbPreventivo.Name = "rbPreventivo";
            rbPreventivo.Size = new Size(81, 19);
            rbPreventivo.TabIndex = 31;
            rbPreventivo.TabStop = true;
            rbPreventivo.Text = "Preventivo";
            rbPreventivo.UseVisualStyleBackColor = true;
            rbPreventivo.CheckedChanged += rbPreventivo_CheckedChanged;
            // 
            // rbServicioNo
            // 
            rbServicioNo.AutoSize = true;
            rbServicioNo.Checked = true;
            rbServicioNo.Location = new Point(263, 307);
            rbServicioNo.Name = "rbServicioNo";
            rbServicioNo.Size = new Size(41, 19);
            rbServicioNo.TabIndex = 33;
            rbServicioNo.TabStop = true;
            rbServicioNo.Text = "No";
            rbServicioNo.UseVisualStyleBackColor = true;
            rbServicioNo.CheckedChanged += rbServicioNo_CheckedChanged;
            // 
            // rbServicioSI
            // 
            rbServicioSI.AutoSize = true;
            rbServicioSI.Location = new Point(150, 307);
            rbServicioSI.Name = "rbServicioSI";
            rbServicioSI.Size = new Size(34, 19);
            rbServicioSI.TabIndex = 32;
            rbServicioSI.Text = "Si";
            rbServicioSI.UseVisualStyleBackColor = true;
            rbServicioSI.CheckedChanged += rbServicioSI_CheckedChanged;
            rbServicioSI.EnabledChanged += rbServicioSI_EnabledChanged;
            // 
            // grbMantenimiento
            // 
            grbMantenimiento.Controls.Add(rbPreventivo);
            grbMantenimiento.Controls.Add(rbCorrectivo);
            grbMantenimiento.Controls.Add(txtValorRepuestos);
            grbMantenimiento.Controls.Add(label11);
            grbMantenimiento.Controls.Add(txtRepuestosUtilizados);
            grbMantenimiento.Controls.Add(label10);
            grbMantenimiento.Controls.Add(btnAceptar);
            grbMantenimiento.Controls.Add(label9);
            grbMantenimiento.Location = new Point(11, 398);
            grbMantenimiento.Name = "grbMantenimiento";
            grbMantenimiento.Size = new Size(352, 171);
            grbMantenimiento.TabIndex = 34;
            grbMantenimiento.TabStop = false;
            grbMantenimiento.Text = "Mantenimiento";
            // 
            // txtValorReparacion
            // 
            txtValorReparacion.Location = new Point(150, 366);
            txtValorReparacion.Name = "txtValorReparacion";
            txtValorReparacion.Size = new Size(200, 23);
            txtValorReparacion.TabIndex = 36;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(52, 369);
            label12.Name = "label12";
            label12.Size = new Size(95, 15);
            label12.TabIndex = 35;
            label12.Text = "Valor reparacion:";
            // 
            // frmIngresoMantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 583);
            Controls.Add(txtValorReparacion);
            Controls.Add(label12);
            Controls.Add(grbMantenimiento);
            Controls.Add(rbServicioNo);
            Controls.Add(rbServicioSI);
            Controls.Add(cmbServicio);
            Controls.Add(label8);
            Controls.Add(rtbTrabajosRealizados);
            Controls.Add(label7);
            Controls.Add(txtDiagnostico);
            Controls.Add(label6);
            Controls.Add(cmbVehiculo);
            Controls.Add(label5);
            Controls.Add(cmbMecanico);
            Controls.Add(cmbCliente);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Name = "frmIngresoMantenimiento";
            Text = "frmIngresoMantenimiento";
            grbMantenimiento.ResumeLayout(false);
            grbMantenimiento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cmbCliente;
        private ComboBox cmbMecanico;
        private ComboBox cmbVehiculo;
        private Label label5;
        private Label label6;
        private TextBox txtDiagnostico;
        private Label label7;
        private RichTextBox rtbTrabajosRealizados;
        private Label label8;
        private ComboBox cmbServicio;
        private Label label9;
        private Button btnAceptar;
        private Label label10;
        private TextBox txtRepuestosUtilizados;
        private TextBox txtValorRepuestos;
        private Label label11;
        private RadioButton rbCorrectivo;
        private RadioButton rbPreventivo;
        private RadioButton rbServicioNo;
        private RadioButton rbServicioSI;
        private GroupBox grbMantenimiento;
        private TextBox txtValorReparacion;
        private Label label12;
    }
}