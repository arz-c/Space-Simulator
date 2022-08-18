namespace SpaceSimulator {
    partial class SpaceSimulatorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.frameControlTimer = new System.Windows.Forms.Timer(this.components);
            this.trailControlTimer = new System.Windows.Forms.Timer(this.components);
            this.pauseResumeButton = new System.Windows.Forms.Button();
            this.clearTrailsButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clockFactorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.selectBodyComboBox = new System.Windows.Forms.ComboBox();
            this.massTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.velocityXTextBox = new System.Windows.Forms.TextBox();
            this.velocityYTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.velocityXTrackBar = new System.Windows.Forms.TrackBar();
            this.velocityYTrackBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.velocityPannel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockFactorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityXTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityYTrackBar)).BeginInit();
            this.velocityPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1215, 962);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // frameControlTimer
            // 
            this.frameControlTimer.Enabled = true;
            this.frameControlTimer.Interval = 15;
            this.frameControlTimer.Tick += new System.EventHandler(this.frameControlTimer_Tick);
            // 
            // trailControlTimer
            // 
            this.trailControlTimer.Enabled = true;
            this.trailControlTimer.Interval = 500;
            this.trailControlTimer.Tick += new System.EventHandler(this.trailControlTimer_Tick);
            // 
            // pauseResumeButton
            // 
            this.pauseResumeButton.Location = new System.Drawing.Point(1251, 54);
            this.pauseResumeButton.Name = "pauseResumeButton";
            this.pauseResumeButton.Size = new System.Drawing.Size(204, 36);
            this.pauseResumeButton.TabIndex = 1;
            this.pauseResumeButton.Text = "Pause";
            this.pauseResumeButton.UseVisualStyleBackColor = true;
            this.pauseResumeButton.Click += new System.EventHandler(this.pauseResumeButton_Click);
            // 
            // clearTrailsButton
            // 
            this.clearTrailsButton.Location = new System.Drawing.Point(1251, 96);
            this.clearTrailsButton.Name = "clearTrailsButton";
            this.clearTrailsButton.Size = new System.Drawing.Size(204, 36);
            this.clearTrailsButton.TabIndex = 2;
            this.clearTrailsButton.Text = "Clear Trails";
            this.clearTrailsButton.UseVisualStyleBackColor = true;
            this.clearTrailsButton.Click += new System.EventHandler(this.clearTrailsButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(1251, 138);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(204, 36);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1284, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clock Factor:";
            // 
            // clockFactorNumericUpDown
            // 
            this.clockFactorNumericUpDown.Location = new System.Drawing.Point(1355, 187);
            this.clockFactorNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clockFactorNumericUpDown.Name = "clockFactorNumericUpDown";
            this.clockFactorNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.clockFactorNumericUpDown.TabIndex = 7;
            this.clockFactorNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clockFactorNumericUpDown.ValueChanged += new System.EventHandler(this.clockFactorNumericUpDown_ValueChanged);
            // 
            // selectBodyComboBox
            // 
            this.selectBodyComboBox.FormattingEnabled = true;
            this.selectBodyComboBox.Location = new System.Drawing.Point(1248, 301);
            this.selectBodyComboBox.Name = "selectBodyComboBox";
            this.selectBodyComboBox.Size = new System.Drawing.Size(204, 21);
            this.selectBodyComboBox.TabIndex = 8;
            this.selectBodyComboBox.SelectedIndexChanged += new System.EventHandler(this.selectBodyComboBox_SelectedIndexChanged);
            // 
            // massTrackBar
            // 
            this.massTrackBar.Location = new System.Drawing.Point(1248, 388);
            this.massTrackBar.Name = "massTrackBar";
            this.massTrackBar.Size = new System.Drawing.Size(204, 45);
            this.massTrackBar.TabIndex = 9;
            this.massTrackBar.Scroll += new System.EventHandler(this.massTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1329, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mass:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Velocity:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // velocityXTextBox
            // 
            this.velocityXTextBox.Location = new System.Drawing.Point(0, 34);
            this.velocityXTextBox.Name = "velocityXTextBox";
            this.velocityXTextBox.Size = new System.Drawing.Size(87, 20);
            this.velocityXTextBox.TabIndex = 12;
            this.velocityXTextBox.TextChanged += new System.EventHandler(this.velocityXTextBox_TextChanged);
            // 
            // velocityYTextBox
            // 
            this.velocityYTextBox.Location = new System.Drawing.Point(117, 34);
            this.velocityYTextBox.Name = "velocityYTextBox";
            this.velocityYTextBox.Size = new System.Drawing.Size(87, 20);
            this.velocityYTextBox.TabIndex = 13;
            this.velocityYTextBox.TextChanged += new System.EventHandler(this.velocityYTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "x";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "y";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // massTextBox
            // 
            this.massTextBox.Location = new System.Drawing.Point(1248, 362);
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(204, 20);
            this.massTextBox.TabIndex = 17;
            this.massTextBox.TextChanged += new System.EventHandler(this.massTextBox_TextChanged);
            // 
            // velocityXTrackBar
            // 
            this.velocityXTrackBar.Location = new System.Drawing.Point(0, 60);
            this.velocityXTrackBar.Name = "velocityXTrackBar";
            this.velocityXTrackBar.Size = new System.Drawing.Size(87, 45);
            this.velocityXTrackBar.TabIndex = 18;
            this.velocityXTrackBar.Scroll += new System.EventHandler(this.velocityXTrackBar_Scroll);
            // 
            // velocityYTrackBar
            // 
            this.velocityYTrackBar.Location = new System.Drawing.Point(117, 60);
            this.velocityYTrackBar.Name = "velocityYTrackBar";
            this.velocityYTrackBar.Size = new System.Drawing.Size(87, 45);
            this.velocityYTrackBar.TabIndex = 19;
            this.velocityYTrackBar.Scroll += new System.EventHandler(this.velocityYTrackBar_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1298, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Physical Settings";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1297, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Simulator Settings";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1311, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Select a Body:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // velocityPannel
            // 
            this.velocityPannel.Controls.Add(this.label3);
            this.velocityPannel.Controls.Add(this.velocityXTextBox);
            this.velocityPannel.Controls.Add(this.velocityYTextBox);
            this.velocityPannel.Controls.Add(this.velocityYTrackBar);
            this.velocityPannel.Controls.Add(this.label4);
            this.velocityPannel.Controls.Add(this.velocityXTrackBar);
            this.velocityPannel.Controls.Add(this.label5);
            this.velocityPannel.Location = new System.Drawing.Point(1248, 438);
            this.velocityPannel.Name = "velocityPannel";
            this.velocityPannel.Size = new System.Drawing.Size(204, 106);
            this.velocityPannel.TabIndex = 24;
            this.velocityPannel.Visible = false;
            // 
            // SpaceSimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.velocityPannel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.massTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.massTrackBar);
            this.Controls.Add(this.selectBodyComboBox);
            this.Controls.Add(this.clockFactorNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.clearTrailsButton);
            this.Controls.Add(this.pauseResumeButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "SpaceSimulatorForm";
            this.Text = "Space Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockFactorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityXTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityYTrackBar)).EndInit();
            this.velocityPannel.ResumeLayout(false);
            this.velocityPannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer frameControlTimer;
        private System.Windows.Forms.Timer trailControlTimer;
        private System.Windows.Forms.Button pauseResumeButton;
        private System.Windows.Forms.Button clearTrailsButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown clockFactorNumericUpDown;
        private System.Windows.Forms.ComboBox selectBodyComboBox;
        private System.Windows.Forms.TrackBar massTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox velocityXTextBox;
        private System.Windows.Forms.TextBox velocityYTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox massTextBox;
        private System.Windows.Forms.TrackBar velocityXTrackBar;
        private System.Windows.Forms.TrackBar velocityYTrackBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel velocityPannel;
    }
}

