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
    public partial class Lista_Casos : Form
    {
        Gestor Negocios;
        Permisos perm;
        string valor_celda = "";
        public string usuario { get; set; }
        public int Id_Perfil { get; set; }

        public Lista_Casos()
        {
            InitializeComponent();
        }

        #region Cargador
        private void Lista_Casos_Load(object sender, EventArgs e)
        {
            try
            {
                this.dat_casos.ReadOnly = true;
                valor_celda = "";
                perm = new Permisos();
                Negocios = new Gestor();
                this.btn_agregar.Enabled = false;
                this.btn_consultar.Enabled = false;
                this.btn_editar.Enabled = false;
                this.btn_eliminar.Enabled = false;
                perm = Negocios.Mostrar_Permisos_Unico(Id_Perfil, 4);
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
                this.dat_casos.DataSource = Negocios.llenar_expedientes();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Filtros de busqueda
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                this.dat_casos.DataSource = Negocios.llenar_expedientes(int.Parse(this.txt_buscar.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_num_expediente_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                this.dat_casos.DataSource = Negocios.llenar_expedientes(this.txt_num_expediente.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Botones
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Mantenimiento_Casos frm = new Mantenimiento_Casos();
                frm.Accion = "A";
                frm.Usuario = usuario;
                frm.Text = "Mantenimiento de Casos: Agregar caso.";
                frm.ShowDialog();
                Lista_Casos_Load(null, null);
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
                if (valor_celda != "")
                { 
                    Mantenimiento_Casos frm = new Mantenimiento_Casos();
                    frm.Accion = "M";
                    frm.Usuario = usuario;
                    frm.Num_Expediente = valor_celda;
                    frm.Text = "Mantenimiento de Casos: Modificar Caso.";
                    frm.ShowDialog();
                    Lista_Casos_Load(null, null);
                }
                else
                {
                     MessageBox.Show("Error debe elegir un Caso!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (valor_celda != "")
            {
                Mantenimiento_Casos frm = new Mantenimiento_Casos();
                frm.Accion = "E";
                frm.Usuario = usuario;
                frm.Num_Expediente = valor_celda;
                frm.Text = "Mantenimiento de Casos: Eliminar Caso.";
                frm.ShowDialog();
                Lista_Casos_Load(null, null);
            }
            else
            {
                MessageBox.Show("Error debe elegir un Caso!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (valor_celda != "")
            {
                Mantenimiento_Casos frm = new Mantenimiento_Casos();
                frm.Accion = "C";
                frm.Usuario = usuario;
                frm.Num_Expediente = valor_celda;
                frm.Text = "Mantenimiento de Casos: Consultar Caso.";
                frm.ShowDialog();
                Lista_Casos_Load(null, null);
            }
            else
            {
                MessageBox.Show("Error debe elegir un Caso!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void dat_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dat_casos.Rows[e.RowIndex].Cells[1].Value.ToString() == "")
                {
                    Lista_Casos_Load(null, null);
                }
                else
                {
                    valor_celda = this.dat_casos.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
