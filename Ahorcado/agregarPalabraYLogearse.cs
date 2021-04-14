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
    public partial class agregarPalabraYLogearse : Form {

        List<String> lista_de_palabras;

        public agregarPalabraYLogearse(List<String> lista_de_palabras) {
            InitializeComponent();

            this.registrarse1.BringToFront();
            this.lista_de_palabras = lista_de_palabras;
        }

        private void agregarPalabraYLogearse_Load(object sender, EventArgs e) {

        }

        private void Agregar_palabro_Click(object sender, EventArgs e) {

            if (this.nueva_palabras.Text != "") {

                this.lista_de_palabras.Add(this.nueva_palabras.Text.ToUpper());
            }

            this.Close();
        }

        private void salir_Click(object sender, EventArgs e) {

            this.Close();
        }
    }
}
