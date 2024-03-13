namespace Problem_plecakowyInterfejs
{
    partial class InterfejsGraficzny
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
            tIloscPrzedmiotow = new TextBox();
            tSeed = new TextBox();
            tPojemoscPlecaka = new TextBox();
            tInstancja = new TextBox();
            tDaneWyjsciowe = new TextBox();
            bOblicz = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tZmiana = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // tIloscPrzedmiotow
            // 
            tIloscPrzedmiotow.Location = new Point(38, 26);
            tIloscPrzedmiotow.Name = "tIloscPrzedmiotow";
            tIloscPrzedmiotow.Size = new Size(100, 23);
            tIloscPrzedmiotow.TabIndex = 0;
            tIloscPrzedmiotow.Tag = "gdfgdfg";
            tIloscPrzedmiotow.TextChanged += tIloscPrzedmiotow_TextChanged;
            // 
            // tSeed
            // 
            tSeed.Location = new Point(38, 70);
            tSeed.Name = "tSeed";
            tSeed.Size = new Size(100, 23);
            tSeed.TabIndex = 1;
            tSeed.TextChanged += tSeed_TextChanged;
            // 
            // tPojemoscPlecaka
            // 
            tPojemoscPlecaka.Location = new Point(38, 114);
            tPojemoscPlecaka.Name = "tPojemoscPlecaka";
            tPojemoscPlecaka.Size = new Size(100, 23);
            tPojemoscPlecaka.TabIndex = 2;
            tPojemoscPlecaka.TextChanged += tPojemoscPlecaka_TextChanged;
            // 
            // tInstancja
            // 
            tInstancja.BackColor = SystemColors.ControlLightLight;
            tInstancja.Location = new Point(244, 26);
            tInstancja.Multiline = true;
            tInstancja.Name = "tInstancja";
            tInstancja.ReadOnly = true;
            tInstancja.ScrollBars = ScrollBars.Vertical;
            tInstancja.Size = new Size(187, 395);
            tInstancja.TabIndex = 3;
            // 
            // tDaneWyjsciowe
            // 
            tDaneWyjsciowe.BackColor = SystemColors.ControlLightLight;
            tDaneWyjsciowe.Location = new Point(38, 217);
            tDaneWyjsciowe.Multiline = true;
            tDaneWyjsciowe.Name = "tDaneWyjsciowe";
            tDaneWyjsciowe.ReadOnly = true;
            tDaneWyjsciowe.ScrollBars = ScrollBars.Vertical;
            tDaneWyjsciowe.Size = new Size(177, 204);
            tDaneWyjsciowe.TabIndex = 4;
            // 
            // bOblicz
            // 
            bOblicz.Location = new Point(38, 172);
            bOblicz.Name = "bOblicz";
            bOblicz.Size = new Size(97, 24);
            bOblicz.TabIndex = 5;
            bOblicz.Text = "Oblicz";
            bOblicz.UseVisualStyleBackColor = true;
            bOblicz.Click += bOblicz_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 7;
            label1.Text = "Ilosc przedmiotow";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 52);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 8;
            label2.Text = "Ziarno losowania";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 96);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 9;
            label3.Text = "Pojemnosc plecaka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 199);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 10;
            label4.Text = "Dane wyjsciowe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(244, 9);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "Instancja";
            // 
            // tZmiana
            // 
            tZmiana.AutoSize = true;
            tZmiana.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tZmiana.Location = new Point(38, 149);
            tZmiana.Name = "tZmiana";
            tZmiana.Size = new Size(0, 20);
            tZmiana.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(38, 429);
            label6.Name = "label6";
            label6.Size = new Size(264, 13);
            label6.TabIndex = 13;
            label6.Text = "Program nie wykorzystuje algorytmu optymalnego";
            // 
            // InterfejsGraficzny
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 450);
            Controls.Add(label6);
            Controls.Add(tZmiana);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bOblicz);
            Controls.Add(tDaneWyjsciowe);
            Controls.Add(tInstancja);
            Controls.Add(tPojemoscPlecaka);
            Controls.Add(tSeed);
            Controls.Add(tIloscPrzedmiotow);
            Name = "InterfejsGraficzny";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tIloscPrzedmiotow;
        private TextBox tSeed;
        private TextBox tPojemoscPlecaka;
        private TextBox tInstancja;
        private TextBox tDaneWyjsciowe;
        private Button bOblicz;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label tZmiana;
        private Label label6;
    }
}
