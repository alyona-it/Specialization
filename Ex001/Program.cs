// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]


string[] arrayInput = new string[4] {"1234", "1567", "-2", "computer science"};
string[] arrayOutput = new string[0];
 Console.Write("Дано: ");
    for (int i = 0; i < arrayInput.Length; i++)
        Console.Write($"'{arrayInput[i]}' ");
    for (int i = 0; i < arrayInput.Length; i++)
      {
       if (arrayInput[i].Length < 4)
        {
         Array.Resize(ref arrayOutput, arrayOutput.Length + 1);
         arrayOutput[arrayOutput.Length - 1] = arrayInput[i];
        }
      }
 Console.WriteLine("Ищем элементы массива <= 3 символам: ");
 Console.Write("Результат: ");
 for (int i = 0; i < arrayOutput.Length; i++)
   Console.Write($"'{arrayOutput[i]}' ");
 Console.ReadLine();