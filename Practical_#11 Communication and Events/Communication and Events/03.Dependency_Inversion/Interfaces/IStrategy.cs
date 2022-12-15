using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Inversion.Interfaces
{
    public interface IStrategy
    {
        int Calculate(int firstOperand, int secondOperand);
    }
}
