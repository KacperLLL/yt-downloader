using System;
using System.Drawing;

namespace Youtube_Desktop_Downloader
{
    /// <summary>
    /// Enum reprezentujący wszystkie kolory aplikacji.
    /// </summary>
    public enum AppColor
    {
        BackgroundMain,
        PanelBackground,
        SidebarBackground,
        DownloadPanelBackground,
        TextPrimary,
        TextSecondary,
        IconColor,
        ButtonDownload,
        ProgressBar,
        ActiveElement
    }

    /// <summary>
    /// Rozszerzenie umożliwiające konwersję AppColor na System.Drawing.Color.
    /// </summary>
    public static class AppColorExtensions
    {
        /// <summary>
        /// Zamienia wartość AppColor na odpowiadający jej kolor w HEX.
        /// </summary>
        /// <param name="appColor">Element palety kolorów</param>
        /// <returns>Obiekt System.Drawing.Color</returns>
        public static Color ToColor(this AppColor appColor)
        {
            return appColor switch
            {
                AppColor.BackgroundMain => ColorTranslator.FromHtml("#1E1E2F"),
                AppColor.PanelBackground => ColorTranslator.FromHtml("#2A2A3C"),
                AppColor.SidebarBackground => ColorTranslator.FromHtml("#252537"),
                AppColor.DownloadPanelBackground => ColorTranslator.FromHtml("#2C2C3E"),
                AppColor.TextPrimary => ColorTranslator.FromHtml("#FFFFFF"),
                AppColor.TextSecondary => ColorTranslator.FromHtml("#B0B0C0"),
                AppColor.IconColor => ColorTranslator.FromHtml("#7A7A90"),
                AppColor.ButtonDownload => ColorTranslator.FromHtml("#3B82F6"),
                AppColor.ProgressBar => ColorTranslator.FromHtml("#6366F1"),
                AppColor.ActiveElement => ColorTranslator.FromHtml("#4F46E5"),
                _ => Color.Magenta // Fallback: magenta dla nieobsługiwanych wartości
            };
        }
    }
}
