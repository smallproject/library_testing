using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Local
{
    class _classFileWatcher
    {
        public void main()
        {
            pathfinder();
        }

        private void pathfinder()
        {
            string pathfind = "FileSystemWatcher_testfolder";
            Console.WriteLine(Path.GetFullPath(pathfind));
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public void Run()
        {

            //FileSystemWatcher FW = new FileSystemWatcher();

            //FW.Path = "FileSystemWatcher_testfolder";
            //FW.IncludeSubdirectories = true;

            //Console.WriteLine(FW.);

            string path = "FileSystemWatcher_testfolder";

            FileSystemWatcher watcher = new FileSystemWatcher();

            watcher.Path = Path.GetFullPath(path);
            watcher.NotifyFilter = NotifyFilters.LastAccess
                                   | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
           
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;

            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q');

        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("File : " + e.FullPath + " " + e.ChangeType);
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            Console.WriteLine("File : {0} renamed to {1}" + e.OldFullPath + " " + e.FullPath);
        }
    }
}
