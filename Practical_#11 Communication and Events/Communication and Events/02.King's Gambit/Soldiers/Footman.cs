using System;
using System.Collections.Generic;
using System.Text;

namespace _02_King_s_Gambit.Soldiers
{
    public class Footman : Soldier
    {
        public Footman(string n) : base(n)
        {
            this.Name = n;
        }

        public override void KingUnderAttack(object sender, EventArgs e)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
