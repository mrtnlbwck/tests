using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_posk
{
    public partial class Wzrok : Form
    {
        Random random = new Random();
        Stopwatch measuredTime = new Stopwatch();
        List<long> timesTested = new List<long>();             

        int avarage_time = 0;
        int measureNumber = 0;
        int j = 0;

        public Wzrok(WzrokMenu Okno)
        {
            InitializeComponent();
            this.okno1 = Okno;

        }

        private void startButtonClick(object sender, EventArgs e)
        {

            measuredTime.Reset();//czyści czas 

            for (int i = 4; i > 0; i--)
            {
                reactionButton.Text = i.ToString();
                Task.Delay(500).Wait();
                reactionButton.Invalidate();     
            }

            reactionButton.Text = "Wciśnij ten guzik, gdy stanie się zielony!";
            Task.Delay(random.Next(4000, 7000)).Wait();
           

            measuredTime.Start();            
            reactionButton.BackColor = Color.GreenYellow;
            reactionButton.Text = "Kliknij teraz!!";
        }
    

            

        private void reactionButtonClick(object sender, EventArgs e)
        {
            

            if (measuredTime.IsRunning) // jeśli czasomierz jest uruchominy
            {
                measuredTime.Stop();
                timesTested.Add(measuredTime.ElapsedMilliseconds);
                reactionButton.BackColor = Color.Red;

                reactionButton.Text = string.Format("Naciśnij ponownie przycisk 'START'. ");

                if (!checkBox1.Checked)
                {
                    if(measuredTime.ElapsedMilliseconds < 100)
                    {
                        timesTested.Remove(timesTested[timesTested.Count - 1]);
                    } 
                    else
                    {
                        measureNumber++;
                        listBox1.Items.Add("\n" + timesTested[timesTested.Count - 1] + " ms");
                        chart1.Series[0].Points.AddXY(measureNumber, timesTested[timesTested.Count - 1]);
                        chart1.Text = "Wykres";
                        if (timesTested.Count == 6)
                        {
                            AverageResponseTime();
                            averageScore.Text = ("Twój średni czas to: " + String.Join(" ", avarage_time) + " milisekund!");
                            startButton.Enabled = false;
                        }

                    }
                    
                }
            } else
            {
                MessageBox.Show("Za szybko!Spróbuj jeszcze raz!");               
            }
            
        }

        public void AverageResponseTime()
        {

            for (int j = 0; j < timesTested.Count; j++)
            {
                avarage_time += (((int)(timesTested[j])) / 6);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(700, 412);

        }
    }

}





