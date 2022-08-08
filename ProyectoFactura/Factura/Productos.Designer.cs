namespace Factura
{
    partial class Productos
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
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExistenciaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.ProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Enabled = false;
            this.CodigoTextBox.Location = new System.Drawing.Point(161, 32);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(213, 20);
            this.CodigoTextBox.TabIndex = 1;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Enabled = false;
            this.NombreTextBox.Location = new System.Drawing.Point(161, 58);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(213, 20);
            this.NombreTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // ExistenciaTextBox
            // 
            this.ExistenciaTextBox.Enabled = false;
            this.ExistenciaTextBox.Location = new System.Drawing.Point(161, 84);
            this.ExistenciaTextBox.Name = "ExistenciaTextBox";
            this.ExistenciaTextBox.Size = new System.Drawing.Size(213, 20);
            this.ExistenciaTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Existencia:";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Enabled = false;
            this.PrecioTextBox.Location = new System.Drawing.Point(161, 110);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(213, 20);
            this.PrecioTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::Factura.Properties.Resources.cancelar;
            this.CancelarButton.Location = new System.Drawing.Point(468, 149);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(108, 36);
            this.CancelarButton.TabIndex = 19;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::Factura.Properties.Resources.Guardar;
            this.GuardarButton.Location = new System.Drawing.Point(354, 149);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(108, 36);
            this.GuardarButton.TabIndex = 18;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::Factura.Properties.Resources.eliminar;
            this.EliminarButton.Location = new System.Drawing.Point(240, 149);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(108, 36);
            this.EliminarButton.TabIndex = 17;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Image = global::Factura.Properties.Resources.modificar;
            this.ModificarButton.Location = new System.Drawing.Point(126, 149);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(108, 36);
            this.ModificarButton.TabIndex = 16;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = global::Factura.Properties.Resources.nuevo;
            this.NuevoButton.Location = new System.Drawing.Point(12, 149);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(108, 36);
            this.NuevoButton.TabIndex = 15;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // ProductosDataGridView
            // 
            this.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDataGridView.Location = new System.Drawing.Point(1, 213);
            this.ProductosDataGridView.Name = "ProductosDataGridView";
            this.ProductosDataGridView.Size = new System.Drawing.Size(684, 254);
            this.ProductosDataGridView.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 468);
            this.Controls.Add(this.ProductosDataGridView);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExistenciaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExistenciaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.DataGridView ProductosDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}