# Student Grade Book

A C# console application. The user enters their name and a list of test scores, and the program stores them, displays them, and calculates simple statistics.

## Features

- **Add a score**: accepts whole numbers from 0 to 100 and rejects anything else (letters, empty input, out-of-range values)
- **View all scores**: lists every score with its position, e.g. `Score 1: 78`
- **View statistics**:
  - Average (shown to 2 decimal places)
  - Highest score
  - Count of odd and even scores
  - Overall grade: **Distinction** (70+), **Pass** (50-69) or **Fail** (below 50)
- **Fun extras**: prints your name in reverse, shows a times table (1 to 12) for a number you choose, and lists subjects with their teachers
- **Clear all scores**: removes every saved score
- **Error handling**: invalid input is handled gracefully, and unexpected errors show a friendly message instead of crashing

## How to Run

1. Clone or download this repository.
2. Open `WYZEtasks.sln` in Visual Studio.
3. Press **F5** (or click the green Start button) to run.

Alternatively, from a terminal in the project folder:

```
dotnet run
```

Requires the [.NET SDK](https://dotnet.microsoft.com/download).

## Example

```
Hello there, Welcome to the student gradebook!
Enter your name: Amaka

Hello Amaka, Let us record your scores.
MENU
1. Add a score
2. View all scores
3. View statistics
4. Fun extras
5. Clear all scores
6. Exit

Pick an option: 1
Enter a score between 0 and 100: 78
Scores saved! You now have 1 score(s)
```

## Concepts Practised

Data types, `int.TryParse`, `if` statements, `switch` statements, `while` and `for` loops, strings, `List<int>`, `Dictionary<string, string>`, functions, `out` parameters, the conditional (`?:`) operator, constants, and `try`/`catch` exception handling.

## Project Files

| File | Purpose |
|------|---------|
| `Program.cs` | All of the program code |
| `WYZEtasks.csproj` | Project settings |
| `WYZEtasks.sln` | Solution file (open this in Visual Studio) |

## Author

Chuks Ozioma
