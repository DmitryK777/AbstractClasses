using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Wolf wolf = new Wolf();
			wolf.Sound();

			Chihuahua chihuahua = new Chihuahua();
			chihuahua.Sound();
		}
	}
}
