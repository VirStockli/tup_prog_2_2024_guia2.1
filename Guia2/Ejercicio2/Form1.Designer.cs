namespace Ejercicio2
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
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnGenerarLiqui = new System.Windows.Forms.Button();
            this.btnMostrarLiqui = new System.Windows.Forms.Button();
            this.tbVer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(57, 16);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(96, 59);
            this.btnRegistro.TabIndex = 3;
            this.btnRegistro.Text = "Registrar Empleado";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnGenerarLiqui
            // 
            this.btnGenerarLiqui.Location = new System.Drawing.Point(175, 17);
            this.btnGenerarLiqui.Name = "btnGenerarLiqui";
            this.btnGenerarLiqui.Size = new System.Drawing.Size(85, 57);
            this.btnGenerarLiqui.TabIndex = 4;
            this.btnGenerarLiqui.Text = "Generar Liquidaciones";
            this.btnGenerarLiqui.UseVisualStyleBackColor = true;
            this.btnGenerarLiqui.Click += new System.EventHandler(this.btnGenerarLiqui_Click);
            // 
            // btnMostrarLiqui
            // 
            this.btnMostrarLiqui.Location = new System.Drawing.Point(288, 17);
            this.btnMostrarLiqui.Name = "btnMostrarLiqui";
            this.btnMostrarLiqui.Size = new System.Drawing.Size(89, 59);
            this.btnMostrarLiqui.TabIndex = 5;
            this.btnMostrarLiqui.Text = "Mostrar Liquidaciones";
            this.btnMostrarLiqui.UseVisualStyleBackColor = true;
            this.btnMostrarLiqui.Click += new System.EventHandler(this.btnMostrarLiqui_Click);
            // 
            // tbVer
            // 
            this.tbVer.Location = new System.Drawing.Point(12, 80);
            this.tbVer.Multiline = true;
            this.tbVer.Name = "tbVer";
            this.tbVer.Size = new System.Drawing.Size(420, 226);
            this.tbVer.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 318);
            this.Controls.Add(this.tbVer);
            this.Controls.Add(this.btnMostrarLiqui);
            this.Controls.Add(this.btnGenerarLiqui);
            this.Controls.Add(this.btnRegistro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnRegistro;
        public System.Windows.Forms.Button btnGenerarLiqui;
        public System.Windows.Forms.Button btnMostrarLiqui;
        public System.Windows.Forms.TextBox tbVer;
    }
}

