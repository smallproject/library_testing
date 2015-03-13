using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Local;

namespace ConsoleApplication1
{
    public static class extension
    {
        public static bool? exist(this int food)
        {
            //1 means food is written in contract
            //2 means food is not written in contract
            //any other number means food is promised or mentioned

            switch (food)
            {
                case 1:
                    return true;
                case 2:
                    return false;
                default:
                    return null;
            }
        }
    }

    class Program
    {

        static SQL_experiments sqlcode = new SQL_experiments();
        static void Main(string[] args)
        {

            try
            {
                string url = "http://www.google.com";
                bool status;
                //classProcess classProcess = new classProcess();
                //classProcess.OpenWithStartInfo(url);

                ProcessMonitor monitor = new ProcessMonitor(url, out status);

                Console.WriteLine(status);

                //var locate = System.Diagnostics.Process.Start("calc");
                //locate.Close();
                //string fullpath = locate.Modules[0].FileName;
                //Console.WriteLine(fullpath);

                //string App = "calc";
                //PrintProcessClass printclass = new PrintProcessClass();
                //printclass.StartHere(App);

                //Process process = new Process();
                //process = Process.Start("iexplore");
                //string fullpath = process.Modules[0].FileName;
                //string version = process.MainModule.FileVersionInfo.FileVersion;
                //process.Kill();

                //Console.WriteLine(fullpath);
                //Console.WriteLine(version);


                //var id = process.Id;
                //var MachineName = process.MachineName;
                //var filename = process.MainModule.FileName;

                //Console.WriteLine(id);
                //Console.WriteLine(MachineName);
                //Console.WriteLine(filename);
                //Process myProcess = new Process();
                //myProcess.StartInfo.FileName = fullpath;
                //myProcess.StartInfo.Verb = "Print";
                //myProcess.StartInfo.CreateNoWindow = true;
                //myProcess.EnableRaisingEvents = true;
                //myProcess.Start();

                //Process process = new Process();
                //process = Process.Start("calc");
                //string fullpath = process.Modules[0].FileName;

                //string processid = process.Id.ToString();
                //process.Kill();
                //Console.WriteLine(fullpath);
                //Console.WriteLine(processid);

            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.Message);
            }

            Console.ReadLine();
        }

        static void test2()
        {
            sqlcode.Id = 1;
            sqlcode.AccountId = "USER001";
            sqlcode.username = "jasperuser";
            sqlcode.password = "jasperpass";
            sqlcode.commandtxt();
        }

        static void test1()
        {
            int food;
            bool? code = null;
            int.TryParse(Console.ReadLine(), out food);
            if (food.exist().Equals(true))
            {
                code = true;
            }

            if (code == null)
            {

            }
        }


        static void test()
        {
            bool? condition;
            int conditionnr = 0;
            int.TryParse(Console.ReadLine(), out conditionnr);

            switch (conditionnr)
            {
                case 1:
                    condition = true;
                    Console.WriteLine("{0}", condition);
                    break;

                case 2:
                    condition = false;
                    Console.WriteLine("{0}", condition);
                    break;

                default:
                    Console.WriteLine("NULL");
                    break;
            }
        }

        static void playingwithmdimension()
        {
            string[,] multidimension = new string[,] { };
            string msg = multidimensionfunction(out multidimension);

            Console.WriteLine(msg);
            foreach (var dimension in multidimension)
            {
                Console.WriteLine(dimension);
            }
        }

        static void playingwithsdimension()
        {
            string[] singledimension = singledimensionfunction();

            foreach (var dimension in singledimension)
            {
                Console.WriteLine(dimension);
            }
        }

        static string[] singledimensionfunction()
        {
            DateTime months = new DateTime();
            string[] singledimension = new string[11];
            try
            {
                singledimension[0] = "januari";
                singledimension[1] = "februari";
                singledimension[2] = "maart";
                singledimension[3] = "april";
                singledimension[4] = "mei";
                singledimension[5] = "juni";
                singledimension[6] = "juli";
                singledimension[7] = "agostos";
                singledimension[8] = "september";
                singledimension[9] = "oktober";
                singledimension[10] = "november";

                foreach (var dimensions in singledimension)
                {
                    //Console.WriteLine(dimensions);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return singledimension;
        }

        static string[][] multidimensionfunction()
        {

            DateTime months = new DateTime();
            string[][] multidimension = new string[11][];
            try
            {
                multidimension[0][0] = "januari";
                multidimension[0][1] = "1";
                multidimension[1][0] = "februari";
                multidimension[1][1] = "1";
                multidimension[2][0] = "maart";
                multidimension[2][1] = "1";
                multidimension[3][0] = "april";
                multidimension[3][1] = "1";
                multidimension[4][0] = "mei";
                multidimension[4][1] = "1";
                multidimension[5][0] = "juni";
                multidimension[5][1] = "1";
                multidimension[6][0] = "juli";
                multidimension[6][1] = "1";
                multidimension[7][0] = "agostos";
                multidimension[7][1] = "1";
                multidimension[8][0] = "september";
                multidimension[8][1] = "1";
                multidimension[9][0] = "oktober";
                multidimension[9][1] = "1";
                multidimension[10][0] = "november";
                multidimension[10][1] = "1";

                foreach (var dimensions in multidimension[1][1])
                {
                    //Console.WriteLine(dimensions);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return multidimension;
        }

        static void multidimensionfunction(out string [][] insertdimension)
        {

            DateTime months = new DateTime();
            string[][] multidimension = new string[11][];
            try
            {
                multidimension[0][0] = "januari";
                multidimension[0][1] = "1";
                multidimension[1][0] = "februari";
                multidimension[1][1] = "1";
                multidimension[2][0] = "maart";
                multidimension[2][1] = "1";
                multidimension[3][0] = "april";
                multidimension[3][1] = "1";
                multidimension[4][0] = "mei";
                multidimension[4][1] = "1";
                multidimension[5][0] = "juni";
                multidimension[5][1] = "1";
                multidimension[6][0] = "juli";
                multidimension[6][1] = "1";
                multidimension[7][0] = "agostos";
                multidimension[7][1] = "1";
                multidimension[8][0] = "september";
                multidimension[8][1] = "1";
                multidimension[9][0] = "oktober";
                multidimension[9][1] = "1";
                multidimension[10][0] = "november";
                multidimension[10][1] = "1";

                foreach (var dimensions in multidimension[1][1])
                {
                    //Console.WriteLine(dimensions);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            insertdimension = new string[][]{};
        }

        static string multidimensionfunction(out string[,] dimensioninsert)
        {
            dimensioninsert = new string[,]{{"januari","1"},{"februari","1"},{"maart","1"}};

            return "multidimension string[,]";
        }

        static string multidimensionfunction(string test)
        {
            return "string test";
        }

        static int multidimensionfunction(int test)
        {
            return 99;
        }

        static bool multidimensionfunction(bool? condition)
        {
            return false;
        }


    }
}
