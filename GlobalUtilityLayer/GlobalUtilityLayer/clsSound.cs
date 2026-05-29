using System;
using System.Windows.Media;

namespace GlobalUtilityLayer
{
    public class clsSounds
    {
        static MediaPlayer player = new MediaPlayer();

        static public bool PlaySoundWav(string sourceFile)
        {
            try
            {
                player.Open(new Uri(sourceFile));
                player.Play();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        static public bool StopSoundWav(String SourseFile)
        {
            try
            {
                player.Stop();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}