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
        public class channel
        {
            public float Left;
            public float Right;
        }

        public Form1()
        {
            InitializeComponent();
            var balance = getChannelVolumes();
            setLeft(balance.Left);
            setRight(balance.Right);
        }
                
        private channel getChannelVolumes()
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
            channelVolumes.Left = endpointVolume.Channels[0].VolumeLevelScalar; // Left channel (0.0 to 1.0)
            channelVolumes.Right = endpointVolume.Channels[1].VolumeLevelScalar; // Right channel (0.0 to 1.0)

            return channelVolumes;
        }

        private channel getSelectedVolumes()
        {
            var vols = new channel();
            vols.Left = (float)valLeft.Value / (float)100;
            vols.Right = (float)valRight.Value / (float)100;
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

        private void setLeft(double volume)
        {
            valLeft.Value = (int)(volume * 100f);
        }

        private void setRight(double volume)
        {
            valRight.Value = (int)(volume * 100f);
        }

        private void valLeft_ValueChanged(object sender, EventArgs e)
        {
            volLeft.Text = displayVal(valLeft.Value);
            setChannelVolumes(getSelectedVolumes());
        }
                
        private void valRight_ValueChanged(object sender, EventArgs e)
        {
            volRight.Text = displayVal(valRight.Value);
            setChannelVolumes(getSelectedVolumes());
        }

        private string displayVal(int val)
        {
            return val == 0 ? "0.00" : val == 100 ? "1.00" : ((float)((float)val / 100f)).ToString().PadRight(4, '0');
        }
    }
}
