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
    public partial class Login : Form
    {
        Gestor Negocios;
       // Sesiones ses;
        Usuarios usu;
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                usu = new Usuarios();
                int Id_Session = 0;
                string pass = Helper.EncodePassword(string.Concat(this.Txt_Usuario.Text.ToString(), this.Txt_Contrasena.ToString()));
                usu = Negocios.Login(this.Txt_Usuario.Text, pass);
                if (usu.Cedula != 0)
                {
                  /*  ses = new Sesiones();
                    ses.Ingreso = DateTime.Now;
                    ses.Usuario = this.txt_Usuario.Text;
                    IPHostEntry host;
                    host = Dns.GetHostEntry(Dns.GetHostName());
                    foreach (IPAddress ip in host.AddressList)
                    {
                        if (ip.AddressFamily.ToString() == "InterNetwork")
                        {
                            ses.Dip = ip.ToString();
                        }
                    }
                    Id_Session = Negocios.Ingreso(ses);
                    if (Id_Session > 0)
                    {*/
                        this.Hide();
                        Menu form = new Menu();
                     /*   form.Id_Perfil = usu.ID_ROL;
                        form.Id_Session = Id_Session;
                        form.usuario = usu.USUARIO;*/
                        MessageBox.Show("Bienvenido: " + usu.Nombre_Usuario, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        form.Show();
                    }
                  /*  else
                    {
                        MessageBox.Show("Error al ingresar!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }*/
                else
                {
                    MessageBox.Show("Error usuario o contraseña invalido!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
