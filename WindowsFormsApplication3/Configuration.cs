using FANNCSharp;

namespace FinancePermutator
{
    public static class Configuration
    {
        public static string PriceFileName = @"c:\forexAI\GBPUSD5.csv";
        public static string LogFileName = @"c:\forexAI\forexAI.log";
        public static string TempPath = "%TEMP%";
        public static int maxInputDimension = 128;
        public static double MinSaveTestMSE = 0.02;
        public static double MinSaveHit = 82;
        public static int MinSaveEpoch = 20;
        public static int MinTaFunctionsCount = 2;
        public static int TestDataAmountPerc = 6;
        public static int TrainLimitEpochs = 255;
        public static uint DefaultHiddenNeurons = 0;
        public static float startSarTemp = 25.0f;
        public static float heatDelta = 0.04f;
        public static int SleepTime = 300;
        public static int SleepCheckTime = 10000;
        public static int OutputIndex = 15;
        public static TrainingAlgorithm TrainAlgo = TrainingAlgorithm.TRAIN_SARPROP; //TRAIN_QUICKPROP
    }
}
