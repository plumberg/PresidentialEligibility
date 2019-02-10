using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asgn_01_Lib
{
    public class Logic
    {
        Boolean citizen;
        Int32 resided;
        Int32 age;
        Int32 terms;
        Boolean rebelled;

        public Logic(Boolean citizen,
         Int32 resided,
         Int32 age,
         Int32 terms,
         Boolean rebelled)
        {
            this.citizen = citizen;
            this.resided = resided;
            this.age = age;
            this.terms = terms;
            this.rebelled = rebelled;
        }

        public Boolean CheckElligibility()
        {
            if (citizen == false || resided < 14
                || age < 35 || terms >= 2 || rebelled == true)
            {
                return false;
            }
            else return true;
        }
    }
}
