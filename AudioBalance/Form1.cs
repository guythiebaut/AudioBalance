using System;
using System.Windows.Forms;
using NAudio.CoreAudioApi;

namespace AudioBalance
{
    public partial class Form1 : Form
    {
        public enum Changed
        {
            Master,
            Left,
            Right,
            Max
        }

        public class channel
        {
            public float Master;
            public float Left;
            public float Right;
        }

        public channel channelVolumes = new channel();
        public AppSettings settings = new AppSettings();
        int prevMaster;

        public Form1()
        {
            InitializeComponent();
            settings = SettingsManager.Load();
            prevMaster = Math.Max(settings.LeftVal, settings.RightVal);
            getChannelVolumes();
            setSlider(trackBarMax, volMax, settings.MaxVal);
            SetMaxVals(settings.MaxVal);
            setSlider(trackBarMaster, volMaster, Math.Max(settings.LeftVal, settings.RightVal));
            setSlider(trackBarLeft, volLeft, settings.LeftVal);
            setSlider(trackBarRight, volRight, settings.RightVal);
            SetMaxValueMinimum();
        }

        private void getChannelVolumes()
        {
            // Initialize audio device enumerator
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDevice device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

            // Access the endpoint volume
            var endpointVolume = device.AudioEndpointVolume;

            // Get the current master volume
            float masterVolume = endpointVolume.MasterVolumeLevelScalar;

            // Set the volume balance (adjust individual channel volumes)
            channelVolumes.Left = endpointVolume.Channels[0].VolumeLevelScalar; // Left channel (0.0 to 1.0)
            channelVolumes.Right = endpointVolume.Channels[1].VolumeLevelScalar; // Right channel (0.0 to 1.0)
            channelVolumes.Master = Math.Max(channelVolumes.Left, channelVolumes.Right); // Master volume (0.0 to 1.0)
        }

        private void SetMaxVals(int max)
        {
            trackBarMaster.Maximum = max;
            trackBarLeft.Maximum = max;
            trackBarRight.Maximum = max;
        }

        private channel getSelectedVolumes()
        {
            var vols = new channel();
            vols.Left = (float)trackBarLeft.Value / 100f;
            vols.Right = (float)trackBarRight.Value / 100f;
            vols.Master = (float)trackBarMaster.Value / 100f;
            return vols;
        }

        private void setChannelVolumes(channel vols)
        {
            // Initialize audio device enumerator
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            MMDevice device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

            // Access the endpoint volume
            var endpointVolume = device.AudioEndpointVolume;

            // Get the current master volume
            float masterVolume = endpointVolume.MasterVolumeLevelScalar;

            var channelVolumes = new channel();

            // Set the volume balance (adjust individual channel volumes)
            endpointVolume.Channels[0].VolumeLevelScalar = vols.Left; // Left channel (0.0 to 1.0)
            endpointVolume.Channels[1].VolumeLevelScalar = vols.Right; // Right channel (0.0 to 1.0)
        }

        private void SliderMoved(Changed changed, int volume)
        {
            switch (changed)
            {
                case Changed.Master:
                    var changedValMaster = volume - prevMaster;
                    setSlider(trackBarLeft, volLeft, trackBarLeft.Value + changedValMaster);
                    setSlider(trackBarRight, volRight, trackBarRight.Value + changedValMaster);
                    volMaster.Text = volume.ToString();
                    prevMaster = volume;
                    break;
                case Changed.Left:
                    if (valIsHighest(Changed.Left))
                    {
                        setSlider(trackBarMaster, volMaster, volume);
                        prevMaster = volume;
                    }
                    volLeft.Text = volume.ToString();
                    break;
                case Changed.Right:
                    if (valIsHighest(Changed.Right))
                    {
                        setSlider(trackBarMaster, volMaster, volume);
                        prevMaster = volume;
                    }
                    volRight.Text = volume.ToString();
                    break;
                case Changed.Max:
                    volMax.Text = volume.ToString();
                    SetMaxVals(volume);
                    break;
                default:
                    break;
            }

            setChannelVolumes(getSelectedVolumes());
        }

        private bool valIsHighest(Changed speaker)
        {
            switch (speaker)
            {
                case Changed.Left:
                    return trackBarLeft.Value >= trackBarRight.Value;
                case Changed.Right:
                    return trackBarRight.Value >= trackBarLeft.Value;
                default:
                    return false;
            }
        }

        private void setSlider(TrackBar bar, Label label, int volume)
        {
            if (volume < 0) volume = 0;
            bar.Value = volume;
            label.Text = volume.ToString();
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
            SliderMoved(Changed.Left, trackBarLeft.Value);
            SetMaxValueMinimum();
        }

        private void valRight_Scroll(object sender, EventArgs e)
        {
            SliderMoved(Changed.Right, trackBarRight.Value);
            SetMaxValueMinimum();
        }

        private void valMaster_Scroll(object sender, EventArgs e)
        {
            //SliderMoved(Changed.Master, trackBarMaster.Value);
            //SetMaxValueMinimum();
            volMaster.Text = trackBarMaster.Value.ToString();
        }

        private void valMax_Scroll(object sender, EventArgs e)
        {
            SliderMoved(Changed.Max, trackBarMax.Value);
        }

        private void SaveSettings()
        {
            settings.LeftVal = trackBarLeft.Value;
            settings.RightVal = trackBarRight.Value;
            settings.MaxVal = trackBarMax.Value;
            SettingsManager.Save(settings);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void trackBarMaster_MouseUp(object sender, MouseEventArgs e)
        {
            SliderMoved(Changed.Master, trackBarMaster.Value);
            SetMaxValueMinimum();
        }

        private void trackBarMaster_KeyUp(object sender, KeyEventArgs e)
        {
            SliderMoved(Changed.Master, trackBarMaster.Value);
            SetMaxValueMinimum();
        }
    }
}
