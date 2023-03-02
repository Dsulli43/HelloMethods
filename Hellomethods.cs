using System; 

namespace HelloMethods
{
    public class program
    {

    
        public static void Main(string[] args)
        {
            string message = Message.GetMessage("la");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
    
}

