namespace SIC
{
    partial class Reporte_por_Cedula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_por_Cedula));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cedula = new System.Windows.Forms.MaskedTextBox();
            this.btn_imprimir_cedula = new System.Windows.Forms.Button();
            this.btn_generar_cedula = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dat_expedientes = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_expedientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cedula);
            this.groupBox1.Controls.Add(this.btn_imprimir_cedula);
            this.groupBox1.Controls.Add(this.btn_generar_cedula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 81);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de busqueda";
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(9, 43);
            this.txt_cedula.Mask = "0000000000";
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(100, 20);
            this.txt_cedula.TabIndex = 28;
            // 
            // btn_imprimir_cedula
            // 
            this.btn_imprimir_cedula.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Print;
            this.btn_imprimir_cedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_imprimir_cedula.Location = new System.Drawing.Point(153, 42);
            this.btn_imprimir_cedula.Name = "btn_imprimir_cedula";
            this.btn_imprimir_cedula.Size = new System.Drawing.Size(30, 20);
            this.btn_imprimir_cedula.TabIndex = 27;
            this.btn_imprimir_cedula.UseVisualStyleBackColor = true;
            this.btn_imprimir_cedula.Click += new System.EventHandler(this.btn_imprimir_cedula_Click);
            // 
            // btn_generar_cedula
            // 
            this.btn_generar_cedula.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Generate;
            this.btn_generar_cedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_generar_cedula.Location = new System.Drawing.Point(115, 42);
            this.btn_generar_cedula.Name = "btn_generar_cedula";
            this.btn_generar_cedula.Size = new System.Drawing.Size(32, 20);
            this.btn_generar_cedula.TabIndex = 25;
            this.btn_generar_cedula.UseVisualStyleBackColor = true;
            this.btn_generar_cedula.Click += new System.EventHandler(this.btn_generar_cedula_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Numero de cedula";
            // 
            // dat_expedientes
            // 
            this.dat_expedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_expedientes.Location = new System.Drawing.Point(12, 99);
            this.dat_expedientes.Name = "dat_expedientes";
            this.dat_expedientes.Size = new System.Drawing.Size(711, 150);
            this.dat_expedientes.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIC.Properties.Resources.IMG_Cliente_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(597, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(479, 266);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 41);
            this.btn_cancelar.TabIndex = 53;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Print;
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_imprimir.Location = new System.Drawing.Point(203, 266);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(62, 41);
            this.btn_imprimir.TabIndex = 52;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // Reporte_por_Cedula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 322);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dat_expedientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte_por_Cedula";
            this.Text = "Reporte de expedientes asociados al funcionario";
            this.Load += new System.EventHandler(this.Reporte_por_Cedula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_expedientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_imprimir_cedula;
        private System.Windows.Forms.Button btn_generar_cedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dat_expedientes;
        private System.Windows.Forms.MaskedTextBox txt_cedula;
    }
}