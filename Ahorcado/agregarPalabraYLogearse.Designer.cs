namespace Ahorcado {
    partial class agregarPalabraYLogearse {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.boton_salir = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.nueva_palabras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Agregar_palabro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.registrarse1 = new Ahorcado.registrarse();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.boton_salir);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 42);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 412);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(714, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // boton_salir
            // 
            this.boton_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_salir.Location = new System.Drawing.Point(870, 0);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(45, 40);
            this.boton_salir.TabIndex = 2;
            this.boton_salir.Text = "-";
            this.boton_salir.UseVisualStyleBackColor = true;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Red;
            this.salir.Dock = System.Windows.Forms.DockStyle.Right;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Location = new System.Drawing.Point(755, 0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(45, 42);
            this.salir.TabIndex = 1;
            this.salir.Text = "X";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // nueva_palabras
            // 
            this.nueva_palabras.Location = new System.Drawing.Point(304, 169);
            this.nueva_palabras.Name = "nueva_palabras";
            this.nueva_palabras.Size = new System.Drawing.Size(162, 22);
            this.nueva_palabras.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Palabra";
            // 
            // Agregar_palabro
            // 
            this.Agregar_palabro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Agregar_palabro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar_palabro.Location = new System.Drawing.Point(304, 303);
            this.Agregar_palabro.Name = "Agregar_palabro";
            this.Agregar_palabro.Size = new System.Drawing.Size(162, 81);
            this.Agregar_palabro.TabIndex = 17;
            this.Agregar_palabro.Text = "Agregar palabra";
            this.Agregar_palabro.UseVisualStyleBackColor = false;
            this.Agregar_palabro.Click += new System.EventHandler(this.Agregar_palabro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "(La palabra tiene que tener como máximo 12 caracteres)";
            // 
            // registrarse1
            // 
            this.registrarse1.Location = new System.Drawing.Point(3, 36);
            this.registrarse1.Name = "registrarse1";
            this.registrarse1.Size = new System.Drawing.Size(800, 412);
            this.registrarse1.TabIndex = 18;
            // 
            // agregarPalabraYLogearse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registrarse1);
            this.Controls.Add(this.Agregar_palabro);
            this.Controls.Add(this.nueva_palabras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregarPalabraYLogearse";
            this.Text = "agregarPalabraYLogearse";
            this.Load += new System.EventHandler(this.agregarPalabraYLogearse_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button boton_salir;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nueva_palabras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Agregar_palabro;
        private registrarse registrarse1;
        private System.Windows.Forms.Label label2;
    }
}