﻿using System;
using System.IO;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream = File.Create(@"E:\frontend study\github\c# practice\001-configuration-dev\HelloCSharp\test.txt");
            var writer = new StreamWriter(stream);
            writer.WriteLine("Hello C# World!");
            writer.Flush();
            writer.Close();
            Console.WriteLine("Done!");
        }
    }
}
