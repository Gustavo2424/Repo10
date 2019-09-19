namespace FERRETERÍA
{
    partial class FrmBanco
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
            this.BtnIsertar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.txtIDBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrvBanco = new System.Windows.Forms.DataGridView();
            this.BtnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrvBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIsertar
            // 
            this.BtnIsertar.Location = new System.Drawing.Point(25, 26);
            this.BtnIsertar.Name = "BtnIsertar";
            this.BtnIsertar.Size = new System.Drawing.Size(75, 23);
            this.BtnIsertar.TabIndex = 0;
            this.BtnIsertar.Text = "INSERTAR";
            this.BtnIsertar.UseVisualStyleBackColor = true;
            this.BtnIsertar.Click += new System.EventHandler(this.BtnIsertar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(25, 132);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(673, 26);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(117, 90);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(100, 20);
            this.txtBanco.TabIndex = 3;
            // 
            // txtDescripción
            // 
            this.txtDescripción.Location = new System.Drawing.Point(310, 90);
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(100, 20);
            this.txtDescripción.TabIndex = 4;
            // 
            // txtIDBanco
            // 
            this.txtIDBanco.Location = new System.Drawing.Point(659, 90);
            this.txtIDBanco.Name = "txtIDBanco";
            this.txtIDBanco.Size = new System.Drawing.Size(100, 20);
            this.txtIDBanco.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inserta ID ejemplo (A1B2C3)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Iserta ID ejemplo (A1B2C3)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inserta Descripción ejemplo (BANCOMER)";
            // 
            // GrvBanco
            // 
            this.GrvBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvBanco.Location = new System.Drawing.Point(270, 150);
            this.GrvBanco.Name = "GrvBanco";
            this.GrvBanco.Size = new System.Drawing.Size(252, 175);
            this.GrvBanco.TabIndex = 9;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(350, 331);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(96, 23);
            this.BtnActualizar.TabIndex = 10;
            this.BtnActualizar.Text = "Actualizar Tabla";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // FrmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.GrvBanco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDBanco);
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnIsertar);
            this.Name = "FrmBanco";
            this.Text = "BANCOS";
            ((System.ComponentModel.ISupportInitialize)(this.GrvBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIsertar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.TextBox txtIDBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GrvBanco;
        private System.Windows.Forms.Button BtnActualizar;
    }
}