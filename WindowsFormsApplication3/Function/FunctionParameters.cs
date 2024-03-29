﻿using FinancePermutator.Generators;
using FinancePermutator.Prices;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace FinancePermutator
{
	internal class FunctionParameters
	{
		public int ParamIndex;
		public int NumData;
		public int OutBegIdx = 0;
		public int Offset;

		//public double[] OutReal = new double[1000];
		public List<string> parametersMap;

		public object[] Arguments;
		public int OutIndex { get; }
		public int OutNbElement { get; }

		/*░░ ♡ ▄▀▀▀▄░░░
			▄███▀░◐░░░▌░░░░░░░
			░░░░▌░░░░░▐░░░░░░░
			░░░░▐░░░░░▐░░░░░░░
			░░░░▌░░░░░▐▄▄░░░░░
			░░░░▌░░░░▄▀▒▒▀▀▀▀▄
			░░░▐░░░░▐▒▒▒▒▒▒▒▒▀▀▄
			░░░▐░░░░▐▄▒▒▒▒▒▒▒▒▒▒▀▄
			░░░░▀▄░░░░▀▄▒▒▒▒▒▒▒▒▒▒▀▄
			░░░░░░▀▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▀▄ <<<---.
			░░░░░░░░░░░▌▌░▌▌░░░░░
			░░░░░░░░░░░▌▌░▌▌░░░░░
			░░░░░░░░░▄▄▌▌▄▌▌░░░░░*/

		public FunctionParameters(MethodInfo methodInfo, int numdata, int offset)
		{
			NumData = numdata;
			Offset = offset;
			parametersMap = new List<string>();

			// DumpParams(methodInfo);
			Arguments = new object[methodInfo.GetParameters().Length];

			// debug($"function method {methodInfo.Name} offset {offset} numdata {NumData} randomSeed {randomSeed}");
			foreach (var param in methodInfo.GetParameters())
			{
				var paramComment = string.Empty;
				switch (param.Name)
				{
					case "optInVFactor":
						Arguments[ParamIndex] = 0;
						break;

					case "outMACDSignal":
						Arguments[ParamIndex] = 0;
						break;

					case "outMACDHist":
						Arguments[ParamIndex] = 0;
						break;

					case "outMin":
						Arguments[ParamIndex] = 0;
						break;

					case "optInNbDevUp":
						Arguments[ParamIndex] = 0.0;
						break;

					case "outMACD":
						Arguments[ParamIndex] = 0.0;
						break;

					case "outLeadSine":
						Arguments[ParamIndex] = 0.0;
						break;

					case "outSine":
						Arguments[ParamIndex] = 0.0;
						break;

					case "optInMinPeriod":
					case "optInMaxPeriod":
					case "optInSignalPeriod":
						Arguments[ParamIndex] = MaTypeGen.GetRandom();
						paramComment = $"MaTypeGen";

						// debug($"{param.Name} optInSignalPeriod=" + arguments[paramIndex]);
						break;

					case "optInMAType":
						Arguments[ParamIndex] = MaTypeGen.GetRandom();
						paramComment = $"MaTypeGen";

						// debug($"{param.Name} optInMAType=" + arguments[paramIndex]);
						break;

					case "optInNbDev":
						Arguments[ParamIndex] = 0.0;
						break;

					case "inReal0":
					case "inReal1":
					case "inReal":
						switch (XRandom.Next(3))
						{
							case 0:
								Arguments[ParamIndex] = ForexPrices.GetOpen(NumData, Offset);
								paramComment = $"Open {NumData}";
								break;

							case 1:
								Arguments[ParamIndex] = ForexPrices.GetClose(numdata, Offset);
								paramComment = $"Close {NumData}";
								break;

							case 2:
								Arguments[ParamIndex] = ForexPrices.GetHigh(NumData, Offset);
								paramComment = $"High {NumData}";
								break;

							case 3:
								Arguments[ParamIndex] = ForexPrices.GetLow(NumData, Offset);
								paramComment = $"Low {NumData}";
								break;
						}

						// debug($"real {param.Name}[0]: " + ((double[])Arguments[ParamIndex])[0]);
						break;

					case "optInMaximum":
						Arguments[ParamIndex] = 0.0;
						break;

					case "optInSlowD_MAType":
					case "optInFastD_MAType":
					case "optInSlowK_MAType":
						Arguments[ParamIndex] = MaTypeGen.GetRandom();
						paramComment = $"MaTypeGen";

						// debug($"{param.Name} optMAtype=" + arguments[paramIndex]);
						break;

					case "optInAccelerationShort":
					case "optInAccelerationMaxShort":
					case "optInAccelerationInitShort":
					case "optInAccelerationMaxLong":
					case "optInAccelerationLong":
					case "optInAccelerationInitLong":
					case "optInAcceleration":
						Arguments[ParamIndex] = 0.0;
						break;

					case "optInOffsetOnReverse":
						Arguments[ParamIndex] = 0;
						break;

					case "optInSlowK_Period":
					case "optInFastK_Period":
					case "optInSlowD_Period":
					case "optInFastD_Period":
						Arguments[ParamIndex] = MaGen.GetRandom(NumData);
						paramComment = $"MaTypeGen";
						break;

					case "optInSlowPeriod":
						Arguments[ParamIndex] = XRandom.Next(Convert.ToInt32(NumData / 2) + 1, NumData - 1);
						break;

					case "optInFastPeriod":
						Arguments[ParamIndex] = MaGen.GetRandom(Convert.ToInt32(NumData / 2));
						break;

					case "optInTimePeriod":
						Arguments[ParamIndex] = 2;
						break;

					case "optInTimePeriod1":
					case "optInTimePeriod3":
					case "optInTimePeriod2":
						Arguments[ParamIndex] = MaGen.GetRandom(NumData);
						break;

					case "optInPenetration":
						Arguments[ParamIndex] = 0;
						break;

					case "optInStartValue":
						Arguments[ParamIndex] = 0;
						break;

					case "startIdx":
						Arguments[ParamIndex] = 0;
						break;

					case "endIdx":
						Arguments[ParamIndex] = NumData - 1;
						break;

					case "inOpen":
						Arguments[ParamIndex] = ForexPrices.GetOpen(NumData, Offset);
						paramComment = $"Open {NumData}";
						break;

					case "inHigh":
						Arguments[ParamIndex] = ForexPrices.GetHigh(NumData, Offset);
						paramComment = $"High {NumData}";
						break;

					case "inLow":
						Arguments[ParamIndex] = ForexPrices.GetLow(NumData, Offset);
						paramComment = $"Low {NumData}";
						break;

					case "inClose":
						Arguments[ParamIndex] = ForexPrices.GetClose(NumData, Offset);
						paramComment = $"Close {NumData}";
						break;

					case "inVolume":
						Arguments[ParamIndex] = ForexPrices.GetVolume(NumData, Offset);
						paramComment = $"Volume {NumData}";
						break;

					case "outBegIdx":
						Arguments[ParamIndex] = OutBegIdx;
						break;

					case "outNBElement":
						Arguments[ParamIndex] = OutNbElement;
						OutNbElement = ParamIndex;
						break;

					case "outInteger":
						Arguments[ParamIndex] = new int[NumData];
						OutIndex = ParamIndex;
						break;

					case "outReal":
						Arguments[ParamIndex] = new double[NumData];
						OutIndex = ParamIndex;
						break;

					case "outAroonUp":
						Arguments[ParamIndex] = new double[1000];
						break;

					case "outAroonDown":
						Arguments[ParamIndex] = new double[1000];
						break;

					case "outSlowD":
					case "outSlowK":
					case "outFastD":
					case "outFastK":
						Arguments[ParamIndex] = new double[1000];
						break;

					default:
						Tools.debug($"nothing found for {param.Name}");
						break;
				}

				parametersMap.Add($"{ParamIndex}|{param.Name}|{Arguments[ParamIndex]}|{paramComment}");
				ParamIndex++;
			}
		}

		private void DumpArguments()
		{
			var argIdx = 0;

			Tools.debug($"arguments: {Arguments.Length}");

			foreach (object o in Arguments)
				if (o != null)
					Tools.debug($" +arg{argIdx++,-2:00} {o.GetType()} {o}");
		}

		private static void DumpParams(MethodInfo methodInfo)
		{
			var idx = 0;

			foreach (ParameterInfo pi in methodInfo.GetParameters())
				Tools.debug($" prm{idx++,2:00} {pi.ParameterType} {pi.Name}");
		}
	}
}