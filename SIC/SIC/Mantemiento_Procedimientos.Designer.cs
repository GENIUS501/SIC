namespace SIC
{
    partial class Mantemiento_Procedimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantemiento_Procedimientos));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_acpetar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_id_procedimiento = new System.Windows.Forms.TextBox();
            this.lbl_id_procedimiento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(338, 229);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(47, 43);
            this.btn_cancelar.TabIndex = 49;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_acpetar
            // 
            this.btn_acpetar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Check;
            this.btn_acpetar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acpetar.Location = new System.Drawing.Point(68, 229);
            this.btn_acpetar.Name = "btn_acpetar";
            this.btn_acpetar.Size = new System.Drawing.Size(47, 43);
            this.btn_acpetar.TabIndex = 48;
            this.btn_acpetar.UseVisualStyleBackColor = true;
            this.btn_acpetar.Click += new System.EventHandler(this.btn_acpetar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIC.Properties.Resources.IMG_Cliente_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(347, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // txt_id_procedimiento
            // 
            this.txt_id_procedimiento.Location = new System.Drawing.Point(15, 25);
            this.txt_id_procedimiento.Name = "txt_id_procedimiento";
            this.txt_id_procedimiento.Size = new System.Drawing.Size(100, 20);
            this.txt_id_procedimiento.TabIndex = 51;
            // 
            // lbl_id_procedimiento
            // 
            this.lbl_id_procedimiento.AutoSize = true;
            this.lbl_id_procedimiento.Location = new System.Drawing.Point(12, 9);
            this.lbl_id_procedimiento.Name = "lbl_id_procedimiento";
            this.lbl_id_procedimiento.Size = new System.Drawing.Size(89, 13);
            this.lbl_id_procedimiento.TabIndex = 52;
            this.lbl_id_procedimiento.Text = "Id_Procedimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nombre del procedimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Descripcion del procedimiento";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(15, 69);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 55;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(15, 105);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(432, 118);
            this.txt_descripcion.TabIndex = 56;
            // 
            // Mantemiento_Procedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(459, 274);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_id_procedimiento);
            this.Controls.Add(this.txt_id_procedimiento);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_acpetar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mantemiento_Procedimientos";
            this.Text = "Mantemiento_Procedimientos";
            this.Load += new System.EventHandler(this.Mantemiento_Procedimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_acpetar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_id_procedimiento;
        private System.Windows.Forms.Label lbl_id_procedimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_descripcion;
    }
}