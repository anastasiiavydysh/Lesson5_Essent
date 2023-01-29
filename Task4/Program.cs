//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Потрібно: Створити клас Article, що містить наступні закриті поля:
//• Назва товару;
//• назва магазину, в якому продається товар;
//• вартість товару в гривнях.
//Створити клас Store, який містить закритий масив елементів типу Article.
//Забезпечити такі можливості:
//• вивід інформації про товар за номером за допомогою індексу;
//• вивід на екран інформації про товар, назва якого введено з клавіатури, якщо таких товарів немає, видати відповідне повідомлення.
//Написати програму, виведення на екран інформацію про товар.

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Article article1 = new Article ( "Pen", "ATB", 5 );
            Article article2 = new Article("Pencil", "Varus", 2);
            Store store = new Store(new Article[] { article1, article2 });
            store[1].Display();
            Console.WriteLine("------------------------");
            Console.Write("Enter item name -> ");
            string itemName = Console.ReadLine().ToLower();
            store[itemName].Display();
        }
    }
}