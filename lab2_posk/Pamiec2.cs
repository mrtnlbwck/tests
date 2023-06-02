using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace lab2_posk
{
    public partial class Pamiec2 : Form
    {
        string[] randomWords = { "Choinka", "Kaczka", "Tulipan", "Mąka", "Bagno", "Biegać", "Kotek","Rzeka", "Uśmiech","Kabanos",
                    "Zachód Słońca", "Chmura", "Pies", "Goździk", "Małpa", "Miasto", "Dwanaście", "Wiertarka", "Latarnia morska",
                "Biedronka", "Północ", "Małpa", "Ziaja", "Kobieta", "Kłapouchy", "Kontynent", "Chleb", "Waga", "Kłamca", "Szczęsny" };

        public List<string> wordsToRemember, checkedWords = new List<string>();
        int correctWords = 0;
        double srednia = 0;
        public Pamiec2(Pamiec Okno)
        {
            InitializeComponent();
            this.okno6 = Okno;
            
            checkedListBox1.Items.AddRange(randomWords);
            checkedListBox1.CheckOnClick = true;
        }


        private void Form6_Load(object sender, EventArgs e)
        {


        }

        private void Sprawdz_Click(object sender, EventArgs e)
        {
            Sprawdz.Enabled = false;
            for (int i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    checkedWords.Add(checkedListBox1.Items[i].ToString());
                    //Console.WriteLine(checkedListBox1.Items[i].ToString());
                }
            }
            Console.WriteLine("checkedWords.Count: " + checkedWords.Count.ToString());
            Console.WriteLine("wordsToRemember.Count: " + wordsToRemember.Count.ToString());
            if (checkedWords.Count > wordsToRemember.Count)
            {
                wynik.Text = "Zaznaczyłeś za dużo słów!";
            }
            else
            {
                for (int i = 0; i < checkedWords.Count; i++)
                {
                    for (int j = 0; i < wordsToRemember.Count; j++)
                    {
                       
                        if (checkedWords[i] == wordsToRemember[j])
                        {
                            correctWords++;
                            break;
                        } else
                        {
                            correctWords = 0;
                            break;
                        }

                    }
                }
                wynik.Text = "Twój wynik: " + correctWords.ToString() + "/" + wordsToRemember.Count.ToString();
                srednia = 100 * correctWords / wordsToRemember.Count ;
                if(srednia <= 30)
                {
                    ocenaWyniku.Text = "Niestety musisz jeszcze poćwiczyć swoją pamięć!";
                } else if ( 31 <= srednia && srednia <=60  )
                {
                    ocenaWyniku.Text = "Jest okej, ale musisz jeszcze poćwiczyć!";
                } else
                {
                    ocenaWyniku.Text = "Twoja pamięć jest bardzo dobra!";
                }
            }
        }
    }
}
