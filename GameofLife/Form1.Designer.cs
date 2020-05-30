namespace GameofLife
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureboxInterpolation1 = new PictureboxInterpolation();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.controlBox = new System.Windows.Forms.GroupBox();
            this.timestepText = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.cellPercentageLabel = new System.Windows.Forms.Label();
            this.aliveTrackerbar = new System.Windows.Forms.TrackBar();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.widthTextbox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.interalTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxInterpolation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.controlBox.SuspendLayout();
            this.settingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aliveTrackerbar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureboxInterpolation1
            // 
            this.pictureboxInterpolation1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureboxInterpolation1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.pictureboxInterpolation1.Location = new System.Drawing.Point(12, 12);
            this.pictureboxInterpolation1.Name = "pictureboxInterpolation1";
            this.pictureboxInterpolation1.Size = new System.Drawing.Size(993, 522);
            this.pictureboxInterpolation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxInterpolation1.TabIndex = 2;
            this.pictureboxInterpolation1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1011, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.controlBox);
            this.splitContainer1.Panel1MinSize = 80;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.settingsBox);
            this.splitContainer1.Size = new System.Drawing.Size(153, 522);
            this.splitContainer1.SplitterDistance = 83;
            this.splitContainer1.TabIndex = 3;
            // 
            // controlBox
            // 
            this.controlBox.AutoSize = true;
            this.controlBox.Controls.Add(this.timestepText);
            this.controlBox.Controls.Add(this.resetButton);
            this.controlBox.Controls.Add(this.startButton);
            this.controlBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlBox.Location = new System.Drawing.Point(0, 0);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(153, 83);
            this.controlBox.TabIndex = 0;
            this.controlBox.TabStop = false;
            this.controlBox.Text = "Controls";
            // 
            // timestepText
            // 
            this.timestepText.AutoSize = true;
            this.timestepText.Location = new System.Drawing.Point(6, 54);
            this.timestepText.Name = "timestepText";
            this.timestepText.Size = new System.Drawing.Size(62, 13);
            this.timestepText.TabIndex = 2;
            this.timestepText.Text = "Timestep: 0";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(74, 19);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(62, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 19);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(62, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // settingsBox
            // 
            this.settingsBox.Controls.Add(this.interalTextbox);
            this.settingsBox.Controls.Add(this.intervalLabel);
            this.settingsBox.Controls.Add(this.saveSettingsButton);
            this.settingsBox.Controls.Add(this.xLabel);
            this.settingsBox.Controls.Add(this.widthTextbox);
            this.settingsBox.Controls.Add(this.heightTextbox);
            this.settingsBox.Controls.Add(this.sizeLabel);
            this.settingsBox.Controls.Add(this.aliveTrackerbar);
            this.settingsBox.Controls.Add(this.cellPercentageLabel);
            this.settingsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsBox.Location = new System.Drawing.Point(0, 0);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(153, 435);
            this.settingsBox.TabIndex = 0;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            // 
            // cellPercentageLabel
            // 
            this.cellPercentageLabel.AutoSize = true;
            this.cellPercentageLabel.Location = new System.Drawing.Point(7, 20);
            this.cellPercentageLabel.Name = "cellPercentageLabel";
            this.cellPercentageLabel.Size = new System.Drawing.Size(80, 13);
            this.cellPercentageLabel.TabIndex = 0;
            this.cellPercentageLabel.Text = "Alive cells: 50%";
            // 
            // aliveTrackerbar
            // 
            this.aliveTrackerbar.Location = new System.Drawing.Point(6, 37);
            this.aliveTrackerbar.Maximum = 100;
            this.aliveTrackerbar.Name = "aliveTrackerbar";
            this.aliveTrackerbar.Size = new System.Drawing.Size(140, 45);
            this.aliveTrackerbar.TabIndex = 1;
            this.aliveTrackerbar.TickFrequency = 10;
            this.aliveTrackerbar.Value = 50;
            this.aliveTrackerbar.Scroll += new System.EventHandler(this.aliveTrackerbar_Scroll);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(7, 94);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(139, 13);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Cell grid size (height x width)";
            // 
            // heightTextbox
            // 
            this.heightTextbox.Location = new System.Drawing.Point(9, 110);
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(55, 20);
            this.heightTextbox.TabIndex = 4;
            this.heightTextbox.Text = "50";
            this.heightTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // widthTextbox
            // 
            this.widthTextbox.Location = new System.Drawing.Point(90, 110);
            this.widthTextbox.Name = "widthTextbox";
            this.widthTextbox.Size = new System.Drawing.Size(55, 20);
            this.widthTextbox.TabIndex = 5;
            this.widthTextbox.Text = "100";
            this.widthTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(72, 114);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(12, 13);
            this.xLabel.TabIndex = 7;
            this.xLabel.Text = "x";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveSettingsButton.Location = new System.Drawing.Point(3, 409);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(147, 23);
            this.saveSettingsButton.TabIndex = 8;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(10, 155);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(88, 13);
            this.intervalLabel.TabIndex = 9;
            this.intervalLabel.Text = "Step interval (ms)";
            // 
            // interalTextbox
            // 
            this.interalTextbox.Location = new System.Drawing.Point(10, 171);
            this.interalTextbox.Name = "interalTextbox";
            this.interalTextbox.Size = new System.Drawing.Size(54, 20);
            this.interalTextbox.TabIndex = 10;
            this.interalTextbox.Text = "1";
            this.interalTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 543);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pictureboxInterpolation1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game of Life";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxInterpolation1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.controlBox.ResumeLayout(false);
            this.controlBox.PerformLayout();
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aliveTrackerbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureboxInterpolation pictureboxInterpolation1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox controlBox;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.Label timestepText;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label cellPercentageLabel;
        private System.Windows.Forms.TrackBar aliveTrackerbar;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox widthTextbox;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.TextBox interalTextbox;
        private System.Windows.Forms.Label intervalLabel;
    }
}

