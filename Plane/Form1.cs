
using System.Media;
namespace Plane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer sp=new SoundPlayer("D:\\C# dersleri\\img and details\\Plane\\WAV\\inishazirliklari.wav");
            sp.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("D:\\C# dersleri\\img and details\\Plane\\WAV\\turbulans.wav");
            sp.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("D:\\C# dersleri\\img and details\\Plane\\WAV\\kemerler.wav");
            sp.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("D:\\C# dersleri\\img and details\\Plane\\WAV\\tesekkurler.wav");
            sp.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("D:\\C# dersleri\\img and details\\Plane\\WAV\\beep.wav");
            sp.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                SoundPlayer sp = new SoundPlayer("D:\\C# dersleri\\img and details\\Plane\\WAV\\isikacmakapamasesi.wav");
                sp.Play();
            }
            else
            {
                pictureBox2.Visible = true;
                SoundPlayer sp = new SoundPlayer("D:\\C# dersleri\\img and details\\Plane\\WAV\\isikacmakapamasesi.wav");
                sp.Play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Location.Y!=0 && pictureBox2.Location.Y != 0)
            {
                pictureBox1.Location=new Point(pictureBox1.Location.X, pictureBox1.Location.Y-5);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 5);
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
