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
    public partial class Lista_Usuario : Form
    {
        Gestor Negocios;
        Permisos perm;
        int valor_celda = -1;
        public string usuario { get; set; }
        public int Id_Perfil { get; set; }
        public Lista_Usuario()
        {
            InitializeComponent();
        }

        private void Lista_Usuario_Load(object sender, EventArgs e)
        {
            perm = new Permisos();
            Negocios = new Gestor();
            perm = Negocios.Mostrar_Paquete_Unico(Id_Perfil, 2);
            this.btn_agregar.Enabled = false;
            this.btn_consultar.Enabled = false;
            this.btn_editar.Enabled = false;
            this.btn_eliminar.Enabled = false;
            if(perm.Agregar=="S")
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
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Mantenimiento_Usuarios frm = new Mantenimiento_Usuarios();
                frm.Accion = "A";
                frm.Usuario = usuario;
                frm.Text = "Mantenimiento de usuarios: Agregar usuario.";
                frm.ShowDialog();
                Lista_Usuario_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
