using System.Media;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Carpathian_star
{
    internal static class Program
    {
        private static PrivateFontCollection _privateFontCollection;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoadCustomFont(); // Завантаження шрифту
            SoundPlayer player = new SoundPlayer(Properties.Resources._2);
            player.PlayLooping();
            Application.Run(new Form1());
        }
        private static void LoadCustomFont()
        {
            _privateFontCollection = new PrivateFontCollection();

            using (MemoryStream fontStream = new MemoryStream(Properties.Resources.Pixeled))
            {
                byte[] fontData = fontStream.ToArray();
                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                _privateFontCollection.AddMemoryFont(fontPtr, fontData.Length);
                Marshal.FreeCoTaskMem(fontPtr);
            }
        }

        public static void ApplyCustomFont(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                float currentFontSize = control.Font.Size;
                control.Font = new System.Drawing.Font(_privateFontCollection.Families[0], currentFontSize);

                if (control.HasChildren)
                {
                    ApplyCustomFont(control.Controls);
                }
            }
        }
    }
}