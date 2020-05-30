using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameofLife
{
    public partial class Form1 : Form
    {
        // Starting values
        // Keeps track of amount of step for current sim.
        private int timestep = 0;
        // Width of the simulation in cells.
        static private int width = 100;
        // Height of the simulation in cells.
        static private int height = 50;
        // Interval between simulation steps.
        private int interval = 1;
        // Bitmap that gets used as the pictureBox image.
        private Bitmap bmp;
        // Amount of alive cells to spawn when generating sim.
        private int alivePercentage = 50;

        public Form1()
        {
            InitializeComponent();
            random_bitmap();
            pictureboxInterpolation1.Image = bmp;
        }

        /// <summary>
        /// Changes the text to string s for the startButton. Also stops and pauses timer.
        /// </summary>
        /// <param name="s">Startbutton text, "Start" or "Pause" for example.</param>
        /// <param name="timer">Timer status, either false or true.</param>
        private void change_startButton_text(string s, bool timer)
        {
            timer1.Enabled = timer;
            startButton.Text = s;
        }

        /// <summary>
        /// On click method for startButton.
        /// Switches between paused and resumed state.
        /// </summary>
        private void startButton_Click(object sender, EventArgs e)
        {
            // Resume the simulation
            if (startButton.Text.Equals("Start"))
            {
                change_startButton_text("Pause", true);
                timer1.Interval = interval;
            }
            else
            // Pause the simulation
            {
                change_startButton_text("Start", false);
            }
        }

        /// <summary>
        /// Stops the timer, resets timestep and creates a new bitmap.
        /// </summary>
        private void reset_sim()
        {
            timer1.Enabled = false;
            timestep = 0;
            timestepText.Text = "Timestep: " + timestep.ToString();
            if (startButton.Text.Equals("Pause"))
            {
                change_startButton_text("Start", false);
            }
            random_bitmap();
            pictureboxInterpolation1.Image = bmp;
        }

        /// <summary>
        /// On click method for resetButton.
        /// </summary>
        private void resetButton_Click(object sender, EventArgs e)
        {
            reset_sim();
        }

        /// <summary>
        /// Check if a pixel is alive or dead based on its colour.
        /// </summary>
        /// <param name="color">Color value of a pixel.</param>
        /// <returns>Returns 1 if alive, 0 if dead.</returns>
        private int color_to_int(Color color)
        {
            if (color.ToArgb() == Color.Black.ToArgb())
            {
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// Sums the alive cells for Moore's neighbourhood.
        /// </summary>
        /// <param name="x">x position of cell requesting neighbour sum.</param>
        /// <param name="y">y position of cell requesting neighbour sum.</param>
        /// <returns>Amount of living cells in neighbourhood using Moore's neighbourhood.</returns>
        private int sum_neighbours(int x, int y)
        {
            int total = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    // Check if this is current cell
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }
                    // Check if we're not looking outside of the boundaries
                    if (x + i < 0 || x + i >= width)
                    {
                        continue;
                    }
                    if (y + j < 0 || y + j >= height)
                    {
                        continue;
                    }
                    total += color_to_int(bmp.GetPixel(x + i, y + j));
                }
            }
            return total;
        }

        /// <summary>
        /// Step the simulation by one.
        /// Places all changes to temporary bitmap that gets copied to main bitmap bmp.
        /// Works using these rules of Conways game of life:
        ///  - A dead cell can be reborn if it has exactly 3 alive neighbours.
        ///  - A living cell will stay alive if it has exactly 2 or 3 neighbours.
        /// If neither rules apply, the cell dies or stays dead.
        /// </summary>
        private void step_sim()
        {
            Bitmap newMap = new Bitmap(width, height);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int cell = color_to_int(bmp.GetPixel(x, y));
                    int neighbours = sum_neighbours(x, y);
                    // If cell is currently dead and can be revived
                    if (cell == 0 && neighbours == 3)
                    {
                        newMap.SetPixel(x, y, Color.Black);
                        continue;
                    }
                    // If cell is currently alive and will live on (either 2 or 3 living neighbours)
                    else if (cell == 1 && (neighbours == 2 || neighbours == 3))
                    {
                        newMap.SetPixel(x, y, Color.Black);
                        continue;
                    }
                    // Cell is either dead and staying dead or dying
                    newMap.SetPixel(x, y, Color.White);
                }
            }
            bmp = (Bitmap)newMap.Clone();
            newMap.Dispose();
        }

        /// <summary>
        /// Creates a random bitmap.
        /// </summary>
        private void random_bitmap()
        {
            if (bmp != null)
            {
                bmp.Dispose();
            }
            bmp = new Bitmap(width, height);
            Random rand = new Random();

            // Loop over all values in the bitmap
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Assign random starting values for now
                    int bit = rand.Next(101);
                    if (bit <= alivePercentage)
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.White);
                    }
                }
            }
        }

        /// <summary>
        /// Timer ticking method, calls the simulation for every tick.
        /// The timstep counter is increased accordingly.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Change the bitmap and assign it to the picturebox
            timestep += 1;
            timestepText.Text = "Timestep: " + timestep.ToString();
            step_sim();
            pictureboxInterpolation1.Image = bmp;
        }

        /// <summary>
        /// Changes the label to match the percentage of alive cells chosen.
        /// </summary>
        private void aliveTrackerbar_Scroll(object sender, EventArgs e)
        {
            cellPercentageLabel.Text = $"Alive cells: {aliveTrackerbar.Value}%";
        }

        /// <summary>
        /// Checks if te string is a valid integer.
        /// Throws a message box with an error telling the user.
        /// </summary>
        /// <param name="input">Input string to sanitize.</param>
        /// <returns>return a value if input equals a valid integer. Else returns -1.</returns>
        private int parse_input(string input, string item)
        {
            int v;
            bool valid = true;
            string caption = $"Invalid input of {item}";
            string message = "";
            if (!int.TryParse(input, out v))
            {
                valid = false;
                message = $"{input} is not recognized as a valid integer.";
            }
            else if (v < 1)
            {
                valid = false;
                message = $"{input} is below the minimum value of 1.";
            }
            if (!valid)
            {
                MessageBox.Show(message, caption);
                return -1;
            }
            return v;
        }

        /// <summary>
        /// Saves the currently entered values for a new simulation.
        /// </summary>
        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            // Parse new height, width values. If invalid, do not change anything.
            int h = parse_input(heightTextbox.Text, "height value");
            int w = parse_input(widthTextbox.Text, "width value");
            int inter = parse_input(interalTextbox.Text, "interval value");
            if (h == -1 || w == -1 || inter == -1)
            {
                return;
            }
            // Reset simulation with new variables.
            width = w;
            height = h;
            interval = inter;
            alivePercentage = aliveTrackerbar.Value;
            reset_sim();
        }
    }
}
