using SampleExam;
using SExam.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SExam.Homes
{
    public abstract class Home
    {
        private decimal bills;
        private decimal salaries;
        private decimal budget;
        private int numberOfRooms;
        private decimal electricityCost;
        protected List<Child> children;
        protected List<Person> people;
        protected List<Device> devices;
        public Home()
        {

        }
        public Home(int numberOfRooms, int electricityCost)
        {
            this.numberOfRooms = numberOfRooms;
            this.electricityCost = electricityCost;
            this.Bills = 0;
            this.Budget = 0;
            this.Salaries = 0;
            this.devices = new List<Device>();
            this.children = new List<Child>();
            this.people = new List<Person>();
        }
        public decimal Budget
        {
            get
            {
                return this.budget;
            }
            private set
            {
                this.budget = value;
            }
        }
        public decimal Bills
        {
            get
            {
                return this.bills;
            }
            private set
            {
                this.bills = value;
            }
        }
        public decimal Salaries
        {
            get
            {
                return this.salaries;
            }
            private set
            {
                this.salaries = value;
            }
        }

        public List<Device> Devices { get; private set; }
        // public List<Child> Children { get; private set; }
        public int population()
        {
            var res= this.people.Count() + this.children.Count();
            return res;
        }

        public void getSalary()
        {
            this.budget += salaries;
        }
        public void calcSalaries()
        {
            foreach (var sal in people)
            {
                this.salaries += sal.Salary;
            }
        }

        public bool canPayBills()
        {
            if (this.getConsumpion()<=this.budget)
            {
                this.budget -= this.getConsumpion();
                return true;
            }
            return false;
        }
        public decimal getConsumpion()
        {
            return this.bills;
        }

        public void totalBills()
        {
            decimal bills = 0;
            foreach (var item in devices)
            {
                bills += item.DeviceCost;
            }
            foreach (var ch in children)
            {
                bills += ch.FoodCost;
                bills += ch.calculateToyPrice();
            }
            bills += this.numberOfRooms * this.electricityCost;
            this.bills = bills;
        }
    }
}