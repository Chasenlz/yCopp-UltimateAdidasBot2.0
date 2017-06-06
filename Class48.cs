using CefSharp;
using System;
using System.Security.Cryptography.X509Certificates;

internal sealed class Class48 : IRequestHandler
{
    public string string_0;
    public string string_1;

    public Class48(string string_2, string string_3)
    {
        this.string_0 = string_2;
        this.string_1 = string_3;
    }

    bool IRequestHandler.GetAuthCredentials(IWebBrowser browserControl, IBrowser browser, IFrame frame, bool isProxy, string host, int port, string realm, string scheme, IAuthCallback callback)
    {
        callback.Continue(this.string_0, this.string_1);
        return true;
    }

    public IResponseFilter GetResourceResponseFilter(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IResponse response) => 
        null;

    public void method_0(IWebBrowser iwebBrowser_0, IBrowser ibrowser_0, IFrame iframe_0, IRequest irequest_0, ref string string_2)
    {
    }

    public bool OnBeforeBrowse(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, bool isRedirect) => 
        false;

    public CefReturnValue OnBeforeResourceLoad(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IRequestCallback callback) => 
        CefReturnValue.Continue;

    public bool OnCertificateError(IWebBrowser browserControl, IBrowser browser, CefErrorCode errorCode, string requestUrl, ISslInfo sslInfo, IRequestCallback callback) => 
        true;

    public bool OnOpenUrlFromTab(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, WindowOpenDisposition targetDisposition, bool userGesture) => 
        true;

    public void OnPluginCrashed(IWebBrowser browserControl, IBrowser browser, string pluginPath)
    {
    }

    public bool OnProtocolExecution(IWebBrowser browserControl, IBrowser browser, string url) => 
        true;

    public bool OnQuotaRequest(IWebBrowser browserControl, IBrowser browser, string originUrl, long newSize, IRequestCallback callback) => 
        true;

    public void OnRenderProcessTerminated(IWebBrowser browserControl, IBrowser browser, CefTerminationStatus status)
    {
    }

    public void OnRenderViewReady(IWebBrowser browserControl, IBrowser browser)
    {
    }

    public void OnResourceLoadComplete(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IResponse response, UrlRequestStatus status, long receivedContentLength)
    {
    }

    public void OnResourceRedirect(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IResponse response, ref string newUrl)
    {
    }

    public bool OnResourceResponse(IWebBrowser browserControl, IBrowser browser, IFrame frame, IRequest request, IResponse response) => 
        false;

    public bool OnSelectClientCertificate(IWebBrowser browserControl, IBrowser browser, bool isProxy, string host, int port, X509Certificate2Collection certificates, ISelectClientCertificateCallback callback) => 
        true;
}

