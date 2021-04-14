using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado {
    public partial class Form_resultado : Form {
        public Form_resultado(String palabra_resultado, bool perdido_o_ganado) {
            InitializeComponent();

            this.que_palabra_era.Text = palabra_resultado;

            if (perdido_o_ganado == false) {

                label_resultado.Text = "HAS PERDIDO";
                label_resultado.ForeColor = Color.Red;
                this.imagen_resultado.ImageLocation = "C:\\Users\\Alexeltocayo\\source\\repos\\Ahorcado\\full_ahorcado.png";
                this.imagen_resultado.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else {

                label_resultado.Text = "HAS GANADO";
                label_resultado.ForeColor = Color.Green;
                this.imagen_resultado.ImageLocation = "C:\\Users\\Alexeltocayo\\source\\repos\\Ahorcado\\cara_felis.png";
                this.imagen_resultado.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void play_again_Click(object sender, EventArgs e) {

            Form1 otra_vez = new Form1();
            otra_vez.Visible = true;

            this.Visible = false;

            this.Close();
        }

        private void salir_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
