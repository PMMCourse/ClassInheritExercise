using System;

namespace ClassInheritExercise
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    //CLASE BASE --> CAMPESINO
    public class Farmer
    {
        //atributes
        private int HP, MP, EXP, LEVEL;
        private String Name;
        //get&set
        public int vHP { get => HP; set => vHP = value; }
        public int vMP { get => MP; set => vMP = value; }
        public int vEXP { get => EXP; set => vEXP = value; }
        public int vLEVEL { get => LEVEL; set => vLEVEL = value; }
        public String vName { get => Name; set => vName = value; }
        //default constructor
        public Farmer()
        {

        }
        //constructor
        public Farmer(int vHP, int vMP, int vEXP, int vLEVEL, String vName)
        {
            this.vHP = HP;
            this.vMP = MP;
            this.vEXP = EXP;
            this.vLEVEL = LEVEL;
            this.vName = Name;
        }
        //metedo para subir de nivel
        public void LevelUp(int exp)
        {
            if (EXP >= 100)
            {
                LEVEL++;
                EXP = EXP - 100;
            }
        }
        //Metodo para buscar grupo
        public void LookForParties()
        {

        }

    }
    //Clase Guerrero que hereda de Campesino
    public class Warrior : Farmer
    {
        private int shield;
        private int attack;

        public int vShield { get; set; }
        public int vAttack { get; set; }

        public Warrior(int vShield, int vAttack)
        {
            this.vShield = shield;
            this.vAttack = attack;
        }
    }

    //Clase Curandero que hereda de campesino
    public class MedicineMan : Farmer
    {
        private int cure;
        private int power;

        public int vCure { get; set; }
        public int vPower { get; set; }

        public MedicineMan(int vCure, int vPower)
        {
            this.vCure = cure;
            this.vPower = power;
        }
    }

    //Clase mago que hereda de campesino
    public class Wizzard : Farmer
    {
        private int magic;
        private int power;

        public int vMagic { get; set; }
        public int vPower { get; set; }

        public Wizzard(int vMagic, int vPower)
        {
            this.vMagic = magic;
            this.vPower = power;
        }
    }
    //Clase explorador que hereda de campesino
    public class Explorer : Farmer
    {
        private int orientation;
        private int skill;

        public int vOrientation { get; set; }
        public int vSkill { get; set; }

        public Explorer(int vOrientation, int vSkill)
        {
            this.vOrientation = orientation;
            this.vSkill = skill;
        }
    }

}
