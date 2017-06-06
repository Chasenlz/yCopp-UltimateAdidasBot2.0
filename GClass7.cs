using System;

public sealed class GClass7
{
    private readonly int? nullable_0;
    private readonly int? nullable_1;
    private readonly string string_0;
    private readonly string string_1;

    public GClass7(int? nullable_2, int? nullable_3, string string_2, string string_3)
    {
        this.nullable_0 = nullable_3;
        this.nullable_1 = nullable_2;
        this.string_0 = string_2;
        this.string_1 = string_3;
    }

    public string method_0() => 
        this.string_0;

    public string method_1() => 
        this.string_1;

    public int? method_2() => 
        this.nullable_1;

    public int? method_3() => 
        this.nullable_0;

    public override string ToString()
    {
        object[] objArray1 = new object[] { "AnticaptchaTask{errorId=", this.nullable_0, ", taskId=", this.nullable_1, ", errorCode='", this.string_0, "', errorDescription='", this.string_1, "'}" };
        return string.Concat(objArray1);
    }
}

