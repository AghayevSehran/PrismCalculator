using Prism.Commands;
using PrismCalculator.Core;
using PrismCalculator.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismCalculator.ViewModels
{
    class ShellViewModel:ViewModelBase
    {
        public ShellViewModel(ICalculator calculator)
        {
            _calculator = calculator;
        }
        bool hasCalulated = false;
        public string Title { get; set; } = "Calculator";

        private string _calculatorText;
        private readonly ICalculator _calculator;

        public string Expression
        {
            get => _calculatorText;
            set
            {
                SetProperty(ref _calculatorText, value);
            }
        }

        public DelegateCommand<string> AddNumberCommand { get; set; }

        public DelegateCommand ClearCommand { get; set; }

        public DelegateCommand EqualsCommand { get; set; }

        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<string>(Addnuber);
            ClearCommand = new DelegateCommand(Clear);
            EqualsCommand = new DelegateCommand(Calculate);
        }

        private void Calculate()
        {
            Expression = _calculator.Calculate(Expression).ToString("N2");
            hasCalulated = true;
        }

        private void Clear()
        {
            Expression = string.Empty;
        }

        private void Addnuber(string buttonText)
        {
            if (hasCalulated)
            {
                Clear();
                hasCalulated = false;
            }
           Expression += buttonText;
        }
    }
}
