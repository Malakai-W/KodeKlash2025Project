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
    public partial class Ending1 : Form
    {
        // Declares variables
        int seconds = 0;
        int rooms = 0;
        public Ending1()
        {
            InitializeComponent();

            // Puts arrows and labels on the front so that picture box containing the Warped creature won't cover those labels & arrows\
            pbDownArrow.BringToFront();
            pbUpArrow.BringToFront();
            lblTheEnd.BringToFront();
            lblReturnToMenu.BringToFront();
        }
        #region Arrows
        private void pbUpArrow_Click(object sender, EventArgs e)
        {
            // Increments variable regarding rooms
            ++rooms;

            // Calls method to display room
            DisplayRoom();
        }

        private void pbLeftArrow_Click(object sender, EventArgs e)
        {
            // Increments variable regarding rooms
            ++rooms;

            // Calls method to display room
            DisplayRoom();
        }
        private void pbDownArrow_Click(object sender, EventArgs e)
        {
            // Decrements variable regarding rooms
            --rooms;

            // Calls method to display room
            DisplayRoom();
        }
        private void pbRightArrow_Click(object sender, EventArgs e)
        {
            // Decrements variable regarding rooms
            --rooms;

            // Calls method to display room
            DisplayRoom();
        }
        #endregion
        #region Methods
        private void DisplayRoom()
        {
            // Calls method to play walk sound - NOTE TO SELF Possibly remove?
            PlayWalkSound();
            // Displays room and enables/disables arrows based on rooms value
            // NOTE TO SELF TO REPLACE IMAGES AT SOME POINT
            switch(rooms)
            {
                case 0:
                    BackgroundImage = (Image)Resources.SafeRoom;
                    DisableLeftArrow();
                    DisableRightArrow();
                    EnableUpArrow();
                    break;
                case 1:
                    BackgroundImage = (Image)Resources.Room1_ClosedDoors;
                    DisableUpArrow();
                    DisableDownArrow();
                    EnableLeftArrow();
                    EnableRightArrow();
                    break;
                case 2:
                    BackgroundImage = (Image)Resources.Hallway_ClosedDoors;
                    DisableRightArrow();
                    EnableDownArrow();
                    break;
                case 3:
                    BackgroundImage = (Image)Resources.FrontDoorSlightlyOpened;
                    DisableLeftArrow();
                    DisableDownArrow();
                    // Enables timer
                    timerShake.Enabled = true;
                    break;
            }
        }
        private void EnableUpArrow()
        {
            pbUpArrow.Visible = true;
            pbUpArrow.Enabled = true;
        }
        private void EnableDownArrow()
        {
            pbDownArrow.Visible = true;
            pbDownArrow.Enabled = true;
        }
        private void EnableLeftArrow()
        {
            pbLeftArrow.Visible = true;
            pbLeftArrow.Enabled = true;
        }
        private void EnableRightArrow()
        {
            pbRightArrow.Visible = true;
            pbRightArrow.Enabled = true;
        }
        private void DisableUpArrow()
        {
            pbUpArrow.Visible = false;
            pbUpArrow.Enabled = false;
        }
        private void DisableDownArrow()
        {
            pbDownArrow.Visible = false;
            pbDownArrow.Enabled = false;
        }
        private void DisableLeftArrow()
        {
            pbLeftArrow.Visible = false;
            pbLeftArrow.Enabled = false;
        }
        private void DisableRightArrow()
        {
            pbRightArrow.Visible = false;
            pbRightArrow.Enabled = false;
        }
        private void PlayWalkSound()
        {
            // Initiliazes soundplayer to play walking sound
            SoundPlayer walk = new SoundPlayer(Properties.Resources.WoodCreak);
            walk.Play();
        }
        #endregion
        private void timerShake_Tick(object sender, EventArgs e)
        {
            // Increments seconds 
            ++seconds;

            // Random values are generated and case statements are used to move form to different directions to create a shaking effect
            Random rnd = new Random();
            int numLeft = rnd.Next(5, 10);
            int numTop = rnd.Next(1, 6);
            switch (seconds)
            {
                case 1:
                    this.Left -= numLeft;
                    this.Top -= numTop;
                    // Plays sound
                    SoundPlayer rumble = new SoundPlayer(Properties.Resources.Rumble);
                    rumble.Play();
                    break;
                case 2:
                    this.Left += numLeft;
                    this.Top += numTop;
                    break;
                case 3:
                    this.Left -= numLeft;
                    this.Top -= numTop;
                    break;
                case 4:
                    this.Left += numLeft;
                    this.Top += numTop;
                    break;
                case 5:
                    this.Left -= numLeft;
                    this.Top -= numTop;
                    break;
                case 6:
                    this.Left += numLeft;
                    this.Top += numTop;
                    break;
                case 7:
                    this.Left -= numLeft;
                    this.Top -= numTop;
                    break;
                case 8:
                    // Nothing happens
                    break;
                case 9:
                    pbTheWarped.Visible = true;
                    break;
                case 10:
                    // Disables timer
                    timerShake.Enabled = false;
                    // Enables labels
                    lblReturnToMenu.Enabled = true;
                    lblReturnToMenu.Visible = true;
                    lblTheEnd.Enabled = true;
                    lblTheEnd.Visible = true;
                    // Removes background image
                    this.BackgroundImage = null;
                    break;
            }
        }

        private void lblReturnToMenu_Click(object sender, EventArgs e)
        {
            // Displays a message box to assure user that the program acknowledged that they clicked "Return to Menu" (Depending on their computer, it may take longer or shorter)
            MessageBox.Show("You will be returned to the menu in a moment - if you do not see the menu pop up when the program disappears, look at your taskbar.");
            // Returns to menu
            Application.Restart();
        }
    }
}
