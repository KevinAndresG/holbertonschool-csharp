using System;

public class Player
{
    string name = "Player";
    float maxHp = 100f;
    float hp = 100f;
    string Name
    {
        get { return name; }
        set { name = value; }
    }
    float MaxHp
    {
        get { return maxHp; }
        set { maxHp = value; }
    }
    float Hp
    {
        get { return hp; }
        set { hp = value; }
    }
    public Player(string name)
    {
        this.name = name;
    }
    public Player(string name, float maxHp)
    {
        if (name != null)
        {
            this.name = name;
        }
        if (maxHp < 0f)
        {
            maxHp = this.maxHp;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
        }
    }
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
}
