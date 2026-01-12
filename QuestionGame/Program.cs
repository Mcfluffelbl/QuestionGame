
Console.Title = "Question Game";

Console.WriteLine("Welcome to the Question Game!");
Console.WriteLine("You will be asked a series of questions. Try to answer them correctly!");
Console.WriteLine("You can choose in betwenn 5 diffrent themes");
Console.WriteLine("Themes: Science, History, Geography, Animals, Entertainment");
Console.WriteLine("Rules:");
Console.WriteLine("Each theme contains 10 questions, randomly sorted out.");
Console.WriteLine("You will have 4 options for each question.");
Console.WriteLine("For each correct answer, you will earn points.");
Console.WriteLine("You can also choose to answer questions from all themes mixed together.");

Console.WriteLine("Press any button to start...");
Console.ReadKey();
Console.WriteLine();

var score = 0;
var askedQuestions = 0;


