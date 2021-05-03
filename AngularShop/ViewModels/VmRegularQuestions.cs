using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace AngularShop.ViewModels
{
    public class VmRegularQuestions
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public VmRegularQuestions()
        {
            
        }

        public VmRegularQuestions(TblRegularQuestion reg)
        {
            Question = reg.Question;
            Answer = reg.Answer;
        }
    }
}
