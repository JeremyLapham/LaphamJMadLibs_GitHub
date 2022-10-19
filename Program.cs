//Jeremy Lapham
//10-17-22
//Mad Libs
//This program will ask the user for different things that will then be put into a mad libs game
//Peer Review:


bool playAgain = true;
while(playAgain)
{
    Console.WriteLine("We are going to play a little Game called Mad Libs");
    Console.WriteLine("This Story is called Trick Or Treat!");

Console.WriteLine("");

    Console.WriteLine("Now I'm going to ask you to give me different things.");
    Console.WriteLine("Starting off give me an Adjective");
    string Adj1 = Console.ReadLine();

    Console.WriteLine("Now I need a Noun");
    string noun1 = Console.ReadLine();

    Console.WriteLine("Now another Adjective");
    string adj2 = Console.ReadLine();

    Console.WriteLine("Now a verb");
    string verb1 = Console.ReadLine();

    Console.WriteLine("Now another Verb");
    string verb2 = Console.ReadLine();

    Console.WriteLine("Now another Noun");
    string noun2 = Console.ReadLine();

    Console.WriteLine("Now another Noun");
    string noun3 = Console.ReadLine();

    Console.WriteLine("Now a fourth noun");
    string noun4 = Console.ReadLine();

    Console.WriteLine("Now a third verb");
    string verb3 = Console.ReadLine();

    Console.WriteLine("Now a fifth noun");
    string noun5 = Console.ReadLine();

    Console.WriteLine("Now I need a word to show your excitement");
    string excite1 = Console.ReadLine();

    Console.WriteLine("Now an adverb");
    string adverb = Console.ReadLine();

    Console.WriteLine("Now a fourth verb");
    string verb4 = Console.ReadLine();

    Console.WriteLine("Now last but not least a verb");
    string verb5 = Console.ReadLine();

    Console.WriteLine("Now here is your story!");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine($"It is a {Adj1} Halloween night. I have my {noun1} costume on and I step outside to begin my {adj2} eveing of trick or treating. I {verb1} down the street and {verb2} up to the first door. \"{noun2} or treat\" I said as the door began to open. \"{noun2} or treat?\" a {noun4} said on the other side of the door. \"What does that mean?\" \"It means if you don't give me a treat I'll have to {verb3} a {noun5} on you. \"{excite1}\" he said as he {adverb} {verb4} out the door and {verb5} down the street. I guess he played a trick on me!");

Console.WriteLine("");
Console.WriteLine("");
    Console.WriteLine("Do you want to play again? Type yes to play again, Type end to stop playing.");
string playAgain2 =Console.ReadLine().ToLower();
if(playAgain2 =="end")
{
    playAgain = false;
}
}
