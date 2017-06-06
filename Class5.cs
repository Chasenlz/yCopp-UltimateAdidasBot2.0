using System;

internal sealed class Class5
{
    internal static uint smethod_0(string string_0)
    {
        uint num;
        if (string_0 != null)
        {
            num = 0x811c9dc5;
            for (int i = 0; i < string_0.Length; i++)
            {
                num = (string_0[i] ^ num) * 0x1000193;
            }
        }
        return num;
    }
}

