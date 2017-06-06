using System;
using System.Runtime.CompilerServices;

public sealed class GClass4
{
    private bool bool_0;
    private int int_0;
    private int int_1;
    private int int_2;
    private int int_3;
    private int int_4;
    private string string_0;
    private string string_1;
    private string string_10;
    private string string_11;
    private string string_12;
    private string string_13;
    private string string_2;
    private string string_3;
    private string string_4;
    private string string_5;
    private string string_6;
    private string string_7;
    private string string_8;
    private string string_9;

    public GClass4()
    {
    }

    public GClass4(string string_14, int int_5, int int_6, string string_15, string string_16, bool bool_1)
    {
        this.profileName = string_14;
        this.countryCode = int_5;
        this.paymentMethod = int_6;
        this.ppLogin = string_15;
        this.ppPw = string_16;
        this.useProxy = bool_1;
    }

    public GClass4(string string_14, int int_5, int int_6, string string_15, string string_16, string string_17, string string_18, string string_19, string string_20, int int_7, string string_21, string string_22, string string_23, string string_24, int int_8, int int_9, string string_25, bool bool_1)
    {
        this.profileName = string_14;
        this.countryCode = int_5;
        this.paymentMethod = int_6;
        this.name = string_15;
        this.lastName = string_16;
        this.address1 = string_17;
        this.address2 = string_18;
        this.city = string_19;
        this.postalCode = string_20;
        this.stateCode = int_7;
        this.phoneNumber = string_21;
        this.email = string_22;
        this.cardName = string_23;
        this.cardNumber = string_24;
        this.expireMonth = int_8;
        this.expireYear = int_9;
        this.cvc = string_25;
        this.useProxy = bool_1;
    }

    public GClass4 method_0()
    {
        if (this.paymentMethod == 0)
        {
            return new GClass4(this.profileName, this.countryCode, this.paymentMethod, this.name, this.lastName, this.address1, this.address2, this.city, this.postalCode, this.stateCode, this.phoneNumber, this.email, this.cardName, this.cardNumber, this.expireMonth, this.expireYear, this.cvc, this.useProxy);
        }
        return new GClass4(this.profileName, this.countryCode, this.paymentMethod, this.ppLogin, this.ppPw, this.useProxy);
    }

    public string method_1() => 
        this.profileName;

    public string address1
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

    public string address2
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

    public string cardName
    {
        [CompilerGenerated]
        get => 
            this.string_9;
        [CompilerGenerated]
        set
        {
            this.string_9 = value;
        }
    }

    public string cardNumber
    {
        [CompilerGenerated]
        get => 
            this.string_10;
        [CompilerGenerated]
        set
        {
            this.string_10 = value;
        }
    }

    public string city
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

    public int countryCode
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

    public string cvc
    {
        [CompilerGenerated]
        get => 
            this.string_11;
        [CompilerGenerated]
        set
        {
            this.string_11 = value;
        }
    }

    public string email
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

    public int expireMonth
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

    public int expireYear
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

    public string lastName
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

    public string name
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

    public int paymentMethod
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

    public string phoneNumber
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

    public string postalCode
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

    public string ppLogin
    {
        [CompilerGenerated]
        get => 
            this.string_12;
        [CompilerGenerated]
        set
        {
            this.string_12 = value;
        }
    }

    public string ppPw
    {
        [CompilerGenerated]
        get => 
            this.string_13;
        [CompilerGenerated]
        set
        {
            this.string_13 = value;
        }
    }

    public string profileName
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

    public int stateCode
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

    public bool useProxy
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
}

