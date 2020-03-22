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
    public partial class Mantenimiento_Usuarios : Form
    {
        public string Accion { get; set; }
        public string Usuario { get; set; }
        public int Cedula { get; set; }
        private string contrasena = "";
        Gestor Negocios;
        Usuarios Usua;
        public Mantenimiento_Usuarios()
        {
            InitializeComponent();
        }
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
        private void llenar_usuario()
        {
            Negocios = new Gestor();
            Usua = new Usuarios();
            Usua = Negocios.Mostrar_Usuario_Unico(Cedula);
            this.txt_confirmar_contrasena.Visible = false;
            this.lbl_contrasena.Visible = false;
            this.txt_apellido1.Text = Usua.Apellido1;
            this.txt_apellido2.Text = Usua.Apellido2;
            this.txt_cedula.Text = Usua.Cedula.ToString();
            this.txt_contrasena.Text = Usua.Contrasena;
            contrasena = Usua.Contrasena;
            this.txt_nombre.Text = Usua.Nombre;
            this.txt_usuario.Text = Usua.Nombre_Usuario;
            this.cbo_genero.SelectedValue = Usua.Genero;
            this.cbo_rol.SelectedValue = Usua.Id_Perfil;
        }
        private void Mantenimiento_Usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'sICDataSet.Tab_Perfiles' Puede moverla o quitarla según sea necesario.
                this.tab_PerfilesTableAdapter.Fill(this.sICDataSet.Tab_Perfiles);
                this.cbo_genero.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cbo_rol.DropDownStyle = ComboBoxStyle.DropDownList;
                Llenar_cbo_genero();
                if(Accion=="M"||Accion=="E" ||Accion=="C")
                {
                    llenar_usuario();
                    this.txt_cedula.Enabled = false;
                    if (Accion == "E" || Accion == "C")
                    {
                        this.txt_apellido1.Enabled = false;
                        this.txt_apellido2.Enabled = false;
                        this.txt_contrasena.Enabled = false;
                        this.txt_nombre.Enabled = false;
                        this.txt_usuario.Enabled = false;
                        this.cbo_genero.Enabled = false;
                        this.cbo_rol.Enabled = false;
                    }
                }
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
                if (Accion == "A" || Accion == "M")
                {
                    Negocios = new Gestor();
                    Usua = new Usuarios();
                    if (this.txt_cedula.Text.Length > 8 && this.txt_cedula.Text.Length < 11)
                    {
                        Usua.Apellido1 = this.txt_apellido1.Text;
                        Usua.Apellido2 = this.txt_apellido2.Text;
                        Usua.Cedula = int.Parse(this.txt_cedula.Text);
                        Usua.Nombre = this.txt_nombre.Text;
                        Usua.Nombre_Usuario = this.txt_usuario.Text;
                        Usua.Id_Perfil = int.Parse(this.cbo_rol.SelectedValue.ToString());
                        Usua.Genero = this.cbo_genero.SelectedValue.ToString();
                        if(Accion=="A")
                        {
                            Int32 FilasAfectadas = 0;
                            if(this.txt_contrasena.Text==this.txt_confirmar_contrasena.Text)
                            {
                                Usua.Contrasena = Helper.EncodePassword(string.Concat(this.txt_usuario.Text.ToString(), this.txt_contrasena.ToString()));
                                FilasAfectadas = Negocios.AgregarUsuarios(Usua,Usuario);
                                if(FilasAfectadas>0)
                                {
                                    MessageBox.Show("Usuario Agregado exitosamente!!!","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    this.Close();
                                }else
                                {
                                    MessageBox.Show("Error al agregar el usuario!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }else
                            {
                                MessageBox.Show("Las contrasañas no coinciden!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
