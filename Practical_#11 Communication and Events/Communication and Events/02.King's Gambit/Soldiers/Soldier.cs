using System;
using System.Collections.Generic;
using System.Text;
using _02.King_s_Gambit;
namespace _02_King_s_Gambit.Soldiers
{
    public abstract class Soldier : IName
    {
        public Soldier(string n)
        {
            Name = n;
        }
        public string Name { get; set; }
        public abstract void KingUnderAttack(object sender, EventArgs e);
    }
}
