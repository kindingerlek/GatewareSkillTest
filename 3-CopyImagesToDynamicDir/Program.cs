/* 
 * Author: Lucas Ernesto Kindinger
 * Date: 2016-05-26
 * 
 * Exercise: In "C:" create dynamically folder and copy images files from a specific directory to that. Use TDD to run the tests.
 */

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
