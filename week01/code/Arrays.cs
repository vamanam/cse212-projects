using System;
using System.Collections.Generic;

public class Arrays
{
    public static double[] MultiplesOf(double start, int count)
    {
        double[] result = new double[count];

        for (int i = 0; i < count; i++)
        {
            result[i] = start * (i + 1);
        }

        return result;
    }

    public static void RotateListRight(List<int> data, int amount)
    {
        int n = data.Count;
        List<int> rightPart = data.GetRange(n - amount, amount);
        List<int> leftPart = data.GetRange(0, n - amount);

        data.Clear();
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}
