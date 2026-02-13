using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Article : EducationalMaterial
    {
        public string Log { get; }
        public string Year { get; }

        public Article(string name, string author, string log, string year) : base(name, author)
        {
            Log = log;
            Year = year;
        }
        public override void DisplayContent()
        {
            Console.WriteLine($"Название: {Name} Автор: {Author} Журнал: {Log} Год: {Year}\n");
        }
    }
}
