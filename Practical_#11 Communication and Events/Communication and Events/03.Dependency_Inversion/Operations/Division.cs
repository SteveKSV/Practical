using System;
using System.Collections.Generic;
using System.Text;
using Dependency_Inversion.Interfaces;
namespace Dependency_Inversion.Operations
{
    public class Division : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand / secondOperand;
        }
    }
}
