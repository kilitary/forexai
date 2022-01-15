using System.Reflection;

namespace FinancePermutator.Generators
{
	internal static class Methods
	{
		public static MethodInfo GetRandomMethod(int randomSeed)
		{
			return Data.TALibMethods[XRandom.Next(Data.TALibMethods.Count - 1)];
		}
	}
}