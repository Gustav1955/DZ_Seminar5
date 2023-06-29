/*
Задача 38: Задайте массив, используя класс Random()
 вещественных чисел. Найдите разницу между максимальным и минимальным 
 значением вещественной части элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

Console.Clear();

    int [] CreateArray1(int size, int min, int max)
    { 
    int [] array1 = new int [size]; 
    Random rand = new Random(); 
 
    for (int i = 1; i < size; i++) 
    { 
        array1 [i] = rand.Next(min, max); 
    } 
    return array1;
    }

    int[] array1 = CreateArray1(5,0,10); 



    double [] CreateArray2(int size, double min, double max)
    { 
    double [] array2 = new double [size]; 
    Random rand = new Random(); 
 
    for (int i = 1; i < size; i++) 
    { 
        array2 [i] = Math.Round(rand.NextDouble(), 3) + array1 [i]; 
    } 
   
    Console.WriteLine($"[{string.Join(", ", array2)}]"); 
    return array2; 
} 
double [] array2 = CreateArray2(5,0,10); 

double CreateArray3(int size, double min, double max)
{
    double [] array3 = new double [size];
    for (int i = 1; i < size; i++) 
    {
        array3 [i] = array2[i] - array1[i];
    }
    return array3;
}

 double GetDigits(double [] array3){
    double min = array3[0];
    double max = array3[0];
        for (int i = 1; i < array2.Length; i++) 
    { 
        if (array3[i] > max) max = array3[i];
        if (array3[i] < min) min = array3[i];
    } 
    double num = max - min;
    return num;
        }


double [] array3 = CreateArray3(5,0,10);
double num = GetDigits(array3);
Console.WriteLine($" difference = {num}");