namespace lab2_posk
{
    partial class Menu
    {
        WzrokMenu okno2;
        Pamiec okno4;
        Sluch okno5;

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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTestOpticalStimulus = new System.Windows.Forms.Button();
            this.btnTestAsousticStimulus = new System.Windows.Forms.Button();
            this.btnMemoryTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(61, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sprawdź swój mózg!\r\nWybierz test, dzięki któremu sprawdzisz swój czas reakcji\r\nlu" +
    "b swoją pamięć! \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTestOpticalStimulus
            // 
            this.btnTestOpticalStimulus.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTestOpticalStimulus.Location = new System.Drawing.Point(79, 291);
            this.btnTestOpticalStimulus.Name = "btnTestOpticalStimulus";
            this.btnTestOpticalStimulus.Size = new System.Drawing.Size(194, 92);
            this.btnTestOpticalStimulus.TabIndex = 1;
            this.btnTestOpticalStimulus.Text = "Test czasu reakcji na bodziec optyczny";
            this.btnTestOpticalStimulus.UseVisualStyleBackColor = true;
            this.btnTestOpticalStimulus.Click += new System.EventHandler(this.btnTestOpticalStimulus_Click);
            // 
            // btnTestAsousticStimulus
            // 
            this.btnTestAsousticStimulus.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTestAsousticStimulus.Location = new System.Drawing.Point(330, 291);
            this.btnTestAsousticStimulus.Name = "btnTestAsousticStimulus";
            this.btnTestAsousticStimulus.Size = new System.Drawing.Size(194, 92);
            this.btnTestAsousticStimulus.TabIndex = 2;
            this.btnTestAsousticStimulus.Text = "Test czasu reakcji na bodziec akustyczny";
            this.btnTestAsousticStimulus.UseVisualStyleBackColor = true;
            this.btnTestAsousticStimulus.Click += new System.EventHandler(this.btnTestAsousticStimulus_Click);
            // 
            // btnMemoryTest
            // 
            this.btnMemoryTest.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMemoryTest.Location = new System.Drawing.Point(577, 291);
            this.btnMemoryTest.Name = "btnMemoryTest";
            this.btnMemoryTest.Size = new System.Drawing.Size(194, 92);
            this.btnMemoryTest.TabIndex = 3;
            this.btnMemoryTest.Text = "Test pamięciowy";
            this.btnMemoryTest.UseVisualStyleBackColor = true;
            this.btnMemoryTest.Click += new System.EventHandler(this.btnMemoryTest_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(330, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "ZAKOŃCZ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(866, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMemoryTest);
            this.Controls.Add(this.btnTestAsousticStimulus);
            this.Controls.Add(this.btnTestOpticalStimulus);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Testy psychomotoryczne";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTestOpticalStimulus;
        private System.Windows.Forms.Button btnTestAsousticStimulus;
        private System.Windows.Forms.Button btnMemoryTest;
        private System.Windows.Forms.Button button1;
    }
}