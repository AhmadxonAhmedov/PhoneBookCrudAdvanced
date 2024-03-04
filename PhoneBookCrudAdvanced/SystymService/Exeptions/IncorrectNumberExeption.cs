using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookCrudAdvanced.SystymService.Exeptions
{
    internal class IncorrectNumberExeption : Exception
    {
        public IncorrectNumberExeption() { }
        public IncorrectNumberExeption(string message) : base(message) { }
    }
}
