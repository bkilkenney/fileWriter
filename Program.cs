using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of StreamWriter to write to a file
            //StreamWriter writer = new StreamWriter("..\\..\\answers.txt");  //we will see if this creates a text file

            //the using statement will auto - close the file for us
            //  using (writer)
            //    {
            //        write a line
            //    writer.WriteLine("This is a sentence I'm attemping to create in a .txt file.");
            //    }




            //New lesson in creating an instance of Streamwriter            
            // Create an instance of StreamWriter to write to a file

            StreamWriter writer = new StreamWriter("..\\..\\numbers.txt");


            //the using statement will auto-close the file for us

            using (writer)
            {
                //loop from 1 through 20 and write the number to a line
                for (int i = 1; i <= 20; i++)
                {

                    writer.WriteLine(i);
                }
            }

        }
    }
}
