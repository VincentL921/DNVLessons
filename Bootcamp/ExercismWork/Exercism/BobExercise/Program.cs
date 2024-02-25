using System;
using System.Collections;
using System.Linq;

//var response = Bob.Response("DONT BULLY ME!");
//Console.WriteLine(response);

public static class Bob
{
    public static string Response(string statement)
    {
        var isSilent = string.IsNullOrEmpty(statement);
        var isQuestion = statement.EndsWith("?");
        var lowercaseChar = statement.Where(m => char.IsUpper(m) == false && char.IsLetter(m));
        var isUppercase = lowercaseChar.Any() == false;
        var noLetters =  statement.Contains("");

        if (isSilent)
        {
            return "Fine. Be that way!";
        }
        if (isQuestion && isUppercase)
        {
            return "Calm down, I know what I'm doing!";
        }
        if (isQuestion && !isUppercase)
        {
            return "Sure.";
        }
        if (!isQuestion && isUppercase)
        {
            return "Whoa, chill out!";
        }
        if (noLetters)
        {
            return "Whatever";
        }
        return "Whatever.";

    }
}