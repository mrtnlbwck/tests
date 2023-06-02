using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_posk
{
    public partial class WzrokMenu : Form
    {
        public WzrokMenu(Menu Okno)
        {
            InitializeComponent();
            this.okno23 = Okno;
        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            this.okno2 = new Wzrok(this);
            this.okno2.ShowDialog();
        }       
        
    }
}
