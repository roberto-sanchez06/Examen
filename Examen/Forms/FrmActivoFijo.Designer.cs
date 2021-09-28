namespace Examen.Forms
{
    partial class FrmActivoFijo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblValorResidual = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoActivo = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.nudValorR = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTIpoActivo = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorR)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(26, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(3, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(84, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTIpoActivo);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.nudValorR);
            this.groupBox1.Controls.Add(this.nudValor);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.lblTipoActivo);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblValorResidual);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Location = new System.Drawing.Point(104, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 320);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Activo Fijo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(26, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(27, 115);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(26, 174);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(64, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor Activo";
            // 
            // lblValorResidual
            // 
            this.lblValorResidual.AutoSize = true;
            this.lblValorResidual.Location = new System.Drawing.Point(26, 210);
            this.lblValorResidual.Name = "lblValorResidual";
            this.lblValorResidual.Size = new System.Drawing.Size(70, 13);
            this.lblValorResidual.TabIndex = 4;
            this.lblValorResidual.Text = "Valor residual";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(26, 249);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha Adquisicion";
            // 
            // lblTipoActivo
            // 
            this.lblTipoActivo.AutoSize = true;
            this.lblTipoActivo.Location = new System.Drawing.Point(26, 289);
            this.lblTipoActivo.Name = "lblTipoActivo";
            this.lblTipoActivo.Size = new System.Drawing.Size(75, 13);
            this.lblTipoActivo.TabIndex = 4;
            this.lblTipoActivo.Text = "Tipo de activo";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(135, 41);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 6;
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCod_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(135, 112);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(190, 42);
            this.txtDesc.TabIndex = 8;
            // 
            // nudValor
            // 
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Location = new System.Drawing.Point(135, 174);
            this.nudValor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudValor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(120, 20);
            this.nudValor.TabIndex = 9;
            this.nudValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudValorR
            // 
            this.nudValorR.DecimalPlaces = 2;
            this.nudValorR.Location = new System.Drawing.Point(135, 208);
            this.nudValorR.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudValorR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValorR.Name = "nudValorR";
            this.nudValorR.Size = new System.Drawing.Size(120, 20);
            this.nudValorR.TabIndex = 10;
            this.nudValorR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(135, 249);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 11;
            // 
            // cmbTIpoActivo
            // 
            this.cmbTIpoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTIpoActivo.FormattingEnabled = true;
            this.cmbTIpoActivo.Location = new System.Drawing.Point(135, 289);
            this.cmbTIpoActivo.Name = "cmbTIpoActivo";
            this.cmbTIpoActivo.Size = new System.Drawing.Size(121, 21);
            this.cmbTIpoActivo.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAceptar);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(104, 361);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 34);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // FrmActivoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmActivoFijo";
            this.Text = "FrmActivoFijo";
            this.Load += new System.EventHandler(this.FrmActivoFijo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorR)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTIpoActivo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.NumericUpDown nudValorR;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblTipoActivo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblValorResidual;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}