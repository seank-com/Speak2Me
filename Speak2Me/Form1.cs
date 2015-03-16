using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Speak2Me
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer _synth;

        public Form1()
        {
            InitializeComponent();
            _synth = new SpeechSynthesizer();
        }

        private void speakButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(messageTextBox.Text))
                return;

            _synth.Volume = volumeTrackBar.Value;
            _synth.Rate = voiceRateTrackBar.Value;
            _synth.SpeakAsync(messageTextBox.Text);
        }
    }
}
