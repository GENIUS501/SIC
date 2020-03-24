namespace SIC
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeCasosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePorExpedienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEstadoDelExpedienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteAsociadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeRolesYPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraDeIngresoYSalidaDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraDeMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.mantenimientoDeProcedimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeFuncionariosToolStripMenuItem,
            this.mantenimientoDeCasosToolStripMenuItem,
            this.mantenimientoDeProcedimientosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // mantenimientoDeFuncionariosToolStripMenuItem
            // 
            this.mantenimientoDeFuncionariosToolStripMenuItem.Name = "mantenimientoDeFuncionariosToolStripMenuItem";
            this.mantenimientoDeFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.mantenimientoDeFuncionariosToolStripMenuItem.Text = "Mantenimiento de Funcionarios";
            this.mantenimientoDeFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeFuncionariosToolStripMenuItem_Click);
            // 
            // mantenimientoDeCasosToolStripMenuItem
            // 
            this.mantenimientoDeCasosToolStripMenuItem.Name = "mantenimientoDeCasosToolStripMenuItem";
            this.mantenimientoDeCasosToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.mantenimientoDeCasosToolStripMenuItem.Text = "Mantenimiento de casos";
            this.mantenimientoDeCasosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeCasosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportePorExpedienteToolStripMenuItem,
            this.reporteDeEstadoDelExpedienteToolStripMenuItem,
            this.reporteAsociadoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportePorExpedienteToolStripMenuItem
            // 
            this.reportePorExpedienteToolStripMenuItem.Name = "reportePorExpedienteToolStripMenuItem";
            this.reportePorExpedienteToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.reportePorExpedienteToolStripMenuItem.Text = "Reporte por expediente";
            this.reportePorExpedienteToolStripMenuItem.Click += new System.EventHandler(this.reportePorExpedienteToolStripMenuItem_Click);
            // 
            // reporteDeEstadoDelExpedienteToolStripMenuItem
            // 
            this.reporteDeEstadoDelExpedienteToolStripMenuItem.Name = "reporteDeEstadoDelExpedienteToolStripMenuItem";
            this.reporteDeEstadoDelExpedienteToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.reporteDeEstadoDelExpedienteToolStripMenuItem.Text = "Reporte de estado del expediente";
            this.reporteDeEstadoDelExpedienteToolStripMenuItem.Click += new System.EventHandler(this.reporteDeEstadoDelExpedienteToolStripMenuItem_Click);
            // 
            // reporteAsociadoToolStripMenuItem
            // 
            this.reporteAsociadoToolStripMenuItem.Name = "reporteAsociadoToolStripMenuItem";
            this.reporteAsociadoToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.reporteAsociadoToolStripMenuItem.Text = "Reporte asociado al funcionario";
            this.reporteAsociadoToolStripMenuItem.Click += new System.EventHandler(this.reporteAsociadoToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeRolesYPermisosToolStripMenuItem,
            this.mantenimientoDeUsuariosToolStripMenuItem,
            this.bitacoraDeIngresoYSalidaDelSistemaToolStripMenuItem,
            this.bitacoraDeMovimientosToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // mantenimientoDeRolesYPermisosToolStripMenuItem
            // 
            this.mantenimientoDeRolesYPermisosToolStripMenuItem.Name = "mantenimientoDeRolesYPermisosToolStripMenuItem";
            this.mantenimientoDeRolesYPermisosToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.mantenimientoDeRolesYPermisosToolStripMenuItem.Text = "Mantenimiento de roles y permisos";
            this.mantenimientoDeRolesYPermisosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeRolesYPermisosToolStripMenuItem_Click);
            // 
            // mantenimientoDeUsuariosToolStripMenuItem
            // 
            this.mantenimientoDeUsuariosToolStripMenuItem.Name = "mantenimientoDeUsuariosToolStripMenuItem";
            this.mantenimientoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.mantenimientoDeUsuariosToolStripMenuItem.Text = "Mantenimiento de usuarios";
            this.mantenimientoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeUsuariosToolStripMenuItem_Click);
            // 
            // bitacoraDeIngresoYSalidaDelSistemaToolStripMenuItem
            // 
            this.bitacoraDeIngresoYSalidaDelSistemaToolStripMenuItem.Name = "bitacoraDeIngresoYSalidaDelSistemaToolStripMenuItem";
            this.bitacoraDeIngresoYSalidaDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.bitacoraDeIngresoYSalidaDelSistemaToolStripMenuItem.Text = "Bitacora de ingreso y salida";
            this.bitacoraDeIngresoYSalidaDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.bitacoraDeIngresoYSalidaDelSistemaToolStripMenuItem_Click);
            // 
            // bitacoraDeMovimientosToolStripMenuItem
            // 
            this.bitacoraDeMovimientosToolStripMenuItem.Name = "bitacoraDeMovimientosToolStripMenuItem";
            this.bitacoraDeMovimientosToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.bitacoraDeMovimientosToolStripMenuItem.Text = "Bitacora de Movimientos";
            this.bitacoraDeMovimientosToolStripMenuItem.Click += new System.EventHandler(this.bitacoraDeMovimientosToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_Usuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 315);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(686, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(0, 17);
            // 
            // mantenimientoDeProcedimientosToolStripMenuItem
            // 
            this.mantenimientoDeProcedimientosToolStripMenuItem.Name = "mantenimientoDeProcedimientosToolStripMenuItem";
            this.mantenimientoDeProcedimientosToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.mantenimientoDeProcedimientosToolStripMenuItem.Text = "Mantenimiento de procedimientos";
            this.mantenimientoDeProcedimientosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeProcedimientosToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 337);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeFuncionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeCasosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeRolesYPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraDeIngresoYSalidaDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraDeMovimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePorExpedienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEstadoDelExpedienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteAsociadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Usuario;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeProcedimientosToolStripMenuItem;
    }
}