namespace SIC
{
    partial class Reporte_numero_expediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_numero_expediente));
            this.dat_expediente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_imprimir_cedula = new System.Windows.Forms.Button();
            this.btn_imprimir_nombre = new System.Windows.Forms.Button();
            this.btn_imprimir_expediente = new System.Windows.Forms.Button();
            this.btn_generar_nombre = new System.Windows.Forms.Button();
            this.btn_generar_expediente = new System.Windows.Forms.Button();
            this.btn_generar_cedula = new System.Windows.Forms.Button();
            this.txt_apellido2 = new System.Windows.Forms.TextBox();
            this.txt_apellido1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_num_expediente = new System.Windows.Forms.TextBox();
            this.txt_cedula = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dat_expediente)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dat_expediente
            // 
            this.dat_expediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_expediente.Location = new System.Drawing.Point(12, 207);
            this.dat_expediente.Name = "dat_expediente";
            this.dat_expediente.Size = new System.Drawing.Size(711, 150);
            this.dat_expediente.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_imprimir_cedula);
            this.groupBox1.Controls.Add(this.btn_imprimir_nombre);
            this.groupBox1.Controls.Add(this.btn_imprimir_expediente);
            this.groupBox1.Controls.Add(this.btn_generar_nombre);
            this.groupBox1.Controls.Add(this.btn_generar_expediente);
            this.groupBox1.Controls.Add(this.btn_generar_cedula);
            this.groupBox1.Controls.Add(this.txt_apellido2);
            this.groupBox1.Controls.Add(this.txt_apellido1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_num_expediente);
            this.groupBox1.Controls.Add(this.txt_cedula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de busqueda";
            // 
            // btn_imprimir_cedula
            // 
            this.btn_imprimir_cedula.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Print;
            this.btn_imprimir_cedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_imprimir_cedula.Location = new System.Drawing.Point(153, 31);
            this.btn_imprimir_cedula.Name = "btn_imprimir_cedula";
            this.btn_imprimir_cedula.Size = new System.Drawing.Size(30, 22);
            this.btn_imprimir_cedula.TabIndex = 2;
            this.btn_imprimir_cedula.UseVisualStyleBackColor = true;
            this.btn_imprimir_cedula.Click += new System.EventHandler(this.btn_imprimir_cedula_Click);
            // 
            // btn_imprimir_nombre
            // 
            this.btn_imprimir_nombre.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Print;
            this.btn_imprimir_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_imprimir_nombre.Location = new System.Drawing.Point(368, 148);
            this.btn_imprimir_nombre.Name = "btn_imprimir_nombre";
            this.btn_imprimir_nombre.Size = new System.Drawing.Size(30, 20);
            this.btn_imprimir_nombre.TabIndex = 10;
            this.btn_imprimir_nombre.UseVisualStyleBackColor = true;
            this.btn_imprimir_nombre.Click += new System.EventHandler(this.btn_imprimir_nombre_Click);
            // 
            // btn_imprimir_expediente
            // 
            this.btn_imprimir_expediente.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Print;
            this.btn_imprimir_expediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_imprimir_expediente.Location = new System.Drawing.Point(153, 91);
            this.btn_imprimir_expediente.Name = "btn_imprimir_expediente";
            this.btn_imprimir_expediente.Size = new System.Drawing.Size(30, 20);
            this.btn_imprimir_expediente.TabIndex = 5;
            this.btn_imprimir_expediente.UseVisualStyleBackColor = true;
            this.btn_imprimir_expediente.Click += new System.EventHandler(this.btn_imprimir_expediente_Click);
            // 
            // btn_generar_nombre
            // 
            this.btn_generar_nombre.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Generate;
            this.btn_generar_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_generar_nombre.Location = new System.Drawing.Point(330, 148);
            this.btn_generar_nombre.Name = "btn_generar_nombre";
            this.btn_generar_nombre.Size = new System.Drawing.Size(32, 20);
            this.btn_generar_nombre.TabIndex = 9;
            this.btn_generar_nombre.UseVisualStyleBackColor = true;
            this.btn_generar_nombre.Click += new System.EventHandler(this.btn_generar_nombre_Click);
            // 
            // btn_generar_expediente
            // 
            this.btn_generar_expediente.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Generate;
            this.btn_generar_expediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_generar_expediente.Location = new System.Drawing.Point(115, 91);
            this.btn_generar_expediente.Name = "btn_generar_expediente";
            this.btn_generar_expediente.Size = new System.Drawing.Size(32, 20);
            this.btn_generar_expediente.TabIndex = 4;
            this.btn_generar_expediente.UseVisualStyleBackColor = true;
            this.btn_generar_expediente.Click += new System.EventHandler(this.btn_generar_expediente_Click);
            // 
            // btn_generar_cedula
            // 
            this.btn_generar_cedula.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Generate;
            this.btn_generar_cedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_generar_cedula.Location = new System.Drawing.Point(115, 31);
            this.btn_generar_cedula.Name = "btn_generar_cedula";
            this.btn_generar_cedula.Size = new System.Drawing.Size(32, 22);
            this.btn_generar_cedula.TabIndex = 1;
            this.btn_generar_cedula.UseVisualStyleBackColor = true;
            this.btn_generar_cedula.Click += new System.EventHandler(this.btn_generar_cedula_Click);
            // 
            // txt_apellido2
            // 
            this.txt_apellido2.Location = new System.Drawing.Point(224, 148);
            this.txt_apellido2.Name = "txt_apellido2";
            this.txt_apellido2.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido2.TabIndex = 8;
            // 
            // txt_apellido1
            // 
            this.txt_apellido1.Location = new System.Drawing.Point(115, 148);
            this.txt_apellido1.Name = "txt_apellido1";
            this.txt_apellido1.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Segundo Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Primer Apellido";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(9, 148);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_num_expediente
            // 
            this.txt_num_expediente.Location = new System.Drawing.Point(9, 91);
            this.txt_num_expediente.Name = "txt_num_expediente";
            this.txt_num_expediente.Size = new System.Drawing.Size(100, 20);
            this.txt_num_expediente.TabIndex = 3;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(9, 33);
            this.txt_cedula.Mask = "0000000000";
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(100, 20);
            this.txt_cedula.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Numero de expediente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cedula del funcionario";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_imprimir.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Print;
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_imprimir.Location = new System.Drawing.Point(205, 364);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(62, 41);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(485, 364);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 41);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIC.Properties.Resources.IMG_Cliente_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(485, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // Reporte_numero_expediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(735, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dat_expediente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reporte_numero_expediente";
            this.Text = "Reporte por numero de expediente";
            this.Load += new System.EventHandler(this.Reporte_numero_expediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_expediente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dat_expediente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_generar_nombre;
        private System.Windows.Forms.Button btn_generar_expediente;
        private System.Windows.Forms.Button btn_generar_cedula;
        private System.Windows.Forms.TextBox txt_apellido2;
        private System.Windows.Forms.TextBox txt_apellido1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_num_expediente;
        private System.Windows.Forms.MaskedTextBox txt_cedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_imprimir_cedula;
        private System.Windows.Forms.Button btn_imprimir_nombre;
        private System.Windows.Forms.Button btn_imprimir_expediente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}