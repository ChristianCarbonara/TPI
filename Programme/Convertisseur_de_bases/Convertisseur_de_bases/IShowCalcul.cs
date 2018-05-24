using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertisseur_de_bases
{
    public partial class IShowCalcul : Form
    {
        int[] tab = new int[33];
        int nbrTab = 0;
        public IShowCalcul()
        {
            InitializeComponent();
            lblResult.Text = Convert.ToString(x[1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void getTable(int x)
        {
            tab[nbrTab] = x;
        }
    }
}
