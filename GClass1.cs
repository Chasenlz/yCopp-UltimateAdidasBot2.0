using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;

public sealed class GClass1
{
    private readonly Encoding encoding_0 = new UTF8Encoding();
    private readonly Uri uri_0;

    public GClass1(string string_0)
    {
        this.uri_0 = new Uri(string_0);
    }

    public void method_0(string string_0, string string_1, string string_2)
    {
        GClass9 class1 = new GClass9();
        class1.set_String_0(string_2);
        class1.set_String_1(string_1);
        class1.set_String_2(string_0);
        GClass9 class2 = class1;
        this.method_1(class2);
    }

    public void method_1(GClass9 gclass9_0)
    {
        string str = JsonConvert.SerializeObject(gclass9_0);
        using (WebClient client = new WebClient())
        {
            NameValueCollection data = new NameValueCollection {
                ["payload"] = str
            };
            byte[] bytes = client.UploadValues(this.uri_0, "POST", data);
            this.encoding_0.GetString(bytes);
        }
    }
}

