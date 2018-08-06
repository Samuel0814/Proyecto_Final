namespace Warehouse_Pharmacy_System.UI.Registros
{
    partial class RegistroClientes
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
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.FechaNacimientodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SexocomboBox = new System.Windows.Forms.ComboBox();
            this.Telefono = new System.Windows.Forms.Label();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ClienteIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreArticulolabel = new System.Windows.Forms.Label();
            this.Cedulalabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CedulamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MYerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CreditotextBox = new System.Windows.Forms.TextBox();
            this.creditomaximotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MYerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(118, 238);
            this.EmailtextBox.Multiline = true;
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(282, 25);
            this.EmailtextBox.TabIndex = 4;
            // 
            // FechaNacimientodateTimePicker
            // 
            this.FechaNacimientodateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaNacimientodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaNacimientodateTimePicker.Location = new System.Drawing.Point(118, 347);
            this.FechaNacimientodateTimePicker.MaxDate = new System.DateTime(2000, 8, 6, 0, 0, 0, 0);
            this.FechaNacimientodateTimePicker.Name = "FechaNacimientodateTimePicker";
            this.FechaNacimientodateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.FechaNacimientodateTimePicker.TabIndex = 7;
            this.FechaNacimientodateTimePicker.Value = new System.DateTime(2000, 8, 6, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Sexo";
            // 
            // SexocomboBox
            // 
            this.SexocomboBox.FormattingEnabled = true;
            this.SexocomboBox.Location = new System.Drawing.Point(118, 313);
            this.SexocomboBox.Name = "SexocomboBox";
            this.SexocomboBox.Size = new System.Drawing.Size(120, 21);
            this.SexocomboBox.TabIndex = 6;
            this.SexocomboBox.SelectedIndexChanged += new System.EventHandler(this.SexocomboBox_SelectedIndexChanged);
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(12, 281);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(49, 13);
            this.Telefono.TabIndex = 19;
            this.Telefono.Text = "Telefono";
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(118, 134);
            this.DirecciontextBox.Multiline = true;
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(282, 48);
            this.DirecciontextBox.TabIndex = 2;
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(12, 147);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(52, 13);
            this.Direccion.TabIndex = 16;
            this.Direccion.Text = "Direccion";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(118, 77);
            this.NombretextBox.Multiline = true;
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(282, 48);
            this.NombretextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email";
            // 
            // ClienteIDnumericUpDown
            // 
            this.ClienteIDnumericUpDown.Location = new System.Drawing.Point(118, 31);
            this.ClienteIDnumericUpDown.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.ClienteIDnumericUpDown.Name = "ClienteIDnumericUpDown";
            this.ClienteIDnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ClienteIDnumericUpDown.TabIndex = 0;
            // 
            // NombreArticulolabel
            // 
            this.NombreArticulolabel.AutoSize = true;
            this.NombreArticulolabel.Location = new System.Drawing.Point(12, 98);
            this.NombreArticulolabel.Name = "NombreArticulolabel";
            this.NombreArticulolabel.Size = new System.Drawing.Size(49, 13);
            this.NombreArticulolabel.TabIndex = 15;
            this.NombreArticulolabel.Text = "Nombres";
            // 
            // Cedulalabel
            // 
            this.Cedulalabel.AutoSize = true;
            this.Cedulalabel.Location = new System.Drawing.Point(12, 202);
            this.Cedulalabel.Name = "Cedulalabel";
            this.Cedulalabel.Size = new System.Drawing.Size(40, 13);
            this.Cedulalabel.TabIndex = 17;
            this.Cedulalabel.Text = "Cedula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cliente ID";
            // 
            // CedulamaskedTextBox
            // 
            this.CedulamaskedTextBox.Location = new System.Drawing.Point(118, 199);
            this.CedulamaskedTextBox.Mask = "###-#######-#";
            this.CedulamaskedTextBox.Name = "CedulamaskedTextBox";
            this.CedulamaskedTextBox.Size = new System.Drawing.Size(81, 20);
            this.CedulamaskedTextBox.TabIndex = 3;
            this.CedulamaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.CedulamaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CedulamaskedTextBox_MaskInputRejected);
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(118, 278);
            this.TelefonomaskedTextBox.Mask = "000-000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(106, 20);
            this.TelefonomaskedTextBox.TabIndex = 5;
            // 
            // MYerrorProvider
            // 
            this.MYerrorProvider.ContainerControl = this;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Delete_File_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(317, 393);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(83, 54);
            this.Eliminarbutton.TabIndex = 12;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Save_All_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(168, 393);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(83, 54);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Create_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(15, 393);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(83, 54);
            this.Nuevobutton.TabIndex = 10;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Search_Property_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(325, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 54);
            this.Buscarbutton.TabIndex = 13;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total Deuda";
            // 
            // CreditotextBox
            // 
            this.CreditotextBox.Location = new System.Drawing.Point(284, 294);
            this.CreditotextBox.Name = "CreditotextBox";
            this.CreditotextBox.ReadOnly = true;
            this.CreditotextBox.Size = new System.Drawing.Size(100, 20);
            this.CreditotextBox.TabIndex = 8;
            // 
            // creditomaximotextBox
            // 
            this.creditomaximotextBox.Location = new System.Drawing.Point(284, 340);
            this.creditomaximotextBox.Name = "creditomaximotextBox";
            this.creditomaximotextBox.Size = new System.Drawing.Size(100, 20);
            this.creditomaximotextBox.TabIndex = 9;
            this.creditomaximotextBox.TextChanged += new System.EventHandler(this.creditomaximotextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Credito Maximo";
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 468);
            this.Controls.Add(this.creditomaximotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CreditotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Controls.Add(this.CedulamaskedTextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.FechaNacimientodateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SexocomboBox);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClienteIDnumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.NombreArticulolabel);
            this.Controls.Add(this.Cedulalabel);
            this.Controls.Add(this.label1);
            this.Name = "RegistroClientes";
            this.Text = "RegistroClientes";
            this.Load += new System.EventHandler(this.RegistroClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MYerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.DateTimePicker FechaNacimientodateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SexocomboBox;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ClienteIDnumericUpDown;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label NombreArticulolabel;
        private System.Windows.Forms.Label Cedulalabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox CedulamaskedTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.ErrorProvider MYerrorProvider;
        private System.Windows.Forms.TextBox CreditotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox creditomaximotextBox;
        private System.Windows.Forms.Label label5;
    }
}