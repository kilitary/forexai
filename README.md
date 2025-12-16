![photo-original.png](https://bitbucket.org/repo/64RkKMg/images/1704156120-photo-original.png) 
# Welcome to ForexAI #



## Operating Principle ##

The **system** focuses on parameter tuning for mathematical functions from [TA-LIB](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/Function/Function.cs) so that the functions applied to price data allow **situation classification** for the next 5-10 minutes ahead.

The system is not a predictor - at least I abandoned this idea since it requires even larger data arrays and computational power. The [neural network](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/Networks/Network.cs) is a **classifier** of 3 classes: 
```
1) situation suitable for SELL
2) situation suitable for BUY  
3) network is uncertain about the situation, you can evaluate the network's output and/or use (for example) martingale.
```

## Program Logic ##

As known, trading in the market uses various strategies. The simplest manual trading variant is market entry (BUY/SELL) when some condition triggers, for example Avg(HIGH) < Avg(HIGH-5). Real strategies can have more than 5 such different conditions. This is a **logical** trading approach where you can arrange all conditions as **IF/ELSE** statements. Let's not touch fundamental analysis - we don't need it. Market parameters are given at each time tick and are defined as: High/Low/Open/Close and also Vol (volume, though I never quite understood what exactly, most likely trading volume).

Since the market is 60% automated trading software, it's not hard to guess that large volumes of market requests will be executed under the same conditions. For example, we have 100 different bots trading on Bollinger Band breakouts (quite relevant, by the way). Thus, when the condition triggers, 100 buy or sell requests immediately hit the market. The market will react with price changes, which we'll see on the chart as a bar rise or fall. The situations leading to this are hard to see with the naked eye or using the usual MT4 arsenal. This is why market analysis libraries exist. When applied to current prices, after some time (yes, some functions need time - we can't get a clear answer if the function hasn't collected enough information yet), they produce results as smooth charts or bars for cdl* functions.

## Network Task ## 

The **network** is capable of analyzing situations that lead to bar changes. This sounds simple, but in practice it involves a huge number of threads that need to be unraveled, and they are unraveled with large amounts of training data (as well as training parameters, but we'll cover that later). By feeding price analysis data to the network input (abstracting from the topology and data schema for now), we bring the network closer to being able to distinguish small or not-so-small changes that lead to bar changes. 

Now let's go back one paragraph. 100 bots saw that Bollinger bands were broken by 0.00200 points (that's a lot, by the way), and after that on the measuring grid, the next bar fell down or rose up. This happens dozens of times on a 5-minute chart, for example on GBPUSD (high volatility there - it changes quickly and significantly over time, opposite of flat). The network, adjusting its weights to fit the desired outputs to actual output data, remembers what actions occurred 4 bars before this. This repeats thousands (even millions) of times during a so-called **epoch**, when data repeatedly flows to the network input for weight adjustment. So, after thousands or two thousand epochs, it learned what these changes were. Consequently, such a trained network, seeing this data again, can tell us what will happen next.

Even simpler analogy: your wife looks at the clock, your arrival time approaches, and naturally after work you want to eat, and naturally she knows this and starts cooking for you; yesterday you ate meat and your wife knows you don't like to repeat, so she cooks mashed potatoes with cutlets for you. So what you do - coming home - is what the wife's neural network remembered; if she has a brain. And what she cooks is the output data for you. Another situation: you know that a car starts falling apart at speeds over 180 km/h (a Lada, for example), so what do you do? You don't accelerate to 180 but drive safely at 100-120 km/h. So what you know - whether gained through experience or not, doesn't matter - is the reason you drive at 100-120 km/h, the output data of your brain when processing speed questions. Don't understand? Then I give up. Watch the trendy AI podcasts that have appeared in thousands over the last 4 years (please).

## FANN+TA-LIB Approach ##

We can have a system to manage cooking tasks. The system can observe another to learn how to be efficient and understand that fresh food should be prepared, not yesterday's leftovers. The point is simple observation and learning patterns.

Looking at this approach, when someone arrives and the meal is ready, prepared 2 hours before arrival, the person is satisfied. So we need to repeat these same actions with another subject to achieve the result. Let's break everything down by parameters: in the task there's subject X, subject Y, food Z, time before arrival Q, satisfaction level W. That's it. So we get a simple agent system with rewards. 

This is the **logical approach** variant, when we know certain conditions or condition intersections. In the case of neural networks, the usual approach is developed through meticulous mathematical calculations for selecting functions, their parameters, and sequence so that everything "converges" - i.e., produces function results as prescribed by mathematical calculations. But we will use randomization for all this. Initially, this was just a test project that showed 60% success. This means from 100% we only achieved 10%. Simply because, strangely, random will always show 50% hits. If it's different - either your computer's CPU modified the random function or you wrote your own weird random function.

So, we fully automate this process. We have [TA-LIB functions](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/Function/Function.cs), we know their parameters and value ranges (todo: validate). We take a random function, insert it into our parameter grid, while randomly applying function parameters. This would have been impossible in x486 computer times, but now we have the power to do this. I'm not even talking about cloud computing yet... 

So we create a lineup of functions and their parameters for network input until testing this network shows us the needed hit percentage. Currently, the ceiling I've seen is 91%.

What we randomize (see [parameter generators](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/Generators/)):
```
1) number of functions in the pipeline
2) function algorithm selection: avg/STOCH/MOM/ta*
3) function parameters  
4) function order in pipeline (pipeline can contain from 1 to N input sequences)
5) number of input parameters for function (i.e. how many prices high/low/open... to take), in code this is [InputDimension](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/Configuration.cs#L10)
6) activation function for input layer of neural network
7) activation function for hidden layers of neural network
8) number of neurons in layers
9) additional network parameters based on training algorithm, e.g. LearningRate, percentage of interconnected neurons (Connection Rate), RPROP Step size, Weight Decay, Temperature 
 (if using SARPROP. Regarding cooling or heating, they say the mathematics is exact, but there's conflicting information online about this. Some write about heating, others talk about the original test of this technology with cooling - namely optimal atom distribution in a crystal lattice during cooling, so heating would have the opposite effect, which is roughly understandable. 

But with my math knowledge I can't verify this - I sometimes even thought these were jokes written by someone for some reason. I even found combined temperature technologies, which is also interesting, since I started trying different training technologies in one epoch based on my own imagination).

And many other parameters that we can change, and most importantly, with small changes we can get a truly working network, whereas applying other training methods or drastically changing training data won't work.
```

Simplified scheme:

![mttrainer.jpg](https://bitbucket.org/repo/64RkKMg/images/2966921009-mttrainer.jpg)


## Network ##

As an amateur, I'll write this simply.

The **network** itself most likely finds patterns that repeat 10 or more times. During training, it uses one year of trading history, but more can be used. The most significant patterns are created by automatic bots trading in the network with/without human participation, but other conditions are possible. Therefore, for example, taking the last 5 years as a period makes no sense, since 3 years ago automatic bots were just being introduced to trading without human participation.

## TA-LIB Library ##

This is a market analysis library. Function list: https://www.ta-lib.org/function.html. The description there is sparse, but everything is available in Visual Studio if you open this reference. There's a good description on the PHP site: http://php.net/manual/ru/book.trader.php. I somehow found some documentation fragments (with interesting info though): https://ta-lib.org/d_api/ 

I suspect that candlestick functions cdl* don't work as they should, or I don't understand something. The data validator in [ForexAI](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/Data.cs) filters them out if they produce nonsensical results. A nonsensical result is recognized (not only for cdl*) in the following cases:

```
1) for identical input data array lengths, the function outputs different double lengths. For example, we have an array of 10 double arrays. The first one is 120 doubles long, and the second one is 130. This is incorrect, we filter this out.
2) function outputs the same number for the entire array, e.g. all threes or first one then all threes.
3) function output is always 0, regardless of input data.
4) value = INFINITE or value = NaN
```

## FANN Neural Network Library ##

This is a library for creating, training and testing neural networks. As an amateur (and I'm not claiming to be an expert), as far as I understand these are multilayer feedforward networks. Multi-layer (3 or more) networks can be SHORTCUT and STANDARD types (C# only, C++ has additional variants). The library supports advanced training methods (as of 2016): **RPROP**, Quickprop, Batch, Incremental and even **Simulated Annealing** (! which works excellently in C++, but stubbornly refuses to work in C# - see [Network.cs implementation](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/Networks/Network.cs)). 

Info: https://en.wikipedia.org/wiki/Fast_Artificial_Neural_Network

Original: http://leenissen.dk/fann/wp/

**C**# connector: http://joelself.github.io/FannCSharp/files/NeuralNetFloat-cs.html


[disconnect]

♥

## Current Development Status ##

<details>
<summary>ⁱ</summary>
Так как уважаемый детский насильник-педофил господин Принц Путин развивает науку и искуственный интеллект, борясь за права людей, как с него это часто льеться, я использовал еще один язык (помимо математического, русского, военного английского) который возможно всетаки вставит ему чтонибудь в мозг.
 √
</details>


For the latest development progress and TODO items, see: [todo.txt](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/todo.txt)

## Key Implementation Files ##

- **[MainForm.cs](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/Forms/MainForm.cs)** - Main application interface and user interaction
- **[Network.cs](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/Networks/Network.cs)** - FANN neural network wrapper and training logic
- **[Train.cs](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/Train/Train.cs)** - Training algorithms and parameter optimization  
- **[Function.cs](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/Function/Function.cs)** - TA-LIB technical analysis functions integration
- **[Configuration.cs](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/Configuration.cs)** - Application configuration and parameter settings
- **[Data.cs](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/Data.cs)** - Data validation and processing
- **[Parameter Generators](https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/Generators/)** - Random parameter generation for network optimization
