## For-Loop

```C#

// Beispiel:
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Zeile " + i);
}

// Folgende Ausgabe wird kommen.
// Zeile 0
// Zeile 1
// Zeile 2
// Zeile 3
// Zeile 4
// Zeile 5
// Zeile 6
// Zeile 7
// Zeile 8
// Zeile 9
```

## string interpolation 

Beispiel:

```C#
string name = "Dude";
string end = "Bye bye";
string satz = $"Hello world {name}, {end}";
// Anstatt string satz = "Hello world " + name + ", " + end;
Console.WriteLine(satz);
```