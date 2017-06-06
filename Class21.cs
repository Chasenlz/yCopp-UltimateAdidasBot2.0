using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

internal static class Class21
{
    private static string string_0 = "<RSAKeyValue><Modulus>khyU+NN8IEwWVHzKtBDzrTQyou2ltocWUyK2JBWq6BIwEZFvCBBMtuRObxtAFfS66aa1uOQ1NB9gmGVLY/KeQRPwKtRcc+igxtzWEKhaZNStmi0gracA7v+a8A0HRTfGDz6mz6CmOyLckIlZK/6W4gzcMAvxYg5vGAR4WFmB0cxCHhS0Le9TGKo2P0D/zUIi0EHjrK0jOOI+BV9/Ax1qeBpgccKvh8lvC5Ad7b/EZaQl8vIGvs2OUnphUpe1dcWXrnySCCjQBHB30AdiWGNqRywBk+hkk++mymjIjUbU3kshKXWpUH9kqa+Z0JhwKLFj3uVUEXipcsjFmq0yXPxQdQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
    public static string string_1 = string.Empty;
    public static string string_10 = string.Empty;
    public static string string_11 = string.Empty;
    public static string string_12 = string.Empty;
    public static string string_13 = string.Empty;
    public static string string_2 = string.Empty;
    public static string string_3 = "0";
    public static string string_4 = string.Empty;
    public static string string_5 = string.Empty;
    public static string string_6 = string.Empty;
    public static string string_7 = string.Empty;
    public static string string_8 = string.Empty;
    public static string string_9 = string.Empty;

    public static void smethod_0(ref HttpWebRequest httpWebRequest_0, bool bool_0)
    {
        httpWebRequest_0.UnsafeAuthenticatedConnectionSharing = true;
        httpWebRequest_0.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
        if (!string_1.Equals(string.Empty))
        {
            httpWebRequest_0.UserAgent = string_1;
        }
        httpWebRequest_0.Accept = "*/*";
        httpWebRequest_0.Headers.Set("X-Requested-With", "XMLHttpRequest");
        httpWebRequest_0.Headers.Set("Upgrade-Insecure-Requests", "1");
        httpWebRequest_0.Headers.Set("Accept-Language", "de-DE,de;q=0.8,en-US;q=0.6,en;q=0.4");
        if (bool_0)
        {
            httpWebRequest_0.Headers.Set("Accept-Encoding", "gzip, deflate, sdch, br");
        }
        else
        {
            httpWebRequest_0.Headers.Set("Accept-Encoding", "deflate");
        }
        object[] args = new object[] { "Connection", "keep-alive" };
        httpWebRequest_0.Headers.GetType().InvokeMember("ChangeInternal", BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance, Type.DefaultBinder, httpWebRequest_0.Headers, args);
    }

    internal static string smethod_1(string string_14)
    {
        StringBuilder builder = new StringBuilder();
        foreach (byte num2 in new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(string_14), 0, Encoding.UTF8.GetByteCount(string_14)))
        {
            builder.Append(num2.ToString("x2"));
        }
        return builder.ToString();
    }

    internal static byte[] smethod_2(string string_14) => 
        new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(string_14), 0, Encoding.UTF8.GetByteCount(string_14));

    public static string smethod_3(string string_14)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(string_14);
        byte[] buffer2 = Encoding.Convert(Encoding.UTF8, Encoding.ASCII, bytes);
        return Encoding.ASCII.GetString(buffer2);
    }

    public static string smethod_4()
    {
        string str3;
        string name = @"SOFTWARE\Microsoft\Cryptography";
        string str2 = "MachineGuid";
        using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, 0x100))
        {
            using (RegistryKey key2 = key.OpenSubKey(name))
            {
                if (key2 == null)
                {
                    throw new KeyNotFoundException($"Key Not Found: {name}");
                }
                object obj1 = key2.GetValue(str2);
                if (obj1 == null)
                {
                    throw new IndexOutOfRangeException($"Index Not Found: {str2}");
                }
                str3 = obj1.ToString();
            }
        }
        return str3;
    }

    public static bool smethod_5(string string_14, string string_15)
    {
        bool flag = false;
        using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider())
        {
            byte[] signature = Convert.FromBase64String(string_15);
            byte[] bytes = Encoding.UTF8.GetBytes(string_14);
            try
            {
                provider.FromXmlString(string_0);
                flag = provider.VerifyData(bytes, new SHA256CryptoServiceProvider(), signature);
            }
            catch (CryptographicException exception1)
            {
                Console.WriteLine(exception1.Message);
            }
            finally
            {
                provider.PersistKeyInCsp = false;
            }
        }
        return flag;
    }

    public static string smethod_6(string string_14, string string_15)
    {
        using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider())
        {
            byte[] rgb = Convert.FromBase64String(string_14);
            try
            {
                provider.FromXmlString(string_15);
                byte[] bytes = provider.Decrypt(rgb, false);
                return Encoding.UTF8.GetString(bytes);
            }
            catch (CryptographicException exception1)
            {
                Console.WriteLine(exception1.Message);
            }
            finally
            {
                provider.PersistKeyInCsp = false;
            }
            return string.Empty;
        }
    }

    [IteratorStateMachine(typeof(Class22))]
    public static IEnumerable<Cookie> smethod_7(this CookieContainer cookieContainer_0) => 
        new Class22(-2) { cookieContainer_1 = cookieContainer_0 };

    public static HttpWebRequest smethod_8(this HttpWebRequest httpWebRequest_0)
    {
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create(httpWebRequest_0.RequestUri.AbsoluteUri);
        List<string> list = new List<string> { 
            "ContentLength",
            "Headers"
        };
        foreach (PropertyInfo info in httpWebRequest_0.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            if (!list.Contains(info.Name))
            {
                object obj2 = info.GetValue(httpWebRequest_0);
                if (info.CanWrite)
                {
                    info.SetValue(request, obj2);
                }
            }
        }
        return request;
    }

    private sealed class Class22 : IEnumerator<Cookie>, IEnumerable<Cookie>, IEnumerable, IEnumerator, IDisposable
    {
        private Cookie cookie_0;
        private CookieContainer cookieContainer_0;
        public CookieContainer cookieContainer_1;
        private IDictionaryEnumerator idictionaryEnumerator_0;
        private IDictionaryEnumerator idictionaryEnumerator_1;
        private IEnumerator ienumerator_0;
        private int int_0;
        private int int_1;

        [DebuggerHidden]
        public Class22(int int_2)
        {
            this.int_0 = int_2;
            this.int_1 = Environment.get_CurrentManagedThreadId();
        }

        private void method_0()
        {
            this.int_0 = -1;
            IDisposable disposable = this.idictionaryEnumerator_0 as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }
        }

        private void method_1()
        {
            this.int_0 = -3;
            IDisposable disposable = this.idictionaryEnumerator_1 as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }
        }

        private void method_2()
        {
            this.int_0 = -4;
            IDisposable disposable = this.ienumerator_0 as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }
        }

        private bool MoveNext()
        {
            try
            {
                Cookie cookie;
                int num = this.int_0;
                if (num != 0)
                {
                    if (num != 1)
                    {
                        return false;
                    }
                    this.int_0 = -5;
                    goto Label_00F1;
                }
                this.int_0 = -1;
                this.idictionaryEnumerator_0 = ((Hashtable) this.cookieContainer_0.GetType().GetField("m_domainTable", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this.cookieContainer_0)).GetEnumerator();
                this.int_0 = -3;
                while (this.idictionaryEnumerator_0.MoveNext())
                {
                    DictionaryEntry current = (DictionaryEntry) this.idictionaryEnumerator_0.Current;
                    FieldInfo field = current.Value.GetType().GetField("m_list", BindingFlags.NonPublic | BindingFlags.Instance);
                    this.idictionaryEnumerator_1 = ((SortedList) field.GetValue(current.Value)).GetEnumerator();
                    this.int_0 = -4;
                    while (this.idictionaryEnumerator_1.MoveNext())
                    {
                        DictionaryEntry entry2 = (DictionaryEntry) this.idictionaryEnumerator_1.Current;
                        this.ienumerator_0 = ((CookieCollection) entry2.Value).GetEnumerator();
                        this.int_0 = -5;
                    Label_00F1:
                        if (this.ienumerator_0.MoveNext())
                        {
                            goto Label_0146;
                        }
                        this.method_2();
                        this.ienumerator_0 = null;
                    }
                    this.method_1();
                    this.idictionaryEnumerator_1 = null;
                }
                this.method_0();
                this.idictionaryEnumerator_0 = null;
                return false;
            Label_0146:
                cookie = (Cookie) this.ienumerator_0.Current;
                this.cookie_0 = cookie;
                this.int_0 = 1;
                return true;
            }
            fault
            {
                this.System.IDisposable.Dispose();
            }
        }

        [DebuggerHidden]
        IEnumerator<Cookie> IEnumerable<Cookie>.GetEnumerator()
        {
            Class21.Class22 class2;
            if ((this.int_0 == -2) && (this.int_1 == Environment.get_CurrentManagedThreadId()))
            {
                this.int_0 = 0;
                class2 = this;
            }
            else
            {
                class2 = new Class21.Class22(0);
            }
            class2.cookieContainer_0 = this.cookieContainer_1;
            return class2;
        }

        [DebuggerHidden]
        IEnumerator IEnumerable.GetEnumerator() => 
            this.System.Collections.Generic.IEnumerable<System.Net.Cookie>.GetEnumerator();

        [DebuggerHidden]
        void IEnumerator.Reset()
        {
            throw new NotSupportedException();
        }

        [DebuggerHidden]
        void IDisposable.Dispose()
        {
            int num = this.int_0;
            switch (num)
            {
                case -5:
                case -4:
                case -3:
                case 1:
                    try
                    {
                        switch (num)
                        {
                            case -5:
                            case -4:
                            case 1:
                                try
                                {
                                    switch (num)
                                    {
                                        case -5:
                                        case 1:
                                            try
                                            {
                                            }
                                            finally
                                            {
                                                this.method_2();
                                            }
                                            break;
                                    }
                                }
                                finally
                                {
                                    this.method_1();
                                }
                                break;
                        }
                    }
                    finally
                    {
                        this.method_0();
                    }
                    return;

                case -2:
                case -1:
                case 0:
                    return;
            }
        }

        Cookie IEnumerator<Cookie>.Current =>
            this.cookie_0;

        object IEnumerator.Current =>
            this.cookie_0;
    }
}

