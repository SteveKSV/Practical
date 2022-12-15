using System;
using System.Collections.Generic;
using System.Text;
using _02.King_s_Gambit;
namespace _02_King_s_Gambit.Soldiers
{
    public class King : IName
    {
        public King()
        {

        }
        public King(string n)
        {
            this.Name = n;
        }

        public string Name { get; set; }
        public event EventHandler UnderAttack;
       public void OnUnderAttack()
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            UnderAttack?.Invoke(this, new EventArgs());
        }
    }
}
