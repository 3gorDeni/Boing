using System;

namespace ConsoleApp13
{
	
		class Program
		{
		    static void Main(string[] args)
			{

				Plane Boing = new Plane("Boing", "White", "EFA - 123", "750 km/h");
			    Boing.name("Boing");
			    Boing.color("White");
			    Boing.model("EFA - 123");
			    Boing.speed("750 km/h");
			    Boing.fly(Boing);
			    Boing.land(Boing);
			}
		}
}
