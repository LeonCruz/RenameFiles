using System;
using System.IO;


namespace rename_files
{
    class Program
    {

	private static string[]  getFiles(string path)
	{
            string[] files = Directory.GetFiles(path);
            Array.Sort(files);    

	    return files;
	}

	private static void renameFiles(string directory, string[] files, string pattern)
	{
	  for (int i=0; i<files.Length; i++)
	  {
	    string newName = "";
	    if (i < 9)
	    { 
	      newName = pattern.Replace("\\d", "0" + (i+1));
	    }
	    else
	    {
	      newName = pattern.Replace("\\d", "" + (i+1));
	    }

	    FileInfo information = new FileInfo(files[i]);
            newName = newName + information.Extension;

	    string fullPath = Path.Combine(directory, newName);

	    Console.WriteLine(fullPath);
	    File.Move(files[i], fullPath);
	  }

	  Console.WriteLine("Concluído.");
	}


        static void Main(string[] args)
        {
	    string directory = args[0];
	    string pattern = args[1];
	    string[] files;

	    if (Directory.Exists(directory))
	    {
	      files = getFiles(directory);
	      renameFiles(directory, files, pattern);
            }
	    else 
	    {
	      Console.WriteLine("Não é uma pasta");
	      Console.WriteLine("Insira um caminho válido");
	    }
        }
    }
}
