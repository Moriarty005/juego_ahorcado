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
    public partial class registrarse : UserControl {
        public registrarse() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {

            this.Visible = false;
            this.SendToBack();
        }
    }
}
