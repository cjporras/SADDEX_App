namespace SADDEX
{
    partial class frmOutsourcings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutsourcings));
            this.dtpFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOutsourcing = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNumeroExpediente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvOutourcing = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnEliminarOutourcing = new System.Windows.Forms.Button();
            this.btnModificarOutourcing = new System.Windows.Forms.Button();
            this.btnAgregarOutourcing = new System.Windows.Forms.Button();
            this.btnLimpiarOutourcing = new System.Windows.Forms.Button();
            this.btnRegresarOutourcing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutourcing)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaContrato
            // 
            this.dtpFechaContrato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaContrato.Location = new System.Drawing.Point(566, 137);
            this.dtpFechaContrato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaContrato.Name = "dtpFechaContrato";
            this.dtpFechaContrato.Size = new System.Drawing.Size(191, 27);
            this.dtpFechaContrato.TabIndex = 100;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(562, 112);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 19);
            this.label14.TabIndex = 99;
            this.label14.Text = "Fecha de contratación";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtOutsourcing
            // 
            this.txtOutsourcing.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutsourcing.FormattingEnabled = true;
            this.txtOutsourcing.Location = new System.Drawing.Point(308, 136);
            this.txtOutsourcing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutsourcing.Name = "txtOutsourcing";
            this.txtOutsourcing.Size = new System.Drawing.Size(239, 28);
            this.txtOutsourcing.TabIndex = 98;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(304, 112);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 19);
            this.label17.TabIndex = 97;
            this.label17.Text = "Tipode servicio";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNumeroExpediente
            // 
            this.txtNumeroExpediente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroExpediente.Location = new System.Drawing.Point(18, 130);
            this.txtNumeroExpediente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroExpediente.Name = "txtNumeroExpediente";
            this.txtNumeroExpediente.Size = new System.Drawing.Size(195, 32);
            this.txtNumeroExpediente.TabIndex = 105;
            this.txtNumeroExpediente.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(221, 129);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 33);
            this.btnBuscar.TabIndex = 103;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvOutourcing
            // 
            this.dgvOutourcing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvOutourcing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutourcing.Location = new System.Drawing.Point(18, 270);
            this.dgvOutourcing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOutourcing.Name = "dgvOutourcing";
            this.dgvOutourcing.Size = new System.Drawing.Size(787, 267);
            this.dgvOutourcing.TabIndex = 113;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1235, 81);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 29);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 29);
            this.label15.TabIndex = 51;
            this.label15.Text = "Outsourcing";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(221, 129);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 104;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 19);
            this.label3.TabIndex = 117;
            this.label3.Text = "Número de Expediente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(530, 208);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 123;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 208);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(149, 208);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 121;
            this.pictureBox3.TabStop = false;
            // 
            // btnEliminarOutourcing
            // 
            this.btnEliminarOutourcing.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarOutourcing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarOutourcing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarOutourcing.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarOutourcing.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarOutourcing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarOutourcing.Location = new System.Drawing.Point(522, 196);
            this.btnEliminarOutourcing.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarOutourcing.Name = "btnEliminarOutourcing";
            this.btnEliminarOutourcing.Size = new System.Drawing.Size(175, 49);
            this.btnEliminarOutourcing.TabIndex = 120;
            this.btnEliminarOutourcing.Text = "Eliminar";
            this.btnEliminarOutourcing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarOutourcing.UseVisualStyleBackColor = false;
            this.btnEliminarOutourcing.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificarOutourcing
            // 
            this.btnModificarOutourcing.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarOutourcing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarOutourcing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarOutourcing.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarOutourcing.ForeColor = System.Drawing.Color.Black;
            this.btnModificarOutourcing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarOutourcing.Location = new System.Drawing.Point(334, 196);
            this.btnModificarOutourcing.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarOutourcing.Name = "btnModificarOutourcing";
            this.btnModificarOutourcing.Size = new System.Drawing.Size(175, 49);
            this.btnModificarOutourcing.TabIndex = 119;
            this.btnModificarOutourcing.Text = "Modificar";
            this.btnModificarOutourcing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarOutourcing.UseVisualStyleBackColor = false;
            // 
            // btnAgregarOutourcing
            // 
            this.btnAgregarOutourcing.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarOutourcing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarOutourcing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarOutourcing.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarOutourcing.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarOutourcing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarOutourcing.Location = new System.Drawing.Point(142, 196);
            this.btnAgregarOutourcing.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarOutourcing.Name = "btnAgregarOutourcing";
            this.btnAgregarOutourcing.Size = new System.Drawing.Size(175, 49);
            this.btnAgregarOutourcing.TabIndex = 118;
            this.btnAgregarOutourcing.Text = "Agregar";
            this.btnAgregarOutourcing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarOutourcing.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarOutourcing
            // 
            this.btnLimpiarOutourcing.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarOutourcing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiarOutourcing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarOutourcing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarOutourcing.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarOutourcing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarOutourcing.Location = new System.Drawing.Point(813, 272);
            this.btnLimpiarOutourcing.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarOutourcing.Name = "btnLimpiarOutourcing";
            this.btnLimpiarOutourcing.Size = new System.Drawing.Size(131, 38);
            this.btnLimpiarOutourcing.TabIndex = 125;
            this.btnLimpiarOutourcing.Text = "Limpiar";
            this.btnLimpiarOutourcing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarOutourcing.UseVisualStyleBackColor = false;
            // 
            // btnRegresarOutourcing
            // 
            this.btnRegresarOutourcing.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegresarOutourcing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresarOutourcing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresarOutourcing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarOutourcing.ForeColor = System.Drawing.Color.Black;
            this.btnRegresarOutourcing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresarOutourcing.Location = new System.Drawing.Point(813, 325);
            this.btnRegresarOutourcing.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresarOutourcing.Name = "btnRegresarOutourcing";
            this.btnRegresarOutourcing.Size = new System.Drawing.Size(131, 38);
            this.btnRegresarOutourcing.TabIndex = 124;
            this.btnRegresarOutourcing.Text = "Regresar";
            this.btnRegresarOutourcing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresarOutourcing.UseVisualStyleBackColor = false;
            // 
            // frmOutsourcings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(963, 546);
            this.Controls.Add(this.btnLimpiarOutourcing);
            this.Controls.Add(this.btnRegresarOutourcing);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnEliminarOutourcing);
            this.Controls.Add(this.btnModificarOutourcing);
            this.Controls.Add(this.btnAgregarOutourcing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOutourcing);
            this.Controls.Add(this.txtNumeroExpediente);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFechaContrato);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtOutsourcing);
            this.Controls.Add(this.label17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmOutsourcings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outsourcing";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutourcing)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaContrato;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox txtOutsourcing;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNumeroExpediente;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvOutourcing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnEliminarOutourcing;
        private System.Windows.Forms.Button btnModificarOutourcing;
        private System.Windows.Forms.Button btnAgregarOutourcing;
        private System.Windows.Forms.Button btnLimpiarOutourcing;
        private System.Windows.Forms.Button btnRegresarOutourcing;
    }
}