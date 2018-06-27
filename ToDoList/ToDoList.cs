using System;

namespace Leetspeak{
  public class Translate
  {
    public void Run()
    {
      Console.WriteLine("Please enter letters");
      string inputLetters = Console.ReadLine();

      char[]letters = inputLetters.ToCharArray();
      for(int i = 0; i < letters.Length; i++)
      {
        if (!(i == 0 && (letters[i] == 's' || letters[i] == 'S')))
        {
          letters[i] = TranslateToLeet(letters[i]);
        }
      }
      Console.WriteLine(letters);
      Console.WriteLine(new String(letters));
    }

    public char TranslateToLeet (char letter)
    {
      if (letter == 'e' || letter == 'E')
      {
        return '3';
      }
      else if (letter == 'o' || letter == 'O')
      {
        return '0';
      }
      else if (letter == 'I')
      {
        return '1';
      }
      else if (letter == 't' || letter == 'T')
      {
        return '7';
      }
      else if (letter == 's' || letter == 'S')
      {
        return 'z';
      }

      return letter;
    }
  }

  public class Program
  {
    public static void Main()
    {
      Translate translator = new Translate();
      translator.Run();
    }
  }
}
