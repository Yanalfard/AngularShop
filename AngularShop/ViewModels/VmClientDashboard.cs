using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmClientDashboard
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string TellNo { get; set; }
        public string ImageUrl { get; set; }

        public VmClientDashboard()
        {
            
        }

        public VmClientDashboard(TblClient client)
        {
            UserId = client.ClientId;
            Name = client.Name;
            TellNo = client.TellNo;
            ImageUrl = client.MainImage;
        }
    }
}
