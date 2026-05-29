using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace BinaryDS
{
    public static class clsAppSettings
    {
        private static string GetAssistPath()
        {
            string prodPath = Path.Combine(Application.StartupPath, "Assist");
            if (Directory.Exists(prodPath)) return prodPath;

            string devPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Assist"));
            if (Directory.Exists(devPath)) return devPath;

            string devCorePath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\Assist"));
            if (Directory.Exists(devCorePath)) return devCorePath;

            return prodPath;
        }

        public static readonly string assistPath = GetAssistPath();
        public static readonly string soundsPath = Path.Combine(assistPath, "SoundsEffect");

        public static readonly string iconSettingsIconPath = Path.Combine(assistPath, "settings-3110.ico");
        public static readonly string iconApplyIconPath = Path.Combine(assistPath, "Apply.ico");
        public static readonly string iconLoginIconPath = Path.Combine(assistPath, "login.ico");
        public static readonly string iconResetIconPath = Path.Combine(assistPath, "reset.ico");

        public static readonly string seClickPath = Path.Combine(soundsPath, "click.wav");
        public static readonly string seHoverPath = Path.Combine(soundsPath, "click.wav");
        public static readonly string seDataRevealPath = Path.Combine(soundsPath, "data-reveal.wav");
    }
}