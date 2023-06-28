/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.Clear();

int [] CreateArray(int size, int min, int max){ 
    int [] array = new int [size]; 
    Random rand = new Random(); 
 
    for (int i = 1; i < size; i++) 
    { 
        array [i] = rand.Next(min, max); 
    } 
    Console.WriteLine($"[{string.Join(", ", array)}]"); 
    return array; 
} 
 int GetDigits(int [] array){
    int sum = 0; 
    for (int i = 1; i < array.Length; i = i + 2) 
    { 
        sum = sum + array[i];
    } 
    return sum;
        }

 int[] arr = CreateArray(7,0,10); 
int sum = GetDigits(arr);
Console.WriteLine($"the sum of odd = {sum}");
