namespace FERRETERÍA_CB
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
            this.BtnCargarGarantías = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.GrvGarantías = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrvGarantías)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCargarGarantías
            // 
            this.BtnCargarGarantías.Location = new System.Drawing.Point(278, 12);
            this.BtnCargarGarantías.Name = "BtnCargarGarantías";
            this.BtnCargarGarantías.Size = new System.Drawing.Size(214, 23);
            this.BtnCargarGarantías.TabIndex = 0;
            this.BtnCargarGarantías.Text = "CARGAR GARANTÍAS";
            this.BtnCargarGarantías.UseVisualStyleBackColor = true;
            this.BtnCargarGarantías.Click += new System.EventHandler(this.BtnCargarGarantías_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(278, 326);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(214, 23);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // GrvGarantías
            // 
            this.GrvGarantías.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvGarantías.Location = new System.Drawing.Point(113, 51);
            this.GrvGarantías.Name = "GrvGarantías";
            this.GrvGarantías.Size = new System.Drawing.Size(547, 251);
            this.GrvGarantías.TabIndex = 2;
            // 
            // FrmGarantía
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrvGarantías);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCargarGarantías);
            this.Name = "FrmGarantía";
            this.Text = "FrmGarantía";
            ((System.ComponentModel.ISupportInitialize)(this.GrvGarantías)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCargarGarantías;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView GrvGarantías;
    }
}