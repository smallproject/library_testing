using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Local
{
    class GetFilesClass
    {
        private string FolderPath()
        {
            return
                @"C:\git_root\library_testing\source\ConsoleApplication1\ConsoleApplication1\Local\FileSystemWatcher_testfolder";
        }

        public void Main()
        {
            string path = FolderPath();

            Console.WriteLine("File Path status: {0}", File.Exists(path));
            Console.WriteLine("Directory path status: {0}", Directory.Exists(path));

            if (File.Exists(path))
            {
                ProcessFile(path);
            }
            else if (Directory.Exists(path))
            {
                ProcessDirectory(path);
            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", path);
            }

        }

        public void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", path);
        }

        public void ProcessDirectory(string targetDirectory)
        {
            string[] fileEntries = Directory.GetFiles(targetDirectory);

            foreach (var fileName in fileEntries)
            {
                ProcessFile(fileName);
            }

            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (var subdirectory in subdirectoryEntries)
            {
                ProcessDirectory(subdirectory);
            }
        }
    }
}
