using System;


using System.Reflection;


[assembly: AssemblyVersionAttribute("1.0.2000.0")]      // Версия сборки.
[assembly: AssemblyTitle("AssemblySmpl")]               // Имя сборки.
[assembly: AssemblyDescription("")]                     // Описание сборки.
[assembly: AssemblyConfiguration("")]                   // Конфигурация, например, Release или Debug.
[assembly: AssemblyCompany("CyberBionic Systematics")]  // Имя компании разработчика.
[assembly: AssemblyProduct("AssemblySmpl")]             // Имя продукта.
[assembly: AssemblyCopyright("Copyright 2009")]         // Копирайты.
[assembly: AssemblyTrademark("")]                       // Торговая марка.
[assembly: AssemblyCulture("")]                         // Какие культуры поддерживает сборка. 


namespace Attributes_003
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);
            AssemblyName assemblyName = assembly.GetName();
            Console.WriteLine(assemblyName.Name);
            Console.WriteLine(assembly.EntryPoint);
            Console.ReadKey();

        }
    }
}
