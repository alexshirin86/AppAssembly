using System;
using System.Reflection;
using NixDll_1;

namespace AppAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType1 = typeof(User1);

            //Type myType2 = Type.GetType(myType1.ToString(), false, true);

            foreach (MemberInfo mi in myType1.GetMembers())
            {
                Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }

            
            Assembly assem = Assembly.LoadFrom("./NixDll_2.dll");

            Console.WriteLine("Assembly Full Name:");
            Console.WriteLine(assem.FullName);

            Console.ReadKey();
        }
    }
}
