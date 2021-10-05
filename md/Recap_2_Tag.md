# Recap vom 2. Tag

## Modulo operator %

Ergebnis der Rest der nicht mehr in die Zahl hinein geht.

2 % 3 = 1 \
5 % 8 = 5 \
3 % 2 = 1 \
4 % 2 = 0

## if statement
```C#
string eingabe = Console.ReadLine();
int number = Convert.ToInt32(eingabe);
int rest = number % 2; 

if (rest == 0) // rest == 0 ist die Condition
{
    // Dieser code wird ausgeführt wenn rest == 0 true ist.
    Console.WriteLine("Zahl ist gerade.");
}
else 
{
    // Dieser code wird ausgeführt wenn rest == 0 false ist.
    Console.WriteLine("Zahl ist ungerade.");
}
```

## while loop

```C#

int number = 3;
while (number > 0) 
{
    // Führt diesen Code solange aus bis number nicht mehr größer als 0 ist. 
    Console.WriteLine("Eine weitere Zeile.");
    number = number - 1;
}

// "Eine weitere Zeile." wird 3 mal ausgeben.


```

## Conditions in if und while

### a == b 
a ist gleich b ? \
Bsp: \
2 == 2 => true \
2 == 3 => false

### a != b 
a ist nicht gleich b ? \
Bsp: \
2 != 2 => false \
2 != 3 => true 

### a > b 
a ist größer als b \
Bsp: \
2 > 1 => true \
2 > 3 => false

### a < b 
a ist kleiner als b \
Bsp: \
1 < 2 => true \
2 < 1 => false

### a >= b 
a ist größer oder gleich als b \
Bsp: \
2 >= 1 => true \
2 >= 2 => true \
2 >= 3 => false

### a <= b 
a ist kleiner oder gleich als b \
Bsp: \
2 <= 1 => false \
2 <= 2 => true \
2 <= 3 => true


## Kompakte Schreibweise von Operanden

```C#
number += 2; // number = number + 2;
number++; // number = number + 1; 
```
