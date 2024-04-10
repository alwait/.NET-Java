using System.Drawing.Text;

namespace Zdjecia
{
    public partial class Form1 : Form
    {
        private volatile Bitmap? img;
        Thread[] watki = new Thread[4];
        private Bitmap? img1;
        private Bitmap? img2;
        private Bitmap? img3;
        private Bitmap? img4;
        public static readonly object locker = new object();
        int w, h;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Przetwarzanie obrazów";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            if (file != null)
            {
                img = new Bitmap(file);
                pictureBoxMain.Image = img;
                w= img.Width;
                h= img.Height;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                img1 = new Bitmap(img);
                img2 = new Bitmap(img);
                img3 = new Bitmap(img);
                img4 = new Bitmap(img);

                watki[0] = new Thread(() => progowanie(img1));
                watki[1] = new Thread(() => negatyw(img2));
                watki[2] = new Thread(() => odcienieSzarosci(img3));
                watki[3] = new Thread(() => odbicieLustrzane(img4));

                foreach (Thread x in watki) x.Start();
                foreach (Thread x in watki) x.Join();

                pictureBox1.Image = img1;
                pictureBox2.Image = img2;
                pictureBox3.Image = img3;
                pictureBox4.Image = img4;
            }
        }
        private void progowanie(Bitmap bmp)
        {
            for (int x = 0; x < w; ++x)
                for (int y = 0; y < h; ++y)
                        if (bmp.GetPixel(x, y).R + bmp.GetPixel(x, y).G + bmp.GetPixel(x, y).B < 500) img1.SetPixel(x, y, Color.Black);
                        else img1.SetPixel(x, y, Color.White);
        }
        private void negatyw(Bitmap bmp)
        {
            for (int x = 0; x < w; ++x)
                for (int y = 0; y < h; ++y) 
                {
                        img2.SetPixel(x, y, Color.FromArgb(255, 255 - bmp.GetPixel(x, y).R, 255 - bmp.GetPixel(x, y).G, 255 - bmp.GetPixel(x, y).B));
                }
        }
        private void odcienieSzarosci(Bitmap bmp)
        {
            for (int x = 0; x < w; ++x)
                for (int y = 0; y < h; ++y)
                {
                        int srednia = (int)Math.Round((float)(bmp.GetPixel(x, y).R + bmp.GetPixel(x, y).G + bmp.GetPixel(x, y).B) / 3.0);
                        img3.SetPixel(x, y, Color.FromArgb(255, srednia, srednia, srednia));
                }
        }
        private void odbicieLustrzane(Bitmap bmp)
        {
            Bitmap imgc;
            lock (locker)
            {
                imgc = new Bitmap(bmp);
            }

            for (int x = 0; x < w; ++x)
                for (int y = 0; y < h; ++y)
                        img4.SetPixel(imgc.Width - x - 1, y, Color.FromArgb(255, imgc.GetPixel(x, y).R, imgc.GetPixel(x, y).G, imgc.GetPixel(x, y).B));
 
        }
    }
}
