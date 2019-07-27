namespace ProyectoCooasar.UI.Reportes
{
    partial class ProveedoresReportViewer
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
            this.Proveedores_ReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Proveedores_ReportViewer
            // 
            this.Proveedores_ReportViewer.ActiveViewIndex = -1;
            this.Proveedores_ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Proveedores_ReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Proveedores_ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Proveedores_ReportViewer.Location = new System.Drawing.Point(0, 0);
            this.Proveedores_ReportViewer.Name = "Proveedores_ReportViewer";
            this.Proveedores_ReportViewer.Size = new System.Drawing.Size(800, 450);
            this.Proveedores_ReportViewer.TabIndex = 0;
            // 
            // ProveedoresReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Proveedores_ReportViewer);
            this.Name = "ProveedoresReportViewer";
            this.Text = "ProveedoresReportViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Proveedores_ReportViewer;
    }
}