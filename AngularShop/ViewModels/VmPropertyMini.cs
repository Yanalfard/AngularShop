using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmPropertyMini
    {
        public string Name { get; set; }
        public string Image { get; set; }


        public VmPropertyMini()
        {

        }

        public VmPropertyMini(TblProperty property)
        {
            Name = property.Name;
            Image = property.Image;
        }
    }
}
