﻿using Csharp_study;

class Program
{
    static void Main(string[] args)
    {
        IAbstractFactory BF = new BlueFactory();
        IAbstractFactory YF = new YellowFactory();
        IAbstractBalloon BB = BF.Create();
        IAbstractBalloon YB = YF.Create();
        Console.WriteLine(YB.color);
        Console.WriteLine(BB.color);
    }
}