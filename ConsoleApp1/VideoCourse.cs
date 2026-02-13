using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class VideoCourse : EducationalMaterial
    {
        public int Time { get; set; }
        public string Link { get; }


        public VideoCourse(string name, string author, int time, string link) : base(name, author)
        {
            Time = time;
            Link = link;
        }
        public override void DisplayContent()
        {
            Console.WriteLine($"Название: {Name} Автор: {Author} Длительность: {Time} Ссылка: {Link}\n");
        }
    }
}
