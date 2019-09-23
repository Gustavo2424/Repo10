namespace FERRETERÍA_CB
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
            this.BtnCargarVehículos = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.GrvVehículos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrvVehículos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCargarVehículos
            // 
            this.BtnCargarVehículos.Location = new System.Drawing.Point(304, 23);
            this.BtnCargarVehículos.Name = "BtnCargarVehículos";
            this.BtnCargarVehículos.Size = new System.Drawing.Size(190, 23);
            this.BtnCargarVehículos.TabIndex = 0;
            this.BtnCargarVehículos.Text = "CARGAR VEHÍCULOS";
            this.BtnCargarVehículos.UseVisualStyleBackColor = true;
            this.BtnCargarVehículos.Click += new System.EventHandler(this.BtnCargarVehículos_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(304, 327);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(190, 23);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // GrvVehículos
            // 
            this.GrvVehículos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvVehículos.Location = new System.Drawing.Point(137, 70);
            this.GrvVehículos.Name = "GrvVehículos";
            this.GrvVehículos.Size = new System.Drawing.Size(526, 236);
            this.GrvVehículos.TabIndex = 2;
            // 
            // FrmVehículo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrvVehículos);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCargarVehículos);
            this.Name = "FrmVehículo";
            this.Text = "FrmVehículo";
            ((System.ComponentModel.ISupportInitialize)(this.GrvVehículos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCargarVehículos;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView GrvVehículos;
    }
}