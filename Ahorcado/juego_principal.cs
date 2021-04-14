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
    public partial class juego_principal : Form {

        public List<Label> lista_de_letras_a_adivinar = new List<Label>();
        public List<String> diccionario = new List<string>();
        public List<PictureBox> muñeco = new List<PictureBox>();
        public String palabra_elegida;
        public int numero_de_fallos;

        public juego_principal(int numero_de_nivel, List<String> lista_nuevas_palabras) {
            InitializeComponent();

            lista_de_letras_a_adivinar.Add(this.letra1);
            lista_de_letras_a_adivinar.Add(this.letra2);
            lista_de_letras_a_adivinar.Add(this.letra3);
            lista_de_letras_a_adivinar.Add(this.letra4);
            lista_de_letras_a_adivinar.Add(this.letra5);
            lista_de_letras_a_adivinar.Add(this.letra6);
            lista_de_letras_a_adivinar.Add(this.letra7);
            lista_de_letras_a_adivinar.Add(this.letra8);
            lista_de_letras_a_adivinar.Add(this.letra9);
            lista_de_letras_a_adivinar.Add(this.letra10);
            lista_de_letras_a_adivinar.Add(this.letra11);
            lista_de_letras_a_adivinar.Add(this.letra12);
            

            this.muñeco.Add(cuerda);
            this.muñeco.Add(cabesa);
            this.muñeco.Add(cuerpito);
            this.muñeco.Add(bi);
            this.muñeco.Add(bd);
            this.muñeco.Add(pi);
            this.muñeco.Add(pd);

            this.diccionario.Add("HOLA");
            this.diccionario.Add("ADIOS");
            this.diccionario.Add("ESTUDIANTE");
            this.diccionario.Add("ORDENADOR");
            this.diccionario.Add("ARITMETICA");
            this.diccionario.Add("ESCENOGRAFIA");
            this.diccionario.Add("MOCHUELO");
            this.diccionario.Add("SARDINA");
            

            if (lista_nuevas_palabras.Count > 0) {

                foreach (String palabra in lista_nuevas_palabras) {
                    if (this.buscarPalabraEnDiccionario(palabra) == false) {
                        this.diccionario.Add(palabra);
                    }
                }
            }

            this.elegirPalabraAJugar();

            this.esconderLetrasSegunNivel(numero_de_nivel);

            for (int index = this.palabra_elegida.Length; index < 12; index++) {

                lista_de_letras_a_adivinar[index].Visible = false;
            }

            this.configurarMuñeco();
            this.elegirPalabraAJugar();
        }

        public bool buscarPalabraEnDiccionario(String palabra) {

            bool yeah = false;

            for (int index = 0; index < this.diccionario.Count; index++) {
                if (this.diccionario[index] == palabra) {

                    yeah = true;
                }
            }

            return yeah;
        }

        public void elegirPalabraAJugar() {

            Random juanillo = new Random();

            this.palabra_elegida = this.diccionario[juanillo.Next(0, this.diccionario.Count)];
        }

        public void esconderLetrasSegunNivel(int nivel) {

            Random numero_aleatorio = new Random();
            int numero;

            for (int index = 0; index < nivel; index++) {
                numero = numero_aleatorio.Next(0, this.palabra_elegida.Length);
                if (this.lista_de_letras_a_adivinar[numero].Text == "_") {

                    this.lista_de_letras_a_adivinar[numero].Text = this.palabra_elegida[numero].ToString();

                    for (int index2 = 0; index2 < this.palabra_elegida.Length; index2++) {

                        if (this.palabra_elegida[numero] == this.palabra_elegida[index2]) {

                            this.lista_de_letras_a_adivinar[index2].Text = this.palabra_elegida[index2].ToString();
                        }
                    }
                }
                else {

                    nivel++;
                }
            }


        }

        public void configurarMuñeco() {
            this.cabesa.Visible = false;
            this.cuerda.Visible = false;
            this.cuerpito.Visible = false;
            this.bi.Visible = false;
            this.bd.Visible = false;
            this.pi.Visible = false;
            this.pd.Visible = false;
        }

        public bool comprobarLetraDePalabra(char letra, String palabra) {

            bool encontrada = false;

            for (int index = 0; index < palabra.Length; index++) {

                if (palabra[index] == letra) {

                    this.lista_de_letras_a_adivinar[index].Text = letra.ToString();

                    encontrada = true;
                }
            }

            bool existente = false;

            if (encontrada == false) {

                if (this.numero_de_fallos < this.muñeco.Count) {
                    this.muñeco[this.numero_de_fallos].Visible = true;
                    this.muñeco[this.numero_de_fallos].BringToFront();
                    this.numero_de_fallos++;
                }


                for (int index2 = 0; index2 < this.letras_falladas.Text.Length; index2++) {

                    if (letra == this.letras_falladas.Text[index2]) {

                        existente = true;
                    }
                }

                if (existente == false) {

                    this.letras_falladas.Text += letra.ToString() + " ";
                }
            }

            return encontrada;
        }

        public Color comprobarBoton(bool condicion) {

            if (condicion == true) {
                return Color.Green;
            }
            else {
                return Color.Red;
            }
        }

        private void salir_Click(object sender, EventArgs e) {

            Application.Exit();
        }

        void boton_Click(object sender, EventArgs e) {

            Button boton = (Button)sender;
            char charClicked = boton.Text.ToCharArray()[0];
            boton.Enabled = false;
        }

        public void comprobarFinDelJuego() {

            int contador_palabra = 0;

            if (this.numero_de_fallos < this.muñeco.Count) {

                for (int index = 0; index < this.lista_de_letras_a_adivinar.Count; index++) {

                    if (this.lista_de_letras_a_adivinar[index].Text != "_") {

                        contador_palabra++;
                        if (contador_palabra == this.palabra_elegida.Length) {

                            /*for (int index2 = 0; index2 < this.lista_de_letras_a_adivinar.Count; index2++) {

                                this.lista_de_letras_a_adivinar[index2].Text = "_";
                            }

                            Form1 empezar_otra_vez = new Form1();

                            empezar_otra_vez.Visible = true;

                            this.Close();*/

                            Form_resultado otra_ves = new Form_resultado(this.palabra_elegida, true);
                            otra_ves.Visible = true;
                            this.Close();
                        }
                    }
                }
            }
            else if (this.numero_de_fallos == this.muñeco.Count) {
                /*for (int index = 0; index < this.lista_de_letras_a_adivinar.Count; index++) {

                    this.lista_de_letras_a_adivinar[index].Text = "_";
                }

                Form1 empezar_otra_vez = new Form1();

                empezar_otra_vez.Visible = true;

                this.Close();*/

                Form_resultado otra_ves = new Form_resultado(this.palabra_elegida, false);
                otra_ves.Visible = true;
                this.Close();
            }
        }

        private void A_Click(object sender, EventArgs e) {

            this.A.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.A.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void B_Click(object sender, EventArgs e) {

            this.B.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.B.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void C_Click(object sender, EventArgs e) {

            this.C.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.C.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void D_Click(object sender, EventArgs e) {

            this.D.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.D.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void E_Click(object sender, EventArgs e) {

            this.E.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.E.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void F_Click(object sender, EventArgs e) {

            this.F.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.F.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void G_Click(object sender, EventArgs e) {

            this.G.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.G.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void H_Click(object sender, EventArgs e) {

            this.H.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.H.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void I_Click(object sender, EventArgs e) {

            this.I.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.I.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void J_Click(object sender, EventArgs e) {

            this.J.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.J.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void K_Click(object sender, EventArgs e) {

            this.K.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.K.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void L_Click(object sender, EventArgs e) {

            this.L.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.L.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void M_Click(object sender, EventArgs e) {

            this.M.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.M.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void N_Click(object sender, EventArgs e) {

            this.N.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.N.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void Ñ_Click(object sender, EventArgs e) {

            this.Ñ.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.Ñ.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void O_Click(object sender, EventArgs e) {

            this.O.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.O.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void P_Click(object sender, EventArgs e) {

            this.P.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.P.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void Q_Click(object sender, EventArgs e) {

            this.Q.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.Q.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void R_Click(object sender, EventArgs e) {

            this.R.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.R.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void S_Click(object sender, EventArgs e) {

            this.S.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.S.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void T_Click(object sender, EventArgs e) {

            this.T.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.T.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void U_Click(object sender, EventArgs e) {

            this.U.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.U.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void V_Click(object sender, EventArgs e) {

            this.V.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.V.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void W_Click(object sender, EventArgs e) {

            this.W.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.W.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void X_Click(object sender, EventArgs e) {

            this.X.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.X.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void Y_Click(object sender, EventArgs e) {

            this.Y.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.Y.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void Z_Click(object sender, EventArgs e) {

            this.Z.BackColor = this.comprobarBoton(this.comprobarLetraDePalabra(Char.Parse(this.Z.Text), this.palabra_elegida));

            this.comprobarFinDelJuego();
        }

        private void juego_principal_Load(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void horca_Click(object sender, EventArgs e) {

        }
    }
}