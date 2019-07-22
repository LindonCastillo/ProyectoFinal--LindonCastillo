namespace ProyectoCooasar.UI.Reportes
{
    partial class UsuariosReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosReportViewer));
            this.Usuarios_crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Usuarios_crystalReportViewer
            // 
            this.Usuarios_crystalReportViewer.ActiveViewIndex = -1;
            this.Usuarios_crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Usuarios_crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.Usuarios_crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Usuarios_crystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.Usuarios_crystalReportViewer.Name = "Usuarios_crystalReportViewer";
            this.Usuarios_crystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.Usuarios_crystalReportViewer.TabIndex = 0;
            this.Usuarios_crystalReportViewer.Load += new System.EventHandler(this.Usuarios_crystalReportViewer_Load);
            // 
            // UsuariosReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Usuarios_crystalReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsuariosReportViewer";
            this.Text = "Usuarios ReportViewer";
            this.Load += new System.EventHandler(this.UsuariosReportViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Usuarios_crystalReportViewer;
    }
}