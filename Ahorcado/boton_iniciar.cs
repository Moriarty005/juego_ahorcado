using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado {
    public partial class boton_iniciar : UserControl {

        List<String> lista_palabras;

        public boton_iniciar() {
            InitializeComponent();
        }

        public void setListaPalabrasBI(List<String> lista_palabras) {

            this.lista_palabras = lista_palabras;
        }

        private void button3_Click(object sender, EventArgs e) {

            this.Visible = false;
        }

        private void agregar_palabra_Click(object sender, EventArgs e) {

            agregarPalabraYLogearse juan = new agregarPalabraYLogearse(this.lista_palabras);

            juan.Visible = true;
        }
    }
}
