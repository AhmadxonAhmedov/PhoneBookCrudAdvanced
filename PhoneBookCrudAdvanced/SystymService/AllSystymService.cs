using PhoneBookCrudAdvanced.Model;
using PhoneBookCrudAdvanced.PhoneBookService.LoggingBroker;
using PhoneBookCrudAdvanced.PhoneBookService.FileBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookCrudAdvanced.SystymService
{
    internal class AllSystymService
    {
        public void Menu()
        {
            Data data = new Data();
            UserInputData userInputData = new UserInputData(10);
            FileBroker fileBroker = new FileBroker();
            void printMune()
            {
                Console.WriteLine("1. Ro`yxatdan o`tish\n 2. Login");
                int choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Registration();
                        Console.WriteLine("1. Malumotlarni o`zgartirish\n 2. Brcha malumotlarni o`chirish\n 3. Barcha malumotlarni ko`rish");
                       
                        int choise2 = Convert.ToInt32(Console.ReadLine());

                        switch (choise2)
                        {
                            case 1:
                                Console.WriteLine("Malumotlarni o`zgartirish uchun raqam kiriting: -");
                                string phNum = Console.ReadLine();
                                Console.WriteLine("Ismingizni kiriting: -");
                                data.Name = Console.ReadLine();
                                try
                                {
                                    Console.WriteLine("Telefon raqam kiriting: -");
                                    data.PhoneNum = Console.ReadLine();
                                    Console.WriteLine("Malumotlaringizni kiriting: -");
                                    data.InfoUser = Console.ReadLine();
                                    if (!(RegexPatterns.PhoneNumberPattern(data.PhoneNum)))
                                    {

                                    }
                                    else
                                    {
                                        throw new Exeptions.IncorrectNumberExeption("Telefon raqam xato");
                                    }
                                }
                                catch (IncorrectNubmerExeption exeption)
                                {
                                    Console.WriteLine($"Xatolik - {exeption}");
                                }

                                userInputData.UpdateDate(phNum, data);
                                break;
                        }
                        break;

                                case 2:
                                Login();
                                break;
                        
                        void Registration()
                        {
                            Console.WriteLine("Malumotlarni o`zgartirish uchun raqam kiriting: -");
                            string phNum = Console.ReadLine();
                            Console.WriteLine("Ismingizni kiriting: -");
                            data.Name = Console.ReadLine();
                            Console.WriteLine("Telefon raqam kiriting: -");
                            data.PhoneNum = Console.ReadLine();
                            Console.WriteLine("Malumotlaringizni kiriting: -");
                            data.InfoUser = Console.ReadLine();
                        }

                        void Login()
                        {

                        }
                }
            }
        }
    }
}
