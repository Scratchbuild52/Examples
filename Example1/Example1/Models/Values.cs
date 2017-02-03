using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example1.Models
{
    public class Value
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime DateCreated { get; set; }

        public Value GetValue()
        {
            return new Value() { Amount = 10.2, DateCreated = DateTime.Now, Name = "Test" };
        }
    }
}