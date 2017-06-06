using System;
using System.Text;

internal sealed class Class15
{
    internal static string smethod_0(byte[] byte_0)
    {
        if (byte_0 == null)
        {
            return null;
        }
        if (byte_0.Length == 0)
        {
            return string.Empty;
        }
        StringBuilder builder = new StringBuilder((byte_0.Length * 8) / 5);
        int index = 0;
        int num3 = 0;
        byte num = 0;
        int num2 = 0;
        while (index < byte_0.Length)
        {
            int num5 = Math.Min((int) (8 - num3), (int) (5 - num2));
            num = (byte) (num << num5);
            num = (byte) (num | ((byte) (byte_0[index] >> (8 - (num3 + num5)))));
            num3 += num5;
            if (num3 >= 8)
            {
                index++;
                num3 = 0;
            }
            num2 += num5;
            if (num2 >= 5)
            {
                num = (byte) (num & 0x1f);
                builder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ234567"[num]);
                num2 = 0;
            }
        }
        if (num2 > 0)
        {
            num = (byte) (num << (5 - num2));
            num = (byte) (num & 0x1f);
            builder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ234567"[num]);
        }
        return builder.ToString();
    }

    internal static byte[] smethod_1(string string_0)
    {
        if (string_0 == null)
        {
            return null;
        }
        if (string_0 == string.Empty)
        {
            return new byte[0];
        }
        string str = string_0.ToUpperInvariant();
        byte[] buffer = new byte[(str.Length * 5) / 8];
        if (buffer.Length == 0)
        {
            throw new ArgumentException("Specified string is not valid Base32 format because it doesn't have enough data to construct a complete byte array");
        }
        int num4 = 0;
        int num = 0;
        int index = 0;
        int num3 = 0;
        while (index < buffer.Length)
        {
            int num6 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567".IndexOf(str[num4]);
            if (num6 < 0)
            {
                throw new ArgumentException($"Specified string is not valid Base32 format because character "{string_0[num4]}" does not exist in Base32 alphabet");
            }
            int num5 = Math.Min((int) (5 - num), (int) (8 - num3));
            buffer[index] = (byte) (buffer[index] << num5);
            buffer[index] = (byte) (buffer[index] | ((byte) (num6 >> (5 - (num + num5)))));
            num3 += num5;
            if (num3 >= 8)
            {
                index++;
                num3 = 0;
            }
            num += num5;
            if (num >= 5)
            {
                num4++;
                num = 0;
            }
        }
        return buffer;
    }
}

