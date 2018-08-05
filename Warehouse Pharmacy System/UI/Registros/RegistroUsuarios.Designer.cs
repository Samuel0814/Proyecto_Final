namespace Warehouse_Pharmacy_System.UI.Registros
{
    partial class RegistroUsuarios
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
            this.TipocomboBox = new System.Windows.Forms.ComboBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.ConfirmarContraseñatextBox = new System.Windows.Forms.TextBox();
            this.ContraseñatextBox = new System.Windows.Forms.TextBox();
            this.NombreArticulotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UsuarioIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreArticulolabel = new System.Windows.Forms.Label();
            this.Contraseñalabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MYerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MYerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TipocomboBox
            // 
            this.TipocomboBox.FormattingEnabled = true;
            this.TipocomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.TipocomboBox.Location = new System.Drawing.Point(123, 117);
            this.TipocomboBox.Name = "TipocomboBox";
            this.TipocomboBox.Size = new System.Drawing.Size(211, 21);
            this.TipocomboBox.TabIndex = 58;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(12, 120);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(28, 13);
            this.Tipo.TabIndex = 57;
            this.Tipo.Text = "Tipo";
            // 
            // ConfirmarContraseñatextBox
            // 
            this.ConfirmarContraseñatextBox.Location = new System.Drawing.Point(123, 188);
            this.ConfirmarContraseñatextBox.Multiline = true;
            this.ConfirmarContraseñatextBox.Name = "ConfirmarContraseñatextBox";
            this.ConfirmarContraseñatextBox.PasswordChar = '*';
            this.ConfirmarContraseñatextBox.Size = new System.Drawing.Size(211, 25);
            this.ConfirmarContraseñatextBox.TabIndex = 56;
            // 
            // ContraseñatextBox
            // 
            this.ContraseñatextBox.Location = new System.Drawing.Point(123, 152);
            this.ContraseñatextBox.Multiline = true;
            this.ContraseñatextBox.Name = "ContraseñatextBox";
            this.ContraseñatextBox.PasswordChar = '*';
            this.ContraseñatextBox.Size = new System.Drawing.Size(211, 25);
            this.ContraseñatextBox.TabIndex = 55;
            // 
            // NombreArticulotextBox
            // 
            this.NombreArticulotextBox.Location = new System.Drawing.Point(123, 74);
            this.NombreArticulotextBox.Multiline = true;
            this.NombreArticulotextBox.Name = "NombreArticulotextBox";
            this.NombreArticulotextBox.Size = new System.Drawing.Size(211, 25);
            this.NombreArticulotextBox.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Confirma Contraseña";
            // 
            // UsuarioIDnumericUpDown
            // 
            this.UsuarioIDnumericUpDown.Location = new System.Drawing.Point(123, 22);
            this.UsuarioIDnumericUpDown.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.UsuarioIDnumericUpDown.Name = "UsuarioIDnumericUpDown";
            this.UsuarioIDnumericUpDown.Size = new System.Drawing.Size(105, 20);
            this.UsuarioIDnumericUpDown.TabIndex = 43;
            // 
            // NombreArticulolabel
            // 
            this.NombreArticulolabel.AutoSize = true;
            this.NombreArticulolabel.Location = new System.Drawing.Point(12, 77);
            this.NombreArticulolabel.Name = "NombreArticulolabel";
            this.NombreArticulolabel.Size = new System.Drawing.Size(83, 13);
            this.NombreArticulolabel.TabIndex = 50;
            this.NombreArticulolabel.Text = "Nombre Usuario";
            // 
            // Contraseñalabel
            // 
            this.Contraseñalabel.AutoSize = true;
            this.Contraseñalabel.Location = new System.Drawing.Point(12, 164);
            this.Contraseñalabel.Name = "Contraseñalabel";
            this.Contraseñalabel.Size = new System.Drawing.Size(61, 13);
            this.Contraseñalabel.TabIndex = 51;
            this.Contraseñalabel.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Usuario ID";
            // 
            // MYerrorProvider
            // 
            this.MYerrorProvider.ContainerControl = this;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Delete_File_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(251, 249);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(83, 54);
            this.Eliminarbutton.TabIndex = 47;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Save_All_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(131, 249);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(83, 54);
            this.Guardarbutton.TabIndex = 46;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Create_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(15, 249);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(83, 54);
            this.Nuevobutton.TabIndex = 45;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Search_Property_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(259, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 54);
            this.Buscarbutton.TabIndex = 48;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 317);
            this.Controls.Add(this.TipocomboBox);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.ConfirmarContraseñatextBox);
            this.Controls.Add(this.ContraseñatextBox);
            this.Controls.Add(this.NombreArticulotextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UsuarioIDnumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.NombreArticulolabel);
            this.Controls.Add(this.Contraseñalabel);
            this.Controls.Add(this.label1);
            this.Name = "RegistroUsuarios";
            this.Text = "RegistroUsuarios";
            this.Load += new System.EventHandler(this.RegistroUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MYerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TipocomboBox;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.TextBox ConfirmarContraseñatextBox;
        private System.Windows.Forms.TextBox ContraseñatextBox;
        private System.Windows.Forms.TextBox NombreArticulotextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown UsuarioIDnumericUpDown;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label NombreArticulolabel;
        private System.Windows.Forms.Label Contraseñalabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider MYerrorProvider;
    }
}