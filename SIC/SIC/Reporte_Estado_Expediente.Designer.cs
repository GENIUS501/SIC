namespace SIC
{
    partial class Reporte_Estado_Expediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Estado_Expediente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_imprimir_expediente = new System.Windows.Forms.Button();
            this.btn_generar_expediente = new System.Windows.Forms.Button();
            this.txt_numero_expediente = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.btn_imprimir_expediente);
            this.groupBox1.Controls.Add(this.btn_generar_expediente);
            this.groupBox1.Controls.Add(this.txt_numero_expediente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de busqueda";
            // 
            // btn_imprimir_expediente
            // 
            this.btn_imprimir_expediente.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Print;
            this.btn_imprimir_expediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_imprimir_expediente.Location = new System.Drawing.Point(153, 42);
            this.btn_imprimir_expediente.Name = "btn_imprimir_expediente";
            this.btn_imprimir_expediente.Size = new System.Drawing.Size(30, 20);
            this.btn_imprimir_expediente.TabIndex = 2;
            this.btn_imprimir_expediente.UseVisualStyleBackColor = true;
            this.btn_imprimir_expediente.Click += new System.EventHandler(this.btn_imprimir_expediente_Click);
            // 
            // btn_generar_expediente
            // 
            this.btn_generar_expediente.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Generate;
            this.btn_generar_expediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_generar_expediente.Location = new System.Drawing.Point(115, 42);
            this.btn_generar_expediente.Name = "btn_generar_expediente";
            this.btn_generar_expediente.Size = new System.Drawing.Size(32, 20);
            this.btn_generar_expediente.TabIndex = 1;
            this.btn_generar_expediente.UseVisualStyleBackColor = true;
            this.btn_generar_expediente.Click += new System.EventHandler(this.btn_generar_expediente_Click);
            // 
            // txt_numero_expediente
            // 
            this.txt_numero_expediente.Location = new System.Drawing.Point(9, 42);
            this.txt_numero_expediente.Name = "txt_numero_expediente";
            this.txt_numero_expediente.Size = new System.Drawing.Size(100, 20);
            this.txt_numero_expediente.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Numero de expediente";
            // 
            // dat_expedientes
            // 
            this.dat_expedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_expedientes.Location = new System.Drawing.Point(10, 94);
            this.dat_expedientes.Name = "dat_expedientes";
            this.dat_expedientes.Size = new System.Drawing.Size(711, 150);
            this.dat_expedientes.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIC.Properties.Resources.IMG_Cliente_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(595, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(477, 261);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 41);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Print;
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_imprimir.Location = new System.Drawing.Point(201, 261);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(62, 41);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // Reporte_Estado_Expediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(730, 307);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dat_expedientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reporte_Estado_Expediente";
            this.Text = "Reporte por estado del expediente";
            this.Load += new System.EventHandler(this.Reporte_Estado_Expediente_Load);
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
        private System.Windows.Forms.Button btn_imprimir_expediente;
        private System.Windows.Forms.Button btn_generar_expediente;
        private System.Windows.Forms.TextBox txt_numero_expediente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dat_expedientes;
    }
}