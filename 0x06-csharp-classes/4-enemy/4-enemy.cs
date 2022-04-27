using System;

namespace Enemies
{
	///<summary>Provides a zombie definition.</summary>
	public class Zombie
	{
		///<summary>Field to define the health.</summary>
		public int health;
		///<summary>Field to define the name.</summary>
		private string name = "(No name)";
		///<summary>get and set the values.</summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		///<summary>set zombie's health in 0.</summary>
		public Zombie()
		{
			this.health = 0;
		}
		///<summary>Check if valie is greater than 0.</summary>
		public Zombie(int value)
		{
			if (value < 0)
			{
				throw new ArgumentException("Health must be greater than or equal to 0");
			}
			this.health = value;
		}
		///<Returns>the value of health of the Zombie object.</Returns>
		public int GetHealth()
		{
			return health;
		}
	}
}
