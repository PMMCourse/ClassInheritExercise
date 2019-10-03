using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritExercise
{
    public class Campesino
    {

        //A
        protected string nick;
        protected short hp;
        protected int exp;
        protected byte atk, def, mdef, aspd, crit;

        //C
        public Campesino()
        {
            // Por Defecto...
        }
        public Campesino(string nick, short hp, int exp, byte atk, byte def, byte mdef, byte aspd, byte crit)
        {
            this.nick = nick;
            this.hp = hp;
            this.exp = exp;
            this.atk = atk;
            this.def = def;
            this.mdef = mdef;
            this.aspd = aspd;
            this.crit = crit;
        }

        //M
        private string Nick { get => nick; set => nick = value; }
        private short Hp { get => hp; set => hp = value; }
        private int Exp { get => exp; set => exp = value; }
        private byte Atk { get => atk; set => atk = value; }
        private byte Def { get => def; set => def = value; }
        private byte Mdef { get => mdef; set => mdef = value; }
        private byte Aspd { get => aspd; set => aspd = value; }
        private byte Crit { get => crit; set => crit = value; }
        protected void Attack() { }
        protected void LeaveGuild() { }
        protected void JoinParty() { }
        protected void LeaveParty() { }
    }
}
