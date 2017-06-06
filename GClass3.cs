using System;

public sealed class GClass3
{
    private readonly double? nullable_0;
    private readonly int? nullable_1;
    private readonly int? nullable_2;
    private readonly int? nullable_3;
    private readonly int? nullable_4;
    private readonly GEnum0? nullable_5;
    private readonly string string_0;
    private readonly string string_1;
    private readonly string string_2;
    private readonly string string_3;

    public GClass3(GEnum0? nullable_6, string string_4, int? nullable_7, string string_5, string string_6, double? nullable_8, string string_7, int? nullable_9, int? nullable_10, int? nullable_11)
    {
        this.nullable_3 = nullable_7;
        this.string_0 = string_5;
        this.string_1 = string_6;
        this.nullable_5 = nullable_6;
        this.string_3 = string_4;
        this.nullable_0 = nullable_8;
        this.string_2 = string_7;
        this.nullable_1 = nullable_9;
        this.nullable_2 = nullable_10;
        this.nullable_4 = nullable_11;
    }

    public int? method_0() => 
        this.nullable_3;

    public string method_1() => 
        this.string_0;

    public string method_2() => 
        this.string_1;

    public GEnum0? method_3() => 
        this.nullable_5;

    public string method_4() => 
        this.string_3;

    public double? method_5() => 
        this.nullable_0;

    public string method_6() => 
        this.string_2;

    public int? method_7() => 
        this.nullable_1;

    public int? method_8() => 
        this.nullable_2;

    public int? method_9() => 
        this.nullable_4;

    public override string ToString()
    {
        object[] objArray1 = new object[] { 
            "AnticaptchaResult{errorId=", this.nullable_3, ", errorCode='", this.string_0, "', errorDescription='", this.string_1, "', status=", this.nullable_5, ", solution='", this.string_3, "', cost=", this.nullable_0, ", ip='", this.string_2, "', createTime=", this.nullable_1,
            ", endTime=", this.nullable_2, ", solveCount=", this.nullable_4, "}"
        };
        return string.Concat(objArray1);
    }

    public enum GEnum0
    {
    }
}

