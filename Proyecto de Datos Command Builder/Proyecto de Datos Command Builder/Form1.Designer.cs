namespace Proyecto_de_Datos_Command_Builder
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEjemplo = new System.Windows.Forms.Button();
            this.GrvEmpleado = new System.Windows.Forms.DataGridView();
            this.BtnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEjemplo
            // 
            this.BtnEjemplo.Location = new System.Drawing.Point(323, 34);
            this.BtnEjemplo.Name = "BtnEjemplo";
            this.BtnEjemplo.Size = new System.Drawing.Size(136, 23);
            this.BtnEjemplo.TabIndex = 0;
            this.BtnEjemplo.Text = "INSERTAR REGISTRO";
            this.BtnEjemplo.UseVisualStyleBackColor = true;
            this.BtnEjemplo.Click += new System.EventHandler(this.BtnEjemplo_Click);
            // 
            // GrvEmpleado
            // 
            this.GrvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvEmpleado.Location = new System.Drawing.Point(231, 63);
            this.GrvEmpleado.Name = "GrvEmpleado";
            this.GrvEmpleado.Size = new System.Drawing.Size(334, 218);
            this.GrvEmpleado.TabIndex = 1;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(348, 287);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(97, 23);
            this.BtnActualizar.TabIndex = 2;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.GrvEmpleado);
            this.Controls.Add(this.BtnEjemplo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GrvEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEjemplo;
        private System.Windows.Forms.DataGridView GrvEmpleado;
        private System.Windows.Forms.Button BtnActualizar;
    }
}

