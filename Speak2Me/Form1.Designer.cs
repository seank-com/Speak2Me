namespace Speak2Me
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.voiceRateTrackBar = new System.Windows.Forms.TrackBar();
            this.voiceRateLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.speakButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.voiceRateTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(13, 13);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(50, 13);
            this.messageLabel.TabIndex = 5;
            this.messageLabel.Text = "Message";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Location = new System.Drawing.Point(16, 29);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(256, 96);
            this.messageTextBox.TabIndex = 0;
            // 
            // voiceRateTrackBar
            // 
            this.voiceRateTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voiceRateTrackBar.Location = new System.Drawing.Point(16, 144);
            this.voiceRateTrackBar.Minimum = -10;
            this.voiceRateTrackBar.Name = "voiceRateTrackBar";
            this.voiceRateTrackBar.Size = new System.Drawing.Size(256, 45);
            this.voiceRateTrackBar.TabIndex = 2;
            // 
            // voiceRateLabel
            // 
            this.voiceRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.voiceRateLabel.AutoSize = true;
            this.voiceRateLabel.Location = new System.Drawing.Point(13, 128);
            this.voiceRateLabel.Name = "voiceRateLabel";
            this.voiceRateLabel.Size = new System.Drawing.Size(60, 13);
            this.voiceRateLabel.TabIndex = 6;
            this.voiceRateLabel.Text = "Voice Rate";
            // 
            // volumeLabel
            // 
            this.volumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(13, 192);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(42, 13);
            this.volumeLabel.TabIndex = 7;
            this.volumeLabel.Text = "Volume";
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeTrackBar.LargeChange = 10;
            this.volumeTrackBar.Location = new System.Drawing.Point(16, 208);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(256, 45);
            this.volumeTrackBar.TabIndex = 3;
            this.volumeTrackBar.TickFrequency = 5;
            this.volumeTrackBar.Value = 50;
            // 
            // speakButton
            // 
            this.speakButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speakButton.Location = new System.Drawing.Point(197, 259);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(75, 23);
            this.speakButton.TabIndex = 1;
            this.speakButton.Text = "Speak";
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.volumeTrackBar);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.voiceRateLabel);
            this.Controls.Add(this.voiceRateTrackBar);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageLabel);
            this.Name = "Form1";
            this.Text = "Speak 2 Me";
            ((System.ComponentModel.ISupportInitialize)(this.voiceRateTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TrackBar voiceRateTrackBar;
        private System.Windows.Forms.Label voiceRateLabel;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.Button speakButton;
    }
}

