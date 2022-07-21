using System;
using Primeiro.Entities;
using System.IO;

namespace Primeiro.Capitulo13.ExemploFileStream.Controller
{
    class ExemploFileStreamController : LoadController
    {
        public override void Rodar()
        {
            bool rodar = false;

            // Desta forma é necessário sempre fechar o objeto nao gerenciado pelo CLR do .NET
            rodar = Helpers.FunctionsHelper.getFromConsole("Deseja rodar o exemplo de FileStream com metodo close (s/n): ").ToString().ToLower() == "s";
            if (rodar)
            {
                string path = @"c:\temp\file1.txt"; // anotacao com @ para simplificar a escrita do path pois se nao seria necessario colocar duas barras ex: c:\\tempo\\file.txt
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open); // File.OpenRead(path);
                    sr = new StreamReader(fs);
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }

                /* EXEMPLO ACIMA MAS DE UMA FORMA MAIS RESUMIDA ELIMITANDO O USO DO FileStream
                    string path = @"c:\temp\file1.txt";
                    StreamReader sr = null;
                    try {
                        sr = File.OpenText(path);
                        while (!sr.EndOfStream) {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                    catch (IOException e) {
                        Console.WriteLine("An error occurred");
                        Console.WriteLine(e.Message);
                    }
                    finally {
                        if (sr != null) sr.Close();
                    }
                */
            }

            // usando using, faz com que após a execução do bloco, os objetos sejam fechados automaticamente pelo CLR simplificando o código
            rodar = Helpers.FunctionsHelper.getFromConsole("Deseja rodar o exemplo de FileStream usando a abordagem using (s/n): ").ToString().ToLower() == "s";
            if (rodar)
            {
                string path = @"c:\temp\file1.txt";
                try
                {
                    using (FileStream fs = new FileStream(path, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                }
                /* EXEMPLO ACIMA MAS DE UMA FORMA MAIS RESUMIDA ELIMITANDO O USO DO FileStream
                   string path = @"c:\temp\file1.txt";
                   try {
                       using (StreamReader sr = File.OpenText(path)) {
                           while (!sr.EndOfStream) {
                               string line = sr.ReadLine();
                               Console.WriteLine(line);
                           } 
                       }
                   }
                   catch (IOException e) {
                       Console.WriteLine("An error occurred");
                       Console.WriteLine(e.Message);
                   }*/
            }

            rodar = Helpers.FunctionsHelper.getFromConsole("Deseja rodar o exemplo de Stream writter (s/n): ").ToString().ToLower() == "s";
            if (rodar)
            {
                string sourcePath = @"c:\temp\file1.txt";
                string targetPath = @"c:\temp\file2.txt";
                try
                {
                    string[] lines = File.ReadAllLines(sourcePath);
                    using (StreamWriter sw = File.AppendText(targetPath))
                    {
                        foreach (string line in lines)
                        {
                            sw.WriteLine(line.ToUpper());
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                }
            }

            rodar = Helpers.FunctionsHelper.getFromConsole("Deseja rodar o exemplo de listagem de pastas (s/n): ").ToString().ToLower() == "s";
            if (rodar)
            {
                string path = @"c:\temp\myfolder";
                try
                {
                    var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                    Console.WriteLine("FOLDERS:");
                    foreach (string s in folders)
                    {
                        Console.WriteLine(s);
                    }
                    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                    Console.WriteLine("FILES:");
                    foreach (string s in files)
                    {
                        Console.WriteLine(s);
                    }
                    Directory.CreateDirectory(@"c:\temp\myfolder\newfolder");
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                }
            }

            rodar = Helpers.FunctionsHelper.getFromConsole("Deseja rodar o exemplo de path (s/n): ").ToString().ToLower() == "s";
            if (rodar)
            {
                string path = @"c:\temp\myfolder\file1.txt";
                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
                Console.WriteLine("GetFileName: " + Path.GetFileName(path));
                Console.WriteLine("GetExtension: " + Path.GetExtension(path));
                Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
                Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            }
        }
    }
}
