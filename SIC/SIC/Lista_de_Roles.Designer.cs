namespace SIC
{
    partial class Lista_de_Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_de_Roles));
            this.dat_usuarios = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dat_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dat_usuarios
            // 
            this.dat_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_usuarios.Location = new System.Drawing.Point(12, 114);
            this.dat_usuarios.Name = "dat_usuarios";
            this.dat_usuarios.Size = new System.Drawing.Size(739, 185);
            this.dat_usuarios.TabIndex = 41;
            this.dat_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_usuarios_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIC.Properties.Resources.IMG_Cliente_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(533, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consultar.Image = global::SIC.Properties.Resources.IMG_Icon_Consult;
            this.btn_consultar.Location = new System.Drawing.Point(180, 67);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(50, 41);
            this.btn_consultar.TabIndex = 40;
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Image = global::SIC.Properties.Resources.IMG_Icon_Delete;
            this.btn_eliminar.Location = new System.Drawing.Point(124, 67);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(50, 41);
            this.btn_eliminar.TabIndex = 39;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar.Image = global::SIC.Properties.Resources.Img_Icon_Modify;
            this.btn_editar.Location = new System.Drawing.Point(68, 67);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(50, 41);
            this.btn_editar.TabIndex = 38;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Add;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Location = new System.Drawing.Point(12, 66);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(50, 41);
            this.btn_agregar.TabIndex = 37;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // Lista_de_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 307);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dat_usuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lista_de_Roles";
            this.Text = "Lista de roles y permisos";
            this.Load += new System.EventHandler(this.Lista_de_Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dat_usuarios;
    }
}