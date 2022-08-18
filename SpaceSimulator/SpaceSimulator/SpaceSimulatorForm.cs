using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace SpaceSimulator {
    public partial class SpaceSimulatorForm : Form {
        #region Constants

        public const float G = 6.67430E-11F;
        public const int AU = 200;
        public static int CENTER_X;
        public static int CENTER_Y;

        private const float TRACKBAR_MARGIN = 0.5F; // x(1 ± 'TRACKBAR_MARGIN')
        private const float TRACKBAR_STEP = 0.1F;
        private static int TRAIL_BASE_TIMER_INTERVAL;

        #endregion

        #region Properties

        public RigidBody selectedBody;

        private List<RigidBody> environment;

        private int clockFactor = 1;
        private float normalizedTrackBarStep = TRACKBAR_STEP * 100;

        #endregion

        #region Constructor

        public SpaceSimulatorForm() {
            InitializeComponent();

            CENTER_X = pictureBox.Width / 2;
            CENTER_Y = pictureBox.Height / 2;
            TRAIL_BASE_TIMER_INTERVAL = trailControlTimer.Interval;

            Restart();
        }

        #endregion

        #region Methods

        public void Restart() {
            environment = new List<RigidBody>();

            // Sun

            RigidBody sun = new RigidBody();

            environment.Add(sun);
            sun.Environment = environment;

            sun.Name = "Sun";
            sun.Position = new Vector2(CENTER_X, CENTER_Y);
            sun.Radius = 50;
            sun.Colour = Color.Yellow;

            sun.Mass = 200 * (float) Math.Pow(50, 2) / G;
            sun.Velocity = new Vector2(0, 0);

            // Earth

            RigidBody earth = new RigidBody();

            environment.Add(earth);
            earth.Environment = environment;

            earth.Name = "Earth";
            earth.Position = new Vector2(CENTER_X, CENTER_Y - 1 * AU);
            earth.Radius = 20;
            earth.Colour = Color.Blue;

            earth.Mass = 1;
            earth.Velocity = new Vector2(50, 0);

            // Moon

            RigidBody moon = new RigidBody();

            environment.Add(moon);
            moon.Environment = environment;

            moon.Name = "Moon";
            moon.Position = new Vector2(CENTER_X, CENTER_Y - 250);
            moon.Radius = 8;
            moon.Colour = Color.Gray;

            moon.Mass = 10E-10F;
            moon.Velocity = new Vector2(50, 0);

            /*// Mercury

            RigidBody mercury = new RigidBody();

            environment.Add(mercury);
            mercury.Environment = environment;

            mercury.Name = "Mercury";
            mercury.Position = new Vector2(CENTER_X, CENTER_Y - 100);
            mercury.Radius = 15;
            mercury.Color = Color.Brown;

            mercury.Mass = earth.Mass / 10;
            mercury.Velocity = new Vector2(70, 0);*/

            // Adding all body names to 'selectedBodyComboBox'
            selectBodyComboBox.Items.Clear(); // To avoid item duplication during restart
            foreach(RigidBody rb in environment) {
                selectBodyComboBox.Items.Add(rb.Name);
            }

            // In case a body was selected before restart, update the references
            selectBodyComboBox.ResetText();
            selectBodyComboBox.SelectedIndex = -1;
            UpdatePhysicalSettingControls();
        }

        private void ResetTrackBar(TrackBar trackBar) {
            trackBar.Minimum = (int) Math.Round((1 - TRACKBAR_MARGIN) * normalizedTrackBarStep);
            trackBar.Maximum = (int) Math.Round((1 + TRACKBAR_MARGIN) * normalizedTrackBarStep);
            trackBar.Value = (int) Math.Round(1 * normalizedTrackBarStep);
        }

        private void UpdatePhysicalSettingControls() {
            if(selectBodyComboBox.SelectedIndex != -1) { // Is -1 following a restart
                // Update selected body
                selectedBody = environment[selectBodyComboBox.SelectedIndex];

                // Update textboxes
                massTextBox.Text = selectedBody.Mass.ToString();
                velocityXTextBox.Text = selectedBody.Velocity.X.ToString();
                velocityYTextBox.Text = selectedBody.Velocity.Y.ToString();
            } else {
                // Nullify selected body
                selectedBody = null;

                // Nullify textboxes
                massTextBox.Text = "";
                velocityXTextBox.Text = "";
                velocityYTextBox.Text = "";
            }

            // Always reset trackbars
            ResetTrackBar(massTrackBar);
            ResetTrackBar(velocityXTrackBar);
            ResetTrackBar(velocityYTrackBar);
        }

        #endregion

        #region Event Handlers

        private void pictureBox_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;

            g.Clear(Color.Black); // Black background

            foreach(RigidBody rb in environment) {
                rb.Update((float) frameControlTimer.Interval / 1000 * clockFactor);
            }

            foreach(RigidBody rb in environment) {
                rb.Draw(g);
            }
        }

        private void frameControlTimer_Tick(object sender, EventArgs e) {
            pictureBox.Refresh();
        }

        private void trailControlTimer_Tick(object sender, EventArgs e) {
            foreach(RigidBody rb in environment) {
                rb.PingTrail();
            }
        }
        private void pauseResumeButton_Click(object sender, EventArgs e) {
            if(frameControlTimer.Enabled) {
                // Pause timers
                frameControlTimer.Enabled = false;
                trailControlTimer.Enabled = false;

                // Enable velocity settings if applicable
                velocityPannel.Visible = true;

                // Update button text
                pauseResumeButton.Text = "Resume";
            } else {
                // Resume timers
                frameControlTimer.Enabled = true;
                trailControlTimer.Enabled = true;

                // Disable velocity settings
                velocityPannel.Visible = false;

                // Update button text
                pauseResumeButton.Text = "Pause";
            }
        }

        private void clearTrailsButton_Click(object sender, EventArgs e) {
            foreach(RigidBody rb in environment) {
                rb.ClearTrail();
            }
        }

        private void restartButton_Click(object sender, EventArgs e) {
            Restart();
            pictureBox.Refresh();
        }

        private void clockFactorNumericUpDown_ValueChanged(object sender, EventArgs e) {
            clockFactor = (int) clockFactorNumericUpDown.Value;
            if(trailControlTimer.Interval / clockFactor > 0)
                trailControlTimer.Interval = TRAIL_BASE_TIMER_INTERVAL / clockFactor;
        }

        private void selectBodyComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            UpdatePhysicalSettingControls();
        }

        private void massTextBox_TextChanged(object sender, EventArgs e) {
            if(massTextBox.Modified) { // Only if the change was by the user
                // Set mass to textbox's value
                if(float.TryParse(massTextBox.Text, out float result))
                    selectedBody.Mass = result;

                // Correct for trackbar
                ResetTrackBar(massTrackBar);
            }
        }

        private void massTrackBar_Scroll(object sender, EventArgs e) {
            // Set mass to trackbar's value
            selectedBody.Mass *= massTrackBar.Value / normalizedTrackBarStep;

            // Correct for textbox
            massTextBox.Text = selectedBody.Mass.ToString();
        }

        private void velocityXTextBox_TextChanged(object sender, EventArgs e) {
            if(velocityXTextBox.Modified) { // Only if the change was by the user
                // Set velocity to textbox's value
                if(float.TryParse(velocityXTextBox.Text, out float result))
                    selectedBody.Velocity = new Vector2(result, selectedBody.Velocity.Y);

                // Correct for trackbar
                ResetTrackBar(velocityXTrackBar);
            }
        }

        private void velocityXTrackBar_Scroll(object sender, EventArgs e) {
            // Set velocity to trackbar's value
            selectedBody.Velocity = new Vector2(
                selectedBody.Velocity.X * (velocityXTrackBar.Value / normalizedTrackBarStep),
                selectedBody.Velocity.Y
            );

            // Correct for textbox
            velocityXTextBox.Text = selectedBody.Velocity.X.ToString();
        }

        private void velocityYTextBox_TextChanged(object sender, EventArgs e) {
            if(velocityYTextBox.Modified) { // Only if the change was by the user
                // Set velocity to textbox's value
                if(float.TryParse(velocityYTextBox.Text, out float result))
                    selectedBody.Velocity = new Vector2(selectedBody.Velocity.X, result);

                // Correct for trackbar
                ResetTrackBar(velocityYTrackBar);
            }
        }

        private void velocityYTrackBar_Scroll(object sender, EventArgs e) {
            // Set velocity to trackbar's value
            selectedBody.Velocity = new Vector2(
                selectedBody.Velocity.X,
                selectedBody.Velocity.Y * (velocityYTrackBar.Value / normalizedTrackBarStep)
            );

            // Correct for textbox
            velocityYTextBox.Text = selectedBody.Velocity.Y.ToString();
        }

        #endregion
    }
}
