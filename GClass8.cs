using CefSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;

[DefaultMember("\x0002")]
public sealed class GClass8 : ICookieVisitor, IDisposable
{
    private bool bool_0;
    private Dictionary<string, System.Net.Cookie> dictionary_0 = new Dictionary<string, System.Net.Cookie>();

    public GClass8()
    {
        this.method_2(true);
    }

    public void Dispose()
    {
    }

    ~GClass8()
    {
    }

    public Dictionary<string, System.Net.Cookie> method_0() => 
        this.dictionary_0;

    public bool method_1() => 
        this.bool_0;

    public void method_2(bool bool_1)
    {
        this.bool_0 = bool_1;
    }

    public bool Visit(CefSharp.Cookie cookie, int count, int total, ref bool deleteCookie)
    {
        GClass8 class2 = this;
        lock (class2)
        {
            if (this.dictionary_0.ContainsKey(cookie.Name))
            {
                this.dictionary_0[cookie.Name] = new System.Net.Cookie(cookie.Name, cookie.Value, cookie.Path, cookie.Domain);
                this.dictionary_0[cookie.Name].Name = cookie.Name;
                this.dictionary_0[cookie.Name].Value = cookie.Value;
                this.dictionary_0[cookie.Name].Path = cookie.Path;
                this.dictionary_0[cookie.Name].Domain = cookie.Domain;
            }
            else
            {
                this.dictionary_0.Add(cookie.Name, new System.Net.Cookie(cookie.Name, cookie.Value, cookie.Path, cookie.Domain));
            }
            this.method_2(count == (total - 1));
        }
        return true;
    }

    public System.Net.Cookie this[string string_0]
    {
        get
        {
            if (!this.dictionary_0.ContainsKey(string_0))
            {
                return null;
            }
            return this.dictionary_0[string_0];
        }
    }
}

