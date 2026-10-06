using System;
using System.Windows.Forms;

namespace Bai52
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form52());
        }
    }
}