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
			Shape[] shapes_group =
			{
				new Square(150, 150, 5, 20),
				new Rectangle(150, 250, 5, 20, 10),
				new Triangle(150, 350, 5, 20, 10),
				new Circle(150, 450, 5, 20)
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
