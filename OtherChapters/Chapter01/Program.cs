using System;
using System.IO;
using System.Windows.Forms;
using MiscUtil;

namespace Chapter01
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo(Application.ExecutablePath);

            ApplicationChooser.Run(typeof(Program), args);
        }
    }
}
