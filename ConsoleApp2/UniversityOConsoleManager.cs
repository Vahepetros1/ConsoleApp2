using System;

namespace ConsoleApp2
{
    public static class UniversityOConsoleManger
    {
        public static void UniversityInit(University university)
        {
            Console.Write("Введите название университета: ");
            university.Name = Console.ReadLine();
            Console.Write("Введите адрес университета: ");
            university.adress = Console.ReadLine();
            Console.Write("Введите назвуание факультета: ");
            string[] facultetsTemp = Console.ReadLine().Split(",");
            foreach (var item in facultetsTemp)
            {
                university.Facultets.Add(item.Trim());
            }
        }

        public static void PrintUniversityInfo(University university)
        {
            Console.WriteLine($"Университет - {university.Name}");
            Console.WriteLine($"Адрес - {university.adress}");
            Console.WriteLine($"Факультет - {university.Facultets}");
            foreach (var item in university.Facultets)
            {
                Console.WriteLine(item);
            }
        }

        public static void StudentInit(University university)
        {
            Console.Write("Введите кол-во студентов к добавлению: ");
            int quantityStudents = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < quantityStudents; i++)
            {
                Students students = new Students();
                Console.Write("ФИО студента ");
                students.FIO = (Console.ReadLine();
                Console.Write("Дата рождения студента ");
                students.Birthday = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Выберите факультет и введите его порядочный номер: ");
                int counter = 1;
                foreach (var item in university.Facultets)
                {
                    Console.WriteLine(counter + "."+item);
                    counter++;
                }

                students.Facultet = university.Facultets(Convert.ToInt32(Console.ReadLine()) - 1);
                Console.Write("Группа студента");
                students.Group = Console.ReadLine();
                university.Students.Add(students);



            }
        }
        
        
        
        
        
        
        
    }
}