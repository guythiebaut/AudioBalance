using System;
using System.Windows.Forms;
using NAudio.CoreAudioApi;

namespace AudioBalance
{
    public partial class Form1 : Form
    {
        public const int MAX_VOLUME = 30;

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

        public Form1()
        {
            InitializeComponent();
            getChannelVolumes();
            setSlider(valMax, volMax, MAX_VOLUME);
            SetMaxVals(MAX_VOLUME);
            setSlider(valMaster, volMaster, channelVolumes.Master * 100);
            setSlider(valLeft, volLeft, channelVolumes.Left * 100);
            setSlider(valRight, volRight, channelVolumes.Right * 100);
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
            valMaster.Maximum = max;
            valLeft.Maximum = max;
            valRight.Maximum = max;
        }

        private channel getSelectedVolumes()
        {
            var vols = new channel();
            vols.Left = (float)valLeft.Value / (float)100;
            vols.Right = (float)valRight.Value / (float)100;
            vols.Master = (float)valMaster.Value / (float)100;
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
            var prevMaster = channelVolumes.Master;
            var prevLeft = channelVolumes.Left;
            var prevRight = channelVolumes.Right;

            switch (changed)
            {
                case Changed.Master:
                    var changedValMaster = ((float)volume / 100f) - prevMaster;
                    setSlider(valLeft, volLeft, (prevLeft * 100) + (changedValMaster * 100));
                    setSlider(valRight, volRight, (prevRight * 100) + (changedValMaster * 100));
                    volMaster.Text = displayVal(volume);
                    break;
                case Changed.Left:
                    if (valIsHighest(Changed.Left))
                    {
                        setSlider(valMaster, volMaster, volume);
                    }
                    volLeft.Text = displayVal(volume);
                    break;
                case Changed.Right:
                    if (valIsHighest(Changed.Right))
                    {
                        setSlider(valMaster, volMaster, volume);
                    }
                    volRight.Text = displayVal(volume);
                    break;
                case Changed.Max:
                    volMax.Text = displayVal(volume);
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
                    return valLeft.Value >= valRight.Value;
                case Changed.Right:
                    return valRight.Value >= valLeft.Value;
                default:
                    return false;
            }
        }

        private void setSlider(TrackBar bar, Label label, float volume)
        {
            if (volume < 0f) volume = 0f;
            bar.Value = (int)(volume);
            label.Text = displayVal(bar.Value);
        }

        private string displayVal(int val)
        {
            return val.ToString();
        }

        private int MaximumSelectedValue()
        {
            return Math.Max(valLeft.Value, valRight.Value);
        }

        private void SetMaxValueMinimum()
        {
            valMax.Minimum = MaximumSelectedValue();
        }

        private void valLeft_Scroll(object sender, EventArgs e)
        {
            SliderMoved(Changed.Left, valLeft.Value);
            SetMaxValueMinimum();
        }

        private void valRight_Scroll(object sender, EventArgs e)
        {
            SliderMoved(Changed.Right, valRight.Value);
            SetMaxValueMinimum();
        }

        private void valMaster_Scroll(object sender, EventArgs e)
        {
            SliderMoved(Changed.Master, valMaster.Value);
            SetMaxValueMinimum();
        }

        private void valMax_Scroll(object sender, EventArgs e)
        {
            SliderMoved(Changed.Max, valMax.Value);
        }
    }
}
