namespace SADDEX
{
    partial class frmPuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuestos));
            this.dgvPuesto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetallePuesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrePuesto = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnEliminarPuesto = new System.Windows.Forms.Button();
            this.btnModificarPuesto = new System.Windows.Forms.Button();
            this.btnAgregarPuesto = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.limpiarCamposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPuesto
            // 
            this.dgvPuesto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuesto.Location = new System.Drawing.Point(22, 306);
            this.dgvPuesto.Name = "dgvPuesto";
            this.dgvPuesto.Size = new System.Drawing.Size(659, 217);
            this.dgvPuesto.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Detalle del puesto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDetallePuesto
            // 
            this.txtDetallePuesto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetallePuesto.Location = new System.Drawing.Point(266, 128);
            this.txtDetallePuesto.MaxLength = 250;
            this.txtDetallePuesto.Multiline = true;
            this.txtDetallePuesto.Name = "txtDetallePuesto";
            this.txtDetallePuesto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetallePuesto.Size = new System.Drawing.Size(416, 94);
            this.txtDetallePuesto.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre del puesto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNombrePuesto
            // 
            this.txtNombrePuesto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePuesto.Location = new System.Drawing.Point(18, 128);
            this.txtNombrePuesto.Name = "txtNombrePuesto";
            this.txtNombrePuesto.Size = new System.Drawing.Size(243, 31);
            this.txtNombrePuesto.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(431, 270);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 146;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 145;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(153, 270);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 144;
            this.pictureBox3.TabStop = false;
            // 
            // btnEliminarPuesto
            // 
            this.btnEliminarPuesto.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarPuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarPuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPuesto.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPuesto.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarPuesto.Location = new System.Drawing.Point(422, 260);
            this.btnEliminarPuesto.Name = "btnEliminarPuesto";
            this.btnEliminarPuesto.Size = new System.Drawing.Size(124, 40);
            this.btnEliminarPuesto.TabIndex = 143;
            this.btnEliminarPuesto.Text = "Eliminar";
            this.btnEliminarPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarPuesto.UseVisualStyleBackColor = false;
            // 
            // btnModificarPuesto
            // 
            this.btnModificarPuesto.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarPuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarPuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarPuesto.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPuesto.ForeColor = System.Drawing.Color.Black;
            this.btnModificarPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarPuesto.Location = new System.Drawing.Point(280, 260);
            this.btnModificarPuesto.Name = "btnModificarPuesto";
            this.btnModificarPuesto.Size = new System.Drawing.Size(130, 40);
            this.btnModificarPuesto.TabIndex = 142;
            this.btnModificarPuesto.Text = "Modificar";
            this.btnModificarPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarPuesto.UseVisualStyleBackColor = false;
            // 
            // btnAgregarPuesto
            // 
            this.btnAgregarPuesto.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarPuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarPuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPuesto.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPuesto.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPuesto.Location = new System.Drawing.Point(142, 260);
            this.btnAgregarPuesto.Name = "btnAgregarPuesto";
            this.btnAgregarPuesto.Size = new System.Drawing.Size(124, 40);
            this.btnAgregarPuesto.TabIndex = 141;
            this.btnAgregarPuesto.Text = "Agregar";
            this.btnAgregarPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPuesto.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(0, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(715, 51);
            this.label15.TabIndex = 149;
            this.label15.Text = "Mantenimiento de Funcionarios";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarCamposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 25);
            this.menuStrip1.TabIndex = 150;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // limpiarCamposToolStripMenuItem
            // 
            this.limpiarCamposToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarCamposToolStripMenuItem.Name = "limpiarCamposToolStripMenuItem";
            this.limpiarCamposToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.limpiarCamposToolStripMenuItem.Text = "Regresar";
            // 
            // frmPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(715, 538);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnEliminarPuesto);
            this.Controls.Add(this.btnModificarPuesto);
            this.Controls.Add(this.btnAgregarPuesto);
            this.Controls.Add(this.dgvPuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetallePuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombrePuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puestos";
            this.Load += new System.EventHandler(this.frmPuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetallePuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrePuesto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnEliminarPuesto;
        private System.Windows.Forms.Button btnModificarPuesto;
        private System.Windows.Forms.Button btnAgregarPuesto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem limpiarCamposToolStripMenuItem;
    }
}