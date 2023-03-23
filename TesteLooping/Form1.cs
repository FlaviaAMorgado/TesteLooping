using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteLooping
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmExercicio1 Exercicio1 = new frmExercicio1();
            this.Hide();
            Exercicio1.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enquantoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmenquanto Enquanto = new frmenquanto();
            this.Hide();
            Enquanto.Show();
        }
    }
}
