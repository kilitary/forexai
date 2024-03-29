﻿using TicTacTec.TA.Library;

namespace FinancePermutator.Generators
{
	internal static class MaTypeGen
	{
		public static Core.MAType GetRandom()
		{
			switch (XRandom.Next(8))
			{
				case 0:
					return Core.MAType.Sma;

				case 1:
					return Core.MAType.Dema;

				case 2:
					return Core.MAType.Ema;

				case 3:
					return Core.MAType.Kama;

				case 4:
					return Core.MAType.Mama;

				case 5:
					return Core.MAType.T3;

				case 6:
					return Core.MAType.Tema;

				case 7:
					return Core.MAType.Trima;

				default:
					return Core.MAType.Wma;
			}
		}
	}
}