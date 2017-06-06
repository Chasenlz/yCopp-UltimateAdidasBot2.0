using Polenter.Serialization;
using System;
using System.Collections;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;

public sealed class GClass0
{
    private ArrayList arrayList_0;
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private bool bool_5;
    private bool bool_6;
    private bool bool_7;
    private BrowserForm browserForm_0;
    public string button0;
    public string button1;
    public string button2;
    public string button3;
    public string button4;
    private CookieContainer cookieContainer_0;
    private DateTime dateTime_0;
    private GClass4 gclass4_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private int int_4;
    public bool isScheduled;
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;
    private string string_4;
    private string string_5;
    private string string_6;
    private string string_7;
    private string string_8;
    private Thread thread_0;
    public bool useProxyCheckout;

    public GClass0()
    {
        this.button1 = "Checkout PP";
        this.button2 = "Checkout CC";
        this.button3 = "View Cart";
        this.button4 = "Log in to account";
        this.button0 = "Start auto checkout";
    }

    public GClass0(int int_5, string string_9, int int_6, bool bool_8, string string_10, string string_11, string string_12, string string_13, string string_14, bool bool_9, string string_15, bool bool_10, GClass4 gclass4_1)
    {
        this.button1 = "Checkout PP";
        this.button2 = "Checkout CC";
        this.button3 = "View Cart";
        this.button4 = "Log in to account";
        this.button0 = "Start auto checkout";
        this.id = int_5;
        this.pid = string_9;
        this.size = int_6;
        this.needsCaptcha = bool_8;
        this.captchaDuplicate = string_10;
        this.proxy = string_12;
        this.proxyUsername = string_13;
        this.proxyPW = string_14;
        this.additionalParams = string_11;
        this.automaticStart = bool_9;
        this.startTime = string_15;
        this.euSizes = bool_10;
        this.isStarted = false;
        this.automaticNoTokenNotified = false;
        this.locationIndex = -1;
        this.isAdidasSize = false;
        this.isCheckout = false;
        this.adiName = string.Empty;
        this.adiPw = string.Empty;
        this.checkoutProfile = gclass4_1;
        this.autoCheckoutState = 0;
    }

    public GClass0(int int_5, string string_9, int int_6, bool bool_8, string string_10, string string_11, string string_12, string string_13, string string_14, bool bool_9, string string_15, bool bool_10, bool bool_11)
    {
        this.button1 = "Checkout PP";
        this.button2 = "Checkout CC";
        this.button3 = "View Cart";
        this.button4 = "Log in to account";
        this.button0 = "Start auto checkout";
        this.id = int_5;
        this.pid = string_9;
        this.size = int_6;
        this.needsCaptcha = bool_8;
        this.captchaDuplicate = string_10;
        this.proxy = string_12;
        this.proxyUsername = string_13;
        this.proxyPW = string_14;
        this.additionalParams = string_11;
        this.automaticStart = bool_9;
        this.startTime = string_15;
        this.euSizes = bool_10;
        this.isStarted = false;
        this.automaticNoTokenNotified = false;
        this.locationIndex = -1;
        this.isAdidasSize = bool_11;
        this.isCheckout = false;
        this.adiName = string.Empty;
        this.adiPw = string.Empty;
        this.autoCheckoutState = 0;
    }

    public string getCheckoutProfileName() => 
        this.checkoutProfile.method_1();

    public string getRemainingTime()
    {
        DateTime timeOfCompletion = this.timeOfCompletion;
        TimeSpan span = this.timeOfCompletion.Subtract(DateTime.Now);
        TimeSpan ts = new TimeSpan(0, 9, 40);
        if (this.autoCheckoutState == 2)
        {
            ts = new TimeSpan(0, 30, 0);
        }
        TimeSpan span3 = span.Add(ts);
        if (span3.TotalSeconds < 0.0)
        {
            return "-1";
        }
        if (span3.Seconds < 10)
        {
            return (Math.Floor(span3.TotalMinutes) + ":0" + span3.Seconds);
        }
        return (Math.Floor(span3.TotalMinutes) + ":" + span3.Seconds);
    }

    public string getSizeString()
    {
        if (this.euSizes)
        {
            switch (this.size)
            {
                case 0:
                    return "EU 36";

                case 1:
                    return "EU 36 2/3";

                case 2:
                    return "EU 37 1/3";

                case 3:
                    return "EU 38";

                case 4:
                    return "EU 38 2/3";

                case 5:
                    return "EU 39 1/3";

                case 6:
                    return "EU 40";

                case 7:
                    return "EU 40 2/3";

                case 8:
                    return "EU 41 1/3";

                case 9:
                    return "EU 42";

                case 10:
                    return "EU 42 2/3";

                case 11:
                    return "EU 43 1/3";

                case 12:
                    return "EU 44";

                case 13:
                    return "EU 44 2/3";

                case 14:
                    return "EU 45 1/3";

                case 15:
                    return "EU 46";

                case 0x10:
                    return "EU 46 2/3";

                case 0x11:
                    return "EU 47 1/3";

                case 0x12:
                    return "EU 48";

                case 0x13:
                    return "EU 48 2/3";

                case 20:
                    return "EU 49 1/3";

                case 0x15:
                    return "EU 51 1/3";

                case 0x16:
                    return "XS";

                case 0x17:
                    return "S";

                case 0x18:
                    return "M";

                case 0x19:
                    return "L";

                case 0x1a:
                    return "XL";

                case 0x1b:
                    return "2XL";

                case 0x1c:
                    return "EU 17";

                case 0x1d:
                    return "EU 18";

                case 30:
                    return "EU 19";

                case 0x1f:
                    return "EU 20";

                case 0x20:
                    return "EU 21";

                case 0x21:
                    return "EU 22";

                case 0x22:
                    return "EU 23";

                case 0x23:
                    return "EU 23 1/2";

                case 0x24:
                    return "EU 24";

                case 0x25:
                    return "EU 25";

                case 0x26:
                    return "EU 25 1/2";

                case 0x27:
                    return "EU 26";

                case 40:
                    return "EU 26 1/2";

                case 0x29:
                    return "EU 27";
            }
        }
        switch (this.size)
        {
            case 0:
                return "US 4";

            case 1:
                return "US 4.5";

            case 2:
                return "US 5";

            case 3:
                return "US 5.5";

            case 4:
                return "US 6";

            case 5:
                return "US 6.5";

            case 6:
                return "US 7";

            case 7:
                return "US 7.5";

            case 8:
                return "US 8";

            case 9:
                return "US 8.5";

            case 10:
                return "US 9";

            case 11:
                return "US 9.5";

            case 12:
                return "US 10";

            case 13:
                return "US 10.5";

            case 14:
                return "US 11";

            case 15:
                return "US 11.5";

            case 0x10:
                return "US 12";

            case 0x11:
                return "US 12.5";

            case 0x12:
                return "US 13";

            case 0x13:
                return "US 13.5";

            case 20:
                return "US 14";

            case 0x15:
                return "US 15.5";

            case 0x16:
                return "XS";

            case 0x17:
                return "S";

            case 0x18:
                return "M";

            case 0x19:
                return "L";

            case 0x1a:
                return "XL";

            case 0x1b:
                return "2XL";

            case 0x1c:
                return "Kids 2";

            case 0x1d:
                return "Kids 3";

            case 30:
                return "Kids 4";

            case 0x1f:
                return "Kids 5";

            case 0x20:
                return "Kids 5.5";

            case 0x21:
                return "Kids 6";

            case 0x22:
                return "Kids 6.5";

            case 0x23:
                return "Kids 7";

            case 0x24:
                return "Kids 7.5";

            case 0x25:
                return "Kids 8";

            case 0x26:
                return "Kids 8.5";

            case 0x27:
                return "Kids 9";

            case 40:
                return "Kids 9.5";

            case 0x29:
                return "Kids 10";
        }
        return "Error";
    }

    public Thread method_0() => 
        this.thread_0;

    public void method_1(Thread thread_1)
    {
        this.thread_0 = thread_1;
    }

    public void method_2(string string_9)
    {
        string str = string_9.ToUpper().Trim();
        uint num = Class5.smethod_0(str);
        if (num <= 0xa70d3061)
        {
            if (num <= 0x54a35613)
            {
                if (num <= 0x1ceb7374)
                {
                    if (num <= 0xe9ee8da)
                    {
                        if (num <= 0x331a001)
                        {
                            switch (num)
                            {
                                case 0x2166374:
                                    if (str == "US 4.5")
                                    {
                                        this.size = 1;
                                    }
                                    return;

                                case 0x331a001:
                                    if (str != "EU 47 1/3")
                                    {
                                        return;
                                    }
                                    this.size = 0x11;
                                    break;
                            }
                        }
                        else if (num == 0x8c73ca6)
                        {
                            if (str == "700")
                            {
                                this.size = 0x11;
                            }
                        }
                        else if ((num == 0xe9ee8da) && (str == "630"))
                        {
                            this.size = 10;
                        }
                    }
                    else if (num <= 0x19acea39)
                    {
                        switch (num)
                        {
                            case 0x15392b9b:
                                if (str == "US 5.5")
                                {
                                    this.size = 3;
                                }
                                return;

                            case 0x19acea39:
                                if (str != "EU 44 2/3")
                                {
                                    return;
                                }
                                this.size = 13;
                                break;
                        }
                    }
                    else
                    {
                        switch (num)
                        {
                            case 0x1c7ca36f:
                                if (str == "EU 45 1/3")
                                {
                                    this.size = 14;
                                }
                                return;

                            case 0x1cc2def4:
                                if (str == "720")
                                {
                                    this.size = 0x13;
                                }
                                return;
                        }
                        if ((num == 0x1ceb7374) && (str == "US 11.5"))
                        {
                            this.size = 15;
                        }
                    }
                }
                else if (num <= 0x300e3b9b)
                {
                    if (num <= 0x2e908847)
                    {
                        switch (num)
                        {
                            case 0x22c526fd:
                                if (str == "730")
                                {
                                    this.size = 20;
                                }
                                return;

                            case 0x2e908847:
                                if (str != "EU 46 2/3")
                                {
                                    return;
                                }
                                this.size = 0x10;
                                break;
                        }
                    }
                    else if (num == 0x2fa7b386)
                    {
                        if (str == "560")
                        {
                            this.size = 3;
                        }
                    }
                    else if ((num == 0x300e3b9b) && (str == "US 10.5"))
                    {
                        this.size = 13;
                    }
                }
                else if (num <= 0x3bac4398)
                {
                    switch (num)
                    {
                        case 0x35a9fb8f:
                            if (str == "570")
                            {
                                this.size = 4;
                            }
                            return;

                        case 0x3bac4398:
                            if (str != "580")
                            {
                                return;
                            }
                            this.size = 5;
                            break;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x4bba145a:
                            if (str == "EU 38 2/3")
                            {
                                this.size = 4;
                            }
                            return;

                        case 0x5173b264:
                            if (str == "EU 36 2/3")
                            {
                                this.size = 1;
                            }
                            return;
                    }
                    if ((num == 0x54a35613) && (str == "EU 42 2/3"))
                    {
                        this.size = 10;
                    }
                }
            }
            else if (num <= 0x82998f48)
            {
                if (num <= 0x698baec8)
                {
                    if (num <= 0x56ba9140)
                    {
                        switch (num)
                        {
                            case 0x563d0c85:
                                if (str == "EU 40 2/3")
                                {
                                    this.size = 7;
                                }
                                return;

                            case 0x56ba9140:
                                if (str != "US 8.5")
                                {
                                    return;
                                }
                                this.size = 9;
                                break;
                        }
                    }
                    else if (num == 0x6513e271)
                    {
                        if (str == "XL")
                        {
                            this.size = 0x1a;
                        }
                    }
                    else if ((num == 0x698baec8) && (str == "US 15.5"))
                    {
                        this.size = 0x15;
                    }
                }
                else if (num <= 0x7285ee60)
                {
                    switch (num)
                    {
                        case 0x6e13f09c:
                            if (str == "XS")
                            {
                                this.size = 0x16;
                            }
                            return;

                        case 0x7285ee60:
                            if (str != "690")
                            {
                                return;
                            }
                            this.size = 0x10;
                            break;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0x78883669:
                            if (str == "680")
                            {
                                this.size = 15;
                            }
                            return;

                        case 0x80a65815:
                            if (str == "640")
                            {
                                this.size = 11;
                            }
                            return;
                    }
                    if ((num == 0x82998f48) && (str == "610"))
                    {
                        this.size = 8;
                    }
                }
            }
            else if (num <= 0x8a5d3fc0)
            {
                if (num <= 0x86a8a01e)
                {
                    switch (num)
                    {
                        case 0x84b8f550:
                            if (str == "760")
                            {
                                this.size = 0x15;
                            }
                            return;

                        case 0x86a8a01e:
                            if (str != "670")
                            {
                                return;
                            }
                            this.size = 14;
                            break;
                    }
                }
                else if (num == 0x889bd751)
                {
                    if (str == "600")
                    {
                        this.size = 7;
                    }
                }
                else if ((num == 0x8a5d3fc0) && (str == "EU 39 1/3"))
                {
                    this.size = 5;
                }
            }
            else if (num <= 0x8eca4e2f)
            {
                switch (num)
                {
                    case 0x8caae827:
                        if (str == "660")
                        {
                            this.size = 13;
                        }
                        return;

                    case 0x8eca4e2f:
                        if (str != "710")
                        {
                            return;
                        }
                        this.size = 0x12;
                        break;
                }
            }
            else
            {
                switch (num)
                {
                    case 0x966ce34a:
                        if (str == "EU 51 1/3")
                        {
                            this.size = 0x15;
                        }
                        return;

                    case 0xa1757e33:
                        if (str == "EU 49 1/3")
                        {
                            this.size = 20;
                        }
                        return;
                }
                if ((num == 0xa70d3061) && (str == "2XL"))
                {
                    this.size = 0x1a;
                }
            }
        }
        else if (num <= 0xc90bfeab)
        {
            if (num <= 0xbe00e24d)
            {
                if (num <= 0xb800d8db)
                {
                    if (num <= 0xb00d9836)
                    {
                        switch (num)
                        {
                            case 0xabc7ed2a:
                                if (str == "US 6.5")
                                {
                                    this.size = 5;
                                }
                                return;

                            case 0xb00d9836:
                                if (str != "EU 38")
                                {
                                    return;
                                }
                                this.size = 3;
                                break;
                        }
                    }
                    else if (num == 0xb200cf69)
                    {
                        if (str == "EU 48")
                        {
                            this.size = 0x12;
                        }
                    }
                    else if ((num == 0xb800d8db) && (str == "EU 42"))
                    {
                        this.size = 9;
                    }
                }
                else if (num <= 0xba0da7f4)
                {
                    switch (num)
                    {
                        case 0xba00dc01:
                            if (str == "EU 40")
                            {
                                this.size = 6;
                            }
                            return;

                        case 0xba0da7f4:
                            if (str != "EU 36")
                            {
                                return;
                            }
                            this.size = 0;
                            break;
                    }
                }
                else
                {
                    switch (num)
                    {
                        case 0xbc00df27:
                            if (str == "EU 46")
                            {
                                this.size = 15;
                            }
                            return;

                        case 0xbda0444b:
                            if (str == "530")
                            {
                                this.size = 0;
                            }
                            return;
                    }
                    if ((num == 0xbe00e24d) && (str == "EU 44"))
                    {
                        this.size = 12;
                    }
                }
            }
            else if (num <= 0xc1b191e6)
            {
                if (num <= 0xbeeab551)
                {
                    switch (num)
                    {
                        case 0xbe35a56d:
                            if (str == "EU 43 1/3")
                            {
                                this.size = 11;
                            }
                            return;

                        case 0xbeeab551:
                            if (str != "US 7.5")
                            {
                                return;
                            }
                            this.size = 7;
                            break;
                    }
                }
                else if (num == 0xc1af5521)
                {
                    if (str == "590")
                    {
                        this.size = 6;
                    }
                }
                else if ((num == 0xc1b191e6) && (str == "US 9"))
                {
                    this.size = 10;
                }
            }
            else if (num <= 0xc3a28c54)
            {
                switch (num)
                {
                    case 0xc2b19379:
                        if (str == "US 8")
                        {
                            this.size = 8;
                        }
                        return;

                    case 0xc3a28c54:
                        if (str != "540")
                        {
                            return;
                        }
                        this.size = 1;
                        break;
                }
            }
            else
            {
                switch (num)
                {
                    case 0xc69cfd2a:
                        if (str == "US 13.5")
                        {
                            this.size = 0x13;
                        }
                        return;

                    case 0xc80bfd18:
                        if (str == "M")
                        {
                            this.size = 0x18;
                        }
                        return;
                }
                if ((num == 0xc90bfeab) && (str == "L"))
                {
                    this.size = 0x19;
                }
            }
        }
        else if (num <= 0xceb1a65d)
        {
            if (num <= 0xcc9c2e7e)
            {
                if (num <= 0xcb2936bb)
                {
                    switch (num)
                    {
                        case 0xc9a4d45d:
                            if (str == "550")
                            {
                                this.size = 2;
                            }
                            return;

                        case 0xcb2936bb:
                            if (str != "EU 41 1/3")
                            {
                                return;
                            }
                            this.size = 8;
                            break;
                    }
                }
                else if (num == 0xcbb1a1a4)
                {
                    if (str == "US 7")
                    {
                        this.size = 6;
                    }
                }
                else if ((num == 0xcc9c2e7e) && (str == "US 14"))
                {
                    this.size = 20;
                }
            }
            else if (num <= 0xcdb1a4ca)
            {
                switch (num)
                {
                    case 0xccb1a337:
                        if (str == "US 6")
                        {
                            this.size = 4;
                        }
                        return;

                    case 0xcdb1a4ca:
                        if (str != "US 5")
                        {
                            return;
                        }
                        this.size = 2;
                        break;
                }
            }
            else
            {
                switch (num)
                {
                    case 0xce9c31a4:
                        if (str == "US 12")
                        {
                            this.size = 0x10;
                        }
                        return;

                    case 0xcea4c2ae:
                        if (str == "EU 37 1/3")
                        {
                            this.size = 2;
                        }
                        return;
                }
                if ((num == 0xceb1a65d) && (str == "US 4"))
                {
                    this.size = 0;
                }
            }
        }
        else if (num <= 0xd2a231bd)
        {
            if (num <= 0xd09c34ca)
            {
                switch (num)
                {
                    case 0xcf9c3337:
                        if (str == "US 13")
                        {
                            this.size = 0x12;
                        }
                        return;

                    case 0xd09c34ca:
                        if (str != "US 10")
                        {
                            return;
                        }
                        this.size = 12;
                        break;
                }
            }
            else if (num == 0xd19c365d)
            {
                if (str == "US 11")
                {
                    this.size = 14;
                }
            }
            else if ((num == 0xd2a231bd) && (str == "EU 48 2/3"))
            {
                this.size = 0x13;
            }
        }
        else if (num <= 0xd9bfc551)
        {
            switch (num)
            {
                case 0xd60c1322:
                    if (str == "S")
                    {
                        this.size = 0x17;
                    }
                    return;

                case 0xd9bfc551:
                    if (str != "US 12.5")
                    {
                        return;
                    }
                    this.size = 0x11;
                    break;
            }
        }
        else
        {
            switch (num)
            {
                case 0xf4a0fe83:
                    if (str == "620")
                    {
                        this.size = 9;
                    }
                    return;

                case 0xf9de3c17:
                    if (str == "US 9.5")
                    {
                        this.size = 11;
                    }
                    return;
            }
            if ((num == 0xfaa3468c) && (str == "650"))
            {
                this.size = 12;
            }
        }
    }

    public string method_3()
    {
        if (this.isAdidasSize)
        {
            return (this.size.ToString() + Class21.string_3);
        }
        string str = "530";
        switch (this.size)
        {
            case 1:
                str = "540";
                break;

            case 2:
                str = "550";
                break;

            case 3:
                str = "560";
                break;

            case 4:
                str = "570";
                break;

            case 5:
                str = "580";
                break;

            case 6:
                str = "590";
                break;

            case 7:
                str = "600";
                break;

            case 8:
                str = "610";
                break;

            case 9:
                str = "620";
                break;

            case 10:
                str = "630";
                break;

            case 11:
                str = "640";
                break;

            case 12:
                str = "650";
                break;

            case 13:
                str = "660";
                break;

            case 14:
                str = "670";
                break;

            case 15:
                str = "680";
                break;

            case 0x10:
                str = "690";
                break;

            case 0x11:
                str = "700";
                break;

            case 0x12:
                str = "710";
                break;

            case 0x13:
                str = "720";
                break;

            case 20:
                str = "730";
                break;

            case 0x15:
                str = "760";
                break;

            case 0x16:
                str = "290";
                break;

            case 0x17:
                str = "310";
                break;

            case 0x18:
                str = "330";
                break;

            case 0x19:
                str = "350";
                break;

            case 0x1a:
                str = "370";
                break;

            case 0x1b:
                str = "390";
                break;

            case 0x1c:
                str = "210";
                break;

            case 0x1d:
                str = "220";
                break;

            case 30:
                str = "230";
                break;

            case 0x1f:
                str = "240";
                break;

            case 0x20:
                str = "250";
                break;

            case 0x21:
                str = "260";
                break;

            case 0x22:
                str = "270";
                break;

            case 0x23:
                str = "280";
                break;

            case 0x24:
                str = "290";
                break;

            case 0x25:
                str = "310";
                break;

            case 0x26:
                str = "320";
                break;

            case 0x27:
                str = "330";
                break;

            case 40:
                str = "340";
                break;

            case 0x29:
                str = "350";
                break;
        }
        return (str + Class21.string_3);
    }

    public string additionalParams
    {
        [CompilerGenerated]
        get => 
            this.string_2;
        [CompilerGenerated]
        set
        {
            this.string_2 = value;
        }
    }

    public string adiName
    {
        [CompilerGenerated]
        get => 
            this.string_7;
        [CompilerGenerated]
        set
        {
            this.string_7 = value;
        }
    }

    public string adiPw
    {
        [CompilerGenerated]
        get => 
            this.string_8;
        [CompilerGenerated]
        set
        {
            this.string_8 = value;
        }
    }

    [ExcludeFromSerialization]
    public BrowserForm autoCheckoutBrowserForm
    {
        [CompilerGenerated]
        get => 
            this.browserForm_0;
        [CompilerGenerated]
        set
        {
            this.browserForm_0 = value;
        }
    }

    public int autoCheckoutState
    {
        [CompilerGenerated]
        get => 
            this.int_4;
        [CompilerGenerated]
        set
        {
            this.int_4 = value;
        }
    }

    public bool automaticNoTokenNotified
    {
        [CompilerGenerated]
        get => 
            this.bool_3;
        [CompilerGenerated]
        set
        {
            this.bool_3 = value;
        }
    }

    public bool automaticStart
    {
        [CompilerGenerated]
        get => 
            this.bool_2;
        [CompilerGenerated]
        set
        {
            this.bool_2 = value;
        }
    }

    public string captchaDuplicate
    {
        [CompilerGenerated]
        get => 
            this.string_1;
        [CompilerGenerated]
        set
        {
            this.string_1 = value;
        }
    }

    public GClass4 checkoutProfile
    {
        [CompilerGenerated]
        get => 
            this.gclass4_0;
        [CompilerGenerated]
        set
        {
            this.gclass4_0 = value;
        }
    }

    public int checkoutType
    {
        [CompilerGenerated]
        get => 
            this.int_3;
        [CompilerGenerated]
        set
        {
            this.int_3 = value;
        }
    }

    public CookieContainer cookieCont
    {
        [CompilerGenerated]
        get => 
            this.cookieContainer_0;
        [CompilerGenerated]
        set
        {
            this.cookieContainer_0 = value;
        }
    }

    public ArrayList cookieList
    {
        [CompilerGenerated]
        get => 
            this.arrayList_0;
        [CompilerGenerated]
        set
        {
            this.arrayList_0 = value;
        }
    }

    public bool euSizes
    {
        [CompilerGenerated]
        get => 
            this.bool_4;
        [CompilerGenerated]
        set
        {
            this.bool_4 = value;
        }
    }

    public int id
    {
        [CompilerGenerated]
        get => 
            this.int_0;
        [CompilerGenerated]
        set
        {
            this.int_0 = value;
        }
    }

    public bool isAdidasSize
    {
        [CompilerGenerated]
        get => 
            this.bool_5;
        [CompilerGenerated]
        set
        {
            this.bool_5 = value;
        }
    }

    public bool isCheckout
    {
        [CompilerGenerated]
        get => 
            this.bool_6;
        [CompilerGenerated]
        set
        {
            this.bool_6 = value;
        }
    }

    public bool isRunning
    {
        [CompilerGenerated]
        get => 
            this.bool_7;
        [CompilerGenerated]
        set
        {
            this.bool_7 = value;
        }
    }

    public bool isStarted
    {
        [CompilerGenerated]
        get => 
            this.bool_1;
        [CompilerGenerated]
        set
        {
            this.bool_1 = value;
        }
    }

    public int locationIndex
    {
        [CompilerGenerated]
        get => 
            this.int_2;
        [CompilerGenerated]
        set
        {
            this.int_2 = value;
        }
    }

    public bool needsCaptcha
    {
        [CompilerGenerated]
        get => 
            this.bool_0;
        [CompilerGenerated]
        set
        {
            this.bool_0 = value;
        }
    }

    public string pid
    {
        [CompilerGenerated]
        get => 
            this.string_0;
        [CompilerGenerated]
        set
        {
            this.string_0 = value;
        }
    }

    public string proxy
    {
        [CompilerGenerated]
        get => 
            this.string_3;
        [CompilerGenerated]
        set
        {
            this.string_3 = value;
        }
    }

    public string proxyPW
    {
        [CompilerGenerated]
        get => 
            this.string_5;
        [CompilerGenerated]
        set
        {
            this.string_5 = value;
        }
    }

    public string proxyUsername
    {
        [CompilerGenerated]
        get => 
            this.string_4;
        [CompilerGenerated]
        set
        {
            this.string_4 = value;
        }
    }

    public int size
    {
        [CompilerGenerated]
        get => 
            this.int_1;
        [CompilerGenerated]
        set
        {
            this.int_1 = value;
        }
    }

    public string startTime
    {
        [CompilerGenerated]
        get => 
            this.string_6;
        [CompilerGenerated]
        set
        {
            this.string_6 = value;
        }
    }

    public DateTime timeOfCompletion
    {
        [CompilerGenerated]
        get => 
            this.dateTime_0;
        [CompilerGenerated]
        set
        {
            this.dateTime_0 = value;
        }
    }
}

