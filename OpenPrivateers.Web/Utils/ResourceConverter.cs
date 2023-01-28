namespace OpenPrivateers.Web.Utils;

public static class ResourceConverter
{
    private const int MetalRatio = 1;
    private const int CrystalRatio = 40;
    private const int DeuteriumRatio = 100;

    public static int ToMiningValue(int metal, int crystal, int deuterium)
    {
        return metal * MetalRatio + crystal * CrystalRatio + deuterium * DeuteriumRatio;
    }
}