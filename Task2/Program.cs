//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Потрібно: Створити масив розмірністю N елементів, заповнити його довільними цілими значеннями. 
//    Вивести найбільше значення масиву, 
//    найменше значення масиву, загальну суму елементів, середнє арифметичне всіх елементів, вивести всі непарні значення

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 1,2,3,4,5,6,7,8,9,10};
            
            Console.WriteLine("The biggest value -> "+array.Max());
            Console.WriteLine("The smallest value -> "+array.Min());
            Console.WriteLine("Sum = "+array.Sum());
            Console.WriteLine("Avg = "+array.Average());
            Console.WriteLine("Odd: ");
            foreach (int i in array)
            {
                if(i%2 != 0)
                    Console.WriteLine(i);
            }
        }
    }
}