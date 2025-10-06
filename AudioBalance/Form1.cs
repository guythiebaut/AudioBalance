using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Right
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
            setMasterSlider(channelVolumes.Master * 100);
            setLeftSlider(channelVolumes.Left * 100);
            setRightSlider(channelVolumes.Right * 100);
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
                    setLeftSlider((prevLeft * 100) + (changedValMaster * 100));
                    setRightSlider((prevRight * 100) + (changedValMaster * 100));
                    volMaster.Text = displayVal(volume);
                    break;
                case Changed.Left:
                    if (valIsHighest(Changed.Left))
                    {
                        setMasterSlider((float)volume);
                    }
                    volLeft.Text = displayVal(volume);
                    break;
                case Changed.Right:
                    if (valIsHighest(Changed.Right))
                    {
                        setMasterSlider((float)volume);
                    }
                    volRight.Text = displayVal(volume);
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

       private void setLeftSlider(float volume)
        {
            if(volume < 0f) volume = 0f;
            valLeft.Value = (int)(volume);
            volLeft.Text = displayVal(valLeft.Value);
        }

        private void setRightSlider(float volume)
        {
            if (volume < 0f) volume = 0f;
            valRight.Value = (int)(volume);
            volRight.Text = displayVal(valRight.Value);
        }

        private void setMasterSlider(float volume)
        {
            if (volume < 0f) volume = 0f;
            valMaster.Value = (int)(volume);
            volMaster.Text = displayVal(valMaster.Value);
        }

        private string displayVal(int val)
        {
            return val == 0 ? "0.00" : val == 100 ? "1.00" : ((float)((float)val / 100f)).ToString().PadRight(4, '0');
        }

        private void valLeft_Scroll(object sender, EventArgs e)
        {
            SliderMoved(Changed.Left, valLeft.Value);
        }

        private void valRight_Scroll(object sender, EventArgs e)
        {
            SliderMoved(Changed.Right, valRight.Value);
        }

        private void valMaster_Scroll(object sender, EventArgs e)
        {
            SliderMoved(Changed.Master, valMaster.Value);
        }
    }
}
