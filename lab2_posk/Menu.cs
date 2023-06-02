using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2_posk
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void btnTestOpticalStimulus_Click(object sender, EventArgs e)
        {
            this.okno2 = new WzrokMenu(this);
            this.okno2.ShowDialog();
        }

        private void btnTestAsousticStimulus_Click(object sender, EventArgs e)
        {
            this.okno5 = new Sluch(this);
            this.okno5.ShowDialog();
        }

        private void btnMemoryTest_Click(object sender, EventArgs e)
        {
            this.okno4 = new Pamiec(this);
            this.okno4.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
