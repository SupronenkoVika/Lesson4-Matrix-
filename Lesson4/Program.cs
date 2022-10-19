using Lesson4;

int x, y;

Console.WriteLine("Enter the array dimension: ");

Console.Write("X = ");
x = int.Parse(Console.ReadLine());

Console.Write("Y = ");
y = int.Parse(Console.ReadLine());


int[,] array = new int[x, y];


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.WriteLine("x - " + i + " y - " + j);
        array[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Array output: ");
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Console.Write(String.Format("{0,5}", array[i, j]));
    }
    Console.WriteLine();
}

MathOperations mathOp = new MathOperations();

Console.WriteLine("Choose the action.");
Console.WriteLine("'p' - amount of positive and negative numbers");
Console.WriteLine("'s' - array sorting");
Console.WriteLine("'i' - array inversion");
char act = Convert.ToChar(Console.ReadLine());

switch (act)
{
    case 'p':
        mathOp.AmountOfPosAndNegNumbers(array, x, y);
        break;
    case 's':
        mathOp.ArrSort(array, x, y);
        break;
    case 'i':
        mathOp.Invers(array, x, y);
        break;
}













