namespace Анкета
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, как вас зовут?");
            string name = (Console.ReadLine());
            Console.WriteLine("Сколько вам лет?");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваша дата рождения?");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Вас зовут {0}, вам {1} лет, вы родились {2},", name, age, birthdate);

            Console.ReadKey();


        }
    }
}