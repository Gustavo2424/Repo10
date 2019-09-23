namespace FERRETERÍA_CB
{
    partial class FrmVendedor
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
            this.BtnCargarVendedores = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.GrvVendedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrvVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCargarVendedores
            // 
            this.BtnCargarVendedores.Location = new System.Drawing.Point(292, 22);
            this.BtnCargarVendedores.Name = "BtnCargarVendedores";
            this.BtnCargarVendedores.Size = new System.Drawing.Size(215, 23);
            this.BtnCargarVendedores.TabIndex = 0;
            this.BtnCargarVendedores.Text = "CARGAR VENDEDORES";
            this.BtnCargarVendedores.UseVisualStyleBackColor = true;
            this.BtnCargarVendedores.Click += new System.EventHandler(this.BtnCargarVendedores_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(292, 322);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(215, 23);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // GrvVendedores
            // 
            this.GrvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvVendedores.Location = new System.Drawing.Point(124, 62);
            this.GrvVendedores.Name = "GrvVendedores";
            this.GrvVendedores.Size = new System.Drawing.Size(549, 242);
            this.GrvVendedores.TabIndex = 2;
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrvVendedores);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCargarVendedores);
            this.Name = "FrmVendedor";
            this.Text = "FrmVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.GrvVendedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCargarVendedores;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView GrvVendedores;
    }
}