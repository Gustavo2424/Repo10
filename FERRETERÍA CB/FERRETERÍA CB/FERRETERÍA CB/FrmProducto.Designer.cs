namespace FERRETERÍA_CB
{
    partial class FrmProducto
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
            this.BtnCargarProductos = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.GrvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCargarProductos
            // 
            this.BtnCargarProductos.Location = new System.Drawing.Point(284, 12);
            this.BtnCargarProductos.Name = "BtnCargarProductos";
            this.BtnCargarProductos.Size = new System.Drawing.Size(217, 23);
            this.BtnCargarProductos.TabIndex = 0;
            this.BtnCargarProductos.Text = "CARGAR PRODUCTOS";
            this.BtnCargarProductos.UseVisualStyleBackColor = true;
            this.BtnCargarProductos.Click += new System.EventHandler(this.BtnCargarProductos_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(284, 328);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(217, 23);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // GrvProductos
            // 
            this.GrvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvProductos.Location = new System.Drawing.Point(123, 55);
            this.GrvProductos.Name = "GrvProductos";
            this.GrvProductos.Size = new System.Drawing.Size(538, 252);
            this.GrvProductos.TabIndex = 2;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrvProductos);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCargarProductos);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            ((System.ComponentModel.ISupportInitialize)(this.GrvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCargarProductos;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView GrvProductos;
    }
}