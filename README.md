![photo-original.png](https://bitbucket.org/repo/64RkKMg/images/1704156120-photo-original.png) 
# Wel**com***e* #



## Принцип работы ##

**С**истема занимаеться подбором параметров для математических функций TA-LIB так, што в итоге применонные к прайсам функции позволяют **классифицировать ситуацию** на ближайшие 5-10 минут вперед.
Система не являеться предсказателем, во всяком случае я отказался от этой идеи так как это требует еще большие массивы данных и мощности. Она (cеть), являеться **классификатором** 3-х классов. 
```
1) ситуация удобна для SELL
2) ситуация удобна для BUY
3) сеть не уверена ни в какой ситуации, вы можете оценить выходку сети и/или использовать (например) мартингейл.
```

## Логика программы ##

Как известно на рынке торгуют используя какието стратегии. Самый простейший вариант торговли вручную это вход в рынок (BUY/SELL) при срабатывании какогонибудь условия, к примеру Avg(HIGH) < Avg(HIGH-5). Реальные стратегии могут иметь более 5 таких разных условий. Это **логический** способ торговли, где вы можете расставить все условия как **IF/ELSE**. Не будем трогать фундаментальный анализ, он нам не нужен. Параметры рынка даны в каждый тик времени и определяються так : High/Low/Open/Close и еще Vol (volume, обьём. правда я так и не понял чего, скорее всего торгов).
Так как рынок на 60% представляет из себя автоматически торгующий софт, не трудно догадаться што большие обьемы запросов к рынку будет выполнен при одинаковых условиях. Например у нас есть 100 разных ботов которые торгуют по пробитию Bollinger Bands (актуально кстати). Таким образом при срабатывании условия на рынок сразу поступит 100 запсрово buy или sell. Рынок отреагирует на это изменением цены, а следовательно мы это увидим на графике как подьём или спад бара. Ситуации к этому приводящие трудно увидеть невооруженным глазом или используя обычный арсенал MT4. Для этого и существуют библиотеки анализа маркета. При натравливании их на текущие прайсы, спустя какоето время (да, для некоторых функций нужно время, мы не сможем например получить четкий ответ если функция еще недособирала информации.) они выдают результат в виде плавных графиков или баров если это cdl\* функции. 

## Задача сети ##

**С**еть должна анализировать ситуации приводящие к изменению бара. Это просто звучит, но на деле это очень большое кол-во ниточек которые надо распутать, и распутываються они с большим количеством данных для тренировок (а также параметрами тренировки, но это уже потом будем проходить). Пустив на вход сети  данные анализа прайсов 
(пока абстрагируемся от топологии и схемы самих данных) мы приближаем сеть к возможности различать мелкие или неочень изменения, приводящие к изменению бара. А теперь вернемся в прошлое на один абзац назад. 100 ботов увидело што bollinger bands пробит на 0.00200 пунктов (эт много кстати), и после этого на измерительной сетке следующий бар упал вниз или поднялся вверх. Это происходит десятки раз за 5-минутный график например на GBPUSD (там высокая волатильность, т.е. он быстро и значительно меняеться со временем, противоположник flat). Сеть, подкрутив свои весы для подгона выходных желаемых к выходным реальным данным запоминает што за 4 бара до этого были такието действия. Это повторяеца тысячи (и даже миллионы) раз, за так называемую **эпоху**, когда данные вновь и вновь поступают на вход сети для подкрутки весов. Итак, она увидела какие это были изименения спустя тысячу, две эпох. Следовательно такая натренированная сеть увидев эти данные снова сможет сказать нам што щаз будет тото-тото. Еще проще: ваша жина смотрит на часы, приближаеться время вашего прихода, и вы есно после работки хотите пожрать, и есно она это знает и начинает готовить вам жрачку; вы вчера ели мясо и жена знает што вы не любите повторять ся, и готовит вам пюре с котлетками. Так вот то што вы - приходите это и есть то што запомнила нейросеть жены; если у неё есть мозг. А то што она готовит это выходные данные, для вас. Еще ситуасьён: вы знаете што тачка при более 180км/ч начинает разваливаться на части (девятка например), поэтому што вы делаете? вы не разгоняетесь до 180 а ездите безопасно на 100-120км/ч. Так вот то што вы знаете - получено это опытом или нет, неважно - являеться причиной того што вы ездите на 100-120 км/ч, так сказать выходные данные вашего мозга при разборе вопроса о скорости. Непонятно? ну тогда я х3. смотрите моднявые на данный момент касты про AI, коих последние 4 года появилось тысячи (пожалуйста)

## Способ FANN+TA-LIB ##

Мы можем иметь жену штобы управлять ею для готовки. А она может наблюдать за другой, штобы  научиться быть хорошей женой и понимать што надо готовить свежую еду, а не вечернюю вчераприготовленную жрать. Блять почему жена? Эшкере конечно , но малоли этот текст будет читать Mike или CodeMonkey и они разьебут нахуй свои мониторы, снова вспомнив этот флейм пятничный на IRC: do you want fuck my wife?. Просто. Так вот, смотрит она такая и видит... ага..... муш пришел и  унего жрачка готова, сделано за 2 часа до прихода. И он доволен они короче сидят ужинают веселяться, анекдоты рассказывают про вовочку и прочее. А потом даже ебуца. Следовательно обьект удовлетворён значит надо повторить этиже действия с другим обьектом, штобы достигнуть результата. Разберем всё по параметрам: в задаче есть жена - X, муж - Y, еда - Z, время до прихода - Q, радость мужа - W. и всё. Так вот аш простая агентская система получилась, с поощрениями. <- Это вариант **логического подхода**, когда мы знаем какието условия или пересечения условий. В случае же с нейросетями обычный подход разрабатываеться путем скурпулезных математических расчетов для выбора функций, их параметров и очередности для того штобы всё это "converge"-валось, т.е. давало результат функции такой, какой предписан математическими расчетами. Но мы - будем использовать рандом для всего этого. Сначало это был просто тестовый проект который показывал 60% успеха. Это значит што из 100% мы сделали только 10%. Просто потому што странно (?), но рандом - всегда будет показывать 50% попаданий. Если он другой - или у вас цру на компутере переделало рандом или вы вообще написали свою бредовую рандом функцию. Не надо так. Так вот, мы полностью автоматизируем этот процесс. У нас есть функции TA-LIB, мы знаем их параметры и диапазоны значений (todo:validate). Будем брать рандомную функцию, вставлять её в нашу сетку параметров, попутно рандомно применяя параметры функции. Это было бы нереально во времена x486 компутеров, но щаз у нас уже есть мощности штобы это делать. Я не говорю даже еще про клоуд-компутинг... Так вот, мы создаем линейку функций и их параметров для входа в сеть до тех пор, пока тест этой сети не будет показывать нам нужную процентность попадания. На данный момент потолок который я видел это 91%. 
Што мы рандомизируем:
```
1) кол-во функций
2) саму функцию avg/STOCH/MOM/....
3) параметры этой функции
4) очередность функции
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

Так как я идиот в матане буду писать как врач.
**С**ама сеть, скорее всего находит паттерны, повторяющиеся от 10 и более раз. При обучении используеться история операций за год, но можно и больше. Самые значимые паттерны создают автоматические боты, торгующие в сети с/без участия человека, но возможны и другие условия. Поэтому к примеру, брать за период последние 5 лет нету смысла, так как 3 года назад автоматические боты только стали внедряться в торговлю без участия человека.

## Библиотека T**A**-LI**B** ##

Это библиотека анализа для маркета. Список функций: https://www.ta-lib.org/function.html. Описание там скудное, но зато всё есть в Visual Studio если открыть этот reference. Есть нормальное описание на PHP-шном сайте: http://php.net/manual/ru/book.trader.php. Я както нарыл какието лохмотья документации (правда с интересной инфой): https://ta-lib.org/d_api/ У меня есть подозрение што функции свечей cdl\* не работают так как надо, либо я чтото непонимаю, проверяльщик данных в ForexAI отсекает их если они выводят бредовый результат. Результат бредовый распознаеца (и не только для cdl*) в следующих случаях:

```
1) для одинаковых длин входящих данных из массива, функция выдаёт разные длины даблов. Например у нас массив из 10 массивов даблов. Из них первая длиной 120 даблов, а вторая например 130. Это неправильно, отсекаем такое.
2) функция выдаёт одно и тоже число для всего массива, например все тройки или первая единица а потом все тройки.
3) выход функции всегда 0, независимо от входных данных.
4) value = INFINITE или value = NaN
```

## Библиотека нейросети FANN ##

Это библиотека для создания, обучения и тестирования нейросетей. Насколько я понимаю это multilayer feedforward сети. Многослойные (3 и более) сети могут быть SHORTCUT и STANDART типов (только на c#, на c++ есть еще варианты). Библиотека поддерживает крутые методы тренировок (актуально на 2016): **RPROP**, Quickprop, Batch, Incremental и даже **Simulated Annealing** (! который отлично работает в c++, но упорно не хочет работать в c#). 

Инфо: https://en.wikipedia.org/wiki/Fast_Artificial_Neural_Network

Оригинал: http://leenissen.dk/fann/wp/

**C**# коннектор: http://joelself.github.io/FannCSharp/files/NeuralNetFloat-cs.html


[**dis**connect]

♥