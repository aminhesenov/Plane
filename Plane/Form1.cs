namespace Plane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool thrustOn;
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            thrustOn = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            thrustOn = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (thrustOn)
            {
                pictureBox1.Location=new Point(pictureBox1.Location.X, pictureBox1.Location.Y-1);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 1);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                button1.Text = "ON";

            }
            else
            {
                pictureBox2.Visible = true;
                button1.Text = "OFF";
            }
        }


    }
}
