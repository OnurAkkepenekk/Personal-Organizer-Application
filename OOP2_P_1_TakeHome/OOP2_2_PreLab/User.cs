using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;

namespace OOP2_2_PreLab
{
    public class User
    {
        private string username;
        private string accoundPassword;
        private bool rememberMe;
        private string usertypes;
        private string name;
        private string surname;
        private string phoneNumber;
        private string address;
        private string email;
        private string photo;
        private string salary;
        public User(string username, string password, bool rememberMe, string usertypes, string name, string surname, string phoneNumber, string address, string email, string photo, string salary)
        {
            this.Username = username;
            this.AccoundPassword = password;
            this.RememberMe = rememberMe;
            this.usertypes = usertypes;
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Email = email;
            this.Photo = photo;
            this.Salary = salary;
        }
        public User() { }
        public string Username { get => username; set => username = value; }
        public string AccoundPassword { get => accoundPassword; set => accoundPassword = value; }
        public bool RememberMe { get => rememberMe; set => rememberMe = value; }
        public string Usertypes { get => usertypes; set => usertypes = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Photo { get => photo; set => photo = value; }
        public string Salary { get => salary; set => salary = value; }
        public bool IsValid(string txtId, string txtPassword, bool rememberMe)
        {
            return this.username.Equals(txtId) && this.accoundPassword.Equals(Util.ComputeStringToSha256Hash(txtPassword));
        }
        public bool IsValid(string txtId, string txtPassword, string usertypes)
        {
            return this.username.Equals(txtId) && this.accoundPassword.Equals(Util.ComputeStringToSha256Hash(txtPassword)) && (this.usertypes.Equals(usertypes));
        }
        public string toString()
        {
            return username + "," + accoundPassword + "," + (rememberMe ? "1" : "0") + "," + usertypes + "," + name + "," + surname + "," + phoneNumber + "," + address + "," + email + "," + photo + "," + salary;
        }
        public Memento Save()
        {
            return new Memento
            {
                username = Username,
                accoundPassword = AccoundPassword,
                name = Name,
                surname = Surname,
                phoneNumber = PhoneNumber,
                address = Address,
                email = Email,
                photo = Photo
            };
        }
        public void Undo(Memento memento)
        {
            this.Username = memento.username;
            this.Name = memento.name;
            this.Surname = memento.surname;
            this.PhoneNumber = memento.phoneNumber;
            this.AccoundPassword = memento.accoundPassword;
            this.Address = memento.address;
            this.Email = memento.email;
            this.Photo = memento.photo;
        }
    }
    public class Memento
    {
        public string username { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string phoneNumber { get; set; }
        public string accoundPassword { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string photo { get; set; }
    }
    class CareTakerDatas
    {
        public Memento Memento { get; set; }
    }
}
