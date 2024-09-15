using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //Console.WriteLine(Console.WindowWidth);
            //Console.WriteLine(Console.WindowHeight);
            
			Shape[] shapes_group =
			{
				new Square(20, 5, 2, 5),
				new Rectangle(20, 12, 2, 20, 5),
				new Triangle(20, 19, 2, 20, 5),
				new Circle(20, 24, 2, 5)
			};

			Rand rand = new Rand();

			Shape[] shapes_group_random = rand.RandGroup(shapes_group);

			for (int i = 0; i < shapes_group_random.Length; i++)
			{
				shapes_group_random[i].Info();
			}

        }
	}
}
