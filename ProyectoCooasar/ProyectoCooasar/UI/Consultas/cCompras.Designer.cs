namespace ProyectoCooasar.UI.Consultas
{
    partial class cCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cCompras));
            this.Imprimir_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Criterio_textBox = new System.Windows.Forms.TextBox();
            this.Filtro_comboBox = new System.Windows.Forms.ComboBox();
            this.Consultar_button = new System.Windows.Forms.Button();
            this.Consulta_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FiltroFecha_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Desde_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Hasta_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Imprimir_button
            // 
            this.Imprimir_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimir_button.Image = global::ProyectoCooasar.Properties.Resources.Impresora;
            this.Imprimir_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimir_button.Location = new System.Drawing.Point(472, 341);
            this.Imprimir_button.Name = "Imprimir_button";
            this.Imprimir_button.Size = new System.Drawing.Size(112, 36);
            this.Imprimir_button.TabIndex = 34;
            this.Imprimir_button.Text = "Imprimir";
            this.Imprimir_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Imprimir_button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Criterio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Filtro";
            // 
            // Criterio_textBox
            // 
            this.Criterio_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criterio_textBox.Location = new System.Drawing.Point(348, 74);
            this.Criterio_textBox.Name = "Criterio_textBox";
            this.Criterio_textBox.Size = new System.Drawing.Size(236, 22);
            this.Criterio_textBox.TabIndex = 31;
            // 
            // Filtro_comboBox
            // 
            this.Filtro_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtro_comboBox.FormattingEnabled = true;
            this.Filtro_comboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "ProveedorId",
            "Balance",
            "Itbis"});
            this.Filtro_comboBox.Location = new System.Drawing.Point(348, 28);
            this.Filtro_comboBox.Name = "Filtro_comboBox";
            this.Filtro_comboBox.Size = new System.Drawing.Size(118, 23);
            this.Filtro_comboBox.TabIndex = 30;
            // 
            // Consultar_button
            // 
            this.Consultar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar_button.Image = global::ProyectoCooasar.Properties.Resources.icono;
            this.Consultar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultar_button.Location = new System.Drawing.Point(472, 18);
            this.Consultar_button.Name = "Consultar_button";
            this.Consultar_button.Size = new System.Drawing.Size(112, 41);
            this.Consultar_button.TabIndex = 29;
            this.Consultar_button.Text = "Consultar";
            this.Consultar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Consultar_button.UseVisualStyleBackColor = true;
            this.Consultar_button.Click += new System.EventHandler(this.Consultar_button_Click);
            // 
            // Consulta_dataGridView
            // 
            this.Consulta_dataGridView.AllowUserToAddRows = false;
            this.Consulta_dataGridView.AllowUserToDeleteRows = false;
            this.Consulta_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Consulta_dataGridView.Location = new System.Drawing.Point(13, 102);
            this.Consulta_dataGridView.Name = "Consulta_dataGridView";
            this.Consulta_dataGridView.ReadOnly = true;
            this.Consulta_dataGridView.Size = new System.Drawing.Size(583, 233);
            this.Consulta_dataGridView.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FiltroFecha_checkBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Desde_dateTimePicker);
            this.panel1.Controls.Add(this.Hasta_dateTimePicker);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 84);
            this.panel1.TabIndex = 35;
            // 
            // FiltroFecha_checkBox
            // 
            this.FiltroFecha_checkBox.AutoSize = true;
            this.FiltroFecha_checkBox.Location = new System.Drawing.Point(69, 10);
            this.FiltroFecha_checkBox.Name = "FiltroFecha_checkBox";
            this.FiltroFecha_checkBox.Size = new System.Drawing.Size(102, 17);
            this.FiltroFecha_checkBox.TabIndex = 18;
            this.FiltroFecha_checkBox.Text = "Filtrar por Fecha";
            this.FiltroFecha_checkBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hasta";
            // 
            // Desde_dateTimePicker
            // 
            this.Desde_dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desde_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desde_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Desde_dateTimePicker.Location = new System.Drawing.Point(16, 53);
            this.Desde_dateTimePicker.Name = "Desde_dateTimePicker";
            this.Desde_dateTimePicker.Size = new System.Drawing.Size(121, 21);
            this.Desde_dateTimePicker.TabIndex = 14;
            // 
            // Hasta_dateTimePicker
            // 
            this.Hasta_dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hasta_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hasta_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Hasta_dateTimePicker.Location = new System.Drawing.Point(165, 53);
            this.Hasta_dateTimePicker.Name = "Hasta_dateTimePicker";
            this.Hasta_dateTimePicker.Size = new System.Drawing.Size(121, 21);
            this.Hasta_dateTimePicker.TabIndex = 13;
            // 
            // cCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 385);
            this.Controls.Add(this.Imprimir_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Criterio_textBox);
            this.Controls.Add(this.Filtro_comboBox);
            this.Controls.Add(this.Consultar_button);
            this.Controls.Add(this.Consulta_dataGridView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cCompras";
            this.Text = "cCompras";
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Imprimir_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Criterio_textBox;
        private System.Windows.Forms.ComboBox Filtro_comboBox;
        private System.Windows.Forms.Button Consultar_button;
        private System.Windows.Forms.DataGridView Consulta_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox FiltroFecha_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Desde_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Hasta_dateTimePicker;
    }
}