using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MediaLibrary<T> where T : EducationalMaterial
    {
        private List<T> _items = new List<T>();

        // Статический член: счетчик для автогенерации ID
        private static int _idCounter = 1;

        public void AddItem(T item)
        {
            // Присвоение ID через статический счетчик
            item.Id = _idCounter++;
            _items.Add(item);
        }

        public List<T> FindByAuthor(string author)
        {
            return _items.Where(x => x.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void ProcessMaterial(T material)
        {
            // Неявное приведение (Implicit): T к базовому типу EducationalMaterial
            EducationalMaterial baseMat = material;

            // Явное приведение (Explicit): к конкретному типу для проверки
            if (material is Book)
            {
                Book b = (Book)(object)material;
                Console.WriteLine($"--> Обработка книги {b.ISBN} завершена.");
            }
        }

        public static void PrintFormattedCatalog<T>(this MediaLibrary<T> library) where T : EducationalMaterial
        {
            Console.WriteLine("\n--- ТЕКУЩИЙ КАТАЛОГ МЕДИАТЕКИ ---");
            foreach (var item in library.GetAll())
            {
                item.DisplayContent();
            }
            Console.WriteLine("---------------------------------\n");
        }

        public List<T> GetAll() => _items;
    }
}
