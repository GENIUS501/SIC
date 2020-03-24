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
        private void Llenar()
        {
            Negocios = new Gestor();
            Func = new Funcionarios();
            Func = Negocios.Mostrar_Funcionario_Unico(Cedula);
            this.txt_apellido1.Text = Func.Apellido1;
            this.txt_apellido2.Text = Func.Apellido2;
            this.txt_cedula.Text = Func.Cedula.ToString();
            this.txt_nombre.Text = Func.Nombre.ToString();
            this.cbo_genero.SelectedValue = Func.Genero;
        }
        private void Mantenimiento_Funcionarios_Load(object sender, EventArgs e)
        {
            try {
                Llenar_cbo_genero();
                this.cbo_genero.DropDownStyle = ComboBoxStyle.DropDownList;
                if(Accion=="M"||Accion == "E" ||Accion == "C" )
                {
                    Llenar();
                    this.txt_cedula.Enabled = false;
                }
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
                                if(Accion=="A")
                                {
                                    FilasAfectadas = Negocios.AgregarFuncionario(Func,Usuario);
                                    if (FilasAfectadas > 0)
                                    {
                                        MessageBox.Show("Funcionario Agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {
                                        if (FilasAfectadas == -1)
                                        {
                                            MessageBox.Show("El Funcionario se ha agregado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al agregar el Funcionario!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                            }
                             if(Accion=="M")
                            {
                                FilasAfectadas = Negocios.AgregarFuncionario(Func, Usuario);
                                if (FilasAfectadas > 0)
                                {
                                    MessageBox.Show("Funcionario Agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    if (FilasAfectadas == -1)
                                    {
                                        MessageBox.Show("El Funcionario se ha agregado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al agregar el Funcionario!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }catch(Exception ex)
            { 
              MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
