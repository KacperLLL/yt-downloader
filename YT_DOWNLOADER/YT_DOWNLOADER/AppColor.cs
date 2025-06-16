using System;
using System.Drawing;

namespace Youtube_Desktop_Downloader
{
    /// <summary>
    /// Enum reprezentujący wszystkie kolory aplikacji.
    /// </summary>
    /*public enum AppColor
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
    }*/

    public enum AppColor
    {
        BackgroundMain,         // Główny kolor tła aplikacji
        NavigationBar,       // Kolor paska nawigacyjnego
        Cells,               // Kolor kafelków
        Icons,          // Kolor ikon
        Selected,           // Kolor zaznaczenia elementu
        FontColor,        // Kolor czcionki
        SelectedFontColor, // Kolor czcionki zaznaczonego elementu
        ButtonColor, // Kolor przycisku pobierania
        ProgressBar, // Kolor paska postępu
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
                AppColor.BackgroundMain => ColorTranslator.FromHtml("#14151a"),
                AppColor.NavigationBar => ColorTranslator.FromHtml("#1a1d24"),
                AppColor.Cells => ColorTranslator.FromHtml("#1b1d24"),
                AppColor.Icons => ColorTranslator.FromHtml("#666b72"), 
                AppColor.Selected => ColorTranslator.FromHtml("#262a32"), 
                AppColor.FontColor => ColorTranslator.FromHtml("#859097"), 
                AppColor.SelectedFontColor => ColorTranslator.FromHtml("#ebf0f1"), 
                AppColor.ButtonColor => ColorTranslator.FromHtml("#252830"), 
                AppColor.ProgressBar => ColorTranslator.FromHtml("#6068e0"), 



                _ => Color.Magenta // Fallback: magenta dla nieobsługiwanych wartości
            };
        }
    }
}
