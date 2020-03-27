namespace SIC
{
    partial class Mantenimiento_Casos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento_Casos));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_acpetar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_estado = new System.Windows.Forms.ComboBox();
            this.cbo_tipo_procedimiento = new System.Windows.Forms.ComboBox();
            this.tabProcedimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sICDataSet1 = new SIC.SICDataSet1();
            this.cbo_parte_procesal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_lugar_trabajo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_num_expediente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_medida_cautelar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.sICDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_ProcedimientoTableAdapter = new SIC.SICDataSet1TableAdapters.Tab_ProcedimientoTableAdapter();
            this.txt_cedula = new System.Windows.Forms.MaskedTextBox();
            this.txt_organo_director = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabProcedimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sICDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Cancel;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(424, 480);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(47, 43);
            this.btn_cancelar.TabIndex = 47;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_acpetar
            // 
            this.btn_acpetar.BackgroundImage = global::SIC.Properties.Resources.IMG_Icon_Check;
            this.btn_acpetar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acpetar.Location = new System.Drawing.Point(149, 480);
            this.btn_acpetar.Name = "btn_acpetar";
            this.btn_acpetar.Size = new System.Drawing.Size(47, 43);
            this.btn_acpetar.TabIndex = 46;
            this.btn_acpetar.UseVisualStyleBackColor = true;
            this.btn_acpetar.Click += new System.EventHandler(this.btn_acpetar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIC.Properties.Resources.IMG_Cliente_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(465, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_organo_director);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_cedula);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbo_estado);
            this.groupBox1.Controls.Add(this.cbo_tipo_procedimiento);
            this.groupBox1.Controls.Add(this.cbo_parte_procesal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_lugar_trabajo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_num_expediente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 175);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del expediente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Estado";
            // 
            // cbo_estado
            // 
            this.cbo_estado.FormattingEnabled = true;
            this.cbo_estado.Location = new System.Drawing.Point(306, 31);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Size = new System.Drawing.Size(121, 21);
            this.cbo_estado.TabIndex = 70;
            // 
            // cbo_tipo_procedimiento
            // 
            this.cbo_tipo_procedimiento.DataSource = this.tabProcedimientoBindingSource;
            this.cbo_tipo_procedimiento.DisplayMember = "Nombre_Procedimiento";
            this.cbo_tipo_procedimiento.FormattingEnabled = true;
            this.cbo_tipo_procedimiento.Location = new System.Drawing.Point(306, 91);
            this.cbo_tipo_procedimiento.Name = "cbo_tipo_procedimiento";
            this.cbo_tipo_procedimiento.Size = new System.Drawing.Size(121, 21);
            this.cbo_tipo_procedimiento.TabIndex = 69;
            this.cbo_tipo_procedimiento.ValueMember = "Id_Procedimiento";
            // 
            // tabProcedimientoBindingSource
            // 
            this.tabProcedimientoBindingSource.DataMember = "Tab_Procedimiento";
            this.tabProcedimientoBindingSource.DataSource = this.sICDataSet1;
            // 
            // sICDataSet1
            // 
            this.sICDataSet1.DataSetName = "SICDataSet1";
            this.sICDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbo_parte_procesal
            // 
            this.cbo_parte_procesal.FormattingEnabled = true;
            this.cbo_parte_procesal.Location = new System.Drawing.Point(144, 92);
            this.cbo_parte_procesal.Name = "cbo_parte_procesal";
            this.cbo_parte_procesal.Size = new System.Drawing.Size(121, 21);
            this.cbo_parte_procesal.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Tipo de procedimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Parte procesal";
            // 
            // txt_lugar_trabajo
            // 
            this.txt_lugar_trabajo.Location = new System.Drawing.Point(9, 92);
            this.txt_lugar_trabajo.Name = "txt_lugar_trabajo";
            this.txt_lugar_trabajo.Size = new System.Drawing.Size(100, 20);
            this.txt_lugar_trabajo.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Lugar de trabajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Cedula";
            // 
            // txt_num_expediente
            // 
            this.txt_num_expediente.Location = new System.Drawing.Point(9, 32);
            this.txt_num_expediente.Name = "txt_num_expediente";
            this.txt_num_expediente.Size = new System.Drawing.Size(100, 20);
            this.txt_num_expediente.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Numero de expediente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_medida_cautelar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_descripcion);
            this.groupBox2.Location = new System.Drawing.Point(4, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 285);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otros datos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Medida cautelar";
            // 
            // txt_medida_cautelar
            // 
            this.txt_medida_cautelar.Location = new System.Drawing.Point(11, 162);
            this.txt_medida_cautelar.Multiline = true;
            this.txt_medida_cautelar.Name = "txt_medida_cautelar";
            this.txt_medida_cautelar.Size = new System.Drawing.Size(576, 111);
            this.txt_medida_cautelar.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(9, 32);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(576, 100);
            this.txt_descripcion.TabIndex = 64;
            // 
            // tab_ProcedimientoTableAdapter
            // 
            this.tab_ProcedimientoTableAdapter.ClearBeforeFill = true;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(144, 31);
            this.txt_cedula.Mask = "0000000000";
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(100, 20);
            this.txt_cedula.TabIndex = 72;
            // 
            // txt_organo_director
            // 
            this.txt_organo_director.Location = new System.Drawing.Point(9, 141);
            this.txt_organo_director.Name = "txt_organo_director";
            this.txt_organo_director.Size = new System.Drawing.Size(100, 20);
            this.txt_organo_director.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "Organo director";
            // 
            // Mantenimiento_Casos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_acpetar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mantenimiento_Casos";
            this.Text = "Mantenimiento de casos";
            this.Load += new System.EventHandler(this.Mantenimiento_Casos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabProcedimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sICDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_acpetar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_estado;
        private System.Windows.Forms.ComboBox cbo_tipo_procedimiento;
        private System.Windows.Forms.ComboBox cbo_parte_procesal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_lugar_trabajo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_num_expediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_medida_cautelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.BindingSource sICDataSetBindingSource;
        private SICDataSet1 sICDataSet1;
        private System.Windows.Forms.BindingSource tabProcedimientoBindingSource;
        private SICDataSet1TableAdapters.Tab_ProcedimientoTableAdapter tab_ProcedimientoTableAdapter;
        private System.Windows.Forms.MaskedTextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_organo_director;
        private System.Windows.Forms.Label label9;
    }
}