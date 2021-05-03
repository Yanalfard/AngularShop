using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmPropertyBig
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public VmPropertyBig()
        {
            
        }

        public VmPropertyBig(TblProperty property)
        {
            Name = property.Name;
            Description = property.Description;
        }
    }
}
