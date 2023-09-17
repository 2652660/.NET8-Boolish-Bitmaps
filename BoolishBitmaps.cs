class BoolishBitmaps
{
    public static bool[][] LeftApexTriangle(int Xl, int Yl, bool YReflect  = false)
	{
		bool[][] BoolMap = new bool[Yl][];
		int Ym = (int)Math.Floor((decimal)((Yl - 1) / 2));
		for (int Y = 0; Y < Yl; Y++)
		{
			BoolMap[Y] = new bool[Xl];
			for (int X = 0; X < Xl; X++)
			{
				BoolMap[Y][X] = (Ym > Y && (Ym - Y) <= X) || (Ym < Y && Math.Abs(Yl - Ym - Y) < X) || (Ym == Y);
			}

			if (YReflect)
			{
				BoolMap[Y] = BoolMap[Y].Reverse().ToArray();
			}
		}

		return BoolMap;
	}
}
