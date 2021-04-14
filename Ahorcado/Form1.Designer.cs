namespace Ahorcado {
    partial class Form1 {
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.boton_cerrar_proyecto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boton_cancelar_niveles = new System.Windows.Forms.Button();
            this.boton_avanzado = new System.Windows.Forms.Button();
            this.boton_medio = new System.Windows.Forms.Button();
            this.boton_basico = new System.Windows.Forms.Button();
            this.boton_iniciar1 = new Ahorcado.boton_iniciar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.boton_cerrar_proyecto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 37);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hangedman Game";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(293, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // boton_cerrar_proyecto
            // 
            this.boton_cerrar_proyecto.BackColor = System.Drawing.Color.Red;
            this.boton_cerrar_proyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_cerrar_proyecto.Location = new System.Drawing.Point(331, 0);
            this.boton_cerrar_proyecto.Name = "boton_cerrar_proyecto";
            this.boton_cerrar_proyecto.Size = new System.Drawing.Size(41, 37);
            this.boton_cerrar_proyecto.TabIndex = 1;
            this.boton_cerrar_proyecto.Text = "X\r\n";
            this.boton_cerrar_proyecto.UseVisualStyleBackColor = false;
            this.boton_cerrar_proyecto.Click += new System.EventHandler(this.boton_cerrar_proyecto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // boton_cancelar_niveles
            // 
            this.boton_cancelar_niveles.BackColor = System.Drawing.SystemColors.ControlDark;
            this.boton_cancelar_niveles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_cancelar_niveles.Location = new System.Drawing.Point(50, 485);
            this.boton_cancelar_niveles.Name = "boton_cancelar_niveles";
            this.boton_cancelar_niveles.Size = new System.Drawing.Size(264, 40);
            this.boton_cancelar_niveles.TabIndex = 11;
            this.boton_cancelar_niveles.Text = "Cancelar";
            this.boton_cancelar_niveles.UseVisualStyleBackColor = false;
            this.boton_cancelar_niveles.Click += new System.EventHandler(this.boton_cancelar_niveles_Click);
            // 
            // boton_avanzado
            // 
            this.boton_avanzado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.boton_avanzado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_avanzado.Location = new System.Drawing.Point(50, 408);
            this.boton_avanzado.Name = "boton_avanzado";
            this.boton_avanzado.Size = new System.Drawing.Size(264, 40);
            this.boton_avanzado.TabIndex = 10;
            this.boton_avanzado.Text = "Avanzado";
            this.boton_avanzado.UseVisualStyleBackColor = false;
            this.boton_avanzado.Click += new System.EventHandler(this.boton_avanzado_Click);
            // 
            // boton_medio
            // 
            this.boton_medio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.boton_medio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_medio.Location = new System.Drawing.Point(50, 348);
            this.boton_medio.Name = "boton_medio";
            this.boton_medio.Size = new System.Drawing.Size(264, 40);
            this.boton_medio.TabIndex = 9;
            this.boton_medio.Text = "Medio";
            this.boton_medio.UseVisualStyleBackColor = false;
            this.boton_medio.Click += new System.EventHandler(this.boton_medio_Click);
            // 
            // boton_basico
            // 
            this.boton_basico.BackColor = System.Drawing.SystemColors.ControlDark;
            this.boton_basico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_basico.Location = new System.Drawing.Point(50, 286);
            this.boton_basico.Name = "boton_basico";
            this.boton_basico.Size = new System.Drawing.Size(264, 40);
            this.boton_basico.TabIndex = 8;
            this.boton_basico.Text = "Básico";
            this.boton_basico.UseVisualStyleBackColor = false;
            this.boton_basico.Click += new System.EventHandler(this.boton_basico_Click);
            // 
            // boton_iniciar1
            // 
            this.boton_iniciar1.Location = new System.Drawing.Point(-1, 272);
            this.boton_iniciar1.Name = "boton_iniciar1";
            this.boton_iniciar1.Size = new System.Drawing.Size(372, 254);
            this.boton_iniciar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 529);
            this.Controls.Add(this.boton_cancelar_niveles);
            this.Controls.Add(this.boton_avanzado);
            this.Controls.Add(this.boton_medio);
            this.Controls.Add(this.boton_basico);
            this.Controls.Add(this.boton_iniciar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button boton_cerrar_proyecto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private boton_iniciar boton_iniciar1;
        private System.Windows.Forms.Button boton_cancelar_niveles;
        private System.Windows.Forms.Button boton_avanzado;
        private System.Windows.Forms.Button boton_medio;
        private System.Windows.Forms.Button boton_basico;
        private System.Windows.Forms.Label label1;
    }
}

