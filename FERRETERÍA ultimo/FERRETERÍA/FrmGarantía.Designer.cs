namespace FERRETERÍA
{
    partial class FrmGarantía
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
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.txtidgarantía = new System.Windows.Forms.TextBox();
            this.txtsemanas = new System.Windows.Forms.TextBox();
            this.txtidgarantiaeliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrvGarantias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrvGarantias)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(30, 21);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(75, 23);
            this.BtnInsertar.TabIndex = 0;
            this.BtnInsertar.Text = "INSERTAR";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(30, 103);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(347, 328);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(147, 23);
            this.BtnActualizar.TabIndex = 2;
            this.BtnActualizar.Text = "ACTUALIZAR TABLA";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(713, 12);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // txtidgarantía
            // 
            this.txtidgarantía.Location = new System.Drawing.Point(168, 67);
            this.txtidgarantía.Name = "txtidgarantía";
            this.txtidgarantía.Size = new System.Drawing.Size(100, 20);
            this.txtidgarantía.TabIndex = 4;
            // 
            // txtsemanas
            // 
            this.txtsemanas.Location = new System.Drawing.Point(347, 67);
            this.txtsemanas.Name = "txtsemanas";
            this.txtsemanas.Size = new System.Drawing.Size(100, 20);
            this.txtsemanas.TabIndex = 5;
            // 
            // txtidgarantiaeliminar
            // 
            this.txtidgarantiaeliminar.Location = new System.Drawing.Point(688, 67);
            this.txtidgarantiaeliminar.Name = "txtidgarantiaeliminar";
            this.txtidgarantiaeliminar.Size = new System.Drawing.Size(100, 20);
            this.txtidgarantiaeliminar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Insertar ID ejemplo (A1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Insertar Semanas ejemplo (2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Insertar ID";
            // 
            // GrvGarantias
            // 
            this.GrvGarantias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvGarantias.Location = new System.Drawing.Point(195, 120);
            this.GrvGarantias.Name = "GrvGarantias";
            this.GrvGarantias.Size = new System.Drawing.Size(432, 180);
            this.GrvGarantias.TabIndex = 10;
            // 
            // FrmGarantía
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrvGarantias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidgarantiaeliminar);
            this.Controls.Add(this.txtsemanas);
            this.Controls.Add(this.txtidgarantía);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnInsertar);
            this.Name = "FrmGarantía";
            this.Text = "GARANTÍAS";
            ((System.ComponentModel.ISupportInitialize)(this.GrvGarantias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox txtidgarantía;
        private System.Windows.Forms.TextBox txtsemanas;
        private System.Windows.Forms.TextBox txtidgarantiaeliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GrvGarantias;
    }
}