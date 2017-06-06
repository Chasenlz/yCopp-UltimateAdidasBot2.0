using Newtonsoft.Json;
using System;

public sealed class GClass9
{
    private string string_0;
    private string string_1;
    private string string_2;

    [JsonProperty("channel")]
    public string String_0
    {
        get => 
            this.string_0;
        set
        {
            this.string_0 = value;
        }
    }

    [JsonProperty("username")]
    public string String_1
    {
        get => 
            this.string_1;
        set
        {
            this.string_1 = value;
        }
    }

    [JsonProperty("text")]
    public string String_2
    {
        get => 
            this.string_2;
        set
        {
            this.string_2 = value;
        }
    }
}

