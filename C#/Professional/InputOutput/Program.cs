using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.Design;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string atrib = Console.ReadLine();
                switch (atrib)
                {
                    case "deletefile":
                        Console.WriteLine("введите имя файла для удаления");
                        string nameFileD = Console.ReadLine();
                        var fileInfoD = new FileInfo(nameFileD);
                        fileInfoD.Delete();
                        break;

                    case "infofile":
                        Console.WriteLine("введите имя файла");
                        string fileNameT = Console.ReadLine();
                        var fileInf = new FileInfo(fileNameT);
                        FileStream stream = fileInf.Create();
                        Console.WriteLine(fileInf.FullName);
                        Console.WriteLine(fileInf.Attributes.ToString());
                        stream.Close();
                        break;

                    case "":
                        Console.WriteLine("неверное имя папки");
                        break;

                    case "creat":
                        Console.WriteLine("создать папку");
                        string atribCreat = Console.ReadLine();
                        var directoryCreat = new DirectoryInfo(atribCreat);
                        if (directoryCreat.Exists)
                        {
                            string sub = "SUBDIR";
                            directoryCreat.CreateSubdirectory(sub);
                            Console.WriteLine("создан {0}", directoryCreat.FullName);
                        }
                        else
                        {
                            Directory.CreateDirectory(atribCreat);
                            var directoryCreatInf = new DirectoryInfo(atribCreat);
                            Console.WriteLine("Создан {0}", atribCreat);
                        }
                        break;

                    case "info":
                        string[] drives = Directory.GetLogicalDrives();
                        Console.WriteLine("Имеющиеся диски:");
                        foreach (string drive in drives)
                            Console.WriteLine("- {0}", drive);
                        break;

                    case "close":
                        goto Close;

                    case "delete":
                        Console.WriteLine("введите имя папки для удаления");
                        string del = Console.ReadLine();
                        try
                        {
                            Directory.Delete(del);
                        }
                        catch (Exception ex) 
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    default:
                        var directory = new DirectoryInfo(atrib);
                        if (directory.Exists)
                        {
                            Console.WriteLine("FullName     : {0}", directory.FullName);
                            Console.WriteLine("Name         : {0}", directory.Name);
                            Console.WriteLine("Parent       : {0}", directory.Parent);
                            Console.WriteLine("CreationTime : {0}", directory.CreationTime);
                            Console.WriteLine("Attributes   : {0}", directory.Attributes);

                            FileInfo[] files = directory.GetFiles("*.txt");
                            Console.WriteLine("Найдено {0} *.txt файлов\n", files.Length);
                            foreach (FileInfo file in files)
                            {
                                Console.WriteLine();
                                Console.WriteLine(file.FullName);
                                Console.WriteLine(file.Attributes);
                                Console.WriteLine(file.CreationTime);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Директория с имене: {0} не существует", directory.FullName);
                        }
                        break;
                }
            Close:
                if (atrib == "close")
                    break;
            }
        }
    }
    //Console.ReadKey();
}

