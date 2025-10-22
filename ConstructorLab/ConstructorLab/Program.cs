using ConstructorLab;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        int choose;
        Console.Write("" +
                "1 -> Создать людей\n" +
                "2 -> Создать дома с N этажами\n" +
                "3 -> Создать сотрудников\n" +
                "4 -> Работа с дробями\n" +
                "Ваш выбор: ");
        choose = Convert.ToInt32(Console.ReadLine());
        switch (choose)
        {

            case 1:
                string name, surname, patronymic;
                Console.Write("Введите имя: ");
                name = Console.ReadLine();
                Console.Write("Введите фамилию (необязательно) : ");
                surname = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(surname))
                {
                    Console.Write("Введите имя отчество (необязательно) : ");
                    patronymic = Console.ReadLine();
                }
                else
                {
                    patronymic = "";
                }
                Person pers1 = new Person(name, surname, patronymic);

                Console.WriteLine();

                Console.Write("Введите имя: ");
                name = Console.ReadLine();
                Console.Write("Введите фамилию (необязательно) : ");
                surname = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(surname))
                {
                    Console.Write("Введите имя отчество (необязательно) : ");
                    patronymic = Console.ReadLine();
                }
                else
                {
                    patronymic = "";
                }
                Person pers2 = new Person(name, surname, patronymic);

                Console.WriteLine();

                Console.Write("Введите имя: ");
                name = Console.ReadLine();
                Console.Write("Введите фамилию (необязательно) : ");
                surname = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(surname))
                {
                    Console.Write("Введите имя отчество (необязательно) : ");
                    patronymic = Console.ReadLine();
                }
                else
                {
                    patronymic = "";
                }
                Person pers3 = new Person(name, surname, patronymic);

                Console.WriteLine(pers1.ToString());
                Console.WriteLine(pers2.ToString());
                Console.WriteLine(pers3.ToString());
                break;

            case 2:
                int floors;
                Console.Write("Введите количество этажей в 1 доме: ");
                floors = Convert.ToInt32(Console.ReadLine());
                House house1 = new House(floors);

                Console.WriteLine();

                Console.Write("Введите количество этажей во 2 доме: ");
                floors = Convert.ToInt32(Console.ReadLine());
                House house2 = new House(floors);

                Console.WriteLine();

                Console.Write("Введите количество этажей в 3 доме: ");
                floors = Convert.ToInt32(Console.ReadLine());
                House house3 = new House(floors);

                Console.WriteLine(house1.ToString());
                Console.WriteLine(house2.ToString());
                Console.WriteLine(house3.ToString());
                break;

            case 3:
                string employeeName;
                string employeeDepartment;

                Console.Write("Введите имя 1 сотрудника (он будет начальником отдела): ");
                employeeName = Console.ReadLine();
                Console.Write("Введите отдел: ");
                employeeDepartment = Console.ReadLine();
                Employee emp1 = new Employee(employeeName, employeeDepartment, true);

                Console.WriteLine();

                Console.Write("Введите имя 2 сотрудника: ");
                employeeName = Console.ReadLine();
                Console.Write("Введите отдел: ");
                employeeDepartment = Console.ReadLine();
                Employee emp2 = new Employee(employeeName, employeeDepartment);

                Console.WriteLine();

                Console.Write("Введите имя 3 сотрудника: ");
                employeeName = Console.ReadLine();
                Console.Write("Введите отдел: ");
                employeeDepartment = Console.ReadLine();
                Employee emp3 = new Employee(employeeName, employeeDepartment);

                Console.WriteLine();
                
                Employee[] employees = new Employee[3];
                employees[0] = emp1;
                employees[1] = emp2;
                employees[2] = emp3;

                Department department = new Department(emp1, employees);
                
                Console.WriteLine(emp1.ToString());
                Console.WriteLine(emp2.ToString());
                Console.WriteLine(emp3.ToString());

                Console.WriteLine();
                
                Console.WriteLine("Все сотрудники отдела через emp2:");
                Employee[] allEmployees = emp2.GetDepartmentEmployees();                

                Console.WriteLine();
              
                Console.WriteLine("Начальник отдела через emp3: " + emp3.GetDepartmentManager().Name);

                Console.WriteLine();
               
                department.PrintAllEmployees();
                break;

            case 4:
                int numerator, denominator;

                Console.Write("Введите числитель: ");
                numerator = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите знаменатель: ");
                denominator = Convert.ToInt32(Console.ReadLine());
                while (denominator == 0)
                {
                    Console.WriteLine("Знаменатель не должен быть равен нулю. Повторите ввод.");
                    denominator = Convert.ToInt32(Console.ReadLine());
                }
                Fractions frac1 = new Fractions(numerator, denominator);

                Console.WriteLine();

                Console.Write("Введите числитель: ");
                numerator = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите знаменатель: ");
                denominator = Convert.ToInt32(Console.ReadLine());
                while (denominator == 0)
                {
                    Console.WriteLine("Знаменатель не должен быть равен нулю. Повторите ввод.");
                    denominator = Convert.ToInt32(Console.ReadLine());
                }
                Fractions frac2 = new Fractions(numerator, denominator);

                Console.WriteLine();                

                Console.WriteLine("\nВыберите операцию:");
                Console.WriteLine("1 - Сложение (+)");
                Console.WriteLine("2 - Вычитание (-)");
                Console.WriteLine("3 - Умножение (*)");
                Console.WriteLine("4 - Деление (/)");
                Console.WriteLine("5 - ((1 + 2) / 3 - 5)");
                Console.Write("Ваш выбор: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                Fractions result = null;
                string operation = "";

                switch (choice)
                {
                    case 1:
                        result = frac1.Sum(frac2).Reduce();
                        operation = " + ";
                        Console.WriteLine();
                        Console.Write(frac1.ToString() + operation + frac2.ToString() + " = " + result.ToString());
                        break;

                    case 2:
                        result = frac1.Minus(frac2).Reduce();
                        operation = " - ";
                        Console.WriteLine();
                        Console.Write(frac1.ToString() + operation + frac2.ToString() + " = " + result.ToString());
                        break;

                    case 3:
                        result = frac1.Mult(frac2).Reduce();
                        operation = " * ";
                        Console.WriteLine();
                        Console.Write(frac1.ToString() + operation + frac2.ToString() + " = " + result.ToString());
                        break;

                    case 4:
                        result = frac1.Div(frac2).Reduce();
                        operation = " / ";
                        Console.WriteLine();
                        Console.Write(frac1.ToString() + operation + frac2.ToString() + " = " + result.ToString());
                        break;

                    case 5:
                        Console.Write("Введите числитель: ");
                        numerator = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите знаменатель: ");
                        denominator = Convert.ToInt32(Console.ReadLine());
                        while (denominator == 0)
                        {
                            Console.WriteLine("Знаменатель не должен быть равен нулю. Повторите ввод.");
                            denominator = Convert.ToInt32(Console.ReadLine());
                        }
                        Fractions frac3 = new Fractions(numerator, denominator);
                        result = frac1.Sum(frac2).Div(frac3).Minus(5).Reduce();
                        Console.WriteLine();
                        Console.Write(frac1.ToString() + " + " + frac2.ToString() + " / " + frac3.ToString() + " + 5 = " + result.ToString());
                        break;

                    default:
                        Console.WriteLine("Ошибка: неправильный выбор. Введите 1, 2, 3, 4 или 5.");
                        return;
                }
                
                break;

            default:
                Console.WriteLine("Ошибка: неправильный выбор. Введите 1, 2, 3 или 4.");
                break;

        }

    }
}