using System;

public abstract class Campesino
{
    public int mana{ set; get; }
    public int exp{ set; get; }
    public int hp { set; get; }
    public void UnirseParty()
    {
    }
}
public class Gremio
{
    public Gremio(Mago m1)
    {
    }
    public Gremio(Guerrero g1)
    {
    }
}

public interface Mago : Campesino
{
    public Mago(int hp, int mana, int exp) : base(hp, mana, exp){
        hp = hp;
        mana = mana+100;
        exp = exp;
    }

}
public class Sanador : Mago
{
    public int curar(Campesino c1)
    {
    }
}
public interface Guerrero : Campesino
{
    public Guerrero(int hp, int mana, int exp) : base(hp, mana, exp)
    {
        hp = hp+100;
        mana = mana;
        exp = exp;
    }
}
public class Espadachin : Guerrero
{
}
