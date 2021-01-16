using System;
using System.Collections.Generic;
using System.Text;

namespace OrdemProdutos.Entities {
    class Client {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() {

        }
        public Client(string name, string email, DateTime birthDate) {
            Name = name;
            Email = email;
            BirthDate = birthDate;

        }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Email);
            sb.Append("Sua data de nascimento: ")
            sb.AppendLine(BirthDate.ToString());

            return sb.ToString();
        }
    }
}
