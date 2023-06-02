namespace lab2_posk
{
    partial class Pamiec2
    {
        Pamiec okno6;
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Sprawdz = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.Label();
            this.ocenaWyniku = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(163, 80);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(448, 225);
            this.checkedListBox1.TabIndex = 21;
            // 
            // Sprawdz
            // 
            this.Sprawdz.Location = new System.Drawing.Point(292, 381);
            this.Sprawdz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sprawdz.Name = "Sprawdz";
            this.Sprawdz.Size = new System.Drawing.Size(161, 40);
            this.Sprawdz.TabIndex = 22;
            this.Sprawdz.Text = "Sprawdź";
            this.Sprawdz.UseVisualStyleBackColor = true;
            this.Sprawdz.Click += new System.EventHandler(this.Sprawdz_Click);
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(330, 307);
            this.wynik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(0, 24);
            this.wynik.TabIndex = 23;
            // 
            // ocenaWyniku
            // 
            this.ocenaWyniku.AutoSize = true;
            this.ocenaWyniku.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ocenaWyniku.Location = new System.Drawing.Point(266, 332);
            this.ocenaWyniku.Name = "ocenaWyniku";
            this.ocenaWyniku.Size = new System.Drawing.Size(0, 24);
            this.ocenaWyniku.TabIndex = 24;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ocenaWyniku);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.Sprawdz);
            this.Controls.Add(this.checkedListBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form6";
            this.Text = "Test pamięci";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Sprawdz;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Label ocenaWyniku;
    }
}