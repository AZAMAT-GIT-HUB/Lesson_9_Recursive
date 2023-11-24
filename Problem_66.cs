// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Recursive(int number_a, int number_b){
    if(number_b == number_a){
        
        return number_a;
    }
    return number_b + Recursive(number_a, number_b-1);
    }

Console.Write("Enter the number_a: ");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number_b: ");
int number_b = Convert.ToInt32(Console.ReadLine());
Console.Write("\nSum of number from N to N: " + Recursive(number_a, number_b));

