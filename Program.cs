// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
/*  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести c клавиатуры, либо
  задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

string[]array (string[]str)
{
    int count=0;
    for (int i=0; i < str.Length; i++)
    {
      if (str[i].Length<4)
      {
        count++;
      }
    }
    string[]ar =new string [count];
    int k=0;
    for (int i=0; i<str.Length; i++)
    {
        if (str[i].Length<4)
        {
            ar[k]=str[i];
            k++;
        }
    }
    return ar;
}
void printArray(string[]array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}, ");   
    }
}
string[] str = {"Москва","Скажи-ка, дядя","дар", "мед","1","253","55"};
string[] ar = array(str);
printArray(ar);