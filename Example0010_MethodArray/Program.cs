﻿int [] array = {1, 2, 3, 5, 4, 5, 6, 7, 8};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}