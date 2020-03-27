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
    public partial class Lista_Procedimiento : Form
    {
        Gestor Negocios;
        Permisos perm;
        int valor_celda = -1;
        public string usuario { get; set; }
        public int Id_Perfil { get; set; }

        public Lista_Procedimiento()
        {
            InitializeComponent();
        }

        private void Lista_Procedimiento_Load(object sender, EventArgs e)
        {
            try
            {
                this.dat_procedimientos.ReadOnly = true;
                valor_celda = -1;
                perm = new Permisos();
                Negocios = new Gestor();
                this.btn_agregar.Enabled = false;
                this.btn_consultar.Enabled = false;
                this.btn_editar.Enabled = false;
                this.btn_eliminar.Enabled = false;
                perm = Negocios.Mostrar_Permisos_Unico(Id_Perfil, 7);
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
                this.dat_procedimientos.DataSource = Negocios.llenar_Procedimientos();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Mantemiento_Procedimientos frm = new Mantemiento_Procedimientos();
                frm.Accion = "A";
                frm.Usuario = usuario;
                frm.Text = "Mantenimiento de Procedimientos: Agregar Procedimiento.";
                frm.ShowDialog();
                Lista_Procedimiento_Load(null, null);
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
                    Mantemiento_Procedimientos frm = new Mantemiento_Procedimientos();
                    frm.Accion = "M";
                    frm.Usuario = usuario;
                    frm.Id_Procedimiento = valor_celda;
                    frm.Text = "Mantenimiento de Procedimientos: Modificar Procedimiento.";
                    frm.ShowDialog();
                    Lista_Procedimiento_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Error debe elegir un Procedimiento!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Mantemiento_Procedimientos frm = new Mantemiento_Procedimientos();
                    frm.Accion = "E";
                    frm.Usuario = usuario;
                    frm.Id_Procedimiento = valor_celda;
                    frm.Text = "Mantenimiento de Procedimientos: Eliminar Procedimiento.";
                    frm.ShowDialog();
                    Lista_Procedimiento_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Error debe elegir un Procedimiento!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Mantemiento_Procedimientos frm = new Mantemiento_Procedimientos();
                    frm.Accion = "C";
                    frm.Usuario = usuario;
                    frm.Id_Procedimiento = valor_celda;
                    frm.Text = "Mantenimiento de Procedimientos: Consultar Procedimiento.";
                    frm.ShowDialog();
                    Lista_Procedimiento_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Error debe elegir un Procedimiento!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dat_procedimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dat_procedimientos.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {
                    Lista_Procedimiento_Load(null, null);
                }
                else
                {
                    valor_celda = Convert.ToInt32(this.dat_procedimientos.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
