namespace FERRETERÍA_CB
{
    partial class FrmMétodoPago
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
            this.BtnCargarMétodosDePago = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.GrvMétodosPago = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrvMétodosPago)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCargarMétodosDePago
            // 
            this.BtnCargarMétodosDePago.Location = new System.Drawing.Point(304, 23);
            this.BtnCargarMétodosDePago.Name = "BtnCargarMétodosDePago";
            this.BtnCargarMétodosDePago.Size = new System.Drawing.Size(201, 23);
            this.BtnCargarMétodosDePago.TabIndex = 0;
            this.BtnCargarMétodosDePago.Text = "CARGAR MÉTODOS DE PAGO";
            this.BtnCargarMétodosDePago.UseVisualStyleBackColor = true;
            this.BtnCargarMétodosDePago.Click += new System.EventHandler(this.BtnCargarMétodosDePago_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(304, 322);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(201, 23);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // GrvMétodosPago
            // 
            this.GrvMétodosPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvMétodosPago.Location = new System.Drawing.Point(155, 65);
            this.GrvMétodosPago.Name = "GrvMétodosPago";
            this.GrvMétodosPago.Size = new System.Drawing.Size(496, 235);
            this.GrvMétodosPago.TabIndex = 2;
            // 
            // FrmMétodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrvMétodosPago);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCargarMétodosDePago);
            this.Name = "FrmMétodoPago";
            this.Text = "FrmMétodoPago";
            ((System.ComponentModel.ISupportInitialize)(this.GrvMétodosPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCargarMétodosDePago;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView GrvMétodosPago;
    }
}