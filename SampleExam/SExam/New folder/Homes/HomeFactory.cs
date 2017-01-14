using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SExam.Item;
using SampleExam;

namespace SExam.Homes
{
    public class HomeFactory
    {
        public  Home createHome(String type, List<String> homeArguments, List<Child> children)
        
            {
                Home home = null;
            switch (type)
            {
                case "YoungCouple":
                    home = new YoungCouple(
                           decimal.Parse(homeArguments[0]),
                            decimal.Parse(homeArguments[1]),
                            decimal.Parse(homeArguments[2]),
                            decimal.Parse(homeArguments[3]),
                             decimal.Parse(homeArguments[4]));
                    break;
                case "YoungCoupleWithChildren":
                    home = new YoungCoupleWithChildren(
                           decimal.Parse(homeArguments[0]),
                            decimal.Parse(homeArguments[1]),
                            decimal.Parse(homeArguments[2]),
                            decimal.Parse(homeArguments[3]),
                             decimal.Parse(homeArguments[4]),
                    children);
                    break;
                case "AloneYoung":
                    home = new AloneYoung(
                           decimal.Parse(homeArguments[0]),
                            decimal.Parse(homeArguments[1]));
                    break;
                case "OldCouple":
                    home = new OldCouple(
                           decimal.Parse(homeArguments[0]),
                            decimal.Parse(homeArguments[1]),
                            decimal.Parse(homeArguments[2]),
                            decimal.Parse(homeArguments[3]),
                             decimal.Parse(homeArguments[4]));
                    break;
                case "AloneOld":
                    home = new AloneOld(
                            decimal.Parse(homeArguments[0]));
                    break;
            }
            return home;
        }
    }
}
