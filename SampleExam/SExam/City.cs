using SExam.Homes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SExam
{
   public class City
    {
        private List<Home> homes;
        public City()
        {
            this.homes = new List<Home>();
        }
        public void addHome(Home home)
        {
            this.homes.Add(home);
        }
        public int getPopulation()
        {
            int res = 0;
            foreach (var pop in homes )
            {
                res += pop.population();
            }
            return res;
        }

        public decimal getConsumption()
        {
            decimal result = 0;
            foreach (var item in homes)
            {
                result += item.getConsumpion();
            }
            return result;
        }

        public void payBills()
        {
            for (int i = homes.Count-1; i >=0; i--)
            {
                if (!homes[i].canPayBills())
                {
                    homes.Remove(homes[i]);
                }
            }
        }
        public void receiveSalary()
        {
            this.homes.ForEach(homes => homes.getSalary());
        }

      
    }
}
