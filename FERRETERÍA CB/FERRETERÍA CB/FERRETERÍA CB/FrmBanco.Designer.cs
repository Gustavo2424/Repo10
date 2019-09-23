namespace FERRETERÍA_CB
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
            this.BtnCargarBancos = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.GrvBancos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrvBancos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCargarBancos
            // 
            this.BtnCargarBancos.Location = new System.Drawing.Point(306, 23);
            this.BtnCargarBancos.Name = "BtnCargarBancos";
            this.BtnCargarBancos.Size = new System.Drawing.Size(181, 23);
            this.BtnCargarBancos.TabIndex = 0;
            this.BtnCargarBancos.Text = "CARGAR BANCOS";
            this.BtnCargarBancos.UseVisualStyleBackColor = true;
            this.BtnCargarBancos.Click += new System.EventHandler(this.BtnCargarBancos_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(306, 305);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(181, 23);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // GrvBancos
            // 
            this.GrvBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvBancos.Location = new System.Drawing.Point(156, 64);
            this.GrvBancos.Name = "GrvBancos";
            this.GrvBancos.Size = new System.Drawing.Size(486, 218);
            this.GrvBancos.TabIndex = 2;
            // 
            // FrmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrvBancos);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCargarBancos);
            this.Name = "FrmBanco";
            this.Text = "FrmBanco";
            ((System.ComponentModel.ISupportInitialize)(this.GrvBancos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCargarBancos;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView GrvBancos;
    }
}