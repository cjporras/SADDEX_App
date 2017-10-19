namespace Interfaz
{
    partial class frmFactura
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
            this.btnLimpiarFactura = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegresarFactura = new System.Windows.Forms.Button();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.btnEliminarFactura = new System.Windows.Forms.Button();
            this.btnModificarFactura = new System.Windows.Forms.Button();
            this.btnAgregarFactura = new System.Windows.Forms.Button();
            this.txtDetalleFacturacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaFacturacion = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtTotall = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarFactura
            // 
            this.btnLimpiarFactura.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarFactura.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFactura.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFactura.Location = new System.Drawing.Point(1274, 306);
            this.btnLimpiarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarFactura.Name = "btnLimpiarFactura";
            this.btnLimpiarFactura.Size = new System.Drawing.Size(143, 38);
            this.btnLimpiarFactura.TabIndex = 130;
            this.btnLimpiarFactura.Text = "Limpiar";
            this.btnLimpiarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarFactura.UseVisualStyleBackColor = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTotal.Controls.Add(this.label12);
            this.txtTotal.Controls.Add(this.label3);
            this.txtTotal.Location = new System.Drawing.Point(1, -1);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(1435, 78);
            this.txtTotal.TabIndex = 129;
            this.txtTotal.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(560, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(276, 29);
            this.label12.TabIndex = 115;
            this.label12.Text = "Detalle de Facturación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 114;
            this.label3.Text = "Factura";
            // 
            // btnRegresarFactura
            // 
            this.btnRegresarFactura.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegresarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresarFactura.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarFactura.ForeColor = System.Drawing.Color.Black;
            this.btnRegresarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresarFactura.Location = new System.Drawing.Point(1274, 352);
            this.btnRegresarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresarFactura.Name = "btnRegresarFactura";
            this.btnRegresarFactura.Size = new System.Drawing.Size(143, 38);
            this.btnRegresarFactura.TabIndex = 128;
            this.btnRegresarFactura.Text = "Regresar";
            this.btnRegresarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresarFactura.UseVisualStyleBackColor = false;
            // 
            // dgvFactura
            // 
            this.dgvFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(575, 310);
            this.dgvFactura.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(691, 267);
            this.dgvFactura.TabIndex = 127;
            // 
            // btnEliminarFactura
            // 
            this.btnEliminarFactura.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarFactura.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFactura.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarFactura.Location = new System.Drawing.Point(938, 244);
            this.btnEliminarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarFactura.Name = "btnEliminarFactura";
            this.btnEliminarFactura.Size = new System.Drawing.Size(150, 48);
            this.btnEliminarFactura.TabIndex = 123;
            this.btnEliminarFactura.Text = "Eliminar";
            this.btnEliminarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarFactura.UseVisualStyleBackColor = false;
            // 
            // btnModificarFactura
            // 
            this.btnModificarFactura.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarFactura.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarFactura.ForeColor = System.Drawing.Color.Black;
            this.btnModificarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarFactura.Location = new System.Drawing.Point(753, 244);
            this.btnModificarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarFactura.Name = "btnModificarFactura";
            this.btnModificarFactura.Size = new System.Drawing.Size(157, 48);
            this.btnModificarFactura.TabIndex = 122;
            this.btnModificarFactura.Text = "Modificar";
            this.btnModificarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarFactura.UseVisualStyleBackColor = false;
            // 
            // btnAgregarFactura
            // 
            this.btnAgregarFactura.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarFactura.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFactura.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarFactura.Location = new System.Drawing.Point(575, 244);
            this.btnAgregarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarFactura.Name = "btnAgregarFactura";
            this.btnAgregarFactura.Size = new System.Drawing.Size(150, 48);
            this.btnAgregarFactura.TabIndex = 121;
            this.btnAgregarFactura.Text = "Agregar";
            this.btnAgregarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarFactura.UseVisualStyleBackColor = false;
            // 
            // txtDetalleFacturacion
            // 
            this.txtDetalleFacturacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleFacturacion.Location = new System.Drawing.Point(575, 194);
            this.txtDetalleFacturacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalleFacturacion.Multiline = true;
            this.txtDetalleFacturacion.Name = "txtDetalleFacturacion";
            this.txtDetalleFacturacion.Size = new System.Drawing.Size(215, 24);
            this.txtDetalleFacturacion.TabIndex = 119;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 120;
            this.label8.Text = "Proveedor";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(575, 122);
            this.txtConcepto.Margin = new System.Windows.Forms.Padding(4);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(215, 23);
            this.txtConcepto.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 131;
            this.label1.Text = "Servicio prestado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(27, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(219, 24);
            this.comboBox2.TabIndex = 133;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(300, 181);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(219, 24);
            this.comboBox3.TabIndex = 134;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 135;
            this.label4.Text = "Usuario";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(300, 123);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(192, 24);
            this.cmbUsuario.TabIndex = 136;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 353);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 137;
            this.label5.Text = "Sub Total";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 138;
            this.label6.Text = "Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(218, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 139;
            this.label7.Text = "Impuesto";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(571, 95);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 23);
            this.label10.TabIndex = 141;
            this.label10.Text = "Concepto";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 95);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 23);
            this.label11.TabIndex = 142;
            this.label11.Text = "Fecha Facturación";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpFechaFacturacion
            // 
            this.dtpFechaFacturacion.Location = new System.Drawing.Point(26, 121);
            this.dtpFechaFacturacion.Name = "dtpFechaFacturacion";
            this.dtpFechaFacturacion.Size = new System.Drawing.Size(251, 22);
            this.dtpFechaFacturacion.TabIndex = 143;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(811, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 140;
            this.label9.Text = "Cantidad";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(815, 195);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(215, 23);
            this.txtCantidad.TabIndex = 144;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 145;
            this.label2.Text = "Detalle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(49, 380);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Multiline = true;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(115, 23);
            this.txtSubTotal.TabIndex = 146;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.Location = new System.Drawing.Point(208, 380);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtImpuesto.Multiline = true;
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(115, 23);
            this.txtImpuesto.TabIndex = 147;
            // 
            // txtTotall
            // 
            this.txtTotall.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotall.Location = new System.Drawing.Point(373, 380);
            this.txtTotall.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotall.Multiline = true;
            this.txtTotall.Name = "txtTotall";
            this.txtTotall.Size = new System.Drawing.Size(115, 23);
            this.txtTotall.TabIndex = 148;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(1042, 195);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(215, 23);
            this.txtMonto.TabIndex = 150;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1038, 168);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 23);
            this.label13.TabIndex = 149;
            this.label13.Text = "Monto";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 244);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 24);
            this.comboBox1.TabIndex = 152;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 218);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 23);
            this.label14.TabIndex = 151;
            this.label14.Text = "Cliente";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1435, 592);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotall);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dtpFechaFacturacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiarFactura);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnRegresarFactura);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.btnEliminarFactura);
            this.Controls.Add(this.btnModificarFactura);
            this.Controls.Add(this.btnAgregarFactura);
            this.Controls.Add(this.txtDetalleFacturacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtConcepto);
            this.Name = "frmFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.txtTotal.ResumeLayout(false);
            this.txtTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarFactura;
        private System.Windows.Forms.GroupBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegresarFactura;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Button btnEliminarFactura;
        private System.Windows.Forms.Button btnModificarFactura;
        private System.Windows.Forms.Button btnAgregarFactura;
        private System.Windows.Forms.TextBox txtDetalleFacturacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaFacturacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtTotall;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
    }
}