using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

internal static class Class0
{
    private sealed class Class1
    {
        public int int_0;

        internal void method_0(int int_1)
        {
            this.int_0 += int_1;
        }
    }

    internal sealed class Class2 : Interface4<int>, Interface1<int>, Interface0, Interface2, Interface3
    {
        private Class0.Class1 class1_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        public int int_4;
        private int int_5;
        private int int_6;
        private int int_7;
        private Interface4<int> interface4_0;

        [DebuggerHidden]
        public Class2(int int_8)
        {
            this.int_0 = int_8;
            this.int_2 = Thread.CurrentThread.ManagedThreadId;
        }

        [DebuggerHidden]
        private Interface3 imethod_0() => 
            this.imethod_1();

        [DebuggerHidden]
        private Interface4<int> imethod_1()
        {
            Class0.Class2 class2;
            if ((this.int_0 == -2) && (this.int_2 == Thread.CurrentThread.ManagedThreadId))
            {
                this.int_0 = 0;
                class2 = this;
            }
            else
            {
                class2 = new Class0.Class2(0);
            }
            class2.int_3 = this.int_4;
            return class2;
        }

        private bool imethod_2()
        {
            try
            {
                int num = this.int_0;
                if (num != 0)
                {
                    if (num != 1)
                    {
                        return false;
                    }
                    this.int_0 = -3;
                    int num3 = this.class1_0.int_0;
                    this.class1_0.int_0 = num3 - 1;
                    if (this.class1_0.int_0 == 0)
                    {
                        this.method_0();
                        return false;
                    }
                    int num2 = this.int_5;
                    this.int_5 = ((num2 + this.int_6) + this.class1_0.int_0) ^ (0x7484a7c7 + this.int_7);
                    this.int_6 = num2;
                }
                else
                {
                    this.int_0 = -1;
                    this.class1_0 = new Class0.Class1();
                    this.class1_0.int_0 = this.int_3;
                    this.int_6 = 0;
                    this.int_5 = 1;
                    Class0.Delegate0<int> delegate3 = new Class0.Delegate0<int>(this.class1_0.method_0);
                    int num4 = this.int_5;
                    Class0.Class3 class1 = new Class0.Class3(-2) {
                        int_4 = num4,
                        delegate0_1 = delegate3
                    };
                    this.interface4_0 = ((Interface1<int>) class1).imethod_1();
                    this.int_0 = -3;
                }
                if (!this.interface4_0.imethod_2())
                {
                    this.method_0();
                    this.interface4_0 = null;
                    return false;
                }
                this.int_7 = this.interface4_0.imethod_4();
                this.int_1 = this.int_5;
                this.int_0 = 1;
                return true;
            }
            fault
            {
                this.Interface2.imethod_0();
            }
        }

        [DebuggerHidden]
        void Interface2.imethod_0()
        {
            switch (this.int_0)
            {
                case -3:
                case 1:
                    try
                    {
                    }
                    finally
                    {
                        this.method_0();
                    }
                    break;
            }
        }

        [DebuggerHidden]
        void Interface3.imethod_0()
        {
            throw new NotSupportedException();
        }

        [DebuggerHidden]
        object Interface3.imethod_3() => 
            this.int_1;

        [DebuggerHidden]
        int Interface4<int>.imethod_4() => 
            this.int_1;

        private void method_0()
        {
            this.int_0 = -1;
            if (this.interface4_0 != null)
            {
                this.interface4_0.imethod_0();
            }
        }
    }

    internal sealed class Class3 : Interface4<int>, Interface1<int>, Interface0, Interface2, Interface3
    {
        private Class0.Delegate0<int> delegate0_0;
        public Class0.Delegate0<int> delegate0_1;
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        public int int_4;
        private int int_5;

        [DebuggerHidden]
        public Class3(int int_6)
        {
            this.int_0 = int_6;
            this.int_2 = Thread.CurrentThread.ManagedThreadId;
        }

        private bool imethod_2()
        {
            int num = this.int_0;
            if (num != 0)
            {
                if (num != 1)
                {
                    return false;
                }
                this.int_0 = -1;
                this.int_5 += this.int_5;
                if (this.int_5 == 0x40)
                {
                    this.delegate0_0(this.int_5 - 7);
                    this.int_5 = 5;
                }
            }
            else
            {
                this.int_0 = -1;
                this.int_5 = 1;
                this.delegate0_0(this.int_3 - -1810025101);
            }
            this.int_1 = this.int_5;
            this.int_0 = 1;
            return true;
        }

        [DebuggerHidden]
        Interface3 Interface0.imethod_0() => 
            this.Interface1<System.Int32>.imethod_1();

        [DebuggerHidden]
        Interface4<int> Interface1<int>.imethod_1()
        {
            Class0.Class3 class2;
            if ((this.int_0 == -2) && (this.int_2 == Thread.CurrentThread.ManagedThreadId))
            {
                this.int_0 = 0;
                class2 = this;
            }
            else
            {
                class2 = new Class0.Class3(0);
            }
            class2.int_3 = this.int_4;
            class2.delegate0_0 = this.delegate0_1;
            return class2;
        }

        [DebuggerHidden]
        void Interface2.imethod_0()
        {
        }

        [DebuggerHidden]
        void Interface3.imethod_0()
        {
            throw new NotSupportedException();
        }

        [DebuggerHidden]
        object Interface3.imethod_3() => 
            this.int_1;

        [DebuggerHidden]
        int Interface4<int>.imethod_4() => 
            this.int_1;
    }

    internal sealed class Class4 : Interface4<int>, Interface1<int>, Interface0, Interface2, Interface3
    {
        private int int_0;
        private int int_1;
        private int int_2;
        private int int_3;
        public int int_4;
        private int int_5;
        private Interface4<int> interface4_0;

        [DebuggerHidden]
        public Class4(int int_6)
        {
            this.int_0 = int_6;
            this.int_2 = Thread.CurrentThread.ManagedThreadId;
        }

        private bool imethod_2()
        {
            try
            {
                int num = this.int_0;
                if (num != 0)
                {
                    if (num != 1)
                    {
                        return false;
                    }
                    this.int_0 = -3;
                    if (this.int_5 == 0)
                    {
                        this.method_0();
                        return false;
                    }
                }
                else
                {
                    this.int_0 = -1;
                    this.int_5 = 7;
                    int num4 = this.int_3;
                    Class0.Class2 class1 = new Class0.Class2(-2) {
                        int_4 = num4
                    };
                    this.interface4_0 = ((Interface1<int>) class1).imethod_1();
                    this.int_0 = -3;
                }
                if (!this.interface4_0.imethod_2())
                {
                    this.method_0();
                    this.interface4_0 = null;
                    return false;
                }
                int num2 = this.interface4_0.imethod_4() ^ this.int_3;
                if ((num2 & 3) == 0)
                {
                    num2 ^= -2060011533;
                }
                int num3 = this.int_5 - 1;
                this.int_5 = num3;
                if ((num2 & 15) == 0)
                {
                    num2 ^= -1059952607 ^ this.int_5;
                }
                this.int_1 = num2;
                this.int_0 = 1;
                return true;
            }
            fault
            {
                this.Interface2.imethod_0();
            }
        }

        [DebuggerHidden]
        private object imethod_3() => 
            this.int_1;

        [DebuggerHidden]
        private int imethod_4() => 
            this.int_1;

        [DebuggerHidden]
        Interface3 Interface0.imethod_0() => 
            this.Interface1<System.Int32>.imethod_1();

        [DebuggerHidden]
        Interface4<int> Interface1<int>.imethod_1()
        {
            Class0.Class4 class2;
            if ((this.int_0 == -2) && (this.int_2 == Thread.CurrentThread.ManagedThreadId))
            {
                this.int_0 = 0;
                class2 = this;
            }
            else
            {
                class2 = new Class0.Class4(0);
            }
            class2.int_3 = this.int_4;
            return class2;
        }

        [DebuggerHidden]
        void Interface2.imethod_0()
        {
            switch (this.int_0)
            {
                case -3:
                case 1:
                    try
                    {
                    }
                    finally
                    {
                        this.method_0();
                    }
                    break;
            }
        }

        [DebuggerHidden]
        void Interface3.imethod_0()
        {
            throw new NotSupportedException();
        }

        private void method_0()
        {
            this.int_0 = -1;
            if (this.interface4_0 != null)
            {
                this.interface4_0.imethod_0();
            }
        }
    }

    private delegate void Delegate0<T>(T gparam_0);
}

