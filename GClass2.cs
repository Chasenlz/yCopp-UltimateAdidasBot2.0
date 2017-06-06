using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

public sealed class GClass2
{
    [return: Dynamic]
    public static object smethod_0(Uri uri_0, string string_0)
    {
        object obj2 = null;
        object obj3;
        byte[] bytes = Encoding.UTF8.GetBytes(string_0);
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create(uri_0);
        request.Method = "POST";
        request.ContentType = "application/json";
        request.ContentLength = bytes.Length;
        try
        {
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(bytes, 0, bytes.Length);
                stream.Close();
            }
            using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
            {
                obj2 = JsonConvert.DeserializeObject(new StreamReader(response.GetResponseStream(), Encoding.UTF8).ReadToEnd());
                response.Close();
            }
            return obj2;
        }
        catch
        {
            obj3 = false;
        }
        return obj3;
    }
}

