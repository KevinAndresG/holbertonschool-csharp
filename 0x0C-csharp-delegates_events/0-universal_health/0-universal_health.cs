using System;

///<summary>Provide the player objects</summary>
public class Player
{
    ///<summary>Field to define the name.</summary>
    private string name = "Player";
    ///<summary>Field to define the maxHp.</summary>
    private float maxHp = 100f;
    ///<summary>Field to define the hp.</summary>
    private float hp = 100f;
    ///<summary>Provide the constructor with the name argument</summary>
    public Player(string name)
    {
        this.name = name;
    }
    ///<summary>Provide the empty constructor</summary>
    public Player()
    {

    }
    ///<summary>Provide the constructor with the maxHp argument</summary>
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
    ///<summary>Provide the constructor with full arguments</summary>
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
    ///<summary>Prints the health and name of the player</summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
}
