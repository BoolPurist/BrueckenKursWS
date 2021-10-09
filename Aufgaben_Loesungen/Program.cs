using System;

namespace BrueckenKursProject
{
  class Program
  {
    static void Main(string[] args)
    {

      
    }

    static void Aufgabe1()
    {
      Console.WriteLine("Hello World!");
    }

    static void Aufgabe2()
    {
      string nachName = "Mustermann";
      Console.WriteLine(nachName);
    }

    static void Aufgabe3()
    {
      string nachName = "Mustermann";
      string vorName = "Mustermeier";
      Console.WriteLine(nachName);
      Console.WriteLine(vorName);
    }

    static void Aufgabe4()
    {
      string nachName = "Mustermann";
      string vorName = "Mustermeier";
      Console.WriteLine(vorName + " " + nachName);
    }


    static void Aufgabe5()
    {
      int number = 10;
      Console.WriteLine(number);
    }

    static void Aufgabe6()
    {
      int addition = 5 + 34;
      int multiplication = 4 * 38;
      int dividing = 60 / 20;
      Console.WriteLine(addition);
      Console.WriteLine(multiplication);
      Console.WriteLine(dividing);
    }

    static void Aufgabe7()
    {
      int ersteRechnung = 5 + 5 * 2;
      int zweiteRechnung = (5 + 5) * 2;
      int dritteRechnung = 6 / 2 + 5;
      Console.WriteLine(ersteRechnung);
      Console.WriteLine(zweiteRechnung);
      Console.WriteLine(dritteRechnung);
    }

    static void Aufgabe8()
    {
      int acht = 8;
      int zweiundzwanzig = 22;
      Console.WriteLine(acht + zweiundzwanzig);
    }

    static void Aufgabe9()
    {
      int acht = 8;
      int zweiundzwanzig = 22;
      int ergebnis = acht + zweiundzwanzig;
      Console.WriteLine(ergebnis);
    }

    static void Aufgabe10()
    {
      double wert = 3.67;
      Console.WriteLine(wert * 5.0);

    }

    static void Aufgabe11()
    {
      double meinWert1 = 6.0;
      int mainWert2 = 4;
      double ergebnis = meinWert1 / mainWert2;
      Console.WriteLine(ergebnis);
    }

    static void Aufgabe12()
    {
      string eingabe = Console.ReadLine();
      Console.Clear();
      Console.WriteLine(eingabe);
    }

    static void Aufgabe13()
    {
      string eingabe = Console.ReadLine();
      Console.Clear();
      Console.WriteLine("Das ist mein Text: " + eingabe);
    }

    static void Aufgabe14()
    {
      Console.WriteLine("Gebe deinen Name an:");
      string name = Console.ReadLine();
      Console.Clear();
      Console.WriteLine("Gebe deinen Alter an:");
      string alter = Console.ReadLine();
      Console.Clear();
      Console.WriteLine("Ich bin " + name + " und " + alter + " Jahre alt.");
      // Altnative auch moeglich
      // Console.WriteLine($"Ich bin {name} und {alter} Jahre alt.");
      // Nennt sich string interpolation
      // Hier link zur Doku
      // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
    }

    static void Aufgabe15()
    {
      // Wenn noch was anderes als zahlen eingeben werden stürzt das program ab.
      // Es wird eine exception geworfen weswegen das program abstürzt.
      int number = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(number);
    }

    static int Aufgabe16()
    {
      int geburtsjahr = Convert.ToInt32(Console.ReadLine());
      int aktuellesJahr = 2021 - geburtsjahr;
      Console.WriteLine(aktuellesJahr);
      return aktuellesJahr;
    }

    static void Aufgabe17()
    {
      double celius = Convert.ToDouble(Console.ReadLine());
      double ergebnis = celius * 1.8 + 32.0;
      Console.WriteLine("Fahrenheit: " + ergebnis);
      // C × 1,8 + 32
    }

    static void Aufgabe18()
    {
      double euro = Convert.ToDouble(Console.ReadLine());
      double dollar = euro * 1.18;
      Console.WriteLine("Dollar: " + dollar);
    }

    static void Aufgabe19()
    {
      int alter = Convert.ToInt32(Console.ReadLine());
      CheckIfMature(alter);
    }

    static void CheckIfMature(int alter)
    {
      if (alter > 17) // alter >= 18 waere auch moeglich.
      {
        Console.WriteLine("volljährig");
      }
      else
      {
        Console.WriteLine("minderjährig");
      }
    }

    static void Aufgabe20()
    {
      int alter = Aufgabe16();
      CheckIfMature(alter);
    }

    static void Aufgabe21()
    {
      Console.WriteLine("Wie viele Tage hat der September");
      string antwort = Console.ReadLine();
      if (antwort == "30")
      {
        Console.WriteLine("richtig");
      }
      else
      {
        Console.WriteLine("falsch");
      }
    }

    static void Aufgabe22()
    {
      string antwort = Console.ReadLine();
      int number = Convert.ToInt32(antwort);

      if (number > 20)
      {
        Console.WriteLine("Größer als 20");
      }
      else
      {
        Console.WriteLine("Kleiner oder gleich 20");
      }

    }

    static void Aufgabe23()
    {
      Console.WriteLine("Preis: ");
      double preis = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Number: ");
      double number = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Was der Kunde gibt: ");
      double kundenSumme = Convert.ToDouble(Console.ReadLine());

      double gesamtSumme = preis * number;
      double wechselGeld = kundenSumme - gesamtSumme;

      if (wechselGeld > 0)
      {
        Console.WriteLine("Du bekommst " + wechselGeld + " zurück.");
      }
      else if (wechselGeld == 0)
      {
        Console.WriteLine("Vielen Dank für Ihren Einkauf !");
      }
      else
      {
        // Wechselgeld ist negative und Kunde hat zu wenig bezahlt.
        // Durch die MultipliKation mit -1 wird der Betrag wieder positiv. 
        // An zu zeigen das der Kunde negatives Geld bezahlen muss macht nicht so viel Sinn.
        double ausgabeWechselGeld = wechselGeld * -1.0;
        Console.WriteLine("Du musst noch " + ausgabeWechselGeld + " bezahlen.");
      }
    }

    static void Aufgabe24()
    {
      string eingebenesWort = Console.ReadLine();
      if (eingebenesWort == "Atmosphäre")
      {
        Console.WriteLine("Richtig geschrieben.");
      }
      else
      {
        Console.WriteLine("Falsch geschrieben.");
      }
    }

    static void Aufgabe25()
    {
      for (int i = 0; i < 100; i++)
      {
        Console.WriteLine("Das ist eine for-Schleife");
      }
    }

    static void Aufgabe26()
    {
      for (int i = 0; i < 51; i++)
      {
        Console.WriteLine(i);
      }
    }

    static void Aufgabe27()
    {
      for (int i = 2; i <= 52; i++)
      {
        Console.WriteLine(i);
      }
    }

    static void Aufgabe28()
    {
      for (int i = 1; i <= 42; i++)
      {
        Console.WriteLine("Das ist der " + i + ".Durchlauf");
      }
    }

    static void Aufgabe29()
    {
      Console.WriteLine("Gebe deinen Namen ein.");
      string firstName = Console.ReadLine();
      Console.WriteLine("Gebe deinen nochmal Namen ein.");
      string secondName = Console.ReadLine();
      Console.WriteLine("Gebe deinen doch nochmal Namen ein.");
      string thridName = Console.ReadLine();
      string dreimalDerName = firstName + ", ";
      dreimalDerName += secondName + ", ";
      dreimalDerName += thridName + ".";
      Console.WriteLine("Hallo " + dreimalDerName);
    }

    static void Aufgabe30()
    {
      int summe = 0;
      for (int i = 1; i < 100; i++)
      {
        summe += i;
      }
      Console.WriteLine("Gesamt Summe: " + summe);
    }

    static void Aufgabe31()
    {
      for (int i = 100; i > -1; i--)
      {
        Console.WriteLine(i);
      }

    }

    static void Aufgabe32()
    {
      for (int i = 0; i <= 10; i++)
      {
        Console.WriteLine(i);
      }

      for (int i = 10; i >= 5; i--)
      {
        Console.WriteLine(i);
      }
    }

    static void Aufgabe33()
    {
      // Wir gaben hier 100 als obere Grenze vor.
      // So werden also alle Vielfachen von 5 bis 100 ausgeben.
      for (int i = 1; i <= 100; i++)
      {
        if (i % 5 == 0)
        {
          Console.WriteLine(i);
        }
      }
    }


    static void Aufgabe34()
    {
      int aktuelleSumme = 1;
      int gesammtSumme = 0;
      for (int i = 0; i < 10; i++)
      {
        aktuelleSumme *= 2;
        gesammtSumme += aktuelleSumme;
        Console.WriteLine(aktuelleSumme);
      }

      Console.WriteLine("Gesamt aller 2 Potenzen: " + gesammtSumme);
    }

    static void Aufgabe35()
    {
      int counter = 1;
      while (counter < 101)
      {
        Console.WriteLine(counter);
        counter++;
      }
    }

    static void Aufgabe36()
    {
      int counter = -100;
      while (counter < 101)
      {
        Console.WriteLine(counter);
        counter++;
      }
    }

    static void Aufgabe37()
    {
      string name = Console.ReadLine();
      name += ", " + name + ", " + name + ".";
      Console.WriteLine(name);
    }

    static void Aufgabe38()
    {
      string nutzerName = "unbekannt";
      bool hatRictigenNutzerNameEingeben = false;
      Console.WriteLine("Bitte gebe den richtigen Nutzername ein.");

      while (hatRictigenNutzerNameEingeben == false)
      {
        string eingabe = Console.ReadLine();
        if (eingabe == nutzerName)
        {
          Console.WriteLine("Welcome " + nutzerName);
          hatRictigenNutzerNameEingeben = true;
        }
        else
        {
          Console.WriteLine("Falscher Nutzername bitte noch einmal eingeben.");
        }

      }


    }

    static void Aufgabe39()
    {
      int number = Convert.ToInt32(Console.ReadLine());

      for (int i = 2; i < number; i++)
      {
        if (CheckForPrimnumber(i))
        {
          Console.WriteLine("Primzahl: " + i);
        }
      }
    }

    static bool CheckForPrimnumber(int number)
    {

      for (int i = 2; i < number; i++)
      {
        if (number % i == 0)
        {
          return false;
        }
      }

      return true;
    }

    static void Aufagbe40()
    {
      int number = Convert.ToInt32(Console.ReadLine());

      int aktuellePrimzahl = 2;
      int restNummer = number;
      string ausgabe = "";

      while (!CheckForPrimnumber(restNummer))
      {
        if (restNummer % aktuellePrimzahl == 0)
        {
          ausgabe += aktuellePrimzahl + " * ";
          restNummer /= aktuellePrimzahl;
        }
        else
        {
          aktuellePrimzahl = FindNextPrimNumber(aktuellePrimzahl);
        }
      }

      ausgabe += restNummer;
      Console.WriteLine("Zerlegung: " + ausgabe);



    }

    static int FindNextPrimNumber(int number)
    {
      while (true)
      {
        number++;
        if (CheckForPrimnumber(number)) return number;
      }

    }

    static void Aufgabe42()
    {
      int counter = 0;
      string[] symbols = new string[5];
      symbols[0] = "1";
      symbols[1] = "2";
      symbols[2] = "3";
      symbols[3] = "4";
      symbols[4] = "5";

      do
      {
        Console.WriteLine(symbols[counter]);
        counter++;
      } while (counter < symbols.Length);
    }

    static void Aufgabe43()
    {
      Console.WriteLine("Gebe einen Nutzername ein.");
      string nutzerName = Console.ReadLine();
      Console.WriteLine("Gebe ein Passwort ein.");
      string password = Console.ReadLine();


      string eingabeNutzerName = "";
      string eingabePassword = "";
      do
      {
        Console.WriteLine("Gebe den korrekten Nutzername ein");
        eingabeNutzerName = Console.ReadLine();
        Console.WriteLine("Gebe das korrekten Password ein");
        eingabePassword = Console.ReadLine();
      } while (eingabeNutzerName != nutzerName || eingabePassword != password);

      Console.WriteLine("Welcome");
    }

    static void Aufgabe44()
    {
      int number = Convert.ToInt32(Console.ReadLine());

      if (CheckForPrimnumber(number))
      {
        Console.WriteLine(number + " ist eine Primzahl.");
      }
      else
      {
        Console.WriteLine(number + " ist keine Primzahl.");
        int größernPrimzahl = FindNextPrimNumber(number);
        int abstandZurGrößernPrimzahl = größernPrimzahl - number;
        Console.WriteLine("Abstand zur nächst größeren Primzahl (" + größernPrimzahl + ") lautet: " + abstandZurGrößernPrimzahl);
        int kleinerPrimzahl = FindNextSmallerPrinNumber(number);
        int abstandZurKleinerePrimzahl = number - kleinerPrimzahl;
        Console.WriteLine("Abstand zur nächst größeren Primzahl (" + kleinerPrimzahl + ") lautet: " + abstandZurKleinerePrimzahl);
      }
    }

    static int FindNextSmallerPrinNumber(int number)
    {
      int counter = number;
      while (counter > 2)
      {
        counter--;
        if (CheckForPrimnumber(counter))
        {
          return counter;
        }
          
      }

      return counter;
    }

    static void Aufgabe45()
    {
      string[] names = new string[2];
      Console.WriteLine("Gebe deinen Vornamen ein");
      names[0] = Console.ReadLine();
      Console.WriteLine("Gebe deinen Nachnamen ein");
      names[1] = Console.ReadLine();

      Console.WriteLine("Vorname: " + names[0]);
      Console.WriteLine("Nachname: " + names[1]);
    }

    static void Aufgabe46()
    {
      string[] names = new string[5];
      for (int i = 0; i < names.Length; i++)
      {
        int index = i + 1;
        Console.WriteLine("Eingabe von " + index + ".Namen");
        names[i] = Console.ReadLine();
      }

      for (int i = 0; i < names.Length; i++)
      {
        int index = i + 1;
        Console.WriteLine("Ausgabe von " + index + ".Namen");
        Console.WriteLine(names[i]);
      }
    }


    static void Aufgabe47()
    {
      string[] data = new string[5];
      data[0] = "Meier";
      data[1] = "Muster";
      data[2] = "100";
      data[4] = "IN";

      for (int i = 0; i < data.Length; i++)
      {
        Console.Write(data[i] + " ");
      }
      
    }

    static void Aufgabe48()
    {
      Random random = new Random();

      int[] numbers = new int[6];
      
      for (int i = 0; i < numbers.Length; i++)
      {
        int index = i + 1;
        Console.WriteLine(index + ". Geben  Zahl zwischen 1 und 49 ein ");
        int zahl = Convert.ToInt32(Console.ReadLine());

        if (zahl < 1)
        {
          i--;
        }
        else if (zahl > 49)
        {
          i--;
        }
        else
        {
          numbers[i] = zahl;
        }
      }

      int[] numbersToHit = new int[6];
      for (int i = 0; i < numbersToHit.Length; i++)
      {
        numbersToHit[i] = random.Next(1, 50);
      }

      bool jackpot = true;

      for (int i = 0; i < numbersToHit.Length; i++)
      {
        Console.WriteLine("Deine Nummer: " + numbers[i] + " Jackpot Nummer: " + numbersToHit[i]);
        if (numbers[i] != numbersToHit[i])
        {
          jackpot = false;
        }
      }

      if (jackpot)
      {
        Console.WriteLine("Jackpot !!!");
      }
      else
      {
        Console.WriteLine("Kein Jackpot :(");
      }

    }
  }



  



}
