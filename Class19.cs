using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;

[DebuggerNonUserCode, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Class19
{
    private static CultureInfo cultureInfo_0;
    private static ResourceManager resourceManager_0;

    internal Class19()
    {
    }

    internal static ResourceManager smethod_0()
    {
        if (resourceManager_0 == null)
        {
            resourceManager_0 = new ResourceManager("yCopp_UltimateAdidasBot.Properties.Resources", typeof(Class19).Assembly);
        }
        return resourceManager_0;
    }

    internal static CultureInfo smethod_1() => 
        cultureInfo_0;

    internal static void smethod_2(CultureInfo cultureInfo_1)
    {
        cultureInfo_0 = cultureInfo_1;
    }

    internal static UnmanagedMemoryStream smethod_3() => 
        smethod_0().GetStream("atc", cultureInfo_0);

    internal static Icon smethod_4() => 
        ((Icon) smethod_0().GetObject("favicon", cultureInfo_0));

    internal static UnmanagedMemoryStream smethod_5() => 
        smethod_0().GetStream("splash", cultureInfo_0);

    internal static UnmanagedMemoryStream smethod_6() => 
        smethod_0().GetStream("success", cultureInfo_0);

    internal static UnmanagedMemoryStream smethod_7() => 
        smethod_0().GetStream("successSpecial", cultureInfo_0);

    internal static Bitmap smethod_8() => 
        ((Bitmap) smethod_0().GetObject("ycopp-proxies", cultureInfo_0));
}

