using System;
using System.Windows.Forms;

namespace Bai53
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form53());
        }
    }
}