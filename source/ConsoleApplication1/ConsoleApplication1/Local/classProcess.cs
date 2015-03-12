using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1.Local
{
    class classProcess
    {
        public void OpenApplication(string url)
        {
            Process.Start("IExplore.exe", url);
        }

        public void OpenWithArgument(string url)
        {
            Process.Start("IExplorer.exe", url);
        }

        public void OpenWithStartInfo(string url)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("IExplorer.exe");
                startInfo.WindowStyle = ProcessWindowStyle.Maximized;

                Process.Start(startInfo);

                startInfo.Arguments = url;
                Process.Start(startInfo);
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.Message);
            }

        }
    }

    class PrintProcessClass
    {
        private Process myProcess = new Process();
        private int elapsedTime;
        private bool eventHandled;

        public void PrintDoc(string fileName)
        {
            elapsedTime = 0;
            eventHandled = false;

            try
            {
                myProcess.StartInfo.FileName = fileName;
                myProcess.StartInfo.Verb = "Print";
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.EnableRaisingEvents = true;
                myProcess.Exited += new EventHandler(myPorcess_Exited);
                myProcess.Start();
            }
            catch (Exception msg)
            {
                Console.WriteLine("An error occurred trying to print \"{0}\":" + "\n" + msg.Message, fileName);
                return;
            }

            const int SLEEP_AMOUNT = 100;
            while (!eventHandled)
            {
                elapsedTime += SLEEP_AMOUNT;
                if (elapsedTime > 30000)
                {
                    break;
                }
                Thread.Sleep(SLEEP_AMOUNT);
            }
        }

        private void myPorcess_Exited(object sender, System.EventArgs e)
        {
            eventHandled = true;
            Console.WriteLine("Exit time:    {0}\r\n" +
                              "Exit code:    {1}\r\nElapsed time: {2}", myProcess.ExitTime, myProcess.ExitCode,
                elapsedTime);
        }

        public void StartHere(string args)
        {
            PrintProcessClass myPrintProcess = new PrintProcessClass();
            myPrintProcess.PrintDoc(args);
        }
    }
}
