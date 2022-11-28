using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Counters_v2._0
{
    public delegate void OnValueChanged();

    public static class DraftMusicManager
    {
        public static event OnValueChanged OnValueChanged;

        private static SoundPlayer sp = new SoundPlayer(Properties.Resources.DraftMusic);
        private static bool _playing = false;

        public static bool Playing
        {
            get { return _playing; }
            set
            {
                _playing = value;

                if (OnValueChanged != null)
                    OnValueChanged();
            }
        }

        public static void Initialize()
        {
            OnValueChanged += DraftMusicManager_OnValueChanged;
            Playing = Properties.Settings.Default.draftMusic;
        }

        public static void SetMusic(UnmanagedMemoryStream Music)
        {
            sp.Stream = Music;
        }


        private static void DraftMusicManager_OnValueChanged()
        {
            if (_playing)
                sp.PlayLooping();
            else
                sp.Stop();
        }
    }
}
