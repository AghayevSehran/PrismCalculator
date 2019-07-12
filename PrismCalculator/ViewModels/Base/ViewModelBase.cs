﻿using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismCalculator.ViewModels.Base
{
    public abstract  class ViewModelBase:BindableBase
    {
        public ViewModelBase()
        {
            RegisterCommands();
        }
        protected virtual void RegisterCommands()
        { }
       
         
    }
}
