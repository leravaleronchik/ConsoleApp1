using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//вар 4. "Библиотечная книга": Класс `Book` с полями: ISBN, название, автор, год издания,
// статус (доступна/выдана). Методы: "взять книгу", "вернуть книгу".
// Абстрактный класс: `EducationalMaterial` (Название, Автор). Абстрактный метод: `DisplayContent()`. 
// Наследники: `Book` (Кол-во страниц, ISBN), `VideoCourse` (Длительность, Ссылка), `Article` (Журнал, Год). Реализовать в каждом `DisplayContent()` по-разному.


namespace ConsoleApp1
{
    internal abstract class EducationalMaterial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public EducationalMaterial(string name, string author)
        {
            Name = name;
            Author = author;
        }
        public abstract void DisplayContent();
    }

}
   
   
