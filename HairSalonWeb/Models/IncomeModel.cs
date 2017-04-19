using System.Collections.Generic;
using HairSalonWeb.DataBase;

namespace HairSalonWeb.Models
{
    public class IncomeModel
    {
        public IEnumerable<IncomeMaterialHead> Head { get; set; }
        public IEnumerable<IncomeMaterialBody> Body { get; set; }
    }
}