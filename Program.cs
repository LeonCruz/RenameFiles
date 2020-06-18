using System;
using System.IO;


namespace rename_files
{
    class Program
    {
        static void Main(string[] args)
        {
	    String directory = args[0];

	    if (Directory.Exists(directory))
	    {
	      Console.WriteLine("É uma pasta"); 
            }
	    else 
	    {
	      Console.WriteLine("Não é uma pasta");
	      Console.WriteLine("Insira um caminho válido");
	    }
        }
    }
}
