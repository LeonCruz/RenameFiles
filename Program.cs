using System;
using System.IO;


namespace rename_files
{
    class Program
    {

	private static void getFiles(string path)
	{
            string[] files = Directory.GetFiles(path);
            Array.Sort(files);    

	    foreach (string file in files)
	    {
	      Console.WriteLine(file);
	    }
	}


        static void Main(string[] args)
        {
	    string directory = args[0];

	    if (Directory.Exists(directory))
	    {
	      getFiles(directory);
            }
	    else 
	    {
	      Console.WriteLine("Não é uma pasta");
	      Console.WriteLine("Insira um caminho válido");
	    }
        }
    }
}
