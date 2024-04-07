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

namespace PeterOS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var soundPlayer = new SoundPlayer(@"c:\Users\Gianni\Downloads\CYW.wav"))

                soundPlayer.Play();

            MessageBox.Show("Great jobb! U Pased Te Petter Text!!!!111!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"c:\Users\Gianni\Downloads\narration.wav"))

                soundPlayer.Play();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VIRUS DOWNLAODED HAHAHAHAHAHHAHAHAHAHAHAHAHAHAHHAHAHAHAHAHAHAHAHAHAHAHAHAHA");
        }
    }
}
