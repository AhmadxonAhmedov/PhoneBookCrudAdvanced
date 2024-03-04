using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookCrudAdvanced.PhoneBookService.FileBroker
{
    internal class FileBroker
    {
        private string _filePath = @"C:\Users\Ahmadxon\Source\Repos\PhoneBookCrudAdvanced\PhoneBookCrudAdvanced\File phonebook.txt";

        public void DeleteAllData()
        {
            using (File.Open(@"C:\Users\Ahmadxon\Source\Repos\PhoneBookCrudAdvanced\PhoneBookCrudAdvanced\File phonebook.txt", FileMode.Open))
            {
                File.WriteAllText(@"C:\Users\Ahmadxon\Source\Repos\PhoneBookCrudAdvanced\PhoneBookCrudAdvanced\File phonebook.txt", null);
            }
        }

        public void DeleteById(string phone)
        {

        }

        public void GetAllData()
        {
            using (File.Open(_filePath, FileMode.Open))
            {
                Console.Write(File.ReadAllLines(_filePath));
            }

        }

        public void GetDataById(string phone)
        {

        }
    }
}

