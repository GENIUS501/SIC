namespace SIC
{
    partial class Cambiar_Contrasena
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
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.txt_confirmar_contrasena = new System.Windows.Forms.TextBox();
            this.txt_contrasena_antigua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_acpetar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(15, 25);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirmacion de contraseña";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(15, 125);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '*';
            this.txt_contrasena.Size = new System.Drawing.Size(100, 20);
            this.txt_contrasena.TabIndex = 3;
            // 
            // txt_confirmar_contrasena
            // 
            this.txt_confirmar_contrasena.Location = new System.Drawing.Point(136, 125);
            this.txt_confirmar_contrasena.Name = "txt_confirmar_contrasena";
            this.txt_confirmar_contrasena.PasswordChar = '*';
            this.txt_confirmar_contrasena.Size = new System.Drawing.Size(100, 20);
            this.txt_confirmar_contrasena.TabIndex = 4;
            // 
            // txt_contrasena_antigua
            // 
            this.txt_contrasena_antigua.Location = new System.Drawing.Point(15, 78);
            this.txt_contrasena_antigua.Name = "txt_contrasena_antigua";
            this.txt_contrasena_antigua.PasswordChar = '*';
            this.txt_contrasena_antigua.Size = new System.Drawing.Size(100, 20);
            this.txt_contrasena_antigua.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contraseña antigua";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIC.Properties.Resources.IMG_Cliente_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(174, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(174, 175);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(47, 43);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_acpetar
            // 
            this.btn_acpetar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Check;
            this.btn_acpetar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acpetar.Location = new System.Drawing.Point(49, 175);
            this.btn_acpetar.Name = "btn_acpetar";
            this.btn_acpetar.Size = new System.Drawing.Size(47, 43);
            this.btn_acpetar.TabIndex = 5;
            this.btn_acpetar.UseVisualStyleBackColor = true;
            this.btn_acpetar.Click += new System.EventHandler(this.btn_acpetar_Click);
            // 
            // Cambiar_Contrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_acpetar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_contrasena_antigua);
            this.Controls.Add(this.txt_confirmar_contrasena);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_usuario);
            this.MaximizeBox = false;
            this.Name = "Cambiar_Contrasena";
            this.Text = "Cambiar_Contrasena";
            this.Load += new System.EventHandler(this.Cambiar_Contrasena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.TextBox txt_confirmar_contrasena;
        private System.Windows.Forms.TextBox txt_contrasena_antigua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_acpetar;
    }
}