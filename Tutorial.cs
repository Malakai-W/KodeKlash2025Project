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
    
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();

            // Plays sound
            SoundPlayer papersound = new SoundPlayer(Properties.Resources.paper_rustle);
            papersound.Play();

            // Displays amount of time user has to survive for
            lblTime.Text = "Fend off intruders for " + Start.Difficulty + " minute(s)";
            // Checks if difficulty player chose was Challenge
            if(Start.Difficulty == 2)
            {
                // Makes label regarding extra mechanic to evade gremlin visible
                lblExtraMechanic.Visible = true;
            }

        }

        private void pbArrow_Click(object sender, EventArgs e)
        {
            // Starts the game - shows Intruders form
            Intruders intruders = new Intruders();
            this.Close();
            intruders.Show();
        }
    }
}
