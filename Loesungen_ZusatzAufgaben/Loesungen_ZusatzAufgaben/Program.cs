using System;

namespace Loesungen_ZusatzAufgaben
{
  class Program
  {
    static void Main(string[] args)
    {
      GeradeZahl();
    }

    static void GeradeZahl()
    {
      // Prüft nicht ob der Nutzer auch wirklich eine Zahl eingibt
      string eingabe = Console.ReadLine();
      int number = Convert.ToInt32(eingabe);
      if (number % 2 == 0)
      {
        Console.WriteLine("Das ist eine gerade Zahl");
      }
      else
      {
        Console.WriteLine("Das ist eine ungerade Zahl");
      }
    }
   
    static void FizzBuzz(double number)
    {
      for (int i = 1; i <= number; i++)
      {
        if (i % 3 == 0)
        {
          Console.WriteLine($"{i} Fizz");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine($"{i} Buzz");
        }
      }
    }

    static int IntegerConverter()
    {
      // Prüft nicht ob der Nutzer auch wirklich eine Zahl eingibt
      string eingabe = Console.ReadLine();
      int number = Convert.ToInt32(eingabe);
      return number;
    }

    static double SummeArray(double[] numbers)
    {
      double summe = 0;
      
      for (int i = 0; i < numbers.Length; i++)
      {
        summe += numbers[i];
      }

      return summe;
    }

    static double Average(double[] numbers)
    {
      double summe = SummeArray(numbers);
      // Length von einem Array ist ein int
      // Da wir teilen wollen mit double werte, wollen wir die Length auch noch als double wert haben.
      // Ist meistens besser operation mit werten zu machen die den gleichen typen haben. 
      double lengthAsDouble = Convert.ToDouble(numbers.Length); 
      double average = summe / lengthAsDouble;
      return average;
    }

    static double Minimum(double[] numbers)
    {
      double minimum = numbers[0];
      for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] < minimum)
        {
          minimum = numbers[i];
        }
      }

      return minimum;
    }

    static double Maximum(double[] numbers)
    {
      double maximum = numbers[0];
      for (int i = 0; i < numbers.Length; i++)
      {
        if (numbers[i] > maximum)
        {
          maximum = numbers[i];
        }
      }

      return maximum;
    }
  }
}
