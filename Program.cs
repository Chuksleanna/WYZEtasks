Console.WriteLine("Hello there, Welcome to the student gradebook!");

string name = "";
while (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
{
    Console.Write("Enter your name: ");
    name = Console.ReadLine()!;
    Console.WriteLine();

    if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
    {
        Console.Write("Name is required. Please try again. ");
        Console.WriteLine();
    }
}

Console.Write($"Hello {name}, Let us record your scores.");
Console.WriteLine();

bool run = true;
List <int> scores = new List<int>();

const int MinScore = 0;
const int MaxScore = 100;

try
{

    while (run)
    {

        Console.WriteLine("MENU");
        Console.WriteLine("1. Add a score");
        Console.WriteLine("2. View all scores");
        Console.WriteLine("3. View statistics");
        Console.WriteLine("4. Fun extras");
        Console.WriteLine("5. Clear all scores");
        Console.WriteLine("6. Exit");
        Console.WriteLine();

        Console.Write("Pick an option: ");
        string ? numInput = Console.ReadLine();

        int num;
        bool success = int.TryParse(numInput, out num);

        if (success)
        {
            switch (num)
            {
                case 1:
                    AddScore(scores, MinScore, MaxScore);
                    Console.WriteLine();
                    break;

                case 2:
                    Viewscore(scores);
                    Console.WriteLine();
                    break;

                case 3:
                    ViewStatistics(scores);
                    Console.WriteLine();
                    break;

                case 4:
                    FunExtras(name);
                    Console.WriteLine();
                    break;

                case 5:
                    Clearscores(scores);
                    Console.WriteLine();
                    break;

                case 6:
                    Console.WriteLine("Goodbye!");
                    run = false;
                    break;

                default:
                    Console.WriteLine("Please choose from option 1 - 6.");
                    Console.WriteLine();
                    break;

            }

        }

        else
        {
            Console.WriteLine("Thats not a valid number. Try again");
        }

    }

}

catch 
{
    Console.WriteLine("Something went wrong, Please try again.");
}

static void AddScore  (List<int> scores, int MinScore, int MaxScore)
{
                Console.Write($"Enter a score between {MinScore} and {MaxScore}: ");
                string ? value = Console.ReadLine();

                if (int.TryParse(value, out int number))
                {

                    if (number >= MinScore && number <= MaxScore)
                    {
                        scores.Add(number);
                        Console.WriteLine($"Scores saved! You now have {scores.Count} score(s)");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                else
                {
                    Console.WriteLine("Thats not a valid number");
                }
}

static void Viewscore (List<int> scores)
{

                if (scores.Count == 0)
                {
                    Console.WriteLine("No scores yet. ");
                }
                else
                {
                   for(int i = 0; i < scores.Count; i++)
                    {
                        Console.WriteLine($"Score {i + 1}: {scores[i]}");
                    }
                }

}

static double GetAverage (List<int> scores)
{
    if (scores == null || scores.Count == 0)
    { 
        return 0; 
    }

    int total = 0;

    for (int i = 0; i < scores.Count; i++)
    {
        total = total + scores[i];
    }

    double average = (double)total / scores.Count;
    return average;
}

static int GetHighest (List<int> scores)
{
    int highest = scores[0];
    for (int i = 0; i < scores.Count; i++)
    { 
      if (scores[i] > highest)
        {
            highest = scores[i];
        }
    }
    return highest;
}


static void CountOddEven (List<int> scores, out int oddCount, out int evenCount)
{
    oddCount = 0;
    evenCount = 0;

    for (int i = 0; i < scores.Count; i++)
    {
        if (scores[i] % 2 == 0)
        { 
         evenCount = evenCount +1;
        }
        else
        {
            oddCount = oddCount +1;
        }
    }

}

static void PrintGrade(double average)
{
    if (average >= 70)
    {
        Console.WriteLine("Distinction");
    }
    
    else
    {
        string grade = (average >= 50) ? "Pass" : "Fail";
        Console.WriteLine(grade);
    }
    Console.WriteLine();
}

static void ViewStatistics (List<int> scores)
{
    if (scores.Count == 0)
    {
        Console.WriteLine("No scores yet");
        return;
    }

    double average = GetAverage(scores);
    int highest = GetHighest(scores);
    CountOddEven (scores, out int oddCount, out int evenCount);

    Console.WriteLine($"Average: {average:F2} ");
    Console.WriteLine($"Highest score: {highest}");
    Console.WriteLine($"Odd scores: {oddCount}, Even Scores: {evenCount}");
    PrintGrade (average);
}

static void FunExtras (string name)
{
    Console.Write("Your name reversed: ");
    for (int i = name.Length - 1; i >= 0; i--)
    {
        Console.Write(name[i]);
    }
    Console.WriteLine();


    int number = 0;
    bool valid = false;

    while (!valid)
    {

        Console.WriteLine();
        Console.Write("Enter a number: ");
        valid = int.TryParse(Console.ReadLine(), out number);

        if (!valid)
        {
            Console.WriteLine("Thats not a valid number. Try again.");
        }
        Console.WriteLine();

    }
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, i * number);
            }
            Console.WriteLine();
       
    Dictionary<string, string> subjects = new Dictionary<string, string>();
    subjects.Add("Maths", "Miss Deborah");
    subjects.Add("English", "Mrs Aanu Jacob");
    subjects.Add("Information Technology", "Mr daniel");
    Console.WriteLine();

    foreach(KeyValuePair<string, string> subject in subjects)
        Console.WriteLine($"{subject.Key}: {subject.Value}");
    Console.WriteLine();

}

static void Clearscores(List<int> scores)
{
    if (scores.Count == 0)
    {
        Console.WriteLine("There are no scores available to clear.");
        return;
    }

    scores.Clear();
    Console.WriteLine("All scores cleared");
}


