using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorLab
{
    internal class Person
    {
        private string name;
        private string surname;
        private string patronymic;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Ошибка имени, оно не может быть пустым");
                    name = "Aboba";
                }
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (value != null)
                {
                    surname = value;
                }
                else
                {
                    surname = "";
                }
            }
        }
        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                if (value != null)
                {
                    patronymic = value;
                }
                else
                {
                    patronymic = "";
                }
            }
        }

        public Person(string name, string surname, string patronymic)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
        } 
        
        public override string ToString()
        {
            return (name + " " + surname + " " + patronymic).Replace("  ", " ");
        }
    }
}
