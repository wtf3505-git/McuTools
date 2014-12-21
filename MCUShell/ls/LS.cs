﻿using McuShell.Kernel;
using System;
using System.IO;

namespace ls
{
    class LS
    {
        static void PrintArray(string[] array, bool files = true)
        {
            if (files)
            {
                foreach (var item in array)
                {
                    FileInfo fi = new FileInfo(item);
                    var currentcolor = Console.ForegroundColor;
                    var type = Kernel.GetFileType(item);
                    switch (type)
                    {
                        case FileType.Archive:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case FileType.Audio:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case FileType.Document:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            break;
                        case FileType.Executable:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case FileType.Image:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        case FileType.Video:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        default:
                            Console.ForegroundColor = currentcolor;
                            break;
                    }

                    Console.WriteLine("{0,-30}\t{1,-10}\t{2,-20}", fi.Name, Kernel.GetFileSize(fi.Length), fi.LastWriteTime);

                    Console.ForegroundColor = currentcolor;
                }
            }
            else
            {
                var currentcolor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                foreach (var item in array)
                {
                    DirectoryInfo di = new DirectoryInfo(item);
                    Console.WriteLine("{0,-30}\t{1,-10}\t{2,-20}", di.Name, "<dir>", di.LastWriteTime);
                }
                Console.ForegroundColor = currentcolor;
            }
        }

        static void Main(string[] args)
        {
            CommandParser.CommandDescription = "List Directory files & subdirectories";
            CommandParser.Parse(null, args);

            string[] files = Directory.GetFiles(Environment.CurrentDirectory, "*.*");
            string[] dirs = Directory.GetDirectories(Environment.CurrentDirectory, "*.*");

            PrintArray(dirs);
            PrintArray(files);
#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
