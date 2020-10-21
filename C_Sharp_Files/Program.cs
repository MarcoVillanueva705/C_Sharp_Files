using System;
//include the System.IO namespace
using System.IO;

namespace C_Sharp_Files
{
    //Working With Files
    //The File class from the System.IO namespace, 
    //allows us to work with files:


    class Program
    {
        static void Main(string[] args)
        {
            //Write To a File and Read It
            //In the following example, we use the WriteAllText() method to create a file named "filename.txt" 
            //and write some content to it. Then we use the ReadAllText() method to read the contents of the file:

            string writeText = "Howdy, stranger!"; //create a text string
            File.WriteAllText("filename.txt", writeText); //create a file and write the content of writetext to it

            string readText = File.ReadAllText("filename.txt"); //read the contents of the file
            Console.WriteLine(readText); //Output the content


        }
    }
}
