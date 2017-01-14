using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor
{
    public class RepositioryFilter
    {
        public  void FilterAndTake(Dictionary<string, double> studentsWithMarks, string wantedFilter, int studentsToTake)
        {
            if (wantedFilter == "excellent")
            {
                this.FilterAndTake(studentsWithMarks, x=>x>=5, studentsToTake);
            }
            else if (wantedFilter == "average")
            {
                this.FilterAndTake(studentsWithMarks, x => x < 5 && x >= 3.5, studentsToTake);
            }
            else if (wantedFilter == "poor")
            {
               this.FilterAndTake(studentsWithMarks, x => x < 3.5, studentsToTake);
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidStudentsFilter);
            }
        }

        private  void FilterAndTake(Dictionary<string, double> studentsWithMarks, Predicate<double> givenFilter, int studentsToTake)
        {
            int counterForPrinted = 0;
            foreach (var studentMark in studentsWithMarks)
            {
                if (counterForPrinted == studentsToTake)
                {
                    break;
                }

                //double averageScore = userName_Points.Value.Average();
              //  double percentageOfFullfilment = averageScore / 100;
              //  double mark = percentageOfFullfilment * 4 + 2;
            
                if (givenFilter(studentMark.Value))
                {
                    OutputWriter.PrintStudent(new KeyValuePair<string, double>(studentMark.Key,studentMark.Value));     
                    counterForPrinted++;
                }
            }
        }              
    }
}
