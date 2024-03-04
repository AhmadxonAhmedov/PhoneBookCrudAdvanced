using PhoneBookCrudAdvanced.Model;
namespace PhoneBookCrudAdvanced.PhoneBookService.LoggingBroker
{
    internal interface IUserInputData
    {
        public void Registration(Data user);
        public void Login(string phoneNumber, string data);
        public void UpdateDate(string phoneNumber, Data data);
        public void DeleteDate(string phoneNumer);
    }
}
