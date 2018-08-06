namespace Warehouse_Pharmacy_System.UI.Inicio
{
    partial class PagoFactura
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
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FacturasdataGridView = new System.Windows.Forms.DataGridView();
            this.Pagar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Pagarbutton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DevueltatextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.EfectivotextBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivotextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.Location = new System.Drawing.Point(58, 39);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(176, 21);
            this.ClientecomboBox.TabIndex = 0;
            this.ClientecomboBox.SelectedValueChanged += new System.EventHandler(this.ClientecomboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // FacturasdataGridView
            // 
            this.FacturasdataGridView.AllowUserToAddRows = false;
            this.FacturasdataGridView.AllowUserToDeleteRows = false;
            this.FacturasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturasdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pagar});
            this.FacturasdataGridView.Location = new System.Drawing.Point(16, 89);
            this.FacturasdataGridView.Name = "FacturasdataGridView";
            this.FacturasdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FacturasdataGridView.Size = new System.Drawing.Size(751, 268);
            this.FacturasdataGridView.TabIndex = 2;
            this.FacturasdataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CalcularTotal);
            this.FacturasdataGridView.SelectionChanged += new System.EventHandler(this.FacturasdataGridView_SelectionChanged);
            this.FacturasdataGridView.Click += new System.EventHandler(this.FacturasdataGridView_Click);
            // 
            // Pagar
            // 
            this.Pagar.HeaderText = "Pagar";
            this.Pagar.Name = "Pagar";
            // 
            // Pagarbutton
            // 
            this.Pagarbutton.Enabled = false;
            this.Pagarbutton.Location = new System.Drawing.Point(678, 60);
            this.Pagarbutton.Name = "Pagarbutton";
            this.Pagarbutton.Size = new System.Drawing.Size(89, 23);
            this.Pagarbutton.TabIndex = 3;
            this.Pagarbutton.Text = "Pagar";
            this.Pagarbutton.UseVisualStyleBackColor = true;
            this.Pagarbutton.Click += new System.EventHandler(this.Pagarbutton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(16, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Marcar Todo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(631, 366);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "Total:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DevueltatextBox
            // 
            this.DevueltatextBox.Enabled = false;
            this.DevueltatextBox.Location = new System.Drawing.Point(667, 412);
            this.DevueltatextBox.Name = "DevueltatextBox";
            this.DevueltatextBox.Size = new System.Drawing.Size(100, 20);
            this.DevueltatextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Efectivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Devuelta";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Enabled = false;
            this.TotaltextBox.Location = new System.Drawing.Point(667, 363);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 11;
            // 
            // EfectivotextBox
            // 
            this.EfectivotextBox.Location = new System.Drawing.Point(668, 386);
            this.EfectivotextBox.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.EfectivotextBox.Name = "EfectivotextBox";
            this.EfectivotextBox.Size = new System.Drawing.Size(120, 20);
            this.EfectivotextBox.TabIndex = 12;
            this.EfectivotextBox.ValueChanged += new System.EventHandler(this.EfectivotextBox_ValueChanged);
            // 
            // PagoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EfectivotextBox);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DevueltatextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Pagarbutton);
            this.Controls.Add(this.FacturasdataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientecomboBox);
            this.Name = "PagoFactura";
            this.Text = "PagoFactura";
            ((System.ComponentModel.ISupportInitialize)(this.FacturasdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivotextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClientecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FacturasdataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pagar;
        private System.Windows.Forms.Button Pagarbutton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DevueltatextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.NumericUpDown EfectivotextBox;
    }
}