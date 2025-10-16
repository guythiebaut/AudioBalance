using System;
using System.Windows.Forms;

namespace AudioBalance
{
    public partial class AudioForm : Form
    {
        internal AudioForm()
        {
            InitializeComponent();
            AudioManager.LoadSettings();
            AudioManager.getChannelVolumes();
            AudioManager.setSlider(trackBarMax, volMax, AudioManager.settings.MaxVal);
            SetMaxVals(AudioManager.settings.MaxVal);
            var masterVolume = Math.Max(AudioManager.settings.LeftVal, AudioManager.settings.RightVal);
            AudioManager.setSlider(trackBarMaster, volMaster, masterVolume);
            AudioManager.setSlider(trackBarLeft, volLeft, AudioManager.settings.LeftVal);
            AudioManager.setSlider(trackBarRight, volRight, AudioManager.settings.RightVal);
            AudioManager.prevMaster = masterVolume;
            SetMaxValueMinimum();
        }

        private void SetMaxVals(int max)
        {
            trackBarMaster.Maximum = max;
            trackBarLeft.Maximum = max;
            trackBarRight.Maximum = max;
        }

        private int MaximumSelectedValue()
        {
            return Math.Max(trackBarLeft.Value, trackBarRight.Value);
        }

        private void SetMaxValueMinimum()
        {
            trackBarMax.Minimum = MaximumSelectedValue();
        }

        private void valLeft_Scroll(object sender, EventArgs e)
        {
            AudioManager.SliderMoved(this, Changed.Left, trackBarLeft.Value);
            SetMaxValueMinimum();
        }

        private void valRight_Scroll(object sender, EventArgs e)
        {
            AudioManager.SliderMoved(this, Changed.Right, trackBarRight.Value);
            SetMaxValueMinimum();
        }

        private void valMaster_Scroll(object sender, EventArgs e)
        {
            volMaster.Text = trackBarMaster.Value.ToString();
        }

        private void valMax_Scroll(object sender, EventArgs e)
        {
            AudioManager.SliderMoved(this, Changed.Max, trackBarMax.Value);
        }
         
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AudioManager.SaveSettings(this);
        }

        private void trackBarMaster_MouseUp(object sender, MouseEventArgs e)
        {
            AudioManager.SliderMoved(this, Changed.Master, trackBarMaster.Value);
            SetMaxValueMinimum();
        }

        private void trackBarMaster_KeyUp(object sender, KeyEventArgs e)
        {
            AudioManager.SliderMoved(this, Changed.Master, trackBarMaster.Value);
            SetMaxValueMinimum();
        }
    }
}
