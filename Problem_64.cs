// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void Recursive(int number_a){
    if (number_a == 1) {
        Console.Write(number_a + " ! ");
      return;
    }
    Console.Write(number_a + ", ");
    Recursive(number_a - 1);
}

Console.Write("Enter the number N: ");
int N = Convert.ToInt32(Console.ReadLine());
Recursive(N);

