//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Потрібно: Створити клас MyMatrix, який забезпечує надання матриці довільного розміру
//з можливістю зміни числа рядків і стовпців. Написати програму, яка виводить на екран
//матрицю і похідні від неї матриці різних порядків.

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMatrix myMatrix = new MyMatrix(2, 3);
            myMatrix.Display();
            Console.WriteLine("---------------------------");
            myMatrix.EditNumColumnsStrings(1, 5);
            myMatrix.Display();
            Console.WriteLine("---------------------------");
            myMatrix.DisplayDifferentOrders();
            Console.WriteLine("---------------------------");
            myMatrix.EditNumColumnsStrings(5, 5);
            myMatrix.DisplayDifferentOrders();
        }
    }
}