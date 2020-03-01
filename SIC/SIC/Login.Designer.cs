namespace SIC
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Contrasena = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // Txt_Contrasena
            // 
            this.Txt_Contrasena.Location = new System.Drawing.Point(87, 144);
            this.Txt_Contrasena.Name = "Txt_Contrasena";
            this.Txt_Contrasena.Size = new System.Drawing.Size(100, 20);
            this.Txt_Contrasena.TabIndex = 2;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(87, 70);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(100, 20);
            this.Txt_Usuario.TabIndex = 3;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Btn_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Aceptar.BackgroundImage")));
            this.Btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Aceptar.Location = new System.Drawing.Point(50, 215);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(66, 61);
            this.Btn_Aceptar.TabIndex = 4;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.BackgroundImage")));
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Cancelar.Location = new System.Drawing.Point(166, 215);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(66, 61);
            this.Btn_Cancelar.TabIndex = 5;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 321);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Txt_Contrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Contrasena;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}

