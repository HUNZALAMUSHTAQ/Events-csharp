using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    delegate void DelOp(int x, int y);
    delegate void DelLogs(string text);

    public class Operations
    {
        public static void Multiplication(int x, int y)
        {
            Console.WriteLine("The Multiple is :"+ x * y);
        }
        public static void Addition(int x, int y)
        {
            Console.WriteLine("The Addition is :" + x + y);
        }
    }

    public class LogService
    {
        public static void cnsl(string text)
        {
            Console.WriteLine(text);
        }

        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Logging email sent..." + e.Video.Title);
        }
    }


}
