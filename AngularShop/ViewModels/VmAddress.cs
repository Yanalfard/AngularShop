using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmAddress
    {
        public int AddressId { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }

        public VmAddress()
        {

        }

        public VmAddress(TblAddress address)
        {
            AddressId = address.AddressId;
            Address = $"{address.Province}- {address.City}- {address.Address}";
            PostalCode = address.PostalCode;
        }
    }
}
