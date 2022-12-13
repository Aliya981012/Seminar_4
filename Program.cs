Console.WriteLine("Hi! Please input task number");
int numberoftask = Convert.ToInt32(Console.ReadLine());
if (numberoftask == 25) Task25();
else if (numberoftask == 27) Task27();
else if (numberoftask == 29) Task29();
else Console.WriteLine("Oops! Wrong task. Please input 25, 27 or 29");

void Task25()
{
    Random rand = new Random();
    double a = rand.Next(1,10);
    double b = rand.Next(1,10);
    double result = 1;
    double i = 1;
    while (i <= b)
    {
        result = result * a;
        i++;
    }
    Console.WriteLine($"{a} to the power of {b} gives {result}");
}

void Task27()
{
    int number = new Random().Next(1,1000);
    int result = 0;
    for(int i = 0; i < Convert.ToString(number).Length; i++)
    {
        result = result + Convert.ToInt32(Convert.ToString(number)[i].ToString());
    }
    Console.WriteLine($"The number is {number}.");
    Console.WriteLine($"The result is {result}.");
}

void Task29()
{
    int size = 8;
    int[] arr = new int [size];
    
    void FillArray(int[] array)
    {
        int i = 0;
        while (i < size)
        {
            arr[i] = new Random().Next(-10,10);
            i++;
        }
        
    }
    void PrintArray(int[] array)
    {
        for(int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    void SortArray(int[] array)
    {
        for(int i = 0; i < size - 1; i++)
        {
            int minposition = i;
            for(int j = i + 1; j < size; j++)
            {
                if (Math.Abs(array[j]) < Math.Abs(array[minposition]))
                {
                    minposition = j;
                }
            }
            int temp = array[i];
            array[i] = array[minposition];
            array[minposition] = temp;
            
        }
        Console.WriteLine($"Answer:");

    }
    FillArray(arr);
    SortArray(arr);
    PrintArray(arr);
}