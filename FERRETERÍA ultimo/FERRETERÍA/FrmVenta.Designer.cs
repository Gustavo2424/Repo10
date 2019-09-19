namespace FERRETERÍA
{
    partial class FrmVenta
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
            this.GrvVenta = new System.Windows.Forms.DataGridView();
            this.CBCliente = new System.Windows.Forms.ComboBox();
            this.CBVendedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBProductosVenta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnTerminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CBVehículo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GrvPrecioProducto = new System.Windows.Forms.DataGridView();
            this.LBFechaVenta = new System.Windows.Forms.Label();
            this.LBHoraVenta = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvPrecioProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // GrvVenta
            // 
            this.GrvVenta.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvVenta.Location = new System.Drawing.Point(12, 178);
            this.GrvVenta.Name = "GrvVenta";
            this.GrvVenta.Size = new System.Drawing.Size(503, 204);
            this.GrvVenta.TabIndex = 0;
            // 
            // CBCliente
            // 
            this.CBCliente.FormattingEnabled = true;
            this.CBCliente.Location = new System.Drawing.Point(265, 28);
            this.CBCliente.Name = "CBCliente";
            this.CBCliente.Size = new System.Drawing.Size(121, 21);
            this.CBCliente.TabIndex = 1;
            // 
            // CBVendedor
            // 
            this.CBVendedor.FormattingEnabled = true;
            this.CBVendedor.Location = new System.Drawing.Point(415, 28);
            this.CBVendedor.Name = "CBVendedor";
            this.CBVendedor.Size = new System.Drawing.Size(121, 21);
            this.CBVendedor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciona Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecciona Vendedor";
            // 
            // CBProductosVenta
            // 
            this.CBProductosVenta.FormattingEnabled = true;
            this.CBProductosVenta.Location = new System.Drawing.Point(12, 72);
            this.CBProductosVenta.Name = "CBProductosVenta";
            this.CBProductosVenta.Size = new System.Drawing.Size(213, 21);
            this.CBProductosVenta.TabIndex = 5;
            this.CBProductosVenta.SelectionChangeCommitted += new System.EventHandler(this.CBProductosVenta_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecciona Productos de Venta";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(415, 73);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Inserta Cantidad";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(534, 71);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(118, 41);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "AGREGAR A VENTA";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnTerminar
            // 
            this.BtnTerminar.Location = new System.Drawing.Point(669, 71);
            this.BtnTerminar.Name = "BtnTerminar";
            this.BtnTerminar.Size = new System.Drawing.Size(119, 41);
            this.BtnTerminar.TabIndex = 11;
            this.BtnTerminar.Text = "TERMINAR VENTA";
            this.BtnTerminar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "FALTA TOTAL";
            // 
            // CBVehículo
            // 
            this.CBVehículo.FormattingEnabled = true;
            this.CBVehículo.Location = new System.Drawing.Point(534, 178);
            this.CBVehículo.Name = "CBVehículo";
            this.CBVehículo.Size = new System.Drawing.Size(121, 21);
            this.CBVehículo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(661, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Selecciona Id Vehículo";
            // 
            // txtIDVenta
            // 
            this.txtIDVenta.Location = new System.Drawing.Point(678, 29);
            this.txtIDVenta.Name = "txtIDVenta";
            this.txtIDVenta.Size = new System.Drawing.Size(100, 20);
            this.txtIDVenta.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(661, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Inserta Id Venta ejemplo (1)";
            // 
            // GrvPrecioProducto
            // 
            this.GrvPrecioProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrvPrecioProducto.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrvPrecioProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvPrecioProducto.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrvPrecioProducto.Location = new System.Drawing.Point(242, 71);
            this.GrvPrecioProducto.Name = "GrvPrecioProducto";
            this.GrvPrecioProducto.Size = new System.Drawing.Size(144, 67);
            this.GrvPrecioProducto.TabIndex = 17;
            // 
            // LBFechaVenta
            // 
            this.LBFechaVenta.AutoSize = true;
            this.LBFechaVenta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LBFechaVenta.Location = new System.Drawing.Point(12, 13);
            this.LBFechaVenta.Name = "LBFechaVenta";
            this.LBFechaVenta.Size = new System.Drawing.Size(83, 13);
            this.LBFechaVenta.TabIndex = 18;
            this.LBFechaVenta.Text = "Fecha de Venta";
            // 
            // LBHoraVenta
            // 
            this.LBHoraVenta.AutoSize = true;
            this.LBHoraVenta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LBHoraVenta.Location = new System.Drawing.Point(12, 28);
            this.LBHoraVenta.Name = "LBHoraVenta";
            this.LBHoraVenta.Size = new System.Drawing.Size(76, 13);
            this.LBHoraVenta.TabIndex = 19;
            this.LBHoraVenta.Text = "Hora de Venta";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBHoraVenta);
            this.Controls.Add(this.LBFechaVenta);
            this.Controls.Add(this.GrvPrecioProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIDVenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBVehículo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnTerminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBProductosVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBVendedor);
            this.Controls.Add(this.CBCliente);
            this.Controls.Add(this.GrvVenta);
            this.Name = "FrmVenta";
            this.Text = "REALIZANDO VENTA";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvPrecioProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrvVenta;
        private System.Windows.Forms.ComboBox CBCliente;
        private System.Windows.Forms.ComboBox CBVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBProductosVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnTerminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBVehículo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView GrvPrecioProducto;
        private System.Windows.Forms.Label LBFechaVenta;
        private System.Windows.Forms.Label LBHoraVenta;
        private System.Windows.Forms.Timer HoraFecha;
    }
}