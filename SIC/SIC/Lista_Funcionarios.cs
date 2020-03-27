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
    public partial class Lista_Funcionarios : Form
    {
        Gestor Negocios;
        Permisos perm;
        int valor_celda = -1;
        public string usuario { get; set; }
        public int Id_Perfil { get; set; }
        public Lista_Funcionarios()
        {
            InitializeComponent();
        }

        private void Lista_Funcionarios_Load(object sender, EventArgs e)
        {
            try
            {
                this.dat_funcionarios.ReadOnly = true;
                valor_celda = -1;
                perm = new Permisos();
                Negocios = new Gestor();
                this.btn_agregar.Enabled = false;
                this.btn_consultar.Enabled = false;
                this.btn_editar.Enabled = false;
                this.btn_eliminar.Enabled = false;
                perm = Negocios.Mostrar_Permisos_Unico(Id_Perfil, 3);
                if (perm.Agregar == "S")
                {
                    this.btn_agregar.Enabled = true;
                }
                if (perm.Modificar == "S")
                {
                    this.btn_editar.Enabled = true;
                }
                if (perm.Eliminar == "S")
                {
                    this.btn_eliminar.Enabled = true;
                }
                if (perm.Consultar == "S")
                {
                    this.btn_consultar.Enabled = true;
                }
                this.dat_funcionarios.DataSource = Negocios.llenar_Funcionarios();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Mantenimiento_Funcionarios frm = new Mantenimiento_Funcionarios();
                frm.Accion = "A";
                frm.Usuario = usuario;
                frm.Text = "Mantenimiento de Funcionarios: Agregar Funcionario.";
                frm.ShowDialog();
                Lista_Funcionarios_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try {
                Negocios = new Gestor();
                this.dat_funcionarios.DataSource = Negocios.llenar_Funcionarios(int.Parse(this.txt_buscar.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_nombre_Click(object sender, EventArgs e)
        {
            Negocios = new Gestor();
            this.dat_funcionarios.DataSource = Negocios.llenar_Funcionarios(this.txt_nombre.Text,this.txt_apellido.Text);
        }

        private void dat_funcionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dat_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {
                    Lista_Funcionarios_Load(null, null);
                }
                else
                {
                    valor_celda = Convert.ToInt32(this.dat_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valor_celda != -1)
                {
                    Mantenimiento_Funcionarios frm = new Mantenimiento_Funcionarios();
                    frm.Accion = "M";
                    frm.Usuario = usuario;
                    frm.Cedula = valor_celda;
                    frm.Text = "Mantenimiento de Funcionarios: Modificar Funcionario.";
                    frm.ShowDialog();
                    Lista_Funcionarios_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Error debe elegir un funcionario!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valor_celda != -1)
                {
                    Mantenimiento_Funcionarios frm = new Mantenimiento_Funcionarios();
                    frm.Accion = "E";
                    frm.Usuario = usuario;
                    frm.Cedula = valor_celda;
                    frm.Text = "Mantenimiento de Funcionarios: Eliminar Funcionario.";
                    frm.ShowDialog();
                    Lista_Funcionarios_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Error debe elegir un funcionario!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valor_celda != -1)
                {
                    Mantenimiento_Funcionarios frm = new Mantenimiento_Funcionarios();
                    frm.Accion = "C";
                    frm.Usuario = usuario;
                    frm.Cedula = valor_celda;
                    frm.Text = "Mantenimiento de Funcionarios: Consultar Funcionario.";
                    frm.ShowDialog();
                    Lista_Funcionarios_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Error debe elegir un funcionario!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
