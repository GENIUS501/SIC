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
        int valor_celda = -1;
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Filtros de busqueda
        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_num_expediente_Click(object sender, EventArgs e)
        {

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
                frm.Text = "Mantenimiento de Procedimientos: Agregar Procedimiento.";
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

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void dat_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
