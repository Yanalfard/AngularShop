using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularShop.ViewModels
{
    public class VmFooter
    {
        public string Description { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string TellNo { get; set; }
        public string InstagramLink { get; set; }
        public string YoutubeLink { get; set; }
        public string GooglePlusLink { get; set; }
        public string TwitterLink { get; set; }
        public string FacebookLink { get; set; }

        public VmFooter()
        {
            
        }

        public VmFooter(string description, string address, string email, string tellNo, string instagramLink, string youtubeLink, string googlePlusLink, string tweeterLink, string facebookLink)
        {
            Description = description;
            Address = address;
            Email = email;
            TellNo = tellNo;
            InstagramLink = instagramLink;
            YoutubeLink = youtubeLink;
            GooglePlusLink = googlePlusLink;
            TwitterLink= tweeterLink;
            FacebookLink = facebookLink;
        }
    }
}
