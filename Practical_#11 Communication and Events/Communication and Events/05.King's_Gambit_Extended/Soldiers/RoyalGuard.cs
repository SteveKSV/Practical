using System;
using System.Collections.Generic;
using System.Text;

namespace _02_King_s_Gambit.Soldiers
{
    public class RoyalGuard : Soldier
    {
        public RoyalGuard(string n) : base(n)
        {
            this.Name = n;
        }

        public override void KingUnderAttack(object sender, EventArgs e)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
