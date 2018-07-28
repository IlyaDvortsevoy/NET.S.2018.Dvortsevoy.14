## Задачи

1. Разработать класс для имитации часов с обратным отсчетом, реализующий возможность по истечении назначенного времени (время ожидания предоставляется классу пользователем) передавать сообщение и дополнительную информацию о событии любому подписавшемуся на событие типу. Предусмотреть возможность подписки на событие в нескольких классах. Продемонстрировать работу класса в консольном приложении.<br/>
[Логика](https://github.com/IlyaDvortsevoy/NET.S.2018.Dvortsevoy.14/tree/master/CountdownTimer)
[Тесты](https://github.com/IlyaDvortsevoy/NET.S.2018.Dvortsevoy.14/tree/master/CountDownTimerTest)

2. Разработать класс, предоставляющий следующие функциональные возможности : 
   - функцию побайтового копирования содержимого одного тествового файла в другой с использованием класса FileStream в качестве потока с резервным хранилищем; функция должна возвращать количество записанных байт;
   - функцию побайтового копирования содержимого одного тествового файла в другой с использованием класса MemoryStream в качестве потока с резервным хранилищем; функция должна возвращать количество записанных байт; содержимое потока MemoryStream наполняется массивом байт, полученных на основе текстовой информации из файла-источника с помощью класса StreamReader;
   - функцию копирования содержимого одного тествового файла в другой, используя возможности буферизации класса FileStream, функция должна возвращать количество записанных байт;
   - функцию копирования содержимого одного тествового файла в другой, используя возможности класса-декоратора потоков BufferedStream, функция должна возвращать количество записанных байт;
   - функцию копирования содержимого одного тествового файла в другой с использованием класса MemoryStream в качестве потока с резервным хранилищем; функция должна возвращать количество записанных байт; 
   - функцию построчного копирования содержимого одного тествового файла в другой, функция должна возвращать количество записанных строк;
   - функцию сравнения содержимого исходного и полученного файлов.

3. Протестировать работу класса для данного текстового [файла](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M13.%20Streams%20and%20IO/SourceText.txt) в консоли, обратить внимание на содержимое файлов, полученных при копировании с помощью различных методов класса. Результаты проанализировать.

4. Для выполнения задания использовать следующий [проект](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/blob/master/M13.%20Streams%20and%20IO/M13.Streams.Task.7z).

5. Реализовать обобщенный алгоритм бинарного поиска. Разработать unit-тесты.<br/>
[Логика](https://github.com/IlyaDvortsevoy/NET.S.2018.Dvortsevoy.14/tree/master/SearchAlgorithm)
[Тесты](https://github.com/IlyaDvortsevoy/NET.S.2018.Dvortsevoy.14/tree/master/SearchAlgorithm.Tests)

6. Реализовать метод-генератор последовательности чисел Фибоначчи. Разработать unit-тесты.
