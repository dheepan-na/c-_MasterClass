using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public Customer() { }

        public Customer(string name)=> this.Name = name;

        public Customer(string name, string address, int phoneNumber = 790422)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }



        public void SetDetails(string name, string address = "NA", int phoneNumber=790422)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        public void SetName(string name) => this.Name = name;

        public string GetAddress() => this.Address;
    }
}
