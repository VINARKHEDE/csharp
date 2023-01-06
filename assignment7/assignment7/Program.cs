using System;
using System.Collections.Generic;
using System.IO;

namespace assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            //create path
            String path = @"C:\Users\VINARKHE\assi7\q1";
            DirectoryInfo f1 = new DirectoryInfo(path);
            f1.Create();
            {
                Console.WriteLine("Directory is Created");
            }
            Console.WriteLine("Directory path " +f1.FullName);
            // to get dir name
            Console.WriteLine("Directory Name " +f1.Name);
            // to get parant path dir
            Console.WriteLine("Directory path " +f1.Parent);

            string[] directory = Directory.GetDirectories(path, "*",SearchOption.AllDirectories);

            //return name of subdirectory
            string[] file = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            //return name of sub file
            Console.WriteLine("Directory deatiles (sub dir)---");
            foreach(string diNext in directory)
            {
                var dirInfo = new DirectoryInfo(diNext);
                Console.WriteLine(dirInfo.FullName);
                  
            }
            Console.WriteLine(" file Deatiles");
            foreach(string fiNext in file)
            {
                var fileInfo = new FileInfo(fiNext);
                Console.WriteLine(fileInfo.FullName);
            }
                
        }
    }
}
    
    

