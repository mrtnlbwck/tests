namespace lab2_posk
{
    partial class Sluch
    {
        Menu okno53;
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.reactionButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tryAgainButton = new System.Windows.Forms.Button();
            this.fazaCheck = new System.Windows.Forms.CheckBox();
            this.resultsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // reactionButton
            // 
            this.reactionButton.Location = new System.Drawing.Point(59, 148);
            this.reactionButton.Name = "reactionButton";
            this.reactionButton.Size = new System.Drawing.Size(685, 178);
            this.reactionButton.TabIndex = 0;
            this.reactionButton.UseVisualStyleBackColor = true;
            this.reactionButton.Click += new System.EventHandler(this.reactionButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(201, 341);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(160, 78);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(288, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test czasu reakcji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(241, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sprawdź swój czas reakcji na dźwięk!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(197, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kliknij w przycisk \"START\" by rozpocząć test.\r\nJeśli chcesz potrenować, wybierz f" +
    "aze szkoleniową.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tryAgainButton
            // 
            this.tryAgainButton.Font = new System.Drawing.Font("Bahnschrift", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tryAgainButton.Location = new System.Drawing.Point(464, 341);
            this.tryAgainButton.Name = "tryAgainButton";
            this.tryAgainButton.Size = new System.Drawing.Size(160, 78);
            this.tryAgainButton.TabIndex = 5;
            this.tryAgainButton.Text = "SPRÓBUJ JESZCZE RAZ";
            this.tryAgainButton.UseVisualStyleBackColor = true;
            this.tryAgainButton.Click += new System.EventHandler(this.tryAgainButton_Click);
            // 
            // fazaCheck
            // 
            this.fazaCheck.AutoSize = true;
            this.fazaCheck.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fazaCheck.ForeColor = System.Drawing.Color.White;
            this.fazaCheck.Location = new System.Drawing.Point(36, 114);
            this.fazaCheck.Name = "fazaCheck";
            this.fazaCheck.Size = new System.Drawing.Size(187, 28);
            this.fazaCheck.TabIndex = 6;
            this.fazaCheck.Text = "faza szkoleniowa";
            this.fazaCheck.UseVisualStyleBackColor = true;
            // 
            // resultsChart
            // 
            this.resultsChart.BackColor = System.Drawing.SystemColors.Control;
            this.resultsChart.BorderlineColor = System.Drawing.SystemColors.ControlDark;
            chartArea1.Name = "ChartArea1";
            this.resultsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.resultsChart.Legends.Add(legend1);
            this.resultsChart.Location = new System.Drawing.Point(294, 453);
            this.resultsChart.Name = "resultsChart";
            this.resultsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.resultsChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Cyan};
            series1.BorderWidth = 10;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Wyniki";
            this.resultsChart.Series.Add(series1);
            this.resultsChart.Size = new System.Drawing.Size(450, 212);
            this.resultsChart.TabIndex = 7;
            this.resultsChart.Text = "chart";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(59, 453);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 212);
            this.listBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(57, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Twoje czasy [ms]:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(290, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wykres czasów:";
            // 
            // Sluch
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(795, 692);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.resultsChart);
            this.Controls.Add(this.fazaCheck);
            this.Controls.Add(this.tryAgainButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.reactionButton);
            this.Name = "Sluch";
            ((System.ComponentModel.ISupportInitialize)(this.resultsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reactionButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tryAgainButton;
        private System.Windows.Forms.CheckBox fazaCheck;
        private System.Windows.Forms.DataVisualization.Charting.Chart resultsChart;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
