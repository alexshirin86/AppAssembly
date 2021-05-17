using System;
using System.Reflection;
using NixDll_1;

namespace AppAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
                                   
            Assembly assem = Assembly.LoadFrom("./NixDll_1.dll");

            Console.WriteLine($"Assembly Full Name: {assem.FullName}");
            Console.WriteLine($"Assembly Version: {assem.ImageRuntimeVersion}");

            foreach ( Type myType in assem.GetTypes() )
            {
                foreach (MemberInfo mi in myType.GetMembers())
                {
                    Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
                }
            }
            
            Console.ReadKey();
        }
    }
}
