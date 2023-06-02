using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace lab2_posk
{

    public partial class Pamiec : Form
    {
        
        List<string> words = new List<string>()
                    { "Choinka", "Kaczka", "Tulipan", "Mąka", "Bagno", "Biegać", "Kotek","Rzeka", "Uśmiech","Kabanos",
                    "Zachód Słońca", "Chmura", "Pies", "Goździk", "Małpa", "Miasto", "Dwanaście", "Wiertarka", "Latarnia morska",
                "Biedronka", "Północ", "Ziaja", "Kobieta", "Kłapouchy", "Kontynent", "Chleb", "Waga", "Kłamca", "Szczęsny" };

        List<string> wordsToRemember = new List<string>();
        Random random = new Random();
        int numberOfDraws = 0;
        int nrWord = 1;
        public Pamiec(Menu Okno)
        {
            InitializeComponent();
            this.okno43 = Okno;

        }

        public void randomizeWords()
        {
            numberOfDraws = random.Next(1, 10);
            timer.Start();
        }

        
        private void Rozpocznij_Click(object sender, EventArgs e)
        {
           
            randomizeWords();
            Rozpocznij.Enabled = false;
        }

        int StopTime = 0;
        string word = "";
        private void timer_Tick(object sender, EventArgs e)
        {
            if (StopTime <= numberOfDraws)
            {
                int number = random.Next(0, words.Count);
                word = words[number].ToString();
                label2.Text = "Słowo nr " + nrWord++;
                while (wordsToRemember.Contains(word))
                {
                    number = random.Next(0, words.Count);
                    word = words[number].ToString();
                }
                Slowo.Text = word;
                label3.Text = "";
                wordsToRemember.Add(word);
                StopTime++;            
            }
            else
            {
                Slowo.Text = "";
                StopTime = 0;
                timer.Stop();
                this.okno4 = new Pamiec2(this);
                okno4.wordsToRemember = wordsToRemember;
                this.okno4.Show();
            }
        }

    }
}
