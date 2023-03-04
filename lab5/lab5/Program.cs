using System;

namespace StudentsNamespace
{
    class Student
    {
        public string name;
        public int groupNumber;
        private int age;

        public Student(string name, int groupNumber, int age)
        {
            this.name = name;
            this.groupNumber = groupNumber;
            this.age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Студент {0}, группа {1}, возраст {2}", name, groupNumber, age);
        }
    }
}
namespace ReadersNamespace
{
    class Reader
    {
        private string fullName;
        public int ticketNumber;
        public string faculty;
        private DateTime birthDate;
        public string phoneNumber;

        public Reader(string fullName, int ticketNumber, string faculty, DateTime birthDate, string phoneNumber)
        {
            this.fullName = fullName;
            this.ticketNumber = ticketNumber;
            this.faculty = faculty;
            this.birthDate = birthDate;
            this.phoneNumber = phoneNumber;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Читатель {0}, номер билета {1}, факультет {2}, дата рождения {3}, телефон {4}", fullName, ticketNumber, faculty, birthDate.ToShortDateString(), phoneNumber);
        }

        public void TakeBook(int bookCount)
        {
            Console.WriteLine("{0} взял {1} книги", fullName, bookCount);
        }

        public void TakeBook(params string[] books)
        {
            Console.WriteLine("{0} взял книги: {1}", fullName, string.Join(", ", books));
        }

        public void ReturnBook(int bookCount)
        {
            Console.WriteLine("{0} вернул {1} книги", fullName, bookCount);
        }

        public void ReturnBook(params string[] books)
        {
            Console.WriteLine("{0} вернул книги: {1}", fullName, string.Join(", ", books));
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        StudentsNamespace.Student[] students = new StudentsNamespace.Student[3];
        students[0] = new StudentsNamespace.Student("Иванов И.И.", 101, 20);
        students[1] = new StudentsNamespace.Student("Петров П.П.", 102, 21);
        students[2] = new StudentsNamespace.Student("Сидоров С.С.", 103, 19);

        ReadersNamespace.Reader[] readers = new ReadersNamespace.Reader[3];
        readers[0] = new ReadersNamespace.Reader("Иванов И.И.", 1001, "Исторический", new DateTime(1990, 1, 1), "123-45-67");
        readers[1] = new ReadersNamespace.Reader("Петров П.П.", 1002, "Филологический", new DateTime(1995, 2, 2), "234-56-78");
        readers[2] = new ReadersNamespace.Reader("Сидоров С.С.", 1003, "Юридический", new DateTime(2000, 3, 3), "345-67-89");

        foreach (var student in students)
        {
            student.PrintInfo();
        }

        foreach (var reader in readers)
        {
            reader.PrintInfo();
        }
        readers[0].TakeBook(3);
        readers[1].TakeBook("Приключения", "Словарь", "Энциклопедия");
        readers[2].TakeBook("Математический анализ", "Алгебра", "Дискретная математика");
        readers[0].ReturnBook(2);
        readers[1].ReturnBook("Приключения", "Словарь");
        readers[2].ReturnBook("Математический анализ", "Алгебра", "Дискретная математика");

        Console.ReadKey();
    }
}