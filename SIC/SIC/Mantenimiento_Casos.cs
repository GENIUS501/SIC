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
    public partial class Mantenimiento_Casos : Form
    {
        public Mantenimiento_Casos()
        {
            InitializeComponent();
        }

        public string Accion { get; set; }
        public string Usuario { get; set; }
        public string Num_Expediente { get; set; }
        Gestor Negocios;
        Expedientes Exp;
        Funcionarios Func;

        #region Llenar combos
        private void Llenar_cbo_parte_procesal()
        {
            try
            {
                this.cbo_parte_procesal.DisplayMember = "Text";
                this.cbo_parte_procesal.ValueMember = "Value";

                var items = new[] {
                                    new { Text = "Investigado", Value = "Investigado" },
                                    new { Text = "Ofendido", Value = "Ofendido" },
                                    new { Text = "Empresa", Value = "Empresa" },
                                    };
                this.cbo_parte_procesal.DataSource = items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }


        }

        private void Llenar_cbo_estado()
        {
            try
            {
                this.cbo_estado.DisplayMember = "Text";
                this.cbo_estado.ValueMember = "Value";

                var items = new[] {
                                    new { Text = "Activo", Value = "Activo" },
                                    new { Text = "Concluido", Value = "Concluido" },
                                    };
                this.cbo_estado.DataSource = items;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }


        }
        #endregion

        #region Llenar Campos
        private void Llenar_Campos()
        {
            Negocios = new Gestor();
            Exp = new Expedientes();
            Exp = Negocios.Mostrar_Expediente_Unico(Num_Expediente);
            this.txt_cedula.Text = Exp.Cedula.ToString();
            this.txt_descripcion.Text = Exp.Descripcion;
            this.txt_lugar_trabajo.Text = Exp.Lugar_Trabajo;
            this.txt_medida_cautelar.Text = Exp.Medida_Cautelar;
            this.txt_num_expediente.Text = Exp.Num_Expediente;
            this.txt_organo_director.Text = Exp.Organo_Director;
            this.cbo_estado.SelectedValue = Exp.Estado;
            this.cbo_parte_procesal.SelectedValue = Exp.Parte_Procesal;
            this.cbo_tipo_procedimiento.SelectedValue = Exp.Id_Tipo_Procedimiento;
        }
        #endregion

        #region Cargador
        private void Mantenimiento_Casos_Load(object sender, EventArgs e)
        {
            try
            {
                Llenar_cbo_parte_procesal();
                Llenar_cbo_estado();
                // TODO: esta línea de código carga datos en la tabla 'sICDataSet1.Tab_Procedimiento' Puede moverla o quitarla según sea necesario.
                this.tab_ProcedimientoTableAdapter.Fill(this.sICDataSet1.Tab_Procedimiento);
                this.cbo_estado.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cbo_parte_procesal.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cbo_tipo_procedimiento.DropDownStyle = ComboBoxStyle.DropDownList;
                if(Accion == "M"|| Accion == "E" || Accion == "C")
                {
                    Llenar_Campos();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }finally
            {
                this.Close();
            }
        }

        private void btn_acpetar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Accion=="A"|| Accion == "M" || Accion == "E")
                {
                    //Validacion de campos llenos
                    if(this.txt_cedula.Text!=""&&this.txt_descripcion.Text!=""&&this.txt_lugar_trabajo.Text!=""&&this.txt_medida_cautelar.Text!=""&&this.txt_num_expediente.Text!=""&&this.txt_cedula.Text.Length>8&&this.txt_cedula.Text.Length<11)
                    {
                        Negocios = new Gestor();
                        Func = new Funcionarios();
                        Func = Negocios.Mostrar_Funcionario_Unico(int.Parse(this.txt_cedula.Text));
                        if (Func.Cedula > 0)
                        {
                            Exp = new Expedientes(int.Parse(this.txt_cedula.Text), Usuario, this.txt_num_expediente.Text, this.cbo_parte_procesal.SelectedValue.ToString(), this.txt_lugar_trabajo.Text, this.txt_descripcion.Text, this.txt_medida_cautelar.Text, int.Parse(this.cbo_tipo_procedimiento.SelectedValue.ToString()), this.txt_organo_director.Text,cbo_estado.SelectedValue.ToString());
                            Int32 FilasAfectadas = 0;
                            if (Accion == "A")
                            {
                                FilasAfectadas = Negocios.AgregarExpediente(Exp, Usuario);
                                if (FilasAfectadas > 0)
                                {
                                    MessageBox.Show("Caso agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    if (FilasAfectadas == -1)
                                    {
                                        MessageBox.Show("El caso se ha agregado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al agregar el caso!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            if(Accion=="M")
                            {
                                FilasAfectadas = Negocios.Modificar_Expendiente(Exp, Usuario);
                                if (FilasAfectadas > 0)
                                {
                                    MessageBox.Show("Caso modificado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    if (FilasAfectadas == -1)
                                    {
                                        MessageBox.Show("El caso se ha modicado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al modificar el caso!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            if(Accion=="E")
                            {
                                DialogResult dr = MessageBox.Show("Realmente desea eliminar el Caso?", "Eliminar el Funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (dr == DialogResult.Yes)
                                {
                                    FilasAfectadas = Negocios.EliminarExpediente(this.txt_num_expediente.Text, Usuario);
                                    if (FilasAfectadas > 0)
                                    {
                                        MessageBox.Show("Caso Eliminado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {
                                        if (FilasAfectadas == -1)
                                        {
                                            MessageBox.Show("El caso se ha eliminado exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al eliminar el caso!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else
                                {
                                    this.Close();
                                }
                        }
                        else
                        {
                            MessageBox.Show("No existe funcionario asosiado al numero de cedula introducido!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        if (this.txt_cedula.Text != "" && this.txt_descripcion.Text != "" && this.txt_lugar_trabajo.Text != "" && this.txt_medida_cautelar.Text != "" && this.txt_num_expediente.Text != "")
                        {
                            MessageBox.Show("Uno o varios Campos no han sido llenados!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if(this.txt_cedula.Text.Length < 9 && this.txt_cedula.Text.Length >10)
                        {
                            MessageBox.Show("Formato de cedula incorrecto!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if(Accion == "C")
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
