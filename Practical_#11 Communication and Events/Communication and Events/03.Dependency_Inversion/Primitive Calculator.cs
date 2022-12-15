using System;
using System.Collections.Generic;
using System.Text;
using Dependency_Inversion.Interfaces;
using Dependency_Inversion.Operations;
namespace Dependency_Inversion
{
    public class Primitive_Calculator : ICalculator
    {
        IStrategy calcOperation;

        public Primitive_Calculator() : this(new Addition())
        {
            
        }

        public Primitive_Calculator(IStrategy strategy) 
        {
            this.calcOperation = strategy;
        }

        public void ChangeStrategy(IStrategy strategy)
        {
            this.calcOperation = strategy;
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
           return this.calcOperation.Calculate(firstOperand, secondOperand);
        }
    }
}
