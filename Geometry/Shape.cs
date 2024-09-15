using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	abstract internal class Shape
	{
		int start_x;
		int start_y;
		int line_width;
		// Properties
		public int Start_x
		{
			get { return start_x; }
			set 
			{
				if (value > 120) start_x = 120;
				else if (20 <= value && value <= 120) start_x = value;
				else start_x = 20; 
			}
		}

		public int Start_y
		{ 
			get => start_y;
			set
			{
				if (value > 30) start_y = 30;
				else if (5 <= value && value <= 30) start_y = value;
				else start_y = 5;
			}
		}

		public int Line_width
		{
			get => line_width;
			set
			{
				if (value > 5) line_width = 5;
				else if (2 <= value && value <= 5) line_width = value;
				else line_width = 2;
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
		public abstract double Get_area();
		public abstract double Get_perimiter();
		public abstract void Draw();
		public virtual void Info()
		{
			Console.WriteLine($"Площадь: {Get_area()}");
			Console.WriteLine($"Периметр: {Get_perimiter()}");
			Draw();
		}
	}
}
