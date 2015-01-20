using System;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.IO.StreamReader myReader = new System.IO.StreamReader("Values.txt");
                string line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                        Console.WriteLine(line);
                }

                myReader.Close();
                Console.ReadLine();
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine("The Directory does not exist.");
                Console.ReadLine();
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine("The File does not exist.");
                Console.ReadLine();
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            finally
            {
                // PErform any remaining actions to close, clean-up, etc.
            }

        }
    }
}
