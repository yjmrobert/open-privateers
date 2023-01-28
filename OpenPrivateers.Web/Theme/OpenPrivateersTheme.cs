using MudBlazor;

namespace OpenPrivateers.Web.Theme;

public static class OpenPrivateersTheme
{
    public const string DarkActionHover = "#ffffff1a";

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
                },
                FontSize = "0.7rem",
                LineHeight = 1.125
            },
            H1 = new H1
            {
                FontSize = "3.75rem",
                FontWeight = 300,
                LetterSpacing = "-.00833em"
            },
            H2 = new H2()
            {
                FontSize = "2.25rem",
                FontWeight = 400,
            },
            H3 = new H3()
            {
                FontSize = "1.5rem",
            },
            H4 = new H4()
            {
                FontSize = "1.25rem",
            },
            H5 = new H5()
            {
                FontSize = "1.125rem",
            },
            H6 = new H6()
            {
                FontSize = "1rem",
            },
        },
        LayoutProperties =
        {
            DefaultBorderRadius = "0",
            AppbarHeight = "32px"
        },
        
    };
}