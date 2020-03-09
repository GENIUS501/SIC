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
    public partial class Mantenimiento_Roles : Form
    {
        public string Usuario { get; set; }
        public string Accion { get; set; }

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
            if (Accion == "A")
            {
                Permisos();
            }
        }
        private void Permisos()
        {
            if (this.chb_Roles.Checked==true)
            {
                MessageBox.Show("Puto");
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
    }
}
