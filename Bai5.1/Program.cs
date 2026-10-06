using Bai51;
using System;
using System.Windows.Forms;

namespace Bai51
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form51());
        }
    }
}