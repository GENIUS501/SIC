namespace SIC
{
    partial class Visor_Bitacora_Movimientos_Fechas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SICDataSet1 = new SIC.SICDataSet1();
            this.Tab_Bitacora_MovimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tab_Bitacora_MovimientosTableAdapter = new SIC.SICDataSet1TableAdapters.Tab_Bitacora_MovimientosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SICDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Bitacora_MovimientosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tab_Bitacora_MovimientosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SIC.Rpt_Bitacora_Movimientos_Fecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(667, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // SICDataSet1
            // 
            this.SICDataSet1.DataSetName = "SICDataSet1";
            this.SICDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tab_Bitacora_MovimientosBindingSource
            // 
            this.Tab_Bitacora_MovimientosBindingSource.DataMember = "Tab_Bitacora_Movimientos";
            this.Tab_Bitacora_MovimientosBindingSource.DataSource = this.SICDataSet1;
            // 
            // Tab_Bitacora_MovimientosTableAdapter
            // 
            this.Tab_Bitacora_MovimientosTableAdapter.ClearBeforeFill = true;
            // 
            // Visor_Bitacora_Movimientos_Fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Visor_Bitacora_Movimientos_Fechas";
            this.Text = "Visor_Bitacora_Movimientos_Fechas";
            this.Load += new System.EventHandler(this.Visor_Bitacora_Movimientos_Fechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SICDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Bitacora_MovimientosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tab_Bitacora_MovimientosBindingSource;
        private SICDataSet1 SICDataSet1;
        private SICDataSet1TableAdapters.Tab_Bitacora_MovimientosTableAdapter Tab_Bitacora_MovimientosTableAdapter;
    }
}