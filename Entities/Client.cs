using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() { }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" " + BirthDate);
            sb.Append(" - " + Email);

            return sb.ToString();
        }
    }
}
