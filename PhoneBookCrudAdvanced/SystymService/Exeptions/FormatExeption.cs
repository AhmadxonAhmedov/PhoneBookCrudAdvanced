using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookCrudAdvanced.SystymService.Exeptions
{
    internal class FormatExeption: Exception
    {
        public FormatExeption() { }
        public FormatExeption(string message) : base(message) { }
    }
}
