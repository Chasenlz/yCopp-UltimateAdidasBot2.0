using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

internal static class Class6
{
    private static Class8 class8_0 = new Class8();

    internal static long smethod_0()
    {
        if ((Assembly.GetCallingAssembly() != typeof(Class6).Assembly) || !smethod_1())
        {
            return 0L;
        }
        lock (class8_0)
        {
            long num2 = class8_0.method_0();
            if (num2 == 0L)
            {
                AssemblyName name;
                Assembly executingAssembly = Assembly.GetExecutingAssembly();
                List<byte> list = new List<byte>();
                try
                {
                    name = executingAssembly.GetName();
                }
                catch
                {
                    name = new AssemblyName(executingAssembly.FullName);
                }
                byte[] publicKeyToken = name.GetPublicKeyToken();
                if ((publicKeyToken != null) && (publicKeyToken.Length == 0))
                {
                    publicKeyToken = null;
                }
                if (publicKeyToken != null)
                {
                    list.AddRange(publicKeyToken);
                }
                list.AddRange(Encoding.Unicode.GetBytes(name.Name));
                int num4 = smethod_3(typeof(Class6));
                int num5 = Class12.smethod_0();
                list.Add((byte) (num4 >> 8));
                list.Add((byte) num5);
                list.Add((byte) (num4 >> 0x10));
                list.Add((byte) (num5 >> 8));
                list.Add((byte) num4);
                list.Add((byte) (num5 >> 0x18));
                list.Add((byte) (num4 >> 0x18));
                list.Add((byte) (num5 >> 0x10));
                int count = list.Count;
                ulong num = 0L;
                for (int i = 0; i != count; i++)
                {
                    num += (ulong) list[i];
                    num += num << 20;
                    num ^= num >> 12;
                    list[i] = 0;
                }
                num += num << 6;
                num ^= num >> 0x16;
                num += num << 30;
                num2 = (long) num;
                num2 ^= -4792907524311011554L;
                class8_0.method_1(num2);
            }
            return num2;
        }
    }

    private static bool smethod_1()
    {
        if (!smethod_2())
        {
            return false;
        }
        return true;
    }

    private static bool smethod_2()
    {
        StackFrame frame = new StackTrace().GetFrame(3);
        MethodBase method = frame?.GetMethod();
        Type declaringType = method?.DeclaringType;
        if (declaringType == typeof(RuntimeMethodHandle))
        {
            return false;
        }
        if (declaringType == null)
        {
            return false;
        }
        if (declaringType.Assembly != typeof(Class6).Assembly)
        {
            return false;
        }
        return true;
    }

    private static int smethod_3(Type type_0) => 
        type_0.MetadataToken;

    private sealed class Class10
    {
        internal static int smethod_0() => 
            Class6.Class14.smethod_1(Class6.Class14.smethod_1(Class6.Class13.smethod_0(), Class6.Class14.smethod_0(Class6.smethod_3(typeof(Class6.Class10)), Class6.Class9.smethod_0())), Class6.smethod_3(typeof(Class6.Class11)));
    }

    private sealed class Class11
    {
        internal static int smethod_0() => 
            Class6.Class14.smethod_0(Class6.smethod_3(typeof(Class6.Class11)), Class6.Class14.smethod_2(Class6.Class14.smethod_1(Class6.smethod_3(typeof(Class6.Class10)), Class6.smethod_3(typeof(Class6.Class12))), Class6.Class14.smethod_2(Class6.smethod_3(typeof(Class6.Class13)) ^ -1022851505, Class6.Class10.smethod_0())));
    }

    private sealed class Class12
    {
        internal static int smethod_0() => 
            Class6.Class14.smethod_2(Class6.Class14.smethod_1(Class6.smethod_3(typeof(Class6.Class9)), Class6.Class14.smethod_2(Class6.smethod_3(typeof(Class6.Class12)), Class6.smethod_3(typeof(Class6.Class10)))), Class6.Class11.smethod_0());
    }

    private sealed class Class13
    {
        internal static int smethod_0() => 
            Class6.Class14.smethod_2(Class6.Class14.smethod_0(Class6.Class9.smethod_0() ^ 0x1f74f46e, Class6.smethod_3(typeof(Class6.Class7))), Class6.Class14.smethod_1(Class6.smethod_3(typeof(Class6.Class12)) ^ Class6.smethod_3(typeof(Class6.Class11)), 0x61087975));
    }

    private static class Class14
    {
        internal static int smethod_0(int int_0, int int_1) => 
            (int_0 ^ (int_1 - -1319628536));

        internal static int smethod_1(int int_0, int int_1) => 
            ((int_0 - 0x28962eec) ^ (int_1 + 0x1a404c7a));

        internal static int smethod_2(int int_0, int int_1) => 
            (int_0 ^ ((int_1 - -1670793542) ^ (int_0 - int_1)));
    }

    private sealed class Class7
    {
        internal static int smethod_0() => 
            Class6.Class14.smethod_2(Class6.smethod_3(typeof(Class6.Class7)), Class6.Class14.smethod_0(Class6.smethod_3(typeof(Class6.Class12)), Class6.Class14.smethod_1(Class6.smethod_3(typeof(Class6.Class9)), Class6.Class14.smethod_2(Class6.smethod_3(typeof(Class6.Class13)), Class6.Class14.smethod_0(Class6.smethod_3(typeof(Class6.Class10)), Class6.smethod_3(typeof(Class6.Class11)))))));
    }

    private sealed class Class8
    {
        private int int_0;
        private int int_1;

        internal Class8()
        {
            this.method_1(0L);
        }

        internal long method_0()
        {
            if (Assembly.GetCallingAssembly() != typeof(Class6.Class8).Assembly)
            {
                return 0x2c87f0L;
            }
            if (!Class6.smethod_1())
            {
                return 0x2c87f0L;
            }
            int[] numArray = new int[4];
            numArray[3] = 0x3092a556;
            numArray[1] = -1320707042;
            numArray[2] = 0xc319a81;
            numArray[0] = 0x64b1a973;
            int num = this.int_0;
            int num2 = this.int_1;
            int num7 = -1640531527;
            int num3 = -957401312;
            for (int i = 0; i != 0x20; i++)
            {
                num2 -= (((num << 4) ^ (num >> 5)) + num) ^ (num3 + numArray[(num3 >> 11) & 3]);
                num3 -= num7;
                num -= (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num3 + numArray[num3 & 3]);
            }
            for (int j = 0; j != 4; j++)
            {
                numArray[j] = 0;
            }
            ulong num6 = ((ulong) num2) << 0x20;
            num6 |= (ulong) num;
            return (long) num6;
        }

        internal void method_1(long long_0)
        {
            if ((Assembly.GetCallingAssembly() == typeof(Class6.Class8).Assembly) && Class6.smethod_1())
            {
                int[] numArray = new int[4];
                numArray[1] = -1320707042;
                numArray[0] = 0x64b1a973;
                numArray[2] = 0xc319a81;
                numArray[3] = 0x3092a556;
                int num6 = -1640531527;
                int num = (int) long_0;
                int num2 = (int) (long_0 >> 0x20);
                int num3 = 0;
                for (int i = 0; i != 0x20; i++)
                {
                    num += (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num3 + numArray[num3 & 3]);
                    num3 += num6;
                    num2 += (((num << 4) ^ (num >> 5)) + num) ^ (num3 + numArray[(num3 >> 11) & 3]);
                }
                for (int j = 0; j != 4; j++)
                {
                    numArray[j] = 0;
                }
                this.int_0 = num;
                this.int_1 = num2;
            }
        }
    }

    private sealed class Class9
    {
        internal static int smethod_0() => 
            Class6.Class14.smethod_0(Class6.smethod_3(typeof(Class6.Class13)), Class6.smethod_3(typeof(Class6.Class7)) ^ Class6.Class14.smethod_1(Class6.smethod_3(typeof(Class6.Class9)), Class6.Class14.smethod_2(Class6.smethod_3(typeof(Class6.Class11)), Class6.Class7.smethod_0())));
    }
}

