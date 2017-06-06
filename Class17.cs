using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal static class Class17
{
    [STAThread]
    private static void Main()
    {
        if (Environment.OSVersion.Version.Major >= 6)
        {
            SetProcessDPIAware();
        }
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Startup());
    }

    [DllImport("user32.dll")]
    private static extern bool SetProcessDPIAware();
}

