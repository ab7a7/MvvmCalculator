using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorModule.ViewModels
{
    public class DisplayViewModel
    {
        public int Total { get; set; }

        public DisplayViewModel()
        {
            Total = 0;
        }

        public void Add(int nextNumber)
        {
            Total += nextNumber;
        }

        public void Subtract(int nextNumber)
        {
            Total -= nextNumber;
        }
    }
}
