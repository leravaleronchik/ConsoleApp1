// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ConsoleApp1;

class Program
{
    static void Main()
    {
        // Создание объекта книги
        Book book1 = new Book(111, 1000, "Мастер и Маргарита", "Михаил Булгаков");
        Book book2 = new Book(222, 800, "Преступление и наказание", "Федор Достоевский");
        Book book3 = new Book(333, 900, "Анна Каренина", "Лев Толстой");

        Article article1 = new Article("Мастер и Маргарита", "Михаил Булгаков", "1", "1940");
        Article article2 = new Article("Преступление и наказание", "Федор Достоевский", "2", "1866");
        Article article3 = new Article("Анна Каренина", "Лев Толстой", "3", "1877");

        VideoCourse videoCourse1 = new VideoCourse("Мастер и Маргарита", "Михаил Булгаков", 1000, "Ссылка1");
        VideoCourse videoCourse2 = new VideoCourse("Преступление и наказание", "Федор Достоевский", 500, "Ссылка2");
        VideoCourse videoCourse3 = new VideoCourse("Анна Каренина", "Лев Толстой", 1000, "Ссылка3");

        book1.DisplayContent();
        book2.DisplayContent();
        book3.DisplayContent();
        article1.DisplayContent();
        article2.DisplayContent();
        article3.DisplayContent();
        videoCourse1.DisplayContent();
        videoCourse2.DisplayContent();
        videoCourse3.DisplayContent();


        book1.take();    // Взять 1-ю книгу
        book2.take();    // Взять 2-юкнигу
        book1.take();    // Попытаться взять снова 1-ю (тест)
        book2.take();    // Попытаться взять снова 2-ю (тест)

        book1.give_away();  // Вернуть 1-ю книгу
        book2.give_away();  // Вернуть 2-ю книгу

    }
}
