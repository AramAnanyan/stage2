using System;
using System.Runtime.InteropServices;

namespace Wooood
{
    class Program
    {
        [DllImport("CameraCaptureDLL.DLL")]
        private static extern bool CaptureStill(string Path);

        [DllImport("CameraCaptureDLL.DLL")]
        private static extern bool InitializeGraph(IntPtr hWnd);

        static void Main(string[] args)
        {
              }
    }
}
