using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

internal static class Class57
{
    private static byte[] byte_0;
    private static byte[] byte_1;
    private static Class58 class58_0;
    private static Class59 class59_0;
    private static Enum0 enum0_0;
    private static int int_0;
    private static int int_1;
    private static int int_2;
    private static short short_0;

    static Class57()
    {
        int num2 = 0x55276e7c;
        int num3 = -437084894;
        class59_0 = new Class59(0x68b);
        int num4 = 2;
        StackTrace trace = new StackTrace(2, false);
        num4 = 0;
        StackFrame frame = trace.GetFrame(0);
        int num5 = 0;
        if (frame == null)
        {
            trace = new StackTrace();
            num5 = 1;
            frame = trace.GetFrame(1);
        }
        int num = ~-~--~-~~-~((0x45dc2cf2 + num2) - num3) ^ ~--~-~~-~-~((0x5c7a7374 - num2) + num3);
        MethodBase method = frame?.GetMethod();
        if (frame != null)
        {
            num ^= -~-~~--~~((0x5d93f35f ^ num2) ^ num3);
        }
        Type declaringType = method?.DeclaringType;
        if (declaringType == typeof(RuntimeMethodHandle))
        {
            num ^= ((num2 + -1865731635) - num3) + num4;
            enum0_0 = ((Enum0) 4) | enum0_0;
        }
        else if (declaringType == null)
        {
            if (smethod_4(trace, num5))
            {
                num ^= -~~--~-~~((0x6f34adbb - num2) ^ num3) - num4;
                enum0_0 = ((Enum0) 0x10) | enum0_0;
            }
            else
            {
                num ^= -~~-~--~~-~((num2 + -1865769490) - num3);
                enum0_0 = ((Enum0) 1) | enum0_0;
            }
        }
        else
        {
            enum0_0 |= (Enum0) 0x10;
            num ^= ~--~~-~-~((0x6f34adb7 - num2) ^ num3) - num4;
        }
        int_2 = num + int_2;
    }

    internal static string smethod_0(int int_3)
    {
        Class59 class2 = class59_0;
        lock (class2)
        {
            string str = class59_0.method_2(int_3);
            if (str != null)
            {
                return str;
            }
            return smethod_1(int_3, true);
        }
    }

    private static string smethod_1(int int_3, bool bool_0)
    {
        int num = -1827340969;
        int num2 = -360735532;
        string str = null;
        while (class58_0 != null)
        {
            int num4;
            StringBuilder builder;
            byte[] buffer2;
            Assembly assembly2;
            int num3 = int_1;
        Label_001A:
            if (int_0 == ((0x7d9434c5 - num) ^ num2))
            {
                return new string(new char[] { (num ^ 0x796b607b) - num2, '0', (0x576a9f35 + num) ^ num2 });
            }
            int num13 = (int_3 ^ ((-1679363405 ^ num) - num2)) ^ num3;
            num13 ^= (num + -605645539) + num2;
            class58_0.method_0().Position = num13;
            if (byte_1 != null)
            {
                buffer2 = byte_1;
            }
            else
            {
                short num21;
                if (short_0 == -1)
                {
                    num21 = (short) ((class58_0.method_1() ^ ((num ^ 0x796b7387) ^ num2)) ^ num13);
                }
                else
                {
                    num21 = short_0;
                }
                if (num21 == 0)
                {
                    buffer2 = null;
                }
                else
                {
                    buffer2 = class58_0.method_6(num21);
                    for (int i = 0; i != buffer2.Length; i++)
                    {
                        buffer2[i] = (byte) (buffer2[i] ^ ((byte) (int_1 >> ((3 & i) << 3))));
                    }
                }
            }
            int num5 = ((class58_0.method_2() ^ num13) ^ -~~--~-~~-~((0x7d9a0a6b - num) - num2)) ^ num3;
            if (num5 != ((-2037080451 ^ num) | num2))
            {
                byte[] buffer3;
                int num15;
                bool flag2 = (num5 & ((num ^ -110403197) ^ num2)) > 0;
                bool flag4 = (num5 & ((num + -1754620035) - num2)) > 0;
                bool flag3 = (num5 & ((0x5d949a2b - num) ^ num2)) > 0;
                num5 &= (-1231774084 ^ num) + num2;
                byte[] buffer4 = class58_0.method_6(num5);
                byte[] buffer6 = buffer2;
                byte num24 = buffer6[1];
                int length = buffer4.Length;
                byte num20 = (byte) ((length + 11) ^ (7 + num24));
                uint num19 = (uint) ((buffer6[0] | (buffer6[2] << 8)) + (num20 << 3));
                int index = 0;
                ushort num16 = 0;
                while (index < length)
                {
                    if ((index & 1) == 0)
                    {
                        num19 = (uint) ((num19 * ((num + 0x5767e1d2) ^ num2)) + ((0x7dbb38ee - num) - num2));
                        num16 = (ushort) (num19 >> 0x10);
                    }
                    byte num30 = (byte) num16;
                    num16 = (ushort) (num16 >> 8);
                    byte num23 = buffer4[index];
                    buffer4[index] = (byte) (((num23 ^ num24) ^ (num20 + 3)) ^ num30);
                    index++;
                    num20 = num23;
                }
                byte[] buffer = buffer4;
                if ((byte_0 > null) != (int_0 != ((-2105282981 + num) + num2)))
                {
                    for (int j = 0; j < num5; j = 1 + j)
                    {
                        byte num14 = byte_0[j & 7];
                        num14 = (byte) ((num14 << 3) | (num14 >> 5));
                        buffer[j] = (byte) (buffer[j] ^ num14);
                    }
                }
                int num8 = int_0 - 12;
                if (!flag4)
                {
                    buffer3 = buffer;
                    num15 = num5;
                }
                else
                {
                    num15 = ((buffer[2] | (buffer[0] << 0x10)) | (buffer[3] << 8)) | (buffer[1] << 0x18);
                    buffer3 = new byte[num15];
                    smethod_5(buffer, 4, buffer3);
                }
                if (flag2 && (num8 == ((0x798cd819 ^ num) - num2)))
                {
                    char[] chArray2 = new char[num15];
                    for (int k = 0; k < num15; k = 1 + k)
                    {
                        chArray2[k] = (char) buffer3[k];
                    }
                    str = new string(chArray2);
                }
                else
                {
                    str = Encoding.Unicode.GetString(buffer3, 0, buffer3.Length);
                }
                num8 += (((num + -2106890668) + num2) + (3 & num8)) << 5;
                if (num8 != ((0x7973f919 ^ num) ^ num2))
                {
                    int num34 = ((num5 + int_3) ^ ((-2105954227 + num) + num2)) ^ (num8 & ((0x7d949f38 - num) - num2));
                    builder = new StringBuilder();
                    num4 = (num + 0x576a9f35) ^ num2;
                    builder.Append((char) ((byte) num4));
                    str = num34.ToString(builder.ToString());
                }
                if ((false == flag3) & bool_0)
                {
                    str = string.Intern(str);
                    class59_0.method_3(int_3, str);
                }
                return str;
            }
            byte[] buffer5 = class58_0.method_6(4);
            int_3 = ((-1466961853 - num) + num2) ^ num3;
            int_3 = (((buffer5[2] | (buffer5[3] << 0x10)) | (buffer5[0] << 8)) | (buffer5[1] << 0x18)) ^ -int_3;
            str = class59_0.method_2(int_3);
            if (str == null)
            {
                continue;
            }
            return str;
        Label_016E:
            assembly2 = Assembly.GetExecutingAssembly();
            Assembly callingAssembly = Assembly.GetCallingAssembly();
            int_0 |= (0x7d7c0bad - num) ^ num2;
            builder = new StringBuilder();
            num4 = (-1718402686 ^ num) - num2;
            builder.Append((char) num4).Append((char) (num4 >> 0x10));
            num4 = (0x5d8eba33 - num) ^ num2;
            builder.Append((char) (num4 >> 0x10)).Append((char) num4);
            num4 = (-1500348829 ^ num) + num2;
            builder.Append((char) num4).Append((char) (num4 >> 0x10));
            num4 = (-1650607566 - num) - num2;
            builder.Append((char) num4).Append((char) (num4 >> 0x10));
            num4 = (-1500217736 ^ num) + num2;
            builder.Append((char) (num4 >> 0x10)).Append((char) num4);
            Stream manifestResourceStream = assembly2.GetManifestResourceStream(builder.ToString());
            int num6 = 2;
            StackTrace trace = new StackTrace(2, false);
            int_0 ^= ((num + 0x576a883b) ^ num2) | 2;
            num6 = 0;
            StackFrame frame = trace.GetFrame(0);
            int num17 = 0;
            if (frame == null)
            {
                trace = new StackTrace();
                num17 = 1;
                frame = trace.GetFrame(1);
            }
            MethodBase method = frame?.GetMethod();
            int_0 ^= num6 + ((-2037080325 ^ num) + num2);
            Type declaringType = method?.DeclaringType;
            if (frame == null)
            {
                int_0 ^= (0x5767c710 + num) ^ num2;
            }
            bool flag = declaringType == typeof(RuntimeMethodHandle);
            int_0 ^= (num ^ -2037080421) + num2;
            if (!flag && (flag = declaringType == null))
            {
                if (smethod_4(trace, num17))
                {
                    flag = false;
                }
                else
                {
                    int_0 ^= (0x7d97f2be - num) - num2;
                }
            }
            if (flag == (trace > null))
            {
                int_0 = 0x20 ^ int_0;
            }
            int_0 ^= ((0x576a885b + num) ^ num2) | (1 + num6);
            class58_0 = new Class58(manifestResourceStream);
            short num25 = (short) (class58_0.method_1() ^ ((short) ~-~--~~-~((num ^ 0x796bbbeb) - num2)));
            if (num25 == 0)
            {
                short_0 = (short) (class58_0.method_1() ^ ((short) -~-~~--~~((-1466604045 - num) ^ num2)));
            }
            else
            {
                byte_1 = class58_0.method_6(num25);
            }
            callingAssembly = assembly2;
            byte_0 = smethod_3(smethod_2(callingAssembly));
            num3 = int_2;
            int_2 = 0;
            num3 ^= (-380421005 ^ num) + num2;
            long num32 = Class6.smethod_0();
            num3 ^= (int) ((uint) num32);
            num3 ^= (0x750a9c29 + num) - num2;
            int num33 = num3;
            int num28 = ((0x5e3827a7 - num) + num2) ^ num33;
            int num11 = (((0x796b4cd6 ^ num) - num2) * num28) % ((-1438863760 - num) + num2);
            int num18 = (num ^ 0x796b601e) - num2;
            int num29 = num11;
            Class0.Class4 class1 = new Class0.Class4((num + -2106890797) | num2) {
                int_4 = num29
            };
            Interface4<int> interface2 = ((Interface1<int>) class1).imethod_1();
            try
            {
                while (interface2.imethod_2())
                {
                    int num31 = interface2.imethod_4();
                    num11 ^= num31 - num18;
                    num18 -= (3 + num11) >> 8;
                }
            }
            finally
            {
                if (interface2 != null)
                {
                    interface2.imethod_0();
                }
            }
            num3 ^= -~-~~--~~((-1813293368 - num) + num2);
            int num26 = num11;
            num3 = num26 + num3;
            int_1 = num3;
            int_0 = (int_0 & ((num ^ 0x696b6111) - num2)) ^ ((num + 0x576a88f9) ^ num2);
            if ((enum0_0 & ~-~--~~-~-~((num ^ 0x796b6197) - num2)) == ((Enum0) 0))
            {
                int_0 = (num + -2106846833) + num2;
            }
            goto Label_001A;
        }
        goto Label_016E;
    }

    private static AssemblyName smethod_2(Assembly assembly_0)
    {
        try
        {
            return assembly_0.GetName();
        }
        catch
        {
            return new AssemblyName(assembly_0.FullName);
        }
    }

    private static byte[] smethod_3(AssemblyName assemblyName_0)
    {
        byte[] publicKeyToken = assemblyName_0.GetPublicKeyToken();
        if ((publicKeyToken != null) && (publicKeyToken.Length == 0))
        {
            publicKeyToken = null;
        }
        return publicKeyToken;
    }

    private static bool smethod_4(StackTrace stackTrace_0, int int_3)
    {
        StackFrame frame = stackTrace_0.GetFrame(int_3 + 1);
        Assembly assembly = (frame?.GetMethod()?.DeclaringType == null) ? null : ((frame?.GetMethod() == null) ? null : ((Assembly) frame?.GetMethod().DeclaringType)).Assembly;
        if (assembly != null)
        {
            byte[] buffer = smethod_3(smethod_2(assembly));
            if (((buffer != null) && (buffer.Length == 8)) && ((buffer[0] == 0xb7) && (buffer[7] == 0x89)))
            {
                return true;
            }
        }
        return false;
    }

    private static void smethod_5(byte[] byte_2, int int_3, byte[] byte_3)
    {
        int num = 0;
        int num4 = 0;
        int num2 = 0x80;
        int length = byte_3.Length;
        while (num < length)
        {
            num2 = num2 << 1;
            if (num2 == 0x100)
            {
                num2 = 1;
                num4 = byte_2[int_3++];
            }
            if ((num4 & num2) == 0)
            {
                goto Label_007C;
            }
            int num6 = (byte_2[int_3] >> 2) + 3;
            int num7 = ((byte_2[int_3] << 8) | byte_2[int_3 + 1]) & 0x3ff;
            int_3 += 2;
            int num3 = num - num7;
            if (num3 >= 0)
            {
                goto Label_0070;
            }
            return;
        Label_005D:
            if (num >= length)
            {
                continue;
            }
            byte_3[num++] = byte_3[num3++];
        Label_0070:
            if (--num6 < 0)
            {
                continue;
            }
            goto Label_005D;
        Label_007C:
            byte_3[num++] = byte_2[int_3++];
        }
    }

    private sealed class Class58
    {
        private byte[] byte_0;
        private Stream stream_0;

        public Class58(Stream stream_1)
        {
            this.stream_0 = stream_1;
            this.byte_0 = new byte[4];
        }

        public Stream method_0() => 
            this.stream_0;

        public short method_1()
        {
            this.method_4(2);
            return (short) (this.byte_0[0] | (this.byte_0[1] << 8));
        }

        public int method_2()
        {
            this.method_4(4);
            return (((this.byte_0[0] | (this.byte_0[1] << 8)) | (this.byte_0[2] << 0x10)) | (this.byte_0[3] << 0x18));
        }

        private void method_3()
        {
            throw new EndOfStreamException();
        }

        private void method_4(int int_0)
        {
            int offset = 0;
            int num2 = 0;
            if (int_0 == 1)
            {
                num2 = this.stream_0.ReadByte();
                if (num2 == -1)
                {
                    this.method_3();
                }
                this.byte_0[0] = (byte) num2;
            }
            else
            {
                do
                {
                    num2 = this.stream_0.Read(this.byte_0, offset, int_0 - offset);
                    if (num2 == 0)
                    {
                        this.method_3();
                    }
                    offset += num2;
                }
                while (offset < int_0);
            }
        }

        public void method_5()
        {
            Stream stream = this.stream_0;
            this.stream_0 = null;
            if (stream != null)
            {
                stream.Close();
            }
            this.byte_0 = null;
        }

        public byte[] method_6(int int_0)
        {
            int num2;
            if (int_0 < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            byte[] buffer = new byte[int_0];
            int offset = 0;
        Label_0024:
            num2 = this.stream_0.Read(buffer, offset, int_0);
            if (num2 != 0)
            {
                offset += num2;
                int_0 -= num2;
                if (int_0 > 0)
                {
                    goto Label_0024;
                }
            }
            if (offset != buffer.Length)
            {
                byte[] dst = new byte[offset];
                Buffer.BlockCopy(buffer, 0, dst, 0, offset);
                buffer = dst;
            }
            return buffer;
        }
    }

    internal sealed class Class59
    {
        private int int_0;
        private Struct0[] struct0_0;

        public Class59()
        {
            this.struct0_0 = new Struct0[0x10];
        }

        public Class59(int int_1)
        {
            int num = 0x10;
            int_1 = int_1 << 1;
            while (num < int_1)
            {
                if (num <= 0)
                {
                    break;
                }
                num = num << 1;
            }
            if (num < 0)
            {
                num = 0x10;
            }
            this.struct0_0 = new Struct0[num];
        }

        public int method_0() => 
            this.int_0;

        private void method_1()
        {
            Struct0[] structArray2 = this.struct0_0;
            int length = structArray2.Length;
            int num3 = length * 2;
            if (num3 > 0)
            {
                Struct0[] structArray = new Struct0[num3];
                int num4 = 0;
                for (int i = 0; i < length; i++)
                {
                    string str = structArray2[i].string_0;
                    if (str != null)
                    {
                        int num6 = structArray2[i].int_0;
                        int index = num6 & (num3 - 1);
                        while (structArray[index].string_0 != null)
                        {
                            index++;
                            if (index >= num3)
                            {
                                index = 0;
                            }
                        }
                        structArray[index].string_0 = str;
                        structArray[index].int_0 = num6;
                        num4++;
                    }
                }
                this.struct0_0 = structArray;
                this.int_0 = num4;
            }
        }

        public string method_2(int int_1)
        {
            Struct0[] structArray = this.struct0_0;
            int length = structArray.Length;
            int index = int_1 & (length - 1);
            string str = null;
            while (structArray[index].int_0 != int_1)
            {
                if (structArray[index].string_0 == null)
                {
                    return str;
                }
                index++;
                if (index >= length)
                {
                    index = 0;
                }
            }
            return structArray[index].string_0;
        }

        public void method_3(int int_1, string string_0)
        {
            int num4;
            Struct0[] structArray = this.struct0_0;
            int length = structArray.Length;
            int num3 = length >> 1;
            int index = int_1 & (length - 1);
        Label_0022:
            num4 = structArray[index].int_0;
            bool flag = structArray[index].string_0 == null;
            if (!((num4 == int_1) | flag))
            {
                index++;
                if (index >= length)
                {
                    index = 0;
                }
                goto Label_0022;
            }
            structArray[index].string_0 = string_0;
            if (flag)
            {
                structArray[index].int_0 = int_1;
                this.int_0++;
                if (this.int_0 > num3)
                {
                    this.method_1();
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Struct0
        {
            public int int_0;
            public string string_0;
        }
    }

    private enum Enum0
    {
    }
}

