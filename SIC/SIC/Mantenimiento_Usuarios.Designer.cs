namespace SIC
{
    partial class Mantenimiento_Usuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento_Usuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_confirmar_contrasena = new System.Windows.Forms.TextBox();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_rol = new System.Windows.Forms.ComboBox();
            this.tabPerfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sICDataSet = new SIC.SICDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_genero = new System.Windows.Forms.ComboBox();
            this.txt_apellido2 = new System.Windows.Forms.TextBox();
            this.txt_apellido1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.MaskedTextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_acpetar = new System.Windows.Forms.Button();
            this.tab_PerfilesTableAdapter = new SIC.SICDataSetTableAdapters.Tab_PerfilesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPerfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.txt_confirmar_contrasena);
            this.groupBox1.Controls.Add(this.txt_contrasena);
            this.groupBox1.Controls.Add(this.lbl_contrasena);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbo_rol);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbo_genero);
            this.groupBox1.Controls.Add(this.txt_apellido2);
            this.groupBox1.Controls.Add(this.txt_apellido1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_cedula);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 287);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del usuario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Nombre de usuario";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(126, 85);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 75;
            // 
            // txt_confirmar_contrasena
            // 
            this.txt_confirmar_contrasena.Location = new System.Drawing.Point(130, 237);
            this.txt_confirmar_contrasena.Name = "txt_confirmar_contrasena";
            this.txt_confirmar_contrasena.PasswordChar = '*';
            this.txt_confirmar_contrasena.Size = new System.Drawing.Size(100, 20);
            this.txt_confirmar_contrasena.TabIndex = 74;
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(9, 237);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '*';
            this.txt_contrasena.Size = new System.Drawing.Size(100, 20);
            this.txt_contrasena.TabIndex = 73;
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Location = new System.Drawing.Point(127, 221);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(139, 13);
            this.lbl_contrasena.TabIndex = 72;
            this.lbl_contrasena.Text = "Confirmacion de contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Contraseña";
            // 
            // cbo_rol
            // 
            this.cbo_rol.DataSource = this.tabPerfilesBindingSource;
            this.cbo_rol.DisplayMember = "Nombre_Perfil";
            this.cbo_rol.FormattingEnabled = true;
            this.cbo_rol.Location = new System.Drawing.Point(126, 185);
            this.cbo_rol.Name = "cbo_rol";
            this.cbo_rol.Size = new System.Drawing.Size(100, 21);
            this.cbo_rol.TabIndex = 70;
            this.cbo_rol.ValueMember = "Id_Perfil";
            // 
            // tabPerfilesBindingSource
            // 
            this.tabPerfilesBindingSource.DataMember = "Tab_Perfiles";
            this.tabPerfilesBindingSource.DataSource = this.sICDataSet;
            // 
            // sICDataSet
            // 
            this.sICDataSet.DataSetName = "SICDataSet";
            this.sICDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Rol";
            // 
            // cbo_genero
            // 
            this.cbo_genero.FormattingEnabled = true;
            this.cbo_genero.Location = new System.Drawing.Point(9, 185);
            this.cbo_genero.Name = "cbo_genero";
            this.cbo_genero.Size = new System.Drawing.Size(100, 21);
            this.cbo_genero.TabIndex = 68;
            // 
            // txt_apellido2
            // 
            this.txt_apellido2.Location = new System.Drawing.Point(126, 136);
            this.txt_apellido2.Name = "txt_apellido2";
            this.txt_apellido2.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido2.TabIndex = 67;
            // 
            // txt_apellido1
            // 
            this.txt_apellido1.Location = new System.Drawing.Point(9, 136);
            this.txt_apellido1.Name = "txt_apellido1";
            this.txt_apellido1.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido1.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Segundo apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Primer apelllido";
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(9, 32);
            this.txt_cedula.Mask = "0000000000";
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(100, 20);
            this.txt_cedula.TabIndex = 61;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(9, 85);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Cedula";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIC.Properties.Resources.IMG_Cliente_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(311, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(366, 305);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(47, 43);
            this.btn_cancelar.TabIndex = 51;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_acpetar
            // 
            this.btn_acpetar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Check;
            this.btn_acpetar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acpetar.Location = new System.Drawing.Point(111, 305);
            this.btn_acpetar.Name = "btn_acpetar";
            this.btn_acpetar.Size = new System.Drawing.Size(47, 43);
            this.btn_acpetar.TabIndex = 50;
            this.btn_acpetar.UseVisualStyleBackColor = true;
            this.btn_acpetar.Click += new System.EventHandler(this.btn_acpetar_Click);
            // 
            // tab_PerfilesTableAdapter
            // 
            this.tab_PerfilesTableAdapter.ClearBeforeFill = true;
            // 
            // Mantenimiento_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_acpetar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mantenimiento_Usuarios";
            this.Text = "Mantenimiento de usuarios";
            this.Load += new System.EventHandler(this.Mantenimiento_Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPerfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_rol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_genero;
        private System.Windows.Forms.TextBox txt_apellido2;
        private System.Windows.Forms.TextBox txt_apellido1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_acpetar;
        private System.Windows.Forms.TextBox txt_confirmar_contrasena;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.Label label8;
        private SICDataSet sICDataSet;
        private System.Windows.Forms.BindingSource tabPerfilesBindingSource;
        private SICDataSetTableAdapters.Tab_PerfilesTableAdapter tab_PerfilesTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_usuario;
    }
}