namespace Interfaz
{
    partial class frmListaOutsourcing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaOutsourcing));
            this.btnLimpiarServicioOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegresarServicioOut = new System.Windows.Forms.Button();
            this.dgvServicioOut = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnEliminarServicioOut = new System.Windows.Forms.Button();
            this.btnModificarServicioOut = new System.Windows.Forms.Button();
            this.btnAgregarServicioOut = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicioOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarServicioOut
            // 
            this.btnLimpiarServicioOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarServicioOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiarServicioOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarServicioOut.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarServicioOut.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarServicioOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarServicioOut.Location = new System.Drawing.Point(557, 274);
            this.btnLimpiarServicioOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarServicioOut.Name = "btnLimpiarServicioOut";
            this.btnLimpiarServicioOut.Size = new System.Drawing.Size(143, 38);
            this.btnLimpiarServicioOut.TabIndex = 130;
            this.btnLimpiarServicioOut.Text = "Limpiar";
            this.btnLimpiarServicioOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarServicioOut.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 78);
            this.groupBox1.TabIndex = 129;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 29);
            this.label3.TabIndex = 114;
            this.label3.Text = "Servicios de Outsourcing";
            // 
            // btnRegresarServicioOut
            // 
            this.btnRegresarServicioOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegresarServicioOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresarServicioOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresarServicioOut.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarServicioOut.ForeColor = System.Drawing.Color.Black;
            this.btnRegresarServicioOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresarServicioOut.Location = new System.Drawing.Point(557, 320);
            this.btnRegresarServicioOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresarServicioOut.Name = "btnRegresarServicioOut";
            this.btnRegresarServicioOut.Size = new System.Drawing.Size(143, 38);
            this.btnRegresarServicioOut.TabIndex = 128;
            this.btnRegresarServicioOut.Text = "Regresar";
            this.btnRegresarServicioOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresarServicioOut.UseVisualStyleBackColor = false;
            this.btnRegresarServicioOut.Click += new System.EventHandler(this.btnRegresarCatBono_Click);
            // 
            // dgvServicioOut
            // 
            this.dgvServicioOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvServicioOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicioOut.Location = new System.Drawing.Point(18, 274);
            this.dgvServicioOut.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServicioOut.Name = "dgvServicioOut";
            this.dgvServicioOut.Size = new System.Drawing.Size(531, 267);
            this.dgvServicioOut.TabIndex = 127;
            this.dgvServicioOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoriaBono_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(393, 215);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 126;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 215);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(31, 215);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 124;
            this.pictureBox3.TabStop = false;
            // 
            // btnEliminarServicioOut
            // 
            this.btnEliminarServicioOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarServicioOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarServicioOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarServicioOut.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServicioOut.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarServicioOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarServicioOut.Location = new System.Drawing.Point(381, 202);
            this.btnEliminarServicioOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarServicioOut.Name = "btnEliminarServicioOut";
            this.btnEliminarServicioOut.Size = new System.Drawing.Size(170, 53);
            this.btnEliminarServicioOut.TabIndex = 123;
            this.btnEliminarServicioOut.Text = "Eliminar";
            this.btnEliminarServicioOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarServicioOut.UseVisualStyleBackColor = false;
            // 
            // btnModificarServicioOut
            // 
            this.btnModificarServicioOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarServicioOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarServicioOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarServicioOut.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarServicioOut.ForeColor = System.Drawing.Color.Black;
            this.btnModificarServicioOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarServicioOut.Location = new System.Drawing.Point(196, 202);
            this.btnModificarServicioOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarServicioOut.Name = "btnModificarServicioOut";
            this.btnModificarServicioOut.Size = new System.Drawing.Size(177, 53);
            this.btnModificarServicioOut.TabIndex = 122;
            this.btnModificarServicioOut.Text = "Modificar";
            this.btnModificarServicioOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarServicioOut.UseVisualStyleBackColor = false;
            // 
            // btnAgregarServicioOut
            // 
            this.btnAgregarServicioOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarServicioOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarServicioOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarServicioOut.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServicioOut.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarServicioOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarServicioOut.Location = new System.Drawing.Point(18, 202);
            this.btnAgregarServicioOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarServicioOut.Name = "btnAgregarServicioOut";
            this.btnAgregarServicioOut.Size = new System.Drawing.Size(170, 53);
            this.btnAgregarServicioOut.TabIndex = 121;
            this.btnAgregarServicioOut.Text = "Agregar";
            this.btnAgregarServicioOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarServicioOut.UseVisualStyleBackColor = false;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(292, 143);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalario.Multiline = true;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(281, 25);
            this.txtSalario.TabIndex = 119;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(288, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 120;
            this.label8.Text = "Salario";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreServicio.Location = new System.Drawing.Point(13, 143);
            this.txtNombreServicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreServicio.Multiline = true;
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(251, 25);
            this.txtNombreServicio.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 118;
            this.label2.Text = "Nombre Servicio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmListaOutsourcing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(734, 559);
            this.Controls.Add(this.btnLimpiarServicioOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresarServicioOut);
            this.Controls.Add(this.dgvServicioOut);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnEliminarServicioOut);
            this.Controls.Add(this.btnModificarServicioOut);
            this.Controls.Add(this.btnAgregarServicioOut);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombreServicio);
            this.Controls.Add(this.label2);
            this.Name = "frmListaOutsourcing";
            this.Text = "Servicios de Outsourcing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicioOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarServicioOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegresarServicioOut;
        private System.Windows.Forms.DataGridView dgvServicioOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnEliminarServicioOut;
        private System.Windows.Forms.Button btnModificarServicioOut;
        private System.Windows.Forms.Button btnAgregarServicioOut;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Label label2;
    }
}