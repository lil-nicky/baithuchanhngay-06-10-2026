using System;
using System.Windows.Forms;

namespace Bai54
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form54());
        }
    }
}