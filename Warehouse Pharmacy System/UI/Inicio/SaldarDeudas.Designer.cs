namespace Warehouse_Pharmacy_System.UI.Inicio
{
    partial class SaldarDeudas
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
            this.Tipo = new System.Windows.Forms.Label();
            this.EfectivotextBox = new System.Windows.Forms.TextBox();
            this.DeudatextBox = new System.Windows.Forms.TextBox();
            this.ClientetextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UsuarioIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreArticulolabel = new System.Windows.Forms.Label();
            this.Contraseñalabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.DevueltatextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIDnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(12, 98);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(39, 13);
            this.Tipo.TabIndex = 71;
            this.Tipo.Text = "Deuda";
            // 
            // EfectivotextBox
            // 
            this.EfectivotextBox.Location = new System.Drawing.Point(76, 145);
            this.EfectivotextBox.Multiline = true;
            this.EfectivotextBox.Name = "EfectivotextBox";
            this.EfectivotextBox.Size = new System.Drawing.Size(88, 25);
            this.EfectivotextBox.TabIndex = 70;
            // 
            // DeudatextBox
            // 
            this.DeudatextBox.Location = new System.Drawing.Point(76, 95);
            this.DeudatextBox.Multiline = true;
            this.DeudatextBox.Name = "DeudatextBox";
            this.DeudatextBox.Size = new System.Drawing.Size(183, 25);
            this.DeudatextBox.TabIndex = 69;
            // 
            // ClientetextBox
            // 
            this.ClientetextBox.Location = new System.Drawing.Point(76, 59);
            this.ClientetextBox.Multiline = true;
            this.ClientetextBox.Name = "ClientetextBox";
            this.ClientetextBox.Size = new System.Drawing.Size(183, 25);
            this.ClientetextBox.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Devuelta";
            // 
            // UsuarioIDnumericUpDown
            // 
            this.UsuarioIDnumericUpDown.Location = new System.Drawing.Point(76, 29);
            this.UsuarioIDnumericUpDown.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.UsuarioIDnumericUpDown.Name = "UsuarioIDnumericUpDown";
            this.UsuarioIDnumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.UsuarioIDnumericUpDown.TabIndex = 59;
            // 
            // NombreArticulolabel
            // 
            this.NombreArticulolabel.AutoSize = true;
            this.NombreArticulolabel.Location = new System.Drawing.Point(12, 62);
            this.NombreArticulolabel.Name = "NombreArticulolabel";
            this.NombreArticulolabel.Size = new System.Drawing.Size(39, 13);
            this.NombreArticulolabel.TabIndex = 66;
            this.NombreArticulolabel.Text = "Cliente";
            // 
            // Contraseñalabel
            // 
            this.Contraseñalabel.AutoSize = true;
            this.Contraseñalabel.Location = new System.Drawing.Point(12, 148);
            this.Contraseñalabel.Name = "Contraseñalabel";
            this.Contraseñalabel.Size = new System.Drawing.Size(46, 13);
            this.Contraseñalabel.TabIndex = 67;
            this.Contraseñalabel.Text = "Efectivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "ID Deudas";
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Delete_File_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(181, 216);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(78, 54);
            this.Eliminarbutton.TabIndex = 63;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Save_All_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(86, 216);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(80, 54);
            this.Guardarbutton.TabIndex = 62;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Create_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(12, 216);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(68, 54);
            this.Nuevobutton.TabIndex = 61;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Warehouse_Pharmacy_System.Properties.Resources.icons8_Search_Property_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(181, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(78, 37);
            this.Buscarbutton.TabIndex = 64;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // DevueltatextBox
            // 
            this.DevueltatextBox.Location = new System.Drawing.Point(76, 185);
            this.DevueltatextBox.Multiline = true;
            this.DevueltatextBox.Name = "DevueltatextBox";
            this.DevueltatextBox.Size = new System.Drawing.Size(88, 25);
            this.DevueltatextBox.TabIndex = 72;
            // 
            // SaldarDeudas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 282);
            this.Controls.Add(this.DevueltatextBox);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.EfectivotextBox);
            this.Controls.Add(this.DeudatextBox);
            this.Controls.Add(this.ClientetextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UsuarioIDnumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.NombreArticulolabel);
            this.Controls.Add(this.Contraseñalabel);
            this.Controls.Add(this.label1);
            this.Name = "SaldarDeudas";
            this.Text = "Saldar Deudas";
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIDnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.TextBox EfectivotextBox;
        private System.Windows.Forms.TextBox DeudatextBox;
        private System.Windows.Forms.TextBox ClientetextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown UsuarioIDnumericUpDown;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label NombreArticulolabel;
        private System.Windows.Forms.Label Contraseñalabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DevueltatextBox;
    }
}