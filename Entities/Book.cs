using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTP1.Entities
{
    public class Book
    {
        private long id;
        private string name;
        private long nb_page;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public long Nb_page { get => nb_page; set => nb_page = value; }
    }
}
