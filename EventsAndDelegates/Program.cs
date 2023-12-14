// See https://aka.ms/new-console-template for more information

using EventsAndDelegates;
using System;


//DelOp obj = new DelOp(Operations.Multiplication);

//obj(2, 3);

//DelLogs obj2 = new DelLogs(LogService.cnsl);
//obj2(@"They are more like type-safe
//function pointers that can be used to
//encapsulate a method and pass it around as
//a parameter or store it for later invocation.");


//for (int i = 0; i < obj.Length; i++)
//{
//    obj[i](2, 5);
//    obj[i](8, 5);
//    obj[i](4, 6);
//}

//DelLogs system = DelLogs();


//var video = new Video() { Title= "Video 1"};
//var videoEncoder = new VideoEncoder(); // publisher 
//var emailService = new EmailService(); // subscriber 
//var loggerService = new LogService();





//videoEncoder.VideoEncoded += loggerService.OnVideoEncoded;
//videoEncoder.VideoEncoded += emailService.OnVideoEncoded;


//videoEncoder.Encode(video);

Console.WriteLine("cac".IsPalindrome());

Console.WriteLine("()()(())".AreBracketBalanced());
Console.WriteLine("()()(()".AreBracketBalanced());
Console.WriteLine("()()(())(({{}}))".AreBracketBalanced());

var myKeys = new Pobject();
foreach (int item in myKeys)
{
    Console.WriteLine(item);
}
Console.WriteLine(myKeys.Sum(x => x));