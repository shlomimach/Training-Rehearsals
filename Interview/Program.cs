//First project to my GitHub
#region //Reverseשימוש ב
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

List<string> strlst = new List<string>() { "A", "B", "C", "D" };

strlst.Reverse();

foreach (string item in strlst)
{
    Console.WriteLine(item);
}
#endregion
#region//שימוש בפילנדרום
string pilandromName = "banana";/*, "david", "Yosef" }*/;


string reversedText = new string(pilandromName.ToCharArray().Reverse().ToArray());

if (pilandromName.SequenceEqual(reversedText))
    Console.WriteLine("{0} is pilandrom", pilandromName);
else
{
    Console.WriteLine("{0} is not pilandrom", pilandromName);

}


List<string> lst = new List<string>() { "walla", "yosef", "david", "ror" };

foreach (string tmpItem in lst)
{
    string text = new string(tmpItem.ToCharArray().Reverse().ToArray());

    if (tmpItem.SequenceEqual(text))
        Console.WriteLine("{0} is pilandrom", tmpItem);
    else
    {
        Console.WriteLine("{0} is not pilandrom", tmpItem);

    }
}
#endregion
#region //Concatשימוש ב 
int[] num1 = new int[] { 5, 4, 6, 2, 9, 1 };
int[] num2 = new int[] { 2, 5, 3, 2, 8, 0 };

int[] concatNum = num1.Concat(num2).OrderBy(x => x).ToArray();


foreach (int itemInt in concatNum)
{
    Console.Write(itemInt.ToString());
}

Console.WriteLine( );
#endregion
#region//שימוש בחיבור מערכים

int[] ints = new int[] { 5, 4, 3, 0, 10, 11 };



string[] parents = new string[] {"Shlomi,Natali"};
string[] Children = new string[] { "Adelle,Josef" };

string[] concatParentAndChildren = parents.Concat(Children).Reverse().OrderBy(x => x).ToArray();
foreach (string item in concatParentAndChildren)
{
    Console.WriteLine("{0}", item);

}
#endregion
#region//סידור מערכים
string[] familyArray = new string[] { "Child", "Baby", "Parents", "GrandParents" };
int[] ageArray = new int[] { 2, 65, 40, 10 };



for (int i = 0; i < ageArray.Length; i++)
{
    string familyMember = DetermineFamilyMember(ageArray[i]);
    Console.WriteLine($"{familyMember} Age:  {ageArray[i]}");
}
 string DetermineFamilyMember(int age)
{
    if (age <= 3)
    {
        return "Baby";
    }
    else if (age <= 12)
    {
        return "Child";
    }
    else if (age <= 60)
    {
        return "Parents";
    }
    else
    {
        return "GrandParents";
    }
}
#endregion
#region//אורך תווים

string textLength = "This is a sample text with multiple words.";

int wordCount = 0;


// What code should you write here to count the number of words in the text?
//one option
string[] words = textLength.Split(' ');
wordCount = words.Length;
Console.WriteLine($"The number of words in the text is: {wordCount}");

//Two option
int tabTxt = textLength.Length;

Console.WriteLine("The number of char in the text is: {0}", tabTxt.ToString());
#endregion
#region//כפולת המספרים שמתחלקים ב3

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// What code should you write here to calculate the product of all numbers that are divisible by 3?
int product = 1;
foreach (int num in numbers)
{
    if(num%3 == 0)
    {
        product *= num; // Multiply the product by the current number
    }
}
Console.WriteLine($"The product of numbers divisible by 3 is: {product}");
#endregion
#region//המרת מחרוזת למספרים

string input = "12345 67890 45678 98765 23456";

// Split the input string by spaces and convert each part to an integer
string[] numberStrings = input.Split(' ');

List<int> lstInt = new List<int>();

foreach (string numberString in numberStrings)
{
    if (int.TryParse(numberString, out int number))
    {
        numbers.Add(number);
    }
}

Console.WriteLine("The extracted numbers are:");
foreach (int num in numbers)
{
    Console.WriteLine(num);
}

#endregion
#region//המילה הארוכה ביותר
List<string> lstString = new List<string> { "apple", "banana", "cherry", "date" };

// What code should you write here to find the longest word in the list?
string longestWord = "";
int longestNumber = 0;
for (int i = 0; i < lstString.Count; i++)
{
    if (lstString[i].Length > longestNumber)
    {
        longestNumber = lstString[i].Length;
        longestWord = lstString[i].ToString();
    }
}
Console.WriteLine($"The longest word in the list is: {longestWord}");


#endregion
#region//אורך המחרוזת

List<string> lstStringWords = new List<string> { "apple", "banana", "cherry", "date" };
int totalCharacters = 0;

for (int i = 0; i < lstStringWords.Count ; i++)
{
    totalCharacters += lstStringWords[i].Length;
}

// What code should you write here to count the total number of characters in all the words combined?

Console.WriteLine($"The total number of characters is: {totalCharacters}");
#endregion
#region//המחרוזת הקצרה ביותר

List<string> shortestWords = new List<string> { "bi", "bai", "ccb", "aba", "bab" };

// What code should you write here to find the shortest word that starts with the letter 'b'?
string shortestBWord = "";

foreach (string item in shortestWords)
{
    if(item.StartsWith("b") && (item.Length < shortestBWord.Length || shortestBWord.Length == 0))
    {
        shortestBWord = item;
    }
}

Console.WriteLine($"The shortest word that starts with 'b' is: {shortestBWord}");
#endregion
#region//מציאת הממוצע של המספרים הזוגיים

List<int> lstNumbers = new List<int> { 12, 25, 18, 32, 15, 7, 40 };

// What code should you write here to find the average of all even numbers in the list?
double averageOfEvenNumbers = 0.0;
int countOfEvenNumber = 0;
for (int i = 0; i < lstNumbers.Count; i++)
{
    if (lstNumbers[i] % 2 == 0)
    {
        averageOfEvenNumbers += (double)lstNumbers[i];
        countOfEvenNumber++;
    }
}

averageOfEvenNumbers /= countOfEvenNumber;
Console.WriteLine($"The average of even numbers in the list is: {averageOfEvenNumbers}");
#endregion
#region//מציאת הציון הגבוה ביותר ברשימה של אובייקט מסוג סטודנט

List<Student> students = new List<Student>
            {
                new Student("Alice", 85),
                new Student("Bob", 92),
                new Student("Charlie", 78),
                new Student("David", 95),
                new Student("Eve", 88)
            };


// What code should you write here to find the name of the student with the highest score?
string studentWithHighestScore = "";
int tmpScore = 0;
for (int i = 0; i < students.Count; i++)
{
    if(i == 0)
        tmpScore = students[i].Score;
    if (students[i].Score > tmpScore)
    {
        tmpScore = students[i].Score;
        studentWithHighestScore = students[i].Name;
    }

}

Console.WriteLine($"The student with the highest score is: {studentWithHighestScore}");

class Student
{
    public string Name { get; set; }
    public int Score { get; set; }

    public Student(string name, int score)
    {
        Name = name;
        Score = score;
    }
}



#endregion

