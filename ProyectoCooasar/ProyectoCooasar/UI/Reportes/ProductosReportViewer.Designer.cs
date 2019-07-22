namespace ProyectoCooasar.UI.Reportes
{
    partial class ProductosReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosReportViewer));
            this.Producto_ReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Producto_ReportViewer
            // 
            this.Producto_ReportViewer.ActiveViewIndex = -1;
            this.Producto_ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Producto_ReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Producto_ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Producto_ReportViewer.Location = new System.Drawing.Point(0, 0);
            this.Producto_ReportViewer.Name = "Producto_ReportViewer";
            this.Producto_ReportViewer.Size = new System.Drawing.Size(800, 450);
            this.Producto_ReportViewer.TabIndex = 0;
            // 
            // ProductosReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Producto_ReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductosReportViewer";
            this.Text = "ProductosReportViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Producto_ReportViewer;
    }
}