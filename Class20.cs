using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

internal sealed class Class20
{
    public string action;
    public bool bool_0;
    public ChromiumWebBrowser chromiumWebBrowser_0;
    public CookieContainer cookieContainer_0;
    public DateTime dateTime_0;
    public Dictionary<string, string> dictionary_0;
    public HttpWebRequest httpWebRequest_0;
    public int id;
    public int int_0;
    public int int_1;
    public long long_0;
    public Panel panel_0;
    public string password;
    public string proxy;
    public int state;
    public string string_0;
    public string string_1;
    public string username;

    public Class20(int int_2, string string_2)
    {
        this.action = string.Empty;
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.bool_0 = true;
        this.dictionary_0 = new Dictionary<string, string>();
        this.id = int_2;
        this.proxy = string_2;
        this.username = string.Empty;
        this.password = string.Empty;
    }

    public Class20(int int_2, string string_2, string string_3, string string_4)
    {
        this.action = string.Empty;
        this.string_0 = string.Empty;
        this.string_1 = string.Empty;
        this.bool_0 = true;
        this.dictionary_0 = new Dictionary<string, string>();
        this.id = int_2;
        this.proxy = string_2;
        this.username = string_3;
        this.password = string_4;
    }

    public string getStateString()
    {
        switch (this.state)
        {
            case -3:
                return "Renewing HMAC...";

            case -2:
                return "Initializing...";

            case -1:
                return "Splash not live";

            case 0:
                return "Idle";

            case 1:
                return "Initializing...";

            case 2:
                return "In Splash";

            case 3:
                return ("Past Splash. " + this.method_0());

            case 4:
                return "Renewing HMAC...";

            case 5:
                return "Waiting for sitekey";

            case 6:
                return "Waiting for HMAC";

            case 10:
                return "Idle";

            case 11:
                return "Error loading splash page";

            case 12:
                return "Proxy banned";

            case 14:
                return "In Splash";

            case 15:
                return ("Past Splash. " + this.method_0());
        }
        return "Unknown error";
    }

    public string method_0()
    {
        TimeSpan span = this.dateTime_0.Subtract(DateTime.Now);
        TimeSpan ts = new TimeSpan(0, 10, 0);
        TimeSpan span3 = span.Add(ts);
        if (span3.TotalSeconds < 0.0)
        {
            return "-1";
        }
        if (span3.Seconds < 10)
        {
            object[] objArray1 = new object[] { Math.Floor(span3.TotalMinutes), ":0", span3.Seconds, " remaining" };
            return string.Concat(objArray1);
        }
        object[] objArray2 = new object[] { Math.Floor(span3.TotalMinutes), ":", span3.Seconds, " remaining" };
        return string.Concat(objArray2);
    }
}

