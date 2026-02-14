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
    public partial class Ending2 : Form
    {
        // Declares a variable
        int count = 0;
        public Ending2()
        {
            InitializeComponent();

            // Plays music box
            SoundPlayer musicBox = new SoundPlayer(Properties.Resources.musicbox);
            musicBox.PlayLooping();
        }

        private void pbArrow_Click(object sender, EventArgs e)
        {
            // Increments count
            ++count;

            // Displays text regarding events related to the ending & changes background color based on value of count - the larger the value of count is, the darker the color
            switch(count)
            {
                case 1:
                    lblOManSpeech.Text = "The familiar face dashed through the rooms as if he too knew how to prevent intruders from coming in.";
                    this.BackColor = Color.Gainsboro;
                    break;
                case 2:
                    lblOManSpeech.Text = "And everytime the old man came across him, the familiar face knew where to hide.";
                    this.BackColor = Color.LightGray;
                    break;
                case 3:
                    lblOManSpeech.Text = "For so long this continued, the familiar face always out of his reach.";
                    this.BackColor = Color.Silver;
                    break;
                case 4:
                    lblOManSpeech.Text = "Until the old man hid behind a door and caught the familiar face off guard, swiftly taking care of the supposed intruder.";
                    this.BackColor = Color.DarkGray;
                    break;
                case 5:
                    lblOManSpeech.Text = "Yet as the familiar face lay motionless, the old man realized this was no intruder.";
                    this.BackColor = Color.Gray;
                    break;
                case 6:
                    lblOManSpeech.Text = "This was a person trapped like him thus a deep sorrow quickly overwhelmed him.";
                    this.BackColor = Color.DimGray;
                    break;
                case 7:
                    lblOManSpeech.Text = "Perhaps even more shocking and heartwrenching for the old man was that the familiar face was his own.";
                    this.BackColor = Color.Black;
                    break;
                case 8:
                    lblOManSpeech.Text = ""; // Removes the text of the label
                    // Disables arrow
                    pbArrow.Visible = false;
                    pbArrow.Enabled = false;
                    // Enables label that displays "The End" and label that allows user to return to menu
                    lblEnd.Visible = true;
                    lblEnd.Enabled = true;
                    lblReturn.Visible = true;
                    lblReturn.Enabled = true;
                    break;
            }
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            // Displays a message box to assure user that the program acknowledged that they clicked "Return to Menu" (Depending on their computer, it may take longer or shorter)
            MessageBox.Show("You will be returned to the menu in a moment - if you do not see the menu pop up when the program disappears, look at your taskbar.");
            // Returns user to menu
            Application.Restart();
        }
    }
}
