using SampleExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SExam.Homes
{
   public class AloneOld:Home
    {
        public const int NUMBERS_OF_ROOMS = 1;
        public const int ELECTRICITY_COST = 15;
       
            public AloneOld(decimal salary) : base(NUMBERS_OF_ROOMS, ELECTRICITY_COST)
            {
            this.people.Add(new Person(salary));
            }

        public AloneOld()
        {
        }
    }
    }

