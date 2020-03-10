using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace SIC
{
    public partial class Mantenimiento_Roles : Form
    {
        public string Usuario { get; set; }
        public string Accion { get; set; }
        Gestor Negocios;
        Perfiles Perf;
        Permisos Permi;
        public Mantenimiento_Roles()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Roles_Load(object sender, EventArgs e)
        {
            try
            {
                this.clb_Roles.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btn_acpetar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion == "A")
                {
                    Permisos(Convert.ToInt32(this.txt_id_rol.Text));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Permisos(int id_perfil)
        {
            Permi = new Permisos();
            Permi.Id_Perfil = id_perfil;
            ///////////////////Roles////////1/////////////////////////////////////////////////////////////////////
            if (this.chb_Roles.Checked==true)
            {
                Permi.Modulo = 1;
                foreach (string value in clb_Roles.CheckedItems)
                {
                    switch (value)
                    {
                        case "Agrergar":
                            Permi.Agregar = "S";
                            break;
                        case "Actualizar":
                            Permi.Modificar = "S";
                            break;
                        case "Borrar":
                            Permi.Eliminar = "S";
                            break;
                        case "Consultar":
                            Permi.Consultar = "S";
                            break;
                    }
                }
                MessageBox.Show("Id Perfil: " + Permi.Id_Perfil + " Modulo: " + Permi.Modulo + " Agregar: " + Permi.Agregar + " Actualizar: " + Permi.Modificar + " Consultar: " + Permi.Consultar + " Eliminar: " + Permi.Eliminar);
            }
            /////////Usuarios//////2///////////////////////////////////////////////////////////////////////
            Permi = new Permisos();
            if (this.chb_usuarios.Checked == true)
            {
                Permi.Modulo = 2;
                foreach (string value in clb_usuarios.CheckedItems)
                {
                    switch (value)
                    {
                        case "Agrergar":
                            Permi.Agregar = "S";
                            break;
                        case "Actualizar":
                            Permi.Modificar = "S";
                            break;
                        case "Borrar":
                            Permi.Eliminar = "S";
                            break;
                        case "Consultar":
                            Permi.Consultar = "S";
                            break;
                    }
                }
                MessageBox.Show("Id Perfil: " + Permi.Id_Perfil + " Modulo: " + Permi.Modulo + " Agregar: " + Permi.Agregar + " Actualizar: " + Permi.Modificar + " Consultar: " + Permi.Consultar + " Eliminar: " + Permi.Eliminar);
            }
            /////////Funcionarios//////3///////////////////////////////////////////////////////////////////////
            Permi = new Permisos();
            if (this.chb_funcionarios.Checked == true)
            {
                Permi.Modulo = 3;
                foreach (string value in clb_funcionarios.CheckedItems)
                {
                    switch (value)
                    {
                        case "Agrergar":
                            Permi.Agregar = "S";
                            break;
                        case "Actualizar":
                            Permi.Modificar = "S";
                            break;
                        case "Borrar":
                            Permi.Eliminar = "S";
                            break;
                        case "Consultar":
                            Permi.Consultar = "S";
                            break;
                    }
                }
                MessageBox.Show("Id Perfil: " + Permi.Id_Perfil + " Modulo: " + Permi.Modulo + " Agregar: " + Permi.Agregar + " Actualizar: " + Permi.Modificar + " Consultar: " + Permi.Consultar + " Eliminar: " + Permi.Eliminar);
            }
            /////////Casos//////4///////////////////////////////////////////////////////////////////////
            Permi = new Permisos();
            if (this.chb_Casos.Checked == true)
            {
                Permi.Modulo = 4;
                foreach (string value in clb_Casos.CheckedItems)
                {
                    switch (value)
                    {
                        case "Agrergar":
                            Permi.Agregar = "S";
                            break;
                        case "Actualizar":
                            Permi.Modificar = "S";
                            break;
                        case "Borrar":
                            Permi.Eliminar = "S";
                            break;
                        case "Consultar":
                            Permi.Consultar = "S";
                            break;
                    }
                }
                MessageBox.Show("Id Perfil: " + Permi.Id_Perfil + " Modulo: " + Permi.Modulo + " Agregar: " + Permi.Agregar + " Actualizar: " + Permi.Modificar + " Consultar: " + Permi.Consultar + " Eliminar: " + Permi.Eliminar);
            }
            /////////Sesiones/////5////////////////////////////////////////////////////////////////////////////////////////
            Permi = new Permisos();
            if (this.chb_sesiones.Checked == true)
            {
                Permi.Modulo = 5;
                Permi.Agregar = "N";
                Permi.Consultar = "N";
                Permi.Eliminar = "N";
                Permi.Modificar = "N";
            }
            ////////Movimientos////6//////////////////////////////////////////////////////////////////////////////////////
            Permi = new Permisos();
            if (this.chb_sesiones.Checked == true)
            {
                Permi.Modulo = 6;
                Permi.Agregar = "N";
                Permi.Consultar = "N";
                Permi.Eliminar = "N";
                Permi.Modificar = "N";
            }

        }

        private void chb_Roles_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_Roles.Checked == true)
            {
                this.clb_Roles.Enabled = true;
            }
            else if(this.chb_Roles.Checked == false)
            {
                this.clb_Roles.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                this.Close();
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
