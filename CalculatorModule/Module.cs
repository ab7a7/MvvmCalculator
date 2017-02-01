using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CalculatorModule
{
    class Module : IModule
    {
        public void Initialize()
        {
            MessageBox.Show("Hello World From Module");
        }
    }
}
