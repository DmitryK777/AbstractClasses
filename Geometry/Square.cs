using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	internal class Square : Shape
	{
		int width;
		public int Width
		{
			get => width;
			set { width = (value > 0) ? value : 0; }
		}
		public Square(int start_x, int start_y, int line_width, int width
			) : base(start_x, start_y, line_width)
		{
			Width = width;
		}

		public override double Get_area() { return Width * Width; }
		public override double Get_perimiter() { return 2 * (Width + Width); }
		public override void Draw()
		{
			Bitmap bitmap = new Bitmap(120, 30, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
			Graphics graphics = Graphics.FromImage(bitmap);
			Pen pen = new Pen(System.Drawing.Color.FromArgb(0, 77, 77, 77), 5);
			graphics.DrawRectangle(pen, Start_x, Start_y, Width, Width);
		}
		public override void Info()
		{
			Console.WriteLine($"{base.ToString().Split('.').Last()}");
			Console.WriteLine($"Ширина: {Width}");
			Console.WriteLine($"Площадь: {Get_area()}");
			Console.WriteLine($"Периметр: {Get_perimiter()}");
			Draw();
            Console.WriteLine();
        }
	}
}
