using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Organizer_Application
{
    public class Phone
    {
        private string user;
        private string name;
        private string surname;
        private string number;
        private string address;
        private string description;
        private string mail;
        public Phone(string user, string name, string surname, string number, string address, string description, string mail)
        {
            this.User = user;
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
            this.Address = address;
            this.Description = description;
            this.Mail = mail;
        }
        public string User { get => user; set => user = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Number { get => number; set => number = value; }
        public string Address { get => address; set => address = value; }
        public string Description { get => description; set => description = value; }
        public string Mail { get => mail; set => mail = value; }
        public string toString()
        {
            return user + "," + name + "," + surname + "," + number + "," + address + "," + description + "," + mail;
        }
    }
}
