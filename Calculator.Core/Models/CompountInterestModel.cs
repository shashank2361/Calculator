using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Models
{
    public class CompountInterestModel
    {
        public double PrincipleAmt { get; set; }
        public double InterestRate { get; set; }
        public int Years { get; set; }
        public int TimesPerYear { get; set; }
    }
}
