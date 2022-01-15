using FANNCSharp;

namespace FinancePermutator
{
	public static class Configuration
	{
		public static string PriceFileName = @"c:\forexAI\GBPUSD5.csv";
		public static string LogFileName = @"c:\forexAI\forexAI.log";
		public static string TempPath = "%TEMP%";
		public static int maxInputDimension = 255;
		public static float MinSaveTestMSE = 0.01f;
		public static float MinSaveHit = 80f;
		public static int MinSaveEpoch = 60;
		public static int MinTaFunctionsCount = 2;
		public static int TestDataAmountPerc = 15;
		public static int TrainLimitEpochs = 455;
		public static uint DefaultHiddenNeurons = 0;
		public static float startSarTemp = 150.9f;
		public static float heatDelta = 0.999f;
		public static int SleepTime = 300;
		public static int SleepCheckTime = 10000;
		public static string path = @"F:\projects\forexai\WindowsFormsApplication3\";
		public static int OutputIndex = 15;
		public static TrainingAlgorithm TrainAlgo = TrainingAlgorithm.TRAIN_SARPROP; //TRAIN_QUICKPROP
	}
}