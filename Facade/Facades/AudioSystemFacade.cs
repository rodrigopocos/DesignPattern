using Facade.Entitites;

namespace Facade.Facades
{
    public class AudioSystemFacade
    {
        private AudioPlayer player;
        private VolumeControl volumeControl;
        private Equalizer equalizer;

        public AudioSystemFacade()
        {
            player = new AudioPlayer();
            volumeControl = new VolumeControl();
            equalizer = new Equalizer();
        }

        public void StartMusic()
        {
            player.Play();
            volumeControl.SetVolume(70);
            equalizer.SetEqualizerPreset("Rock");
        }

        public void StopMusic()
        {
            player.Stop();
        }
    }

}
