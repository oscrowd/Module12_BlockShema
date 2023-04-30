using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12_BlockShema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var phoneBook = new List<User>();
            string inputName = null;
            bool alreadyExists = false;

            // добавляем контакты
            phoneBook.Add(new User("Andr","Игорь", true));
            phoneBook.Add(new User("Igor" ,"Андрей", false));
            phoneBook.Add(new User("Ivan", "Иван", false));

            Console.WriteLine("Введите свое имя:");
            inputName = Console.ReadLine();
            Console.WriteLine("Добро пожаловать {0}", inputName);
            // пробегаемся по списку и смотрим, есть ли уже с таким именем
            foreach (var contact in phoneBook)
            {
                if (contact.Name == inputName)
                {
                    alreadyExists = true;
                    break;
                }
            }
            if (!alreadyExists) 
            {
                User.ShowAds();
            }
            Console.ReadLine();
        }
    }
}
