using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIC
{
    public partial class Mantenimiento_Funcionarios : Form
    {
        public Mantenimiento_Funcionarios()
        {
            InitializeComponent();
        }
        public string Accion { get; set; }
        public string Usuario { get; set; }
        public int Cedula { get; set; }
        Gestor Negocios;
        Funcionarios Func;
        private void Llenar_cbo_genero()
        {
            try
            {
                this.cbo_genero.DisplayMember = "Text";
                this.cbo_genero.ValueMember = "Value";

                var items = new[] {
                                    new { Text = "Masculino", Value = "M" },
                                    new { Text = "Femenino", Value = "F" },
                                    };
                this.cbo_genero.DataSource = items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }


        }
        private void Mantenimiento_Funcionarios_Load(object sender, EventArgs e)
        {
            try {
                Llenar_cbo_genero();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btn_acpetar_Click(object sender, EventArgs e)
        {
            try {
                if (Accion == "A" || Accion == "M" || Accion == "E")
                {
                        Negocios = new Gestor();
                        Func = new Funcionarios();
                       if (this.txt_cedula.Text.Length > 8 && this.txt_cedula.Text.Length < 11)
                        {
                            Func.Apellido1 = this.txt_apellido1.Text;
                            Func.Apellido2 = this.txt_apellido2.Text;
                            Func.Cedula = int.Parse(this.txt_cedula.Text);
                            Func.Nombre = this.txt_nombre.Text;
                            Func.Genero = this.cbo_genero.SelectedValue.ToString();
                            Int32 FilasAfectadas = 0;
                            if (this.txt_apellido1.Text != "" || this.txt_apellido2.Text != "" || this.txt_nombre.Text != "" || this.txt_cedula.Text != "")
                            {

                            }
                            else
                            {
                                MessageBox.Show("Error no ha llenado uno o varios campos!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    }
                        else
                        {
                            MessageBox.Show("Formato de cedula incorrecto!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                  }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
