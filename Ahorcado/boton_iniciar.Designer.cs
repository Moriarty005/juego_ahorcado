namespace Ahorcado {
    partial class boton_iniciar {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.button3 = new System.Windows.Forms.Button();
            this.agregar_palabra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(56, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 110);
            this.button3.TabIndex = 3;
            this.button3.Text = "Jugar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // agregar_palabra
            // 
            this.agregar_palabra.BackColor = System.Drawing.SystemColors.ControlDark;
            this.agregar_palabra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar_palabra.Location = new System.Drawing.Point(56, 160);
            this.agregar_palabra.Name = "agregar_palabra";
            this.agregar_palabra.Size = new System.Drawing.Size(256, 59);
            this.agregar_palabra.TabIndex = 4;
            this.agregar_palabra.Text = "Agregar palabra";
            this.agregar_palabra.UseVisualStyleBackColor = false;
            this.agregar_palabra.Click += new System.EventHandler(this.agregar_palabra_Click);
            // 
            // boton_iniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.agregar_palabra);
            this.Controls.Add(this.button3);
            this.Name = "boton_iniciar";
            this.Size = new System.Drawing.Size(372, 254);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button agregar_palabra;
    }
}
