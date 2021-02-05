using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTP1.Entities
{
    public class BookShop
    {
        private long id;
        private string name;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
