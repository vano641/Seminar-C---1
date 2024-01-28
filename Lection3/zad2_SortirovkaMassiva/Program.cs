int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array) // выводит массив на экран
{
    int count = array.Length;

    for(int i = 0; i < count; i++) // проходим все элементы и записываем их
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // метод который упорядочивает массив
{
    for(int i = 0; i < array.Length - 1; i++) // проходим по всем элементам массива 
    //исключая уже отобранные минимальные элементы array.Length-1
    {
        int minPosition = i; // определяем позицию на которую смотрим minPosition
        // и запоминаем i рабочую позицию элемента который будем менять на минимальный

        for(int j = i + 1; j < array.Length; j++) // ищем минимальный элемент в оставшейся чисти массива
        // то что отсортированно начинается с i+1 позиции
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i]; // рабочюю позицию меняем с наименьшей
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr); // первоначальный вариант массива
SelectionSort(arr);

PrintArray(arr);

