namespace FERRETERÍA
{
    partial class FrmVehículo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.txtidvehículoaliminar = new System.Windows.Forms.TextBox();
            this.txtidvehículo = new System.Windows.Forms.TextBox();
            this.txtplacas = new System.Windows.Forms.TextBox();
            this.GrvVehiculos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(33, 34);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(75, 23);
            this.BtnInsertar.TabIndex = 0;
            this.BtnInsertar.Text = "INSERTAR";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(702, 24);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(33, 117);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(346, 322);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(143, 23);
            this.BtnActualizar.TabIndex = 3;
            this.BtnActualizar.Text = "ACTUALIZAR TABLA";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // txtidvehículoaliminar
            // 
            this.txtidvehículoaliminar.Location = new System.Drawing.Point(688, 77);
            this.txtidvehículoaliminar.Name = "txtidvehículoaliminar";
            this.txtidvehículoaliminar.Size = new System.Drawing.Size(100, 20);
            this.txtidvehículoaliminar.TabIndex = 4;
            // 
            // txtidvehículo
            // 
            this.txtidvehículo.Location = new System.Drawing.Point(176, 77);
            this.txtidvehículo.Name = "txtidvehículo";
            this.txtidvehículo.Size = new System.Drawing.Size(100, 20);
            this.txtidvehículo.TabIndex = 5;
            // 
            // txtplacas
            // 
            this.txtplacas.Location = new System.Drawing.Point(333, 76);
            this.txtplacas.Name = "txtplacas";
            this.txtplacas.Size = new System.Drawing.Size(100, 20);
            this.txtplacas.TabIndex = 6;
            // 
            // GrvVehiculos
            // 
            this.GrvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvVehiculos.Location = new System.Drawing.Point(222, 137);
            this.GrvVehiculos.Name = "GrvVehiculos";
            this.GrvVehiculos.Size = new System.Drawing.Size(376, 153);
            this.GrvVehiculos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inserta ID ejemplo (123)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Inserta Placa ejemplo (A1B2C3)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Inserta ID Vehiculo";
            // 
            // FrmVehículo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrvVehiculos);
            this.Controls.Add(this.txtplacas);
            this.Controls.Add(this.txtidvehículo);
            this.Controls.Add(this.txtidvehículoaliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnInsertar);
            this.Name = "FrmVehículo";
            this.Text = "VEHÍCULOS";
            this.Load += new System.EventHandler(this.FrmVehículo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox txtidvehículoaliminar;
        private System.Windows.Forms.TextBox txtidvehículo;
        private System.Windows.Forms.TextBox txtplacas;
        private System.Windows.Forms.DataGridView GrvVehiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}