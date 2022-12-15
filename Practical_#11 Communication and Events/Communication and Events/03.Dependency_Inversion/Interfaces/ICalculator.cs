using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Inversion.Interfaces
{
    public interface ICalculator
    {
        void ChangeStrategy(IStrategy strategy);
        int PerformCalculation(int firstOperand, int secondOperand);
    }
}
