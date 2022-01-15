using FANNCSharp;
using FANNCSharp.Double;
using FinancePermutator.Generators;
using Microsoft.AppCenter.Analytics;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static FinancePermutator.Tools;

/*
				░░ ♡ ▄▀▀▀▄░░░
		▄███▀░◐░░░▌░░░░░░░
		░░░░▌░░░░░▐░░░░░░░
		░░░░▐░░░░░▐░░░░░░░
		░░░░▌░░░░░▐▄▄░░░░░
		░░░░▌░░░░▄▀▒▒▀▀▀▀▄
		░░░▐░░░░▐▒▒▒▒▒▒▒▒▀▀▄
		░░░▐░░░░▐▄▒▒▒▒▒▒▒▒▒▒▀▄
		░░░░▀▄░░░░▀▄▒▒▒▒▒▒▒▒▒▒▀▄
		░░░░░░▀▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▀▄
		░░░░░░░░░░░▌▌░▌▌░░░░░
		░░░░░░░░░░░▌▌░▌▌░░░░░
		░░░░░░░░░▄▄▌▌▄▌▌░░░░░*/

namespace FinancePermutator.Networks
{
	internal class Network
	{
		private readonly NeuralNet network;
		public float MSE => network.MSE;
		public uint ErrNo => network.ErrNo;
		public string ErrStr => network.ErrStr;
		public uint BitFail => network.BitFail;
		public bool newNetwork = false;
		private float temperature = Configuration.startSarTemp;

		public double Test(TrainingData testData)
		{
			return network.TestDataParallel(testData, 4);
		}

		public TrainingAlgorithm TrainingAlgorithm
		{
			get => network.TrainingAlgorithm;
			set => network.TrainingAlgorithm = value;
		}

		public float SarpropStepErrorShift
		{
			get => network.SarpropStepErrorShift;
			set => network.SarpropStepErrorShift = value;
		}

		public float SarTemp
		{
			get { return network.SarpropTemperature; }

			set { network.SarpropTemperature = value; }
		}

		public void SetupActivation()
		{
			var activationFunc = ActivationFunction.SIGMOID_SYMMETRIC;
			Program.Form.AddConfiguration($"\r\n InputActFunc i: {activationFunc}");
			network.SetActivationFunctionLayer(activationFunc, 0);
			activationFunc = ActivationFunctionGenerator.GetRandomFunction();
			Program.Form.AddConfiguration($" LayerActFunc m: {activationFunc}");
			network.SetActivationFunctionLayer(activationFunc, 1);
			activationFunc = ActivationFunctionGenerator.GetRandomFunction();
			Program.Form.AddConfiguration($" LayerActFunc o: {activationFunc}");
			network.SetActivationFunctionLayer(activationFunc, 2);

			temperature = Configuration.startSarTemp;
		}

		/*
				\\         //
				 \\     //
				   \\ //
				  (O)
				   //#\\
				 // ### \\
				 //  #####  \\
				  #######
				  ### ###
			  '' """  """"  "'"""""
		*/

		public void SaveNetwork()
		{
			var netDirectory = $"NET_{network.GetHashCode():X}";

			if (!Directory.Exists($"c:\\forexAI\\{netDirectory}"))
				Directory.CreateDirectory($"c:\\forexAI\\{netDirectory}");

			network.Save($@"c:\forexAI\{netDirectory}\FANN.net");

			File.Copy($@"{GetTempPath()}\traindata.dat", $@"c:\forexAI\{netDirectory}\traindata.dat", true);
			File.Copy($@"{GetTempPath()}\testdata.dat", $@"c:\forexAI\{netDirectory}\testdata.dat", true);

			Program.Form.chart.Invoke((MethodInvoker)(() =>
			{
				Program.Form.chart.SaveImage($@"c:\forexAI\{netDirectory}\chart.jpg", ChartImageFormat.Jpeg);

				using (var tw = new StreamWriter($@"c:\forexAI\{netDirectory}\debug.log"))
				{
					foreach (var item in Program.Form.debugView.Items)
						tw.WriteLine(item.ToString());
				}

				using (var cf = new StreamWriter($@"c:\forexAI\{netDirectory}\configuration.txt"))
				{
					cf.WriteLine(Program.Form.configurationTab.Text);
				}

				using (var cf = new StreamWriter($@"c:\forexAI\{netDirectory}\functions.json"))
				{
					cf.WriteLine(JsonConvert.SerializeObject(Data.FunctionConfiguration, Formatting.Indented));
				}
			}));
		}

		public void InitWeights(TrainingData trainData)
		{
			network.InitWeights(trainData);
		}

		public Network(NetworkType layer, uint numInput, uint numHidden, uint numOutput)
		{
			network = new NeuralNet(layer, 3, numInput, numHidden, numOutput);
			debug($"network {network} input: {numInput} numHidden: {numHidden} output: {numOutput}");
		}

		public double Train(TrainingData trainData)
		{
			network.SetScalingParams(trainData, -1.0f, 1.0f, -1.0f, 1.0f);

			var ret = 0.0;

			switch (network.TrainingAlgorithm)
			{
				case TrainingAlgorithm.TRAIN_SARPROP:
					//temperature = (float)(network.SarpropTemperature = (float)temperature / (1.0f + (float)Configuration.heatDelta * (float)temperature));
					network.SarpropTemperature = (temperature *= (float)Configuration.heatDelta);
					debug($"set temp {temperature}");
					//  self.currTemp = self.currTemp / (1 + self.beta * self.currTemp)

					Program.Form.chart.Invoke((MethodInvoker)(() =>
					{
						Program.Form.label3.Text = $"t⁰ {(float)temperature}";
					}));

					ret = network.TrainEpochSarpropParallel(trainData, 4);
					break;

				case TrainingAlgorithm.TRAIN_QUICKPROP:
					ret = network.TrainEpochQuickpropParallel(trainData, 4);
					break;

				case TrainingAlgorithm.TRAIN_RPROP:
					ret = network.TrainEpochIrpropmParallel(trainData, 4);
					break;
			}

			return ret;
		}

		public double[] Run(double[] input)
		{
			double[] outputData = network.Run(input);
			return outputData;
		}

		public void Save(string name)
		{
			debug($"saving network 0x{network.GetHashCode()} as {name}");
			network.Save(name);

			if (newNetwork)
			{
				Analytics.TrackEvent($"New network mined [0x{network.GetHashCode():x}]");
				newNetwork = false;
			}
		}

		internal void SetupScaling(TrainingData trainData)
		{
			network.SetScalingParams(trainData, -1.0f, 1.0f, -1.0f, 1.0f);

			network.RandomizeWeights(-1.0f, 1.0f);
		}
	}
}