using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;

namespace EssentialTraningApp
{
    class Program
    {
        //Debuging

        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static List<string> Words;
        static void Main(string[] args)
        {
            logger.Trace("The program startert");
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");

            CrazyMathProblem();
            ReadTextFile();
            Console.ReadLine();
        }

        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:\temp\test.txt")) //dont have that locatin or file name (debuging purpose )
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {

                Console.WriteLine("Couldn't find the directory.");
                logger.Error("The directory was not found." + ex.Message);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Couldn't find the file."); //if we have the directory but not the file
                logger.Error(ex.Message);
            }
            catch(Exception ex) //general exception
            {
                Console.WriteLine("An unknow error occured" + ex.Message);
            }
            finally //runs no metter what
            {
                Console.WriteLine("The finaly runs all the time");
            }
        }
        private static int CrazyMathProblem()
        {
            var income = 1000;
            for (int i = 10; i > 0; i--)
            {
                income = income = (income / i);
            }
            return income;
        }
    }
}
