using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmComment
    {
        public int CommentId { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
        public string OwnerName { get; set; }
        public string OwnerImageUrl { get; set; }
        public List<VmComment> SubComments { get; set; }

        public VmComment()
        {

        }

        public VmComment(TblComment comment)
        {
            SubComments = new List<VmComment>();
            CommentId = comment.CommentId;
            Body = comment.Body;
            DateCreated = comment.DateCreated ?? new DateTime(1997, 0, 0);
            OwnerName = comment.Client.Name;
            OwnerImageUrl = comment.Client.MainImage;
            foreach (TblComment i in comment.InverseParent)
                SubComments.Add(new VmComment(i));
        }
    }
}
