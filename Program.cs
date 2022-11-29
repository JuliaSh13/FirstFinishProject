string[] ThreeLengthNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            count++;
    string[] newArray = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    return newArray;
}

string[] strArray = CreateArray();

ShowArray(ThreeLengthNewArray(strArray));

string[] CreateArray() 
{
  Console.Write("Input the length of the array: ");
  int size = Convert.ToInt32(Console.ReadLine());
  string[] array = new string[size];
  Console.WriteLine("Create array: ");
  for (int i = 0; i < size; i++)
  {
    Console.Write($"Input value of the {i + 1} element of the array: ");
    array[i] = Console.ReadLine();
  }
  Console.WriteLine("New array: ");
  return array;
}

void ShowArray(string[] array) 
{
  foreach (var item in array)
    Console.Write(item + " ");
}