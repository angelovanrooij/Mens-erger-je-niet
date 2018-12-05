using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mens_erger_je_niet
{
    public partial class Form1 : Form
    {
        int WaardeGedobbeld;
        public Form1()
        {
            InitializeComponent();
        }

        Dobbelsteen dobbel1 = new Dobbelsteen();

        private void button1_Click(object sender, EventArgs e)
        {
            Spel speler1 = new Spel();
            speler1.getal();
        }
    }
}
