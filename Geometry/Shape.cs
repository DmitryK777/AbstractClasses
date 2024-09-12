using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	internal class Shape
	{
		// Properties
		public int Start_x
		{
			get { return Start_x; }
			set 
			{
				if (value > 800) Start_x = 800;
				else if (100 <= value && value <= 800) Start_x = value;
				else Start_x = 100; 
			}
		}

		public int Start_y
		{ 
			get => Start_y;
			set
			{
				if (value > 600) Start_y = 600;
				else if (100 <= value && value <= 600) Start_y = value;
				else Start_y = 100;
			}
		}

		public int Line_width
		{
			get => Line_width;
			set
			{
				if (value > 33) Line_width = 33;
				else if (3 <= value && value <= 33) Line_width = value;
				else Line_width = 3;
			}
		}

		// Constructors
		public Shape(int start_x, int start_y, int line_width)
		{
			Start_x = start_x;
			Start_y = start_y;
			Line_width = line_width;
		}

		// Methods
		public virtual double Get_area() { return 0.0; }
		public virtual double Get_perimiter() { return 0; }
		public virtual void Draw() {}
		public virtual void Info()
		{
			Console.WriteLine($"Площадь: {Get_area()}\n");
			Console.WriteLine($"Периметр: {Get_perimiter()}\n");
			Draw();
		}
	}
}
