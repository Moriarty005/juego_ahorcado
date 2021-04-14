namespace Ahorcado {
    partial class Form_resultado {
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
            this.play_again = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.imagen_resultado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.que_palabra_era = new System.Windows.Forms.Label();
            this.label_resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // play_again
            // 
            this.play_again.BackColor = System.Drawing.SystemColors.ControlDark;
            this.play_again.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_again.Location = new System.Drawing.Point(546, 408);
            this.play_again.Name = "play_again";
            this.play_again.Size = new System.Drawing.Size(195, 53);
            this.play_again.TabIndex = 0;
            this.play_again.Text = "Volver a jugar";
            this.play_again.UseVisualStyleBackColor = false;
            this.play_again.Click += new System.EventHandler(this.play_again_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Location = new System.Drawing.Point(546, 494);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(195, 53);
            this.salir.TabIndex = 1;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // imagen_resultado
            // 
            this.imagen_resultado.Location = new System.Drawing.Point(25, 39);
            this.imagen_resultado.Name = "imagen_resultado";
            this.imagen_resultado.Size = new System.Drawing.Size(453, 504);
            this.imagen_resultado.TabIndex = 2;
            this.imagen_resultado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "La palabra era:";
            // 
            // que_palabra_era
            // 
            this.que_palabra_era.AutoSize = true;
            this.que_palabra_era.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.que_palabra_era.Location = new System.Drawing.Point(546, 314);
            this.que_palabra_era.Name = "que_palabra_era";
            this.que_palabra_era.Size = new System.Drawing.Size(0, 29);
            this.que_palabra_era.TabIndex = 4;
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_resultado.Location = new System.Drawing.Point(540, 39);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(187, 32);
            this.label_resultado.TabIndex = 5;
            this.label_resultado.Text = "Enhorabuena";
            // 
            // Form_resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.que_palabra_era);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagen_resultado);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.play_again);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_resultado";
            this.Text = "Form_resultado";
            ((System.ComponentModel.ISupportInitialize)(this.imagen_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play_again;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.PictureBox imagen_resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label que_palabra_era;
        private System.Windows.Forms.Label label_resultado;
    }
}