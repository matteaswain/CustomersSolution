using System;
using System.Collections.Generic;
using System.Text;

namespace Customers
{
    class Custy // class
    {
        private static int NextId { get; set; } = 1; // properties

        public int Id { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Sales { get; private set; }
        public bool Active { get; set; } = true;

        public void AddSales(decimal amount) // method
        {
            Sales = Sales + amount; // assignment -- parameter acts like variable 
        }

        public Custy(string Name, string City, string State) // constructor
        {
            this.Id = NextId;
            NextId++;
            this.Name = Name;
            this.City = City;
            this.State = State;    
        }
               
    }
}
