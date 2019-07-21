namespace ProyectoCooasar.UI.Registros
{
    partial class rPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rPagos));
            this.label3 = new System.Windows.Forms.Label();
            this.CompraId_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PagaTotal_textBox = new System.Windows.Forms.TextBox();
            this.Remover_button = new System.Windows.Forms.Button();
            this.Agregar_button = new System.Windows.Forms.Button();
            this.Pago_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Detalle_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cheque_radioButton = new System.Windows.Forms.RadioButton();
            this.Efectivo_radioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Fecha_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.PagoId_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Balance_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BuscarCompraId_button = new System.Windows.Forms.Button();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CompraId_numericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pago_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PagoId_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Detalle de Pago";
            // 
            // CompraId_numericUpDown
            // 
            this.CompraId_numericUpDown.Location = new System.Drawing.Point(95, 94);
            this.CompraId_numericUpDown.Name = "CompraId_numericUpDown";
            this.CompraId_numericUpDown.Size = new System.Drawing.Size(99, 20);
            this.CompraId_numericUpDown.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.PagaTotal_textBox);
            this.panel1.Controls.Add(this.Remover_button);
            this.panel1.Controls.Add(this.Agregar_button);
            this.panel1.Controls.Add(this.Pago_numericUpDown);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Detalle_dataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(10, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 254);
            this.panel1.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tipo de Pago";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(207, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Pago Total";
            // 
            // PagaTotal_textBox
            // 
            this.PagaTotal_textBox.BackColor = System.Drawing.Color.White;
            this.PagaTotal_textBox.Location = new System.Drawing.Point(305, 223);
            this.PagaTotal_textBox.Name = "PagaTotal_textBox";
            this.PagaTotal_textBox.ReadOnly = true;
            this.PagaTotal_textBox.Size = new System.Drawing.Size(132, 20);
            this.PagaTotal_textBox.TabIndex = 22;
            // 
            // Remover_button
            // 
            this.Remover_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remover_button.Image = global::ProyectoCooasar.Properties.Resources.seo_social_web_network_internet_322_icon_icons_com_61532;
            this.Remover_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Remover_button.Location = new System.Drawing.Point(20, 217);
            this.Remover_button.Name = "Remover_button";
            this.Remover_button.Size = new System.Drawing.Size(132, 30);
            this.Remover_button.TabIndex = 21;
            this.Remover_button.Text = "Remover Fila";
            this.Remover_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Remover_button.UseVisualStyleBackColor = true;
            this.Remover_button.Click += new System.EventHandler(this.Remover_button_Click);
            // 
            // Agregar_button
            // 
            this.Agregar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar_button.Location = new System.Drawing.Point(404, 6);
            this.Agregar_button.Name = "Agregar_button";
            this.Agregar_button.Size = new System.Drawing.Size(33, 30);
            this.Agregar_button.TabIndex = 20;
            this.Agregar_button.Text = "+";
            this.Agregar_button.UseVisualStyleBackColor = true;
            this.Agregar_button.Click += new System.EventHandler(this.Agregar_button_Click);
            // 
            // Pago_numericUpDown
            // 
            this.Pago_numericUpDown.Location = new System.Drawing.Point(305, 13);
            this.Pago_numericUpDown.Name = "Pago_numericUpDown";
            this.Pago_numericUpDown.Size = new System.Drawing.Size(93, 20);
            this.Pago_numericUpDown.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Pago";
            // 
            // Detalle_dataGridView
            // 
            this.Detalle_dataGridView.AllowUserToAddRows = false;
            this.Detalle_dataGridView.AllowUserToDeleteRows = false;
            this.Detalle_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Detalle_dataGridView.Location = new System.Drawing.Point(14, 41);
            this.Detalle_dataGridView.Name = "Detalle_dataGridView";
            this.Detalle_dataGridView.ReadOnly = true;
            this.Detalle_dataGridView.Size = new System.Drawing.Size(427, 170);
            this.Detalle_dataGridView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Cheque_radioButton);
            this.panel2.Controls.Add(this.Efectivo_radioButton);
            this.panel2.Location = new System.Drawing.Point(98, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 30);
            this.panel2.TabIndex = 34;
            // 
            // Cheque_radioButton
            // 
            this.Cheque_radioButton.AutoSize = true;
            this.Cheque_radioButton.Location = new System.Drawing.Point(76, 7);
            this.Cheque_radioButton.Name = "Cheque_radioButton";
            this.Cheque_radioButton.Size = new System.Drawing.Size(62, 17);
            this.Cheque_radioButton.TabIndex = 26;
            this.Cheque_radioButton.TabStop = true;
            this.Cheque_radioButton.Text = "Cheque";
            this.Cheque_radioButton.UseVisualStyleBackColor = true;
            // 
            // Efectivo_radioButton
            // 
            this.Efectivo_radioButton.AutoSize = true;
            this.Efectivo_radioButton.Location = new System.Drawing.Point(6, 7);
            this.Efectivo_radioButton.Name = "Efectivo_radioButton";
            this.Efectivo_radioButton.Size = new System.Drawing.Size(64, 17);
            this.Efectivo_radioButton.TabIndex = 25;
            this.Efectivo_radioButton.TabStop = true;
            this.Efectivo_radioButton.Text = "Efectivo";
            this.Efectivo_radioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fecha";
            // 
            // Fecha_dateTimePicker
            // 
            this.Fecha_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha_dateTimePicker.Location = new System.Drawing.Point(95, 57);
            this.Fecha_dateTimePicker.Name = "Fecha_dateTimePicker";
            this.Fecha_dateTimePicker.Size = new System.Drawing.Size(193, 20);
            this.Fecha_dateTimePicker.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "CompraId";
            // 
            // PagoId_numericUpDown
            // 
            this.PagoId_numericUpDown.Location = new System.Drawing.Point(95, 16);
            this.PagoId_numericUpDown.Name = "PagoId_numericUpDown";
            this.PagoId_numericUpDown.Size = new System.Drawing.Size(99, 20);
            this.PagoId_numericUpDown.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "PagoId";
            // 
            // Balance_textBox
            // 
            this.Balance_textBox.BackColor = System.Drawing.Color.White;
            this.Balance_textBox.Location = new System.Drawing.Point(289, 93);
            this.Balance_textBox.Name = "Balance_textBox";
            this.Balance_textBox.ReadOnly = true;
            this.Balance_textBox.Size = new System.Drawing.Size(106, 20);
            this.Balance_textBox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Balance";
            // 
            // BuscarCompraId_button
            // 
            this.BuscarCompraId_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarCompraId_button.Image = global::ProyectoCooasar.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.BuscarCompraId_button.Location = new System.Drawing.Point(200, 91);
            this.BuscarCompraId_button.Name = "BuscarCompraId_button";
            this.BuscarCompraId_button.Size = new System.Drawing.Size(34, 26);
            this.BuscarCompraId_button.TabIndex = 23;
            this.BuscarCompraId_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarCompraId_button.UseVisualStyleBackColor = true;
            this.BuscarCompraId_button.Click += new System.EventHandler(this.BuscarCompraId_button_Click);
            // 
            // Buscar_button
            // 
            this.Buscar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_button.Image = global::ProyectoCooasar.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.Buscar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar_button.Location = new System.Drawing.Point(200, 9);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(88, 29);
            this.Buscar_button.TabIndex = 20;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_button.Image = global::ProyectoCooasar.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.Eliminar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar_button.Location = new System.Drawing.Point(301, 405);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(94, 34);
            this.Eliminar_button.TabIndex = 19;
            this.Eliminar_button.Text = "Eliminar";
            this.Eliminar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Guardar_button
            // 
            this.Guardar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_button.Image = global::ProyectoCooasar.Properties.Resources.seo_social_web_network_internet_273_icon_icons_com_61489;
            this.Guardar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar_button.Location = new System.Drawing.Point(179, 405);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(95, 34);
            this.Guardar_button.TabIndex = 18;
            this.Guardar_button.Text = "Guardar";
            this.Guardar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo_button.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo_button.Image")));
            this.Nuevo_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevo_button.Location = new System.Drawing.Point(65, 405);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(89, 34);
            this.Nuevo_button.TabIndex = 17;
            this.Nuevo_button.Text = "Nuevo";
            this.Nuevo_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // rPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 447);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Balance_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CompraId_numericUpDown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BuscarCompraId_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Fecha_dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PagoId_numericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.Eliminar_button);
            this.Controls.Add(this.Guardar_button);
            this.Controls.Add(this.Nuevo_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rPagos";
            this.Text = "Registro de Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.CompraId_numericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pago_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PagoId_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown CompraId_numericUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PagaTotal_textBox;
        private System.Windows.Forms.Button Remover_button;
        private System.Windows.Forms.Button Agregar_button;
        private System.Windows.Forms.NumericUpDown Pago_numericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Detalle_dataGridView;
        private System.Windows.Forms.Button BuscarCompraId_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Fecha_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown PagoId_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.TextBox Balance_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Cheque_radioButton;
        private System.Windows.Forms.RadioButton Efectivo_radioButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}