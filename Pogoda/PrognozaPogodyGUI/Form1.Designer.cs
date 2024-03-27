namespace PrognozaPogodyGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBaza = new ListBox();
            label1 = new Label();
            textMiasto = new TextBox();
            Miasto = new Label();
            Temperatura = new Label();
            textTemp = new TextBox();
            Wilgotnosc = new Label();
            textWilg = new TextBox();
            Wiatr = new Label();
            textWiatr = new TextBox();
            Aktualizacja = new Label();
            textAktual = new TextBox();
            Baza = new Label();
            buttonAktual = new Button();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // listBaza
            // 
            listBaza.BackColor = Color.LightSkyBlue;
            listBaza.BorderStyle = BorderStyle.FixedSingle;
            listBaza.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            listBaza.ForeColor = Color.Black;
            listBaza.FormattingEnabled = true;
            listBaza.ItemHeight = 15;
            listBaza.Location = new Point(20, 280);
            listBaza.Name = "listBaza";
            listBaza.Size = new Size(517, 77);
            listBaza.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(128, 9);
            label1.Name = "label1";
            label1.Size = new Size(304, 47);
            label1.TabIndex = 1;
            label1.Text = "Stacja pogodowa";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textMiasto
            // 
            textMiasto.Location = new Point(128, 72);
            textMiasto.Name = "textMiasto";
            textMiasto.Size = new Size(100, 23);
            textMiasto.TabIndex = 2;
            // 
            // Miasto
            // 
            Miasto.AutoSize = true;
            Miasto.BackColor = Color.Transparent;
            Miasto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Miasto.Location = new Point(68, 75);
            Miasto.Name = "Miasto";
            Miasto.Size = new Size(54, 20);
            Miasto.TabIndex = 3;
            Miasto.Text = "Miasto";
            // 
            // Temperatura
            // 
            Temperatura.AutoSize = true;
            Temperatura.BackColor = Color.Transparent;
            Temperatura.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Temperatura.Location = new Point(9, 115);
            Temperatura.Name = "Temperatura";
            Temperatura.Size = new Size(116, 20);
            Temperatura.TabIndex = 4;
            Temperatura.Text = "Temperatura [C]";
            // 
            // textTemp
            // 
            textTemp.Location = new Point(128, 115);
            textTemp.Name = "textTemp";
            textTemp.ReadOnly = true;
            textTemp.Size = new Size(100, 23);
            textTemp.TabIndex = 5;
            // 
            // Wilgotnosc
            // 
            Wilgotnosc.AutoSize = true;
            Wilgotnosc.BackColor = Color.Transparent;
            Wilgotnosc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Wilgotnosc.Location = new Point(12, 157);
            Wilgotnosc.Name = "Wilgotnosc";
            Wilgotnosc.Size = new Size(110, 20);
            Wilgotnosc.TabIndex = 6;
            Wilgotnosc.Text = "Wilgotnosc [%]";
            // 
            // textWilg
            // 
            textWilg.Location = new Point(128, 154);
            textWilg.Name = "textWilg";
            textWilg.ReadOnly = true;
            textWilg.Size = new Size(100, 23);
            textWilg.TabIndex = 7;
            // 
            // Wiatr
            // 
            Wiatr.AutoSize = true;
            Wiatr.BackColor = Color.Transparent;
            Wiatr.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Wiatr.Location = new Point(38, 200);
            Wiatr.Name = "Wiatr";
            Wiatr.Size = new Size(84, 20);
            Wiatr.TabIndex = 8;
            Wiatr.Text = "Wiatr [m/s]";
            // 
            // textWiatr
            // 
            textWiatr.Location = new Point(128, 198);
            textWiatr.Name = "textWiatr";
            textWiatr.ReadOnly = true;
            textWiatr.Size = new Size(100, 23);
            textWiatr.TabIndex = 9;
            // 
            // Aktualizacja
            // 
            Aktualizacja.AutoSize = true;
            Aktualizacja.BackColor = Color.Transparent;
            Aktualizacja.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Aktualizacja.Location = new Point(267, 174);
            Aktualizacja.Name = "Aktualizacja";
            Aktualizacja.Size = new Size(146, 20);
            Aktualizacja.TabIndex = 10;
            Aktualizacja.Text = "Ostatnia aktualizacja";
            // 
            // textAktual
            // 
            textAktual.Location = new Point(277, 197);
            textAktual.Name = "textAktual";
            textAktual.ReadOnly = true;
            textAktual.Size = new Size(115, 23);
            textAktual.TabIndex = 11;
            textAktual.TextAlign = HorizontalAlignment.Center;
            // 
            // Baza
            // 
            Baza.AutoSize = true;
            Baza.BackColor = Color.Transparent;
            Baza.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Baza.Location = new Point(46, 257);
            Baza.Name = "Baza";
            Baza.Size = new Size(203, 20);
            Baza.TabIndex = 12;
            Baza.Text = "Historia danych pogodowych";
            // 
            // buttonAktual
            // 
            buttonAktual.BackColor = Color.Transparent;
            buttonAktual.Location = new Point(436, 197);
            buttonAktual.Name = "buttonAktual";
            buttonAktual.Size = new Size(75, 23);
            buttonAktual.TabIndex = 13;
            buttonAktual.Text = "Aktualizuj";
            buttonAktual.UseVisualStyleBackColor = false;
            buttonAktual.Click += buttonAktual_ClickAsync;
            // 
            // pictureBox
            // 
            pictureBox.AccessibleDescription = "";
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Location = new Point(277, 72);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(102, 93);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 14;
            pictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(562, 381);
            Controls.Add(pictureBox);
            Controls.Add(buttonAktual);
            Controls.Add(Baza);
            Controls.Add(textAktual);
            Controls.Add(Aktualizacja);
            Controls.Add(textWiatr);
            Controls.Add(Wiatr);
            Controls.Add(textWilg);
            Controls.Add(Wilgotnosc);
            Controls.Add(textTemp);
            Controls.Add(Temperatura);
            Controls.Add(Miasto);
            Controls.Add(textMiasto);
            Controls.Add(label1);
            Controls.Add(listBaza);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBaza;
        private Label label1;
        private TextBox textMiasto;
        private Label Miasto;
        private Label Temperatura;
        private TextBox textTemp;
        private Label Wilgotnosc;
        private TextBox textWilg;
        private Label Wiatr;
        private TextBox textWiatr;
        private Label Aktualizacja;
        private TextBox textAktual;
        private Label Baza;
        private Button buttonAktual;
        private PictureBox pictureBox;
    }
}
