using MudBlazor;

namespace OpenPrivateers.Web.Theme;

public static class OpenPrivateersTheme
{
    public static MudTheme Theme => new MudTheme()
    {
        PaletteDark = 
        {
            Primary = "#ea580c",
            AppbarBackground = "#030407cc",
            Background = "#030407",
        },
        Typography =
        {
            Default =
            {
                FontFamily = new []
                {
                    "Rajdhani",
                    "Helvetica",
                    "Arial",
                    "sans-serif"
                }
            }
        }
    };
}