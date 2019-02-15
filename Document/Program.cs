using System;
using System.IO;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            String documentName, yesNo;
            bool correctResponse, loop = true;

            Console.WriteLine("Document\n");

            while (loop == true)
            {
                Console.WriteLine("Enter the name of the document");
                documentName = Console.ReadLine();
                Console.WriteLine("Enter the content of the document");
                String content = Console.ReadLine();

                try //try to do something here that might create an exception
                {
                    bool endBool = documentName.EndsWith(".txt", StringComparison.Ordinal);
                    if (endBool == true)
                    {
                        StreamWriter streamWriter = new StreamWriter(documentName);
                        streamWriter.WriteLine(content);
                        if (streamWriter != null)
                        {
                            streamWriter.Close();
                        }
                    }
                    else
                    {
                        StreamWriter streamWriter = new StreamWriter(documentName + ".txt");
                        streamWriter.WriteLine(content);
                        if (streamWriter != null)
                        {
                            streamWriter.Close();
                        }
                    }
                    Console.WriteLine("{0} was sucessfully saved. The document contains {1} characters.", documentName, content.Length);
                }
                catch (Exception e) //handle an exception if it occurs
                {
                    Console.WriteLine("Program failed exception: " + e.Message);

                }
                /*finally //do something at the end regardless of whether an exception happens or not
                {
                    
                }*/
                correctResponse = false;
                while (correctResponse == false)
                {
                    Console.WriteLine("Would you like to save another document? yes/ no");
                    yesNo = Console.ReadLine();
                    if (yesNo == "yes" || yesNo == "Yes" || yesNo == "YES")
                    {
                        loop = true;
                        correctResponse = true;
                    }
                    else if (yesNo == "no" || yesNo == "No" || yesNo == "NO")
                    {
                        loop = false;
                        correctResponse = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect response");
                        correctResponse = false;
                    }
                }
            }
        }
    }
}
