using System;
using System.Web;

namespace SimpleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var installDir = HttpRuntime.ClrInstallDirectory;
            Console.WriteLine($"CLR Install Directory: {installDir}");
        }
    }
}
