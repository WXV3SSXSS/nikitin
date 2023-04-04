namespace Composite_Structure_by_WAV3SSXSS
{
	internal class ListOfParticle//скоп частиц, нада 1)заспавнить все частицы done 2)переспавнивать их от времени в разные стороны м ао, done 3) если частица упираецца в бок
								 //она идёт тогда в другой бок (чек на границы)done 4) если частица тыкаецца в частицу-корабль то становица частицей кораблём ~~
	{
		public List<Particle> ParticleList { get; set; } = new List<Particle>();
		public int N { get; set; } //колво клеток
		public double probability { get; set; }


		public ListOfParticle(int n, PictureBox p, double prob) //сразу заспавниваем лист частичками
		{
			N = n;
			probability = prob;
			Random r = new Random();
			for (int i = 0; i < N * N; i++)
			{
				if (r.NextDouble() < probability)
				{
					ParticleList.Add(new Particle(r.Next(N), r.Next(N)));
				}
			}
			//ship-particle:
			ParticleList.Add(
				new Particle
				{
					X = N / 2,
					Y = N / 2,
					IsShip = true
				});
		}

		public void MoveAll()
		{
			int i;
			if (ParticleList != null)
			{
				foreach (var item in ParticleList)
				{
					i = item.Move();
					if (i == 0) //up
					{
						if (item.Y == 0)
						{
							item.Y += 1;
						}
						else
						{
							item.Y -= 1;
						}

					}
					if (i == 1) //right
					{
						if (item.X == N)
						{
							item.X -= 1;
						}
						else
						{
							item.X += 1;
						}
					}
					if (i == 2) //bottom
					{
						if (item.Y == N)
						{
							item.Y -= 1;
						}
						else
						{
							item.Y += 1;
						}
					}
					if (i == 3) //left
					{
						if (item.X == 0)
						{
							item.X += 1;
						}
						else
						{
							item.X -= 1;
						}
					}
					if (i == 5)//its ship
					{
						//nenado move
					}
				}
			}
			CheckingForNeighbor();
		}

		public void CheckingForNeighbor()
		{
			if (ParticleList != null)
			{
				foreach (var beingTestedItem in ParticleList)
				{
					if (!beingTestedItem.IsShip)
					{
						foreach (var item in ParticleList)
						{
							if (item.IsShip)
							{
								if (beingTestedItem.X + 1 == item.X)
								{
									if (beingTestedItem.Y == item.Y)
									{
										beingTestedItem.IsShip = true;
									}
								}
								if (beingTestedItem.X - 1 == item.X)
								{
									if (beingTestedItem.Y == item.Y)
									{
										beingTestedItem.IsShip = true;
									}
								}
								if (beingTestedItem.Y + 1 == item.Y)
								{
									if (beingTestedItem.X == item.X)
									{
										beingTestedItem.IsShip = true;
									}
								}
								if (beingTestedItem.Y - 1 == item.Y)
								{
									if (beingTestedItem.X == item.X)
									{
										beingTestedItem.IsShip = true;
									}
								}
							}
						}
					}
				}
			}
		}
		/// <summary>
		/// true = all Ships
		/// </summary>
		/// <returns></returns>
		public bool CheckingIsAllShips()
		{
			bool isAllShips = true;
			if (ParticleList != null)
			{
				foreach (var item in ParticleList)
				{
					if (!item.IsShip)
					{
						isAllShips = false;
					}
				}
			}
			return isAllShips;
		}

		public bool MoveNext()
		{
			throw new NotImplementedException();
		}

		public void Reset()
		{
			throw new NotImplementedException();
		}
	}
}
