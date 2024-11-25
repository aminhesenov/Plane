using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plane
{
    public partial class PlaneSound : UserControl
    {
        public PlaneSound()
        {
            InitializeComponent();
        }
        SoundPlayer sp;

        private void button1_Click(object sender, EventArgs e)
        {
            sp = new SoundPlayer("D:\\C# dersleri\\img and details\\Plane\\WAV\\inishazirliklari.wav");
            sp.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sp = new SoundPlayer("D:\\C# dersleri\\img and details\\Plane\\WAV\\turbulans.wav");
            sp.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sp = new SoundPlayer("D:\\C# dersleri\\img and details\\Plane\\WAV\\kemerler.wav");
            sp.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sp = new SoundPlayer("D:\\C# dersleri\\img and details\\Plane\\WAV\\tesekkurler.wav");
            sp.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sp = new SoundPlayer("D:\\C# dersleri\\img and details\\Plane\\WAV\\beep.wav");
            sp.Play();
        }
    }
}
