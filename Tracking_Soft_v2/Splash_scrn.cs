using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracking_Soft_v2
{
    public partial class Splash_scrn : Form
    {
        public Splash_scrn()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3 ;

            if (panel2.Width == 436)
            {
                mafiaVoice();
            }

            if (panel2.Width >=956)
            {
                timer1.Stop();
                //mafiaVoice();
                //Login f2 = new Login();
                MainForm.login.Show();
                this.Hide();
            }
        }

        private void mafiaVoice()
        {
            ////Accept only Wav
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = @"C:\Users\david\Desktop\NEW WIL\Tracking_Soft_v2\Tracking_Soft_v2\Tracking_Soft_v2\bin\Debug\IMAGES\FrenchToasteMafiaSplashSound.wav";
            //player.Play();
        }

        private void Splash_scrn_Load(object sender, EventArgs e)
        {

        }
    }
}
