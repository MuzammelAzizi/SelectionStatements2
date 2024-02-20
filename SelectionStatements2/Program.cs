using System.Net.Mail;

namespace SelectionStatements2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Science":
                    Console.WriteLine("Science is an interesting subject");
                    break;

                case "Art":
                    Console.WriteLine("Art is a fun!");
                    break;

                case "Math":
                    Console.WriteLine("Math is a hard subject");
                    break;

                case "English":
                    Console.WriteLine("English is an amazing subject!"); 
                    break;

                case "Chemistry":
                    Console.WriteLine("Chemistry is a tough subject");  
                    break;

                default : Console.WriteLine("Amazing!! I remember taking that subject");    
                    break;


            }
        }
    }
}
