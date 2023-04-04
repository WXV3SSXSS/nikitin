using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Structure_by_WAV3SSXSS
{
	internal class Particle //Класс частицы, она должна иметь координаты, двигаца рандомно по таймеру вверх влево вправо
		//и становица частью корабля 
	{
		public int X { get; set; }
		public int Y { get; set; }
		public bool IsShip { get; set; } = false;

		public Particle(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		public Particle()
		{
		    
		}
		/* 0 - вверх
		 * 1 - вправо
		 * 2 - вниз
		 * 3 - вверх
		 * 5 - это корабль
		 * пусть двигаются внутри листа т.к. они не знают какого размера квадратики у нас
		 */
		public int Move() 
		{
			if (!IsShip)
			{
				Random random = new Random();
				int i = random.Next(0, 4); //если 0 вверх, 1 вправо, 2 вниз, 3 влево
				return i;
			}
			return 5;
		}
	}
}
