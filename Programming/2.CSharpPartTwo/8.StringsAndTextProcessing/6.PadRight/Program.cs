﻿using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        int maxLength = 20;
        char fillCharacter = '*';

        if (str.Length <= maxLength)
            Console.WriteLine(str.PadRight(maxLength, fillCharacter));
    }
}
