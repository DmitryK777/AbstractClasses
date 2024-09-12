using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	internal class Triangle : Rectangle
	{
		public Triangle(int start_x, int start_y, int line_width, int width,
			int height
			) : base(start_x, start_y, line_width, width, height) { }

		public override double Get_area() { return (Width * Height)/2; }
		public override double Get_perimiter() 
		{
			double Hipotenuze = Math.Sqrt(Math.Pow((Width / 2), 2) + Math.Pow(Height, 2));
			return (Width + 2 * Hipotenuze); 
		}
		public override void Draw()
		{
			Bitmap bitmap = new Bitmap(850, 650, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
			Graphics graphics = Graphics.FromImage(bitmap);
			Pen pen = new Pen(System.Drawing.Color.FromArgb(0, 77, 77, 77), Line_width);
			graphics.DrawPolygon(pen, 
				new[] { 
					new Point(Start_x, Start_y),
					new Point(Start_x + Width, Start_y),
					new Point(Start_x + (Width / 2), Start_y + Height),
					new Point(Start_x, Start_y)
				});
		}
		public override void Info()
		{
			Console.WriteLine($"{base.ToString().Split('.').Last()}");
			Console.WriteLine($"Ширина: {Width}");
			Console.WriteLine($"Высота: {Height}");
			base.Info();
		}
	}
}
