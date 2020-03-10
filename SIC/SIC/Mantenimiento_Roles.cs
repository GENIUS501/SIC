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
                this.clb_Casos.Enabled = false;
                this.clb_funcionarios.Enabled = false;
                this.clb_usuarios.Enabled = false;
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
                Negocios = new Gestor();
                Perf = new Perfiles();
                
                if (Accion == "A")
                {
                    Int32 FilasAfectadas = 0;
                    Perf.Id_Perfil = Convert.ToInt32(this.txt_id_rol.Text);
                    Perf.Nombre_Perfil = this.txt_nombre.Text;
                    FilasAfectadas = Negocios.AgregarRol(Perf,Usuario);
                    if(FilasAfectadas>0)
                    {
                        Permisos(Convert.ToInt32(this.txt_id_rol.Text));
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el rol!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Permisos(int id_perfil)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                Negocios = new Gestor();
                Permi = new Permisos();
                Permi.Id_Perfil = id_perfil;
                ///////////////////Roles////////1/////////////////////////////////////////////////////////////////////
                if (this.chb_Roles.Checked == true)
                {
                    FilasAfectadas = 0;
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
                    FilasAfectadas = Negocios.AgregarPermisos(Permi);
                    if(FilasAfectadas>0)
                    {

                    }else
                    {
                        MessageBox.Show("No se pudo agregar el permiso sobre el modulo Roles y permisos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                /////////Usuarios//////2///////////////////////////////////////////////////////////////////////
                Permi = new Permisos();
                Permi.Id_Perfil = id_perfil;
                if (this.chb_usuarios.Checked == true)
                {
                    FilasAfectadas = 0;
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
                    FilasAfectadas = Negocios.AgregarPermisos(Permi);
                    if (FilasAfectadas > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el permiso sobre el modulo Usuarios ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                /////////Funcionarios//////3///////////////////////////////////////////////////////////////////////
                Permi = new Permisos();
                if (this.chb_funcionarios.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Modulo = 3;
                    Permi.Id_Perfil = id_perfil;
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
                    FilasAfectadas = Negocios.AgregarPermisos(Permi);
                    if (FilasAfectadas > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el permiso sobre el modulo funcionarios ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                /////////Casos//////4///////////////////////////////////////////////////////////////////////
                Permi = new Permisos();
                if (this.chb_Casos.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Id_Perfil = id_perfil;
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
                    FilasAfectadas = Negocios.AgregarPermisos(Permi);
                    if (FilasAfectadas > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el permiso sobre el modulo casos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                /////////Sesiones/////5////////////////////////////////////////////////////////////////////////////////////////
                Permi = new Permisos();
                if (this.chb_sesiones.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Modulo = 5;
                    Permi.Id_Perfil = id_perfil;
                    Permi.Agregar = "N";
                    Permi.Consultar = "N";
                    Permi.Eliminar = "N";
                    Permi.Modificar = "N";
                    FilasAfectadas = Negocios.AgregarPermisos(Permi);
                    if (FilasAfectadas > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el permiso sobre el modulo bitacora sesiones ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ////////Movimientos////6//////////////////////////////////////////////////////////////////////////////////////
                Permi = new Permisos();
                if (this.chb_movimientos.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Modulo = 6;
                    Permi.Id_Perfil = id_perfil;
                    Permi.Agregar = "N";
                    Permi.Consultar = "N";
                    Permi.Eliminar = "N";
                    Permi.Modificar = "N";
                    FilasAfectadas = Negocios.AgregarPermisos(Permi);
                    if (FilasAfectadas > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el permiso sobre el modulo bitacora movimientos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_Roles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_Roles.Checked == true)
                {
                    this.clb_Roles.Enabled = true;
                }
                else if (this.chb_Roles.Checked == false)
                {
                    this.clb_Roles.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void chb_usuarios_CheckedChanged(object sender, EventArgs e)
        {
            try {
                    if (this.chb_usuarios.Checked == true)
                    {
                        this.clb_usuarios.Enabled = true;
                    }
                    else if (this.chb_Roles.Checked == false)
                    {
                        this.clb_usuarios.Enabled = false;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_funcionarios_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_funcionarios.Checked == true)
                {
                    this.clb_funcionarios.Enabled = true;
                }
                else if (this.chb_funcionarios.Checked == false)
                {
                    this.clb_funcionarios.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_Casos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_Casos.Checked == true)
                {
                    this.clb_Casos.Enabled = true;
                }
                else if (this.chb_Casos.Checked == false)
                {
                    this.clb_Casos.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
