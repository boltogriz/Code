using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.Design;
using System.Collections;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace InputOutput
{
    class Comands
    {
        public Dictionary<string, string[]> comands = new Dictionary<string, string[]>();
        public Comands()
        {
            AddComands("deletefile", "удалить файл");
            AddComands("stream", "создать Test.dat");
        }
        public void AddComands(string key, string value)
        {
            comands.Add(key, new string[] { key, value });
        }
        private string GetComand(string comand)
        {
            string str = "";
            if (comands.ContainsKey(comand))
            {
                str = comands[comand][0];
            }
            else
            {
                comands.Add(comand, new string[] { comand, "нет описания для " + comand });
                str = comands[comand][0];
            }
            return str;
        }
        public string Steam => GetComand("stream");
        public string Deletefile => GetComand("deletefile");
        public void Help()
        {
            foreach (var comand in comands)
            {
                Console.WriteLine("{0} - {1}", comand.Value[0], comand.Value[1]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Comands comands = new Comands();
            Console.WriteLine(comands.Steam.GetType());
            comands.Help();

            while (true)
            {
                string atrib = Console.ReadLine();
                if (comands.Steam == atrib)
                {
                    var stream = new FileStream("Test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    for (int i = 0; i < 256; i++)
                    {
                        stream.WriteByte((byte)i);
                    }
                    Console.WriteLine(stream.Position + "asdf");
                    stream.Position = 0;
                    stream.Close();
                }


                switch (atrib)
                {
                    case "driver":
                        {
                            DriveInfo[] drives2 = DriveInfo.GetDrives();
                            foreach(DriveInfo drive in drives2) 
                            {
                                Console.WriteLine("Driver: {0} Type: {1}", drive.Name, drive.DriveType);
                            }
                            break;
                        }
                    case "copy":
                        {
                            var file = new FileInfo(@"C:\Windows\notepad.exe");
                            try
                            {
                                file.CopyTo(@"C:\Users\admin\source\repos\Code\C#\Professional\InputOutput\bin\Debug\notepad.exe");
                                Console.WriteLine("copy successed");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case "writetext":
                        {
                            var file = new FileInfo("Text.txt");
                            StreamWriter writer = file.CreateText();
                            writer.WriteLine("First");
                            writer.WriteLine("Second");
                            writer.WriteLine(writer.NewLine);
                            writer.WriteLine("Third");
                            for (int i = 0; i < 10; i++)
                            {
                                writer.Write(i + " ");
                            }
                            writer.WriteLine(writer.NewLine);
                            writer.Close();

                            var file2 = new FileStream("text2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                            var writer2 = new StreamWriter(file2, Encoding.GetEncoding(1251));
                            writer2.WriteLine("Первая строка");
                            writer2.WriteLine("Вторая строка");
                            writer2.Close();
                            StreamReader reader = File.OpenText("Text.txt");
                            string input;
                            while((input = reader.ReadLine()) != null) 
                            {
                                Console.WriteLine(input);
                            }
                            reader.Close();
                            break;
                        }
                    case "memory":
                        {
                            var memory = new MemoryStream();
                            memory.Capacity = 256;
                            for (var i = 0; i < 256; i++)
                            {
                                memory.WriteByte((byte)i);
                            }
                            memory.Position = 0;
                            for (var i = 0; i < 256; i++)
                            {
                                Console.Write(" " + memory.ReadByte());
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(new string('-', 20));
                            Console.WriteLine();
                            byte[] array = memory.ToArray();
                            foreach (var item in array)
                            {
                                Console.Write(" " + item);
                            }
                            Console.WriteLine();
                            Console.WriteLine(new string('-', 20));
                            Console.WriteLine();
                            var file = new FileStream("Dump.dat", FileMode.Create, FileAccess.ReadWrite);
                            memory.WriteTo(file);
                            file.Position = 0;
                            for (var i = 0; i < 256; i++)
                            {
                                Console.Write(" "+file.ReadByte());
                            }
                            memory.Close();
                            file.Close();
                            break;
                        }
                    case "stream":
                        {
                            var stream = new FileStream("Test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                            for (int i = 0; i < 256; i++)
                            {
                                stream.WriteByte((byte)i);
                            }
                            Console.WriteLine(stream.Position);
                            stream.Position = 0;
                            for (int i = 0; i < 256; i++)
                            {
                                Console.Write(stream.Position + " - ");
                                Console.WriteLine(" " + stream.ReadByte());
                            }
                            stream.Close();
                            break;
                        }
                    case "deletefile":
                        Console.WriteLine("введите имя файла для удаления");
                        string nameFileD = Console.ReadLine();
                        var fileInfoD = new FileInfo(nameFileD);
                        fileInfoD.Delete();
                        break;

                    case "infofile":
                        {
                            Console.WriteLine("введите имя файла");
                            string fileNameT = Console.ReadLine();
                            var fileInf = new FileInfo(fileNameT);
                            FileStream stream = fileInf.Create();
                            Console.WriteLine(fileInf.FullName);
                            Console.WriteLine(fileInf.Attributes.ToString());
                            stream.Close();
                            break;
                        }
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

