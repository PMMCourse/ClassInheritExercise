using System;

public interface ICampesino
{
    int hp;
    int mana;
    int exp;
	public ICampesino( int hp,int mana,int exp)
	{
        this.hp = hp;
        this.mana = mana;
        this.exp = exp;
	}
}
public class Mago : ICampesino
{
    public Mago(int hp, int mana, int exp) : base(hp, mana, exp){
        hp = hp;
        mana = mana+100;
        exp = exp;
    }

}
public class Guerrero : ICampesino
{
    public Guerrero(int hp, int mana, int exp) : base(hp, mana, exp)
    {
        hp = hp+100;
        mana = mana;
        exp = exp;
    }
}
