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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double l, result;
            Char cod;

            l = Convert.ToDouble(txtlitros.Text);
            cod = Convert.ToChar(txtcod.Text);

            if (cod.Equals("A")) ;
            {
                if(l>=20)
                {
                    result = l * (4.30 - (4.30 * 3 / 100));
                    txtresult.Text = result.ToString();

                }
                else
                {
                    result = l * (4.30 - (4.30 * 5 / 100));
                    txtresult.Text = result.ToString();
                }
            }
            if (cod.Equals("G")) ;
            {
                if (l >= 20)
                {
                    result=l* (5.50 - (5.50 * 4 / 100));
                    txtresult.Text = result.ToString();
                }
                else
                {
                    result = l * (5.50 - (5.50 * 6 / 100));
                    txtresult.Text = result.ToString();
                }
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcod.Clear();
            txtlitros.Clear();
            txtresult.Clear();

            txtcod.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal Principal = new frmprincipal();
            this.Hide();
            Principal.Show();
        }
    }
}
