namespace FERRETERÍA_CB
{
    partial class FrmFabricante
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
            this.BtnCargarFabricantes = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.GrvFabricantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrvFabricantes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCargarFabricantes
            // 
            this.BtnCargarFabricantes.Location = new System.Drawing.Point(296, 12);
            this.BtnCargarFabricantes.Name = "BtnCargarFabricantes";
            this.BtnCargarFabricantes.Size = new System.Drawing.Size(191, 23);
            this.BtnCargarFabricantes.TabIndex = 0;
            this.BtnCargarFabricantes.Text = "CARGAR FABRICANTES";
            this.BtnCargarFabricantes.UseVisualStyleBackColor = true;
            this.BtnCargarFabricantes.Click += new System.EventHandler(this.BtnCargarFabricantes_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(296, 326);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(191, 23);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // GrvFabricantes
            // 
            this.GrvFabricantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvFabricantes.Location = new System.Drawing.Point(96, 53);
            this.GrvFabricantes.Name = "GrvFabricantes";
            this.GrvFabricantes.Size = new System.Drawing.Size(589, 257);
            this.GrvFabricantes.TabIndex = 2;
            // 
            // FrmFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrvFabricantes);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCargarFabricantes);
            this.Name = "FrmFabricante";
            this.Text = "FrmFabricante";
            ((System.ComponentModel.ISupportInitialize)(this.GrvFabricantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCargarFabricantes;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView GrvFabricantes;
    }
}