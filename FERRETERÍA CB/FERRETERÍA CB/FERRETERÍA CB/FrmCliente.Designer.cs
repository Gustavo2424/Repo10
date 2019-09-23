namespace FERRETERÍA_CB
{
    partial class FrmCliente
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
            this.GrvClientes = new System.Windows.Forms.DataGridView();
            this.BtnCargarClientes = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GrvClientes
            // 
            this.GrvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvClientes.Location = new System.Drawing.Point(145, 73);
            this.GrvClientes.Name = "GrvClientes";
            this.GrvClientes.Size = new System.Drawing.Size(537, 225);
            this.GrvClientes.TabIndex = 0;
            // 
            // BtnCargarClientes
            // 
            this.BtnCargarClientes.Location = new System.Drawing.Point(292, 32);
            this.BtnCargarClientes.Name = "BtnCargarClientes";
            this.BtnCargarClientes.Size = new System.Drawing.Size(240, 23);
            this.BtnCargarClientes.TabIndex = 1;
            this.BtnCargarClientes.Text = "CARGAR CLIENTES";
            this.BtnCargarClientes.UseVisualStyleBackColor = true;
            this.BtnCargarClientes.Click += new System.EventHandler(this.BtnCargarClientes_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(292, 324);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(240, 23);
            this.BtnActualizar.TabIndex = 2;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnCargarClientes);
            this.Controls.Add(this.GrvClientes);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.GrvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrvClientes;
        private System.Windows.Forms.Button BtnCargarClientes;
        private System.Windows.Forms.Button BtnActualizar;
    }
}