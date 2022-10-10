using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OldSchoolRSLibrary.Interfaces;

namespace OldSchoolRSLibrary
{
    public class Test : ITest
    {
        public string RunMe(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
