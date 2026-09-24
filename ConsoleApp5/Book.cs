using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal record Book(string Title, string Author, int Pages)
    {
        public double Price { get; set; }
        public void UpdatePrice(int percent)
        {
            Price *= (percent / 100) / 100;
        }
        public double GetPrice3() 
        { 
            return Price * 3; 
        }
    }
}
