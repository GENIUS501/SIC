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
    public partial class Mantemiento_Procedimientos : Form
    {
        public Mantemiento_Procedimientos()
        {
            InitializeComponent();
        }
        public string Accion { get; set; }
        public string Usuario { get; set; }
        public int Id_Procedimiento { get; set;}
        Gestor Negocios;
        Procedimiento Proc;
        private void Llenar()
        {

        }
        private void Mantemiento_Procedimientos_Load(object sender, EventArgs e)
        {
            if(Accion=="A")
            {
                this.txt_id_procedimiento.Visible = false;
                this.lbl_id_procedimiento.Visible = false;
            }
            if(Accion == "M" || Accion == "E" ||Accion=="C")
            {

            }
        }

        private void btn_acpetar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Accion=="A" || Accion=="M" || Accion=="E")
                {
                    if(this.txt_nombre.Text!="" && this.txt_descripcion.Text!="")
                    {
                        Negocios = new Gestor();
                        Proc = new Procedimiento();
                        Int32 FilasAfectadas = 0;
                        Proc.Nombre_Procedimiento = this.txt_nombre.Text;
                        Proc.Descripcion_Procedimiento = this.txt_descripcion.Text;
                        if (Accion == "A")
                        {
                            FilasAfectadas = Negocios.AgregarProcedimiento(Proc, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                MessageBox.Show("Procedimiento Agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("El procedimiento se ha agregado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    MessageBox.Show("Error al agregar el procedimiento!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        if(Accion=="M")
                        {
                            Proc.Id_Procedimiento = int.Parse(this.txt_id_procedimiento.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se a llenado uno o varios campos!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
