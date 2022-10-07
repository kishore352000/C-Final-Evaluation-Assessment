using System;
using System.IO;

namespace Files_Q6
{
    class Copy_File

    {



        static void Main()

        {

            // Copy contents from file1 to file2

            File.Copy("rrr.txt", "sample.txt");





            // Display file2 contents

            Console.WriteLine(File.ReadAllText("sample.txt"));

            var file = File.ReadAllText(@"C:\Users\kishore.lakkireddy\source\repos\Final_Assessment\Files_Q6\Files_Q6\bin\Debug\netcoreapp3.1\sample.txt");

            FileInfo filetodecrypt = new FileInfo(file);

            filetodecrypt.Encrypt(); //Encrypt



            filetodecrypt.Decrypt(); //Decrypt



        }

    }
}
