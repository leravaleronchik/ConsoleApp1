using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book : EducationalMaterial
    {
        private readonly int ISBN;
        public int Pages { get; }
        public bool StatusIsTrue { get; set; }// true - доступна, false - выдана

        public Book(int isbn, int pages, string name, string author) : base(name, author)//конструктор
        {
            ISBN = isbn;
            Pages = pages;
            StatusIsTrue = true; // По умолчанию книга доступна
        }
        //public Book() : this(0, "пустое значение", "пустое значение", 0)
        //{
        //}
        public override void DisplayContent()
        {
            Console.WriteLine($"Название: {Name} Автор: {Author} ISBN: {ISBN}\n");
        }
        public void take() // Метод: взять книгу
        {
            if (StatusIsTrue)
            {
                StatusIsTrue = false;
                Console.WriteLine($"Книга '{Name}' успешно выдана.");
            }
            else
            {
                Console.WriteLine($"Книга '{Name}' нет в наличии в библиотеке.");
            }
            Console.WriteLine($"Учетный номер: {ISBN} Название: {Name} Автор: {Author} Статус: {StatusIsTrue}");
            return;
        }
        public void give_away() // Метод: вернуть книгу
        {
            if (!StatusIsTrue)
            {
                StatusIsTrue = true;
                Console.WriteLine($"Книга '{Name}' возвращена в библиотеку.");
            }
            else
            {
                Console.WriteLine($"Книга '{Name}' находится в библиотеке.");
            }

            Console.WriteLine($"Учетный номер: {ISBN} Название: {Name} Автор: {Author} Статус: {StatusIsTrue}");

        }
    }
}
