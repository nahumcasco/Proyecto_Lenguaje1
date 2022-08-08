namespace Factura
{
    partial class Facturacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreProductoTextBox = new System.Windows.Forms.TextBox();
            this.ProductoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DetallesDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.ISVTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClienteTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FechaDateTimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Location = new System.Drawing.Point(395, 15);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(475, 22);
            this.ClienteTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(117, 15);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(120, 22);
            this.FechaDateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Factura:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CantidadTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NombreProductoTextBox);
            this.groupBox2.Controls.Add(this.ProductoTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del producto";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(750, 30);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(120, 22);
            this.CantidadTextBox.TabIndex = 4;
            this.CantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad:";
            // 
            // NombreProductoTextBox
            // 
            this.NombreProductoTextBox.Location = new System.Drawing.Point(243, 30);
            this.NombreProductoTextBox.Name = "NombreProductoTextBox";
            this.NombreProductoTextBox.Size = new System.Drawing.Size(405, 22);
            this.NombreProductoTextBox.TabIndex = 2;
            // 
            // ProductoTextBox
            // 
            this.ProductoTextBox.Location = new System.Drawing.Point(117, 30);
            this.ProductoTextBox.Name = "ProductoTextBox";
            this.ProductoTextBox.Size = new System.Drawing.Size(120, 22);
            this.ProductoTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Producto:";
            // 
            // DetallesDataGridView
            // 
            this.DetallesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetallesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallesDataGridView.Location = new System.Drawing.Point(0, 220);
            this.DetallesDataGridView.Name = "DetallesDataGridView";
            this.DetallesDataGridView.Size = new System.Drawing.Size(902, 248);
            this.DetallesDataGridView.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sub Total:";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Enabled = false;
            this.SubTotalTextBox.Location = new System.Drawing.Point(86, 195);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.SubTotalTextBox.TabIndex = 4;
            // 
            // ISVTextBox
            // 
            this.ISVTextBox.Enabled = false;
            this.ISVTextBox.Location = new System.Drawing.Point(232, 195);
            this.ISVTextBox.Name = "ISVTextBox";
            this.ISVTextBox.Size = new System.Drawing.Size(100, 22);
            this.ISVTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "ISV:";
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Location = new System.Drawing.Point(407, 195);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(100, 22);
            this.DescuentoTextBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descuento:";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Enabled = false;
            this.TotalTextBox.Location = new System.Drawing.Point(568, 195);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalTextBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Image = global::Factura.Properties.Resources.cancelar;
            this.CancelarButton.Location = new System.Drawing.Point(788, 183);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(102, 34);
            this.CancelarButton.TabIndex = 11;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::Factura.Properties.Resources.Guardar;
            this.GuardarButton.Location = new System.Drawing.Point(676, 183);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(106, 34);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 468);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ISVTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DetallesDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ProductoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreProductoTextBox;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DetallesDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox ISVTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
    }
}