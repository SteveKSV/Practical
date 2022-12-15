using System;
using System.Collections.Generic;
using System.Text;
using Dependency_Inversion.Interfaces;
using Dependency_Inversion.Operations;
namespace Dependency_Inversion
{
    public delegate void OperationHandler(int res);
    public class Engine
    {
        ICalculator calculator;
        IDictionary<char, IStrategy> symbolicStrategyMapper;
        public event OperationHandler Operation;

        public Engine(ICalculator calculator)
            : this(calculator, new Dictionary<char, IStrategy>())
        {
            this.SetDefaultSymbolicStrategyMapper();
        }

        public Engine(ICalculator calculator, IDictionary<char, IStrategy> symbolicStrategyMapper)
        {
            this.calculator = calculator;
            this.symbolicStrategyMapper = symbolicStrategyMapper;
        }

        public void ExecuteCommand()
        {
            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command[0].Equals("mode", StringComparison.OrdinalIgnoreCase))
                {
                    var newStrategy = this.symbolicStrategyMapper[command[1][0]];
                    this.calculator.ChangeStrategy(newStrategy);
                }
                else
                {
                    int firstOperand = int.Parse(command[0]);
                    int secondOperand = int.Parse(command[1]);
                    var result = this.calculator.PerformCalculation(firstOperand, secondOperand);
                    Operation?.Invoke(result);
                }
                command = Console.ReadLine().Split();
            }
        }
        public void Run()
        {
            ExecuteCommand();
        }
        private void SetDefaultSymbolicStrategyMapper()
        {
            this.symbolicStrategyMapper['+'] = new Addition();
            this.symbolicStrategyMapper['-'] = new Substraction();
            this.symbolicStrategyMapper['*'] = new Multiplication();
            this.symbolicStrategyMapper['/'] = new Division();
        }
    }
}
