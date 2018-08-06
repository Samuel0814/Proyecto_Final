namespace Warehouse_Pharmacy_System.UI.Registros
{
    partial class RegistroArticulos
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
            this.Existencialabel = new System.Windows.Forms.Label();
            this.NombreArticulotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ArticuloIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreArticulolabel = new System.Windows.Forms.Label();
            this.PrecioVentalabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExistenciatextBox = new System.Windows.Forms.TextBox();
            this.PrecioVentatextBox = new System.Windows.Forms.TextBox();
            this.PrecioCompratextBox = new System.Windows.Forms.TextBox();
            this.Categoria = new System.Windows.Forms.Label();
            this.CategoriacomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FechaIngresodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ITBIStextBox = new System.Windows.Forms.TextBox();
            this.MYerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MYerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Existencialabel
            // 
            this.Existencialabel.AutoSize = true;
            this.Existencialabel.Location = new System.Drawing.Point(12, 115);
            this.Existencialabel.Name = "Existencialabel";
            this.Existencialabel.Size = new System.Drawing.Size(55, 13);
            this.Existencialabel.TabIndex = 30;
            this.Existencialabel.Text = "Existencia";
            // 
            // NombreArticulotextBox
            // 
            this.NombreArticulotextBox.Location = new System.Drawing.Point(103, 72);
            this.NombreArticulotextBox.Multiline = true;
            this.NombreArticulotextBox.Name = "NombreArticulotextBox";
            this.NombreArticulotextBox.Size = new System.Drawing.Size(282, 25);
            this.NombreArticulotextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Precio Compra";
            // 
            // ArticuloIdnumericUpDown
            // 
            this.ArticuloIdnumericUpDown.Location = new System.Drawing.Point(103, 22);
            this.ArticuloIdnumericUpDown.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.ArticuloIdnumericUpDown.Name = "ArticuloIdnumericUpDown";
            this.ArticuloIdnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ArticuloIdnumericUpDown.TabIndex = 16;
            // 
            // NombreArticulolabel
            // 
            this.NombreArticulolabel.AutoSize = true;
            this.NombreArticulolabel.Location = new System.Drawing.Point(12, 75);
            this.NombreArticulolabel.Name = "NombreArticulolabel";
            this.NombreArticulolabel.Size = new System.Drawing.Size(82, 13);
            this.NombreArticulolabel.TabIndex = 26;
            this.NombreArticulolabel.Text = "Nombre Articulo";
            // 
            // PrecioVentalabel
            // 
            this.PrecioVentalabel.AutoSize = true;
            this.PrecioVentalabel.Location = new System.Drawing.Point(12, 151);
            this.PrecioVentalabel.Name = "PrecioVentalabel";
            this.PrecioVentalabel.Size = new System.Drawing.Size(68, 13);
            this.PrecioVentalabel.TabIndex = 27;
            this.PrecioVentalabel.Text = "Precio Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Articulo ID";
            // 
            // ExistenciatextBox
            // 
            this.ExistenciatextBox.Location = new System.Drawing.Point(103, 103);
            this.ExistenciatextBox.Multiline = true;
            this.ExistenciatextBox.Name = "ExistenciatextBox";
            this.ExistenciatextBox.Size = new System.Drawing.Size(282, 25);
            this.ExistenciatextBox.TabIndex = 32;
            this.ExistenciatextBox.TextChanged += new System.EventHandler(this.ExistenciatextBox_TextChanged);
            // 
            // PrecioVentatextBox
            // 
            this.PrecioVentatextBox.Location = new System.Drawing.Point(103, 139);
            this.PrecioVentatextBox.Multiline = true;
            this.PrecioVentatextBox.Name = "PrecioVentatextBox";
            this.PrecioVentatextBox.Size = new System.Drawing.Size(95, 25);
            this.PrecioVentatextBox.TabIndex = 33;
            // 
            // PrecioCompratextBox
            // 
            this.PrecioCompratextBox.Location = new System.Drawing.Point(286, 139);
            this.PrecioCompratextBox.Multiline = true;
            this.PrecioCompratextBox.Name = "PrecioCompratextBox";
            this.PrecioCompratextBox.Size = new System.Drawing.Size(99, 25);
            this.PrecioCompratextBox.TabIndex = 34;
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Location = new System.Drawing.Point(12, 184);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(52, 13);
            this.Categoria.TabIndex = 35;
            this.Categoria.Text = "Categoria";
            // 
            // CategoriacomboBox
            // 
            this.CategoriacomboBox.FormattingEnabled = true;
            this.CategoriacomboBox.Location = new System.Drawing.Point(102, 176);
            this.CategoriacomboBox.Name = "CategoriacomboBox";
            this.CategoriacomboBox.Size = new System.Drawing.Size(283, 21);
            this.CategoriacomboBox.TabIndex = 36;
            this.CategoriacomboBox.SelectedIndexChanged += new System.EventHandler(this.CategoriacomboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Fecha Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "ITBIS";
            // 
            // FechaIngresodateTimePicker
            // 
            this.FechaIngresodateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaIngresodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIngresodateTimePicker.Location = new System.Drawing.Point(102, 264);
            this.FechaIngresodateTimePicker.Name = "FechaIngresodateTimePicker";
            this.FechaIngresodateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.FechaIngresodateTimePicker.TabIndex = 40;
            // 
            // ITBIStextBox
            // 
            this.ITBIStextBox.Location = new System.Drawing.Point(102, 219);
            this.ITBIStextBox.Multiline = true;
            this.ITBIStextBox.Name = "ITBIStextBox";
            this.ITBIStextBox.Size = new System.Drawing.Size(116, 25);
            this.ITBIStextBox.TabIndex = 41;
            // 
            // MYerrorProvider
            // 
            this.MYerrorProvider.ContainerControl = this;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Delete_File_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(302, 300);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(83, 54);
            this.Eliminarbutton.TabIndex = 23;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Save_All_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(158, 300);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(83, 54);
            this.Guardarbutton.TabIndex = 22;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Create_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(15, 300);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(83, 54);
            this.Nuevobutton.TabIndex = 21;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Search_Property_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(310, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 54);
            this.Buscarbutton.TabIndex = 24;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RegistroArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 372);
            this.Controls.Add(this.ITBIStextBox);
            this.Controls.Add(this.FechaIngresodateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CategoriacomboBox);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.PrecioCompratextBox);
            this.Controls.Add(this.PrecioVentatextBox);
            this.Controls.Add(this.ExistenciatextBox);
            this.Controls.Add(this.Existencialabel);
            this.Controls.Add(this.NombreArticulotextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ArticuloIdnumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.NombreArticulolabel);
            this.Controls.Add(this.PrecioVentalabel);
            this.Controls.Add(this.label1);
            this.Name = "RegistroArticulos";
            this.Text = "RegistroArticulos";
            this.Load += new System.EventHandler(this.RegistroArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MYerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Existencialabel;
        private System.Windows.Forms.TextBox NombreArticulotextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ArticuloIdnumericUpDown;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label NombreArticulolabel;
        private System.Windows.Forms.Label PrecioVentalabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExistenciatextBox;
        private System.Windows.Forms.TextBox PrecioVentatextBox;
        private System.Windows.Forms.TextBox PrecioCompratextBox;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.ComboBox CategoriacomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechaIngresodateTimePicker;
        private System.Windows.Forms.TextBox ITBIStextBox;
        private System.Windows.Forms.ErrorProvider MYerrorProvider;
    }
}