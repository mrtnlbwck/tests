using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_posk
{
    public partial class Sluch : Form
    {
        private CancellationTokenSource cts;

        Random random = new Random();
        Stopwatch stopwatch = new Stopwatch();
        List<long> timesTested = new List<long>();
        int TimesTested = 0;

        int avarage_time = 0;

        int j = 0;

        public void AverageResponseTime()
        {

            //Convert.ToInt32(timesTested);
            for (int j = 0; j < timesTested.Count; j++)
            {
                avarage_time += (((int)(timesTested[j])) / 5);
            }

        }

        public Sluch(Menu Okno)
        {
            InitializeComponent();
            this.okno53 = Okno;

        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();

            reactionButton.Text = "Wciśnij ten guzik, gdy usłyszysz dźwięk!";
            reactionButton.BackColor = Color.Yellow;

            stopwatch.Reset();

            try
            {
                await Sound(".\\honk.wav", cts.Token);
                await Task.Delay(400);
                stopwatch.Start();
            }
            catch (TaskCanceledException ex)
            {
                MessageBox.Show("Naciśnij Start jeszcze raz");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cts.Dispose();
            }

            cts = null;
        }

        private void tryAgainButton_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
            reactionButton.Text = "Naciśnij START";
            reactionButton.BackColor = Color.LightGray;
        }

        private void reactionButton_Click(object sender, EventArgs e)
        {
            CancellationToken cancellationToken;
            if (fazaCheck.Checked)
            {
                if (stopwatch.IsRunning)
                {
                    stopwatch.Stop();
                    double time = stopwatch.ElapsedMilliseconds;
                    reactionButton.BackColor = Color.YellowGreen;
                    reactionButton.Text = string.Format("Twój czas to " + time + " milisekund! Naciśnij ponownie przycisk 'START'. ");

                }
                else
                {
                    reactionButton.BackColor = Color.Red;
                    reactionButton.Text = string.Format("Za szybko. Naciśnij przycisk 'Spróbuj ponownie'");
                }
            }
            else if (!fazaCheck.Checked)
            {
                if (stopwatch.IsRunning)
                {
                    stopwatch.Stop();
                    timesTested.Add(stopwatch.ElapsedMilliseconds);
                    reactionButton.BackColor = Color.YellowGreen;
                    reactionButton.Text = string.Format("Twój czas to {0} milisekund! Naciśnij ponownie przycisk 'START'. ",
                                                           timesTested[timesTested.Count - 1]);
                    listBox1.Items.Add("\n" + timesTested[timesTested.Count - 1] + " ms");
                    resultsChart.Series["Wyniki"].Points.DataBindY(timesTested);


                    if (timesTested.Count == 5)
                    {
                        AverageResponseTime();
                        MessageBox.Show("Twoje czasy to: " + String.Join(", ", timesTested.ToArray()) + " milisekund!");
                        DialogResult results = MessageBox.Show("Twój średni czas to: " + String.Join(" ", avarage_time) + " milisekund!");
                    }
                }
                else
                {
                    reactionButton.BackColor = Color.Red;
                    reactionButton.Text = string.Format("Za szybko. Naciśnij przycisk 'Spróbuj ponownie'");
                }
            }
        }

        private async Task Sound(string file, CancellationToken token = default)
        {
            await Task.Delay(random.Next(4000, 7000), token);
            using (var soundPlayer = new SoundPlayer(file))
            {

                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }
    }
}
