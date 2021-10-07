## 1. Gerade Zahl

> Aufgabe

* Fragt die Eingabe vom Nutzer ab.
* Falls die Eingabe eine gerade Zahl ist, dann soll auf der Console "Das ist eine gerade Zahl" ausgeben werden.
* Falls die Eingabe nicht eine gerade Zahl ist, dann soll auf der Console "Das ist eine ungerade Zahl" ausgeben werden.

## 2. Fizz Buzz

> Aufgabe

* Nutzer gibt eine Zahl ein. 
* Es soll für jedes Vielfache von 5 zwischen 1 und der eingebender Zahl folgende Zeile ausgeben werden. "[number] Buzz"
* Es soll für jedes Vielfache von 3 zwischen 1 und der eingebender Zahl folgende Zeile ausgeben werden. "[number] Fizz"
* Dabei ist number die aktuelle Zahl.

> Beispiel

* Eingabe von 50

```
3 Fizz
5 Buzz
6 Fizz
9 Fizz
10 Buzz
12 Fizz
15 Buzz
15 Fizz
18 Fizz 
20 Buzz
21 Fizz
24 Fizz
25 Buzz
27 Fizz
30 Buzz
30 Fizz
33 Fizz
35 Buzz
36 Fizz
40 Buzz
39 Fizz
42 Fizz
45 Buzz
45 Fizz
48 Fizz
50 Buzz
```

> Hintergrund

Stellt ein Wortspiel dar mit denen Kinder Divisionen lernen sollen.

[Wiki Link](https://de.wikipedia.org/wiki/Fizz_buzz)

Ist auch eine ganz beliebte Aufgabe in Bewerbungsgesprächen für ein Programmierjob :)

## 3. Integer Function

> Aufgabe

* Schreibe eine Function mit folgender Vorschrift/Signature "static int GetIntegerFromUser()"
* Beim Aufruf dieser Funktion soll der Nutzer um eine Eingabe gebeten werden auf der Konsole.
* Nach der Eingabe vom Nutzer soll von der Function ein Integer zurück gegeben werden.

> Beispiel

```C#
int number = GetIntegerFromUser();

// Nutzer gibt 2 ein

Console.WriteLine(number);

// Ausgabe ist 2.
```

## 4. Gesamt Summe von einem Array
> Aufgabe


* Schreibe eine Function namens "SummeArray"
* Diese Funktion soll eine Array mit element von type double als Parameter bekommen. Diese Funktion soll die Summe alle Element des Arrays zurück geben.

> Beispiel:

```C#
int[] numbers = new int[3];
numbers[0] = 2;
numbers[1] = 4;
numbers[2] = 5;

int summe = SummeArray(numbers);
Console.WriteLine(summe); // 11
```

## 5. Durchschnitt von einem Array

> Aufgabe

* Schreibe eine Function namens "Average"
* Diese Funktion soll ein Array mit element von type double als Parameter bekommen. Diese Funktion soll den Durchschnitt alle Elemente zurück gegeben.

> Beispiel:

```C#
double[] numbers = new int[3];
numbers[0] = 2;
numbers[1] = 4;
numbers[2] = 5;

int summe = Average(numbers);
Console.WriteLine(summe); // 3.0
```

## 6. Maximum von einem Array

> Aufgabe

* Schreibe eine Function namens "Maximum"
* Diese Funktion soll ein Array mit element von type double als Parameter bekommen. Diese Funktion soll die größte Zahl alle Elemente zurück geben.

> Beispiel:

```C#
double[] numbers = new int[3];
numbers[0] = 2;
numbers[1] = 4;
numbers[2] = 5;

int summe = Maximum(numbers);
Console.WriteLine(summe); // 5
```

## 7. Minimum von einem Array

> Aufgabe

* Schreibe eine Function namens "Minimum"
* Diese Funktion soll ein Array mit element von type double als Parameter bekommen. Diese Funktion soll die kleinste Zahl alle Elemente zurück geben.

> Beispiel:

```C#
double[] numbers = new int[3];
numbers[0] = 2;
numbers[1] = 4;
numbers[2] = 5;

int summe = Minimum(numbers);
Console.WriteLine(summe); // 2
```

