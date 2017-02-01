using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Calc.Common;
using Microsoft.Practices.Unity;

namespace CalculatorModule
{
    public class Module : IModule
    {
        IRegionManager _regionManager;
        public Module(IRegionManager manager)
        {
            _regionManager = manager;
        }
        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(RegionName.DisplayRegion, typeof(Views.Display));
            _regionManager.RegisterViewWithRegion(RegionName.KeyboardRegion, typeof(Views.Keyboard));
        }
    }
}
