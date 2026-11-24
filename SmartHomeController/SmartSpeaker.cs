using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    public class SmartSpeaker : SmartDevice
    {
        // private fields
        private int volume;
        private bool isPlaying;



        // public properties

        public int Volume
        {  
            get { return volume; } 
            set { volume = value; }   
        }

        public bool IsPlaying
        {
            get {return isPlaying;  }
            set {  isPlaying = value; }
        }

        // Constructor
        public SmartSpeaker(
            int smartSpeakerVolume, 
            bool smartSpeakerIsPlaying, 
            int smartDeviceID, 
            string deviceName, 
            bool DeviceStatus) 
            : base(smartDeviceID, deviceName, DeviceStatus)
        {
            SetVolume(volume);
            IsPlaying = isPlaying;

        }


        // Methods
        public void SetVolume(int volume)
        {
            if (volume < 0 || volume > 100)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(volume), "The volume must be between 0 and 100.");
            }
            Volume = volume;
        }

        public void PlayMusic()
        {
            IsPlaying = true;
        }

        public void StopMusic()
        {
            IsPlaying = false;
        }

        public override void GetStatus()
        {
            base.GetStatus();
            Console.WriteLine($" Current smartspeaker volume: {Volume}");
        }

    }
}
