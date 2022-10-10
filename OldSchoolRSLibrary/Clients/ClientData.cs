using OldSchoolRSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldSchoolRSLibrary.Clients
{
    public class ClientData : IClientData
    {
        public GEClientData GEClientData
        {
            get
            {
                return new GEClientData()
                {
                    BaseAddress = "https://services.runescape.com/m=itemdb_oldschool/api/catalogue/items.json?",
                    ItemsAddress = "category=1&alpha={alpha}&page={page}"
                };
            }
        }
    }
}
