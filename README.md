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

We can have a system to manage cooking tasks. The system can observe another to learn how to be efficient and understand that fresh food should be prepared, not yesterday's leftovers. Блять почему жена? Эшкере конечно , но малоли этот текст будет читать Mike или CodeMonkey и они разьебут нахуй свои мониторы, снова вспомнив этот флейм пятничный на IRC: do you want fuck my wife?. Просто. Так вот, смотрит она такая и видит... ага..... муш пришел и  унего жрачка готова, сделано за 2 часа до прихода. И он доволен они короче сидят ужинают веселяться, анекдоты рассказывают про вовочку и прочее. А потом даже ебуца. А потом вообще оказываеца что жена - это - мужик, а ты -  в тайланде. Но оп ус тим эт о. Следовательно обьект удовлетворён значит надо повторить этиже действия с другим обьектом, штобы достигнуть результата. Разберем всё по параметрам: в задаче есть жена - X, муж - Y, еда - Z, время до прихода - Q, радость мужа - W. и всё. Так вот аш простая агентская система получилась, с поощрениями. <- Это вариант **логического подхода**, когда мы знаем какието условия или пересечения условий. В случае же с нейросетями обычный подход разрабатываеться путем скурпулезных математических расчетов для выбора функций, их параметров и очередности для того штобы всё это "converge"-валось, т.е. давало результат функции такой, какой предписан математическими расчетами. Но мы - будем использовать рандом для всего этого. Сначало это был просто тестовый проект который показывал 60% успеха. Это значит што из 100% мы сделали только 10%. Просто потому што странно (?), но рандом - всегда будет показывать 50% попаданий. Если он другой - или у вас цру на компутере переделало рандом или вы вообще написали свою бредовую рандом функцию. Надо так. Так вот, мы полностью автоматизируем этот процесс. У нас есть функции TA-LIB, мы знаем их параметры и диапазоны значений (todo:validate). Будем брать рандомную функцию, вставлять её в нашу сетку параметров, попутно рандомно применяя параметры функции. Это было бы нереально во времена x486 компутеров, но щаз у нас уже есть мощности штобы это делать. Я не говорю даже еще про клоуд-компутинг... Так вот, мы создаем линейку функций и их параметров для входа в сеть до тех пор, пока тест этой сети не будет показывать нам нужную процентность попадания. На данный момент потолок который я видел это 91%. 
Што мы рандомизируем:
```
1) кол-во функций в конвеере
2) выбираем алгоритм функции avg/STOCH/MOM/ta*
3) параметры этой функции
4) очередность функции в конвеере (конвеер может содержать от 1 до nAN сиквенсов входа)
5) кол-во входящих параметров для функции (т.е. сколько брать прайсов high/low/open...), в коде это InputDimension
6) функция активации для входящего слоя нейросети
7) функция активации для промежуточных слоёв нейросети
8) кол-во нейронов в слоях
9) дополнительные параметры сети, отталкивающиеся от алгоритма трейна. например LearningRate, процентность соединенных между собой нейронов (Connection Rate), RPROP Step size, Weight Decoy, Temp 
(если это SARPROP. про охлаждени или подогрев сказать немног о, говорят математика точна. но в инете конфкликтующая между собой информация по этому поводу, ктото пишет про подогрев, ктото говорит про изначальный тест этой технологии при охлаждении а именно оптимальное распределение атомов в кристаллической решетке в момент остывания, тоесть при подогреве будет обратный эффект, даже примерно понятно дураку што другой. 
но мне с моим матаном это не проверить, я даже иногда думал што это по приколу написанные (кемто?нахуя бля??) фейки. я даже находил комбинированные технологии температур, но и это интересно. ведь пробовать разные технологии трейна в одной эпохе я тоже начал по логике собственной фантазии). 
и еще кучу пораметров, которые мы можем изменить и што самое важное, мы маленьким измененим можем получить реально работающую сеть, тогда как применив другие трейны или коренным образом поменяв трейн данные не получим. в00т.
```

Упрощенная схема:

![mttrainer.jpg](https://bitbucket.org/repo/64RkKMg/images/2966921009-mttrainer.jpg)


## Сеть ##

Так как я идиот  буду писать как врач.
**С**ама сеть, скорее всего находит паттерны, повторяющиеся от 10 и более раз. При обучении используеться история операций за год, но можно и больше. Самые значимые паттерны создают автоматические боты, торгующие в сети с/без участия человека, но возможны и другие условия. Поэтому к примеру, брать за период последние 5 лет нету смысла, так как 3 года назад автоматические боты только стали внедряться в торговлю без участия человека.

## Библиотека T**A**-LI**B** ##

Это библиотека анализа для маркета. Список функций: https://www.ta-lib.org/function.html. Описание там скудное, но зато всё есть в Visual Studio если открыть этот reference. Есть нормальное описание на PHP-шном сайте: http://php.net/manual/ru/book.trader.php. Я както нарыл какието лохмотья документации (правда с интересной инфой): https://ta-lib.org/d_api/ У меня есть подозрение што функции свечей cdl\* не работают так как надо, либо я чтото непонимаю, проверяльщик данных в ForexAI отсекает их если они выводят бредовый результат. Результат бредовый распознаеца (и не только для cdl*) в следующих случаях:

```
1) для одинаковых длин входящих данных из массива, функция выдаёт разные длины даблов. Например у нас массив из 10 массивов даблов. Из них первая длиной 120 даблов, а вторая например 130. Это неправильно, отсекаем такое.
2) функция выдаёт одно и тоже число для всего массива, например все тройки или первая единица а потом все тройки.
3) выход функции всегда 0, независимо от входных данных.
4) value = INFINITE или value = NaN
```

## Библиотека  нейросетей FANN ##

Это библиотека для создания, обучения и тестирования нейросетей. Так как я - врач то (а я это не я), то насколько я понимаю это multilayer feedforward сети. Многослойные (3 и более) сети могут быть SHORTCUT и STANDART типов (только на c#, на c++ есть еще варианты). Библиотека поддерживает крутые методы тренировок (актуально на 2016): **RPROP**, Quickprop, Batch, Incremental и даже **Simulated Annealing** (! который отлично работает в c++, но упорно не хочет работать в c#). 

Инфо: https://en.wikipedia.org/wiki/Fast_Artificial_Neural_Network

Оригинал: http://leenissen.dk/fann/wp/

**C**# коннектор: http://joelself.github.io/FannCSharp/files/NeuralNetFloat-cs.html


[d**is**co**nn**e**ct**]

♥

see latest @ https://github.com/kilitary/forexai/blob/main/WindowsFormsApplication3/todo.txt
