using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1.Local
{
    internal class ProcessMonitor
    {
        private Process myProcess = new Process();
        private int elapsedTime;
        private bool eventHandled;

        public ProcessMonitor(string url, out bool status)
        {
            elapsedTime = 0;
            eventHandled = false;

            try
            {
                myProcess.StartInfo.FileName = "iexplore";
                myProcess.StartInfo.Arguments = "-noframemerging " + url;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.EnableRaisingEvents = true;
                myProcess.Exited += new EventHandler(myPorcess_Exited);
                myProcess.Start();
            }
            catch (Win32Exception msg)
            {
                Console.WriteLine("An error occurred trying to print \"{0}\":" + "\n" + msg.Message);
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

            status = eventHandled;
        }

        private void myPorcess_Exited(object sender, System.EventArgs e)
        {
            eventHandled = true;
            Console.WriteLine("Exit time:    {0}\r\n" +
                              "Exit code:    {1}\r\nElapsed time: {2}", myProcess.ExitTime, myProcess.ExitCode,
                elapsedTime);
        }
    }
}
