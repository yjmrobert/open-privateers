using MudBlazor;

namespace OpenPrivateers.Web.Theme;

public static class OpenPrivateersTheme
{
    public static MudTheme Theme = new MudTheme()
    {
        PaletteDark = 
        {
            Primary = "#ea580c",
            AppbarBackground = "#000000cc",
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