using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTP1.Entities
{
   public class Author
    {
        private long id;
        private string firstname;
        private string lastname;

        public long Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
    }
}
