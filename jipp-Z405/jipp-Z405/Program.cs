Console.WriteLine("Pierwszy program - rozgrzewka \n");

Console.WriteLine("Zadanie 2\n");
//Console.WriteLine("Podaj swoje imię:");
//var name = Console.ReadLine();
//Console.WriteLine("Hello " + name);

Console.WriteLine("\nZadanie 3\n");
int result = 5 + 9;
Console.WriteLine(result);

Console.WriteLine("\nOperatory \n");
Console.WriteLine("Zadanie 1\n");

int number = 30;
float money = 42.32f;
string text = "zadanie1";
bool isLogged = true;
char myChar = 'A';
decimal price = 140.99m;

Console.WriteLine($"number: {number}");
Console.WriteLine($"money: {money}");
Console.WriteLine($"text: {text}");
Console.WriteLine($"isLogged: {isLogged}");
Console.WriteLine($"myChar: {myChar}");
Console.WriteLine($"price: {price}");

Console.WriteLine("\nZadanie 2\n");
string myAge = "Age: ";
int wifeAge = 18;
string result1 = myAge + wifeAge;
Console.WriteLine(result1);

Console.WriteLine("\nZadanie 3\n");
bool isTrue = true;
bool isFalse = false;
bool isReallyTrue = true;

bool and = isTrue && isFalse;
bool or = isTrue || isReallyTrue;
bool negative = !isFalse;

Console.WriteLine($"and: {and}");
Console.WriteLine($"or: {or}");
Console.WriteLine($"negative: {negative}");

Console.WriteLine("\nZadanie 4\n");
int a = 5;
int b = 12;

int add = a + b;
int sub = a - b;
int div = a / b;
int mul = a * b;
int mod = a % b;

Console.WriteLine($"add: {add}");
Console.WriteLine($"sub: {sub}");
Console.WriteLine($"div: {div}");
Console.WriteLine($"mul: {mul}");
Console.WriteLine($"mod: {mod}");

Console.WriteLine("\nZadanie 5\n");
string d = "Ala ";
string e = "ma ";
string f = "kota.";

string result2 = d + e + f;

Console.WriteLine($"result: {result2}"); // Spacje w zmiennych a i b zapewniają poprawne formatowanie

Console.WriteLine("\nInstrukcje sterujące i pętle\n");

Console.WriteLine("\nZadanie 1\n");
int n1 = 10;
int n2 = 20;

if (n1 > n2)
{
    Console.WriteLine($"{n1} jest większe od {n2}");
}
else if (n1 < n2)
{
    Console.WriteLine($"{n2} jest większe od {n1}");
}
else
{
    Console.WriteLine($"{n1} jest równe {n2}");
}

Console.WriteLine("\nZadanie 2\n");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("C#");
}

int count = 0;
while (count < 10)
{
    Console.WriteLine("C#");
    count++;
}

Console.WriteLine("\nZadanie 3\n");
int n = 10;

for (int i = 0; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} - Parzysta");
    }
    else
    {
        Console.WriteLine($"{i} - Nieparzysta");
    }
}

Console.WriteLine("\nZadanie 4\n");
int n3 = 5;

for (int i = 1; i <= n3; i++)
{
    for (int j2 = 1; j2 <= i; j2++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}


Console.WriteLine("\nZadanie 5\n");
int exam = 86;

if (exam < 0 || exam > 100)
{
    Console.WriteLine("Wartość poza zakresem.");
}
else if (exam <= 39)
{
    Console.WriteLine("Ocena Niedostateczna");
}
else if (exam <= 54)
{
    Console.WriteLine("Ocena Dopuszczająca");
}
else if (exam <= 69)
{
    Console.WriteLine("Ocena Dostateczna");
}
else if (exam <= 84)
{
    Console.WriteLine("Ocena Dobra");
}
else if (exam <= 98)
{
    Console.WriteLine("Ocena Bardzo Dobra");
}
else
{
    Console.WriteLine("Ocena Celująca");
}

Console.WriteLine("\nKolekcje\n");
Console.WriteLine("\nZadanie 1\n");

string[] colors = { "niebieski", "zielony", "żółty", "czerwony" };

Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
Console.WriteLine("Mój ostatni kolor to: " + colors[colors.Length - 1]);

Console.WriteLine("\nZadanie 2\n");
int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Liczba: " + numbers[i]);
}

foreach (int number1 in numbers)
{
    Console.WriteLine("Liczba: " + number1);
}

int j = 0;
while (j < numbers.Length)
{
    Console.WriteLine("Liczba: " + numbers[j]);
    j++;
}

Console.WriteLine("\nZadanie 3\n");

List<string> fruits = new List<string> { "Pomidor", "Jabłko", "Marchewka", "Banan" };

Console.WriteLine(string.Join(", ", fruits));

fruits.RemoveAt(0);
fruits.RemoveAt(fruits.Count - 1);

Console.WriteLine(string.Join(", ", fruits));