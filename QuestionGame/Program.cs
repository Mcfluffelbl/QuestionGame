
Console.Title = "Question Game";

// Introduction
Console.WriteLine("Welcome to the Question Game!");
Console.WriteLine("\nYou will be asked a series of questions. Try to answer them correctly!");
Console.WriteLine("\nYou can choose in betwenn 5 diffrent themes");
Console.WriteLine("Themes: Science, History, Geography, Animals, Entertainment");
Console.WriteLine("\nRules:");
Console.WriteLine("1. Each theme contains 10 questions, randomly sorted out.");
Console.WriteLine("2. You will have 4 options for each question.");
Console.WriteLine("3. For each correct answer, you will earn points.");
Console.WriteLine("4. You can also choose to answer questions from all themes mixed together.");

// Wait for user to be ready
Console.WriteLine("\nPress any button to start...");
Console.ReadKey(true);
Console.WriteLine();

// Initialize score and question count
var score = 0;
var askedQuestions = 0;

// Main game loop

// End of game summary
Console.WriteLine($"\nGame Over! You answered {askedQuestions} questions with a total score of {score} points.");
Console.WriteLine("Tryck på valfri knapp för att avsluta spelet...");
Console.ReadKey(true);