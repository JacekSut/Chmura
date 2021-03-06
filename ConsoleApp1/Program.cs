using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var netCoreVer = System.Environment.Version; 
            var runtimeVer = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription; 
            Console.WriteLine($"Net core version: {netCoreVer}");
            Console.WriteLine($"Runtime version: {runtimeVer}");
            Console.WriteLine($"Autorzy projektu: {DEV1.Autor}, {DEV2.Autor}");
        }
    }
}
