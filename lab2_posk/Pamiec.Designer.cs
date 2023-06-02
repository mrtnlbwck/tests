namespace lab2_posk
{
    partial class Pamiec
    {
        Menu okno43;
        Pamiec2 okno4;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Rozpocznij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Slowo = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rozpocznij
            // 
            this.Rozpocznij.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rozpocznij.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rozpocznij.Location = new System.Drawing.Point(332, 316);
            this.Rozpocznij.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rozpocznij.Name = "Rozpocznij";
            this.Rozpocznij.Size = new System.Drawing.Size(239, 57);
            this.Rozpocznij.TabIndex = 0;
            this.Rozpocznij.Text = "Rozpocznij";
            this.Rozpocznij.UseVisualStyleBackColor = true;
            this.Rozpocznij.Click += new System.EventHandler(this.Rozpocznij_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(56, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sprawdź swoją pamięć! Za chwilę wyświetli Ci się kilka losowych słów, postaraj si" +
    "ę je zapamiętać!\r\n Następnie zaznacz słowa, które Twoim zdaniem zostały wyświelo" +
    "ne. \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Slowo
            // 
            this.Slowo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Slowo.AutoSize = true;
            this.Slowo.Font = new System.Drawing.Font("Bahnschrift Condensed", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Slowo.ForeColor = System.Drawing.SystemColors.Window;
            this.Slowo.Location = new System.Drawing.Point(239, 167);
            this.Slowo.Name = "Slowo";
            this.Slowo.Size = new System.Drawing.Size(435, 57);
            this.Slowo.TabIndex = 2;
            this.Slowo.Text = "Tutaj wyświetlą się słowa, ";
            this.Slowo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(344, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 34);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(239, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 57);
            this.label3.TabIndex = 5;
            this.label3.Text = "które musisz zapamiętać!";
            // 
            // Pamiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Slowo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rozpocznij);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pamiec";
            this.Text = "Test pamięciowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rozpocznij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Slowo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}