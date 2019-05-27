using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3_CopyImagesToDynamicDir
{
    class Program
    {
        static void Main(string[] args)
        {
           ImageCopyTool.RunCopy(@"C:\ImageFolder\", AppDomain.CurrentDomain.BaseDirectory + @"data\");
        }

    }
}
