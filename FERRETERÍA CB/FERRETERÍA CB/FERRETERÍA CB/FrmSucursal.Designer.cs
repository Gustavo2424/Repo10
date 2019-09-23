namespace FERRETERÍA_CB
{
    partial class FrmSucursal
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
            this.BtnCargarSucursales = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.GrvSucursales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCargarSucursales
            // 
            this.BtnCargarSucursales.Location = new System.Drawing.Point(308, 44);
            this.BtnCargarSucursales.Name = "BtnCargarSucursales";
            this.BtnCargarSucursales.Size = new System.Drawing.Size(216, 23);
            this.BtnCargarSucursales.TabIndex = 0;
            this.BtnCargarSucursales.Text = "CARGAR SUCURSALES";
            this.BtnCargarSucursales.UseVisualStyleBackColor = true;
            this.BtnCargarSucursales.Click += new System.EventHandler(this.BtnCargarSucursales_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(308, 328);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(216, 23);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // GrvSucursales
            // 
            this.GrvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvSucursales.Location = new System.Drawing.Point(176, 82);
            this.GrvSucursales.Name = "GrvSucursales";
            this.GrvSucursales.Size = new System.Drawing.Size(477, 225);
            this.GrvSucursales.TabIndex = 2;
            // 
            // FrmSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrvSucursales);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCargarSucursales);
            this.Name = "FrmSucursal";
            this.Text = "FrmSucursal";
            ((System.ComponentModel.ISupportInitialize)(this.GrvSucursales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCargarSucursales;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView GrvSucursales;
    }
}