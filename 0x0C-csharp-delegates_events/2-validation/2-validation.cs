using System;

/// <summary>Provide the player objects</summary>
public class Player
{
    /// <summary>Field to define the name.</summary>
    private string name = "Player";
    /// <summary>Field to define the maxHp.</summary>
    private float maxHp = 100f;
    /// <summary>Field to define the hp.</summary>
    private float hp = 100f;
    /// <summary>Provide the constructor with the name argument</summary>
    public Player(string name)
    {
        this.name = name;
    }
    /// <summary>Provide the empty constructor</summary>
    public Player()
    {
    }
    /// <summary>Provide the constructor with the maxHp argument</summary>
    public Player(float maxHp)
    {
        if (maxHp < 0f)
        {
            maxHp = this.maxHp;
            this.hp = this.maxHp;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
        }
    }
    /// <summary>Provide the constructor with full arguments</summary>
    public Player(string name, float maxHp)
    {
        if (maxHp < 0f)
        {
            maxHp = this.maxHp;
            this.hp = this.maxHp;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
        }
        this.name = name;
    }
    /// <summary>Prints the health and name of the player</summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
    /// <summary>create a delegate</summary>
    public delegate void CalculateHealth(float amount);
    ///<summary>substract the damage of the hp</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine("{0} takes 0 damage!", this.name);
        }
        else
        {
            float newHp = this.hp - damage;
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
            ValidateHP(newHp);
        }
    }
    /// <summary>add the heal to the hp</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine("{0} heals 0 HP!", this.name);
        }
        else
        {
            float newHp = this.hp + heal;
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
            ValidateHP(newHp);
        }
    }
    /// <summary>add the heal to the hp</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        if (newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }
}
