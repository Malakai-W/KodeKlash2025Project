using Intrusion.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intrusion
{
    public partial class Intruders : Form
    {
        // Declares variable to be passed to GameOver form
        public static char Cause {  get; set; }

        // Declares variables and objects from various classes - Objects are declared here as multiple methods may use some of them & because if included inside a timer, it would essentially
        // prevent values from being updated as it would keep creating new objects (which would look like as if it's overwriting the values)
        int rooms = 0;
        double gameSeconds = 0;
        OldMan oldMan = new OldMan();
        FrontDoor fDoor = new FrontDoor();
        Gremlin gremlin = new Gremlin();
        bool hide = false;
        public Intruders()
        {
            InitializeComponent();

            // Sets KeyPreview to true so that the form is able to check if a user presses Q
            this.KeyPreview = true;

            // Declares constant
            const int MINUTE = 60;

            // Assigns amount of time player has until games ends based off difficulty
            gameSeconds = MINUTE * Start.Difficulty;

        }
        #region Arrows
        private void pbArrowUp_Click(object sender, EventArgs e)
        {
            // User moved forward

            // Plays walk sound
            PlayWalkSound();

            // Checks if rooms value corresponds to old man's location
            if (rooms == oldMan.Location)
            {
                // Calls GameOver method and passes value to it to signal the cause of death
                GameOver('O');
            }
            else
            {
                // Checks value of rooms variable and updates value accordingly
                switch (rooms)
                {
                    case 0:
                        ++rooms;
                        break;
                    case 2:
                        ++rooms;
                        // Calls method for chance of old man encounter
                        OldManChance();
                        break;
                    default:
                        /* Checks that rooms is 3 or 4 - even though up arrow should only be enabled if its 3 or 4 if it reaches the default case,
                        this is done to ensure that no bugs that may have been overlooked when finalized will occur */
                        if (rooms == 3 || rooms == 4)
                        {
                            // Checks if player is hiding or not, sets boolean to opposite of what it currently is
                            if (hide)
                                hide = false;
                            else
                                hide = true;
                        }
                        break;
                }


                // Calls methods to display room
                DisplayRoom();
            }
        }

        private void pbArrowRight_Click(object sender, EventArgs e)
        {
            // User moved right

            // Checks value of rooms variable and updates value accordingly
            switch (rooms)
            {
                case 1:
                    --rooms;
                    // Checks if gremlinChase is true - if gremlin chase is ongoing - player is moving to safe-room (rooms = 0) which would end the chase
                    if(gremlin.Chase)
                    {
                        // Sets gremlinChase to false
                        gremlin.Chase = false;

                        // Resets variables concerning timerGremlin such as gremlin's seconds, time, and location
                        gremlin.Seconds = -1;
                        gremlin.Time = -1;
                        gremlin.Location = -1;
                    }
                    break;
                case 2:
                    rooms = 4;
                    // Calls method for chance of old man encounter
                    OldManChance();
                    break;

            }

            // Calls methods to display room and play a walk sound
            DisplayRoom();
            PlayWalkSound();
        }

        private void pbArrowDown_Click(object sender, EventArgs e)
        {
            // User moved back

            // Checks value of rooms variable and updates value accordingly
            switch (rooms)
            {
                case 2:
                    --rooms;
                    break;
                case 3:
                    --rooms;
                    break;
                case 4:
                    rooms = 2;
                    // Calls method for chance of old man encounter
                    OldManChance();
                    break;
                case 5:
                    rooms = 2;
                    // Calls method for chance of old man encounter
                    OldManChance();
                    break;
            }

            // Calls methods to display room and play a walk sound
            DisplayRoom();
            PlayWalkSound();
        }

        private void pbArrowLeft_Click(object sender, EventArgs e)
        {
            // User moved left

            // Checks value of rooms variable and updates value accordingly
            switch (rooms)
            {
                case 1:
                    ++rooms;
                    // Calls method for chance of old man encounter
                    OldManChance();
                    break;
                case 2:
                    rooms = 5;
                    break;
            }

            // Calls methods to display room and play a walk sound
            DisplayRoom();
            PlayWalkSound();
        }
        #endregion Arrows
        #region Methods
        private void DisplayRoom()
        {
            // Checks value of rooms, displays corresponding room and enables/disables arrows corresponding to certain rooms
            switch (rooms)
            {
                case 0:
                    BackgroundImage = (Image)Resources.SafeRoom;
                    DisableLeftArrow();
                    DisableRightArrow();
                    EnableUpArrow();
                    break;
                case 1:
                    DisableUpArrow();
                    DisableDownArrow();
                    EnableLeftArrow();
                    // Checks if gremlin location corresponds with room value - displays corresponding background image
                    if (gremlin.Location == rooms)
                    {
                        BackgroundImage = (Image)Resources.Room1Gremlin;
                        // Disables right arrow and enables picture box for getting rid of gremlin
                        DisableRightArrow();
                        EnableFlashlight();
                    }
                    else
                    {
                        BackgroundImage = (Image)Resources.Room1;
                        EnableRightArrow();
                    }
                    break;
                case 2:
                    EnableUpArrow();
                    EnableRightArrow();
                    EnableLeftArrow();
                    EnableDownArrow();
                    DisableFlashlight(); // Disabled in case user moves away from room where gremlin is located
                    pbCloseDoor.Enabled = false; // Disabled in case user backs away from slightly opened door
                    // Checks if old man's location corresponds with rooms value; displays room with old man if so otherwise displays room as normally
                    if (oldMan.Location == rooms)
                        BackgroundImage = (Image)Resources.HallwayOldMan;
                    else
                        BackgroundImage = (Image)Resources.Hallway;
                    break;
                case 3:
                    // Checks if player is hiding and displays corresponding image
                    if (hide)
                    {
                        BackgroundImage = (Image)Resources.Room2Hide;
                        DisableDownArrow();
                    }
                    else
                    {
                        DisableLeftArrow();
                        DisableRightArrow();
                        EnableDownArrow();
                        // Checks if gremlin or old man's location corresponds with rooms value; displays the corresponding image
                        if (oldMan.Location == rooms)
                            BackgroundImage = (Image)Resources.Room2OldMan;
                        else if (gremlin.Location == rooms)
                        {
                            BackgroundImage = (Image)Resources.Room2Gremlin;
                            // Disables forward arrow and enables picture box for getting rid of gremlin
                            DisableUpArrow();
                            EnableFlashlight();
                        }
                        else
                            BackgroundImage = (Image)Resources.Room2;
                    }
                    break;
                case 4:
                    // Checks if player is hiding and displays corresponding image
                    if (hide)
                    {
                        BackgroundImage = (Image)Resources.Room3Hide;
                        DisableDownArrow();
                    }
                    else
                    {
                        DisableLeftArrow();
                        DisableRightArrow();
                        EnableDownArrow();
                        // Checks if gremlin or old man's location corresponds with rooms value; displays the corresponding image
                        if (oldMan.Location == rooms)
                            BackgroundImage = (Image)Resources.Room3OldMan;
                        else if (gremlin.Location == rooms)
                        {
                            BackgroundImage = (Image)Resources.Room3Gremlin;
                            // Disables forward arrow and enables picture box for getting rid of gremlin
                            DisableUpArrow();
                            EnableFlashlight();
                        }
                        else
                            BackgroundImage = (Image)Resources.Room3;
                    }
                    break;
                case 5:
                    DisableLeftArrow();
                    DisableRightArrow();
                    DisableUpArrow();
                    // Checks if front door is open - displays corresponding image based on whether it is or isn't
                    if (fDoor.TimeTillOpen == -1)
                    {
                        BackgroundImage = (Image)Resources.FrontDoorSlightlyOpened;
                        // Enables invisible picture box concerning close front door
                        pbCloseDoor.Enabled = true;
                    }
                    else
                        BackgroundImage = (Image)Resources.FrontDoor;
                    break;
                default:
                    // Displays message & closes application in the event that this bug somehow occurs (likely and hopefully won't)
                    MessageBox.Show("ERROR: Variable called rooms contained a value outside of the range 0 to 5. Programmers should refer to Arrows region and DisplayRoom method");
                    Application.Exit();
                    break;
            }


        }
        private void OldManChance()
        {
            // Method that decides whether or not player encounters old man

            // Checks if timer for old man's encounter is disabled
            if (timerOldMan.Enabled == false)
            {
                // Randomly generates number
                Random rando = new Random();
                int encounter = rando.Next(1, 5);

                // Checks if encounter is equal to value of difficulty and that gremlin's location won't be the same as old man's location
                if (encounter == Start.Difficulty && gremlin.Location != rooms)
                {
                    // Sets old man's location to value corresponding to room
                    oldMan.Location = rooms;
                    // Randomly generates amount of seconds player has to hide
                    oldMan.Time = rando.Next(4, 10 - Start.Difficulty);
                    // Checks if old man's location is in the hallway & if gremlin is in the room behind; also checks if there isn't enough time to find gremlin if so
                    // or if gremlin has essentially just appeared (this part is included to prevent the player from accidentally running right into the old man while bell is playing)
                    if ((oldMan.Location == 2 && gremlin.Location == 3 && ((gremlin.Time - gremlin.Seconds) - oldMan.Time) < 4) || (gremlin.Location != -1 && gremlin.Seconds == 0))
                    {
                        // Resets variables regarding old man
                        oldMan.Location = -1;
                        oldMan.Time = -1;
                    }
                    else
                    {
                        // Enables timer for old man's encounter
                        timerOldMan.Enabled = true;
                    }
                }
            }


        }
        private void GameOver(char causeOfDeath)
        {
            // Calls method to disable timers
            DisableTimers();

            // Sets Cause's value to the value passed into method into causeOfDeath
            Cause = causeOfDeath;

            // Shows GameOver form
            GameOver gOver = new GameOver();
            gOver.Show();

            // Closes this form
            this.Close();
        }
        private void EnableFlashlight()
        {
            // Method to enable flashlight picturebox and make it visible
            pbFlashlight.Enabled = true;
            pbFlashlight.Visible = true;
        }
        private void DisableFlashlight()
        {
            // Method to disable flashlight picture and make it not visible
            pbFlashlight.Enabled = false;
            pbFlashlight.Visible = false;
        }
        private void EnableUpArrow()
        {
            pbArrowUp.Visible = true;
            pbArrowUp.Enabled = true;
        }
        private void EnableDownArrow()
        {
            pbArrowDown.Visible = true;
            pbArrowDown.Enabled = true;
        }
        private void EnableLeftArrow()
        {
            pbArrowLeft.Visible = true;
            pbArrowLeft.Enabled = true;
        }
        private void EnableRightArrow()
        {
            pbArrowRight.Visible = true;
            pbArrowRight.Enabled = true;
        }
        private void DisableUpArrow()
        {
            pbArrowUp.Visible = false;
            pbArrowUp.Enabled = false;
        }
        private void DisableDownArrow()
        {
            pbArrowDown.Visible = false;
            pbArrowDown.Enabled = false;
        }
        private void DisableLeftArrow()
        {
            pbArrowLeft.Visible = false;
            pbArrowLeft.Enabled = false;
        }
        private void DisableRightArrow()
        {
            pbArrowRight.Visible = false;
            pbArrowRight.Enabled = false;
        }
        private void PlayWalkSound()
        {
            // Initiliazes soundplayer to play walking sound
            SoundPlayer walk = new SoundPlayer(Properties.Resources.WoodCreak);
            walk.Play();
        }
        private void DisableTimers()
        {
            // Disables all timers
            timerFrontDoor.Enabled = false;
            timerFrontDoor.Stop();
            timerGremlin.Enabled = false;
            timerGremlin.Stop();
            timerOldMan.Enabled = false;
            timerOldMan.Stop();
        }
        #endregion
        #region Timers
        private void timerOldMan_Tick(object sender, EventArgs e)
        {
            // Incremements seconds
            ++oldMan.Seconds;

            // Checks if seconds match value of amount of time given to player to hide
            if (oldMan.Seconds == oldMan.Time)
            {
                // Checks if player is hiding
                if (hide)
                {
                    // Creates soundplayer to play sound to indicate that player is safe
                    SoundPlayer oldManGone = new SoundPlayer(Properties.Resources.Clack);
                    oldManGone.Play();

                    // Sets seconds to 0, old man's location and time to -1
                    oldMan.Seconds = 0;
                    oldMan.Location = -1;
                    oldMan.Time = -1;
                }
                else
                {
                    // Calls GameOver method and passes value to it to signal the cause of death
                    GameOver('O');
                }
                // Disables timer
                timerOldMan.Enabled = false;
            }
        }
        

        private void timerFrontDoor_Tick(object sender, EventArgs e)
        {
            // Checks that front door isn't already opened
            if (fDoor.Seconds == -1)
            {
                // Randomly generates amount of seconds
                Random rando = new Random();
                fDoor.TimeTillOpen = rando.Next(8 - Start.Difficulty, 12);

                // Increments fDoorSeconds
                ++fDoor.Seconds;
            }
            else
            {
                // Increments fDoorSeconds
                ++fDoor.Seconds;
                
                // Checks if seconds has reached the number of seconds for opening door
                if (fDoor.Seconds == fDoor.TimeTillOpen)
                {
                    // Sets seconds to 0
                    fDoor.Seconds = 0;

                    // Sets fDoorTimeTillOpen to -1
                    fDoor.TimeTillOpen = -1;

                    // Checks if player is currently facing front door to switch to corresponding image
                    if (rooms == 5)
                    {
                        DisplayRoom();

                        // Plays an open door sound
                        SoundPlayer doorOpens = new SoundPlayer(Properties.Resources.OpenDoor);
                        doorOpens.Play();
                    }
                }
                else if(fDoor.Seconds > fDoor.TimeTillOpen) // Checks if seconds passed time till open (front door is open)
                {
                    // Checks if seconds has reached amount of time that the door is allowed to be open for
                    if (fDoor.Seconds == fDoor.Time)
                    {
                        // Calls GameOver method and passes value to it to signal the cause of death
                        GameOver('F');
                    }
                }
            }

        }
        private void timerGremlin_Tick(object sender, EventArgs e)
        {
            // Checks if seconds is -1 (Time till gremlin hasn't been generated yet)
            if (gremlin.Seconds == -1)
            {
                // Randomly generates seconds until gremlin appears
                Random rando = new Random();
                gremlin.Time = rando.Next(7 - Start.Difficulty, 15 - Start.Difficulty);

                // Increments seconds
                ++gremlin.Seconds;
            }
            else if (gremlin.Location == -1) // Checks if gremlin hasn't been assigned a room value yet
            {
                // Increments seconds
                ++gremlin.Seconds;

                // Checks if seconds match amount of time till gremlin appears
                if (gremlin.Seconds == gremlin.Time)
                {
                    // Sets seconds to 0
                    gremlin.Seconds = 0;

                    // Randomly generates value to determine which room gremlin will be in
                    Random rando = new Random();
                    int rLocation = rando.Next(1, 4);

                    // Determines which room gremlin will be in based off value
                    switch (rLocation)
                    {
                        case 1:
                            // Checks if user is in safe spot
                            if (rooms == 0)
                                gremlin.Seconds = gremlin.Time - 1; // Next tick will go through this section again to randomize location
                            else
                                gremlin.Location = rLocation;
                            break;
                        case 2:
                            // Checks if value of rooms is 4 and if user is hiding in it OR if old man is already occupying room
                            if ((rooms == 4 && hide) || (oldMan.Location == 4))
                                gremlin.Seconds = gremlin.Time - 1; // Next tick will go through this section again to randomize location
                            else
                                gremlin.Location = 4;

                            break;
                        case 3:
                            // Checks if rLocation has the same value of room that user is in and if they're hiding in it OR if old man is already occupying room
                            if ((rLocation == rooms && hide) || (oldMan.Location == rLocation))
                                gremlin.Seconds = gremlin.Time - 1; // Next tick will go through this section again to randomize location
                            else
                                gremlin.Location = rLocation;
                            break;
                    }

                    // Checks if gremlinLocation is no longer -1 (default value)
                    if (gremlin.Location != -1)
                    {
                        // Sets amount of time player has to find gremlin (and also subtracts by value of difficulty)
                        gremlin.Time = 13 - Start.Difficulty;

                        // Checks if gremlin and user are in the same room
                        if (rooms == gremlin.Location)
                            DisplayRoom();

                        // Plays sound
                        SoundPlayer bell = new SoundPlayer(Properties.Resources.Bell);
                        bell.PlaySync();
                    }
                }
            }
            else
            {
                // Increments seconds
                ++gremlin.Seconds;

                // Checks if player ran out of time
                if (gremlin.Time == gremlin.Seconds)
                {
                    // Checks if user fell victim to gremlin during chase --- G refers to gremlin chase while g refers to not finding gremlin
                    if (gremlin.Chase)
                    {
                        // Calls GameOver method and passes value to it to signal the cause of death
                        GameOver('G');
                    }
                    else
                    {
                        // Calls GameOver method and passes value to it to signal the cause of death
                        GameOver('g');
                    }
                }
            }
        }
        private void timerGameEnds_Tick(object sender, EventArgs e)
        {
            // Timer for decrementing until the game ends

            // Decrements gameSeconds
            --gameSeconds;

            // Displays seconds left until game ends
            lblSeconds.Text = gameSeconds.ToString();


            // Checks if game is over - if gameSeconds has finally decremented to 0
            if (gameSeconds == 0)
            {
                // Calls method
                DisableTimers();

                // Checks which difficulty player played on to show the corresponding ending (corresponding form) and closes this form
                switch (Start.Difficulty)
                {
                    case 1:
                        Ending1 ending1 = new Ending1();
                        this.Close();
                        ending1.Show();
                        break;
                    case 2:
                        Ending2 ending2 = new Ending2();
                        this.Close();
                        ending2.Show();
                        break;
                }

                // Disables itself (Note to person reading this; timers in visual studio can behave weirdly and unexpectly so this prevents it from unnecessarily going for another tick
                timerGameEnds.Enabled = false;
            }
        }
        #endregion
        private void pbCloseDoor_Click(object sender, EventArgs e)
        {
            // Sets front door's seconds and time till open to default values, -1 and 0 respectively
            fDoor.Seconds = -1;
            fDoor.TimeTillOpen = 0;

            // Calls method to display room's corresponding image regarding front door no longer being open & plays sound
            DisplayRoom();
            SoundPlayer closeDoor = new SoundPlayer(Properties.Resources.CloseDoor);
            closeDoor.Play();

            // Disables itself
            pbCloseDoor.Enabled = false;

        }

        

        private void pbFlashlight_Click(object sender, EventArgs e)
        {
            // Picturebox clicked by player to get rid of gremlin

            // Plays flashlight sound
            SoundPlayer flashlightTurnOn = new SoundPlayer(Properties.Resources.flashlightOnOff);
            flashlightTurnOn.Play();

            // Checks that gremlin's Chase boolean is false - that gremlin isn't already chasing player
            if(!gremlin.Chase)
            {
                // Declares variable
                int chaseChance = 0;

                // Checks if difficulty's value is 2 (player is on challenge) & that player is not in room 1, and assigns a random value to chase variable if so
                if (Start.Difficulty == 2 && rooms != 1)
                {
                    Random rando = new Random();
                    chaseChance = rando.Next(1, 4);
                }

                // Checks if chaseChance equals value of difficulty (1 in 3 chance - if difficulty is 1, chase will still be 0 as it only assigns random value if difficulty's value is 2
                if (chaseChance == Start.Difficulty)
                {
                    // Sets gremlinChase boolean to true
                    gremlin.Chase = true;

                    // Resets gremlin's seconds to 0 and sets time to 5 (the amount of time player has to reach the safe-room)
                    gremlin.Seconds = 0;
                    gremlin.Time = 5;
                    

                    // Checks if player needs to hide from old man and gives extra seconds if so
                    if (oldMan.Location != -1)
                        oldMan.Time += 4;
                }
                else
                {
                    // Resets variables concerning timerGremlin such as gremlin's seconds, time, and location
                    gremlin.Seconds = -1;
                    gremlin.Time = -1;
                    gremlin.Location = -1;

                    // Calls method to display room without gremlin
                    DisplayRoom();

                    // Checks if user was in a room where they could hide
                    if (rooms == 3 || rooms == 4)
                        EnableUpArrow();

                    // Disables flaslight
                    DisableFlashlight();
                }
            }
        }

        

        private void Intruders_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Checks if user pressed Q (more-so makes sure they pressed shift + q to make sure they intentionally pressed it) to return to menu
            if(e.KeyChar == 'Q')
            {
                // Disables timers
                DisableTimers();
                timerGameEnds.Enabled = false;

                // Displays a message box to assure user that the program acknowledged that they clicked "Return to Menu" (Depending on their computer, it may take longer or shorter)
                MessageBox.Show("You will be returned to the menu in a moment - if you do not see the menu pop up when the program disappears, look at your taskbar.");
                // Returns to menu by restarting application
                Application.Restart();
            }
        }
    }
    #region Classes
    // Classes containing values for each enemy
    class OldMan
    {
        private int time = -1;
        private int seconds = 0;
        private int location = -1;
        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        public int Location
        {
            get { return location; }
            set { location = value; }
        }
    }
    class FrontDoor
    {
        private int time;
        private int seconds = -1;
        private int timeTillOpen;
        public int Time
        {
            get { return time; }
            set { time = 19 - Start.Difficulty; }
        }
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        public int TimeTillOpen
        {
            get { return timeTillOpen; }
            set { timeTillOpen = value; }
        }
    }
    class Gremlin
    {
        private int time;
        private int seconds = -1;
        private int location = -1;
        private bool chase = false;
        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        public int Location
        {
            get { return location; }
            set { location = value; }
        }
        public bool Chase
        {
            get { return chase; }
            set { chase = value; }
        }
    }
    #endregion
}
