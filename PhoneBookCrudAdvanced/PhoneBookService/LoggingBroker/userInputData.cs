
using PhoneBookCrudAdvanced.Model;

namespace PhoneBookCrudAdvanced.PhoneBookService.LoggingBroker
{
    internal class UserInputData: IUserInputData
    {
        public Data[] UserInfo;
        int _number;

        public UserInputData(int number)
        { 
            _number = number;
            UserInfo = new Data[_number];
        }
        public void Registration(Data user)
        {
            string[] warp = new string[UserInfo.Length];
            for(int i =0; i < UserInfo.Length; i++)
            {
                if (UserInfo[i] is null && warp[i] is null)
                {
                UserInfo[i] = user;
                    warp[i] = UserInfo[i].ToString();
                using
                (
                File.Open(@"C:\Users\Ahmadxon\Source\Repos\PhoneBookCrudAdvanced\PhoneBookCrudAdvanced\File phonebook.txt",FileMode.Open)
                )
                {
                    File.WriteAllLines(@"C:\Users\Ahmadxon\Source\Repos\PhoneBookCrudAdvanced\PhoneBookCrudAdvanced\File phonebook.txt",warp);
                }
                break;
                }
            }     
        }

        public void Login(string phoneNumber, string data)
        {
            
        }

        public void UpdateDate(string phoneNumber, Data data)
        {
           if(data.PhoneNum == phoneNumber)
            {
                Registration(data);
            }
            
        }

        public void DeleteDate(string phoneNumer)
        {
            
        }
    }  
}
