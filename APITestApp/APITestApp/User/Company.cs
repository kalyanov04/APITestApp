using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp.User
{
    public class Company
    {
        string name;
        string catchPhrase;
        string bs;

        public Company(string name, string catchPhrase, string bs)
        {
            this.name = name;
            this.catchPhrase = catchPhrase;
            this.bs = bs;
        }
    }
}
