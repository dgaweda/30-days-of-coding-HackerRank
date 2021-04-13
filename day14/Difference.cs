
using System;

class Difference
{
    private readonly int[] elements;
    public int MaximumDifference;
    private int _temp = 0;

    public Difference(int[] elements)
    {
        this.elements = elements;
    }

    public void ComputeDifference()
    {
        for (var i = 0; i < elements.Length; i++)
        {
            for (var j = i; j < elements.Length; j++)
            {
                _temp = Math.Abs(elements[i] - elements[j]);
                if (_temp > MaximumDifference)
                {
                    MaximumDifference = _temp;
                }
            }
        }
    }
}