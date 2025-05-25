using System.Text;

string textFile = @"Files\test.txt";
var input = Console.ReadLine();
var fileName = textFile.Split('\\').Last();

//Nullcheck
//while (!input.Equals("-e"))
//{
using (StreamReader reader = new(textFile))
{
    // number of bytes in a file
    if (input == "-c")
    {
        FileInfo fileInfo = new(textFile);
        Console.WriteLine($"{input} {fileName}");
        Console.WriteLine($"{fileInfo.Length} {fileName}");
    }

    // number of lines in a file
    if (input == "-l")
    {
        var lines = File.ReadLines(textFile);
        Console.WriteLine($"{input} {fileName}");
        Console.WriteLine($"{lines.Count()} {fileName}");
    }

    // number of words in a file
    if (input == "-w")
    {
        var text = reader.ReadToEnd();

        var wordCount = 0;

        for (int i = 0; i < text.Length-1; i++)
        {
            if (char.IsWhiteSpace(text[i]))
                i++;

            if (!char.IsWhiteSpace(text[i]))
            { 
                while(i < text.Length && !char.IsWhiteSpace(text[i]))
                    i++;
                wordCount++;
            }               
        }

        Console.WriteLine($"{wordCount} {fileName}");
    }

    if (input == "-m")
    {
        
        var charsInFile = reader.ReadToEnd().Length;
        Console.WriteLine(charsInFile);
    }
}

Console.ReadLine();
//}


/*
 Så länge som "END" inte är input - när END är input, stäng program
öppna filen
läs input och utför instruktion

 */