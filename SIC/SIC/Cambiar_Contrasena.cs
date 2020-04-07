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
    public partial class Cambiar_Contrasena : Form
    {
        Gestor Negocios;
        Usuarios usu;
        public string Usuario { get; set; }
        public Cambiar_Contrasena()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_acpetar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                usu = new Usuarios();
                string pass = Helper.EncodePassword(string.Concat(this.txt_usuario.Text.ToString(), this.txt_contrasena_antigua.ToString()));
                usu = Negocios.Login(this.txt_usuario.Text, pass);
                if (usu.Cedula != 0)
                {
                    if (this.txt_contrasena.Text.Length > 7)
                    {
                        if (this.txt_contrasena.Text == this.txt_confirmar_contrasena.Text)
                        {
                            usu.Contrasena = Helper.EncodePassword(string.Concat(this.txt_usuario.Text.ToString(), this.txt_contrasena.ToString()));
                            Int32 FilasAfectadas = 0;
                            FilasAfectadas = Negocios.Modificar_Usuario_pass(usu, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Contraseña sustituida exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("La Contraseña ha sustituida exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al sustituir la contraseña !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Las Contraseñas no coinciden!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error contraseña muy corta!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error contraseña incorrecta!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cambiar_Contrasena_Load(object sender, EventArgs e)
        {
            try
            {
                this.txt_usuario.Text = Usuario;
                this.txt_usuario.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
