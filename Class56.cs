using CefSharp;
using System;
using System.Collections;
using System.Threading;

internal sealed class Class56 : ICookieVisitor, IDisposable
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private readonly ManualResetEvent manualResetEvent_0 = new ManualResetEvent(false);

    public void Dispose()
    {
    }

    public void method_0()
    {
        Thread.Sleep(50);
    }

    public ArrayList method_1() => 
        this.arrayList_0;

    public bool Visit(Cookie cookie, int count, int total, ref bool deleteCookie)
    {
        this.arrayList_0.Add(cookie);
        return true;
    }
}

