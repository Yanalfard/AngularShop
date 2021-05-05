using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmKeyword
    {
        public int KeywordId { get; set; }
        public string Name { get; set; }

        public VmKeyword()
        {
            
        }

        public VmKeyword(TblKeyword keyword)
        {
            KeywordId = keyword.KeywordId;
            Name = keyword.Name;
        }
    }
}
