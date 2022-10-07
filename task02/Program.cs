Console.Write($"Введи количество элементов массива: ");
int ElementsNumber = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int ElementsNumber, int min, int max)
  {
  int[] randomNumbers = new int[ElementsNumber];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(ElementsNumber, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");