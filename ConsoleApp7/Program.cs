//Задача 1: Фильтрация списка
//Создайте класс Person с полями Name (строка) и Age(целое число).
//Создайте список объектов класса Person.
//Используя лямбда-выражения, отфильтруйте список и получите только те объекты Person,
//у которых возраст больше 25.
//Выведите результаты фильтрации на экран.

//Задача 2: Сортировка списка
//Используя созданный ранее список объектов класса Person, отсортируйте его
//по возрасту, начиная с самого молодого.
//Выведите отсортированный список на экран.

//Задача 3: Вычисление среднего возраста
//Используя созданный ранее список объектов класса Person, вычислите средний возраст
//всех людей в списке с использованием лямбда-выражения.
//Выведите результат на экран.

//Задача 4: Преобразование списка
//Используя созданный ранее список объектов класса Person, создайте новый список строк,
//содержащих только имена людей.
//Выведите новый список на экран.
//Эти задачи помогут вам попрактиковаться с использованием лямбда-выражений для
//фильтрации, сортировки, вычисления и преобразования списков в C#. Успехов в тренировке!

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }



}
class Program
{

    public static void Main(string[] args)
    {

        Person person = new Person()
        { Name = "Bob", Age = 21 };

        Person person1 = new Person()
        { Name = "Martin", Age = 16 };

        Person person2 = new Person()
        { Name = "Edgar", Age = 21 };

        List<Person> personList = new List<Person>();
          
          personList.Add(person);
        personList.Add(person1);
        personList.Add(person2);

        List<Person> filteresList= personList.Where(person => person.Age > 18).ToList();

        foreach(Person persona in filteresList)
        {
            Console.WriteLine($"{persona.Name} {persona.Age}");

        }
        //foreach(Person persona in personList)
        //{
        //    if(persona.Age > 18)

        //    Console.WriteLine($"{persona.Name} {persona.Age}");

        //}
       
       

       List<Person> sortList= personList.OrderBy(person => person.Age).ToList();
        foreach (Person persona in sortList)
        {
            Console.WriteLine($"{persona.Name} {persona.Age}");

        }


       double averageAge= personList.Average(p  => p.Age);

        Console.WriteLine($"{averageAge:F2}");


        List<string> nameList = personList.Select(p => p.Name).ToList();

        Console.WriteLine("\nСписок имен:");
        foreach (string name in nameList)
        {
            Console.WriteLine(name);
        }
    }

}