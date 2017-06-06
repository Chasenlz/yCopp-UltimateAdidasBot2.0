using System;
using System.Net;
using System.Text;
using System.Threading;

public sealed class GClass5
{
    private readonly Func<HttpListenerRequest, string> func_0;
    private readonly HttpListener httpListener_0;

    public GClass5(Func<HttpListenerRequest, string> func_1, params string[] string_0) : this(string_0, func_1)
    {
    }

    public GClass5(string[] string_0, Func<HttpListenerRequest, string> func_1)
    {
        this.httpListener_0 = new HttpListener();
        if (!HttpListener.IsSupported)
        {
            throw new NotSupportedException("Needs Windows XP SP2, Server 2003 or later.");
        }
        if ((string_0 == null) || (string_0.Length == 0))
        {
            throw new ArgumentException("prefixes");
        }
        if (func_1 == null)
        {
            throw new ArgumentException("method");
        }
        foreach (string str in string_0)
        {
            this.httpListener_0.Prefixes.Add(str);
        }
        this.func_0 = func_1;
        this.httpListener_0.Start();
    }

    public void method_0()
    {
        ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_2));
    }

    public void method_1()
    {
        this.httpListener_0.Stop();
        this.httpListener_0.Close();
    }

    private void method_2(object object_0)
    {
        Console.WriteLine("Webserver running...");
        try
        {
            while (this.httpListener_0.IsListening)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_3), this.httpListener_0.GetContext());
            }
        }
        catch
        {
        }
    }

    private void method_3(object object_0)
    {
        HttpListenerContext context = object_0 as HttpListenerContext;
        try
        {
            string s = this.func_0.Invoke(context.Request);
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            context.Response.ContentLength64 = bytes.Length;
            context.Response.OutputStream.Write(bytes, 0, bytes.Length);
        }
        catch
        {
        }
        finally
        {
            context.Response.OutputStream.Close();
        }
    }
}

