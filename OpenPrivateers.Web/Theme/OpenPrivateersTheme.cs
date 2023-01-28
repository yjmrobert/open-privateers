using MudBlazor;

namespace OpenPrivateers.Web.Theme;

public static class OpenPrivateersTheme
{
    public static MudTheme Theme => new()
    {
        PaletteDark = 
        {
            Primary = "#ea580c",
            AppbarBackground = "#030407cc",
            Background = "#030407",
            Surface = "#030407d4",
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
        },
        LayoutProperties =
        {
            DefaultBorderRadius = "0",
            AppbarHeight = "32px"
        },
        
    };
}