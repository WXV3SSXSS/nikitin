namespace Composite_Structure_by_WAV3SSXSS
{
	public partial class Form1 : Form
	{
		bool isInitialised = false;
		double[,] data;
		double[,] values;

		ListOfParticle fractale;//не трогать это на новый год
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int N = Convert.ToInt32(textBoxNumers.Text);
				double probability = Convert.ToDouble(textBoxProbability.Text);//шанс что клетка будет чорной
				if (radioButtonRandom.Checked)
				{
					double[,,] gazon = GenerateRandom(N);

					ART(gazon, probability, N);
				}
				if (radioButtonPoloski.Checked)
				{
					double[,,] gazon = GenerateFractaleHorizontal(N, probability);

					ART(gazon, probability, N);
				}
				if (radioButtonPoloskiVertical.Checked)
				{
					double[,,] gazon = GenerateFractaleVertical(N, probability);

					ART(gazon, probability, N);
				}
				if (radioButtonFractale.Checked)
				{
					GenerateFractaleULTRA(N, probability);
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		public double[,,] GenerateRandom(int N)
		{
			double p = Convert.ToDouble(textBoxProbability.Text);
			double[,,] gazon = new double[N, N, N];
			Random RRR = new Random();
			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
					for (int k = 0; k < N; k++)
					{
						gazon[i, j, k] = RRR.NextDouble(); //спавним каждому члену массива число от 0 до 1
					}
				}
			}
			values = new double[N, N];
			for (int k = 0; k < N; k++)
			{
				for (int l = 0; l < N; l++)
				{
					if (gazon[k, l, 0] > p)
					{
						values[k, l] = 1;
					}
				}
			}
			return gazon;
		}
		public double[,,] GenerateFractaleHorizontal(int N, double probability)
		{
			double p = Convert.ToDouble(textBoxProbability.Text);
			int antiRangeDractal = (int)(probability * N);
			int rangeFractal = (int)((1 - probability) * N);
			int range = rangeFractal;
			double[,,] gazon = new double[N, N, N];
			Random RRR = new Random();
			int i = 0;
			bool isBlack = true;
			while (i < (N - 1) * N)
			{
				for (int j = 0; j < RRR.Next(range); j++)
				{
					int x = i / N;
					int y = i % N;
					if (isBlack)
					{
						gazon[y, x, 0] = 1;
					}
					else
					{
						gazon[y, x, 0] = 0;
					}
					i++;
				}
				if (isBlack)
				{
					isBlack = false;
					range = antiRangeDractal;
				}
				else
				{
					isBlack = true;
					range = rangeFractal;
				}
			}
			values = new double[N, N];
			for (int k = 0; k < N; k++)
			{
				for (int l = 0; l < N; l++)
				{
					if (gazon[k, l, 0] > p)
					{
						values[k, l] = 1;
					}
				}
			}
			return gazon;
		}

		public double[,,] GenerateFractaleVertical(int N, double probability)
		{
			double p = Convert.ToDouble(textBoxProbability.Text);
			int antiRangeDractal = (int)(probability * N);
			int rangeFractal = (int)((1 - probability) * N);
			int range = rangeFractal;
			double[,,] gazon = new double[N, N, N];
			Random RRR = new Random();
			int i = 0;
			bool isBlack = true;
			while (i < (N - 1) * N)
			{
				for (int j = 0; j < RRR.Next(range); j++)
				{
					int x = i / N;
					int y = i % N;
					if (isBlack)
					{
						gazon[x, y, 0] = 1;
					}
					else
					{
						gazon[x, y, 0] = 0;
					}
					i++;
				}
				if (isBlack)
				{
					isBlack = false;

					range = antiRangeDractal;
				}
				else
				{
					isBlack = true;

					range = rangeFractal;
				}
			}
			values = new double[N, N];
			for (int k = 0; k < N; k++)
			{
				for (int l = 0; l < N; l++)
				{
					if (gazon[k, l, 0] > p)
					{
						values[k, l] = 1;
					}
				}
			}
			return gazon;
		}

		public void ART(double[,,] gaz, double p, int N) //метод рисования 
		{
			Graphics gr;
			Bitmap bmp;
			bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			gr = Graphics.FromImage(bmp);
			var pen_1 = new Pen(Color.Black);
			var brush = new SolidBrush(Color.Black);

			var WidthN = pictureBox1.Width / N;
			var HeightN = pictureBox1.Height / N;

			for (int i = 0; i < N; i++) //рисуем сетку
			{
				gr.DrawLine(pen_1, WidthN * i, 0, WidthN * i, pictureBox1.Height);
				gr.DrawLine(pen_1, 0, HeightN * i, pictureBox1.Width, HeightN * i);
				for (int j = 0; j < N; j++)
				{
					if (gaz[i, j, 0] < p)
					{
						gr.FillRectangle(brush, i * HeightN, j * WidthN, HeightN, WidthN);//рисуем квадратики
					}
				}
			}

			pictureBox1.Image = bmp;
		}

		public void GenerateFractaleULTRA(int N, double probability)
		{
			fractale = new ListOfParticle(N, pictureBox1, probability);
			timer1.Start();
			button1.Enabled = false;
		}

		private void timer1_Tick(object sender, EventArgs e) //для фрактала
		{
			if (fractale.CheckingIsAllShips())
			{
				timer1.Stop();
				button1.Enabled = true;
				int N = Convert.ToInt32(textBoxNumers.Text);
				double p = Convert.ToDouble(textBoxProbability.Text);
				values = new double[N, N];
				int i = 0;
				foreach (var item in fractale.ParticleList) //тут немного 💩кода
				{
					i++;
					if (item.IsShip)
					{
						int k = i / N;
						int l = i % N;
						values[k, l] = 1;
					}
				}

			}
			Graphics gr;
			Bitmap bmp;
			bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			gr = Graphics.FromImage(bmp);
			var pen_1 = new Pen(Color.Black);
			var brush = new SolidBrush(Color.Black);

			var WidthN = pictureBox1.Width / fractale.N;
			var HeightN = pictureBox1.Height / fractale.N;

			for (int i = 0; i < fractale.N; i++) //рисуем сетку
			{
				gr.DrawLine(pen_1, WidthN * i, 0, WidthN * i, pictureBox1.Height);
				gr.DrawLine(pen_1, 0, HeightN * i, pictureBox1.Width, HeightN * i);
			}
			foreach (var item in fractale.ParticleList) //тут немного 💩кода
			{
				gr.FillRectangle(brush, item.X * WidthN, item.Y * HeightN, HeightN, WidthN);
			}
			pictureBox1.Image = bmp;

			fractale.MoveAll();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			button2.Enabled = false;
			data = Initialisation();
			timer2.Start();
		}

		public double[,] Initialisation() //делаем массив температур
		{
			var T1 = Convert.ToInt32(textBoxTopTemperature.Text);
			var T2 = Convert.ToInt32(textBoxBotTemperature.Text);
			Random r = new Random();
			int Tmax;
			int Tmin;
			if (T1 > T2)
			{
				Tmax = T1;
				Tmin = T2;
			}
			else
			{
				Tmax = T2;
				Tmin = T1;
			}

			int N = Convert.ToInt32(textBoxNumers.Text);
			double[,] Temperature = new double[N, N];
			for (int i = 0; i < N; i++)
			{
				Temperature[0, i] = Tmax;
				Temperature[N - 1, i] = Tmin;
				for (int j = 2; j < N; j++)
				{
					Temperature[N - j, i] = (r.NextDouble() * (Tmax - Tmin)) + Tmin;
					//Temperature[N - j, i] = Tmin;
				}
			}


			return Temperature;
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			int N = Convert.ToInt32(textBoxNumers.Text);
			double lyam = Convert.ToDouble(textBoxLyambda.Text);
			double k, kiplus, kjplus;

			for (int i = 1; i < N - 1; i++)
			{
				for (int j = 1; j < N - 1; j++)
				{
					if (values[i, j] == 1)
					{
						k = 1;
					}
					else
					{
						k = lyam;
					}
					if (values[i + 1, j] == 1)
					{
						kiplus = 1;
					}
					else
					{
						kiplus = lyam;
					}
					if (values[i, j + 1] == 1)
					{
						kjplus = 1;
					}
					else
					{
						kjplus = lyam;
					}
					//old
					data[i, j] = (data[i - 1, j] + data[i + 1, j] + data[i, j - 1] + data[i, j + 1]) / 4;
					
					//data[i, j] = ((kiplus - k) * (data[i + 1, j] - data[i - 1, j]) / 2) + (((kjplus - k) * (data[i, j - 1] - (data[i - 1, j - 1] / 2)))
					//	- (k * data[i - 1, j]) - (k * data[i + 1, j]) - (k * data[i, j - 1]) - (k * data[i, j + 1]) / (4 * k));
				}
			}

			Draw();
		}

		private void Draw()
		{
			double Tmiddle = 0;
			int countKKK = 0;
			var T1 = Convert.ToInt32(textBoxTopTemperature.Text);
			var T2 = Convert.ToInt32(textBoxBotTemperature.Text);
			var N = Convert.ToInt32(textBoxNumers.Text);
			int max;
			int min;
			if (T1 > T2)
			{
				max = T1;
				min = T2;
			}
			else
			{
				max = T2;
				min = T1;
			}


			Graphics gr;
			Bitmap bmp;
			bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
			gr = Graphics.FromImage(bmp);
			var WidthN = pictureBox2.Width / N;
			var HeightN = pictureBox2.Height / N;

			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
					// Вычисляем цвет пикселя на основе значения элемента массива
					double value = data[i, j];
					int shade = (int)(value / max * 255);
					Color color = Color.FromArgb(shade, 0, 0);
					var brush = new SolidBrush(color);
					gr.FillRectangle(brush, i * HeightN, j * WidthN, HeightN, WidthN);//рисуем квадратики
					Tmiddle += value;
					countKKK++;
				}
			}

			Tmiddle = Tmiddle / (countKKK * (max - min));
			button3.Text = Tmiddle.ToString() ;

			pictureBox2.Image = bmp;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			data = Initialisation();

			Draw();
		}
	}


}