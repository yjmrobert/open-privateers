using MudBlazor;

namespace OpenPrivateers.Web.Theme;

public static class OpenPrivateersTheme
{
    public static MudTheme Theme = new MudTheme()
    {
        Typography =
        {
            Default =
            {
                FontFamily = new []
                {
                    "Jura",
                    "Helvetica",
                    "Arial",
                    "sans-serif"
                }
            }
        }
    };
}