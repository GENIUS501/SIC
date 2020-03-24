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
        private void Mantemiento_Procedimientos_Load(object sender, EventArgs e)
        {

        }
    }
}
