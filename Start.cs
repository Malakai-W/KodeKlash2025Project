// Programmers: Malakai Wicker, Samuel Hiles
// Program: Intrusion
// Purpose: Game where player has to evade various threats
// Date: 5/13/25
// Old man, gremlin, the warped design, and ending 2 illustration by Eva Wicker
// Images and sounds from https://pixabay.com/
// Map used: https://assetstore.unity.com/packages/3d/environments/urban/ountry-house-125731
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
    public partial class Start : Form
    {
        // Declares variable that indicates value corresponding to difficulty
        public static int Difficulty { get; set; } // 1 = Standard, 2 = Challenge
        public Start()
        {
            InitializeComponent();

            // Sets Difficulty to value corresponding to Standard
            Difficulty = 1;

            // Plays ambience
            // Loops to play background music
            SoundPlayer menuMusic = new SoundPlayer(Properties.Resources.start_ambience);
            menuMusic.PlayLooping();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            // Starts the game

            
            Tutorial tutorial = new Tutorial();
            this.Hide();
            tutorial.Show();
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            // Closes the program
            Application.Exit();
        }

        private void lblStandard_Click(object sender, EventArgs e)
        {
            // Sets difficulty to value corresponding to Standard
            Difficulty = 1;

            // Adds asterisk to label regarding difficulty to signify what user selected & sets other label to regular text
            lblStandard.Text = "*Standard";
            lblChallenge.Text = "Challenge";
        }

        private void lblChallenge_Click(object sender, EventArgs e)
        {
            // Sets difficulty to value corresponding to Challenge
            Difficulty = 2;

            // Adds asterisk to label regarding difficulty to signify what user selected & sets other label to regular text
            lblStandard.Text = "Standard";
            lblChallenge.Text = "*Challenge";
        }
    }
}
