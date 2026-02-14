using Intrusion.Properties;
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

namespace Intrusion
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();


            // Makes it so that the picturebox isn't covering the labels - the labels are displayed over the parts of the picturebox
            lblCause.BringToFront();
            lblReturn.BringToFront();
            lblTryAgain.BringToFront();

            // Displays message and image corresponding to what caused player's demise (what resulted in GameOver)
            // O refers to old man, F for front door, G means gremlin chased player, and g means player did not find gremlin in time
            switch(Intruders.Cause)
            {
                case 'O':
                    lblCause.Text = "To the old man, you're no different than any other intruder.";
                    pbCreature.Image = (Image)Resources.OldMan;
                    break;
                case 'F':
                    lblCause.Text = "An intruder can make its way in if the front door remains open for too long.";
                    TheWarped(); // Calls method to display the Warped and changed properties of picturebox so it doesn't look weird
                    break;
                case 'G':
                    lblCause.Text = "Some gremlins cannot be scared off with the empty threat of a flashlight.";
                    pbCreature.Image = (Image)Resources.Gremlin;
                    break;
                case 'g':
                    lblCause.Text = "A gremlin will appear in one of the rooms when a bell is heard. If it's not scared off, it'll break down the boarded windows allowing malicious intruders to get inside.";
                    TheWarped(); // Calls method to display the Warped and changed properties of picturebox so it doesn't look weird
                    break;
            }

            // Initiliazes soundplayer so that sound can be played
            SoundPlayer jumpscare = new SoundPlayer(Properties.Resources.jumpscare);

            // Plays sound
            jumpscare.Play();
        }
        private void TheWarped()
        {
            // Displays the Warped, and changes the size & position of picture box so it doesn't look awkward
            pbCreature.Image = (Image)Resources.TheWarped;
            pbCreature.Height = 500;
            pbCreature.Width = 592;
            pbCreature.Location = new Point(117, 34);
        }
        private void lblTryAgain_Click(object sender, EventArgs e)
        {
            // Closes this form and shows Tutorial form
            Tutorial tutorial = new Tutorial();
            this.Close();
            tutorial.Show();
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            // Displays a message box to assure user that the program acknowledged that they clicked "Return to Menu" (Depending on their computer, it may take longer or shorter)
            MessageBox.Show("You will be returned to the menu in a moment - if you do not see the menu pop up when the program disappears, look at your taskbar.");
            // Returns to Start form (menu) by restarting the application
            Application.Restart();
        }
    }
}
