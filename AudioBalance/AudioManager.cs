using NAudio.CoreAudioApi;
using System;
using System.Windows.Forms;

namespace AudioBalance
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

    internal static class AudioManager
    {
        internal static AppSettings settings = new AppSettings();
        static channel channelVolumes = new channel();
        internal static int prevMaster;

        internal static void SliderMoved(AudioForm form, Changed changed, int volume)
        {
            switch (changed)
            {
                case Changed.Master:
                    var changedValMaster = volume - prevMaster;
                    setSlider(form.trackBarLeft, form.volLeft, form.trackBarLeft.Value + changedValMaster);
                    setSlider(form.trackBarRight, form.volRight, form.trackBarRight.Value + changedValMaster);
                    form.volMaster.Text = volume.ToString();
                    prevMaster = volume;
                    break;
                case Changed.Left:
                    if (valIsHighest(form, Changed.Left))
                    {
                        setSlider(form.trackBarMaster, form.volMaster, volume);
                        prevMaster = volume;
                    }
                    form.volLeft.Text = volume.ToString();
                    break;
                case Changed.Right:
                    if (valIsHighest(form, Changed.Right))
                    {
                        setSlider(form.trackBarMaster, form.volMaster, volume);
                        prevMaster = volume;
                    }
                    form.volRight.Text = volume.ToString();
                    break;
                case Changed.Max:
                    form.volMax.Text = volume.ToString();
                    SetMaxVals(form, volume);
                    break;
                default:
                    break;
            }

            setChannelVolumes(getSelectedVolumes(form));
        }

        internal static void getChannelVolumes()
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

        private static void SetMaxVals(AudioForm form, int max)
        {
            form.trackBarMaster.Maximum = max;
            form.trackBarLeft.Maximum = max;
            form.trackBarRight.Maximum = max;
        }

        private static channel getSelectedVolumes(AudioForm form)
        {
            var vols = new channel();
            vols.Left = (float)form.trackBarLeft.Value / 100f;
            vols.Right = (float)form.trackBarRight.Value / 100f;
            vols.Master = (float)form.trackBarMaster.Value / 100f;
            return vols;
        }

        internal static void setChannelVolumes(channel vols)
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

        private static bool valIsHighest(AudioForm form, Changed speaker)
        {
            switch (speaker)
            {
                case Changed.Left:
                    return form.trackBarLeft.Value >= form.trackBarRight.Value;
                case Changed.Right:
                    return form.trackBarRight.Value >= form.trackBarLeft.Value;
                default:
                    return false;
            }
        }

        internal static void setSlider(TrackBar bar, Label label, int volume)
        {
            if (volume < 0) volume = 0;
            bar.Value = volume;
            label.Text = volume.ToString();
        }

        internal static void LoadSettings()
        {
            settings = SettingsManager.Load();
        }

        internal static void SaveSettings(AudioForm form)
        {
            settings.LeftVal = form.trackBarLeft.Value;
            settings.RightVal = form.trackBarRight.Value;
            settings.MaxVal = form.trackBarMax.Value;
            SettingsManager.Save(settings);
        }
    }
}
