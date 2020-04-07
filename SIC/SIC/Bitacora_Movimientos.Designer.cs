namespace SIC
{
    partial class Bitacora_Movimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora_Movimientos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_imprimir_fecha = new System.Windows.Forms.Button();
            this.btn_generar_fecha = new System.Windows.Forms.Button();
            this.txt_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.txt_fecha_ini = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_imprimir_usuario = new System.Windows.Forms.Button();
            this.btn_generar_usuario = new System.Windows.Forms.Button();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dat_movimientos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_movimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_imprimir_fecha);
            this.groupBox1.Controls.Add(this.btn_generar_fecha);
            this.groupBox1.Controls.Add(this.txt_fecha_fin);
            this.groupBox1.Controls.Add(this.txt_fecha_ini);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_imprimir_usuario);
            this.groupBox1.Controls.Add(this.btn_generar_usuario);
            this.groupBox1.Controls.Add(this.Txt_Usuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 154);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de busqueda";
            // 
            // btn_imprimir_fecha
            // 
            this.btn_imprimir_fecha.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Print;
            this.btn_imprimir_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_imprimir_fecha.Location = new System.Drawing.Point(459, 95);
            this.btn_imprimir_fecha.Name = "btn_imprimir_fecha";
            this.btn_imprimir_fecha.Size = new System.Drawing.Size(30, 20);
            this.btn_imprimir_fecha.TabIndex = 33;
            this.btn_imprimir_fecha.UseVisualStyleBackColor = true;
            this.btn_imprimir_fecha.Click += new System.EventHandler(this.btn_imprimir_fecha_Click);
            // 
            // btn_generar_fecha
            // 
            this.btn_generar_fecha.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Generate;
            this.btn_generar_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_generar_fecha.Location = new System.Drawing.Point(421, 95);
            this.btn_generar_fecha.Name = "btn_generar_fecha";
            this.btn_generar_fecha.Size = new System.Drawing.Size(32, 20);
            this.btn_generar_fecha.TabIndex = 32;
            this.btn_generar_fecha.UseVisualStyleBackColor = true;
            this.btn_generar_fecha.Click += new System.EventHandler(this.btn_generar_fecha_Click);
            // 
            // txt_fecha_fin
            // 
            this.txt_fecha_fin.Location = new System.Drawing.Point(215, 95);
            this.txt_fecha_fin.Name = "txt_fecha_fin";
            this.txt_fecha_fin.Size = new System.Drawing.Size(200, 20);
            this.txt_fecha_fin.TabIndex = 31;
            // 
            // txt_fecha_ini
            // 
            this.txt_fecha_ini.Location = new System.Drawing.Point(9, 95);
            this.txt_fecha_ini.Name = "txt_fecha_ini";
            this.txt_fecha_ini.Size = new System.Drawing.Size(200, 20);
            this.txt_fecha_ini.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fecha Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fecha inicial";
            // 
            // btn_imprimir_usuario
            // 
            this.btn_imprimir_usuario.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Print;
            this.btn_imprimir_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_imprimir_usuario.Location = new System.Drawing.Point(153, 42);
            this.btn_imprimir_usuario.Name = "btn_imprimir_usuario";
            this.btn_imprimir_usuario.Size = new System.Drawing.Size(30, 20);
            this.btn_imprimir_usuario.TabIndex = 27;
            this.btn_imprimir_usuario.UseVisualStyleBackColor = true;
            this.btn_imprimir_usuario.Click += new System.EventHandler(this.btn_imprimir_usuario_Click);
            // 
            // btn_generar_usuario
            // 
            this.btn_generar_usuario.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Generate;
            this.btn_generar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_generar_usuario.Location = new System.Drawing.Point(115, 42);
            this.btn_generar_usuario.Name = "btn_generar_usuario";
            this.btn_generar_usuario.Size = new System.Drawing.Size(32, 20);
            this.btn_generar_usuario.TabIndex = 25;
            this.btn_generar_usuario.UseVisualStyleBackColor = true;
            this.btn_generar_usuario.Click += new System.EventHandler(this.btn_generar_usuario_Click);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(9, 42);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(100, 20);
            this.Txt_Usuario.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre de usuario";
            // 
            // dat_movimientos
            // 
            this.dat_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_movimientos.Location = new System.Drawing.Point(12, 172);
            this.dat_movimientos.Name = "dat_movimientos";
            this.dat_movimientos.Size = new System.Drawing.Size(711, 150);
            this.dat_movimientos.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIC.Properties.Resources.IMG_Cliente_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(556, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(479, 339);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 41);
            this.btn_cancelar.TabIndex = 58;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Print;
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_imprimir.Location = new System.Drawing.Point(203, 339);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(62, 41);
            this.btn_imprimir.TabIndex = 57;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // Bitacora_Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(736, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dat_movimientos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bitacora_Movimientos";
            this.Text = "Bitacora de movimientos";
            this.Load += new System.EventHandler(this.Bitacora_Movimientos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_movimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_imprimir_fecha;
        private System.Windows.Forms.Button btn_generar_fecha;
        private System.Windows.Forms.DateTimePicker txt_fecha_fin;
        private System.Windows.Forms.DateTimePicker txt_fecha_ini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_imprimir_usuario;
        private System.Windows.Forms.Button btn_generar_usuario;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dat_movimientos;
    }
}