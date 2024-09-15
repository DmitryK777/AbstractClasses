using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	internal class Circle : Shape
	{
		int radius;
		public int Radius
		{
			get => radius;
			set {radius = (value > 0) ? value : 0; }
		}
		public Circle(int start_x, int start_y, int line_width, int radius
			) : base(start_x, start_y, line_width)
		{
			Radius = radius;
		}

		public override double Get_area() { return Math.Pow((Math.PI * Radius), 2); }
		public override double Get_perimiter() { return 2 * (Math.PI * Radius); }
		public override void Draw()
		{
			Bitmap bitmap = new Bitmap(120, 30, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
			Graphics graphics = Graphics.FromImage(bitmap);
			Pen pen = new Pen(System.Drawing.Color.FromArgb(0, 77, 77, 77), 5);
			graphics.DrawEllipse(pen, Start_x, Start_y, Radius, Radius);
		}
		public override void Info()
		{
			Console.WriteLine($"{base.ToString().Split('.').Last()}");
			Console.WriteLine($"Радиус: {Radius}");
			Console.WriteLine($"Площадь: {Get_area()}");
			Console.WriteLine($"Периметр: {Get_perimiter()}");
			Draw();
            Console.WriteLine();
        }
	}
}
