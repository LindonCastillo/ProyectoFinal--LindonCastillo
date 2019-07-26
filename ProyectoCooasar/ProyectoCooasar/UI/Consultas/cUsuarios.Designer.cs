namespace ProyectoCooasar.UI.Consultas
{
    partial class cUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cUsuarios));
            this.FiltroFecha_checkBox = new System.Windows.Forms.CheckBox();
            this.Imprimir_button = new System.Windows.Forms.Button();
            this.Consulta_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Desde_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Hasta_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Consultar_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Filtro_comboBox = new System.Windows.Forms.ComboBox();
            this.Criterio_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltroFecha_checkBox
            // 
            this.FiltroFecha_checkBox.AutoSize = true;
            this.FiltroFecha_checkBox.Location = new System.Drawing.Point(19, 15);
            this.FiltroFecha_checkBox.Name = "FiltroFecha_checkBox";
            this.FiltroFecha_checkBox.Size = new System.Drawing.Size(102, 17);
            this.FiltroFecha_checkBox.TabIndex = 29;
            this.FiltroFecha_checkBox.Text = "Filtrar por Fecha";
            this.FiltroFecha_checkBox.UseVisualStyleBackColor = true;
            // 
            // Imprimir_button
            // 
            this.Imprimir_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimir_button.Image = global::ProyectoCooasar.Properties.Resources.Impresora;
            this.Imprimir_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimir_button.Location = new System.Drawing.Point(606, 406);
            this.Imprimir_button.Name = "Imprimir_button";
            this.Imprimir_button.Size = new System.Drawing.Size(112, 36);
            this.Imprimir_button.TabIndex = 31;
            this.Imprimir_button.Text = "Imprimir";
            this.Imprimir_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Imprimir_button.UseVisualStyleBackColor = true;
            this.Imprimir_button.Click += new System.EventHandler(this.Imprimir_button_Click_1);
            // 
            // Consulta_dataGridView
            // 
            this.Consulta_dataGridView.AllowUserToAddRows = false;
            this.Consulta_dataGridView.AllowUserToDeleteRows = false;
            this.Consulta_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Consulta_dataGridView.Location = new System.Drawing.Point(12, 99);
            this.Consulta_dataGridView.Name = "Consulta_dataGridView";
            this.Consulta_dataGridView.ReadOnly = true;
            this.Consulta_dataGridView.Size = new System.Drawing.Size(706, 303);
            this.Consulta_dataGridView.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Desde_dateTimePicker);
            this.panel1.Controls.Add(this.Hasta_dateTimePicker);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 61);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 10);
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
            this.Desde_dateTimePicker.Location = new System.Drawing.Point(6, 29);
            this.Desde_dateTimePicker.Name = "Desde_dateTimePicker";
            this.Desde_dateTimePicker.Size = new System.Drawing.Size(121, 21);
            this.Desde_dateTimePicker.TabIndex = 14;
            // 
            // Hasta_dateTimePicker
            // 
            this.Hasta_dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hasta_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hasta_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Hasta_dateTimePicker.Location = new System.Drawing.Point(155, 29);
            this.Hasta_dateTimePicker.Name = "Hasta_dateTimePicker";
            this.Hasta_dateTimePicker.Size = new System.Drawing.Size(121, 21);
            this.Hasta_dateTimePicker.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Consultar_button);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Filtro_comboBox);
            this.panel2.Controls.Add(this.Criterio_textBox);
            this.panel2.Location = new System.Drawing.Point(304, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 61);
            this.panel2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Criterio";
            // 
            // Consultar_button
            // 
            this.Consultar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar_button.Image = global::ProyectoCooasar.Properties.Resources.icono;
            this.Consultar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultar_button.Location = new System.Drawing.Point(368, 10);
            this.Consultar_button.Name = "Consultar_button";
            this.Consultar_button.Size = new System.Drawing.Size(41, 42);
            this.Consultar_button.TabIndex = 21;
            this.Consultar_button.UseVisualStyleBackColor = true;
            this.Consultar_button.Click += new System.EventHandler(this.Consultar_button_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Filtro";
            // 
            // Filtro_comboBox
            // 
            this.Filtro_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtro_comboBox.FormattingEnabled = true;
            this.Filtro_comboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "Nombre",
            "Cantidad",
            "Precio de Compra",
            "Precio de Venta",
            "ITBIS"});
            this.Filtro_comboBox.Location = new System.Drawing.Point(6, 30);
            this.Filtro_comboBox.Name = "Filtro_comboBox";
            this.Filtro_comboBox.Size = new System.Drawing.Size(118, 23);
            this.Filtro_comboBox.TabIndex = 22;
            // 
            // Criterio_textBox
            // 
            this.Criterio_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criterio_textBox.Location = new System.Drawing.Point(133, 31);
            this.Criterio_textBox.Name = "Criterio_textBox";
            this.Criterio_textBox.Size = new System.Drawing.Size(229, 22);
            this.Criterio_textBox.TabIndex = 23;
            // 
            // cUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 449);
            this.Controls.Add(this.FiltroFecha_checkBox);
            this.Controls.Add(this.Imprimir_button);
            this.Controls.Add(this.Consulta_dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cUsuarios";
            this.Text = "Consulta de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FiltroFecha_checkBox;
        private System.Windows.Forms.Button Imprimir_button;
        private System.Windows.Forms.DataGridView Consulta_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Desde_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Hasta_dateTimePicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Consultar_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Filtro_comboBox;
        private System.Windows.Forms.TextBox Criterio_textBox;
    }
}