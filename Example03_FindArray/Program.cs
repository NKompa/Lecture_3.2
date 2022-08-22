// В массиве array с количеством элементов n нужно найти элемент find и указать его индекс. Find вводится произвольно.
int[] array = { 178, 20, 34, 45, 82, 65, 26, 73, 82 };
int n = array.Length;
int find = 26;
int index = 0;

while(index <n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
