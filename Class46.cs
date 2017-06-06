using System;

internal sealed class Class46
{
    public string string_0;
    public string string_1;

    public Class46(string string_2)
    {
        char[] separator = new char[] { ':' };
        string[] strArray = string_2.Split(separator);
        if (strArray.Length != 2)
        {
            this.string_0 = string.Empty;
            this.string_1 = string.Empty;
        }
        else
        {
            this.string_0 = strArray[0];
            this.string_1 = strArray[1];
        }
    }

    public Class46(string string_2, string string_3)
    {
        this.string_0 = string_2;
        this.string_1 = string_3;
    }
}

