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
    public partial class Form1 : Form {

        public juego_principal giocco;
        List<String> lista_palabras = new List<string>();

        public Form1() {
            InitializeComponent();

            this.boton_iniciar1.setListaPalabrasBI(lista_palabras);
            this.boton_iniciar1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void boton_cancelar_niveles_Click(object sender, EventArgs e) {

            this.boton_iniciar1.Visible = true;
        }

        private void boton_cerrar_proyecto_Click(object sender, EventArgs e) {

            Application.Exit();
        }

        private void boton_basico_Click(object sender, EventArgs e) {

            this.giocco = new juego_principal(2, lista_palabras);
            this.Visible = false;

            this.giocco.Visible = true;
        }

        private void boton_medio_Click(object sender, EventArgs e) {
            this.giocco = new juego_principal(1, lista_palabras);
            this.Visible = false;

            this.giocco.Visible = true;
        }

        private void boton_avanzado_Click(object sender, EventArgs e) {
            this.giocco = new juego_principal(0, lista_palabras);
            this.Visible = false;

            this.giocco.Visible = true;
        }
    }
}
